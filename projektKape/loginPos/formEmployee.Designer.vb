<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEmployee
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
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.linkEmployeeLogin = New MetroFramework.Controls.MetroLabel()
        Me.listEmployee = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 116)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(168, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Select a employee to login."
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 90)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(609, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "_________________________________________________________________________________" &
    "___________________"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(17, 70)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(103, 25)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Employees"
        '
        'btnLogin
        '
        Me.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnLogin.Location = New System.Drawing.Point(342, 362)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(127, 26)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseSelectable = True
        '
        'linkEmployeeLogin
        '
        Me.linkEmployeeLogin.AutoSize = True
        Me.linkEmployeeLogin.Location = New System.Drawing.Point(17, 369)
        Me.linkEmployeeLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkEmployeeLogin.Name = "linkEmployeeLogin"
        Me.linkEmployeeLogin.Size = New System.Drawing.Size(123, 19)
        Me.linkEmployeeLogin.TabIndex = 15
        Me.linkEmployeeLogin.Text = "Back to Login Panel"
        Me.linkEmployeeLogin.UseStyleColors = True
        '
        'listEmployee
        '
        Me.listEmployee.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.listEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.listEmployee.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.listEmployee.FullRowSelect = True
        Me.listEmployee.GridLines = True
        Me.listEmployee.Location = New System.Drawing.Point(17, 147)
        Me.listEmployee.MultiSelect = False
        Me.listEmployee.Name = "listEmployee"
        Me.listEmployee.OwnerDraw = True
        Me.listEmployee.ShowGroups = False
        Me.listEmployee.Size = New System.Drawing.Size(458, 198)
        Me.listEmployee.TabIndex = 102
        Me.listEmployee.UseCompatibleStateImageBehavior = False
        Me.listEmployee.UseSelectable = True
        Me.listEmployee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Employee Name"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 250
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Contact"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 204
        '
        'formEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 406)
        Me.Controls.Add(Me.listEmployee)
        Me.Controls.Add(Me.linkEmployeeLogin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "formEmployee"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents linkEmployeeLogin As MetroFramework.Controls.MetroLabel
    Friend WithEvents listEmployee As MetroFramework.Controls.MetroListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
