<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLogin
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.buttonLogin = New MetroFramework.Controls.MetroButton()
        Me.txtUser = New MetroFramework.Controls.MetroTextBox()
        Me.txtPass = New MetroFramework.Controls.MetroTextBox()
        Me.passwordBox = New MetroFramework.Controls.MetroTextBox()
        Me.checkToggle = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.linkEmployeeLogin = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'buttonLogin
        '
        Me.buttonLogin.Location = New System.Drawing.Point(60, 415)
        Me.buttonLogin.Margin = New System.Windows.Forms.Padding(60, 0, 60, 108)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(267, 40)
        Me.buttonLogin.Style = MetroFramework.MetroColorStyle.Purple
        Me.buttonLogin.TabIndex = 7
        Me.buttonLogin.Text = "LOGIN"
        Me.buttonLogin.UseSelectable = True
        '
        'txtUser
        '
        '
        '
        '
        Me.txtUser.CustomButton.Image = Nothing
        Me.txtUser.CustomButton.Location = New System.Drawing.Point(245, 1)
        Me.txtUser.CustomButton.Name = ""
        Me.txtUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUser.CustomButton.TabIndex = 1
        Me.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUser.CustomButton.UseSelectable = True
        Me.txtUser.CustomButton.Visible = False
        Me.txtUser.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtUser.Lines = New String() {"Username"}
        Me.txtUser.Location = New System.Drawing.Point(60, 220)
        Me.txtUser.MaxLength = 32767
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.ShortcutsEnabled = True
        Me.txtUser.Size = New System.Drawing.Size(267, 23)
        Me.txtUser.TabIndex = 8
        Me.txtUser.Text = "Username"
        Me.txtUser.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUser.UseSelectable = True
        Me.txtUser.UseStyleColors = True
        Me.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPass
        '
        '
        '
        '
        Me.txtPass.CustomButton.Image = Nothing
        Me.txtPass.CustomButton.Location = New System.Drawing.Point(245, 1)
        Me.txtPass.CustomButton.Name = ""
        Me.txtPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPass.CustomButton.TabIndex = 1
        Me.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPass.CustomButton.UseSelectable = True
        Me.txtPass.CustomButton.Visible = False
        Me.txtPass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPass.Lines = New String() {"Password"}
        Me.txtPass.Location = New System.Drawing.Point(60, 309)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.Size = New System.Drawing.Size(267, 23)
        Me.txtPass.TabIndex = 9
        Me.txtPass.Text = "Password"
        Me.txtPass.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPass.UseSelectable = True
        Me.txtPass.UseStyleColors = True
        Me.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'passwordBox
        '
        '
        '
        '
        Me.passwordBox.CustomButton.Image = Nothing
        Me.passwordBox.CustomButton.Location = New System.Drawing.Point(245, 1)
        Me.passwordBox.CustomButton.Name = ""
        Me.passwordBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.passwordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.passwordBox.CustomButton.TabIndex = 1
        Me.passwordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.passwordBox.CustomButton.UseSelectable = True
        Me.passwordBox.CustomButton.Visible = False
        Me.passwordBox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.passwordBox.Lines = New String() {"Password"}
        Me.passwordBox.Location = New System.Drawing.Point(60, 280)
        Me.passwordBox.MaxLength = 32767
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.passwordBox.SelectedText = ""
        Me.passwordBox.SelectionLength = 0
        Me.passwordBox.SelectionStart = 0
        Me.passwordBox.ShortcutsEnabled = True
        Me.passwordBox.Size = New System.Drawing.Size(267, 23)
        Me.passwordBox.TabIndex = 11
        Me.passwordBox.Text = "Password"
        Me.passwordBox.Theme = MetroFramework.MetroThemeStyle.Light
        Me.passwordBox.UseSelectable = True
        Me.passwordBox.UseStyleColors = True
        Me.passwordBox.UseSystemPasswordChar = True
        Me.passwordBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.passwordBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'checkToggle
        '
        Me.checkToggle.AutoSize = True
        Me.checkToggle.Location = New System.Drawing.Point(60, 338)
        Me.checkToggle.Name = "checkToggle"
        Me.checkToggle.Size = New System.Drawing.Size(112, 15)
        Me.checkToggle.TabIndex = 12
        Me.checkToggle.Text = "Toggle Password"
        Me.checkToggle.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(92, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(200, 19)
        Me.MetroLabel1.TabIndex = 13
        Me.MetroLabel1.Text = "Organize your sales and network"
        '
        'linkEmployeeLogin
        '
        Me.linkEmployeeLogin.AutoSize = True
        Me.linkEmployeeLogin.Location = New System.Drawing.Point(60, 489)
        Me.linkEmployeeLogin.Name = "linkEmployeeLogin"
        Me.linkEmployeeLogin.Size = New System.Drawing.Size(80, 19)
        Me.linkEmployeeLogin.TabIndex = 14
        Me.linkEmployeeLogin.Text = "Not Admin?"
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 550)
        Me.Controls.Add(Me.linkEmployeeLogin)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.checkToggle)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.buttonLogin)
        Me.Name = "formLogin"
        Me.Padding = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "ECT Pharmacy POS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents txtUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents passwordBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents checkToggle As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents linkEmployeeLogin As MetroFramework.Controls.MetroLabel
End Class
