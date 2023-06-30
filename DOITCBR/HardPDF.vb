Imports DOITCBR.CheckExistenct
Imports DOITCBR.logger
Imports DOITCBR.NTBProcess
Imports System.IO
Imports System.Text

Public Class HardPDF
    'SelectForm 인스턴스 생성
    Dim filePath As String = String.Empty
    Dim folderPath As String = String.Empty

    'command format 결과'
    Dim rs As String = String.Empty
    '명령어
    Public cmd As String = String.Empty
    '실행파일의 명령어
    Public exe_cmd As New List(Of String)
    '작업 실행 exe
    Public exename As String = String.Empty
    'Output
    Public opt As String = String.Empty

    'Private Sub btn_input_Click(sender As Object, e As EventArgs)
    '    Try
    '        Using ofd As New OpenFileDialog
    '            ofd.Filter = "(*.txt)|*.txt|(*.spl)|*.spl"
    '            If ofd.ShowDialog() = DialogResult.OK Then
    '                filePath = ofd.FileName
    '                txtboxInput.Text = filePath
    '                settingPath.WriteIni(filePath, "putFiles")
    '            End If
    '            Settinginit()
    '            Update_chkLst_putLst()
    '        End Using
    '    Catch ex As Exception
    '        logger.log(ex.ToString, "w")
    '    End Try
    'End Sub

    'Private Sub btn_output_Click(sender As Object, e As EventArgs)
    '    Using ofd2 As New FolderBrowserDialog
    '        If ofd2.ShowDialog() = DialogResult.OK Then
    '            folderPath = ofd2.SelectedPath
    '            txtboxOutput.Text = folderPath
    '            SelectForm.ListFilesAndFolders(settingPath.data("txtOutput"))
    '            UpdateIni(folderPath, "txtOutput")
    '            SelectForm.ListFilesAndFolders(folderPath)
    '        End If
    '    End Using
    'End Sub


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
    Private Sub txtboxOutput_DragEnter(sender As Object, e As DragEventArgs) Handles txtboxOutput2.DragEnter
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

    Private Sub txtboxOutput_DragDrop(sender As Object, e As DragEventArgs) Handles txtboxOutput2.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
                If filePaths.Length > 0 Then
                    Dim drpath As String = chkFileAnsdFolder(filePaths(0))

                    txtboxOutput2.Text = drpath
                    folderPath = drpath
                    SelectForm.ListFilesAndFolders(drpath)
                    UpdateIni(drpath, "txtOutput")
                End If
            End If
            If e.Data.GetDataPresent(DataFormats.Text) Then
                Dim droppedText As String = CStr(e.Data.GetData(DataFormats.Text))
                Dim drpath As String = chkFileAnsdFolder(droppedText)
                txtboxOutput2.Text = drpath
                folderPath = drpath
                SelectForm.ListFilesAndFolders(drpath)
                UpdateIni(drpath, "txtOutput")
            End If
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub

    Private Sub txtboxOutput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxOutput2.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtboxOutput2.Text Is Nothing Or txtboxOutput2.Text = "" Then
                    txtboxOutput2.Text = settingPath.data("txtOutput")
                End If
                folderPath = txtboxOutput2.Text
                SelectForm.ListFilesAndFolders(folderPath)
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
    Sub OpenOutputFolder()
        Try
            Dim path As String = data("txtOutput")
            If Not String.IsNullOrEmpty(path) AndAlso Directory.Exists(path) Then
                Process.Start(path)
            Else
                MessageBox.Show("유효한 폴더 경로를 입력하세요.")
            End If
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub


    Private Sub HardPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelRound(40, txtInput_Pn)
        PanelRound(40, Panel2)
        PanelRound(40, Panel3)
        PanelRound(40, Panel4)
        PanelRound(40, Panel5)

        PanelRound(5, cbbox_workLst)
        PanelRound(40, btn_cmdClear)
        PanelRound(40, btn_history)
        PanelRound(40, btn_start)
        PanelRound(40, btn_putFileDelete)

        txtboxInput.Padding = New Padding(100)

        txtboxOutput2.Text = data("txtOutput")
        Update_chkLst_putLst()
        Update_cbbox_workLst()
        Update_cbbox_workLst()
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
    'lst_commandBox 리스트에 데이터 추가
    Sub SetExeSelectBox()
        lst_commandBox.Items.Clear()
        For Each d In data(cbbox_workLst.SelectedItem).Split(",")
            lst_commandBox.Items.Add(d)
        Next
    End Sub
    Private Sub cbbox_workLst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbox_workLst.SelectedIndexChanged
        SetExeSelectBox()
        exe_cmd = New List(Of String)
        FormatCommand(cbbox_workLst.SelectedItem, "e")
    End Sub
    Private Sub lst_commandBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_commandBox.SelectedIndexChanged
        FormatCommand(lst_commandBox.SelectedItem, "ec")
    End Sub
    'str : 문자열
    'state 어디 문자열인지
    ' str, state 를 받아서 command를 만들어주는 함수
    Sub FormatCommand(str, state)
        'Output 일때
        If state = "o" Then
            opt = $"{str}"
        ElseIf state = "e" Then '실행파일 이름
            For Each d In data("cbbox_workLst").Split(",")
                If d.IndexOf(str) > -1 Then
                    str = d
                End If
            Next
            exename = $"{str}"
        ElseIf state = "ec" Then ' 실행파일의 명령어
            If exe_cmd.IndexOf(str) < 0 Then ' 배열에 없음 -1 있음 -1 보다 큰 수
                exe_cmd.Add($"{str}")
            End If
        End If
        cmd = $"{exename} {String.Join(" ", exe_cmd)}"
        'cmd에 아무값이 없으면 " " 값이 나옴
        If cmd <> " " Then
            commandBox.Text = FormatCommand2(cmd)
        Else
            commandBox.Text = FormatCommand3(commandBox.Text)
        End If
    End Sub
    'history에서 올린 파일을 선택할 때 기존 값에서 변경해주는 함수
    Function FormatCommand3(str As String)
        '입력받은 경로를 붙여줘야하는 명령어들
        Dim tt As New List(Of String) From {"-o", "-D", "-i"}
        rs = str
        For Each t In tt
            If t = "-o" Then
                If rs.IndexOf("-o") <> -1 Then
                    '이전에 Command Box에 있던 경로 값
                    Dim preopt2 As String = rs.Substring(rs.IndexOf("-o") + 2).Trim.Split(" ")(0)

                    Dim opt2 As String = Path.ChangeExtension(opt, ".pdf")
                    rs = rs.Replace(preopt2, opt2)
                End If
            End If

            If t = "-D" Then
                If rs.IndexOf("-D") <> -1 Then
                    Dim prepath As String = rs.Substring(rs.IndexOf("-D") + 2).Trim.Split(" ")(0)
                    rs = rs.Replace(prepath, txtboxOutput2.Text)
                End If
            End If

            If t = "-i" Then
                If rs.IndexOf("-i") <> -1 Then
                    Dim preopt As String = rs.Substring(rs.IndexOf("-i") + 2).Trim.Split(" ")(0)
                    rs = rs.Replace(preopt, chkLst_putFilelst.SelectedItem)
                End If
            End If
        Next
        Return rs
    End Function
    '문자열을 주면 문자열이 null 이면 0 아니면 문자 길이를 주는 함수
    Function chr_len(str As String) As Integer
        If str <> String.Empty Then
            Return 0
        Else
            Return str.Length
        End If
    End Function
    'exe 파일 명령어 뒤에 경로를 붙이기 위함 함수
    Function FormatCommand2(str As String)
        '입력받은 경로를 붙여줘야하는 명령어들
        Dim tt As New List(Of String) From {"-o", "-D", "-i"}
        rs = str
        For Each t In tt
            If t = "-o" Then
                If rs.IndexOf("-o") <> -1 Then
                    Dim opt2 As String = Path.ChangeExtension(opt, ".pdf")
                    rs = rs.Substring(0, rs.IndexOf("-o") + 2) & $" {opt2} " & rs.Substring(rs.IndexOf("-o") + 2)
                End If
            End If

            If t = "-D" Then
                If rs.IndexOf("-D") <> -1 Then
                    rs = rs.Substring(0, rs.IndexOf("-D") + 2) & $" {txtboxOutput2.Text} " & rs.Substring(rs.IndexOf("-D") + +2)
                End If
            End If

            If t = "-i" Then
                If rs.IndexOf("-i") <> -1 Then
                    rs = rs.Substring(0, rs.IndexOf("-i") + 2) & $" {opt} " & rs.Substring(rs.IndexOf("-i") + 2)
                End If
            End If
        Next
        Return rs
    End Function
    Private Sub chkLst_putFilelst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkLst_putFilelst.SelectedIndexChanged
        FormatCommand(chkLst_putFilelst.SelectedItem, "o")
    End Sub
    Private Sub btn_cmdClear_Click(sender As Object, e As EventArgs) Handles btn_cmdClear.Click
        commandBox.Text = ""
    End Sub
    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        History.Show()
    End Sub
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Try
            If commandBox.Text <> String.Empty Then
                Dim currentdt As DateTime = DateTime.Now

                Dim exePath As String = commandBox.Text.Substring(0, commandBox.Text.IndexOf(" ")).Trim

                Dim argument As String = commandBox.Text.Substring(cmd.IndexOf(" ") + 1).Trim
                Dim text As String = $"[{currentdt.Year}.{chkz(currentdt.Month)}.{chkz(currentdt.Day)} {chkz(currentdt.Hour)}:{chkz(currentdt.Minute)}:{chkz(currentdt.Second)}][{exePath} {argument}]"

                NTBProcess.ProcessFn(exePath, argument)
                WriteLog(text, data("cmdPath"))
                logger.log(text, "i")
                sForm.ListFilesAndFolders(data("txtOutput"))
            Else
                MessageBox.Show("명령어가 공백입니다.")
            End If
        Catch ex As Exception
            logger.log(ex.ToString, "w")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Settinginit()
        OpenOutputFolder()
    End Sub
End Class