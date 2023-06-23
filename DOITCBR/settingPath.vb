Imports System.IO
Module settingPath
    'ini 파일 주소
    Public settingFilePath As String = "E:\연습프로젝트\결과폴더\DOITCBR.ini"
    Public data As New Dictionary(Of String, String)()
    'ini 파일 값 불러오기
    Sub Settinginit()
        Try
            Dim lines As String() = File.ReadAllLines(settingFilePath)
            For Each line As String In lines
                If line.IndexOf("#") <> 0 Then '주석이 아닐때
                    If line.Split("=")(0) <> "cbox_workLst_command" Then '명령어 박스 Key 가 아닐때
                        data(line.Split("=")(0)) = line.Split("=")(1)
                    Else
                        Dim values As String() = line.Split("=")(1).Split("&")
                        For Each value In values
                            data(value.Split(":")(0).Split("[")(1)) = value.Split(":")(1).Split("]")(0)
                        Next
                    End If
                End If
            Next
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub
    'ini 파일에서 원하는 라인을 Insert 시켜주는 함수
    Sub WriteIni(content As String, keyName As String)
        Try
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
                            logger.log($"{keyName} 의 값이 Insert", "i")
                        Else
                            lines(i) = $"{keyName}=" & lines(i).Split("=")(1)
                        End If
                        Exit For
                    Else
                        lines(i) = $"{keyName}=" & content
                        logger.log($"{keyName} 의 값이 Insert", "i")
                        Exit For
                    End If
                End If
            Next
            File.WriteAllLines(settingFilePath, lines)
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub
    '해당 라인 값을 그냥 업데이트해주는 함수
    Sub UpdateIni(content As String, keyName As String)
        Try
            Dim lines As String() = File.ReadAllLines(settingFilePath)

            For i As Integer = 0 To lines.Length - 1
                If lines(i).Split("=")(0).StartsWith($"{keyName}") Then
                    lines(i) = $"{keyName}=" & content
                    logger.log($"{keyName} 의 값이 Update", "i")
                    Exit For
                End If
            Next
            File.WriteAllLines(settingFilePath, lines)
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub
    'ini 원하는 라인의 값에서 원하는 값을 삭제하는 함수
    Sub RemoveFileini(content, keyName)
        Try
            Dim lines As String() = File.ReadAllLines(settingFilePath)
            Dim line_result As String = String.Empty
            For i As Integer = 0 To lines.Length - 1
                If lines(i).Split("=")(0).StartsWith($"{keyName}") Then
                    If lines(i).Split("=")(1) <> String.Empty Then 'null 값 체크
                        '값들을 하나씩 비교해서 체크된 항목만 배제
                        For Each value In lines(i).Split("=")(1).Split(",")
                            If value <> content Then
                                line_result += "," & value
                            End If
                        Next
                        'null 값 체크
                        If line_result <> String.Empty Then
                            lines(i) = $"{keyName}=" & line_result.Substring(1)
                        Else
                            lines(i) = $"{keyName}="
                        End If
                        Exit For
                    Else
                        logger.log($"{keyName} 의 값이 null이기 때문에 삭제되지 않았습니다.", "w")
                        Exit For
                    End If
                End If
            Next
            File.WriteAllLines(settingFilePath, lines)
            logger.log($"{keyName} 의 값이 Update", "i")
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub
    'file 인지 folder 인지 체크해서 경로 설정
    Function chkFileAnsdFolder(p As String)
        Try
            Dim isFilePath As Boolean = File.Exists(p)
            Dim result As String = String.Empty
            If isFilePath Then
                result = Path.GetDirectoryName(p)
            Else
                result = p
            End If
            Return result
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
        Return p
    End Function
End Module
