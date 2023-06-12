Imports DOITCBR.CheckExistenct
Imports DOITCBR.logger
Imports DOITCBR.NTBProcess
Public Class HardPDF
    Private background As Integer

    Dim filePath As String = String.Empty
    Dim folderPath As String = String.Empty

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "(*.txt)|*.txt|(*.spl)|*.spl"
            If ofd.ShowDialog() = DialogResult.OK Then
                filePath = ofd.FileName
                txtboxInput.Text = filePath
            End If
        End Using
    End Sub

    Private Sub btn_output_Click(sender As Object, e As EventArgs) Handles btn_output.Click
        Using ofd2 As New FolderBrowserDialog
            If ofd2.ShowDialog() = DialogResult.OK Then
                folderPath = ofd2.SelectedPath
                txtboxOutput.Text = folderPath
            End If
        End Using
    End Sub


    Private Sub HardPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pdfYesBtn.Checked = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If pdfYesBtn.Checked Then
            background = 1
        ElseIf pdfNoBtn.Checked Then
            background = -1
        End If
        Me.Enabled = False
        NTBProcess.CobraProcess(filePath, folderPath, background)
        Me.Enabled = True
    End Sub

    Private Sub txtboxInput_DragEnter(sender As Object, e As DragEventArgs) Handles txtboxInput.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub txtboxInput_DragDrop(sender As Object, e As DragEventArgs) Handles txtboxInput.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If filePaths.Length > 0 Then
                txtboxInput.Text = filePaths(0)
                filePath = filePaths(0)
            End If
        End If
        If e.Data.GetDataPresent(DataFormats.Text) Then
            Dim droppedText As String = CStr(e.Data.GetData(DataFormats.Text))
            txtboxInput.Text = droppedText
            filePath = droppedText
        End If
    End Sub
    Private Sub txtboxOutput_DragEnter(sender As Object, e As DragEventArgs) Handles txtboxOutput.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If

        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub txtboxOutput_DragDrop(sender As Object, e As DragEventArgs) Handles txtboxOutput.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If filePaths.Length > 0 Then
                txtboxOutput.Text = filePaths(0)
                folderPath = filePaths(0)
            End If

        End If

        If e.Data.GetDataPresent(DataFormats.Text) Then
            Dim droppedText As String = CStr(e.Data.GetData(DataFormats.Text))
            txtboxOutput.Text = droppedText
            folderPath = droppedText
        End If
    End Sub

End Class