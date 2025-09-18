<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminportal
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminportal))
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.monthlyAttendancePieChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.attendanceBarChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.totalStudentLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.totalRecordLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.totalEnrollmentLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.totalAdminLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.settingsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.attendanceRecordBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.viewAdminBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.viewStudentBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.dashBoardBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.date_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.time_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lastLoginLabelTxt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.staffFullNameLabelTxt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.passporrt = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.admin_log_out_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel5.SuspendLayout()
        CType(Me.monthlyAttendancePieChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.attendanceBarChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel9.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        Me.Guna2Panel10.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.passporrt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel5.BorderRadius = 5
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.monthlyAttendancePieChart)
        Me.Guna2Panel5.Controls.Add(Me.attendanceBarChart)
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel6)
        Me.Guna2Panel5.Location = New System.Drawing.Point(261, 175)
        Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(1431, 426)
        Me.Guna2Panel5.TabIndex = 13
        '
        'monthlyAttendancePieChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.monthlyAttendancePieChart.ChartAreas.Add(ChartArea1)
        Me.monthlyAttendancePieChart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend1.Name = "Legend1"
        Me.monthlyAttendancePieChart.Legends.Add(Legend1)
        Me.monthlyAttendancePieChart.Location = New System.Drawing.Point(983, 220)
        Me.monthlyAttendancePieChart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.monthlyAttendancePieChart.Name = "monthlyAttendancePieChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.monthlyAttendancePieChart.Series.Add(Series1)
        Me.monthlyAttendancePieChart.Size = New System.Drawing.Size(520, 431)
        Me.monthlyAttendancePieChart.TabIndex = 2
        Me.monthlyAttendancePieChart.Text = "Chart1"
        '
        'attendanceBarChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.attendanceBarChart.ChartAreas.Add(ChartArea2)
        Me.attendanceBarChart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend2.Name = "Legend1"
        Me.attendanceBarChart.Legends.Add(Legend2)
        Me.attendanceBarChart.Location = New System.Drawing.Point(25, 222)
        Me.attendanceBarChart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.attendanceBarChart.Name = "attendanceBarChart"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.attendanceBarChart.Series.Add(Series2)
        Me.attendanceBarChart.Size = New System.Drawing.Size(932, 431)
        Me.attendanceBarChart.TabIndex = 1
        Me.attendanceBarChart.Text = "Chart1"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel6.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel6.BorderRadius = 5
        Me.Guna2Panel6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Panel6.Controls.Add(Me.Guna2Panel7)
        Me.Guna2Panel6.Controls.Add(Me.Guna2Panel9)
        Me.Guna2Panel6.Controls.Add(Me.Guna2Panel8)
        Me.Guna2Panel6.Controls.Add(Me.Guna2Panel10)
        Me.Guna2Panel6.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.Location = New System.Drawing.Point(25, 17)
        Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(1376, 162)
        Me.Guna2Panel6.TabIndex = 0
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel7.BorderRadius = 5
        Me.Guna2Panel7.Controls.Add(Me.totalStudentLabel)
        Me.Guna2Panel7.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Guna2Panel7.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel7.Location = New System.Drawing.Point(327, 21)
        Me.Guna2Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(348, 119)
        Me.Guna2Panel7.TabIndex = 4
        '
        'totalStudentLabel
        '
        Me.totalStudentLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalStudentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalStudentLabel.ForeColor = System.Drawing.Color.White
        Me.totalStudentLabel.Location = New System.Drawing.Point(20, 38)
        Me.totalStudentLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalStudentLabel.Name = "totalStudentLabel"
        Me.totalStudentLabel.Size = New System.Drawing.Size(22, 40)
        Me.totalStudentLabel.TabIndex = 3
        Me.totalStudentLabel.Text = "0"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(16, 10)
        Me.Guna2HtmlLabel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(138, 20)
        Me.Guna2HtmlLabel8.TabIndex = 2
        Me.Guna2HtmlLabel8.Text = "TOTAL STUDENT"
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel9.BorderRadius = 5
        Me.Guna2Panel9.Controls.Add(Me.totalRecordLabel)
        Me.Guna2Panel9.Controls.Add(Me.Guna2HtmlLabel12)
        Me.Guna2Panel9.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel9.Location = New System.Drawing.Point(1079, 21)
        Me.Guna2Panel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.ShadowDecoration.Parent = Me.Guna2Panel9
        Me.Guna2Panel9.Size = New System.Drawing.Size(327, 119)
        Me.Guna2Panel9.TabIndex = 5
        '
        'totalRecordLabel
        '
        Me.totalRecordLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalRecordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalRecordLabel.ForeColor = System.Drawing.Color.White
        Me.totalRecordLabel.Location = New System.Drawing.Point(23, 38)
        Me.totalRecordLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalRecordLabel.Name = "totalRecordLabel"
        Me.totalRecordLabel.Size = New System.Drawing.Size(22, 40)
        Me.totalRecordLabel.TabIndex = 7
        Me.totalRecordLabel.Text = "0"
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(15, 10)
        Me.Guna2HtmlLabel12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(247, 19)
        Me.Guna2HtmlLabel12.TabIndex = 6
        Me.Guna2HtmlLabel12.Text = "TOTAL ATTENDANCE RECORD"
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel8.BorderRadius = 5
        Me.Guna2Panel8.Controls.Add(Me.totalEnrollmentLabel)
        Me.Guna2Panel8.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2Panel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Guna2Panel8.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel8.Location = New System.Drawing.Point(704, 21)
        Me.Guna2Panel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.ShadowDecoration.Parent = Me.Guna2Panel8
        Me.Guna2Panel8.Size = New System.Drawing.Size(348, 119)
        Me.Guna2Panel8.TabIndex = 2
        '
        'totalEnrollmentLabel
        '
        Me.totalEnrollmentLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalEnrollmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalEnrollmentLabel.ForeColor = System.Drawing.Color.White
        Me.totalEnrollmentLabel.Location = New System.Drawing.Point(23, 38)
        Me.totalEnrollmentLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalEnrollmentLabel.Name = "totalEnrollmentLabel"
        Me.totalEnrollmentLabel.Size = New System.Drawing.Size(22, 40)
        Me.totalEnrollmentLabel.TabIndex = 5
        Me.totalEnrollmentLabel.Text = "0"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(19, 10)
        Me.Guna2HtmlLabel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(173, 20)
        Me.Guna2HtmlLabel10.TabIndex = 4
        Me.Guna2HtmlLabel10.Text = "TOTAL ENROLLMENT"
        '
        'Guna2Panel10
        '
        Me.Guna2Panel10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel10.BorderRadius = 5
        Me.Guna2Panel10.Controls.Add(Me.totalAdminLabel)
        Me.Guna2Panel10.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Guna2Panel10.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel10.Location = New System.Drawing.Point(-29, 21)
        Me.Guna2Panel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel10.Name = "Guna2Panel10"
        Me.Guna2Panel10.ShadowDecoration.Parent = Me.Guna2Panel10
        Me.Guna2Panel10.Size = New System.Drawing.Size(327, 119)
        Me.Guna2Panel10.TabIndex = 3
        '
        'totalAdminLabel
        '
        Me.totalAdminLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalAdminLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAdminLabel.ForeColor = System.Drawing.Color.White
        Me.totalAdminLabel.Location = New System.Drawing.Point(23, 38)
        Me.totalAdminLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalAdminLabel.Name = "totalAdminLabel"
        Me.totalAdminLabel.Size = New System.Drawing.Size(22, 40)
        Me.totalAdminLabel.TabIndex = 1
        Me.totalAdminLabel.Text = "0"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(19, 10)
        Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(112, 19)
        Me.Guna2HtmlLabel6.TabIndex = 0
        Me.Guna2HtmlLabel6.Text = "TOTAL ADMIN"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BorderRadius = 3
        Me.Guna2Panel2.Controls.Add(Me.settingsBtn)
        Me.Guna2Panel2.Controls.Add(Me.attendanceRecordBtn)
        Me.Guna2Panel2.Controls.Add(Me.viewAdminBtn)
        Me.Guna2Panel2.Controls.Add(Me.viewStudentBtn)
        Me.Guna2Panel2.Controls.Add(Me.dashBoardBtn)
        Me.Guna2Panel2.Location = New System.Drawing.Point(-5, 62)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(245, 539)
        Me.Guna2Panel2.TabIndex = 12
        '
        'settingsBtn
        '
        Me.settingsBtn.BackColor = System.Drawing.Color.White
        Me.settingsBtn.BorderRadius = 3
        Me.settingsBtn.CheckedState.Parent = Me.settingsBtn
        Me.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingsBtn.CustomImages.Parent = Me.settingsBtn
        Me.settingsBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.settingsBtn.ForeColor = System.Drawing.Color.White
        Me.settingsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.settingsBtn.HoverState.Parent = Me.settingsBtn
        Me.settingsBtn.Location = New System.Drawing.Point(5, 310)
        Me.settingsBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.ShadowDecoration.Parent = Me.settingsBtn
        Me.settingsBtn.Size = New System.Drawing.Size(237, 75)
        Me.settingsBtn.TabIndex = 11
        Me.settingsBtn.Text = "Settings"
        '
        'attendanceRecordBtn
        '
        Me.attendanceRecordBtn.BackColor = System.Drawing.Color.White
        Me.attendanceRecordBtn.BorderRadius = 3
        Me.attendanceRecordBtn.CheckedState.Parent = Me.attendanceRecordBtn
        Me.attendanceRecordBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.attendanceRecordBtn.CustomImages.Parent = Me.attendanceRecordBtn
        Me.attendanceRecordBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.attendanceRecordBtn.ForeColor = System.Drawing.Color.White
        Me.attendanceRecordBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.attendanceRecordBtn.HoverState.Parent = Me.attendanceRecordBtn
        Me.attendanceRecordBtn.Location = New System.Drawing.Point(5, 233)
        Me.attendanceRecordBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.attendanceRecordBtn.Name = "attendanceRecordBtn"
        Me.attendanceRecordBtn.ShadowDecoration.Parent = Me.attendanceRecordBtn
        Me.attendanceRecordBtn.Size = New System.Drawing.Size(237, 75)
        Me.attendanceRecordBtn.TabIndex = 10
        Me.attendanceRecordBtn.Text = "Attendance records"
        '
        'viewAdminBtn
        '
        Me.viewAdminBtn.BackColor = System.Drawing.Color.White
        Me.viewAdminBtn.BorderRadius = 3
        Me.viewAdminBtn.CheckedState.Parent = Me.viewAdminBtn
        Me.viewAdminBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewAdminBtn.CustomImages.Parent = Me.viewAdminBtn
        Me.viewAdminBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.viewAdminBtn.ForeColor = System.Drawing.Color.White
        Me.viewAdminBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.viewAdminBtn.HoverState.Parent = Me.viewAdminBtn
        Me.viewAdminBtn.Location = New System.Drawing.Point(5, 78)
        Me.viewAdminBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.viewAdminBtn.Name = "viewAdminBtn"
        Me.viewAdminBtn.ShadowDecoration.Parent = Me.viewAdminBtn
        Me.viewAdminBtn.Size = New System.Drawing.Size(237, 75)
        Me.viewAdminBtn.TabIndex = 9
        Me.viewAdminBtn.Text = "Register Admin"
        '
        'viewStudentBtn
        '
        Me.viewStudentBtn.BackColor = System.Drawing.Color.White
        Me.viewStudentBtn.BorderRadius = 3
        Me.viewStudentBtn.CheckedState.Parent = Me.viewStudentBtn
        Me.viewStudentBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewStudentBtn.CustomImages.Parent = Me.viewStudentBtn
        Me.viewStudentBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.viewStudentBtn.ForeColor = System.Drawing.Color.White
        Me.viewStudentBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.viewStudentBtn.HoverState.Parent = Me.viewStudentBtn
        Me.viewStudentBtn.Location = New System.Drawing.Point(5, 155)
        Me.viewStudentBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.viewStudentBtn.Name = "viewStudentBtn"
        Me.viewStudentBtn.ShadowDecoration.Parent = Me.viewStudentBtn
        Me.viewStudentBtn.Size = New System.Drawing.Size(237, 75)
        Me.viewStudentBtn.TabIndex = 8
        Me.viewStudentBtn.Text = "Register Student"
        '
        'dashBoardBtn
        '
        Me.dashBoardBtn.BackColor = System.Drawing.Color.White
        Me.dashBoardBtn.BorderRadius = 3
        Me.dashBoardBtn.CheckedState.Parent = Me.dashBoardBtn
        Me.dashBoardBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashBoardBtn.CustomImages.Parent = Me.dashBoardBtn
        Me.dashBoardBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.dashBoardBtn.ForeColor = System.Drawing.Color.White
        Me.dashBoardBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dashBoardBtn.HoverState.Parent = Me.dashBoardBtn
        Me.dashBoardBtn.Location = New System.Drawing.Point(5, 0)
        Me.dashBoardBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dashBoardBtn.Name = "dashBoardBtn"
        Me.dashBoardBtn.ShadowDecoration.Parent = Me.dashBoardBtn
        Me.dashBoardBtn.Size = New System.Drawing.Size(237, 75)
        Me.dashBoardBtn.TabIndex = 5
        Me.dashBoardBtn.Text = "Dashboard"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel3.Controls.Add(Me.date_label)
        Me.Guna2Panel3.Controls.Add(Me.time_label)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Location = New System.Drawing.Point(1447, 74)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(245, 89)
        Me.Guna2Panel3.TabIndex = 11
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(16, 14)
        Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(99, 21)
        Me.Guna2HtmlLabel5.TabIndex = 5
        Me.Guna2HtmlLabel5.Text = "Current Time:"
        '
        'date_label
        '
        Me.date_label.BackColor = System.Drawing.Color.Transparent
        Me.date_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_label.Location = New System.Drawing.Point(16, 54)
        Me.date_label.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.date_label.Name = "date_label"
        Me.date_label.Size = New System.Drawing.Size(99, 20)
        Me.date_label.TabIndex = 4
        Me.date_label.Text = "Current Date"
        '
        'time_label
        '
        Me.time_label.BackColor = System.Drawing.Color.Transparent
        Me.time_label.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_label.ForeColor = System.Drawing.Color.Maroon
        Me.time_label.Location = New System.Drawing.Point(16, 36)
        Me.time_label.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(95, 21)
        Me.time_label.TabIndex = 3
        Me.time_label.Text = "Current Time"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BorderRadius = 5
        Me.Guna2Panel4.Controls.Add(Me.lastLoginLabelTxt)
        Me.Guna2Panel4.Controls.Add(Me.staffFullNameLabelTxt)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel4.Controls.Add(Me.passporrt)
        Me.Guna2Panel4.Location = New System.Drawing.Point(261, 74)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(1167, 87)
        Me.Guna2Panel4.TabIndex = 10
        '
        'lastLoginLabelTxt
        '
        Me.lastLoginLabelTxt.BackColor = System.Drawing.Color.Transparent
        Me.lastLoginLabelTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lastLoginLabelTxt.Location = New System.Drawing.Point(111, 49)
        Me.lastLoginLabelTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lastLoginLabelTxt.Name = "lastLoginLabelTxt"
        Me.lastLoginLabelTxt.Size = New System.Drawing.Size(35, 18)
        Me.lastLoginLabelTxt.TabIndex = 7
        Me.lastLoginLabelTxt.Text = "XXXX"
        '
        'staffFullNameLabelTxt
        '
        Me.staffFullNameLabelTxt.BackColor = System.Drawing.Color.Transparent
        Me.staffFullNameLabelTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffFullNameLabelTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.staffFullNameLabelTxt.Location = New System.Drawing.Point(111, 31)
        Me.staffFullNameLabelTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.staffFullNameLabelTxt.Name = "staffFullNameLabelTxt"
        Me.staffFullNameLabelTxt.Size = New System.Drawing.Size(57, 18)
        Me.staffFullNameLabelTxt.TabIndex = 6
        Me.staffFullNameLabelTxt.Text = "XXXXXX"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(111, 9)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(121, 20)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "Admin Dashboard"
        '
        'passporrt
        '
        Me.passporrt.BorderRadius = 5
        Me.passporrt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.passporrt.Image = Global.WindowsApplication2.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Places_user_identity_128
        Me.passporrt.Location = New System.Drawing.Point(13, 7)
        Me.passporrt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passporrt.Name = "passporrt"
        Me.passporrt.ShadowDecoration.Parent = Me.passporrt
        Me.passporrt.Size = New System.Drawing.Size(91, 73)
        Me.passporrt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passporrt.TabIndex = 4
        Me.passporrt.TabStop = False
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GradientPanel2.BorderRadius = 1
        Me.Guna2GradientPanel2.Controls.Add(Me.admin_log_out_btn)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(-7, 0)
        Me.Guna2GradientPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(1727, 62)
        Me.Guna2GradientPanel2.TabIndex = 9
        '
        'admin_log_out_btn
        '
        Me.admin_log_out_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admin_log_out_btn.BorderRadius = 5
        Me.admin_log_out_btn.CheckedState.Parent = Me.admin_log_out_btn
        Me.admin_log_out_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_log_out_btn.CustomImages.Parent = Me.admin_log_out_btn
        Me.admin_log_out_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.admin_log_out_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.admin_log_out_btn.ForeColor = System.Drawing.Color.White
        Me.admin_log_out_btn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.admin_log_out_btn.HoverState.Parent = Me.admin_log_out_btn
        Me.admin_log_out_btn.Location = New System.Drawing.Point(1571, 12)
        Me.admin_log_out_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.admin_log_out_btn.Name = "admin_log_out_btn"
        Me.admin_log_out_btn.ShadowDecoration.Parent = Me.admin_log_out_btn
        Me.admin_log_out_btn.Size = New System.Drawing.Size(108, 39)
        Me.admin_log_out_btn.TabIndex = 0
        Me.admin_log_out_btn.Text = "LOG-OUT"
        '
        'Timer1
        '
        '
        'adminportal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.bg_8
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1716, 617)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "adminportal"
        Me.Text = "adminportal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel5.ResumeLayout(False)
        CType(Me.monthlyAttendancePieChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.attendanceBarChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel7.PerformLayout()
        Me.Guna2Panel9.ResumeLayout(False)
        Me.Guna2Panel9.PerformLayout()
        Me.Guna2Panel8.ResumeLayout(False)
        Me.Guna2Panel8.PerformLayout()
        Me.Guna2Panel10.ResumeLayout(False)
        Me.Guna2Panel10.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.passporrt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents totalStudentLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents totalRecordLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents totalEnrollmentLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents totalAdminLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents attendanceRecordBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents viewAdminBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents viewStudentBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashBoardBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents date_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents time_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lastLoginLabelTxt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents staffFullNameLabelTxt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents passporrt As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents admin_log_out_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents settingsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents attendanceBarChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents monthlyAttendancePieChart As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
