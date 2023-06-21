Imports System.IO
Module settingPath
    'ini 파일 주소
    Public settingFilePath As String = "E:\연습프로젝트\결과폴더\DOITCBR.ini"
    Public data As New Dictionary(Of String, String)()
    Sub Settinginit()
        Dim lines As String() = File.ReadAllLines(settingFilePath)
        For Each line As String In lines
            If line.IndexOf("#") < 0 Then '주석이 아닐때
                data(line.Split("=")(0)) = line.Split("=")(1)
            End If
        Next
    End Sub
    'ini 파일에서 원하는 라인을 Insert 시켜주는 함수
    Sub WriteIni(content As String, keyName As String)
        Dim lines As String() = File.ReadAllLines(settingFilePath)
        '중복 체크 변수
        Dim chkControl As Boolean = False
        For i As Integer = 0 To lines.Length - 1
            If lines(i).Split("=")(0).StartsWith($"{keyName}") Then
                If lines(i).Split("=")(1) <> String.Empty Then 'null 값 체크
                    '이전에 값들 
                    Dim chkpreValues As String() = lines(i).Split("=")(1).Split(",")
                    For Each chkv In chkpreValues '중복 값 체크  True : 중복 False: 중복 X
                        If chkv = content Then
                            chkControl = True
                        End If
                    Next
                    '중복 검사 후에도 중복이 아니면
                    If chkControl <> True Then
                        lines(i) = $"{keyName}=" & lines(i).Split("=")(1) & "," & content
                        logger.log($"ini 파일에 {keyName} 의 값이 Insert 되었습니다.", "i")
                    Else
                        lines(i) = $"{keyName}=" & lines(i).Split("=")(1)
                    End If
                    Exit For
                Else
                    lines(i) = $"{keyName}=" & content
                    logger.log($"ini 파일에 {keyName} 의 값이 Insert 되었습니다.", "i")
                    Exit For
                End If
            End If
        Next
        File.WriteAllLines(settingFilePath, lines)
    End Sub
    '라인을 업데이트 시켜주는 함수
    Sub UpdateIni(content As String, keyName As String)
        Dim lines As String() = File.ReadAllLines(settingFilePath)
        '중복 체크 변수
        Dim chkControl As Boolean = False
        For i As Integer = 0 To lines.Length - 1
            If lines(i).Split("=")(0).StartsWith($"{keyName}") Then
                lines(i) = $"{keyName}=" & lines(i).Split("=")(1) & content
                logger.log($"ini 파일에 {keyName} 의 값이 Update 되었습니다.", "i")
                Exit For
            End If
        Next
        File.WriteAllLines(settingFilePath, lines)
    End Sub
    'ini 원하는 라인의 값에서 원하는 값을 삭제하는 함수
    Sub RemoveFileini(content As String, keyName As String)
        Dim lines As String() = File.ReadAllLines(settingFilePath)
        Dim line_result As String = String.Empty
        For i As Integer = 0 To lines.Length - 1
            If lines(i).Split("=")(0).StartsWith($"{keyName}") Then
                If lines(i).Split("=")(1) <> String.Empty Then 'null 값 체크
                    '값들을 하나씩 비교
                    For Each value In lines(i).Split("=")(1).Split(",")
                        If value <> content Then
                            line_result += "," & content
                        End If
                    Next
                    lines(i) = $"{keyName}=" & line_result
                    Exit For
                Else
                    logger.log($"ini 파일에 {keyName} 의 값이 null이기 때문에 삭제되지 않았습니다.", "w")
                    Exit For
                End If
            End If
        Next
        File.WriteAllLines(settingFilePath, lines)
        logger.log($"ini 파일에 {keyName} 의 값이 Update 되었습니다.", "i")
    End Sub
End Module
