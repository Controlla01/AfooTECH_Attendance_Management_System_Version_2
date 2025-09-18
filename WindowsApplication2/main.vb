Public Class main

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim close_validation = MessageBox.Show("Are you sure you want to Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close_validation = vbYes Then
            Me.Close()
            index.Close()
        End If
    End Sub

    Private Sub admin_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_btn.Click
        Me.Close()
        adminlogin.Show()
    End Sub

    Private Sub checkInBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkInBtn.Click
        Dim attendForm As New markAttendance()
        attendForm.AttendanceMode = "Check-In"
        overlay.Show()
        attendForm.Show()
        'Me.Close()
        'markAttendance.Show()
    End Sub

    Private Sub checkOutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkOutBtn.Click
        Dim attendForm As New markAttendance()
        attendForm.AttendanceMode = "Check-Out"
        overlay.Show()
        attendForm.Show()
        'Me.Close()
        'markAttendance.Show()
    End Sub
End Class