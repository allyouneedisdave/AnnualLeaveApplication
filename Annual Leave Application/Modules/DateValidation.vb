

''' <summary>
''' A set of functions to validate date selection for restricted dates.
''' </summary>
Public Module DateValidation

    ' Fixed array of bank holiday dates.
    Private Function GetBankHolidayArray() As Date()

        Dim bankHolidays(54) As Date

        '2019 Bank Holidays
        bankHolidays(1) = #1/1/2019# 'New Year's Day
        bankHolidays(2) = #4/19/2019# 'Good Friday
        bankHolidays(3) = #4/22/2019# 'Easter Monday
        bankHolidays(4) = #5/6/2019# 'May Bank Holiday
        bankHolidays(5) = #5/27/2019# 'Spring Bank Holiday
        bankHolidays(6) = #8/26/2019# 'Summer Bank Holiday
        bankHolidays(7) = #12/25/2019# 'Christmas Day
        bankHolidays(8) = #12/26/2019# 'Boxing Day

        '2020 Bank Holidays
        bankHolidays(9) = #1/1/2020# 'New Year's Day
        bankHolidays(10) = #4/10/2020# 'Good Friday
        bankHolidays(11) = #4/13/2020# 'Easter Monday
        bankHolidays(12) = #5/4/2020# 'May Bank Holiday
        bankHolidays(13) = #5/25/2020# 'Spring Bank Holiday
        bankHolidays(14) = #8/31/2020# 'Summer Bank Holiday
        bankHolidays(15) = #12/25/2020# 'Christmas Day
        bankHolidays(16) = #12/26/2020# 'Boxing Day
        bankHolidays(17) = #12/28/2020# 'Boxing Day Sub Day

        '2021 Bank Holidays
        bankHolidays(18) = #1/1/2021# 'New Year's Day
        bankHolidays(19) = #4/02/2021# 'Good Friday
        bankHolidays(20) = #4/05/2021# 'Easter Monday
        bankHolidays(21) = #5/03/2021# 'May Bank Holiday
        bankHolidays(22) = #5/31/2021# 'Spring Bank Holiday
        bankHolidays(23) = #8/30/2021# 'Summer Bank Holiday
        bankHolidays(24) = #12/25/2021# 'Christmas Day
        bankHolidays(25) = #12/26/2021# 'Boxing Day
        bankHolidays(26) = #12/27/2021# 'Christmas Day Sub Day
        bankHolidays(27) = #12/28/2021# 'Boxing Day Sub Day

        '2022 Bank Holidays
        bankHolidays(28) = #1/1/2022# 'New Year's Day
        bankHolidays(29) = #1/3/2022# 'New Year's Day Sub Day
        bankHolidays(30) = #4/15/2022# 'Good Friday
        bankHolidays(31) = #4/18/2022# 'Easter Monday
        bankHolidays(32) = #5/2/2022# 'May Bank Holiday
        bankHolidays(33) = #5/30/2022# 'Spring Bank Holiday
        bankHolidays(34) = #8/29/2022# 'Summer Bank Holiday
        bankHolidays(35) = #12/25/2022# 'Christmas Day
        bankHolidays(36) = #12/26/2022# 'Boxing Day
        bankHolidays(37) = #12/27/2022# 'Christmas Day Sub Day

        '2023 Bank Holidays
        bankHolidays(38) = #1/1/2023# 'New Year's Day
        bankHolidays(39) = #1/2/2023# 'New Year's Day Sub Day
        bankHolidays(40) = #4/7/2023# 'Good Friday
        bankHolidays(41) = #4/10/2023# 'Easter Monday
        bankHolidays(42) = #5/1/2023# 'May Bank Holiday
        bankHolidays(43) = #5/29/2023# 'Spring Bank Holiday
        bankHolidays(44) = #8/28/2023# 'Summer Bank Holiday
        bankHolidays(45) = #12/25/2023# 'Christmas Day
        bankHolidays(46) = #12/26/2023# 'Boxing Day

        '2024 Bank Holidays
        bankHolidays(47) = #1/1/2024# 'New Year's Day
        bankHolidays(48) = #3/29/2024# 'Good Friday
        bankHolidays(49) = #4/1/2024# 'Easter Monday
        bankHolidays(50) = #5/6/2024# 'May Bank Holiday
        bankHolidays(51) = #5/27/2024# 'Spring Bank Holiday
        bankHolidays(52) = #8/26/2024# 'Summer Bank Holiday
        bankHolidays(53) = #12/25/2024# 'Christmas Day
        bankHolidays(54) = #12/26/2024# 'Boxing Day

        Return bankHolidays
    End Function

    ''' <summary>
    ''' Uses a select case to determine if the passed in date is a Saturday or Sunday and returns the result as a boolean.
    ''' </summary>
    ''' <param name="dateSelected"></param>
    ''' <returns>Boolean</returns>
    Public Function TestDateForSaturdayOrSunday(ByVal dateSelected As Date) As Boolean
        Dim dateIsSaturdayOrSunday As Boolean

        Select Case dateSelected.DayOfWeek
            Case DayOfWeek.Saturday
                dateIsSaturdayOrSunday = True
            Case DayOfWeek.Sunday
                dateIsSaturdayOrSunday = True
            Case Else
                dateIsSaturdayOrSunday = False
        End Select

        Return dateIsSaturdayOrSunday
    End Function

    ''' <summary>
    ''' Loops through an arrray of known bank holidays and returns true if the selected date is a Bank Holiday. Returns False if no match is found.
    ''' </summary>
    ''' <param name="dateSelected"></param>
    ''' <returns>Boolean</returns>
    Public Function TestDateForBankHoliday(ByVal dateSelected As Date) As Boolean
        Dim isBankHoliday As Boolean = False

        Dim bankHolidays() As Date = GetBankHolidayArray()

        For i As Integer = 0 To bankHolidays.Length - 1
            If bankHolidays(i) = dateSelected Then
                isBankHoliday = True
                Return isBankHoliday
                Exit Function
            End If
        Next

        Return isBankHoliday
    End Function

    ''' <summary>
    ''' Calculates the working days, deducting weekends and bank holidays from a date range.
    ''' </summary>
    ''' <param name="startDate"></param>
    ''' <param name="endDate"></param>
    ''' <returns>Integer</returns>
    Public Function CalculateWorkingDaysInRange(ByVal startDate As Date, ByVal endDate As Date) As Integer
        Dim workingDays As Integer

        ' Return 1 working day if only one day selected
        If startDate = endDate Then
            workingDays = 1
            Return workingDays
        Else
            Dim timeSpan As TimeSpan = endDate.AddDays(1) - startDate

            workingDays = timeSpan.Days

            Dim bankHolidays() As Date = GetBankHolidayArray()

            While startDate <= endDate
                If startDate.DayOfWeek = DayOfWeek.Saturday Or startDate.DayOfWeek = DayOfWeek.Sunday Then
                    workingDays -= 1
                End If

                For i As Integer = 0 To bankHolidays.Length - 1
                    If bankHolidays(i) = startDate Then
                        workingDays -= 1
                        Exit For
                    End If
                Next

                startDate = startDate.AddDays(1)
            End While

        End If

        Return workingDays
    End Function


End Module
