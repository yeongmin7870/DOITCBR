Public Class History
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HistoryInit(Me, data("cmdPath"))
    End Sub

    Private Sub cmdHistory_DoubleClick(sender As Object, e As EventArgs) Handles cmdHistory.DoubleClick
        Dim hForm As HardPDF = TryCast(sForm.preForm, HardPDF)
        If hForm IsNot Nothing Then
            hForm.commandBox.Text = GetHistoryFormat(cmdHistory.SelectedItem.Trim)
        End If
        Me.Close()
    End Sub
    Function GetHistoryFormat(h As String)
        Dim rs As String = String.Empty
        rs = h.Split("]")(1).Split("[")(1).Trim
        Return rs
    End Function
End Class