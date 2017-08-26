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
        Me.checkToggle = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.linkEmployeeLogin = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'buttonLogin
        '
        Me.buttonLogin.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.buttonLogin.Location = New System.Drawing.Point(60, 395)
        Me.buttonLogin.Margin = New System.Windows.Forms.Padding(80, 0, 80, 133)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(267, 39)
        Me.buttonLogin.Style = MetroFramework.MetroColorStyle.Purple
        Me.buttonLogin.TabIndex = 4
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
        Me.txtUser.CustomButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtUser.CustomButton.Name = ""
        Me.txtUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUser.CustomButton.TabIndex = 1
        Me.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUser.CustomButton.UseSelectable = True
        Me.txtUser.CustomButton.Visible = False
        Me.txtUser.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtUser.Lines = New String() {"Username"}
        Me.txtUser.Location = New System.Drawing.Point(60, 194)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtUser.MaxLength = 32767
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.ShortcutsEnabled = True
        Me.txtUser.Size = New System.Drawing.Size(267, 23)
        Me.txtUser.TabIndex = 1
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
        Me.txtPass.CustomButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPass.CustomButton.Name = ""
        Me.txtPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPass.CustomButton.TabIndex = 1
        Me.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPass.CustomButton.UseSelectable = True
        Me.txtPass.CustomButton.Visible = False
        Me.txtPass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPass.Lines = New String() {"Password"}
        Me.txtPass.Location = New System.Drawing.Point(60, 248)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.Size = New System.Drawing.Size(267, 23)
        Me.txtPass.TabIndex = 2
        Me.txtPass.Text = "Password"
        Me.txtPass.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPass.UseSelectable = True
        Me.txtPass.UseStyleColors = True
        Me.txtPass.UseSystemPasswordChar = True
        Me.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'checkToggle
        '
        Me.checkToggle.AutoSize = True
        Me.checkToggle.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.checkToggle.Location = New System.Drawing.Point(60, 280)
        Me.checkToggle.Margin = New System.Windows.Forms.Padding(60, 285, 5, 4)
        Me.checkToggle.Name = "checkToggle"
        Me.checkToggle.Size = New System.Drawing.Size(136, 20)
        Me.checkToggle.TabIndex = 3
        Me.checkToggle.Text = "Toggle Password"
        Me.checkToggle.Theme = MetroFramework.MetroThemeStyle.Light
        Me.checkToggle.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(49, 59)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(288, 25)
        Me.MetroLabel1.TabIndex = 13
        Me.MetroLabel1.Text = "Organize your sales and network"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'linkEmployeeLogin
        '
        Me.linkEmployeeLogin.AutoSize = True
        Me.linkEmployeeLogin.Location = New System.Drawing.Point(60, 455)
        Me.linkEmployeeLogin.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.linkEmployeeLogin.Name = "linkEmployeeLogin"
        Me.linkEmployeeLogin.Size = New System.Drawing.Size(82, 20)
        Me.linkEmployeeLogin.TabIndex = 14
        Me.linkEmployeeLogin.Text = "Not Admin?"
        Me.linkEmployeeLogin.UseStyleColors = True
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 550)
        Me.Controls.Add(Me.linkEmployeeLogin)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.checkToggle)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.buttonLogin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "formLogin"
        Me.Padding = New System.Windows.Forms.Padding(0, 74, 0, 0)
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "ECT Pharmacy POS"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents txtUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents checkToggle As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents linkEmployeeLogin As MetroFramework.Controls.MetroLabel
End Class
