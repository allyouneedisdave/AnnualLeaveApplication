
Public Module DocumentManagement

    'uniqueReference, manager, startDate, endDate, daysRequestedCount, additionalNotes, employee

    Public Function CreateWordDocument(ByVal newAnnualLeaveRequest As AnnualLeaveRequest) As Boolean
        Dim documentCreated As Boolean


        'Microsoft Word 16.0 Object Library - add reference
        Dim wordApp As Microsoft.Office.Interop.Word.Application
        Dim wordDoc As Microsoft.Office.Interop.Word.Document

        wordApp = CreateObject("Word.Application")

        wordDoc = wordApp.Documents.Open(My.Resources.AnnualLeaveRequestTemplate)

        wordApp.Visible = False



        Return documentCreated
    End Function


    Private Sub FindAndReplaceText(ByVal findText As String, ByVal replaceText As String, ByVal wordDoc As Microsoft.Office.Interop.Word.Document, ByVal wordApp As Microsoft.Office.Interop.Word.Application)

        With wordApp.Selection.Find
            .Text = $"[{findText}]"               'text to find
            .Replacement.Text = $"[{replaceText}]"  'text to replace it with
            .Forward = True                 'keep going forward
            .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue   'keep continuing
            .Format = False                 'no need to update formatting
            .MatchCase = False              'no need to match case (caps / lower)
            .MatchWholeWord = False         'no need to match whole word (rather than part)
            .MatchWildcards = False         'no wildcard matching
            .MatchSoundsLike = False        'no match for similar words
            .MatchAllWordForms = False      'no match for different forms (e.g. past tenses)
        End With

    End Sub


End Module
