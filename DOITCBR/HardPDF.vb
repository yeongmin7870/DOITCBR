Imports DOITCBR.CheckExistenct
Imports DOITCBR.logger
Imports DOITCBR.NTBProcess
Public Class HardPDF
    Private background As Integer
    'SelectForm 인스턴스 생성
    Dim selectForm As SelectForm = CType(Application.OpenForms("SelectForm"), SelectForm)
    Dim filePath As String = String.Empty
    Dim folderPath As String = String.Empty

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "(*.txt)|*.txt|(*.spl)|*.spl"
            If ofd.ShowDialog() = DialogResult.OK Then
                filePath = ofd.FileName
                txtboxInput.Text = filePath
                txtboxOutput.Text = folderPath
            End If
        End Using
    End Sub

    Private Sub btn_output_Click(sender As Object, e As EventArgs) Handles btn_output.Click
        Using ofd2 As New FolderBrowserDialog
            If ofd2.ShowDialog() = DialogResult.OK Then
                folderPath = ofd2.SelectedPath
                txtboxOutput.Text = folderPath
                selectForm.ListFilesAndFolders(folderPath)
            End If
        End Using
    End Sub


    'Private Sub HardPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    pdfYesBtn.Checked = True
    'End Sub
    ''Cobradoc + CRTPDFC
    'Private Sub Button3_Click(sender As Object, e As EventArgs)

    '    If pdfYesBtn.Checked Then
    '        background = 1
    '    ElseIf pdfNoBtn.Checked Then
    '        background = -1
    '    End If
    '    Me.Enabled = False
    '    NTBProcess.CobraProcess(filePath, folderPath, background)
    '    Me.Enabled = True
    '    selectForm.ListFilesAndFolders(folderPath)
    'End Sub
    ''CRTPDFC 버튼
    'Private Sub btnCRTPDFC_Click(sender As Object, e As EventArgs)
    '    If pdfYesBtn.Checked Then
    '        background = 1
    '    ElseIf pdfNoBtn.Checked Then
    '        background = -1
    '    End If
    '    Me.Enabled = False
    '    NTBProcess.CRPDFC(filePath)
    '    Me.Enabled = True
    '    selectForm.ListFilesAndFolders(folderPath)
    'End Sub
    'cobradoc 버튼

    'Private Sub btn_doc_Click(sender As Object, e As EventArgs)
    '    If pdfYesBtn.Checked Then
    '        background = 1
    '    ElseIf pdfNoBtn.Checked Then
    '        background = -1
    '    End If
    '    Me.Enabled = False
    '    NTBProcess.CobraDoc(filePath, folderPath, background)
    '    Me.Enabled = True
    '    selectForm.ListFilesAndFolders(folderPath)
    'End Sub

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
    'Output textbox 안에 파일을 떨어뜨리는 함수
    'Private Sub txtboxOutput_DragEnter(sender As Object, e As DragEventArgs) Handles txtboxOutput.DragEnter
    '    If e.Data.GetDataPresent(DataFormats.FileDrop) Then
    '        e.Effect = DragDropEffects.Copy
    '    End If

    '    If e.Data.GetDataPresent(DataFormats.Text) Then
    '        e.Effect = DragDropEffects.Copy
    '    End If
    'End Sub
    Private Sub txtboxOutput_DragDrop(sender As Object, e As DragEventArgs) Handles txtboxOutput.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

            If filePaths.Length > 0 Then
                txtboxOutput.Text = filePaths(0)
                folderPath = filePaths(0)
                selectForm.ListFilesAndFolders(filePaths(0))
            End If

        End If

        If e.Data.GetDataPresent(DataFormats.Text) Then
            Dim droppedText As String = CStr(e.Data.GetData(DataFormats.Text))
            txtboxOutput.Text = droppedText
            folderPath = droppedText
            selectForm.ListFilesAndFolders(droppedText)
        End If
    End Sub

    Private Sub txtboxOutput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxOutput.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If txtboxOutput.Text Is Nothing Or txtboxOutput.Text = "" Then
                txtboxOutput.Text = "C:\"
            End If
            Dim path As String = txtboxOutput.Text
            folderPath = path

            selectForm.ListFilesAndFolders(folderPath)
        End If
    End Sub

    Private Sub txtboxInput_TextChanged(sender As Object, e As EventArgs) Handles txtboxInput.TextChanged
        Dim outputPathlst As String() = txtboxInput.Text.Split("\")
        Dim outputPath As String = String.Empty
        For i = 0 To outputPathlst.Length - 2
            If i = outputPathlst.Length - 2 Then
                outputPath += outputPathlst(i)
            Else
                outputPath += outputPathlst(i) + "\"
            End If

        Next
        selectForm.ListFilesAndFolders(outputPath)
        txtboxOutput.Text = outputPath
        folderPath = outputPath
    End Sub

End Class