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
            hForm.commandBox.Text = GetHistoryFormat(cmdHistory.SelectedItem.Trim)
            hForm.ApplyColorToText("&", Color.FromArgb(26, 28, 30))
        End If
        Me.Close()
    End Sub
    Function GetHistoryFormat(h As String)
        Dim rs As String = String.Empty
        rs = h.Split("]")(1).Split("[")(1).Trim
        Return rs
    End Function

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