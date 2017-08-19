<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.textBoxUser = New MetroFramework.Controls.MetroTextBox()
        Me.textBoxPass = New MetroFramework.Controls.MetroTextBox()
        Me.buttonLogin = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(126, 81)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(89, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Username"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(129, 199)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(82, 25)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Password"
        '
        'textBoxUser
        '
        '
        '
        '
        Me.textBoxUser.CustomButton.Image = Nothing
        Me.textBoxUser.CustomButton.Location = New System.Drawing.Point(229, 1)
        Me.textBoxUser.CustomButton.Name = ""
        Me.textBoxUser.CustomButton.Size = New System.Drawing.Size(41, 41)
        Me.textBoxUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textBoxUser.CustomButton.TabIndex = 1
        Me.textBoxUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textBoxUser.CustomButton.UseSelectable = True
        Me.textBoxUser.CustomButton.Visible = False
        Me.textBoxUser.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.textBoxUser.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.textBoxUser.Lines = New String(-1) {}
        Me.textBoxUser.Location = New System.Drawing.Point(42, 128)
        Me.textBoxUser.MaxLength = 32767
        Me.textBoxUser.Multiline = True
        Me.textBoxUser.Name = "textBoxUser"
        Me.textBoxUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textBoxUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textBoxUser.SelectedText = ""
        Me.textBoxUser.SelectionLength = 0
        Me.textBoxUser.SelectionStart = 0
        Me.textBoxUser.ShortcutsEnabled = True
        Me.textBoxUser.Size = New System.Drawing.Size(271, 43)
        Me.textBoxUser.TabIndex = 2
        Me.textBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.textBoxUser.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textBoxUser.UseSelectable = True
        Me.textBoxUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textBoxUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'textBoxPass
        '
        '
        '
        '
        Me.textBoxPass.CustomButton.Image = Nothing
        Me.textBoxPass.CustomButton.Location = New System.Drawing.Point(229, 1)
        Me.textBoxPass.CustomButton.Name = ""
        Me.textBoxPass.CustomButton.Size = New System.Drawing.Size(41, 41)
        Me.textBoxPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textBoxPass.CustomButton.TabIndex = 1
        Me.textBoxPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textBoxPass.CustomButton.UseSelectable = True
        Me.textBoxPass.CustomButton.Visible = False
        Me.textBoxPass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.textBoxPass.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.textBoxPass.Lines = New String(-1) {}
        Me.textBoxPass.Location = New System.Drawing.Point(42, 241)
        Me.textBoxPass.MaxLength = 32767
        Me.textBoxPass.Multiline = True
        Me.textBoxPass.Name = "textBoxPass"
        Me.textBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textBoxPass.SelectedText = ""
        Me.textBoxPass.SelectionLength = 0
        Me.textBoxPass.SelectionStart = 0
        Me.textBoxPass.ShortcutsEnabled = True
        Me.textBoxPass.Size = New System.Drawing.Size(271, 43)
        Me.textBoxPass.TabIndex = 5
        Me.textBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.textBoxPass.UseSelectable = True
        Me.textBoxPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textBoxPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'buttonLogin
        '
        Me.buttonLogin.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.buttonLogin.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.buttonLogin.Location = New System.Drawing.Point(42, 311)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(271, 60)
        Me.buttonLogin.TabIndex = 6
        Me.buttonLogin.Text = "LOGIN"
        Me.buttonLogin.UseSelectable = True
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 408)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.textBoxPass)
        Me.Controls.Add(Me.textBoxUser)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "formLogin"
        Me.Resizable = False
        Me.Text = "ECT Pharmacy POS"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents textBoxUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents textBoxPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents buttonLogin As MetroFramework.Controls.MetroButton
End Class
