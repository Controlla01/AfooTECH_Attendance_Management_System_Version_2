Imports MySql.Data.MySqlClient
Imports System.IO
Imports DPFP
Imports DPFP.Capture
Imports DPFP.Processing
Imports DPFP.Gui
Imports Guna.UI2.WinForms

Public Class regstudentfingerprint
    Implements DPFP.Capture.EventHandler
    Private defaultFingerImage As Image = My.Resources.istockphoto_519825403_612x612
    Private WithEvents statusResetTimer As New Timer()
    Public passedStudentId As String
    Public passedEmail As String
    Private fingerCount As Integer = 0


    Private WithEvents capturer As DPFP.Capture.Capture
    Private capturedTemplate As DPFP.Template
    Private capturedSample As DPFP.Sample
    Private enroller As DPFP.Processing.Enrollment
    Private studentIdHidden As String
    Dim defaultImagePath As String
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub finishEnrolBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles finishEnrolBtn.Click

        Try

            Dim connection = functions.connection
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM fingerprints_tab WHERE studentId = @studentId"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@studentId", passedStudentId)

            Dim enrolledFingerCount As Integer = Convert.ToInt32(command.ExecuteScalar())
            connection.Close()

            If enrolledFingerCount < 4 Then
                MessageBox.Show("You must enroll at least 4 fingers before finishing!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            If selectFingerComboBox.Items.Count > 0 Then
                selectFingerComboBox.SelectedIndex = 0
            End If


            defaultImagePath = "C:\Users\Michael\Documents\Visual Studio 2010\Projects\AfooTECH_Attendance_Management_System_Version_2\WindowsApplication2\Resources\istockphoto-519825403-612x612.jpg"
            If IO.File.Exists(defaultImagePath) Then
                studentFingerPrintTemplate.Image = Image.FromFile(defaultImagePath)
            Else
                studentFingerPrintTemplate.Image = Nothing
            End If


            enrollStatusLabel.Text = "Click Enroll Button to Begin"

            MessageBox.Show("Enrollment completed successfully!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
            overlay.Show()
            regStudent.Show()

        Catch ex As Exception
            MessageBox.Show("Error checking enrollment status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub regstudentfingerprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            functions.loadFingerOptions()

            If selectFingerComboBox.Items.Count > 0 Then
                selectFingerComboBox.SelectedIndex = 0
            End If

            enrollProgressBar.Minimum = 0
            enrollProgressBar.Maximum = 4
            enrollProgressBar.Value = 0

            If passedStudentId <> "" Then
                Dim result = functions.getStudentProfile(passedStudentId)

                Dim studentId = result.Item1
                Dim emailAddress = result.Item2
                Dim arrimage() As Byte = result.Rest.Item1
                Dim mstream As New MemoryStream(arrimage)
                studentProfilePic.Image = Image.FromStream(mstream)

                emailAddressTxt.Text = emailAddress
                emailAddressTxt.ReadOnly = True
                studentIdHidden = passedStudentId
            End If

            Dim totalCount = functions.allCounts()
            totalStudentCountLabel.Text = totalCount.Item2.ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading fingerprint form: " & ex.Message)
        End Try
    End Sub

    Private Sub startEnrollBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startEnrollBtn.Click
        If selectFingerComboBox.Text = "SELECT FINGER" OrElse selectFingerComboBox.Text = "" Then
            MessageBox.Show("Please select the student's finger to enroll.", "Warning")
            SafeUpdateLabel(enrollStatusLabel, "Click Enroll Button To Begin", Color.Red)
            Exit Sub
        End If

        Try
            capturer = New DPFP.Capture.Capture()
            If capturer Is Nothing Then
                SafeUpdateLabel(enrollStatusLabel, "Fingerprint reader not detected.", Color.Red)
                Return
            End If

            capturer.EventHandler = Me
            enroller = New DPFP.Processing.Enrollment()
            capturer.StartCapture()

            SafeUpdateLabel(enrollStatusLabel, "Scan your finger...", Color.DarkGreen)
            SafeUpdateProgressBar(enrollProgressBar, 0)
        Catch ex As Exception
            SafeUpdateLabel(enrollStatusLabel, "Error starting capture: " & ex.Message, Color.Red)
        End Try
    End Sub
    ' Cross-thread safe UI helpers
    Private Sub SafeUpdateLabel(ByVal label As Label, ByVal text As String, ByVal color As Color)
        If label.InvokeRequired Then
            label.Invoke(Sub()
                             label.Text = text
                             label.ForeColor = color
                         End Sub)
        Else
            label.Text = text
            label.ForeColor = color
        End If
    End Sub

    Private Sub SafeUpdateImage(ByVal box As PictureBox, ByVal img As Bitmap)
        If box.InvokeRequired Then
            box.Invoke(Sub() box.Image = img)
        Else
            box.Image = img
        End If
    End Sub

    Private Sub SafeUpdateProgressBar(ByVal progress As Guna2ProgressBar, ByVal value As Integer)
        If progress.InvokeRequired Then
            progress.Invoke(Sub() progress.Value = value)
        Else
            progress.Value = value
        End If
    End Sub

    Public Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        'capturedSample = Sample
        Dim bitmap As Bitmap = ConvertSampleToBitmap(Sample)
        SafeUpdateImage(studentFingerPrintTemplate, bitmap)
        SafeUpdateProgressBar(enrollProgressBar, 100)

        Dim features = ConvertSampleToFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)
        If features IsNot Nothing Then
            'Try
            enroller.AddFeatures(features)

            If enroller.TemplateStatus = DPFP.Processing.Enrollment.Status.Ready Then
                capturedTemplate = enroller.Template
                SafeUpdateLabel(enrollStatusLabel, "Finger captured successfully.", Color.Green)
                SafeUpdateLabel(enrollStatusLabel, "Select the Next Finger And Click Enroll Button To Begin", Color.Black)
                SaveFingerprintToDB()
                capturer.StopCapture()
                Dim updatedCounts = functions.allCounts()
                adminportal.totalEnrollmentLabel.Text = updatedCounts.Item3.ToString()
            Else
                SafeUpdateLabel(enrollStatusLabel, "Keep scanning the same finger...", Color.DarkOrange)
                'SafeUpdateProgressBar(enrollProgressBar, enroller.FeaturesNeeded * 25)
            End If
            'Catch ex As Exception
            ' This likely means the wrong finger was used midway
            'enroller.Clear()
            'SafeUpdateLabel(enrollStatusLabel, "Finger mismatch detected. Please scan the same finger from the beginning.", Color.Red)
            'SafeUpdateProgressBar(enrollProgressBar, 0)
            'End Try
        Else
            SafeUpdateLabel(enrollStatusLabel, "Poor quality. Try again.", Color.Red)
        End If
    End Sub

    Public Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        SafeUpdateLabel(enrollStatusLabel, "Finger placed on scanner.", Color.DarkOrange)
    End Sub

    Public Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        SafeUpdateLabel(enrollStatusLabel, "Finger removed.", Color.Gray)
    End Sub

    Public Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        SafeUpdateLabel(enrollStatusLabel, "Fingerprint reader connected.", Color.Green)
    End Sub

    Public Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        SafeUpdateLabel(enrollStatusLabel, "Fingerprint reader disconnected.", Color.Red)
    End Sub

    Public Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Feedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If Feedback = DPFP.Capture.CaptureFeedback.Good Then
            SafeUpdateLabel(enrollStatusLabel, "Good fingerprint sample.", Color.Green)
        Else
            SafeUpdateLabel(enrollStatusLabel, "Bad fingerprint sample. Try again.", Color.Red)
        End If
    End Sub

    ' Fingerprint Save To DB
    Private Sub SaveFingerprintToDB()
        If capturedTemplate Is Nothing Then
            MessageBox.Show("No fingerprint captured.")
            Return
        End If

        Try
            Dim fingerId As Object = Nothing
            Dim studentIdValue As String = ""

            If selectFingerComboBox.InvokeRequired Then
                selectFingerComboBox.Invoke(Sub() fingerId = selectFingerComboBox.SelectedValue)
            Else
                fingerId = selectFingerComboBox.SelectedValue
            End If

            If Me.InvokeRequired Then
                Me.Invoke(Sub() studentIdValue = studentIdHidden)
            Else
                studentIdValue = studentIdHidden
            End If

            Dim connection = functions.connection
            connection.Open()

            query = "SELECT studentId, fingerId, fingerprintTemplate FROM fingerprints_tab"
            command = New MySqlCommand(query, connection)
            Dim reader = command.ExecuteReader()

            Dim verification As New DPFP.Verification.Verification()
            Dim result As New DPFP.Verification.Verification.Result()
            Dim currentFeatures As DPFP.FeatureSet = ConvertSampleToFeatures(capturedSample, DPFP.Processing.DataPurpose.Verification)

            Dim fingerprintMatched As Boolean = False
            Dim matchedStudentId As String = ""

            While reader.Read()
                Dim existingStudentId = reader("studentId").ToString()
                Dim storedTemplateBytes() As Byte = CType(reader("fingerprintTemplate"), Byte())
                Dim storedTemplate As New DPFP.Template(New MemoryStream(storedTemplateBytes))

                verification.Verify(currentFeatures, storedTemplate, result)

                If result.Verified Then
                    fingerprintMatched = True
                    matchedStudentId = existingStudentId
                    Exit While
                End If
            End While
            reader.Close()

            If fingerprintMatched Then
                If matchedStudentId = studentIdValue Then
                    SafeUpdateLabel(enrollStatusLabel, "This finger already exists for this student.", Color.Red)
                Else
                    SafeUpdateLabel(enrollStatusLabel, "This fingerprint is already registered to another student.", Color.Red)
                End If
                connection.Close()
                Return
            Else
                query = "SELECT COUNT(*) FROM student_tab WHERE studentId = @studentId"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentId", studentIdValue)
                Dim studentExists = Convert.ToInt32(command.ExecuteScalar())

                If studentExists = 0 Then
                    SafeUpdateLabel(enrollStatusLabel, "This fingerprint is not recognized or mismatch fingerprint.", Color.Red)
                    connection.Close()
                    Return
                End If
            End If

            query = "SELECT COUNT(*) FROM fingerprints_tab WHERE studentId = @studentId AND fingerId = @fingerId"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@studentId", studentIdValue)
            command.Parameters.AddWithValue("@fingerId", fingerId)
            Dim fingerAlreadyExists = Convert.ToInt32(command.ExecuteScalar())

            If fingerAlreadyExists > 0 Then
                SafeUpdateLabel(enrollStatusLabel, "This fingerprint is not recognized or mismatch fingerprint.", Color.Red)
                connection.Close()
                Return
            End If

            Dim ms As New MemoryStream()
            capturedTemplate.Serialize(ms)

            query = "INSERT INTO fingerprints_tab (studentId, fingerId, fingerprintTemplate, createdTime) VALUES (@studentId, @fingerId, @template, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@studentId", studentIdValue)
            command.Parameters.AddWithValue("@fingerId", fingerId)
            command.Parameters.AddWithValue("@template", ms.ToArray())
            command.ExecuteNonQuery()

            SafeUpdateLabel(enrollStatusLabel, "Fingerprint saved successfully.", Color.Green)
            connection.Close()

            Dim updatedCounts = functions.allCounts()
            If adminportal.InvokeRequired Then
                adminportal.Invoke(Sub()
                                       adminportal.totalEnrollmentLabel.Text = updatedCounts.Item3.ToString()
                                       adminportal.totalEnrollmentLabel.Refresh()
                                   End Sub)
            Else
                adminportal.totalEnrollmentLabel.Text = updatedCounts.Item3.ToString()
                adminportal.totalEnrollmentLabel.Refresh()
            End If

        Catch ex As Exception
            MessageBox.Show("Error saving fingerprint: " & ex.Message)
        End Try
    End Sub
    ' Converters
    Private Function ConvertSampleToBitmap(ByVal sample As DPFP.Sample) As Bitmap
        Dim converter As New DPFP.Capture.SampleConversion()
        Dim bmp As Bitmap = Nothing
        converter.ConvertToPicture(sample, bmp)
        Return bmp
    End Function

    Private Function ConvertSampleToFeatures(ByVal sample As DPFP.Sample, ByVal purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim feedback As DPFP.Capture.CaptureFeedback = Nothing
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(sample, purpose, feedback, features)
        Return If(feedback = DPFP.Capture.CaptureFeedback.Good, features, Nothing)
    End Function
End Class
