Module ValidateDateSelection

    ' Uses a select case to determine if the passed in date is a Saturday or Sunday
    ' And returns the result as a boolean.
    Public Function CheckIfDateIsSaturdayOrSunday(ByVal dateSelected As Date) As Boolean
        Dim dateIsSaturdayOrSunday As Boolean = False

        Select Case dateSelected.DayOfWeek
            Case "Saturday"
                dateIsSaturdayOrSunday = True
            Case "Sunday"
                dateIsSaturdayOrSunday = True
            Case Else
                dateIsSaturdayOrSunday = False
        End Select

        Return dateIsSaturdayOrSunday
    End Function



End Module
