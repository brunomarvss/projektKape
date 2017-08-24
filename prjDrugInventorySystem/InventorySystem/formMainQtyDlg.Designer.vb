<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMainQtyDlg
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
        Me.textBoxQty = New MetroFramework.Controls.MetroTextBox()
        Me.btnQty = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'textBoxQty
        '
        '
        '
        '
        Me.textBoxQty.CustomButton.Image = Nothing
        Me.textBoxQty.CustomButton.Location = New System.Drawing.Point(66, 2)
        Me.textBoxQty.CustomButton.Name = ""
        Me.textBoxQty.CustomButton.Size = New System.Drawing.Size(39, 39)
        Me.textBoxQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textBoxQty.CustomButton.TabIndex = 1
        Me.textBoxQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textBoxQty.CustomButton.UseSelectable = True
        Me.textBoxQty.CustomButton.Visible = False
        Me.textBoxQty.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.textBoxQty.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.textBoxQty.Lines = New String(-1) {}
        Me.textBoxQty.Location = New System.Drawing.Point(68, 129)
        Me.textBoxQty.MaxLength = 32767
        Me.textBoxQty.Multiline = True
        Me.textBoxQty.Name = "textBoxQty"
        Me.textBoxQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textBoxQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textBoxQty.SelectedText = ""
        Me.textBoxQty.SelectionLength = 0
        Me.textBoxQty.SelectionStart = 0
        Me.textBoxQty.ShortcutsEnabled = True
        Me.textBoxQty.Size = New System.Drawing.Size(108, 44)
        Me.textBoxQty.TabIndex = 1
        Me.textBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.textBoxQty.UseSelectable = True
        Me.textBoxQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textBoxQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnQty
        '
        Me.btnQty.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnQty.Location = New System.Drawing.Point(68, 198)
        Me.btnQty.Name = "btnQty"
        Me.btnQty.Size = New System.Drawing.Size(108, 51)
        Me.btnQty.TabIndex = 2
        Me.btnQty.Text = "OK"
        Me.btnQty.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(45, 71)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(159, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Enter Item Quantity"
        '
        'formMainQtyDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 294)
        Me.Controls.Add(Me.btnQty)
        Me.Controls.Add(Me.textBoxQty)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "formMainQtyDlg"
        Me.Resizable = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textBoxQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnQty As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
