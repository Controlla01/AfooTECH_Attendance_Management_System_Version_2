<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.checkOutBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.checkInBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MV Boli", 29.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(37, 235)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(993, 52)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = " AfooTECH ATTENDANCE MANAGEMENT SYSTEM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin_btn
        '
        Me.admin_btn.BorderRadius = 5
        Me.admin_btn.CheckedState.Parent = Me.admin_btn
        Me.admin_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_btn.CustomImages.Parent = Me.admin_btn
        Me.admin_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.admin_btn.ForeColor = System.Drawing.Color.White
        Me.admin_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.admin_btn.HoverState.Parent = Me.admin_btn
        Me.admin_btn.Location = New System.Drawing.Point(463, 325)
        Me.admin_btn.Name = "admin_btn"
        Me.admin_btn.ShadowDecoration.Parent = Me.admin_btn
        Me.admin_btn.Size = New System.Drawing.Size(149, 47)
        Me.admin_btn.TabIndex = 2
        Me.admin_btn.Text = "Login As Admin"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(422, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'checkOutBtn
        '
        Me.checkOutBtn.BorderRadius = 5
        Me.checkOutBtn.CheckedState.Parent = Me.checkOutBtn
        Me.checkOutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkOutBtn.CustomImages.Parent = Me.checkOutBtn
        Me.checkOutBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.checkOutBtn.ForeColor = System.Drawing.Color.White
        Me.checkOutBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.checkOutBtn.HoverState.Parent = Me.checkOutBtn
        Me.checkOutBtn.Location = New System.Drawing.Point(695, 325)
        Me.checkOutBtn.Name = "checkOutBtn"
        Me.checkOutBtn.ShadowDecoration.Parent = Me.checkOutBtn
        Me.checkOutBtn.Size = New System.Drawing.Size(149, 47)
        Me.checkOutBtn.TabIndex = 7
        Me.checkOutBtn.Text = "Check-Out"
        '
        'checkInBtn
        '
        Me.checkInBtn.BorderRadius = 5
        Me.checkInBtn.CheckedState.Parent = Me.checkInBtn
        Me.checkInBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkInBtn.CustomImages.Parent = Me.checkInBtn
        Me.checkInBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.checkInBtn.ForeColor = System.Drawing.Color.White
        Me.checkInBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.checkInBtn.HoverState.Parent = Me.checkInBtn
        Me.checkInBtn.Location = New System.Drawing.Point(234, 327)
        Me.checkInBtn.Name = "checkInBtn"
        Me.checkInBtn.ShadowDecoration.Parent = Me.checkInBtn
        Me.checkInBtn.Size = New System.Drawing.Size(149, 47)
        Me.checkInBtn.TabIndex = 8
        Me.checkInBtn.Text = "Check-In"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(643, 325)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(14, 48)
        Me.Guna2HtmlLabel3.TabIndex = 10
        Me.Guna2HtmlLabel3.Text = "|"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(422, 324)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(14, 48)
        Me.Guna2HtmlLabel2.TabIndex = 11
        Me.Guna2HtmlLabel2.Text = "|"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 484)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.checkInBtn)
        Me.Controls.Add(Me.checkOutBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.admin_btn)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents checkOutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents checkInBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
