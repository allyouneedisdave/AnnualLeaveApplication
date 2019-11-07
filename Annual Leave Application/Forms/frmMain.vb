
Public Class frmMain

#Region "Form Events"

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Delete any temporary files created from the previous session.
        Dim failedMessage As String = DeleteTemporaryFiles()

        If failedMessage <> "" Then
            MessageBox.Show("Unable to delete temporary files. Please ensure all word documents are closed before proceeding or contact Technical Support.",
"Annual Leave Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'Close the form and application.
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))

        End If

    End Sub

#End Region

#Region "Helper Methods"

    ' Validate form fields for values. Returns a user prompt if any required fields are left blank.
    ' Returns a null String if all required fields are satisfied.
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
        Else
            ' Validate Email Address.
            Dim isValidEmail As Boolean = Validate_Email(txtManagerEmail.Text)

            If isValidEmail = False Then
                validationMessage = "Please enter a valid email address for the 'Manager Email' field."
            End If
        End If
        Return validationMessage
    End Function

    ' Displays the total working days requested as annual leave.
    Private Sub DisplayAnnualLeaveDaysRequested(ByVal startDate As String, ByVal endDate As String)
        Dim workingDays As Integer = CalculateWorkingDaysInRange(Date.Parse(startDate), Date.Parse(endDate))
        lblDaysAnnualLeaveUsed.Text = $"{workingDays} Days Annual Leave Requested"
        lblDaysAnnualLeaveUsed.Visible = True
    End Sub

    ' Generates a unique ID for the document.
    Private Function GenerateUniqueId() As String
        Dim uniqueId As String = $"{Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "-")}-{txtEmployeeName.Text.Trim()}"

        Return uniqueId
    End Function

    ' Clears all form fields and controls for next input.
    Private Sub ClearInputFields()
        txtEmployeeName.Text = ""
        txtManagerName.Text = ""
        txtManagerEmail.Text = ""
        txtStartDate.Text = ""
        txtEndDate.Text = ""
        txtAdditionalNotes.Text = ""
        lblDaysAnnualLeaveUsed.Visible = False
    End Sub

    ' Check the start precedes the end date.
    Private Function ValidateStartAndEndDate() As Boolean
        Dim datesAreValid As Boolean
        If TestStartDatePrecedesEndDate(DateTime.Parse(txtStartDate.Text), DateTime.Parse(txtEndDate.Text)) = False Then
            datesAreValid = False
            txtStartDate.Text = ""
            txtEndDate.Text = ""
            MessageBox.Show($"You have selected a start date that is later than the end date.{vbCrLf}{vbCrLf}
The date fields will now be cleared.  Please make a valid selection", "Annual Leave Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            datesAreValid = True
        End If

        Return datesAreValid
    End Function

#End Region

#Region "Button Control Events"

    ' Show a modal calendar date picker.
    Private Sub BtnStartDate_Click(sender As Object, e As EventArgs) Handles btnStartDate.Click

        Dim startDate As String

        frmDatePicker.Owner = Me
        frmDatePicker.Location = PointToScreen(New Point(355, 191))
        frmDatePicker.ShowDialog()
        startDate = frmDatePicker.DatePicked
        txtStartDate.Text = startDate

    End Sub

    ' Show a modal calendar date picker.
    Private Sub BtnEndDate_Click(sender As Object, e As EventArgs) Handles btnEndDate.Click

        Dim endDate As String

        frmDatePicker.Owner = Me
        frmDatePicker.Location = PointToScreen(New Point(355, 223))
        frmDatePicker.ShowDialog()
        endDate = frmDatePicker.DatePicked
        txtEndDate.Text = endDate

    End Sub

    ' Validate user input, create an annual leave Word document and attach it to an Outlook email.
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        ' Validate input for form fields.
        Dim validationString As String = ValidateFormFields()

        ' Exit sub if user input does not pass validation tests.
        If ValidateFormFields() <> "" Then
            MessageBox.Show(validationString, "Annual Leave Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
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

            ' Generate Unique ID.
            newAnnualLeaveRequest.UniqueId = GenerateUniqueId()

            ' Generate a word document.
            Dim newDocumentPath As String = CreateWordDocument(newAnnualLeaveRequest)

            ' Exit application if word document could not be created.
            If newDocumentPath = "" Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("The document could not be created, please contact Technical Support.", "Annual Leave Application", MessageBoxButtons.OK)
                Me.Close()
            Else
                ' Create Outlook object and attempt to attach email.
                Dim failureString As String = CreateOutlookEmailWithAttachment(newAnnualLeaveRequest, newDocumentPath)
                If failureString <> "" Then
                    ' Give the option to open the word document and attach manually in the event of Outlook failure.
                    Dim result As DialogResult = MessageBox.Show($"{failureString}", "Annual Leave Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        Try
                            Process.Start(newDocumentPath)
                        Catch ex As Exception
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("An error occurred when creating the Word document, please contact Technical Support.")
                        End Try
                    End If
                End If
            End If

            ' Clear input fields.
            ClearInputFields()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    ' Exit the application.
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

#End Region

#Region "TextBox Control events"

    Private Sub TxtStartDate_TextChanged(sender As Object, e As EventArgs) Handles txtStartDate.TextChanged
        If txtStartDate.Text <> "" And txtEndDate.Text <> "" Then

            If ValidateStartAndEndDate() = False Then
                Exit Sub
            End If

            DisplayAnnualLeaveDaysRequested(txtStartDate.Text, txtEndDate.Text)
        Else
            lblDaysAnnualLeaveUsed.Visible = False
        End If
    End Sub

    Private Sub TxtEndDate_TextChanged(sender As Object, e As EventArgs) Handles txtEndDate.TextChanged
        If txtStartDate.Text <> "" And txtEndDate.Text <> "" Then

            If ValidateStartAndEndDate() = False Then
                Exit Sub
            End If

            DisplayAnnualLeaveDaysRequested(txtStartDate.Text, txtEndDate.Text)
        Else
            lblDaysAnnualLeaveUsed.Visible = False
        End If
    End Sub

    Private Sub TxtEmployeeName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmployeeName.KeyPress
        ' Restrict non alphabetical input. Allow space bar.
        If Not (Asc(e.KeyChar) = 8) Then
            Dim validCharacters As String = " abcdefghijklmnopqrstuvwxyz"
            If Not validCharacters.Contains(e.KeyChar.ToString().ToLower()) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                MessageBox.Show("Please do not input numbers or special characters.")
            End If
        End If
    End Sub

    Private Sub TxtManagerName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtManagerName.KeyPress
        ' Restrict non alphabetical input. Allow space bar.
        If Not Asc(e.KeyChar) = 8 Then
            Dim validCharacters As String = " abcdefghijklmnopqrstuvwxyz"
            If Not validCharacters.Contains(e.KeyChar.ToString().ToLower()) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                MessageBox.Show("Please do not input numbers or special characters.")
            End If
        End If
    End Sub

    Private Sub TxtManagerEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtManagerEmail.KeyPress
        ' Restrict space bar input.
        If Asc(e.KeyChar) = 32 Then
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

#End Region

End Class
