<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Me.btnSelect = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage7 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage6 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage5 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage8 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage9 = New MetroFramework.Controls.MetroTabPage()
        Me.btnManageTeacher = New MetroFramework.Controls.MetroButton()
        Me.comboSearchTeacher = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearchTeacher = New MetroFramework.Controls.MetroTextBox()
        Me.listTeacher = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.btnManageStudent = New MetroFramework.Controls.MetroButton()
        Me.comboSearchStudent = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearchStudent = New MetroFramework.Controls.MetroTextBox()
        Me.listStudent = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btnMangeDepartment = New MetroFramework.Controls.MetroButton()
        Me.comboSearchDepartment = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearchDepartment = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.listDepartment = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.btnManageCourse = New MetroFramework.Controls.MetroButton()
        Me.comboSearchCourse = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearchCourse = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.listCourse = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnManageSection = New MetroFramework.Controls.MetroButton()
        Me.comboSearchSection = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearchSection = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.listSection = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.btnManageSubject = New MetroFramework.Controls.MetroButton()
        Me.comboSearchSubject = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearchSubject = New MetroFramework.Controls.MetroTextBox()
        Me.listSubject = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtPassCon = New MetroFramework.Controls.MetroTextBox()
        Me.togglePassCon = New MetroFramework.Controls.MetroToggle()
        Me.txtPass = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel24 = New MetroFramework.Controls.MetroLabel()
        Me.txtUser = New MetroFramework.Controls.MetroTextBox()
        Me.togglePass = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel29 = New MetroFramework.Controls.MetroLabel()
        Me.txtSuffix = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.comboGender = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel32 = New MetroFramework.Controls.MetroLabel()
        Me.btnClear = New MetroFramework.Controls.MetroButton()
        Me.txtmiddle = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel33 = New MetroFramework.Controls.MetroLabel()
        Me.txtsname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel34 = New MetroFramework.Controls.MetroLabel()
        Me.txtfname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel35 = New MetroFramework.Controls.MetroLabel()
        Me.txtID = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel37 = New MetroFramework.Controls.MetroLabel()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel38 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel39 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel40 = New MetroFramework.Controls.MetroLabel()
        Me.checkNeeded = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel25 = New MetroFramework.Controls.MetroLabel()
        Me.btnPrintIndividual = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.txtName1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.txtPos1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.txtTitle = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.txtName2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.txtPos2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.comboReport = New MetroFramework.Controls.MetroComboBox()
        Me.txtReport = New MetroFramework.Controls.MetroTextBox()
        Me.listReport = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.comboSem = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel26 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.btnUpdateAdmin = New MetroFramework.Controls.MetroButton()
        Me.btnDelete = New MetroFramework.Controls.MetroButton()
        Me.btnReport = New MetroFramework.Controls.MetroButton()
        Me.btnCreate = New MetroFramework.Controls.MetroButton()
        Me.btnInsert = New MetroFramework.Controls.MetroButton()
        Me.btnTeacher = New MetroFramework.Controls.MetroButton()
        Me.btnLogout = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.txtWelcome = New MetroFramework.Controls.MetroLabel()
        Me.txtCaption = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(0, 207)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(165, 23)
        Me.btnSelect.TabIndex = 0
        Me.btnSelect.Text = "Select"
        Me.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelect.UseSelectable = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage7)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage6)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage5)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage8)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage9)
        Me.MetroTabControl1.Location = New System.Drawing.Point(164, 131)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(619, 434)
        Me.MetroTabControl1.TabIndex = 7
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(611, 392)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Dashboard"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(611, 392)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(611, 392)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'MetroTabPage7
        '
        Me.MetroTabPage7.HorizontalScrollbarBarColor = True
        Me.MetroTabPage7.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage7.HorizontalScrollbarSize = 10
        Me.MetroTabPage7.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage7.Name = "MetroTabPage7"
        Me.MetroTabPage7.Size = New System.Drawing.Size(611, 392)
        Me.MetroTabPage7.TabIndex = 3
        Me.MetroTabPage7.VerticalScrollbarBarColor = True
        Me.MetroTabPage7.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage7.VerticalScrollbarSize = 10
        '
        'MetroTabPage6
        '
        Me.MetroTabPage6.HorizontalScrollbarBarColor = True
        Me.MetroTabPage6.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.HorizontalScrollbarSize = 10
        Me.MetroTabPage6.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage6.Name = "MetroTabPage6"
        Me.MetroTabPage6.Size = New System.Drawing.Size(611, 392)
        Me.MetroTabPage6.TabIndex = 4
        Me.MetroTabPage6.VerticalScrollbarBarColor = True
        Me.MetroTabPage6.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.VerticalScrollbarSize = 10
        '
        'MetroTabPage5
        '
        Me.MetroTabPage5.HorizontalScrollbarBarColor = True
        Me.MetroTabPage5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.HorizontalScrollbarSize = 10
        Me.MetroTabPage5.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage5.Name = "MetroTabPage5"
        Me.MetroTabPage5.Size = New System.Drawing.Size(611, 392)
        Me.MetroTabPage5.TabIndex = 5
        Me.MetroTabPage5.VerticalScrollbarBarColor = True
        Me.MetroTabPage5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.VerticalScrollbarSize = 10
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(611, 392)
        Me.MetroTabPage4.TabIndex = 6
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'MetroTabPage8
        '
        Me.MetroTabPage8.HorizontalScrollbarBarColor = True
        Me.MetroTabPage8.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage8.HorizontalScrollbarSize = 10
        Me.MetroTabPage8.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage8.Name = "MetroTabPage8"
        Me.MetroTabPage8.Size = New System.Drawing.Size(611, 392)
        Me.MetroTabPage8.TabIndex = 7
        Me.MetroTabPage8.VerticalScrollbarBarColor = True
        Me.MetroTabPage8.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage8.VerticalScrollbarSize = 10
        '
        'MetroTabPage9
        '
        Me.MetroTabPage9.HorizontalScrollbarBarColor = True
        Me.MetroTabPage9.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage9.HorizontalScrollbarSize = 10
        Me.MetroTabPage9.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage9.Name = "MetroTabPage9"
        Me.MetroTabPage9.Size = New System.Drawing.Size(611, 392)
        Me.MetroTabPage9.TabIndex = 8
        Me.MetroTabPage9.VerticalScrollbarBarColor = True
        Me.MetroTabPage9.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage9.VerticalScrollbarSize = 10
        '
        'btnManageTeacher
        '
        Me.btnManageTeacher.Location = New System.Drawing.Point(525, 353)
        Me.btnManageTeacher.Name = "btnManageTeacher"
        Me.btnManageTeacher.Size = New System.Drawing.Size(84, 26)
        Me.btnManageTeacher.TabIndex = 165
        Me.btnManageTeacher.Text = "Manage"
        Me.btnManageTeacher.UseSelectable = True
        '
        'comboSearchTeacher
        '
        Me.comboSearchTeacher.FormattingEnabled = True
        Me.comboSearchTeacher.ItemHeight = 23
        Me.comboSearchTeacher.Items.AddRange(New Object() {"Department", "First Name", "ID", "Last Name"})
        Me.comboSearchTeacher.Location = New System.Drawing.Point(80, 29)
        Me.comboSearchTeacher.Name = "comboSearchTeacher"
        Me.comboSearchTeacher.Size = New System.Drawing.Size(138, 29)
        Me.comboSearchTeacher.Sorted = True
        Me.comboSearchTeacher.TabIndex = 95
        Me.comboSearchTeacher.UseSelectable = True
        '
        'txtSearchTeacher
        '
        '
        '
        '
        Me.txtSearchTeacher.CustomButton.Image = Nothing
        Me.txtSearchTeacher.CustomButton.Location = New System.Drawing.Point(229, 1)
        Me.txtSearchTeacher.CustomButton.Name = ""
        Me.txtSearchTeacher.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearchTeacher.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchTeacher.CustomButton.TabIndex = 1
        Me.txtSearchTeacher.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchTeacher.CustomButton.UseSelectable = True
        Me.txtSearchTeacher.CustomButton.Visible = False
        Me.txtSearchTeacher.Lines = New String(-1) {}
        Me.txtSearchTeacher.Location = New System.Drawing.Point(358, 29)
        Me.txtSearchTeacher.MaxLength = 32767
        Me.txtSearchTeacher.Name = "txtSearchTeacher"
        Me.txtSearchTeacher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchTeacher.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchTeacher.SelectedText = ""
        Me.txtSearchTeacher.SelectionLength = 0
        Me.txtSearchTeacher.SelectionStart = 0
        Me.txtSearchTeacher.ShortcutsEnabled = True
        Me.txtSearchTeacher.Size = New System.Drawing.Size(251, 23)
        Me.txtSearchTeacher.TabIndex = 96
        Me.txtSearchTeacher.UseSelectable = True
        Me.txtSearchTeacher.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchTeacher.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'listTeacher
        '
        Me.listTeacher.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.listTeacher.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.listTeacher.FullRowSelect = True
        Me.listTeacher.GridLines = True
        Me.listTeacher.Location = New System.Drawing.Point(5, 64)
        Me.listTeacher.MultiSelect = False
        Me.listTeacher.Name = "listTeacher"
        Me.listTeacher.OwnerDraw = True
        Me.listTeacher.ShowGroups = False
        Me.listTeacher.Size = New System.Drawing.Size(603, 283)
        Me.listTeacher.TabIndex = 99
        Me.listTeacher.UseCompatibleStateImageBehavior = False
        Me.listTeacher.UseSelectable = True
        Me.listTeacher.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Name"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 303
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Department"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 111
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Employee ID"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 153
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(301, 29)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel5.TabIndex = 98
        Me.MetroLabel5.Text = "Search:"
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(5, 29)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel6.TabIndex = 97
        Me.MetroLabel6.Text = "Search by:"
        Me.MetroLabel6.UseCustomBackColor = True
        '
        'btnManageStudent
        '
        Me.btnManageStudent.Location = New System.Drawing.Point(524, 353)
        Me.btnManageStudent.Name = "btnManageStudent"
        Me.btnManageStudent.Size = New System.Drawing.Size(84, 26)
        Me.btnManageStudent.TabIndex = 164
        Me.btnManageStudent.Text = "Manage"
        Me.btnManageStudent.UseSelectable = True
        '
        'comboSearchStudent
        '
        Me.comboSearchStudent.FormattingEnabled = True
        Me.comboSearchStudent.ItemHeight = 23
        Me.comboSearchStudent.Items.AddRange(New Object() {"Course", "First Name", "ID", "Last Name"})
        Me.comboSearchStudent.Location = New System.Drawing.Point(80, 29)
        Me.comboSearchStudent.Name = "comboSearchStudent"
        Me.comboSearchStudent.Size = New System.Drawing.Size(138, 29)
        Me.comboSearchStudent.Sorted = True
        Me.comboSearchStudent.TabIndex = 90
        Me.comboSearchStudent.UseSelectable = True
        '
        'txtSearchStudent
        '
        '
        '
        '
        Me.txtSearchStudent.CustomButton.Image = Nothing
        Me.txtSearchStudent.CustomButton.Location = New System.Drawing.Point(228, 1)
        Me.txtSearchStudent.CustomButton.Name = ""
        Me.txtSearchStudent.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearchStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchStudent.CustomButton.TabIndex = 1
        Me.txtSearchStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchStudent.CustomButton.UseSelectable = True
        Me.txtSearchStudent.CustomButton.Visible = False
        Me.txtSearchStudent.Lines = New String(-1) {}
        Me.txtSearchStudent.Location = New System.Drawing.Point(358, 29)
        Me.txtSearchStudent.MaxLength = 32767
        Me.txtSearchStudent.Name = "txtSearchStudent"
        Me.txtSearchStudent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchStudent.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchStudent.SelectedText = ""
        Me.txtSearchStudent.SelectionLength = 0
        Me.txtSearchStudent.SelectionStart = 0
        Me.txtSearchStudent.ShortcutsEnabled = True
        Me.txtSearchStudent.Size = New System.Drawing.Size(250, 23)
        Me.txtSearchStudent.TabIndex = 91
        Me.txtSearchStudent.UseSelectable = True
        Me.txtSearchStudent.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchStudent.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'listStudent
        '
        Me.listStudent.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listStudent.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.listStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.listStudent.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.listStudent.ForeColor = System.Drawing.Color.Black
        Me.listStudent.FullRowSelect = True
        Me.listStudent.GridLines = True
        Me.listStudent.Location = New System.Drawing.Point(5, 64)
        Me.listStudent.MultiSelect = False
        Me.listStudent.Name = "listStudent"
        Me.listStudent.OwnerDraw = True
        Me.listStudent.ShowGroups = False
        Me.listStudent.Size = New System.Drawing.Size(603, 283)
        Me.listStudent.Style = MetroFramework.MetroColorStyle.Blue
        Me.listStudent.TabIndex = 94
        Me.listStudent.UseCompatibleStateImageBehavior = False
        Me.listStudent.UseSelectable = True
        Me.listStudent.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 321
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Course"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 77
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Student ID"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 175
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(301, 29)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel2.TabIndex = 93
        Me.MetroLabel2.Text = "Search:"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(5, 29)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel3.TabIndex = 92
        Me.MetroLabel3.Text = "Search by:"
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'btnMangeDepartment
        '
        Me.btnMangeDepartment.Location = New System.Drawing.Point(501, 353)
        Me.btnMangeDepartment.Name = "btnMangeDepartment"
        Me.btnMangeDepartment.Size = New System.Drawing.Size(84, 26)
        Me.btnMangeDepartment.TabIndex = 169
        Me.btnMangeDepartment.Text = "Manage"
        Me.btnMangeDepartment.UseSelectable = True
        '
        'comboSearchDepartment
        '
        Me.comboSearchDepartment.FormattingEnabled = True
        Me.comboSearchDepartment.ItemHeight = 23
        Me.comboSearchDepartment.Items.AddRange(New Object() {"Code", "Name"})
        Me.comboSearchDepartment.Location = New System.Drawing.Point(83, 29)
        Me.comboSearchDepartment.Name = "comboSearchDepartment"
        Me.comboSearchDepartment.Size = New System.Drawing.Size(138, 29)
        Me.comboSearchDepartment.Sorted = True
        Me.comboSearchDepartment.TabIndex = 164
        Me.comboSearchDepartment.UseSelectable = True
        '
        'txtSearchDepartment
        '
        '
        '
        '
        Me.txtSearchDepartment.CustomButton.Image = Nothing
        Me.txtSearchDepartment.CustomButton.Location = New System.Drawing.Point(139, 1)
        Me.txtSearchDepartment.CustomButton.Name = ""
        Me.txtSearchDepartment.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearchDepartment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchDepartment.CustomButton.TabIndex = 1
        Me.txtSearchDepartment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchDepartment.CustomButton.UseSelectable = True
        Me.txtSearchDepartment.CustomButton.Visible = False
        Me.txtSearchDepartment.Lines = New String(-1) {}
        Me.txtSearchDepartment.Location = New System.Drawing.Point(424, 29)
        Me.txtSearchDepartment.MaxLength = 32767
        Me.txtSearchDepartment.Name = "txtSearchDepartment"
        Me.txtSearchDepartment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchDepartment.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchDepartment.SelectedText = ""
        Me.txtSearchDepartment.SelectionLength = 0
        Me.txtSearchDepartment.SelectionStart = 0
        Me.txtSearchDepartment.ShortcutsEnabled = True
        Me.txtSearchDepartment.Size = New System.Drawing.Size(161, 23)
        Me.txtSearchDepartment.TabIndex = 165
        Me.txtSearchDepartment.UseSelectable = True
        Me.txtSearchDepartment.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchDepartment.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel12.Location = New System.Drawing.Point(8, 29)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel12.TabIndex = 166
        Me.MetroLabel12.Text = "Search by:"
        Me.MetroLabel12.UseCustomBackColor = True
        '
        'listDepartment
        '
        Me.listDepartment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader18})
        Me.listDepartment.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.listDepartment.FullRowSelect = True
        Me.listDepartment.GridLines = True
        Me.listDepartment.Location = New System.Drawing.Point(83, 64)
        Me.listDepartment.MultiSelect = False
        Me.listDepartment.Name = "listDepartment"
        Me.listDepartment.OwnerDraw = True
        Me.listDepartment.ShowGroups = False
        Me.listDepartment.Size = New System.Drawing.Size(502, 283)
        Me.listDepartment.TabIndex = 168
        Me.listDepartment.UseCompatibleStateImageBehavior = False
        Me.listDepartment.UseSelectable = True
        Me.listDepartment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Department Name"
        Me.ColumnHeader17.Width = 329
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Code"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader18.Width = 134
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.Location = New System.Drawing.Point(367, 29)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel13.TabIndex = 167
        Me.MetroLabel13.Text = "Search:"
        Me.MetroLabel13.UseCustomBackColor = True
        '
        'btnManageCourse
        '
        Me.btnManageCourse.Location = New System.Drawing.Point(524, 353)
        Me.btnManageCourse.Name = "btnManageCourse"
        Me.btnManageCourse.Size = New System.Drawing.Size(84, 26)
        Me.btnManageCourse.TabIndex = 162
        Me.btnManageCourse.Text = "Manage"
        Me.btnManageCourse.UseSelectable = True
        '
        'comboSearchCourse
        '
        Me.comboSearchCourse.FormattingEnabled = True
        Me.comboSearchCourse.ItemHeight = 23
        Me.comboSearchCourse.Items.AddRange(New Object() {"Classification", "Code", "Name", "Year"})
        Me.comboSearchCourse.Location = New System.Drawing.Point(80, 29)
        Me.comboSearchCourse.Name = "comboSearchCourse"
        Me.comboSearchCourse.Size = New System.Drawing.Size(138, 29)
        Me.comboSearchCourse.Sorted = True
        Me.comboSearchCourse.TabIndex = 85
        Me.comboSearchCourse.UseSelectable = True
        '
        'txtSearchCourse
        '
        '
        '
        '
        Me.txtSearchCourse.CustomButton.Image = Nothing
        Me.txtSearchCourse.CustomButton.Location = New System.Drawing.Point(246, 1)
        Me.txtSearchCourse.CustomButton.Name = ""
        Me.txtSearchCourse.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearchCourse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchCourse.CustomButton.TabIndex = 1
        Me.txtSearchCourse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchCourse.CustomButton.UseSelectable = True
        Me.txtSearchCourse.CustomButton.Visible = False
        Me.txtSearchCourse.Lines = New String(-1) {}
        Me.txtSearchCourse.Location = New System.Drawing.Point(340, 29)
        Me.txtSearchCourse.MaxLength = 32767
        Me.txtSearchCourse.Name = "txtSearchCourse"
        Me.txtSearchCourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchCourse.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchCourse.SelectedText = ""
        Me.txtSearchCourse.SelectionLength = 0
        Me.txtSearchCourse.SelectionStart = 0
        Me.txtSearchCourse.ShortcutsEnabled = True
        Me.txtSearchCourse.Size = New System.Drawing.Size(268, 23)
        Me.txtSearchCourse.TabIndex = 86
        Me.txtSearchCourse.UseSelectable = True
        Me.txtSearchCourse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchCourse.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(283, 29)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel7.TabIndex = 88
        Me.MetroLabel7.Text = "Search:"
        Me.MetroLabel7.UseCustomBackColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(5, 29)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel4.TabIndex = 87
        Me.MetroLabel4.Text = "Search by:"
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'listCourse
        '
        Me.listCourse.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader16})
        Me.listCourse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.listCourse.FullRowSelect = True
        Me.listCourse.GridLines = True
        Me.listCourse.Location = New System.Drawing.Point(4, 64)
        Me.listCourse.MultiSelect = False
        Me.listCourse.Name = "listCourse"
        Me.listCourse.OwnerDraw = True
        Me.listCourse.ShowGroups = False
        Me.listCourse.Size = New System.Drawing.Size(604, 283)
        Me.listCourse.TabIndex = 89
        Me.listCourse.UseCompatibleStateImageBehavior = False
        Me.listCourse.UseSelectable = True
        Me.listCourse.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Program Name"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 322
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Code"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 77
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Classification"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 106
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Year(s)"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnManageSection
        '
        Me.btnManageSection.Location = New System.Drawing.Point(491, 353)
        Me.btnManageSection.Name = "btnManageSection"
        Me.btnManageSection.Size = New System.Drawing.Size(94, 26)
        Me.btnManageSection.TabIndex = 163
        Me.btnManageSection.Text = "Manage Section"
        Me.btnManageSection.UseSelectable = True
        '
        'comboSearchSection
        '
        Me.comboSearchSection.FormattingEnabled = True
        Me.comboSearchSection.ItemHeight = 23
        Me.comboSearchSection.Items.AddRange(New Object() {"Course", "ID", "Section"})
        Me.comboSearchSection.Location = New System.Drawing.Point(83, 29)
        Me.comboSearchSection.Name = "comboSearchSection"
        Me.comboSearchSection.Size = New System.Drawing.Size(138, 29)
        Me.comboSearchSection.Sorted = True
        Me.comboSearchSection.TabIndex = 90
        Me.comboSearchSection.UseSelectable = True
        '
        'txtSearchSection
        '
        '
        '
        '
        Me.txtSearchSection.CustomButton.Image = Nothing
        Me.txtSearchSection.CustomButton.Location = New System.Drawing.Point(139, 1)
        Me.txtSearchSection.CustomButton.Name = ""
        Me.txtSearchSection.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearchSection.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchSection.CustomButton.TabIndex = 1
        Me.txtSearchSection.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchSection.CustomButton.UseSelectable = True
        Me.txtSearchSection.CustomButton.Visible = False
        Me.txtSearchSection.Lines = New String(-1) {}
        Me.txtSearchSection.Location = New System.Drawing.Point(424, 29)
        Me.txtSearchSection.MaxLength = 32767
        Me.txtSearchSection.Name = "txtSearchSection"
        Me.txtSearchSection.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchSection.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchSection.SelectedText = ""
        Me.txtSearchSection.SelectionLength = 0
        Me.txtSearchSection.SelectionStart = 0
        Me.txtSearchSection.ShortcutsEnabled = True
        Me.txtSearchSection.Size = New System.Drawing.Size(161, 23)
        Me.txtSearchSection.TabIndex = 91
        Me.txtSearchSection.UseSelectable = True
        Me.txtSearchSection.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchSection.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(8, 29)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel9.TabIndex = 92
        Me.MetroLabel9.Text = "Search by:"
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'listSection
        '
        Me.listSection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.listSection.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.listSection.FullRowSelect = True
        Me.listSection.GridLines = True
        Me.listSection.Location = New System.Drawing.Point(83, 64)
        Me.listSection.MultiSelect = False
        Me.listSection.Name = "listSection"
        Me.listSection.OwnerDraw = True
        Me.listSection.ShowGroups = False
        Me.listSection.Size = New System.Drawing.Size(502, 283)
        Me.listSection.TabIndex = 94
        Me.listSection.UseCompatibleStateImageBehavior = False
        Me.listSection.UseSelectable = True
        Me.listSection.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "I.D."
        Me.ColumnHeader10.Width = 205
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Course"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 134
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Section"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 124
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(367, 29)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel8.TabIndex = 93
        Me.MetroLabel8.Text = "Search:"
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'btnManageSubject
        '
        Me.btnManageSubject.Location = New System.Drawing.Point(524, 353)
        Me.btnManageSubject.Name = "btnManageSubject"
        Me.btnManageSubject.Size = New System.Drawing.Size(84, 26)
        Me.btnManageSubject.TabIndex = 163
        Me.btnManageSubject.Text = "Manage"
        Me.btnManageSubject.UseSelectable = True
        '
        'comboSearchSubject
        '
        Me.comboSearchSubject.FormattingEnabled = True
        Me.comboSearchSubject.ItemHeight = 23
        Me.comboSearchSubject.Items.AddRange(New Object() {"Pre-Requisite", "Subject Code", "Subject Title"})
        Me.comboSearchSubject.Location = New System.Drawing.Point(80, 29)
        Me.comboSearchSubject.Name = "comboSearchSubject"
        Me.comboSearchSubject.Size = New System.Drawing.Size(138, 29)
        Me.comboSearchSubject.Sorted = True
        Me.comboSearchSubject.TabIndex = 90
        Me.comboSearchSubject.UseSelectable = True
        '
        'txtSearchSubject
        '
        '
        '
        '
        Me.txtSearchSubject.CustomButton.Image = Nothing
        Me.txtSearchSubject.CustomButton.Location = New System.Drawing.Point(239, 1)
        Me.txtSearchSubject.CustomButton.Name = ""
        Me.txtSearchSubject.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearchSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchSubject.CustomButton.TabIndex = 1
        Me.txtSearchSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchSubject.CustomButton.UseSelectable = True
        Me.txtSearchSubject.CustomButton.Visible = False
        Me.txtSearchSubject.Lines = New String(-1) {}
        Me.txtSearchSubject.Location = New System.Drawing.Point(347, 29)
        Me.txtSearchSubject.MaxLength = 32767
        Me.txtSearchSubject.Name = "txtSearchSubject"
        Me.txtSearchSubject.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchSubject.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchSubject.SelectedText = ""
        Me.txtSearchSubject.SelectionLength = 0
        Me.txtSearchSubject.SelectionStart = 0
        Me.txtSearchSubject.ShortcutsEnabled = True
        Me.txtSearchSubject.Size = New System.Drawing.Size(261, 23)
        Me.txtSearchSubject.TabIndex = 91
        Me.txtSearchSubject.UseSelectable = True
        Me.txtSearchSubject.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchSubject.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'listSubject
        '
        Me.listSubject.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.listSubject.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.listSubject.FullRowSelect = True
        Me.listSubject.GridLines = True
        Me.listSubject.Location = New System.Drawing.Point(5, 64)
        Me.listSubject.MultiSelect = False
        Me.listSubject.Name = "listSubject"
        Me.listSubject.OwnerDraw = True
        Me.listSubject.ShowGroups = False
        Me.listSubject.Size = New System.Drawing.Size(603, 283)
        Me.listSubject.Style = MetroFramework.MetroColorStyle.Blue
        Me.listSubject.TabIndex = 94
        Me.listSubject.UseCompatibleStateImageBehavior = False
        Me.listSubject.UseSelectable = True
        Me.listSubject.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Subject Title"
        Me.ColumnHeader13.Width = 297
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Subject Code"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 116
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Pre-Requisite"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 157
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(290, 29)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel10.TabIndex = 93
        Me.MetroLabel10.Text = "Search:"
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(5, 29)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel11.TabIndex = 92
        Me.MetroLabel11.Text = "Search by:"
        Me.MetroLabel11.UseCustomBackColor = True
        '
        'txtPassCon
        '
        '
        '
        '
        Me.txtPassCon.CustomButton.Image = Nothing
        Me.txtPassCon.CustomButton.Location = New System.Drawing.Point(96, 1)
        Me.txtPassCon.CustomButton.Name = ""
        Me.txtPassCon.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPassCon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassCon.CustomButton.TabIndex = 1
        Me.txtPassCon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassCon.CustomButton.UseSelectable = True
        Me.txtPassCon.CustomButton.Visible = False
        Me.txtPassCon.Lines = New String(-1) {}
        Me.txtPassCon.Location = New System.Drawing.Point(49, 268)
        Me.txtPassCon.MaxLength = 32767
        Me.txtPassCon.Name = "txtPassCon"
        Me.txtPassCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassCon.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassCon.SelectedText = ""
        Me.txtPassCon.SelectionLength = 0
        Me.txtPassCon.SelectionStart = 0
        Me.txtPassCon.ShortcutsEnabled = True
        Me.txtPassCon.Size = New System.Drawing.Size(118, 23)
        Me.txtPassCon.TabIndex = 199
        Me.txtPassCon.UseSelectable = True
        Me.txtPassCon.UseSystemPasswordChar = True
        Me.txtPassCon.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassCon.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'togglePassCon
        '
        Me.togglePassCon.AutoSize = True
        Me.togglePassCon.Location = New System.Drawing.Point(190, 274)
        Me.togglePassCon.Name = "togglePassCon"
        Me.togglePassCon.Size = New System.Drawing.Size(80, 17)
        Me.togglePassCon.Style = MetroFramework.MetroColorStyle.Teal
        Me.togglePassCon.TabIndex = 200
        Me.togglePassCon.Text = "Off"
        Me.togglePassCon.UseSelectable = True
        '
        'txtPass
        '
        '
        '
        '
        Me.txtPass.CustomButton.Image = Nothing
        Me.txtPass.CustomButton.Location = New System.Drawing.Point(96, 1)
        Me.txtPass.CustomButton.Name = ""
        Me.txtPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPass.CustomButton.TabIndex = 1
        Me.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPass.CustomButton.UseSelectable = True
        Me.txtPass.CustomButton.Visible = False
        Me.txtPass.Lines = New String(-1) {}
        Me.txtPass.Location = New System.Drawing.Point(49, 226)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.Size = New System.Drawing.Size(118, 23)
        Me.txtPass.TabIndex = 197
        Me.txtPass.UseSelectable = True
        Me.txtPass.UseSystemPasswordChar = True
        Me.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel24
        '
        Me.MetroLabel24.AutoSize = True
        Me.MetroLabel24.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel24.Location = New System.Drawing.Point(72, 246)
        Me.MetroLabel24.Name = "MetroLabel24"
        Me.MetroLabel24.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel24.TabIndex = 212
        Me.MetroLabel24.Text = "Password"
        Me.MetroLabel24.UseCustomBackColor = True
        '
        'txtUser
        '
        '
        '
        '
        Me.txtUser.CustomButton.Image = Nothing
        Me.txtUser.CustomButton.Location = New System.Drawing.Point(96, 1)
        Me.txtUser.CustomButton.Name = ""
        Me.txtUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUser.CustomButton.TabIndex = 1
        Me.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUser.CustomButton.UseSelectable = True
        Me.txtUser.CustomButton.Visible = False
        Me.txtUser.Lines = New String(-1) {}
        Me.txtUser.Location = New System.Drawing.Point(49, 184)
        Me.txtUser.MaxLength = 32767
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.ShortcutsEnabled = True
        Me.txtUser.Size = New System.Drawing.Size(118, 23)
        Me.txtUser.TabIndex = 196
        Me.txtUser.UseSelectable = True
        Me.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'togglePass
        '
        Me.togglePass.AutoSize = True
        Me.togglePass.Location = New System.Drawing.Point(190, 231)
        Me.togglePass.Name = "togglePass"
        Me.togglePass.Size = New System.Drawing.Size(80, 17)
        Me.togglePass.TabIndex = 198
        Me.togglePass.Text = "Off"
        Me.togglePass.UseSelectable = True
        '
        'MetroLabel29
        '
        Me.MetroLabel29.AutoSize = True
        Me.MetroLabel29.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel29.Location = New System.Drawing.Point(70, 204)
        Me.MetroLabel29.Name = "MetroLabel29"
        Me.MetroLabel29.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel29.TabIndex = 211
        Me.MetroLabel29.Text = "Username"
        Me.MetroLabel29.UseCustomBackColor = True
        '
        'txtSuffix
        '
        '
        '
        '
        Me.txtSuffix.CustomButton.Image = Nothing
        Me.txtSuffix.CustomButton.Location = New System.Drawing.Point(11, 1)
        Me.txtSuffix.CustomButton.Name = ""
        Me.txtSuffix.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSuffix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSuffix.CustomButton.TabIndex = 1
        Me.txtSuffix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSuffix.CustomButton.UseSelectable = True
        Me.txtSuffix.CustomButton.Visible = False
        Me.txtSuffix.Lines = New String(-1) {}
        Me.txtSuffix.Location = New System.Drawing.Point(545, 135)
        Me.txtSuffix.MaxLength = 32767
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuffix.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSuffix.SelectedText = ""
        Me.txtSuffix.SelectionLength = 0
        Me.txtSuffix.SelectionStart = 0
        Me.txtSuffix.ShortcutsEnabled = True
        Me.txtSuffix.Size = New System.Drawing.Size(33, 23)
        Me.txtSuffix.TabIndex = 195
        Me.txtSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSuffix.UseSelectable = True
        Me.txtSuffix.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSuffix.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel30.Location = New System.Drawing.Point(540, 155)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel30.TabIndex = 210
        Me.MetroLabel30.Text = "Suffix"
        Me.MetroLabel30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLabel30.UseCustomBackColor = True
        '
        'comboGender
        '
        Me.comboGender.FormattingEnabled = True
        Me.comboGender.ItemHeight = 23
        Me.comboGender.Items.AddRange(New Object() {"FEMALE", "MALE"})
        Me.comboGender.Location = New System.Drawing.Point(297, 178)
        Me.comboGender.Name = "comboGender"
        Me.comboGender.Size = New System.Drawing.Size(118, 29)
        Me.comboGender.TabIndex = 201
        Me.comboGender.UseSelectable = True
        '
        'MetroLabel31
        '
        Me.MetroLabel31.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel31.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel31.ForeColor = System.Drawing.Color.Transparent
        Me.MetroLabel31.Location = New System.Drawing.Point(31, 87)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(384, 22)
        Me.MetroLabel31.TabIndex = 209
        Me.MetroLabel31.Text = "Note:  Please type N/A on field(s) if none"
        Me.MetroLabel31.UseCustomBackColor = True
        '
        'MetroLabel32
        '
        Me.MetroLabel32.AutoSize = True
        Me.MetroLabel32.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel32.Location = New System.Drawing.Point(331, 204)
        Me.MetroLabel32.Name = "MetroLabel32"
        Me.MetroLabel32.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel32.TabIndex = 208
        Me.MetroLabel32.Text = "Gender"
        Me.MetroLabel32.UseCustomBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(421, 268)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 26)
        Me.btnClear.TabIndex = 203
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseSelectable = True
        '
        'txtmiddle
        '
        '
        '
        '
        Me.txtmiddle.CustomButton.Image = Nothing
        Me.txtmiddle.CustomButton.Location = New System.Drawing.Point(96, 1)
        Me.txtmiddle.CustomButton.Name = ""
        Me.txtmiddle.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtmiddle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtmiddle.CustomButton.TabIndex = 1
        Me.txtmiddle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtmiddle.CustomButton.UseSelectable = True
        Me.txtmiddle.CustomButton.Visible = False
        Me.txtmiddle.Lines = New String(-1) {}
        Me.txtmiddle.Location = New System.Drawing.Point(297, 136)
        Me.txtmiddle.MaxLength = 32767
        Me.txtmiddle.Name = "txtmiddle"
        Me.txtmiddle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmiddle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmiddle.SelectedText = ""
        Me.txtmiddle.SelectionLength = 0
        Me.txtmiddle.SelectionStart = 0
        Me.txtmiddle.ShortcutsEnabled = True
        Me.txtmiddle.Size = New System.Drawing.Size(118, 23)
        Me.txtmiddle.TabIndex = 193
        Me.txtmiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtmiddle.UseSelectable = True
        Me.txtmiddle.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtmiddle.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel33
        '
        Me.MetroLabel33.AutoSize = True
        Me.MetroLabel33.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel33.Location = New System.Drawing.Point(314, 156)
        Me.MetroLabel33.Name = "MetroLabel33"
        Me.MetroLabel33.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel33.TabIndex = 207
        Me.MetroLabel33.Text = "Middle Initial"
        Me.MetroLabel33.UseCustomBackColor = True
        '
        'txtsname
        '
        '
        '
        '
        Me.txtsname.CustomButton.Image = Nothing
        Me.txtsname.CustomButton.Location = New System.Drawing.Point(96, 1)
        Me.txtsname.CustomButton.Name = ""
        Me.txtsname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtsname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsname.CustomButton.TabIndex = 1
        Me.txtsname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsname.CustomButton.UseSelectable = True
        Me.txtsname.CustomButton.Visible = False
        Me.txtsname.Lines = New String(-1) {}
        Me.txtsname.Location = New System.Drawing.Point(421, 136)
        Me.txtsname.MaxLength = 32767
        Me.txtsname.Name = "txtsname"
        Me.txtsname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsname.SelectedText = ""
        Me.txtsname.SelectionLength = 0
        Me.txtsname.SelectionStart = 0
        Me.txtsname.ShortcutsEnabled = True
        Me.txtsname.Size = New System.Drawing.Size(118, 23)
        Me.txtsname.TabIndex = 194
        Me.txtsname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtsname.UseSelectable = True
        Me.txtsname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel34
        '
        Me.MetroLabel34.AutoSize = True
        Me.MetroLabel34.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel34.Location = New System.Drawing.Point(444, 156)
        Me.MetroLabel34.Name = "MetroLabel34"
        Me.MetroLabel34.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel34.TabIndex = 206
        Me.MetroLabel34.Text = "Last Name"
        Me.MetroLabel34.UseCustomBackColor = True
        '
        'txtfname
        '
        '
        '
        '
        Me.txtfname.CustomButton.Image = Nothing
        Me.txtfname.CustomButton.Location = New System.Drawing.Point(96, 1)
        Me.txtfname.CustomButton.Name = ""
        Me.txtfname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtfname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtfname.CustomButton.TabIndex = 1
        Me.txtfname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtfname.CustomButton.UseSelectable = True
        Me.txtfname.CustomButton.Visible = False
        Me.txtfname.Lines = New String(-1) {}
        Me.txtfname.Location = New System.Drawing.Point(173, 136)
        Me.txtfname.MaxLength = 32767
        Me.txtfname.Name = "txtfname"
        Me.txtfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtfname.SelectedText = ""
        Me.txtfname.SelectionLength = 0
        Me.txtfname.SelectionStart = 0
        Me.txtfname.ShortcutsEnabled = True
        Me.txtfname.Size = New System.Drawing.Size(118, 23)
        Me.txtfname.TabIndex = 192
        Me.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtfname.UseSelectable = True
        Me.txtfname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtfname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel35
        '
        Me.MetroLabel35.AutoSize = True
        Me.MetroLabel35.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel35.Location = New System.Drawing.Point(196, 156)
        Me.MetroLabel35.Name = "MetroLabel35"
        Me.MetroLabel35.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel35.TabIndex = 205
        Me.MetroLabel35.Text = "First Name"
        Me.MetroLabel35.UseCustomBackColor = True
        '
        'txtID
        '
        '
        '
        '
        Me.txtID.CustomButton.Image = Nothing
        Me.txtID.CustomButton.Location = New System.Drawing.Point(96, 1)
        Me.txtID.CustomButton.Name = ""
        Me.txtID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtID.CustomButton.TabIndex = 1
        Me.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtID.CustomButton.UseSelectable = True
        Me.txtID.CustomButton.Visible = False
        Me.txtID.Lines = New String(-1) {}
        Me.txtID.Location = New System.Drawing.Point(49, 136)
        Me.txtID.MaxLength = 32767
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtID.SelectedText = ""
        Me.txtID.SelectionLength = 0
        Me.txtID.SelectionStart = 0
        Me.txtID.ShortcutsEnabled = True
        Me.txtID.Size = New System.Drawing.Size(118, 23)
        Me.txtID.TabIndex = 191
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtID.UseSelectable = True
        Me.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel37
        '
        Me.MetroLabel37.AutoSize = True
        Me.MetroLabel37.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel37.Location = New System.Drawing.Point(64, 156)
        Me.MetroLabel37.Name = "MetroLabel37"
        Me.MetroLabel37.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel37.TabIndex = 204
        Me.MetroLabel37.Text = "Employee ID"
        Me.MetroLabel37.UseCustomBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(331, 268)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 26)
        Me.btnUpdate.TabIndex = 202
        Me.btnUpdate.Text = "Register"
        Me.btnUpdate.UseSelectable = True
        '
        'MetroLabel38
        '
        Me.MetroLabel38.AutoSize = True
        Me.MetroLabel38.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel38.Location = New System.Drawing.Point(182, 213)
        Me.MetroLabel38.Name = "MetroLabel38"
        Me.MetroLabel38.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel38.TabIndex = 213
        Me.MetroLabel38.Text = "Show Password"
        Me.MetroLabel38.UseCustomBackColor = True
        '
        'MetroLabel39
        '
        Me.MetroLabel39.AutoSize = True
        Me.MetroLabel39.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel39.Location = New System.Drawing.Point(51, 287)
        Me.MetroLabel39.Name = "MetroLabel39"
        Me.MetroLabel39.Size = New System.Drawing.Size(113, 19)
        Me.MetroLabel39.TabIndex = 214
        Me.MetroLabel39.Text = "Re-type Password"
        Me.MetroLabel39.UseCustomBackColor = True
        '
        'MetroLabel40
        '
        Me.MetroLabel40.AutoSize = True
        Me.MetroLabel40.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel40.Location = New System.Drawing.Point(182, 256)
        Me.MetroLabel40.Name = "MetroLabel40"
        Me.MetroLabel40.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel40.TabIndex = 215
        Me.MetroLabel40.Text = "Show Password"
        Me.MetroLabel40.UseCustomBackColor = True
        '
        'checkNeeded
        '
        Me.checkNeeded.AutoSize = True
        Me.checkNeeded.BackColor = System.Drawing.Color.Transparent
        Me.checkNeeded.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.checkNeeded.Location = New System.Drawing.Point(70, 247)
        Me.checkNeeded.Name = "checkNeeded"
        Me.checkNeeded.Size = New System.Drawing.Size(146, 15)
        Me.checkNeeded.TabIndex = 153
        Me.checkNeeded.Text = "Need for modification"
        Me.checkNeeded.UseCustomBackColor = True
        Me.checkNeeded.UseSelectable = True
        '
        'MetroLabel25
        '
        Me.MetroLabel25.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel25.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel25.ForeColor = System.Drawing.Color.Transparent
        Me.MetroLabel25.Location = New System.Drawing.Point(313, 258)
        Me.MetroLabel25.Name = "MetroLabel25"
        Me.MetroLabel25.Size = New System.Drawing.Size(298, 42)
        Me.MetroLabel25.TabIndex = 152
        Me.MetroLabel25.Text = "Note:  Please check 'Need for modification' " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                     if the report " & _
            "is outdated"
        Me.MetroLabel25.UseCustomBackColor = True
        '
        'btnPrintIndividual
        '
        Me.btnPrintIndividual.Location = New System.Drawing.Point(442, 194)
        Me.btnPrintIndividual.Name = "btnPrintIndividual"
        Me.btnPrintIndividual.Size = New System.Drawing.Size(164, 23)
        Me.btnPrintIndividual.TabIndex = 116
        Me.btnPrintIndividual.Text = "Print by Individual"
        Me.btnPrintIndividual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintIndividual.UseSelectable = True
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel23.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel23.Location = New System.Drawing.Point(3, 208)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(284, 25)
        Me.MetroLabel23.TabIndex = 115
        Me.MetroLabel23.Text = "Corrrect the report if necessary:"
        Me.MetroLabel23.UseCustomBackColor = True
        '
        'txtName1
        '
        '
        '
        '
        Me.txtName1.CustomButton.Image = Nothing
        Me.txtName1.CustomButton.Location = New System.Drawing.Point(161, 1)
        Me.txtName1.CustomButton.Name = ""
        Me.txtName1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtName1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName1.CustomButton.TabIndex = 1
        Me.txtName1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName1.CustomButton.UseSelectable = True
        Me.txtName1.CustomButton.Visible = False
        Me.txtName1.Lines = New String() {"Lucila C. Berbie"}
        Me.txtName1.Location = New System.Drawing.Point(78, 310)
        Me.txtName1.MaxLength = 32767
        Me.txtName1.Name = "txtName1"
        Me.txtName1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName1.SelectedText = ""
        Me.txtName1.SelectionLength = 0
        Me.txtName1.SelectionStart = 0
        Me.txtName1.ShortcutsEnabled = True
        Me.txtName1.Size = New System.Drawing.Size(183, 23)
        Me.txtName1.TabIndex = 113
        Me.txtName1.Text = "Lucila C. Berbie"
        Me.txtName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtName1.UseSelectable = True
        Me.txtName1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel19.Location = New System.Drawing.Point(14, 310)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel19.TabIndex = 114
        Me.MetroLabel19.Text = "Name:"
        Me.MetroLabel19.UseCustomBackColor = True
        '
        'txtPos1
        '
        '
        '
        '
        Me.txtPos1.CustomButton.Image = Nothing
        Me.txtPos1.CustomButton.Location = New System.Drawing.Point(161, 1)
        Me.txtPos1.CustomButton.Name = ""
        Me.txtPos1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPos1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPos1.CustomButton.TabIndex = 1
        Me.txtPos1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPos1.CustomButton.UseSelectable = True
        Me.txtPos1.CustomButton.Visible = False
        Me.txtPos1.Lines = New String() {"Director, Instruction"}
        Me.txtPos1.Location = New System.Drawing.Point(78, 339)
        Me.txtPos1.MaxLength = 32767
        Me.txtPos1.Name = "txtPos1"
        Me.txtPos1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPos1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPos1.SelectedText = ""
        Me.txtPos1.SelectionLength = 0
        Me.txtPos1.SelectionStart = 0
        Me.txtPos1.ShortcutsEnabled = True
        Me.txtPos1.Size = New System.Drawing.Size(183, 23)
        Me.txtPos1.TabIndex = 111
        Me.txtPos1.Text = "Director, Instruction"
        Me.txtPos1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPos1.UseSelectable = True
        Me.txtPos1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPos1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel20.Location = New System.Drawing.Point(14, 339)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel20.TabIndex = 112
        Me.MetroLabel20.Text = "Position;"
        Me.MetroLabel20.UseCustomBackColor = True
        '
        'txtTitle
        '
        '
        '
        '
        Me.txtTitle.CustomButton.Image = Nothing
        Me.txtTitle.CustomButton.Location = New System.Drawing.Point(28, 1)
        Me.txtTitle.CustomButton.Name = ""
        Me.txtTitle.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTitle.CustomButton.TabIndex = 1
        Me.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTitle.CustomButton.UseSelectable = True
        Me.txtTitle.CustomButton.Visible = False
        Me.txtTitle.Lines = New String() {"Engr."}
        Me.txtTitle.Location = New System.Drawing.Point(120, 281)
        Me.txtTitle.MaxLength = 32767
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTitle.SelectedText = ""
        Me.txtTitle.SelectionLength = 0
        Me.txtTitle.SelectionStart = 0
        Me.txtTitle.ShortcutsEnabled = True
        Me.txtTitle.Size = New System.Drawing.Size(50, 23)
        Me.txtTitle.TabIndex = 110
        Me.txtTitle.Text = "Engr."
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTitle.UseSelectable = True
        Me.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTitle.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel18.Location = New System.Drawing.Point(13, 281)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel18.TabIndex = 109
        Me.MetroLabel18.Text = "Title of Teacher:"
        Me.MetroLabel18.UseCustomBackColor = True
        '
        'txtName2
        '
        '
        '
        '
        Me.txtName2.CustomButton.Image = Nothing
        Me.txtName2.CustomButton.Location = New System.Drawing.Point(161, 1)
        Me.txtName2.CustomButton.Name = ""
        Me.txtName2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtName2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName2.CustomButton.TabIndex = 1
        Me.txtName2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName2.CustomButton.UseSelectable = True
        Me.txtName2.CustomButton.Visible = False
        Me.txtName2.Lines = New String() {"Jose P. Lisama"}
        Me.txtName2.Location = New System.Drawing.Point(356, 310)
        Me.txtName2.MaxLength = 32767
        Me.txtName2.Name = "txtName2"
        Me.txtName2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName2.SelectedText = ""
        Me.txtName2.SelectionLength = 0
        Me.txtName2.SelectionStart = 0
        Me.txtName2.ShortcutsEnabled = True
        Me.txtName2.Size = New System.Drawing.Size(183, 23)
        Me.txtName2.TabIndex = 107
        Me.txtName2.Text = "Jose P. Lisama"
        Me.txtName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtName2.UseSelectable = True
        Me.txtName2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel15.Location = New System.Drawing.Point(293, 310)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel15.TabIndex = 108
        Me.MetroLabel15.Text = "Name:"
        Me.MetroLabel15.UseCustomBackColor = True
        '
        'txtPos2
        '
        '
        '
        '
        Me.txtPos2.CustomButton.Image = Nothing
        Me.txtPos2.CustomButton.Location = New System.Drawing.Point(161, 1)
        Me.txtPos2.CustomButton.Name = ""
        Me.txtPos2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPos2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPos2.CustomButton.TabIndex = 1
        Me.txtPos2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPos2.CustomButton.UseSelectable = True
        Me.txtPos2.CustomButton.Visible = False
        Me.txtPos2.Lines = New String() {"Campus Administrator"}
        Me.txtPos2.Location = New System.Drawing.Point(356, 339)
        Me.txtPos2.MaxLength = 32767
        Me.txtPos2.Name = "txtPos2"
        Me.txtPos2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPos2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPos2.SelectedText = ""
        Me.txtPos2.SelectionLength = 0
        Me.txtPos2.SelectionStart = 0
        Me.txtPos2.ShortcutsEnabled = True
        Me.txtPos2.Size = New System.Drawing.Size(183, 23)
        Me.txtPos2.TabIndex = 105
        Me.txtPos2.Text = "Campus Administrator"
        Me.txtPos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPos2.UseSelectable = True
        Me.txtPos2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPos2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel14.Location = New System.Drawing.Point(293, 339)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel14.TabIndex = 106
        Me.MetroLabel14.Text = "Position;"
        Me.MetroLabel14.UseCustomBackColor = True
        '
        'comboReport
        '
        Me.comboReport.FormattingEnabled = True
        Me.comboReport.ItemHeight = 23
        Me.comboReport.Items.AddRange(New Object() {"Department", "First Name", "ID", "Last Name"})
        Me.comboReport.Location = New System.Drawing.Point(78, 32)
        Me.comboReport.Name = "comboReport"
        Me.comboReport.Size = New System.Drawing.Size(138, 29)
        Me.comboReport.Sorted = True
        Me.comboReport.TabIndex = 100
        Me.comboReport.UseSelectable = True
        '
        'txtReport
        '
        '
        '
        '
        Me.txtReport.CustomButton.Image = Nothing
        Me.txtReport.CustomButton.Location = New System.Drawing.Point(229, 1)
        Me.txtReport.CustomButton.Name = ""
        Me.txtReport.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtReport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReport.CustomButton.TabIndex = 1
        Me.txtReport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReport.CustomButton.UseSelectable = True
        Me.txtReport.CustomButton.Visible = False
        Me.txtReport.Lines = New String(-1) {}
        Me.txtReport.Location = New System.Drawing.Point(356, 32)
        Me.txtReport.MaxLength = 32767
        Me.txtReport.Name = "txtReport"
        Me.txtReport.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReport.SelectedText = ""
        Me.txtReport.SelectionLength = 0
        Me.txtReport.SelectionStart = 0
        Me.txtReport.ShortcutsEnabled = True
        Me.txtReport.Size = New System.Drawing.Size(251, 23)
        Me.txtReport.TabIndex = 101
        Me.txtReport.UseSelectable = True
        Me.txtReport.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReport.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'listReport
        '
        Me.listReport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21})
        Me.listReport.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.listReport.FullRowSelect = True
        Me.listReport.GridLines = True
        Me.listReport.Location = New System.Drawing.Point(3, 67)
        Me.listReport.MultiSelect = False
        Me.listReport.Name = "listReport"
        Me.listReport.OwnerDraw = True
        Me.listReport.ShowGroups = False
        Me.listReport.Size = New System.Drawing.Size(603, 121)
        Me.listReport.TabIndex = 104
        Me.listReport.UseCompatibleStateImageBehavior = False
        Me.listReport.UseSelectable = True
        Me.listReport.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Name"
        Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader19.Width = 303
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Department"
        Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader20.Width = 111
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Employee ID"
        Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader21.Width = 153
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel16.Location = New System.Drawing.Point(299, 32)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel16.TabIndex = 103
        Me.MetroLabel16.Text = "Search:"
        Me.MetroLabel16.UseCustomBackColor = True
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel17.Location = New System.Drawing.Point(3, 32)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel17.TabIndex = 102
        Me.MetroLabel17.Text = "Search by:"
        Me.MetroLabel17.UseCustomBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MetroLabel1.Location = New System.Drawing.Point(675, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Admin Panel"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.comboSem)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel26)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel22)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel21)
        Me.MetroPanel2.Controls.Add(Me.btnUpdateAdmin)
        Me.MetroPanel2.Controls.Add(Me.btnDelete)
        Me.MetroPanel2.Controls.Add(Me.btnReport)
        Me.MetroPanel2.Controls.Add(Me.btnCreate)
        Me.MetroPanel2.Controls.Add(Me.btnInsert)
        Me.MetroPanel2.Controls.Add(Me.btnTeacher)
        Me.MetroPanel2.Controls.Add(Me.btnSelect)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(-1, 50)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(165, 526)
        Me.MetroPanel2.TabIndex = 3
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'comboSem
        '
        Me.comboSem.FormattingEnabled = True
        Me.comboSem.ItemHeight = 23
        Me.comboSem.Location = New System.Drawing.Point(16, 143)
        Me.comboSem.Name = "comboSem"
        Me.comboSem.Size = New System.Drawing.Size(121, 29)
        Me.comboSem.TabIndex = 208
        Me.comboSem.UseSelectable = True
        '
        'MetroLabel26
        '
        Me.MetroLabel26.AutoSize = True
        Me.MetroLabel26.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel26.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel26.Location = New System.Drawing.Point(23, 121)
        Me.MetroLabel26.Name = "MetroLabel26"
        Me.MetroLabel26.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel26.TabIndex = 207
        Me.MetroLabel26.Text = "Dropdown List"
        Me.MetroLabel26.UseCustomBackColor = True
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel22.Location = New System.Drawing.Point(-1, 403)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel22.TabIndex = 206
        Me.MetroLabel22.Text = "More"
        Me.MetroLabel22.UseCustomBackColor = True
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel21.Location = New System.Drawing.Point(-1, 185)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel21.TabIndex = 205
        Me.MetroLabel21.Text = "Main"
        Me.MetroLabel21.UseCustomBackColor = True
        '
        'btnUpdateAdmin
        '
        Me.btnUpdateAdmin.Location = New System.Drawing.Point(-1, 450)
        Me.btnUpdateAdmin.Name = "btnUpdateAdmin"
        Me.btnUpdateAdmin.Size = New System.Drawing.Size(165, 23)
        Me.btnUpdateAdmin.TabIndex = 8
        Me.btnUpdateAdmin.Text = "Update Account"
        Me.btnUpdateAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateAdmin.UseSelectable = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(0, 282)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(165, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.UseSelectable = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(0, 425)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(164, 23)
        Me.btnReport.TabIndex = 7
        Me.btnReport.Text = "Report"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.UseSelectable = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(0, 307)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(165, 23)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "Create"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreate.UseSelectable = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(0, 257)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(165, 23)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.UseSelectable = True
        '
        'btnTeacher
        '
        Me.btnTeacher.Location = New System.Drawing.Point(0, 232)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(165, 23)
        Me.btnTeacher.TabIndex = 1
        Me.btnTeacher.Text = "Update"
        Me.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacher.UseSelectable = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(692, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(93, 46)
        Me.btnLogout.TabIndex = 91
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(200, 100)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'txtWelcome
        '
        Me.txtWelcome.AutoSize = True
        Me.txtWelcome.BackColor = System.Drawing.Color.Transparent
        Me.txtWelcome.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.txtWelcome.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.txtWelcome.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtWelcome.Location = New System.Drawing.Point(27, 24)
        Me.txtWelcome.Name = "txtWelcome"
        Me.txtWelcome.Size = New System.Drawing.Size(136, 25)
        Me.txtWelcome.TabIndex = 4
        Me.txtWelcome.Text = "Welcome back"
        Me.txtWelcome.UseCustomBackColor = True
        Me.txtWelcome.UseCustomForeColor = True
        '
        'txtCaption
        '
        Me.txtCaption.AutoSize = True
        Me.txtCaption.BackColor = System.Drawing.Color.DarkGreen
        Me.txtCaption.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.txtCaption.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.txtCaption.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtCaption.Location = New System.Drawing.Point(17, 93)
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.Size = New System.Drawing.Size(282, 25)
        Me.txtCaption.TabIndex = 3
        Me.txtCaption.Text = "Let's manage this school, Let's go!"
        Me.txtCaption.UseCustomBackColor = True
        Me.txtCaption.UseCustomForeColor = True
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAdmin"
        Me.Text = "Admin Panel"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSelect As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnInsert As MetroFramework.Controls.MetroButton
    Friend WithEvents btnTeacher As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage5 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage6 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnCreate As MetroFramework.Controls.MetroButton
    Friend WithEvents listCourse As MetroFramework.Controls.MetroListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents comboSearchCourse As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSearchCourse As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnLogout As MetroFramework.Controls.MetroButton
    Friend WithEvents comboSearchStudent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearchStudent As MetroFramework.Controls.MetroTextBox
    Friend WithEvents listStudent As MetroFramework.Controls.MetroListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents comboSearchTeacher As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearchTeacher As MetroFramework.Controls.MetroTextBox
    Friend WithEvents listTeacher As MetroFramework.Controls.MetroListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents comboSearchSection As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearchSection As MetroFramework.Controls.MetroTextBox
    Friend WithEvents listSection As MetroFramework.Controls.MetroListView
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents comboSearchSubject As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearchSubject As MetroFramework.Controls.MetroTextBox
    Friend WithEvents listSubject As MetroFramework.Controls.MetroListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnManageCourse As MetroFramework.Controls.MetroButton
    Friend WithEvents btnManageSection As MetroFramework.Controls.MetroButton
    Friend WithEvents btnManageSubject As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabPage7 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnManageStudent As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMangeDepartment As MetroFramework.Controls.MetroButton
    Friend WithEvents comboSearchDepartment As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearchDepartment As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listDepartment As MetroFramework.Controls.MetroListView
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnManageTeacher As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReport As MetroFramework.Controls.MetroButton
    Friend WithEvents txtWelcome As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCaption As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabPage8 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage9 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtPassCon As MetroFramework.Controls.MetroTextBox
    Friend WithEvents togglePassCon As MetroFramework.Controls.MetroToggle
    Friend WithEvents txtPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel24 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents togglePass As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel29 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSuffix As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents comboGender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel31 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel32 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
    Friend WithEvents txtmiddle As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel33 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtsname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel34 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtfname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel35 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel38 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel39 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel40 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel37 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnUpdateAdmin As MetroFramework.Controls.MetroButton
    Friend WithEvents comboReport As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtReport As MetroFramework.Controls.MetroTextBox
    Friend WithEvents listReport As MetroFramework.Controls.MetroListView
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtName2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPos2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtName1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPos1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTitle As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnPrintIndividual As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents checkNeeded As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel25 As MetroFramework.Controls.MetroLabel
    Friend WithEvents comboSem As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel26 As MetroFramework.Controls.MetroLabel
End Class
