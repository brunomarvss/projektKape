<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formSeniorDc
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.textboxSCusName = New MetroFramework.Controls.MetroTextBox()
        Me.textboxSCusNo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnSenior = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(30, 95)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(136, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Customer Name"
        '
        'textboxSCusName
        '
        '
        '
        '
        Me.textboxSCusName.CustomButton.Image = Nothing
        Me.textboxSCusName.CustomButton.Location = New System.Drawing.Point(336, 1)
        Me.textboxSCusName.CustomButton.Name = ""
        Me.textboxSCusName.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.textboxSCusName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textboxSCusName.CustomButton.TabIndex = 1
        Me.textboxSCusName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textboxSCusName.CustomButton.UseSelectable = True
        Me.textboxSCusName.CustomButton.Visible = False
        Me.textboxSCusName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.textboxSCusName.Lines = New String(-1) {}
        Me.textboxSCusName.Location = New System.Drawing.Point(187, 88)
        Me.textboxSCusName.MaxLength = 32767
        Me.textboxSCusName.Multiline = True
        Me.textboxSCusName.Name = "textboxSCusName"
        Me.textboxSCusName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textboxSCusName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textboxSCusName.SelectedText = ""
        Me.textboxSCusName.SelectionLength = 0
        Me.textboxSCusName.SelectionStart = 0
        Me.textboxSCusName.ShortcutsEnabled = True
        Me.textboxSCusName.Size = New System.Drawing.Size(372, 37)
        Me.textboxSCusName.TabIndex = 1
        Me.textboxSCusName.UseSelectable = True
        Me.textboxSCusName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textboxSCusName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'textboxSCusNo
        '
        '
        '
        '
        Me.textboxSCusNo.CustomButton.Image = Nothing
        Me.textboxSCusNo.CustomButton.Location = New System.Drawing.Point(336, 1)
        Me.textboxSCusNo.CustomButton.Name = ""
        Me.textboxSCusNo.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.textboxSCusNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textboxSCusNo.CustomButton.TabIndex = 1
        Me.textboxSCusNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textboxSCusNo.CustomButton.UseSelectable = True
        Me.textboxSCusNo.CustomButton.Visible = False
        Me.textboxSCusNo.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.textboxSCusNo.Lines = New String(-1) {}
        Me.textboxSCusNo.Location = New System.Drawing.Point(187, 142)
        Me.textboxSCusNo.MaxLength = 32767
        Me.textboxSCusNo.Multiline = True
        Me.textboxSCusNo.Name = "textboxSCusNo"
        Me.textboxSCusNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textboxSCusNo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textboxSCusNo.SelectedText = ""
        Me.textboxSCusNo.SelectionLength = 0
        Me.textboxSCusNo.SelectionStart = 0
        Me.textboxSCusNo.ShortcutsEnabled = True
        Me.textboxSCusNo.Size = New System.Drawing.Size(372, 37)
        Me.textboxSCusNo.TabIndex = 3
        Me.textboxSCusNo.UseSelectable = True
        Me.textboxSCusNo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textboxSCusNo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(49, 147)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(96, 25)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "ID Number"
        '
        'btnSenior
        '
        Me.btnSenior.Location = New System.Drawing.Point(256, 203)
        Me.btnSenior.Name = "btnSenior"
        Me.btnSenior.Size = New System.Drawing.Size(153, 41)
        Me.btnSenior.TabIndex = 4
        Me.btnSenior.Text = "SAVE"
        Me.btnSenior.UseSelectable = True
        '
        'formSeniorDc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 267)
        Me.Controls.Add(Me.btnSenior)
        Me.Controls.Add(Me.textboxSCusNo)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.textboxSCusName)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "formSeniorDc"
        Me.Resizable = False
        Me.Text = "Senior Citizen Discount Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents textboxSCusName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents textboxSCusNo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSenior As MetroFramework.Controls.MetroButton
End Class
