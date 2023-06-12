Imports System.Windows.Forms
Imports System.Timers
Imports System
Imports System.IO
Imports System.Diagnostics
Imports System.Windows.Forms.AxHost

Module logger
    Public sForm As SelectForm = DirectCast(Application.OpenForms("SelectForm"), SelectForm)
    Public filePath As String = "D:\test.txt"

    Sub loggerInit()
        Using reader As New StreamReader(filePath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()


                'Dim state As String = String.Join(Environment.NewLine, line.Split("]")(1).Substring(1))
                Dim state As String = "h"
                AddColoredText(line, CheckedState(state), CheckedColor(CheckedState(state)))
            End While
        End Using

    End Sub

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
        End If
    End Function
    Sub log(log As String, state As String)
        Dim currentdt As DateTime = DateTime.Now
        Dim text As String = $"[{currentdt.Year}.{chkz(currentdt.Month)}.{chkz(currentdt.Day)} {chkz(currentdt.Hour)}:{chkz(currentdt.Minute)}:{chkz(currentdt.Second)}][{CheckedState(state)}][{log}]"
        WriteLog(text)
        AddColoredText(text, CheckedState(state), CheckedColor(CheckedState(state)))
    End Sub
    Function CheckedState(s As String) As String
        If s = String.Empty Then
            Return "상태표시를 잘확인해주세요"
        Else
            If s = "i" Or s = "I" Then
                Return "Info"
            ElseIf s = "w" Or s = "W" Then
                Return "Warn"
            ElseIf s = "e" Or s = "E" Then
                Return "Error"
            ElseIf s = "h" Or s = "H" Then
                Return "History"
            Else
                Return "상태표시를 잘확인해주세요"
            End If
        End If
    End Function
    Sub WriteLog(text)
        Using writer As StreamWriter = File.AppendText(filePath)
            writer.WriteLine(text)
        End Using
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
