Imports System.Windows.Forms
Imports System.Timers
Imports System
Imports System.IO
Imports System.Diagnostics
Imports System.Windows.Forms.AxHost
Imports Newtonsoft.Json.Linq

Module logger
    Public sForm As SelectForm = DirectCast(Application.OpenForms("SelectForm"), SelectForm)
    '에러 핸들러 변수 값
    ' 1: 정상 -1: 비정상
    Public errorValue As Integer = 1
    Function loggerInit(filePath As String)
        Try
            Dim jsonString As String = File.ReadAllText(filePath)
            Dim jsonData As JObject = JObject.Parse(jsonString)

            Dim logArray As JArray = jsonData("log")

            For Each logItem As JObject In logArray
                Dim time As String = logItem.Value(Of String)("time")
                Dim state As String = logItem.Value(Of String)("state")
                Dim content As String = logItem.Value(Of String)("content")

                AddColoredText($"[{time}][{state}][{content}]", CheckedState(state), CheckedColor(state))
            Next
            Return 1
        Catch ex As Exception
            PrintLog($"{ex.Message & ex.StackTrace & ex.Source}")
            Return -1
        End Try
    End Function
    '큰 흐름에서 오류가 났을때
    Sub ErrorHandler(str, chk)
        If chk = -1 Then
            logger.log($"{str}", "w")
            MessageBox.Show($"{str}")
        ElseIf chk = 1 Then
            logger.log($"{str}", "w")
        End If
    End Sub
    ' 로그와 메시지박스
    Sub PrintLog(str)
        logger.log($"{str}", "w")
        MessageBox.Show($"{str}")
    End Sub
    Function HistoryInit(hForm As History, filePath As String)
        Try
            Dim jsonString As String = File.ReadAllText(filePath)
            Dim jsonData As JObject = JObject.Parse(jsonString)

            Dim logArray As JArray = jsonData("history")
            If logArray IsNot Nothing Then
                For Each logItem As JObject In logArray.Reverse
                    Dim time As String = logItem.Value(Of String)("time")
                    Dim content As String = logItem.Value(Of String)("content")
                    hForm.cmdHistory.Items.Add($"[{time}][{content}]")
                Next
                Return 1
            Else
                Return -1
            End If
        Catch ex As Exception
            PrintLog($"{ex.Message & ex.StackTrace & ex.Source}")
            Return -1
        End Try
    End Function
    Sub AddColoredText(text As String, state As String, color As Color)
        sForm.logMSG.SelectionColor = color
        sForm.logMSG.AppendText(text & vbCrLf)
    End Sub
    Function CheckedColor(s As String) As Color
        If s = "Warn" Then
            Return Color.Red
        ElseIf s = "Info" Then
            Return Color.Green
        ElseIf s = "Error" Then
            Return Color.Gray
        Else
            Return Color.White
        End If
    End Function
    Sub log(log As String, state As String)
        Dim currentdt As DateTime = DateTime.Now
        Dim time As String = $"{currentdt.Year}.{chkz(currentdt.Month)}.{chkz(currentdt.Day)} {chkz(currentdt.Hour)}:{chkz(currentdt.Minute)}:{chkz(currentdt.Second)}"
        Dim states As String = $"{CheckedState(state)}"
        Dim text As String = $"{log}"
        '로그 쓰기
        WriteLog2(time, states, text, GETValue("log"))

        '로그 프론트에 색깔 입혀서 뿌리기
        AddColoredText($"[{time}][{states}][{text}]", CheckedState(state), CheckedColor(CheckedState(state)))
    End Sub
    Function CheckedState(s As String) As String
        If s = String.Empty Then
            Return "상태표시를 잘확인해주세요"
        Else
            If s = "i" Or s = "I" Or s = "Info" Then
                Return "Info"
            ElseIf s = "w" Or s = "W" Or s = "Warn" Then
                Return "Warn"
            ElseIf s = "e" Or s = "E" Or s = "Error" Then
                Return "Error"
            Else
                Return "상태표시를 잘확인해주세요"
            End If
        End If
    End Function
    Sub WriteLog2(time As String, state As String, text As String, filePath As String)
        Dim existingLog As String = File.ReadAllText(filePath)

        Dim jsonData As JObject = JObject.Parse(existingLog)

        Dim dataArray As JArray = jsonData("log")
        Dim data As New JObject()

        If dataArray Is Nothing Then
            dataArray = New JArray()
        End If

        data("time") = time
        data("state") = state
        data("content") = text

        dataArray.Add(data)

        jsonData("log") = dataArray

        Dim combinedLog As String = jsonData.ToString()
        File.WriteAllText(filePath, combinedLog)
    End Sub
    Sub WriteLog(time As String, text As String, filePath As String)
        Dim existingLog As String = File.ReadAllText(filePath)

        Dim jsonData As JObject = JObject.Parse(existingLog)

        Dim dataArray As JArray = jsonData("history")
        Dim data As New JObject()

        If dataArray Is Nothing Then
            dataArray = New JArray()
        End If
        data("time") = time
        data("content") = text

        dataArray.Add(data)

        jsonData("history") = dataArray

        Dim combinedLog As String = jsonData.ToString()
        File.WriteAllText(filePath, combinedLog)
    End Sub
    '일의 자리는 앞에 0을 붙여주는 함수
    Function chkz(text As Integer) As String
        If $"{text}".Length = 1 Then
            Return $"0{text}"
        Else
            Return $"{text}"
        End If
    End Function
End Module
