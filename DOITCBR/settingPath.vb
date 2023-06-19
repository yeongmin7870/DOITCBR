Imports System.IO
Module settingPath
    'ini 파일 주소
    Public settingFilePath As String = "E:\연습프로젝트\결과폴더\DOITCBR.ini"
    Public logPath As String = String.Empty

    Sub Settinginit()
        Dim lines As String() = File.ReadAllLines(settingFilePath)

        For Each line As String In lines
            logger.log(line, "i")
        Next
    End Sub


End Module
