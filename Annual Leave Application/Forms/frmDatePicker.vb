Public Class frmDatePicker

#Region "Global Variables"

    ' Publicly accessable property for other forms.
    Public Property DatePicked As String

#End Region

#Region "Control Events"

    ' Clear DatePicked variable if no selection was made.
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DatePicked = ""
        Me.Close()
    End Sub

    ' Set the DatePicked property with the selection and close the form.
    Private Sub calDatePicker_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calDatePicker.DateSelected

        'Validate the selected date
        If CheckIfDateIsSaturdayOrSunday(calDatePicker.SelectionRange.Start) = True Then
            MessageBox.Show("Weekends cannot be selected for annual leave, please select a different date.", "Annual Leave Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            calDatePicker.SelectionRange = Nothing
            Exit Sub
        End If




        DatePicked = calDatePicker.SelectionRange.Start.ToShortDateString()
        Me.Close()
    End Sub




#End Region









End Class