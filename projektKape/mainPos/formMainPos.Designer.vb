<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMainPos
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("12323")
        Me.textBoxUser = New MetroFramework.Controls.MetroTextBox()
        Me.MetroListView1 = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroListView2 = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btnSenior = New MetroFramework.Controls.MetroButton()
        Me.btnPwd = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnTender = New System.Windows.Forms.Button()
        Me.labelTotalPrice = New System.Windows.Forms.Label()
        Me.labelTempTotal = New MetroFramework.Controls.MetroLabel()
        Me.labelDiscount = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.btnLogout = New MetroFramework.Controls.MetroButton()
        Me.labelTime = New MetroFramework.Controls.MetroLabel()
        Me.timerClock = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'textBoxUser
        '
        '
        '
        '
        Me.textBoxUser.CustomButton.Image = Nothing
        Me.textBoxUser.CustomButton.Location = New System.Drawing.Point(413, 1)
        Me.textBoxUser.CustomButton.Name = ""
        Me.textBoxUser.CustomButton.Size = New System.Drawing.Size(39, 39)
        Me.textBoxUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textBoxUser.CustomButton.TabIndex = 1
        Me.textBoxUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textBoxUser.CustomButton.UseSelectable = True
        Me.textBoxUser.CustomButton.Visible = False
        Me.textBoxUser.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.textBoxUser.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.textBoxUser.Lines = New String(-1) {}
        Me.textBoxUser.Location = New System.Drawing.Point(619, 90)
        Me.textBoxUser.MaxLength = 32767
        Me.textBoxUser.Multiline = True
        Me.textBoxUser.Name = "textBoxUser"
        Me.textBoxUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textBoxUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textBoxUser.SelectedText = ""
        Me.textBoxUser.SelectionLength = 0
        Me.textBoxUser.SelectionStart = 0
        Me.textBoxUser.ShortcutsEnabled = True
        Me.textBoxUser.Size = New System.Drawing.Size(453, 41)
        Me.textBoxUser.TabIndex = 3
        Me.textBoxUser.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textBoxUser.UseSelectable = True
        Me.textBoxUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textBoxUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroListView1
        '
        Me.MetroListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.MetroListView1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MetroListView1.FullRowSelect = True
        Me.MetroListView1.GridLines = True
        Me.MetroListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.MetroListView1.Location = New System.Drawing.Point(619, 224)
        Me.MetroListView1.Name = "MetroListView1"
        Me.MetroListView1.OwnerDraw = True
        Me.MetroListView1.Size = New System.Drawing.Size(713, 419)
        Me.MetroListView1.TabIndex = 4
        Me.MetroListView1.UseCompatibleStateImageBehavior = False
        Me.MetroListView1.UseSelectable = True
        Me.MetroListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "QTY"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "BRAND NAME"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 253
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "GENERIC NAME"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 310
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "SRP"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 103
        '
        'MetroListView2
        '
        Me.MetroListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.MetroListView2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MetroListView2.FullRowSelect = True
        Me.MetroListView2.Location = New System.Drawing.Point(61, 111)
        Me.MetroListView2.Name = "MetroListView2"
        Me.MetroListView2.OwnerDraw = True
        Me.MetroListView2.Size = New System.Drawing.Size(350, 408)
        Me.MetroListView2.TabIndex = 5
        Me.MetroListView2.UseCompatibleStateImageBehavior = False
        Me.MetroListView2.UseSelectable = True
        Me.MetroListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "QTY"
        Me.ColumnHeader5.Width = 62
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ITEM NAME"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 194
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "SRP"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 93
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(619, 51)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(105, 25)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "Search Item:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(61, 653)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(138, 25)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "TOTAL AMOUNT"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(452, 123)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(108, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "DISCOUNT TYPE"
        '
        'btnSenior
        '
        Me.btnSenior.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSenior.Location = New System.Drawing.Point(458, 159)
        Me.btnSenior.Name = "btnSenior"
        Me.btnSenior.Size = New System.Drawing.Size(102, 81)
        Me.btnSenior.TabIndex = 9
        Me.btnSenior.Text = "SENIOR"
        Me.btnSenior.UseSelectable = True
        '
        'btnPwd
        '
        Me.btnPwd.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnPwd.Location = New System.Drawing.Point(458, 259)
        Me.btnPwd.Name = "btnPwd"
        Me.btnPwd.Size = New System.Drawing.Size(102, 81)
        Me.btnPwd.TabIndex = 10
        Me.btnPwd.Text = "PWD"
        Me.btnPwd.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(1253, 712)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(82, 15)
        Me.MetroLabel4.TabIndex = 11
        Me.MetroLabel4.Text = "BRN SYSTEMS"
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.Color.Red
        Me.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.White
        Me.btnVoid.Location = New System.Drawing.Point(458, 379)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(102, 75)
        Me.btnVoid.TabIndex = 12
        Me.btnVoid.Text = "VOID"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'btnTender
        '
        Me.btnTender.BackColor = System.Drawing.Color.Green
        Me.btnTender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTender.ForeColor = System.Drawing.Color.White
        Me.btnTender.Location = New System.Drawing.Point(458, 487)
        Me.btnTender.Name = "btnTender"
        Me.btnTender.Size = New System.Drawing.Size(102, 75)
        Me.btnTender.TabIndex = 13
        Me.btnTender.Text = "TENDER"
        Me.btnTender.UseVisualStyleBackColor = False
        '
        'labelTotalPrice
        '
        Me.labelTotalPrice.AutoSize = True
        Me.labelTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotalPrice.Location = New System.Drawing.Point(312, 650)
        Me.labelTotalPrice.Name = "labelTotalPrice"
        Me.labelTotalPrice.Size = New System.Drawing.Size(75, 33)
        Me.labelTotalPrice.TabIndex = 14
        Me.labelTotalPrice.Text = "0.00"
        '
        'labelTempTotal
        '
        Me.labelTempTotal.AutoSize = True
        Me.labelTempTotal.Location = New System.Drawing.Point(354, 560)
        Me.labelTempTotal.Name = "labelTempTotal"
        Me.labelTempTotal.Size = New System.Drawing.Size(33, 19)
        Me.labelTempTotal.TabIndex = 15
        Me.labelTempTotal.Text = "0.00"
        '
        'labelDiscount
        '
        Me.labelDiscount.AutoSize = True
        Me.labelDiscount.Location = New System.Drawing.Point(354, 592)
        Me.labelDiscount.Name = "labelDiscount"
        Me.labelDiscount.Size = New System.Drawing.Size(33, 19)
        Me.labelDiscount.TabIndex = 16
        Me.labelDiscount.Text = "0.00"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(61, 560)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel5.TabIndex = 17
        Me.MetroLabel5.Text = "Subtotal"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(61, 592)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel6.TabIndex = 18
        Me.MetroLabel6.Text = "Discount (20%)"
        '
        'btnLogout
        '
        Me.btnLogout.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnLogout.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnLogout.Location = New System.Drawing.Point(1240, 36)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(92, 25)
        Me.btnLogout.TabIndex = 19
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseSelectable = True
        '
        'labelTime
        '
        Me.labelTime.AutoSize = True
        Me.labelTime.Location = New System.Drawing.Point(1099, 709)
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(15, 19)
        Me.labelTime.TabIndex = 20
        Me.labelTime.Text = "_"
        '
        'timerClock
        '
        Me.timerClock.Interval = 1000
        '
        'formMainPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1365, 736)
        Me.Controls.Add(Me.labelTime)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.labelDiscount)
        Me.Controls.Add(Me.labelTempTotal)
        Me.Controls.Add(Me.labelTotalPrice)
        Me.Controls.Add(Me.btnTender)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.btnPwd)
        Me.Controls.Add(Me.btnSenior)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroListView2)
        Me.Controls.Add(Me.MetroListView1)
        Me.Controls.Add(Me.textBoxUser)
        Me.Name = "formMainPos"
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "ECT Pharmacy POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textBoxUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroListView1 As MetroFramework.Controls.MetroListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents MetroListView2 As MetroFramework.Controls.MetroListView
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSenior As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPwd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnVoid As Button
    Friend WithEvents btnTender As Button
    Friend WithEvents labelTotalPrice As Label
    Friend WithEvents labelTempTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelDiscount As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnLogout As MetroFramework.Controls.MetroButton
    Friend WithEvents labelTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents timerClock As Timer
End Class
