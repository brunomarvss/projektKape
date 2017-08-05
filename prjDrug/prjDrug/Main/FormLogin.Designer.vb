<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.togglePass = New MetroFramework.Controls.MetroToggle()
        Me.txtUser = New MetroFramework.Controls.MetroTextBox()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.txtPass = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.linkCreate = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Location = New System.Drawing.Point(44, 101)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Username:"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'togglePass
        '
        Me.togglePass.AutoSize = True
        Me.togglePass.Location = New System.Drawing.Point(314, 137)
        Me.togglePass.Name = "togglePass"
        Me.togglePass.Size = New System.Drawing.Size(80, 17)
        Me.togglePass.TabIndex = 4
        Me.togglePass.Text = "Off"
        Me.togglePass.UseSelectable = True
        '
        'txtUser
        '
        '
        '
        '
        Me.txtUser.CustomButton.Image = Nothing
        Me.txtUser.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtUser.CustomButton.Name = ""
        Me.txtUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUser.CustomButton.TabIndex = 1
        Me.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUser.CustomButton.UseSelectable = True
        Me.txtUser.CustomButton.Visible = False
        Me.txtUser.Lines = New String(-1) {}
        Me.txtUser.Location = New System.Drawing.Point(116, 97)
        Me.txtUser.MaxLength = 32767
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.ShortcutsEnabled = True
        Me.txtUser.Size = New System.Drawing.Size(174, 23)
        Me.txtUser.TabIndex = 1
        Me.txtUser.UseSelectable = True
        Me.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Gold
        Me.btnLogin.Location = New System.Drawing.Point(219, 174)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(77, 23)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseSelectable = True
        '
        'txtPass
        '
        '
        '
        '
        Me.txtPass.CustomButton.Image = Nothing
        Me.txtPass.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtPass.CustomButton.Name = ""
        Me.txtPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPass.CustomButton.TabIndex = 1
        Me.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPass.CustomButton.UseSelectable = True
        Me.txtPass.CustomButton.Visible = False
        Me.txtPass.Lines = New String(-1) {}
        Me.txtPass.Location = New System.Drawing.Point(116, 131)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.Size = New System.Drawing.Size(174, 23)
        Me.txtPass.TabIndex = 2
        Me.txtPass.UseSelectable = True
        Me.txtPass.UseSystemPasswordChar = True
        Me.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.Location = New System.Drawing.Point(44, 136)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Password:"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.Location = New System.Drawing.Point(310, 119)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Show Password"
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'linkCreate
        '
        Me.linkCreate.BackColor = System.Drawing.Color.Transparent
        Me.linkCreate.Location = New System.Drawing.Point(2, 246)
        Me.linkCreate.Name = "linkCreate"
        Me.linkCreate.Size = New System.Drawing.Size(214, 23)
        Me.linkCreate.TabIndex = 7
        Me.linkCreate.Text = "Don't have an account? Create here"
        Me.linkCreate.UseCustomBackColor = True
        Me.linkCreate.UseSelectable = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 269)
        Me.Controls.Add(Me.linkCreate)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.togglePass)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Login to your Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents togglePass As MetroFramework.Controls.MetroToggle
    Friend WithEvents txtUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents txtPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents linkCreate As MetroFramework.Controls.MetroLink
End Class
