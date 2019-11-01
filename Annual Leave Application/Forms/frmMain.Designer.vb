<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtManagerName = New System.Windows.Forms.TextBox()
        Me.lblManagerName = New System.Windows.Forms.Label()
        Me.txtManagerEmail = New System.Windows.Forms.TextBox()
        Me.lblManagerEmail = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.btnStartDate = New System.Windows.Forms.Button()
        Me.btnEndDate = New System.Windows.Forms.Button()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.txtAdditionalNotes = New System.Windows.Forms.TextBox()
        Me.lblAdditionalNotes = New System.Windows.Forms.Label()
        Me.lblPageDescription = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.ttpMainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDaysAnnualLeaveUsed = New System.Windows.Forms.Label()
        Me.lblOptionalNotes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtManagerName
        '
        Me.txtManagerName.Location = New System.Drawing.Point(179, 127)
        Me.txtManagerName.MaxLength = 100
        Me.txtManagerName.Name = "txtManagerName"
        Me.txtManagerName.Size = New System.Drawing.Size(220, 26)
        Me.txtManagerName.TabIndex = 1
        Me.ttpMainToolTip.SetToolTip(Me.txtManagerName, "Enter your manager's name here.")
        '
        'lblManagerName
        '
        Me.lblManagerName.AutoSize = True
        Me.lblManagerName.Location = New System.Drawing.Point(70, 130)
        Me.lblManagerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManagerName.Name = "lblManagerName"
        Me.lblManagerName.Size = New System.Drawing.Size(102, 18)
        Me.lblManagerName.TabIndex = 13
        Me.lblManagerName.Text = "Manager Name"
        '
        'txtManagerEmail
        '
        Me.txtManagerEmail.Location = New System.Drawing.Point(179, 159)
        Me.txtManagerEmail.MaxLength = 200
        Me.txtManagerEmail.Name = "txtManagerEmail"
        Me.txtManagerEmail.Size = New System.Drawing.Size(414, 26)
        Me.txtManagerEmail.TabIndex = 2
        Me.ttpMainToolTip.SetToolTip(Me.txtManagerEmail, "Enter your manager's email address here.")
        '
        'lblManagerEmail
        '
        Me.lblManagerEmail.AutoSize = True
        Me.lblManagerEmail.Location = New System.Drawing.Point(73, 162)
        Me.lblManagerEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManagerEmail.Name = "lblManagerEmail"
        Me.lblManagerEmail.Size = New System.Drawing.Size(99, 18)
        Me.lblManagerEmail.TabIndex = 11
        Me.lblManagerEmail.Text = "Manager Email"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(179, 95)
        Me.txtEmployeeName.MaxLength = 100
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(220, 26)
        Me.txtEmployeeName.TabIndex = 0
        Me.ttpMainToolTip.SetToolTip(Me.txtEmployeeName, "Enter your name here.")
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Location = New System.Drawing.Point(62, 98)
        Me.lblEmployeeName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(110, 18)
        Me.lblEmployeeName.TabIndex = 1
        Me.lblEmployeeName.Text = "Employee Name"
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(179, 191)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.ReadOnly = True
        Me.txtStartDate.Size = New System.Drawing.Size(138, 26)
        Me.txtStartDate.TabIndex = 16
        Me.txtStartDate.TabStop = False
        Me.ttpMainToolTip.SetToolTip(Me.txtStartDate, "Click the button and select a start date.")
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(17, 194)
        Me.lblStartDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(155, 18)
        Me.lblStartDate.TabIndex = 15
        Me.lblStartDate.Text = "Annual Leave Start Date"
        '
        'btnStartDate
        '
        Me.btnStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStartDate.Location = New System.Drawing.Point(323, 191)
        Me.btnStartDate.Name = "btnStartDate"
        Me.btnStartDate.Size = New System.Drawing.Size(26, 26)
        Me.btnStartDate.TabIndex = 3
        Me.ttpMainToolTip.SetToolTip(Me.btnStartDate, "Select a start date.")
        Me.btnStartDate.UseVisualStyleBackColor = True
        '
        'btnEndDate
        '
        Me.btnEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEndDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEndDate.Location = New System.Drawing.Point(323, 223)
        Me.btnEndDate.Name = "btnEndDate"
        Me.btnEndDate.Size = New System.Drawing.Size(26, 26)
        Me.btnEndDate.TabIndex = 4
        Me.ttpMainToolTip.SetToolTip(Me.btnEndDate, "Select an end date.")
        Me.btnEndDate.UseVisualStyleBackColor = True
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(179, 223)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.ReadOnly = True
        Me.txtEndDate.Size = New System.Drawing.Size(138, 26)
        Me.txtEndDate.TabIndex = 19
        Me.txtEndDate.TabStop = False
        Me.ttpMainToolTip.SetToolTip(Me.txtEndDate, "Click the button and select an end date.")
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(23, 226)
        Me.lblEndDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(149, 18)
        Me.lblEndDate.TabIndex = 18
        Me.lblEndDate.Text = "Annual Leave End Date"
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTitle.Location = New System.Drawing.Point(13, 9)
        Me.lblPageTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(302, 39)
        Me.lblPageTitle.TabIndex = 21
        Me.lblPageTitle.Text = "Annual Leave Request"
        '
        'txtAdditionalNotes
        '
        Me.txtAdditionalNotes.Location = New System.Drawing.Point(179, 255)
        Me.txtAdditionalNotes.MaxLength = 1000
        Me.txtAdditionalNotes.Multiline = True
        Me.txtAdditionalNotes.Name = "txtAdditionalNotes"
        Me.txtAdditionalNotes.Size = New System.Drawing.Size(414, 198)
        Me.txtAdditionalNotes.TabIndex = 5
        Me.ttpMainToolTip.SetToolTip(Me.txtAdditionalNotes, "Add any additional notes here, if requesting half day, please specify AM or PM.")
        '
        'lblAdditionalNotes
        '
        Me.lblAdditionalNotes.AutoSize = True
        Me.lblAdditionalNotes.Location = New System.Drawing.Point(60, 258)
        Me.lblAdditionalNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdditionalNotes.Name = "lblAdditionalNotes"
        Me.lblAdditionalNotes.Size = New System.Drawing.Size(112, 18)
        Me.lblAdditionalNotes.TabIndex = 23
        Me.lblAdditionalNotes.Text = "Additional Notes"
        '
        'lblPageDescription
        '
        Me.lblPageDescription.AutoSize = True
        Me.lblPageDescription.Location = New System.Drawing.Point(17, 48)
        Me.lblPageDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPageDescription.Name = "lblPageDescription"
        Me.lblPageDescription.Size = New System.Drawing.Size(508, 18)
        Me.lblPageDescription.TabIndex = 24
        Me.lblPageDescription.Text = "Fill out the fields and click 'Create' to attach the annual leave request to an e" &
    "mail."
        '
        'btnCreate
        '
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCreate.Location = New System.Drawing.Point(179, 463)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(282, 29)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Create Document"
        Me.ttpMainToolTip.SetToolTip(Me.btnCreate, "Create an annual leave request and attach it to an Outlook email.")
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'ttpMainToolTip
        '
        Me.ttpMainToolTip.ToolTipTitle = "Annual Leave Request"
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(467, 463)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 29)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "Exit"
        Me.ttpMainToolTip.SetToolTip(Me.btnExit, "Exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDaysAnnualLeaveUsed
        '
        Me.lblDaysAnnualLeaveUsed.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysAnnualLeaveUsed.Location = New System.Drawing.Point(356, 226)
        Me.lblDaysAnnualLeaveUsed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDaysAnnualLeaveUsed.Name = "lblDaysAnnualLeaveUsed"
        Me.lblDaysAnnualLeaveUsed.Size = New System.Drawing.Size(236, 18)
        Me.lblDaysAnnualLeaveUsed.TabIndex = 26
        Me.lblDaysAnnualLeaveUsed.Text = "0 Days Annual Leave Requested"
        Me.lblDaysAnnualLeaveUsed.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblDaysAnnualLeaveUsed.Visible = False
        '
        'lblOptionalNotes
        '
        Me.lblOptionalNotes.AutoSize = True
        Me.lblOptionalNotes.Location = New System.Drawing.Point(101, 276)
        Me.lblOptionalNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOptionalNotes.Name = "lblOptionalNotes"
        Me.lblOptionalNotes.Size = New System.Drawing.Size(71, 18)
        Me.lblOptionalNotes.TabIndex = 27
        Me.lblOptionalNotes.Text = "(Optional)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(605, 504)
        Me.Controls.Add(Me.lblOptionalNotes)
        Me.Controls.Add(Me.lblDaysAnnualLeaveUsed)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lblPageDescription)
        Me.Controls.Add(Me.lblAdditionalNotes)
        Me.Controls.Add(Me.txtAdditionalNotes)
        Me.Controls.Add(Me.lblPageTitle)
        Me.Controls.Add(Me.btnEndDate)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.btnStartDate)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.txtManagerName)
        Me.Controls.Add(Me.lblManagerName)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.txtManagerEmail)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.lblManagerEmail)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(621, 543)
        Me.MinimumSize = New System.Drawing.Size(621, 543)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Annual Leave Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtManagerName As TextBox
    Friend WithEvents lblManagerName As Label
    Friend WithEvents txtManagerEmail As TextBox
    Friend WithEvents lblManagerEmail As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents lblStartDate As Label
    Friend WithEvents btnStartDate As Button
    Friend WithEvents btnEndDate As Button
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents txtAdditionalNotes As TextBox
    Friend WithEvents lblAdditionalNotes As Label
    Friend WithEvents lblPageDescription As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents ttpMainToolTip As ToolTip
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDaysAnnualLeaveUsed As Label
    Friend WithEvents lblOptionalNotes As Label
End Class
