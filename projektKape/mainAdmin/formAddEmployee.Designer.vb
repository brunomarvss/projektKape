<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddEmployee
    Inherits MetroFramework.Forms.MetroForm
    'Inherits System.Windows.Forms.Form

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
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtLname = New MetroFramework.Controls.MetroTextBox()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtFname = New MetroFramework.Controls.MetroTextBox()
        Me.txtSuffix = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtMname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtProvince = New MetroFramework.Controls.MetroTextBox()
        Me.txtCity = New MetroFramework.Controls.MetroTextBox()
        Me.txtAddress = New MetroFramework.Controls.MetroTextBox()
        Me.txtContact = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtJobTitle = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(27, 49)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(609, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "_________________________________________________________________________________" &
    "___________________"
        '
        'txtLname
        '
        '
        '
        '
        Me.txtLname.CustomButton.Image = Nothing
        Me.txtLname.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtLname.CustomButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtLname.CustomButton.Name = ""
        Me.txtLname.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtLname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLname.CustomButton.TabIndex = 1
        Me.txtLname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLname.CustomButton.UseSelectable = True
        Me.txtLname.CustomButton.Visible = False
        Me.txtLname.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtLname.Lines = New String() {"Last Name"}
        Me.txtLname.Location = New System.Drawing.Point(126, 241)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtLname.MaxLength = 32767
        Me.txtLname.Multiline = True
        Me.txtLname.Name = "txtLname"
        Me.txtLname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLname.SelectedText = ""
        Me.txtLname.SelectionLength = 0
        Me.txtLname.SelectionStart = 0
        Me.txtLname.ShortcutsEnabled = True
        Me.txtLname.Size = New System.Drawing.Size(186, 35)
        Me.txtLname.TabIndex = 1
        Me.txtLname.Text = "Last Name"
        Me.txtLname.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLname.UseSelectable = True
        Me.txtLname.UseStyleColors = True
        Me.txtLname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSave.Location = New System.Drawing.Point(160, 465)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(107, 0, 107, 164)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(315, 48)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(46, 109)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(288, 57)
        Me.MetroLabel1.TabIndex = 7
        Me.MetroLabel1.Text = "-Input the credentials of your employee." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Leave or skip the text field if not ap" &
    "plicable." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Required to fill-up fields that has asterisk mark."
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(27, 80)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(59, 25)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Note:"
        '
        'txtFname
        '
        '
        '
        '
        Me.txtFname.CustomButton.Image = Nothing
        Me.txtFname.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtFname.CustomButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtFname.CustomButton.Name = ""
        Me.txtFname.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFname.CustomButton.TabIndex = 1
        Me.txtFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFname.CustomButton.UseSelectable = True
        Me.txtFname.CustomButton.Visible = False
        Me.txtFname.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtFname.Lines = New String() {"First Name"}
        Me.txtFname.Location = New System.Drawing.Point(126, 298)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtFname.MaxLength = 32767
        Me.txtFname.Multiline = True
        Me.txtFname.Name = "txtFname"
        Me.txtFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFname.SelectedText = ""
        Me.txtFname.SelectionLength = 0
        Me.txtFname.SelectionStart = 0
        Me.txtFname.ShortcutsEnabled = True
        Me.txtFname.Size = New System.Drawing.Size(186, 35)
        Me.txtFname.TabIndex = 2
        Me.txtFname.Text = "First Name"
        Me.txtFname.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFname.UseSelectable = True
        Me.txtFname.UseStyleColors = True
        Me.txtFname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSuffix
        '
        '
        '
        '
        Me.txtSuffix.CustomButton.Image = Nothing
        Me.txtSuffix.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtSuffix.CustomButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtSuffix.CustomButton.Name = ""
        Me.txtSuffix.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtSuffix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSuffix.CustomButton.TabIndex = 1
        Me.txtSuffix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSuffix.CustomButton.UseSelectable = True
        Me.txtSuffix.CustomButton.Visible = False
        Me.txtSuffix.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSuffix.Lines = New String() {"Suffix"}
        Me.txtSuffix.Location = New System.Drawing.Point(126, 388)
        Me.txtSuffix.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtSuffix.MaxLength = 32767
        Me.txtSuffix.Multiline = True
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuffix.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSuffix.SelectedText = ""
        Me.txtSuffix.SelectionLength = 0
        Me.txtSuffix.SelectionStart = 0
        Me.txtSuffix.ShortcutsEnabled = True
        Me.txtSuffix.Size = New System.Drawing.Size(186, 35)
        Me.txtSuffix.TabIndex = 4
        Me.txtSuffix.Text = "Suffix"
        Me.txtSuffix.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSuffix.UseSelectable = True
        Me.txtSuffix.UseStyleColors = True
        Me.txtSuffix.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSuffix.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(50, 241)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(67, 25)
        Me.MetroLabel4.TabIndex = 12
        Me.MetroLabel4.Text = "Name:"
        '
        'txtMname
        '
        '
        '
        '
        Me.txtMname.CustomButton.Image = Nothing
        Me.txtMname.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtMname.CustomButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtMname.CustomButton.Name = ""
        Me.txtMname.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtMname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMname.CustomButton.TabIndex = 1
        Me.txtMname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMname.CustomButton.UseSelectable = True
        Me.txtMname.CustomButton.Visible = False
        Me.txtMname.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtMname.Lines = New String() {"Middle Name"}
        Me.txtMname.Location = New System.Drawing.Point(126, 343)
        Me.txtMname.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtMname.MaxLength = 32767
        Me.txtMname.Multiline = True
        Me.txtMname.Name = "txtMname"
        Me.txtMname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMname.SelectedText = ""
        Me.txtMname.SelectionLength = 0
        Me.txtMname.SelectionStart = 0
        Me.txtMname.ShortcutsEnabled = True
        Me.txtMname.Size = New System.Drawing.Size(186, 35)
        Me.txtMname.TabIndex = 3
        Me.txtMname.Text = "Middle Name"
        Me.txtMname.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMname.UseSelectable = True
        Me.txtMname.UseStyleColors = True
        Me.txtMname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(344, 184)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(87, 25)
        Me.MetroLabel5.TabIndex = 17
        Me.MetroLabel5.Text = "Phone #:"
        '
        'txtProvince
        '
        '
        '
        '
        Me.txtProvince.CustomButton.Image = Nothing
        Me.txtProvince.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtProvince.CustomButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtProvince.CustomButton.Name = ""
        Me.txtProvince.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtProvince.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtProvince.CustomButton.TabIndex = 1
        Me.txtProvince.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtProvince.CustomButton.UseSelectable = True
        Me.txtProvince.CustomButton.Visible = False
        Me.txtProvince.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtProvince.Lines = New String() {"Province"}
        Me.txtProvince.Location = New System.Drawing.Point(440, 331)
        Me.txtProvince.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtProvince.MaxLength = 32767
        Me.txtProvince.Multiline = True
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProvince.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtProvince.SelectedText = ""
        Me.txtProvince.SelectionLength = 0
        Me.txtProvince.SelectionStart = 0
        Me.txtProvince.ShortcutsEnabled = True
        Me.txtProvince.Size = New System.Drawing.Size(186, 35)
        Me.txtProvince.TabIndex = 8
        Me.txtProvince.Text = "Province"
        Me.txtProvince.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtProvince.UseSelectable = True
        Me.txtProvince.UseStyleColors = True
        Me.txtProvince.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtProvince.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCity
        '
        '
        '
        '
        Me.txtCity.CustomButton.Image = Nothing
        Me.txtCity.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtCity.CustomButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtCity.CustomButton.Name = ""
        Me.txtCity.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCity.CustomButton.TabIndex = 1
        Me.txtCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCity.CustomButton.UseSelectable = True
        Me.txtCity.CustomButton.Visible = False
        Me.txtCity.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtCity.Lines = New String() {"City"}
        Me.txtCity.Location = New System.Drawing.Point(440, 286)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtCity.MaxLength = 32767
        Me.txtCity.Multiline = True
        Me.txtCity.Name = "txtCity"
        Me.txtCity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCity.SelectedText = ""
        Me.txtCity.SelectionLength = 0
        Me.txtCity.SelectionStart = 0
        Me.txtCity.ShortcutsEnabled = True
        Me.txtCity.Size = New System.Drawing.Size(186, 35)
        Me.txtCity.TabIndex = 7
        Me.txtCity.Text = "City"
        Me.txtCity.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCity.UseSelectable = True
        Me.txtCity.UseStyleColors = True
        Me.txtCity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAddress
        '
        '
        '
        '
        Me.txtAddress.CustomButton.Image = Nothing
        Me.txtAddress.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtAddress.CustomButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtAddress.CustomButton.Name = ""
        Me.txtAddress.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAddress.CustomButton.TabIndex = 1
        Me.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress.CustomButton.UseSelectable = True
        Me.txtAddress.CustomButton.Visible = False
        Me.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtAddress.Lines = New String() {"Address Details"}
        Me.txtAddress.Location = New System.Drawing.Point(440, 241)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtAddress.MaxLength = 32767
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.ShortcutsEnabled = True
        Me.txtAddress.Size = New System.Drawing.Size(186, 35)
        Me.txtAddress.TabIndex = 6
        Me.txtAddress.Text = "Address Details"
        Me.txtAddress.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress.UseSelectable = True
        Me.txtAddress.UseStyleColors = True
        Me.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtContact
        '
        '
        '
        '
        Me.txtContact.CustomButton.Image = Nothing
        Me.txtContact.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtContact.CustomButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtContact.CustomButton.Name = ""
        Me.txtContact.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContact.CustomButton.TabIndex = 1
        Me.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContact.CustomButton.UseSelectable = True
        Me.txtContact.CustomButton.Visible = False
        Me.txtContact.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtContact.Lines = New String() {"Contact Number"}
        Me.txtContact.Location = New System.Drawing.Point(440, 184)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtContact.MaxLength = 32767
        Me.txtContact.Multiline = True
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContact.SelectedText = ""
        Me.txtContact.SelectionLength = 0
        Me.txtContact.SelectionStart = 0
        Me.txtContact.ShortcutsEnabled = True
        Me.txtContact.Size = New System.Drawing.Size(186, 35)
        Me.txtContact.TabIndex = 5
        Me.txtContact.Text = "Contact Number"
        Me.txtContact.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContact.UseSelectable = True
        Me.txtContact.UseStyleColors = True
        Me.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtContact.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(344, 241)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(85, 25)
        Me.MetroLabel6.TabIndex = 18
        Me.MetroLabel6.Text = "Address:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(27, 184)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(90, 25)
        Me.MetroLabel7.TabIndex = 20
        Me.MetroLabel7.Text = "Job Title:"
        '
        'txtJobTitle
        '
        '
        '
        '
        Me.txtJobTitle.CustomButton.Image = Nothing
        Me.txtJobTitle.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtJobTitle.CustomButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtJobTitle.CustomButton.Name = ""
        Me.txtJobTitle.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtJobTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtJobTitle.CustomButton.TabIndex = 1
        Me.txtJobTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtJobTitle.CustomButton.UseSelectable = True
        Me.txtJobTitle.CustomButton.Visible = False
        Me.txtJobTitle.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtJobTitle.Lines = New String() {"Work Title"}
        Me.txtJobTitle.Location = New System.Drawing.Point(126, 184)
        Me.txtJobTitle.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.txtJobTitle.MaxLength = 32767
        Me.txtJobTitle.Multiline = True
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJobTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtJobTitle.SelectedText = ""
        Me.txtJobTitle.SelectionLength = 0
        Me.txtJobTitle.SelectionStart = 0
        Me.txtJobTitle.ShortcutsEnabled = True
        Me.txtJobTitle.Size = New System.Drawing.Size(186, 35)
        Me.txtJobTitle.TabIndex = 0
        Me.txtJobTitle.Text = "Work Title"
        Me.txtJobTitle.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtJobTitle.UseSelectable = True
        Me.txtJobTitle.UseStyleColors = True
        Me.txtJobTitle.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtJobTitle.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'formAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 550)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txtJobTitle)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtSuffix)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formAddEmployee"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.Text = "Add Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Protected Friend WithEvents txtLname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Protected Friend WithEvents txtFname As MetroFramework.Controls.MetroTextBox
    Protected Friend WithEvents txtSuffix As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Protected Friend WithEvents txtMname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Protected Friend WithEvents txtProvince As MetroFramework.Controls.MetroTextBox
    Protected Friend WithEvents txtCity As MetroFramework.Controls.MetroTextBox
    Protected Friend WithEvents txtAddress As MetroFramework.Controls.MetroTextBox
    Protected Friend WithEvents txtContact As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Protected Friend WithEvents txtJobTitle As MetroFramework.Controls.MetroTextBox
End Class
