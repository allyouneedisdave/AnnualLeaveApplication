<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtLineManagerName = New System.Windows.Forms.TextBox()
        Me.lblLineManagerName = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.lblLineManagerEmail = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLineManagerName
        '
        Me.txtLineManagerName.Location = New System.Drawing.Point(16, 109)
        Me.txtLineManagerName.Name = "txtLineManagerName"
        Me.txtLineManagerName.Size = New System.Drawing.Size(220, 26)
        Me.txtLineManagerName.TabIndex = 14
        '
        'lblLineManagerName
        '
        Me.lblLineManagerName.AutoSize = True
        Me.lblLineManagerName.Location = New System.Drawing.Point(13, 88)
        Me.lblLineManagerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLineManagerName.Name = "lblLineManagerName"
        Me.lblLineManagerName.Size = New System.Drawing.Size(131, 18)
        Me.lblLineManagerName.TabIndex = 13
        Me.lblLineManagerName.Text = "Line Manager Name"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(16, 159)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(413, 26)
        Me.TextBox7.TabIndex = 12
        '
        'lblLineManagerEmail
        '
        Me.lblLineManagerEmail.AutoSize = True
        Me.lblLineManagerEmail.Location = New System.Drawing.Point(13, 138)
        Me.lblLineManagerEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLineManagerEmail.Name = "lblLineManagerEmail"
        Me.lblLineManagerEmail.Size = New System.Drawing.Size(128, 18)
        Me.lblLineManagerEmail.TabIndex = 11
        Me.lblLineManagerEmail.Text = "Line Manager Email"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(16, 30)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(220, 26)
        Me.txtFirstName.TabIndex = 2
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Location = New System.Drawing.Point(13, 9)
        Me.lblEmployeeName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(110, 18)
        Me.lblEmployeeName.TabIndex = 1
        Me.lblEmployeeName.Text = "Employee Name"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(948, 597)
        Me.Controls.Add(Me.txtLineManagerName)
        Me.Controls.Add(Me.lblLineManagerName)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblLineManagerEmail)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Annual Leave Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLineManagerName As TextBox
    Friend WithEvents lblLineManagerName As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents lblLineManagerEmail As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblEmployeeName As Label
End Class
