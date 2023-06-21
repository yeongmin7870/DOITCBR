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
                settingPath.WriteIni(filePath, "putFiles")
            End If
        End Using
    End Sub

    Private Sub btn_output_Click(sender As Object, e As EventArgs) Handles btn_output.Click
        Using ofd2 As New FolderBrowserDialog
            If ofd2.ShowDialog() = DialogResult.OK Then
                folderPath = ofd2.SelectedPath
                txtboxOutput.Text = folderPath
                selectForm.ListFilesAndFolders(settingPath.data("txtOutput"))
                UpdateIni(folderPath, "txtOutput")
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
                settingPath.WriteIni(filePaths(0), "putFiles")
                Update_chkLst_putFilelst()
            End If
        End If
        If e.Data.GetDataPresent(DataFormats.Text) Then
            Dim droppedText As String = CStr(e.Data.GetData(DataFormats.Text))
            txtboxInput.Text = droppedText
            filePath = droppedText
            settingPath.WriteIni(droppedText, "putFiles")
            Update_chkLst_putFilelst()
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
    'Private Sub txtboxOutput_DragDrop(sender As Object, e As DragEventArgs) Handles txtboxOutput.DragDrop
    '    If e.Data.GetDataPresent(DataFormats.FileDrop) Then

    '        Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

    '        If filePaths.Length > 0 Then
    '            txtboxOutput.Text = filePaths(0)
    '            folderPath = filePaths(0)
    '            selectForm.ListFilesAndFolders(filePaths(0))
    '        End If

    '    End If

    '    If e.Data.GetDataPresent(DataFormats.Text) Then
    '        Dim droppedText As String = CStr(e.Data.GetData(DataFormats.Text))
    '        txtboxOutput.Text = droppedText
    '        folderPath = droppedText
    '        selectForm.ListFilesAndFolders(droppedText)
    '    End If
    'End Sub

    Private Sub txtboxOutput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxOutput.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If txtboxOutput.Text Is Nothing Or txtboxOutput.Text = "" Then
                txtboxOutput.Text = settingPath.data("txtOutput")
            End If
            Dim path As String = txtboxOutput.Text
            folderPath = path
            selectForm.ListFilesAndFolders(folderPath)
            UpdateIni(folderPath, "txtOutput")
        End If
    End Sub

    'Private Sub txtboxInput_TextChanged(sender As Object, e As EventArgs) Handles txtboxInput.TextChanged
    '    Dim outputPathlst As String() = txtboxInput.Text.Split("\")
    '    Dim outputPath As String = String.Empty
    '    For i = 0 To outputPathlst.Length - 2
    '        If i = outputPathlst.Length - 2 Then
    '            outputPath += outputPathlst(i)
    '        Else
    '            outputPath += outputPathlst(i) + "\"
    '        End If

    '    Next
    '    selectForm.ListFilesAndFolders(outputPath)
    '    txtboxOutput.Text = outputPath
    '    folderPath = outputPath
    'End Sub
    '올려놓은 파일 체크리스트 박스 업데이트 함수
    Sub Update_chkLst_putFilelst()
        Settinginit()
        '출력 경로
        txtboxOutput.Text = settingPath.data("txtOutput")
        selectForm.ListFilesAndFolders(txtboxOutput.Text)
    End Sub

    Private Sub HardPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update_chkLst_putFilelst()
        Update_chkLst_putLst()
        Update_chkLst_worklst()
    End Sub

    Private Sub btn_putFileAllchk_Click(sender As Object, e As EventArgs) Handles btn_putFileAllchk.Click
        For i = 0 To chkLst_putFilelst.Items.Count - 1
            chkLst_putFilelst.SetItemChecked(i, True)
        Next
    End Sub
    Private Sub btn_putFileAlldechk_Click(sender As Object, e As EventArgs) Handles btn_putFileAlldechk.Click
        For i = 0 To chkLst_putFilelst.Items.Count - 1
            chkLst_putFilelst.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub btn_putFileDelete_Click(sender As Object, e As EventArgs) Handles btn_putFileDelete.Click
        If chkLst_putFilelst.CheckedItems.Count <> 0 Then
            For Each item In chkLst_putFilelst.CheckedItems
                settingPath.RemoveFileini(item, "putFiles")
            Next
        Else
            MessageBox.Show("아무것도 선택하지 않았습니다.")
            Exit Sub
        End If
        Update_chkLst_putFilelst()
    End Sub
    '작업 리스트 갱신
    Sub Update_chkLst_worklst()
        chkLst_worklst.Items.Clear()
        For Each item In settingPath.data("workList").Split(",")
            If item <> String.Empty Then
                chkLst_worklst.Items.Add(item)
            End If
        Next
    End Sub

    '올려놓은 파일 체크리스트
    Sub Update_chkLst_putLst()
        chkLst_putFilelst.Items.Clear()
        For Each d In data("putFiles").Split(",")
            If d <> String.Empty Then
                chkLst_putFilelst.Items.Add(d)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To chkLst_worklst.Items.Count - 1
            chkLst_worklst.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        For i = 0 To chkLst_worklst.Items.Count - 1
            chkLst_worklst.SetItemChecked(i, False)
        Next
    End Sub
End Class