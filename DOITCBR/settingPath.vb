Imports System.IO
Module settingPath
    'ini 파일 주소
    Public settingFilePath As String = "E:\연습프로젝트\결과폴더\DOITCBR.ini"
    Public data As New Dictionary(Of String, String)()
    Sub Settinginit()
        Dim lines As String() = File.ReadAllLines(settingFilePath)
        For Each line As String In lines
            If line.IndexOf("#") < 0 Then '주석이 아닐때
                data.Add(line.Split("=")(0), line.Split("=")(1))
            End If
        Next
    End Sub
End Module
