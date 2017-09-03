<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMainAdmin
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
        Me.labelTimeAdmin = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.listViewAdmin = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddStock = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.btnAddItem = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTimeAdmin
        '
        Me.labelTimeAdmin.AutoSize = True
        Me.labelTimeAdmin.Location = New System.Drawing.Point(1457, 876)
        Me.labelTimeAdmin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTimeAdmin.Name = "labelTimeAdmin"
        Me.labelTimeAdmin.Size = New System.Drawing.Size(15, 20)
        Me.labelTimeAdmin.TabIndex = 22
        Me.labelTimeAdmin.Text = "_"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(1663, 880)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(91, 17)
        Me.MetroLabel4.TabIndex = 21
        Me.MetroLabel4.Text = "BRN SYSTEMS"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.MetroButton5)
        Me.GroupBox1.Controls.Add(Me.MetroButton4)
        Me.GroupBox1.Controls.Add(Me.MetroButton3)
        Me.GroupBox1.Controls.Add(Me.MetroButton1)
        Me.GroupBox1.Controls.Add(Me.MetroButton2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(48, 110)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 439)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'MetroButton5
        '
        Me.MetroButton5.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton5.Highlight = True
        Me.MetroButton5.Location = New System.Drawing.Point(28, 335)
        Me.MetroButton5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(208, 60)
        Me.MetroButton5.TabIndex = 28
        Me.MetroButton5.Text = "Logout"
        Me.MetroButton5.UseSelectable = True
        '
        'MetroButton4
        '
        Me.MetroButton4.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton4.Highlight = True
        Me.MetroButton4.Location = New System.Drawing.Point(28, 267)
        Me.MetroButton4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(208, 60)
        Me.MetroButton4.TabIndex = 27
        Me.MetroButton4.Text = "Admin"
        Me.MetroButton4.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton3.Highlight = True
        Me.MetroButton3.Location = New System.Drawing.Point(28, 193)
        Me.MetroButton3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(208, 66)
        Me.MetroButton3.TabIndex = 26
        Me.MetroButton3.Text = "View Reports"
        Me.MetroButton3.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.White
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.Highlight = True
        Me.MetroButton1.Location = New System.Drawing.Point(28, 46)
        Me.MetroButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(208, 66)
        Me.MetroButton1.TabIndex = 24
        Me.MetroButton1.Text = "Suppliers"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.Highlight = True
        Me.MetroButton2.Location = New System.Drawing.Point(28, 119)
        Me.MetroButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(208, 66)
        Me.MetroButton2.TabIndex = 25
        Me.MetroButton2.Text = "Items"
        Me.MetroButton2.UseSelectable = True
        '
        'listViewAdmin
        '
        Me.listViewAdmin.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.listViewAdmin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.listViewAdmin.FullRowSelect = True
        Me.listViewAdmin.GridLines = True
        Me.listViewAdmin.Location = New System.Drawing.Point(40, 213)
        Me.listViewAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.listViewAdmin.Name = "listViewAdmin"
        Me.listViewAdmin.OwnerDraw = True
        Me.listViewAdmin.Size = New System.Drawing.Size(1339, 426)
        Me.listViewAdmin.TabIndex = 25
        Me.listViewAdmin.UseCompatibleStateImageBehavior = False
        Me.listViewAdmin.UseSelectable = True
        Me.listViewAdmin.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ITEM ID"
        Me.ColumnHeader1.Width = 89
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "BRAND NAME"
        Me.ColumnHeader2.Width = 192
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "GENERIC NAME"
        Me.ColumnHeader3.Width = 242
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "QTY"
        Me.ColumnHeader4.Width = 79
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "SUPPLIER"
        Me.ColumnHeader5.Width = 142
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "RAW PRICE"
        Me.ColumnHeader6.Width = 103
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "SRP"
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "STATUS"
        Me.ColumnHeader8.Width = 77
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnAddStock)
        Me.GroupBox2.Controls.Add(Me.MetroLabel2)
        Me.GroupBox2.Controls.Add(Me.MetroTextBox1)
        Me.GroupBox2.Controls.Add(Me.MetroComboBox1)
        Me.GroupBox2.Controls.Add(Me.btnAddItem)
        Me.GroupBox2.Controls.Add(Me.listViewAdmin)
        Me.GroupBox2.Location = New System.Drawing.Point(383, 110)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1388, 729)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'btnAddStock
        '
        Me.btnAddStock.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAddStock.Location = New System.Drawing.Point(1156, 46)
        Me.btnAddStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(196, 85)
        Me.btnAddStock.TabIndex = 31
        Me.btnAddStock.Text = "ADD STOCK"
        Me.btnAddStock.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(40, 146)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(83, 25)
        Me.MetroLabel2.TabIndex = 30
        Me.MetroLabel2.Text = "SEARCH:"
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(537, 1)
        Me.MetroTextBox1.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(49, 46)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox1.Lines = New String() {"SEARCH"}
        Me.MetroTextBox1.Location = New System.Drawing.Point(435, 149)
        Me.MetroTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Multiline = True
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(441, 39)
        Me.MetroTextBox1.TabIndex = 29
        Me.MetroTextBox1.Text = "SEARCH"
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 29
        Me.MetroComboBox1.Items.AddRange(New Object() {"BRAND NAME", "QTY", "SUPPLIER", "SRP", "STATUS"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(152, 146)
        Me.MetroComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(257, 35)
        Me.MetroComboBox1.TabIndex = 27
        Me.MetroComboBox1.UseSelectable = True
        '
        'btnAddItem
        '
        Me.btnAddItem.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAddItem.Location = New System.Drawing.Point(920, 46)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(196, 85)
        Me.btnAddItem.TabIndex = 26
        Me.btnAddItem.Text = "ADD ITEM"
        Me.btnAddItem.UseSelectable = True
        '
        'formMainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1820, 906)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.labelTimeAdmin)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "formMainAdmin"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "ECT Pharmacy - ADMIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelTimeAdmin As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents listViewAdmin As MetroFramework.Controls.MetroListView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAddItem As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAddStock As MetroFramework.Controls.MetroButton
End Class
