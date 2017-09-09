<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCashTender
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
        Me.labelAmtToBe = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxPayment = New System.Windows.Forms.TextBox()
        Me.btn50 = New MetroFramework.Controls.MetroButton()
        Me.btn100 = New MetroFramework.Controls.MetroButton()
        Me.btn500 = New MetroFramework.Controls.MetroButton()
        Me.btn1000 = New MetroFramework.Controls.MetroButton()
        Me.btnConfirmPayment = New System.Windows.Forms.Button()
        Me.btnPwd = New MetroFramework.Controls.MetroButton()
        Me.btnSenior = New MetroFramework.Controls.MetroButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelDisc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelTotalTender = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "SUBTOTAL:"
        '
        'labelAmtToBe
        '
        Me.labelAmtToBe.AutoSize = True
        Me.labelAmtToBe.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAmtToBe.Location = New System.Drawing.Point(255, 65)
        Me.labelAmtToBe.Name = "labelAmtToBe"
        Me.labelAmtToBe.Size = New System.Drawing.Size(85, 47)
        Me.labelAmtToBe.TabIndex = 26
        Me.labelAmtToBe.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "ENTER PAYMENT"
        '
        'txtBoxPayment
        '
        Me.txtBoxPayment.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxPayment.Location = New System.Drawing.Point(216, 274)
        Me.txtBoxPayment.Multiline = True
        Me.txtBoxPayment.Name = "txtBoxPayment"
        Me.txtBoxPayment.Size = New System.Drawing.Size(283, 78)
        Me.txtBoxPayment.TabIndex = 28
        Me.txtBoxPayment.Text = "0.00"
        '
        'btn50
        '
        Me.btn50.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn50.Location = New System.Drawing.Point(68, 395)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(106, 50)
        Me.btn50.TabIndex = 29
        Me.btn50.Text = "50"
        Me.btn50.UseSelectable = True
        '
        'btn100
        '
        Me.btn100.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn100.Location = New System.Drawing.Point(221, 395)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(106, 50)
        Me.btn100.TabIndex = 30
        Me.btn100.Text = "100"
        Me.btn100.UseSelectable = True
        '
        'btn500
        '
        Me.btn500.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn500.Location = New System.Drawing.Point(364, 395)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(106, 50)
        Me.btn500.TabIndex = 31
        Me.btn500.Text = "500"
        Me.btn500.UseSelectable = True
        '
        'btn1000
        '
        Me.btn1000.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn1000.Location = New System.Drawing.Point(509, 395)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(106, 50)
        Me.btn1000.TabIndex = 32
        Me.btn1000.Text = "1000"
        Me.btn1000.UseSelectable = True
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.BackColor = System.Drawing.Color.Green
        Me.btnConfirmPayment.Enabled = False
        Me.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmPayment.ForeColor = System.Drawing.Color.White
        Me.btnConfirmPayment.Location = New System.Drawing.Point(231, 476)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(225, 63)
        Me.btnConfirmPayment.TabIndex = 33
        Me.btnConfirmPayment.Text = "CONFIRM PAYMENT"
        Me.btnConfirmPayment.UseVisualStyleBackColor = False
        '
        'btnPwd
        '
        Me.btnPwd.Enabled = False
        Me.btnPwd.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnPwd.Location = New System.Drawing.Point(545, 172)
        Me.btnPwd.Name = "btnPwd"
        Me.btnPwd.Size = New System.Drawing.Size(102, 81)
        Me.btnPwd.TabIndex = 35
        Me.btnPwd.Text = "PWD"
        Me.btnPwd.UseSelectable = True
        '
        'btnSenior
        '
        Me.btnSenior.Enabled = False
        Me.btnSenior.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSenior.Location = New System.Drawing.Point(545, 72)
        Me.btnSenior.Name = "btnSenior"
        Me.btnSenior.Size = New System.Drawing.Size(102, 81)
        Me.btnSenior.TabIndex = 34
        Me.btnSenior.Text = "SENIOR"
        Me.btnSenior.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 21)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "DISCOUNT (20%):"
        '
        'labelDisc
        '
        Me.labelDisc.AutoSize = True
        Me.labelDisc.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDisc.Location = New System.Drawing.Point(255, 114)
        Me.labelDisc.Name = "labelDisc"
        Me.labelDisc.Size = New System.Drawing.Size(85, 47)
        Me.labelDisc.TabIndex = 37
        Me.labelDisc.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 21)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "AMOUNT TO BE PAID:"
        '
        'labelTotalTender
        '
        Me.labelTotalTender.AutoSize = True
        Me.labelTotalTender.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotalTender.Location = New System.Drawing.Point(236, 181)
        Me.labelTotalTender.Name = "labelTotalTender"
        Me.labelTotalTender.Size = New System.Drawing.Size(125, 65)
        Me.labelTotalTender.TabIndex = 39
        Me.labelTotalTender.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(297, 21)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "_________________________________________"
        '
        'formCashTender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 570)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labelTotalTender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labelDisc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPwd)
        Me.Controls.Add(Me.btnSenior)
        Me.Controls.Add(Me.btnConfirmPayment)
        Me.Controls.Add(Me.btn1000)
        Me.Controls.Add(Me.btn500)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.txtBoxPayment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelAmtToBe)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formCashTender"
        Me.Text = "ECT Pharmacy - Tender Cash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents labelAmtToBe As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxPayment As TextBox
    Friend WithEvents btn50 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn100 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn500 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn1000 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConfirmPayment As Button
    Friend WithEvents btnPwd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSenior As MetroFramework.Controls.MetroButton
    Friend WithEvents Label3 As Label
    Friend WithEvents labelDisc As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents labelTotalTender As Label
    Friend WithEvents Label5 As Label
End Class
