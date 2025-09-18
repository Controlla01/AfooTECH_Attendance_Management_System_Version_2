Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class attendanceRecordForm
    Dim connection As MySqlConnection = functions.connection
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub attendanceRecordForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        attendanceDatePicker.Format = DateTimePickerFormat.Custom
        attendanceDatePicker.CustomFormat = "dddd dd, MMMM yyyy"
        attendanceDatePicker.Value = DateTime.Today

        attendanceSearchTxt.Text = String.Empty
        LoadAllAttendanceRecords()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
        adminportal.Show()
    End Sub

    Private Sub refreshBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles refreshBtn.Click
        attendanceSearchTxt.Text = String.Empty
        attendanceDatePicker.Value = DateTime.Today
        LoadAllAttendanceRecords()
    End Sub

    Private Sub searchBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles searchBtn.Click
        Dim emailAddressFilter As String = attendanceSearchTxt.Text.Trim()
        Dim selectedDate As Date = attendanceDatePicker.Value.Date

        If emailAddressFilter = "" AndAlso selectedDate = DateTime.Today Then
            LoadAllAttendanceRecords()
        ElseIf emailAddressFilter = "" Then
            LoadAttendanceForDate(selectedDate)
        ElseIf selectedDate = DateTime.Today Then
            LoadAttendanceByEmailOnly(emailAddressFilter)
        Else
            LoadAttendanceFiltered(emailAddressFilter, selectedDate)
        End If
    End Sub

    ' Load all attendance records
    Private Sub LoadAllAttendanceRecords()
        Try
            Dim dt As New DataTable
            query = "SELECT studentId, fullName, emailAddress, attendanceDate, checkInTime, checkOutTime, clockStatus FROM attendance_tab ORDER BY attendanceDate DESC, checkInTime DESC"
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dt)

            attendanceListView.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(sn.ToString())
                item.SubItems.Add(row("studentId").ToString())
                item.SubItems.Add(row("fullName").ToString())
                item.SubItems.Add(row("emailAddress").ToString())
                item.SubItems.Add(row("attendanceDate").ToString())
                item.SubItems.Add(row("checkInTime").ToString())
                item.SubItems.Add(row("checkOutTime").ToString())
                item.SubItems.Add(row("clockStatus").ToString())
                attendanceListView.Items.Add(item)
                sn += 1
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading records: " & ex.Message)
        End Try
    End Sub

    'Load attendance for a specific date
    Private Sub LoadAttendanceForDate(ByVal dateValue As Date)
        Try
            Dim dt As New DataTable
            query = "SELECT studentId, fullName, emailAddress, attendanceDate, checkInTime, checkOutTime, clockStatus " &
                                  "FROM attendance_tab WHERE attendanceDate = @date ORDER BY checkInTime DESC"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@date", dateValue.ToString("yyyy-MM-dd"))
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dt)

            attendanceListView.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(sn.ToString())
                item.SubItems.Add(row("studentId").ToString())
                item.SubItems.Add(row("fullName").ToString())
                item.SubItems.Add(row("emailAddress").ToString())
                item.SubItems.Add(row("attendanceDate").ToString())
                item.SubItems.Add(row("checkInTime").ToString())
                item.SubItems.Add(row("checkOutTime").ToString())
                item.SubItems.Add(row("clockStatus").ToString())
                attendanceListView.Items.Add(item)
                sn += 1
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading records by date: " & ex.Message)
        End Try
    End Sub

    ' Load attendance filtered by email only
    Private Sub LoadAttendanceByEmailOnly(ByVal emailAddress As String)
        Try
            Dim dt As New DataTable
            query = "SELECT studentId, fullName, emailAddress, attendanceDate, checkInTime, checkOutTime, clockStatus " &
                                  "FROM attendance_tab WHERE emailAddress LIKE @email ORDER BY attendanceDate DESC, checkInTime DESC"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email", "%" & emailAddress & "%")
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dt)

            attendanceListView.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(sn.ToString())
                item.SubItems.Add(row("studentId").ToString())
                item.SubItems.Add(row("fullName").ToString())
                item.SubItems.Add(row("emailAddress").ToString())
                item.SubItems.Add(row("attendanceDate").ToString())
                item.SubItems.Add(row("checkInTime").ToString())
                item.SubItems.Add(row("checkOutTime").ToString())
                item.SubItems.Add(row("clockStatus").ToString())
                attendanceListView.Items.Add(item)
                sn += 1
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading records by email: " & ex.Message)
        End Try
    End Sub

    'Load attendance filtered by email and date
    Private Sub LoadAttendanceFiltered(ByVal emailAddress As String, ByVal dateVal As Date)
        Try
            Dim dt As New DataTable
            query = "SELECT studentId, fullName, emailAddress, attendanceDate, checkInTime, checkOutTime, clockStatus " &
                                  "FROM attendance_tab WHERE emailAddress LIKE @email AND attendanceDate = @date ORDER BY checkInTime DESC"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email", "%" & emailAddress & "%")
            command.Parameters.AddWithValue("@date", dateVal.ToString("yyyy-MM-dd"))
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dt)

            attendanceListView.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(sn.ToString())
                item.SubItems.Add(row("studentId").ToString())
                item.SubItems.Add(row("fullName").ToString())
                item.SubItems.Add(row("emailAddress").ToString())
                item.SubItems.Add(row("attendanceDate").ToString())
                item.SubItems.Add(row("checkInTime").ToString())
                item.SubItems.Add(row("checkOutTime").ToString())
                item.SubItems.Add(row("clockStatus").ToString())
                attendanceListView.Items.Add(item)
                sn += 1
            Next
        Catch ex As Exception
            MessageBox.Show("Error searching by email and date: " & ex.Message)
        End Try
    End Sub

    Private Sub generatePdfBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles generatePdfBtn.Click
        GenerateAttendancePDF()
    End Sub

   Private Sub GenerateAttendancePDF()
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf"
            saveDialog.Title = "Save Attendance Report"
            saveDialog.FileName = "AttendanceReport.pdf"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveDialog.FileName

                ' Setup fonts using BaseFont
                Dim baseFont As iTextSharp.text.pdf.BaseFont = iTextSharp.text.pdf.BaseFont.CreateFont(iTextSharp.text.pdf.BaseFont.HELVETICA, iTextSharp.text.pdf.BaseFont.CP1252, iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED)
                Dim titleFont As New iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD)
                Dim headerFont As New iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD)
                Dim normalFont As New iTextSharp.text.Font(baseFont, 9, iTextSharp.text.Font.NORMAL)
                Dim italicFont As New iTextSharp.text.Font(baseFont, 9, iTextSharp.text.Font.ITALIC)

                ' Create document
                Dim doc As New Document(PageSize.A4, 40, 40, 80, 60)
                PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))
                doc.Open()


                Dim logoPath As String = "C:\Users\Michael\Documents\Visual Studio 2010\Projects\AfooTECH_Attendance_Management_System_Version_2\WindowsApplication2/logo.PNG"
                If File.Exists(logoPath) Then
                    Dim logo = iTextSharp.text.Image.GetInstance(logoPath)
                    logo.ScaleAbsolute(140, 50)
                    logo.Alignment = Element.ALIGN_CENTER
                    doc.Add(logo)
                End If


                Dim title As New Paragraph("AfooTECH Attendance Report", titleFont)
                title.Alignment = Element.ALIGN_CENTER
                title.SpacingAfter = 20
                doc.Add(title)


                Dim table As New PdfPTable(7)
                table.WidthPercentage = 100
                table.SetWidths(New Single() {5, 20, 20, 35, 15, 12.5F, 12.5F})


                Dim headers = {"S/N", "Student ID", "Full Name", "Email Address", "Date", "Check-In", "Check-Out"}
                For Each header As String In headers
                    Dim cell As New PdfPCell(New Phrase(header, headerFont))
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY
                    cell.HorizontalAlignment = Element.ALIGN_CENTER
                    table.AddCell(cell)
                Next


                Dim connection = functions.connection
                connection.Open()
                query = "SELECT studentId, fullName, emailAddress, attendanceDate, checkInTime, checkOutTime FROM attendance_tab WHERE 1=1"

                If attendanceSearchTxt.Text.Trim() <> "" Then
                    query &= " AND (emailAddress LIKE @studentSearch OR studentId LIKE @studentSearch)"
                End If

                If attendanceDatePicker.Checked = True Then
                    query &= " AND attendanceDate = @filterDate"
                End If

                query &= " ORDER BY attendanceDate DESC"

                Dim command As New MySqlCommand(query, connection)

                If attendanceSearchTxt.Text.Trim() <> "" Then
                    command.Parameters.AddWithValue("@studentSearch", "%" & attendanceSearchTxt.Text.Trim() & "%")
                End If
                If attendanceDatePicker.Checked Then
                    command.Parameters.AddWithValue("@filterDate", attendanceDatePicker.Value.Date)
                End If

                Dim reader As MySqlDataReader = command.ExecuteReader()
                Dim sn As Integer = 1
                While reader.Read()
                    table.AddCell(New Phrase(sn.ToString(), normalFont))
                    table.AddCell(New Phrase(reader("studentId").ToString(), normalFont))
                    table.AddCell(New Phrase(reader("fullName").ToString(), normalFont))
                    table.AddCell(New Phrase(reader("emailAddress").ToString(), normalFont))
                    table.AddCell(New Phrase(Convert.ToDateTime(reader("attendanceDate")).ToString("dd/MM/yyyy"), normalFont))
                    table.AddCell(New Phrase(reader("checkInTime").ToString(), normalFont))
                    table.AddCell(New Phrase(reader("checkOutTime").ToString(), normalFont))
                    sn += 1
                End While
                reader.Close()
                connection.Close()

                doc.Add(table)


                doc.Add(New Paragraph(" "))
                Dim footer As New Paragraph("Page 1", italicFont)
                footer.Alignment = Element.ALIGN_RIGHT
                doc.Add(footer)

                doc.Close()

                MessageBox.Show("Attendance report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Process.Start(filePath)
            End If
        Catch ex As Exception
            MessageBox.Show("Error creating attendance PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
