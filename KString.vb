Imports System.Globalization

Public Class KString
    Public Function KRemoveWhiteSpace(ByVal strText As String) As String
        Dim S As String
        S = System.Text.RegularExpressions.Regex.Replace(strText, " ", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
        S = System.Text.RegularExpressions.Regex.Replace(strText, " ", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        Return S
    End Function

    Public Function KRemoveLineFeeds(ByVal strText As String) As String
        Dim S As String

        S = System.Text.RegularExpressions.Regex.Replace(strText, ControlChars.NewLine, String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
        S = System.Text.RegularExpressions.Regex.Replace(S, ControlChars.Cr, String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
        S = System.Text.RegularExpressions.Regex.Replace(S, ControlChars.CrLf, String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
        S = System.Text.RegularExpressions.Regex.Replace(S, ControlChars.FormFeed, String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
        S = System.Text.RegularExpressions.Regex.Replace(S, ControlChars.Lf, String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
        S = System.Text.RegularExpressions.Regex.Replace(S, ControlChars.NullChar, String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
        S = System.Text.RegularExpressions.Regex.Replace(S, ControlChars.Tab, String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
        S = System.Text.RegularExpressions.Regex.Replace(S, ControlChars.VerticalTab, String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
        Return S

    End Function
    Public Function KCleanString(ByVal Str As String) As String
        Dim S As String = ""
        S = KRemoveWhiteSpace(Str)
        S = KRemoveLineFeeds(S)
        Return S
    End Function

    Public Function KOpenTextFile(ByVal sourceFilePath As String) As String

        Dim result As String
        result = ""

        Try
            
            Using sr As IO.StreamReader = IO.File.OpenText(sourceFilePath)
                result = sr.ReadToEnd
            End Using
            Return result
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        OpenTextFile = result
    End Function

    Public Function KCompareString(ByVal Str1 As String, ByVal Str2 As String, ByVal LangCode as String) As Boolean

        Dim Matched As Boolean = False
    '"ur-PK"
        If (String.Compare(Str1, Str2, New CultureInfo(LangCode), CompareOptions.Ordinal)) = 0 Then
            Matched = True
        End If

        Return Matched

    End Function
End Class
