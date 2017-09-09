<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMainPos
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
        Me.components = New System.ComponentModel.Container()
        Me.txtSearchProduct = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnTender = New System.Windows.Forms.Button()
        Me.btnLogout = New MetroFramework.Controls.MetroButton()
        Me.labelTime = New MetroFramework.Controls.MetroLabel()
        Me.timerClock = New System.Windows.Forms.Timer(Me.components)
        Me.listProducts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listBuy = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelTotalPrice = New System.Windows.Forms.Label()
        Me.labelTempTotal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearchProduct
        '
        '
        '
        '
        Me.txtSearchProduct.CustomButton.Image = Nothing
        Me.txtSearchProduct.CustomButton.Location = New System.Drawing.Point(445, 1)
        Me.txtSearchProduct.CustomButton.Name = ""
        Me.txtSearchProduct.CustomButton.Size = New System.Drawing.Size(39, 39)
        Me.txtSearchProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchProduct.CustomButton.TabIndex = 1
        Me.txtSearchProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchProduct.CustomButton.UseSelectable = True
        Me.txtSearchProduct.CustomButton.Visible = False
        Me.txtSearchProduct.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSearchProduct.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtSearchProduct.Lines = New String(-1) {}
        Me.txtSearchProduct.Location = New System.Drawing.Point(653, 90)
        Me.txtSearchProduct.MaxLength = 32767
        Me.txtSearchProduct.Multiline = True
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchProduct.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchProduct.SelectedText = ""
        Me.txtSearchProduct.SelectionLength = 0
        Me.txtSearchProduct.SelectionStart = 0
        Me.txtSearchProduct.ShortcutsEnabled = True
        Me.txtSearchProduct.Size = New System.Drawing.Size(485, 41)
        Me.txtSearchProduct.TabIndex = 3
        Me.txtSearchProduct.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchProduct.UseSelectable = True
        Me.txtSearchProduct.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchProduct.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.btnVoid.Enabled = False
        Me.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.White
        Me.btnVoid.Location = New System.Drawing.Point(510, 236)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(102, 75)
        Me.btnVoid.TabIndex = 12
        Me.btnVoid.Text = "VOID TRANSACTON"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'btnTender
        '
        Me.btnTender.BackColor = System.Drawing.Color.Green
        Me.btnTender.Enabled = False
        Me.btnTender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTender.ForeColor = System.Drawing.Color.White
        Me.btnTender.Location = New System.Drawing.Point(510, 335)
        Me.btnTender.Name = "btnTender"
        Me.btnTender.Size = New System.Drawing.Size(102, 75)
        Me.btnTender.TabIndex = 13
        Me.btnTender.Text = "TENDER CASH"
        Me.btnTender.UseVisualStyleBackColor = False
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
        Me.labelTime.Location = New System.Drawing.Point(1064, 708)
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(15, 19)
        Me.labelTime.TabIndex = 20
        Me.labelTime.Text = "_"
        '
        'timerClock
        '
        Me.timerClock.Interval = 1000
        '
        'listProducts
        '
        Me.listProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader8, Me.ColumnHeader12})
        Me.listProducts.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listProducts.FullRowSelect = True
        Me.listProducts.GridLines = True
        Me.listProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listProducts.Location = New System.Drawing.Point(653, 139)
        Me.listProducts.Name = "listProducts"
        Me.listProducts.Size = New System.Drawing.Size(644, 440)
        Me.listProducts.TabIndex = 22
        Me.listProducts.UseCompatibleStateImageBehavior = False
        Me.listProducts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STOCK"
        Me.ColumnHeader1.Width = 88
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "BRAND NAME"
        Me.ColumnHeader2.Width = 282
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "GENERIC NAME"
        Me.ColumnHeader3.Width = 208
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "SRP"
        Me.ColumnHeader4.Width = 194
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ITEM CODE"
        Me.ColumnHeader8.Width = 112
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "RAW PRICE"
        '
        'listBuy
        '
        Me.listBuy.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader11, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader13})
        Me.listBuy.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBuy.FullRowSelect = True
        Me.listBuy.GridLines = True
        Me.listBuy.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listBuy.Location = New System.Drawing.Point(23, 90)
        Me.listBuy.Name = "listBuy"
        Me.listBuy.Size = New System.Drawing.Size(459, 393)
        Me.listBuy.TabIndex = 23
        Me.listBuy.UseCompatibleStateImageBehavior = False
        Me.listBuy.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "QTY"
        Me.ColumnHeader5.Width = 75
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "BrandName"
        Me.ColumnHeader6.Width = 132
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "GenericName"
        Me.ColumnHeader11.Width = 174
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "SRP"
        Me.ColumnHeader7.Width = 81
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ID"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "STOCK"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "RAWPRICE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(649, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "SEARCH ITEM: (BRANDNAME / GENERIC NAME)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 535)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "SUBTOTAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 21)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "TOTAL AMOUNT"
        '
        'labelTotalPrice
        '
        Me.labelTotalPrice.AutoSize = True
        Me.labelTotalPrice.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotalPrice.Location = New System.Drawing.Point(304, 25)
        Me.labelTotalPrice.Name = "labelTotalPrice"
        Me.labelTotalPrice.Size = New System.Drawing.Size(125, 65)
        Me.labelTotalPrice.TabIndex = 29
        Me.labelTotalPrice.Text = "0.00"
        '
        'labelTempTotal
        '
        Me.labelTempTotal.AutoSize = True
        Me.labelTempTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTempTotal.Location = New System.Drawing.Point(334, 536)
        Me.labelTempTotal.Name = "labelTempTotal"
        Me.labelTempTotal.Size = New System.Drawing.Size(40, 21)
        Me.labelTempTotal.TabIndex = 30
        Me.labelTempTotal.Text = "0.00"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labelTotalPrice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 609)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 103)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'formMainPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.labelTempTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listBuy)
        Me.Controls.Add(Me.listProducts)
        Me.Controls.Add(Me.labelTime)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnTender)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtSearchProduct)
        Me.Name = "formMainPos"
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = " ECT Pharmacy POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchProduct As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnVoid As Button
    Friend WithEvents btnTender As Button
    Friend WithEvents btnLogout As MetroFramework.Controls.MetroButton
    Friend WithEvents labelTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents timerClock As Timer
    Friend WithEvents listProducts As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents listBuy As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labelTotalPrice As Label
    Friend WithEvents labelTempTotal As Label
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
End Class
