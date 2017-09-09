<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formChange
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelChange = New System.Windows.Forms.Label()
        Me.btnChangeOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 32)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "CHANGE IS"
        '
        'labelChange
        '
        Me.labelChange.AutoSize = True
        Me.labelChange.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelChange.Location = New System.Drawing.Point(66, 151)
        Me.labelChange.Name = "labelChange"
        Me.labelChange.Size = New System.Drawing.Size(165, 86)
        Me.labelChange.TabIndex = 27
        Me.labelChange.Text = "0.00"
        '
        'btnChangeOK
        '
        Me.btnChangeOK.BackColor = System.Drawing.Color.Green
        Me.btnChangeOK.Enabled = False
        Me.btnChangeOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeOK.ForeColor = System.Drawing.Color.White
        Me.btnChangeOK.Location = New System.Drawing.Point(97, 267)
        Me.btnChangeOK.Name = "btnChangeOK"
        Me.btnChangeOK.Size = New System.Drawing.Size(100, 51)
        Me.btnChangeOK.TabIndex = 28
        Me.btnChangeOK.Text = "OK"
        Me.btnChangeOK.UseVisualStyleBackColor = False
        '
        'formChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 345)
        Me.Controls.Add(Me.btnChangeOK)
        Me.Controls.Add(Me.labelChange)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formChange"
        Me.Text = "ECT Pharmacy - Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents labelChange As Label
    Friend WithEvents btnChangeOK As Button
End Class
