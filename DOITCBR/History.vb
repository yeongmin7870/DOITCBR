Public Class History
    Private isDragging As Boolean = False
    Private mouseOffset As Point
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HistoryInit(Me, GETValue("cmd"))
        PanelRound(60, Me)
        PanelRound(10, historyNavbar)
        PanelRound(10, cmdHistory)
    End Sub

    Private Sub cmdHistory_DoubleClick(sender As Object, e As EventArgs) Handles cmdHistory.DoubleClick
        Dim hForm As HardPDF = TryCast(sForm.preForm, HardPDF)
        If hForm IsNot Nothing Then
            GetHistoryFormat(cmdHistory.SelectedItem.Trim, hForm)
            hForm.ApplyColorToText("&", Color.FromArgb(26, 28, 30))
        End If
        Me.Close()
    End Sub
    Sub GetHistoryFormat(h As String, hform As HardPDF)
        'history 명령어에 따라 체크리스트의 체크를 자동으로 해주는 함수 
        hform.historyAutoChecked_before()

        Dim rs As String = String.Empty
        rs = h.Split("]")(1).Split("[")(1).Trim
        Dim allCommand As String() = rs.Split("&")

        hform.exe_path = allCommand(0).Split(" ")(0)

        '초기화
        hform.exe_command = New List(Of String)
        hform.exe_file = New List(Of String)
        Dim str1 As String()

        'ex)  -i 파일경로 
        '     exe_command exe_file
        '     exe_command는 다음에 exe_file이 있을 수도 있고 없을 수도 있음
        'True 이어야 exe_file이 올 수 있음
        Dim nextExe_file As Boolean = False
        'exe_path 파일 경로의 따라서 명령어 개수가 틀려지기 때문에 2개 이상부터는 exe_path 만 받도록 함
        Dim path_count As Integer = 0
        For Each cm In allCommand
            str1 = cm.Trim.Split(" ")
            For Each s In str1 'command 넣고
                If s.Trim.Equals(hform.exe_path.Trim) Then
                    path_count += 1
                    If path_count > 1 Then
                        nextExe_file = True
                    End If
                Else
                    If s.IndexOf("-") <> -1 Then
                        If hform.exe_command.IndexOf(s) = -1 Then
                            hform.exe_command.Add(s)
                            If s.Equals("-D") Or s.Equals("-o") Then
                                nextExe_file = False
                            Else
                                nextExe_file = True
                            End If
                        Else
                            If s.Equals("-D") Or s.Equals("-o") Then
                                nextExe_file = False
                            Else
                                nextExe_file = True
                            End If
                        End If
                    ElseIf nextExe_file = True Then
                        If hform.exe_file.IndexOf(s) = -1 Then
                            hform.exe_file.Add(s)
                            If path_count <= 1 Then
                                nextExe_file = False
                            End If
                        End If
                    End If
                End If
            Next
        Next
        hform.GenerateCommand()
        hform.exe_file = New List(Of String)
    End Sub

    Private Sub lb_exit_Click(sender As Object, e As EventArgs) Handles lb_exit.Click
        Me.Close()
    End Sub
    Sub PanelRound(r, pn)
        Dim radius As Integer = r ' 원하는 모서리 깎기 정도를 조절합니다.
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90) ' 좌상단 모서리
        path.AddArc(pn.Width - radius, 0, radius, radius, 270, 90) ' 우상단 모서리
        path.AddArc(pn.Width - radius, pn.Height - radius, radius, radius, 0, 90) ' 우하단 모서리
        path.AddArc(0, pn.Height - radius, radius, radius, 90, 90) ' 좌하단 모서리
        path.CloseFigure()

        pn.Region = New Region(path)
    End Sub
    Private Sub historyNavbar_MouseDown(sender As Object, e As MouseEventArgs) Handles historyNavbar.MouseDown, Me.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub
    Private Sub historyNavbar_MouseMove(sender As Object, e As MouseEventArgs) Handles historyNavbar.MouseMove, Me.MouseMove
        If isDragging Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub historyNavbar_MouseUp(sender As Object, e As MouseEventArgs) Handles historyNavbar.MouseUp, Me.MouseUp
        isDragging = False
    End Sub
End Class