Public Class AnnualLeaveRequest

    Private _employeeName As String
    Private _managerName As String
    Private _managerEmail As String
    Private _startDate As String
    Private _endDate As String
    Private _additionalNotes As String = ""
    Private _uniqueReference As String
    Private _daysRequestedCount As Integer

    ' Constants
    Private Const employeeNamePlaceHolder As String = "employee"
    Private Const managerNamePlaceHolder As String = "manager"
    Private Const startDatePlaceHolder As String = "startDate"
    Private Const endDatePlaceHolder As String = "endDate"
    Private Const daysRequestedCountPlaceHolder As String = "daysRequestedCount"
    Private Const additionalNotesPlaceHolder As String = "additionalNotes"
    Private Const uniqueReferencePlaceHolder As String = "uniqueReference"



    ' Getter and Setter for _employeeName variable
    Public Property EmployeeName() As String
        Get
            Return _employeeName
        End Get
        Set(ByVal value As String)
            _employeeName = value
        End Set
    End Property

    ' Getter and Setter for _managerName variable
    Public Property ManagerName() As String
        Get
            Return _managerName
        End Get
        Set(ByVal value As String)
            _managerName = value
        End Set
    End Property

    ' Getter and Setter for _managerEmail variable
    Public Property ManagerEmail() As String
        Get
            Return _managerEmail
        End Get
        Set(ByVal value As String)
            _managerEmail = value
        End Set
    End Property

    ' Getter and Setter for _startDate variable
    Public Property StartDate() As String
        Get
            Return _startDate
        End Get
        Set(ByVal value As String)
            _startDate = value
        End Set
    End Property

    ' Getter and Setter for _endDate variable
    Public Property EndDate() As String
        Get
            Return _endDate
        End Get
        Set(ByVal value As String)
            _endDate = value
        End Set
    End Property

    ' Getter and Setter for _additionalNotes variable
    Public Property AdditionalNotes() As String
        Get
            Return _additionalNotes
        End Get
        Set(ByVal value As String)
            _additionalNotes = value
        End Set
    End Property

    ' Getter and Setter for _uniqueId variable
    Public Property UniqueId() As String
        Get
            Return _uniqueReference
        End Get
        Set(ByVal value As String)
            _uniqueReference = value
        End Set
    End Property

    ' Getter and Setter for _daysRequestedCount variable
    Public Property DaysRequestedCount() As Integer
        Get
            Return _daysRequestedCount
        End Get
        Set(ByVal value As Integer)
            _daysRequestedCount = value
        End Set
    End Property


End Class
