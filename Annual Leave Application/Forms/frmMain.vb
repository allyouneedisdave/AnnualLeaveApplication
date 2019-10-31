Public Class frmMain

#Region "Form Events"

#End Region



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
        End If

        Return validationMessage
    End Function


#End Region


#Region "Control Click Events"

    ' Show a modal calendar date picker.
    Private Sub btnStartDate_Click(sender As Object, e As EventArgs) Handles btnStartDate.Click

        Dim StartDate As String = ""

        frmDatePicker.Owner = Me
        frmDatePicker.Location = btnStartDate.Location
        frmDatePicker.ShowDialog()
        StartDate = frmDatePicker.DatePicked
        txtStartDate.Text = StartDate

    End Sub

    ' Show a modal calendar date picker.
    Private Sub btnEndDate_Click(sender As Object, e As EventArgs) Handles btnEndDate.Click

        Dim EndDate As String = ""

        frmDatePicker.Owner = Me
        frmDatePicker.Location = btnEndDate.Location
        frmDatePicker.ShowDialog()
        EndDate = frmDatePicker.DatePicked
        txtEndDate.Text = EndDate

    End Sub


    ' Validate user input, create an annual leave Word document and attach it to an Outlook email.
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

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
            Dim newAnnualLeaveRequest As New AnnualLeaveRequest()
            newAnnualLeaveRequest.EmployeeName = txtEmployeeName.Text
            newAnnualLeaveRequest.ManagerName = txtManagerName.Text
            newAnnualLeaveRequest.ManagerEmail = txtManagerEmail.Text
            newAnnualLeaveRequest.StartDate = txtStartDate.Text
            newAnnualLeaveRequest.EndDate = txtEndDate.Text
            newAnnualLeaveRequest.AdditionalNotes = txtAdditionalNotes.Text



        End If

    End Sub



#End Region




End Class
