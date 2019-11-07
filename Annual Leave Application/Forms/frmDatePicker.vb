Public Class frmDatePicker

#Region "Global Variables"

    ' Publicly accessible property for other forms.
    Public Property DatePicked As String

#End Region

#Region "Control Events"

    ' Clear DatePicked variable if no selection was made.
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DatePicked = ""
        Me.Close()
    End Sub

    ' Set the DatePicked property with the selection and close the form.
    Private Sub CalDatePicker_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calDatePicker.DateSelected

        ' Check the selected date for restricted Weekends.
        If TestDateForSaturdayOrSunday(calDatePicker.SelectionRange.Start) = True Then
            MessageBox.Show("Weekends cannot be selected for annual leave, please select a different date.", "Annual Leave Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DatePicked = ""
            Exit Sub
        End If

        ' Check the selected date for restricted Bank Holidays.
        If TestDateForBankHoliday(calDatePicker.SelectionRange.Start) = True Then
            MessageBox.Show("Bank Holidays cannot be selected for annual leave, please select a different date.", "Annual Leave Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DatePicked = ""
            Exit Sub
        End If

        DatePicked = calDatePicker.SelectionRange.Start.ToShortDateString()
        Me.Close()
    End Sub

#End Region

End Class