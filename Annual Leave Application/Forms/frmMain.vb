Public Class frmMain

#Region "Form Events"

#End Region



#Region "Helper Methods"




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



    End Sub



#End Region




End Class
