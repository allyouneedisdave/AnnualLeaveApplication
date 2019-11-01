
Imports System.IO
Imports System.Reflection
Imports Microsoft.Office.Interop

Public Module DocumentManagement
    ''' <summary>
    ''' Creates a word document from a template, replacing key words with the AnnualLeaveRequest object properties. Returns the file path of the new file if successful or an empty string on failure.
    ''' </summary>
    ''' <param name="newAnnualLeaveRequest"></param>
    ''' <returns>String</returns>
    Public Function CreateWordDocument(ByVal newAnnualLeaveRequest As AnnualLeaveRequest) As String
        Dim newDocumentPath As String

        'Declare Word Application and Document objects.
        Dim wordApp As Word.Application
        Dim wordDoc As Word.Document

        wordApp = CreateObject("Word.Application")
        wordApp.Visible = False

        ' Get path for Word Template
        Dim myTempFile As String = ConvertResourceToWordTemplate()

        ' Attempt to open the Word template. Return on failure.
        Try
            wordDoc = wordApp.Documents.Open(myTempFile)
        Catch ex As Exception
            wordApp.Quit()
            newDocumentPath = ""
            Return newDocumentPath
        End Try


        Dim findText As String
        Dim replaceText As String

        ' Get the properties of the custom object, loop through them and find/replace the values.
        Dim props As PropertyInfo() = newAnnualLeaveRequest.GetType().GetProperties()

        For Each prop As PropertyInfo In props
            findText = prop.Name.ToString()
            replaceText = prop.GetValue(newAnnualLeaveRequest)

            FindAndReplaceText(findText, replaceText, wordApp)
        Next

        ' Create a new file path and attempt to save the edited file. Return on failure. 
        Try
            newDocumentPath = $"{Application.StartupPath.ToLower.Replace("\bin\debug", "").Replace("\bin\release", "")}\TempOutput\Annual Leave Request {newAnnualLeaveRequest.UniqueId.ToString()}.docx"
            wordDoc.SaveAs2(newDocumentPath)
            wordDoc.Close()
            wordApp.Quit()
        Catch ex As Exception
            wordDoc.Close()
            wordApp.Quit()
            newDocumentPath = ""
            Return newDocumentPath
        End Try

        Return newDocumentPath
    End Function

    ' Convert the AnnualLeaveRequestTemplate from bytes in to a temporary .docx file and return the path.
    Private Function ConvertResourceToWordTemplate()

        Dim myTempFile As String = $"{Application.StartupPath.ToLower.Replace("\bin\debug", "").Replace("\bin\release", "")}\Temp\template.docx"

        If Not My.Computer.FileSystem.FileExists($"{Application.StartupPath.ToLower.Replace("\bin\debug", "").Replace("\bin\release", "")}\Temp\template.docx") Then
            My.Computer.FileSystem.WriteAllBytes(myTempFile, My.Resources.AnnualLeaveRequestTemplate, False)
        End If

        Return myTempFile
    End Function

    ' Finds and replace the selected values in the word document.
    Private Sub FindAndReplaceText(ByVal findText As String, ByVal replaceText As String, ByVal wordApp As Microsoft.Office.Interop.Word.Application)

        With wordApp.Selection.Find
            .Text = $"[{findText}]"
            .Replacement.Text = $"{replaceText}"
            .Forward = True
            .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            .Format = False
            .MatchCase = False
            .MatchWholeWord = False
            .MatchWildcards = False
            .MatchSoundsLike = False
            .MatchAllWordForms = False
        End With

        wordApp.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

    End Sub

    ' Delete all temporary files from Temp and TempOutput folders.
    Public Function DeleteTemporaryFiles() As String

        Dim failedToDeleteFiles As Boolean
        Dim failedMessage As String = ""

        Try
            ' Delete all files in the Temp Directory.
            For Each file As IO.FileInfo In New IO.DirectoryInfo($"{Application.StartupPath.ToLower.Replace("\bin\debug", "").Replace("\bin\release", "")}\Temp\").GetFiles
                file.Delete()
            Next
        Catch ex As Exception
            If TypeOf ex Is IOException Then
                failedToDeleteFiles = True
            End If
        End Try

        Try
            ' Delete all files in the Temp Output Directory.
            For Each file As IO.FileInfo In New IO.DirectoryInfo($"{Application.StartupPath.ToLower.Replace("\bin\debug", "").Replace("\bin\release", "")}\TempOutput\").GetFiles
                file.Delete()
            Next
        Catch ex As Exception
            If TypeOf ex Is IOException Then
                failedToDeleteFiles = True
            End If
        End Try

        If failedToDeleteFiles = True Then
            failedMessage = "Unable to delete temporary files. Please ensure all word documents are closed before proceeding or contact Technical Support"
        End If

        Return failedMessage
    End Function

    Public Function CreateOutlookEmailWithAttachment(ByVal newAnnualLeaveRequest As AnnualLeaveRequest, newDocumentPath As String)
        Dim failureString As String = ""

        Try
            Dim outApp As Outlook.Application
            outApp = CreateObject("Outlook.Application")
            Dim outMsg As Outlook.MailItem
            outMsg = outApp.CreateItem(0)
            outMsg.Subject = $"Annual Leave Request Ref: {newAnnualLeaveRequest.UniqueId}"
            outMsg.Attachments.Add(newDocumentPath)
            outMsg.To = newAnnualLeaveRequest.ManagerEmail
            outMsg.Display(True)
        Catch ex As Exception
            failureString = "Outlook could not create a new message. Would you like to open the annual leave request as a word document?"
        End Try


        Return failureString
    End Function

End Module
