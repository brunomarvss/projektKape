<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPwdDc
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
        Me.btnPWD = New MetroFramework.Controls.MetroButton()
        Me.textboxPCusNo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.textboxPCusName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'btnPWD
        '
        Me.btnPWD.Location = New System.Drawing.Point(259, 193)
        Me.btnPWD.Name = "btnPWD"
        Me.btnPWD.Size = New System.Drawing.Size(153, 41)
        Me.btnPWD.TabIndex = 9
        Me.btnPWD.Text = "SAVE"
        Me.btnPWD.UseSelectable = True
        '
        'textboxPCusNo
        '
        '
        '
        '
        Me.textboxPCusNo.CustomButton.Image = Nothing
        Me.textboxPCusNo.CustomButton.Location = New System.Drawing.Point(336, 1)
        Me.textboxPCusNo.CustomButton.Name = ""
        Me.textboxPCusNo.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.textboxPCusNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textboxPCusNo.CustomButton.TabIndex = 1
        Me.textboxPCusNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textboxPCusNo.CustomButton.UseSelectable = True
        Me.textboxPCusNo.CustomButton.Visible = False
        Me.textboxPCusNo.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.textboxPCusNo.Lines = New String(-1) {}
        Me.textboxPCusNo.Location = New System.Drawing.Point(183, 140)
        Me.textboxPCusNo.MaxLength = 32767
        Me.textboxPCusNo.Multiline = True
        Me.textboxPCusNo.Name = "textboxPCusNo"
        Me.textboxPCusNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textboxPCusNo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textboxPCusNo.SelectedText = ""
        Me.textboxPCusNo.SelectionLength = 0
        Me.textboxPCusNo.SelectionStart = 0
        Me.textboxPCusNo.ShortcutsEnabled = True
        Me.textboxPCusNo.Size = New System.Drawing.Size(372, 37)
        Me.textboxPCusNo.TabIndex = 8
        Me.textboxPCusNo.UseSelectable = True
        Me.textboxPCusNo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textboxPCusNo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(45, 145)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(96, 25)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "ID Number"
        '
        'textboxPCusName
        '
        '
        '
        '
        Me.textboxPCusName.CustomButton.Image = Nothing
        Me.textboxPCusName.CustomButton.Location = New System.Drawing.Point(336, 1)
        Me.textboxPCusName.CustomButton.Name = ""
        Me.textboxPCusName.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.textboxPCusName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textboxPCusName.CustomButton.TabIndex = 1
        Me.textboxPCusName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textboxPCusName.CustomButton.UseSelectable = True
        Me.textboxPCusName.CustomButton.Visible = False
        Me.textboxPCusName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.textboxPCusName.Lines = New String(-1) {}
        Me.textboxPCusName.Location = New System.Drawing.Point(183, 86)
        Me.textboxPCusName.MaxLength = 32767
        Me.textboxPCusName.Multiline = True
        Me.textboxPCusName.Name = "textboxPCusName"
        Me.textboxPCusName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textboxPCusName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textboxPCusName.SelectedText = ""
        Me.textboxPCusName.SelectionLength = 0
        Me.textboxPCusName.SelectionStart = 0
        Me.textboxPCusName.ShortcutsEnabled = True
        Me.textboxPCusName.Size = New System.Drawing.Size(372, 37)
        Me.textboxPCusName.TabIndex = 6
        Me.textboxPCusName.UseSelectable = True
        Me.textboxPCusName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textboxPCusName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(26, 93)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(136, 25)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "Customer Name"
        '
        'formPwdDc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 267)
        Me.Controls.Add(Me.btnPWD)
        Me.Controls.Add(Me.textboxPCusNo)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.textboxPCusName)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPwdDc"
        Me.Resizable = False
        Me.Text = "PWD Discount Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPWD As MetroFramework.Controls.MetroButton
    Friend WithEvents textboxPCusNo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents textboxPCusName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
