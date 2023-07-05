Imports System.IO
Imports Newtonsoft.Json.Linq
Imports System.Reflection
Module settingPath
    'ini 파일 주소
    Public settingFilePath As String = String.Empty
    Sub Init()
        Try
            'JSON 파일의 이름
            Dim jsonFileName As String = "DOITCBR.json"
            'Log 파일의 이름
            Dim logFileName As String = "log.txt"
            'cmd history 파일의 이름
            Dim cmdHistoryFileName As String = "cmdHistory.txt"
            '내장된 리소스 이름 생성
            Dim resourceName As String = jsonFileName
            settingFilePath = resourceName

            If File.Exists(settingFilePath) Then
            Else
                MessageBox.Show("EXE 파일 경로에 ""DOITCBR.json"" 파일을 위치시키세요")
                End
            End If
            If File.Exists(logFileName) Then
                UPONEDATEDATA(logFileName, "log")
            Else
                '로그 파일생성
                File.Create(logFileName).Dispose()
                MessageBox.Show($"EXE 파일 경로에 ""log.txt"" 파일이 위치되어 있지 않기 때문에 ""{logFileName}""을 자동 생성시켰습니다.")
            End If
            If File.Exists(cmdHistoryFileName) Then
                UPONEDATEDATA(cmdHistoryFileName, "cmd")
            Else
                '로그 파일생성
                File.Create(cmdHistoryFileName).Dispose()
                MessageBox.Show($"EXE 파일 경로에 ""{cmdHistoryFileName}"" 파일이 위치되어 있지 않기 때문에 ""{cmdHistoryFileName}""을 자동 생성시켰습니다.")
            End If

        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub

    'pth 파일 주소 key: 대분류 key
    Function GETValue(key As String) As Object
        Try
            Dim jsonString As String = String.Empty
            jsonString = File.ReadAllText(settingFilePath)
            'JSON 데이터 역직렬화
            Dim jsonData As Object = JObject.Parse(jsonString)
            Return jsonData(key)("path")
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function
    Function GETCMDVALUE(key As String, key2 As String) As Object
        Try
            Dim jsonString As String = String.Empty
            jsonString = File.ReadAllText(settingFilePath)
            'JSON 데이터 역직렬화
            Dim jsonData As Object = JObject.Parse(jsonString)
            Return jsonData(key)(key2)
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    ''ini 파일 값 불러오기
    'Sub Settinginit()
    '    Try
    '        Dim lines As String() = File.ReadAllLines(settingFilePath)
    '        For Each line As String In lines

    '            'If line.Split("=")(0) <> "cbox_workLst_command" Then '명령어 박스 Key 가 아닐때
    '            data(line.Split("=")(0)) = line.Split("=")(1)

    '        Next
    '    Catch ex As Exception
    '        logger.log(ex.ToString, "w")
    '    End Try
    'End Sub
    'ini 파일에서 원하는 라인을 Insert 시켜주는 함수
    'Sub UPDATEDATA(content As String, keyName As String)
    '    Try
    '        Dim lines As String() = File.ReadAllLines(settingFilePath)
    '        '중복 체크 변수
    '        Dim chkControl As Boolean = False
    '        For i As Integer = 0 To lines.Length - 1
    '            If lines(i).Split("=")(0).StartsWith($"{keyName}") Then
    '                If lines(i).Split("=")(1) <> String.Empty Then 'null 값 체크
    '                    '이전에 값들 
    '                    Dim chkpreValues As String() = lines(i).Split("=")(1).Split(",")
    '                    For Each chkv In chkpreValues '중복 값 체크  True : 중복 False: 중복 X
    '                        If chkv = content Then
    '                            chkControl = True
    '                        End If
    '                    Next
    '                    '중복 검사 후에도 중복이 아니면
    '                    If chkControl <> True Then
    '                        lines(i) = $"{keyName}=" & lines(i).Split("=")(1) & "," & content
    '                        logger.log($"{keyName} 의 값이 Insert", "i")
    '                    Else
    '                        lines(i) = $"{keyName}=" & lines(i).Split("=")(1)
    '                    End If
    '                    Exit For
    '                Else
    '                    lines(i) = $"{keyName}=" & content
    '                    logger.log($"{keyName} 의 값이 Insert", "i")
    '                    Exit For
    '                End If
    '            End If
    '        Next
    '        File.WriteAllLines(settingFilePath, lines)
    '    Catch ex As Exception
    '        logger.log(ex.ToString, "w")
    '    End Try
    'End Sub
    '데이터 값을 추가해주는 함수
    Sub UPDATEDATA(content As String, keyName As String)
        Try
            ' Json 파일 읽기
            Dim jsonString As String = File.ReadAllText(settingFilePath)
            ' Json 데이터 파싱
            Dim jsonData As JObject = JObject.Parse(jsonString)

            '값을 추가할 배열 선택
            Dim pathArray As JArray = jsonData(keyName)("path")
            Dim check As Boolean = False
            If pathArray.Count <= 0 Then
                check = True
            Else
                For Each path In pathArray
                    If path = content Then
                        check = False
                        Exit For
                    Else
                        check = True
                    End If
                Next
            End If

            '이미 값이 있는지 없는지 체크
            If check = True Then
                pathArray.Add(content)
                ' 수정된 JSON 객체를 문자열로 변환
                Dim modifiedJsonString As String = jsonData.ToString()
                '수정된 JSON 문자열을 파일에 씀
                File.WriteAllText(settingFilePath, modifiedJsonString)
            End If


        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub
    'array 가 아닌 값 추가 
    Sub UPONEDATEDATA(content As String, keyName As String)
        Try
            ' Json 파일 읽기
            Dim jsonString As String = File.ReadAllText(settingFilePath)
            ' Json 데이터 파싱
            Dim jsonData As JObject = JObject.Parse(jsonString)
            jsonData(keyName)("path") = content
            ' 수정된 JSON 객체를 문자열로 변환
            Dim modifiedJsonString As String = jsonData.ToString()
            '수정된 JSON 문자열을 파일에 씀
            File.WriteAllText(settingFilePath, modifiedJsonString)
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub
    'ini 원하는 라인의 값에서 원하는 값을 삭제하는 함수
    'Sub REMOVEDATA(content, keyName)
    '    Try
    '        Dim lines As String() = File.ReadAllLines(settingFilePath)
    '        Dim line_result As String = String.Empty
    '        For i As Integer = 0 To lines.Length - 1
    '            If lines(i).Split("=")(0).StartsWith($"{keyName}") Then
    '                If lines(i).Split("=")(1) <> String.Empty Then 'null 값 체크
    '                    '값들을 하나씩 비교해서 체크된 항목만 배제
    '                    For Each value In lines(i).Split("=")(1).Split(",")
    '                        If value <> content Then
    '                            line_result += "," & value
    '                        End If
    '                    Next
    '                    'null 값 체크
    '                    If line_result <> String.Empty Then
    '                        lines(i) = $"{keyName}=" & line_result.Substring(1)
    '                    Else
    '                        lines(i) = $"{keyName}="
    '                    End If
    '                    Exit For
    '                Else
    '                    logger.log($"{keyName} 의 값이 null이기 때문에 삭제되지 않았습니다.", "w")
    '                    Exit For
    '                End If
    '            End If
    '        Next
    '        File.WriteAllLines(settingFilePath, lines)
    '        logger.log($"{keyName} 의 값이 Update", "i")
    '    Catch ex As Exception
    '        logger.log(ex.ToString, "w")
    '    End Try
    'End Sub
    'json 삭제
    Sub REMOVEDATA(content, keyName)
        Try
            Dim jsonString As String = File.ReadAllText(settingFilePath)
            Dim jsonData As JObject = JObject.Parse(jsonString)
            Dim pathArray As JArray = jsonData(keyName)("path")

            For i As Integer = pathArray.Count - 1 To 0 Step -1
                If pathArray(i).ToString() = content Then
                    pathArray.RemoveAt(i)
                End If
            Next
            File.WriteAllText(settingFilePath, jsonData.ToString())
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
