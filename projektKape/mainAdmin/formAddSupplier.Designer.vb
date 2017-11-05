<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddSupplier
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
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtCompany = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtProvince = New MetroFramework.Controls.MetroTextBox()
        Me.txtCity = New MetroFramework.Controls.MetroTextBox()
        Me.txtAddress = New MetroFramework.Controls.MetroTextBox()
        Me.txtContact = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtFname = New MetroFramework.Controls.MetroTextBox()
        Me.txtLname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.txtSuffix = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(107, 286)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(102, 25)
        Me.MetroLabel7.TabIndex = 32
        Me.MetroLabel7.Text = "Company:"
        '
        'txtCompany
        '
        '
        '
        '
        Me.txtCompany.CustomButton.Image = Nothing
        Me.txtCompany.CustomButton.Location = New System.Drawing.Point(275, 1)
        Me.txtCompany.CustomButton.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtCompany.CustomButton.Name = ""
        Me.txtCompany.CustomButton.Size = New System.Drawing.Size(55, 50)
        Me.txtCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCompany.CustomButton.TabIndex = 1
        Me.txtCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCompany.CustomButton.UseSelectable = True
        Me.txtCompany.CustomButton.Visible = False
        Me.txtCompany.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtCompany.Lines = New String() {"Company Name"}
        Me.txtCompany.Location = New System.Drawing.Point(240, 286)
        Me.txtCompany.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtCompany.MaxLength = 32767
        Me.txtCompany.Multiline = True
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompany.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCompany.SelectedText = ""
        Me.txtCompany.SelectionLength = 0
        Me.txtCompany.SelectionStart = 0
        Me.txtCompany.ShortcutsEnabled = True
        Me.txtCompany.Size = New System.Drawing.Size(248, 43)
        Me.txtCompany.TabIndex = 0
        Me.txtCompany.Text = "Company Name"
        Me.txtCompany.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCompany.UseSelectable = True
        Me.txtCompany.UseStyleColors = True
        Me.txtCompany.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCompany.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(531, 356)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(88, 25)
        Me.MetroLabel6.TabIndex = 30
        Me.MetroLabel6.Text = "Address:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(531, 286)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(90, 25)
        Me.MetroLabel5.TabIndex = 29
        Me.MetroLabel5.Text = "Phone #:"
        '
        'txtProvince
        '
        '
        '
        '
        Me.txtProvince.CustomButton.Image = Nothing
        Me.txtProvince.CustomButton.Location = New System.Drawing.Point(275, 1)
        Me.txtProvince.CustomButton.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtProvince.CustomButton.Name = ""
        Me.txtProvince.CustomButton.Size = New System.Drawing.Size(55, 50)
        Me.txtProvince.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtProvince.CustomButton.TabIndex = 1
        Me.txtProvince.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtProvince.CustomButton.UseSelectable = True
        Me.txtProvince.CustomButton.Visible = False
        Me.txtProvince.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtProvince.Lines = New String() {"Province"}
        Me.txtProvince.Location = New System.Drawing.Point(659, 466)
        Me.txtProvince.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtProvince.MaxLength = 32767
        Me.txtProvince.Multiline = True
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProvince.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtProvince.SelectedText = ""
        Me.txtProvince.SelectionLength = 0
        Me.txtProvince.SelectionStart = 0
        Me.txtProvince.ShortcutsEnabled = True
        Me.txtProvince.Size = New System.Drawing.Size(248, 43)
        Me.txtProvince.TabIndex = 7
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
        Me.txtCity.CustomButton.Location = New System.Drawing.Point(275, 1)
        Me.txtCity.CustomButton.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtCity.CustomButton.Name = ""
        Me.txtCity.CustomButton.Size = New System.Drawing.Size(55, 50)
        Me.txtCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCity.CustomButton.TabIndex = 1
        Me.txtCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCity.CustomButton.UseSelectable = True
        Me.txtCity.CustomButton.Visible = False
        Me.txtCity.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtCity.Lines = New String() {"City"}
        Me.txtCity.Location = New System.Drawing.Point(659, 411)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtCity.MaxLength = 32767
        Me.txtCity.Multiline = True
        Me.txtCity.Name = "txtCity"
        Me.txtCity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCity.SelectedText = ""
        Me.txtCity.SelectionLength = 0
        Me.txtCity.SelectionStart = 0
        Me.txtCity.ShortcutsEnabled = True
        Me.txtCity.Size = New System.Drawing.Size(248, 43)
        Me.txtCity.TabIndex = 6
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
        Me.txtAddress.CustomButton.Location = New System.Drawing.Point(275, 1)
        Me.txtAddress.CustomButton.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtAddress.CustomButton.Name = ""
        Me.txtAddress.CustomButton.Size = New System.Drawing.Size(55, 50)
        Me.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAddress.CustomButton.TabIndex = 1
        Me.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress.CustomButton.UseSelectable = True
        Me.txtAddress.CustomButton.Visible = False
        Me.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtAddress.Lines = New String() {"Address Details"}
        Me.txtAddress.Location = New System.Drawing.Point(659, 356)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtAddress.MaxLength = 32767
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.ShortcutsEnabled = True
        Me.txtAddress.Size = New System.Drawing.Size(248, 43)
        Me.txtAddress.TabIndex = 5
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
        Me.txtContact.CustomButton.Location = New System.Drawing.Point(275, 1)
        Me.txtContact.CustomButton.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtContact.CustomButton.Name = ""
        Me.txtContact.CustomButton.Size = New System.Drawing.Size(55, 50)
        Me.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContact.CustomButton.TabIndex = 1
        Me.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContact.CustomButton.UseSelectable = True
        Me.txtContact.CustomButton.Visible = False
        Me.txtContact.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtContact.Lines = New String() {"Contact Number"}
        Me.txtContact.Location = New System.Drawing.Point(659, 286)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtContact.MaxLength = 32767
        Me.txtContact.Multiline = True
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContact.SelectedText = ""
        Me.txtContact.SelectionLength = 0
        Me.txtContact.SelectionStart = 0
        Me.txtContact.ShortcutsEnabled = True
        Me.txtContact.Size = New System.Drawing.Size(248, 43)
        Me.txtContact.TabIndex = 4
        Me.txtContact.Text = "Contact Number"
        Me.txtContact.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContact.UseSelectable = True
        Me.txtContact.UseStyleColors = True
        Me.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtContact.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(139, 356)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(69, 25)
        Me.MetroLabel4.TabIndex = 24
        Me.MetroLabel4.Text = "Name:"
        '
        'txtFname
        '
        '
        '
        '
        Me.txtFname.CustomButton.Image = Nothing
        Me.txtFname.CustomButton.Location = New System.Drawing.Point(275, 1)
        Me.txtFname.CustomButton.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtFname.CustomButton.Name = ""
        Me.txtFname.CustomButton.Size = New System.Drawing.Size(55, 50)
        Me.txtFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFname.CustomButton.TabIndex = 1
        Me.txtFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFname.CustomButton.UseSelectable = True
        Me.txtFname.CustomButton.Visible = False
        Me.txtFname.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtFname.Lines = New String() {"First Name"}
        Me.txtFname.Location = New System.Drawing.Point(240, 426)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtFname.MaxLength = 32767
        Me.txtFname.Multiline = True
        Me.txtFname.Name = "txtFname"
        Me.txtFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFname.SelectedText = ""
        Me.txtFname.SelectionLength = 0
        Me.txtFname.SelectionStart = 0
        Me.txtFname.ShortcutsEnabled = True
        Me.txtFname.Size = New System.Drawing.Size(248, 43)
        Me.txtFname.TabIndex = 2
        Me.txtFname.Text = "First Name"
        Me.txtFname.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFname.UseSelectable = True
        Me.txtFname.UseStyleColors = True
        Me.txtFname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLname
        '
        '
        '
        '
        Me.txtLname.CustomButton.Image = Nothing
        Me.txtLname.CustomButton.Location = New System.Drawing.Point(275, 1)
        Me.txtLname.CustomButton.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtLname.CustomButton.Name = ""
        Me.txtLname.CustomButton.Size = New System.Drawing.Size(55, 50)
        Me.txtLname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLname.CustomButton.TabIndex = 1
        Me.txtLname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLname.CustomButton.UseSelectable = True
        Me.txtLname.CustomButton.Visible = False
        Me.txtLname.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtLname.Lines = New String() {"Last Name"}
        Me.txtLname.Location = New System.Drawing.Point(240, 356)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtLname.MaxLength = 32767
        Me.txtLname.Multiline = True
        Me.txtLname.Name = "txtLname"
        Me.txtLname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLname.SelectedText = ""
        Me.txtLname.SelectionLength = 0
        Me.txtLname.SelectionStart = 0
        Me.txtLname.ShortcutsEnabled = True
        Me.txtLname.Size = New System.Drawing.Size(248, 43)
        Me.txtLname.TabIndex = 1
        Me.txtLname.Text = "Last Name"
        Me.txtLname.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLname.UseSelectable = True
        Me.txtLname.UseStyleColors = True
        Me.txtLname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 123)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(609, 20)
        Me.MetroLabel2.TabIndex = 33
        Me.MetroLabel2.Text = "_________________________________________________________________________________" &
    "___________________"
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSave.Location = New System.Drawing.Point(279, 610)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(143, 0, 143, 202)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(420, 59)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseSelectable = True
        '
        'txtSuffix
        '
        '
        '
        '
        Me.txtSuffix.CustomButton.Image = Nothing
        Me.txtSuffix.CustomButton.Location = New System.Drawing.Point(275, 1)
        Me.txtSuffix.CustomButton.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtSuffix.CustomButton.Name = ""
        Me.txtSuffix.CustomButton.Size = New System.Drawing.Size(55, 50)
        Me.txtSuffix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSuffix.CustomButton.TabIndex = 1
        Me.txtSuffix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSuffix.CustomButton.UseSelectable = True
        Me.txtSuffix.CustomButton.Visible = False
        Me.txtSuffix.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSuffix.Lines = New String() {"Suffix e.g. (Jr.)"}
        Me.txtSuffix.Location = New System.Drawing.Point(240, 481)
        Me.txtSuffix.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtSuffix.MaxLength = 32767
        Me.txtSuffix.Multiline = True
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuffix.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSuffix.SelectedText = ""
        Me.txtSuffix.SelectionLength = 0
        Me.txtSuffix.SelectionStart = 0
        Me.txtSuffix.ShortcutsEnabled = True
        Me.txtSuffix.Size = New System.Drawing.Size(248, 43)
        Me.txtSuffix.TabIndex = 3
        Me.txtSuffix.Text = "Suffix e.g. (Jr.)"
        Me.txtSuffix.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSuffix.UseSelectable = True
        Me.txtSuffix.UseStyleColors = True
        Me.txtSuffix.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSuffix.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'formAddSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 772)
        Me.Controls.Add(Me.txtSuffix)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtLname)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "formAddSupplier"
        Me.Padding = New System.Windows.Forms.Padding(20, 74, 20, 20)
        Me.Text = "Supplier Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Protected Friend WithEvents txtCompany As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Protected Friend WithEvents txtProvince As MetroFramework.Controls.MetroTextBox
    Protected Friend WithEvents txtCity As MetroFramework.Controls.MetroTextBox
    Protected Friend WithEvents txtAddress As MetroFramework.Controls.MetroTextBox
    Protected Friend WithEvents txtContact As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Protected Friend WithEvents txtFname As MetroFramework.Controls.MetroTextBox
    Protected Friend WithEvents txtLname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Protected Friend WithEvents txtSuffix As MetroFramework.Controls.MetroTextBox
End Class
