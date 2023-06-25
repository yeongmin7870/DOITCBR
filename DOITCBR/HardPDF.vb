Imports DOITCBR.CheckExistenct
Imports DOITCBR.logger
Imports DOITCBR.NTBProcess
Imports System.IO
Public Class HardPDF
    'SelectForm 인스턴스 생성
    Dim selectForm As SelectForm = CType(Application.OpenForms("SelectForm"), SelectForm)
    Dim filePath As String = String.Empty
    Dim folderPath As String = String.Empty

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        Try
            Using ofd As New OpenFileDialog
                ofd.Filter = "(*.txt)|*.txt|(*.spl)|*.spl"
                If ofd.ShowDialog() = DialogResult.OK Then
                    filePath = ofd.FileName
                    txtboxInput.Text = filePath
                    settingPath.WriteIni(filePath, "putFiles")
                End If
                Settinginit()
                Update_chkLst_putLst()
            End Using
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
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
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.Copy
            End If
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = DragDropEffects.Copy
            End If
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub

    Private Sub txtboxInput_DragDrop(sender As Object, e As DragEventArgs) Handles txtboxInput.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
                If filePaths.Length > 0 Then
                    txtboxInput.Text = filePaths(0)
                    filePath = filePaths(0)
                    settingPath.WriteIni(filePaths(0), "putFiles")
                End If
            End If
            If e.Data.GetDataPresent(DataFormats.Text) Then
                Dim droppedText As String = CStr(e.Data.GetData(DataFormats.Text))
                txtboxInput.Text = droppedText
                filePath = droppedText
                settingPath.WriteIni(droppedText, "putFiles")
            End If
            Settinginit()
            Update_chkLst_putLst()
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub
    'Output textbox 안에 파일을 떨어뜨리는 함수
    Private Sub txtboxOutput_DragEnter(sender As Object, e As DragEventArgs) Handles txtboxOutput.DragEnter
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.Copy
            End If

            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = DragDropEffects.Copy
            End If
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub

    Private Sub txtboxOutput_DragDrop(sender As Object, e As DragEventArgs) Handles txtboxOutput.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
                If filePaths.Length > 0 Then
                    Dim drpath As String = chkFileAnsdFolder(filePaths(0))

                    txtboxOutput.Text = drpath
                    folderPath = drpath
                    selectForm.ListFilesAndFolders(drpath)
                    UpdateIni(drpath, "txtOutput")
                End If
            End If
            If e.Data.GetDataPresent(DataFormats.Text) Then
                Dim droppedText As String = CStr(e.Data.GetData(DataFormats.Text))
                Dim drpath As String = chkFileAnsdFolder(droppedText)
                txtboxOutput.Text = drpath
                folderPath = drpath
                selectForm.ListFilesAndFolders(drpath)
                UpdateIni(drpath, "txtOutput")
            End If
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub

    Private Sub txtboxOutput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxOutput.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtboxOutput.Text Is Nothing Or txtboxOutput.Text = "" Then
                    txtboxOutput.Text = settingPath.data("txtOutput")
                End If
                folderPath = txtboxOutput.Text
                selectForm.ListFilesAndFolders(folderPath)
                UpdateIni(folderPath, "txtOutput")
            End If
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
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



    Private Sub HardPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxOutput.Text = data("txtOutput")
        Update_chkLst_putLst()
        Update_cbbox_workLst()
    End Sub



    Private Sub btn_putFileDelete_Click(sender As Object, e As EventArgs) Handles btn_putFileDelete.Click
        Try
            settingPath.RemoveFileini(chkLst_putFilelst.SelectedItem, "putFiles")
            Settinginit()
            Update_chkLst_putLst()
            Exit Sub
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try

    End Sub
    '작업 리스트 갱신
    Sub Update_cbbox_workLst()
        cbbox_workLst.Items.Clear()
        For Each item In settingPath.data("cbbox_workLst").Split(",")
            If item <> String.Empty Then
                Dim name As String() = item.Split("\")
                cbbox_workLst.Items.Add(name(name.Count - 1))
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
        For i = 0 To lst_commandBox.Items.Count - 1
            lst_commandBox.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        For i = 0 To lst_commandBox.Items.Count - 1
            lst_commandBox.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub cbbox_workLst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbox_workLst.SelectedIndexChanged
        lst_commandBox.Items.Clear()
        For Each d In data(cbbox_workLst.SelectedItem).Split(",")
            lst_commandBox.Items.Add(d)
        Next
    End Sub

    Private Sub lst_commandBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_commandBox.SelectedIndexChanged
        Try
            Dim checkedCommand As String = String.Empty

            For Each item In lst_commandBox.CheckedItems
                checkedCommand += " " + item
            Next
            commandBox.Text = cbbox_workLst.Text & " " & chkLst_putFilelst.SelectedItem & checkedCommand
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub
End Class