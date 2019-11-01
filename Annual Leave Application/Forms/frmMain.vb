Public Class frmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Delete any temporary files created from previous session.
        Dim failedMessage As String = DeleteTemporaryFiles()

        If failedMessage <> "" Then
            MessageBox.Show("Unable to delete temporary files. Please ensure all word documents are closed before proceeding or contact Technical Support.",
"Annual Leave Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'Close the form and application.
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))

        End If

    End Sub

#Region "Helper Methods"

    'Validate form fields for values. Returns a user prompt if any required fields are left blank.
    'Returns a null String if all required fields are satisfied.
    Private Function ValidateFormFields() As String
        Dim validationMessage As String = ""

        If txtEmployeeName.Text = "" Then
            validationMessage = "Please enter your name in the 'Employee Name' field."
        ElseIf txtManagerName.Text = "" Then
            validationMessage = "Please enter your manager's name in the 'Manager Name' field."
        ElseIf txtManagerEmail.Text = "" Then
            validationMessage = "Please enter your manager's email address in the 'Manager Email' field."
        ElseIf txtStartDate.Text = "" Then
            validationMessage = "Please select a start date for your annual leave by clicking the button."
        ElseIf txtEndDate.Text = "" Then
            validationMessage = "Please select an end date for your annual leave by clicking the button."
        ElseIf Not txtManagerEmail.Text.Contains("@") Then
            validationMessage = "Please enter a valid email address for the 'Manager Email' field."
        End If

        Return validationMessage
    End Function

    ' Displays the total working days requested as annual leave.
    Private Sub DisplayAnnualLeaveDaysRequested(ByVal startDate As String, ByVal endDate As String)
        Dim workingDays As Integer = CalculateWorkingDaysInRange(Date.Parse(startDate), Date.Parse(endDate))
        lblDaysAnnualLeaveUsed.Text = $"{workingDays} Days Annual Leave Requested"
        lblDaysAnnualLeaveUsed.Visible = True
    End Sub

    Private Function GenerateUniqueId() As String
        Dim uniqueId As String = $"{Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "-")}-{txtEmployeeName.Text.Trim()}"

        Return uniqueId
    End Function

    Private Sub ClearInputFields()
        txtEmployeeName.Text = ""
        txtManagerName.Text = ""
        txtManagerEmail.Text = ""
        txtStartDate.Text = ""
        txtEndDate.Text = ""
        txtAdditionalNotes.Text = ""
        lblDaysAnnualLeaveUsed.Visible = False
    End Sub

#End Region


#Region "Button Control Events"

    ' Show a modal calendar date picker.
    Private Sub BtnStartDate_Click(sender As Object, e As EventArgs) Handles btnStartDate.Click

        Dim startDate As String

        frmDatePicker.Owner = Me
        frmDatePicker.Location = PointToScreen(New Point(355, 191))
        frmDatePicker.ShowDialog()
        StartDate = frmDatePicker.DatePicked
        txtStartDate.Text = startDate

    End Sub

    ' Show a modal calendar date picker.
    Private Sub BtnEndDate_Click(sender As Object, e As EventArgs) Handles btnEndDate.Click

        Dim endDate As String

        frmDatePicker.Owner = Me
        frmDatePicker.Location = PointToScreen(New Point(355, 223))
        frmDatePicker.ShowDialog()
        EndDate = frmDatePicker.DatePicked
        txtEndDate.Text = endDate

    End Sub


    ' Validate user input, create an annual leave Word document and attach it to an Outlook email.
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        ' Validate form entry.
        Dim validationString As String = ValidateFormFields()

        ' Exit sub if user input does not pass validation tests.
        If ValidateFormFields() <> "" Then
            MessageBox.Show(validationString, "Annual Leave Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            ' Create Word Document from template.
            ' Create Outlook Email and attach document.
            ' On exception, give the user option to create document only
            ' On total failure, notify user of unavailable service.

            ' Initialize a new AnnualLeaveRequest object and assign properties.
            Dim newAnnualLeaveRequest As New AnnualLeaveRequest With {
                .EmployeeName = txtEmployeeName.Text.Trim(),
                .ManagerName = txtManagerName.Text.Trim(),
                .ManagerEmail = txtManagerEmail.Text.Trim(),
                .StartDate = txtStartDate.Text.Trim(),
                .EndDate = txtEndDate.Text.Trim(),
                .AdditionalNotes = txtAdditionalNotes.Text.Trim(),
                .DaysRequestedCount = CalculateWorkingDaysInRange(Date.Parse(txtStartDate.Text), Date.Parse(txtEndDate.Text))
            }
            Me.Cursor = Cursors.WaitCursor

            'temp
            newAnnualLeaveRequest.UniqueId = GenerateUniqueId()

            Dim newDocumentPath As String = CreateWordDocument(newAnnualLeaveRequest)

            If newDocumentPath = "" Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("The document could not be created, please contact Technical Support.", "Annual Leave Application", MessageBoxButtons.OK)
            Else
                ' Create outlook object.
                Dim failureString As String = CreateOutlookEmailWithAttachment(newAnnualLeaveRequest, newDocumentPath)
                If failureString <> "" Then
                    Dim result As DialogResult = MessageBox.Show($"{failureString}", "Annual Leave Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        Try
                            Process.Start(newDocumentPath)
                        Catch ex As Exception
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("An error occurred when creating the Word document, please contact Technical Support.")
                        End Try
                    Else

                    End If
                End If

            End If

            'Clear input fields
            ClearInputFields()

            Me.Cursor = Cursors.Default

        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub





#End Region


#Region "TextBox Control events"

    Private Sub TxtStartDate_TextChanged(sender As Object, e As EventArgs) Handles txtStartDate.TextChanged
        If txtStartDate.Text <> "" And txtEndDate.Text <> "" Then
            DisplayAnnualLeaveDaysRequested(txtStartDate.Text, txtEndDate.Text)
        Else
            lblDaysAnnualLeaveUsed.Visible = False
        End If
    End Sub

    Private Sub TxtEndDate_TextChanged(sender As Object, e As EventArgs) Handles txtEndDate.TextChanged
        If txtStartDate.Text <> "" And txtEndDate.Text <> "" Then
            DisplayAnnualLeaveDaysRequested(txtStartDate.Text, txtEndDate.Text)
        Else
            lblDaysAnnualLeaveUsed.Visible = False
        End If
    End Sub



#End Region



End Class
