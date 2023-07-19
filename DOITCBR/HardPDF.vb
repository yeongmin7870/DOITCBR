Imports DOITCBR.CheckExistenct
Imports DOITCBR.logger
Imports DOITCBR.NTBProcess
Imports System.IO
Imports Newtonsoft.Json.Linq
Public Class HardPDF
    'SelectForm 인스턴스 생성
    Dim filePath As String = String.Empty
    Dim folderPath As String = String.Empty

    'command format 결과'
    Dim rs As String = String.Empty
    '명령어
    Public cmd As String = String.Empty
    ''실행파일의 명령어
    'Public exe_cmd As New List(Of String)
    '작업 실행 exe
    Public exename As String = String.Empty
    'Output
    Public opt As String = String.Empty


    '현재 실행파일
    Public exe_path As String = String.Empty
    Public exe_command As New List(Of String)
    Public exe_file As New List(Of String)

    '업로드 파일 체크 여부 
    Dim chkBtn As Boolean = False
    'EXE 실행파일 명령어 체크 여부
    Dim CMDchk As Boolean = False

    'crtacvres format 예시
    Dim crtacvres_format As String = "예시) pcxmono pcxgray pcx16 pcx256 pcx24b pcxcmyk pbm pbmraw pgm pgmraw" &
                     "pgnm pgnmraw tiffcrle tiffg3 tiffg32d tiffg4 tifflzw tiffpack bmpmono" &
                     "bmpgray bmp16 bmp256 bmp16m tiff12nc tiff24nc psmono bit bitrgb bitcmyk" &
                     "pngmono pnggray png16 png256 png16m jpeg jpeggray pdfwrite epswrite"

    Dim output As String = crtacvres_format.Replace(" ", Environment.NewLine)
    Dim preCommandBoxText As String = String.Empty
    '이전에 입력했던 CRTACVRES FORMAT
    Dim preformat As String = String.Empty
    '입력
    Dim format As String = String.Empty
    '한번만 CRTACVRES FORMAT 입력하게하는 변수
    'Dim formatbool As Boolean = False

    'Input 박스로 마우스 드래그가 들어갈때
    Private Sub txtboxInput_DragEnter(sender As Object, e As DragEventArgs) Handles txtboxInput.DragEnter, txtInputLb.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    'input 박스에 내용물을 떨어뜨렸을때
    Private Sub txtboxInput_DragDrop(sender As Object, e As DragEventArgs) Handles txtboxInput.DragDrop, txtInputLb.DragDrop
        Try
            'inputbox 에 들어갈 값을 저장해둠
            Dim txtboxInput2 As String = String.Empty
            commandBox.Text = ""
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim filePaths As String() = e.Data.GetData(DataFormats.FileDrop)

                If filePaths.Length > 0 Then
                    For Each t In filePaths
                        If File.Exists(t) Then
                            txtboxInput2 += t & vbCrLf
                            filePath = t
                            errorValue = settingPath.UPDATEDATA(t, "putFiles", settingPath.settingFilePath)
                        End If
                    Next
                    txtboxInput.Text = txtboxInput2.Substring(0, txtboxInput2.Length - 1)
                End If
            End If
            If e.Data.GetDataPresent(DataFormats.Text) Then
                Dim droppedText As String = CType(e.Data.GetData(DataFormats.Text), String)
                'For Each t In droppedText
                'txtboxInput2 += t & ","
                filePath = droppedText
                errorValue = settingPath.UPDATEDATA(filePath, "putFiles", settingPath.settingFilePath)
                'Next
                '마지막 ',' 를 빼주기 위해서 
                'txtboxInput.Text = txtboxInput2.Substring(0, txtboxInput2.Length - 1)
                txtboxInput.Text = filePath
            End If
            Update_chkLst_putLst()
        Catch ex As Exception
            ErrorHandler($"{ex.Message & ex.StackTrace & ex.Source}", errorValue)
        End Try
    End Sub
    'Output textbox 안에 파일을 떨어뜨리는 함수
    Private Sub txtboxOutput2_DragEnter(sender As Object, e As DragEventArgs) Handles txtboxOutput2.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub txtboxOutput2_DragDrop(sender As Object, e As DragEventArgs) Handles txtboxOutput2.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
                If filePaths.Length > 0 Then
                    Dim drpath As String = chkFileAnsdFolder(filePaths(0))

                    txtboxOutput2.Text = drpath
                    folderPath = drpath
                    SelectForm.ListFilesAndFolders(drpath)
                    errorValue = UPONEDATEDATA(drpath, "txtOutput")
                End If
            End If
            If e.Data.GetDataPresent(DataFormats.Text) Then
                Dim droppedText As String = CStr(e.Data.GetData(DataFormats.Text))
                Dim drpath As String = chkFileAnsdFolder(droppedText)
                txtboxOutput2.Text = drpath
                folderPath = drpath
                SelectForm.ListFilesAndFolders(drpath)
                errorValue = UPONEDATEDATA(drpath, "txtOutput")
            End If
        Catch ex As Exception
            ErrorHandler($"{ex.Message & ex.StackTrace & ex.Source}", errorValue)
        End Try
    End Sub

    Private Sub txtboxOutput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxOutput2.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtboxOutput2.Text Is Nothing Or txtboxOutput2.Text = "" Then
                    txtboxOutput2.Text = GETValue("txtOutput")
                End If
                folderPath = txtboxOutput2.Text
                SelectForm.ListFilesAndFolders(folderPath)
                errorValue = UPONEDATEDATA(folderPath, "txtOutput")
            End If
        Catch ex As Exception
            ErrorHandler($"{ex.Message & ex.StackTrace & ex.Source}", errorValue)
        End Try
    End Sub
    '파일을 끌어오라는 문구가 나타나는 함수
    Sub DragAndDropLabel()
        If txtboxInput.Text <> String.Empty Then
            txtInputLb.Visible = False
        Else
            txtInputLb.Visible = True
        End If
    End Sub
    'input 에 파일을 넣었을때 output 경로가 자동으로 바뀌게 하는 함수
    Private Sub txtboxInput_TextChanged(sender As Object, e As EventArgs) Handles txtboxInput.TextChanged
        Try

            DragAndDropLabel()

            '빈값 이라면 
            If txtboxInput.Text.Trim IsNot String.Empty Then
                Dim outputPathlst As String() = txtboxInput.Text.Split(vbCrLf)
                folderPath = chkFileAnsdFolder2(outputPathlst(0))
                'input 값이 비어 있지 않다면
                If folderPath <> String.Empty Then
                    errorValue = UPONEDATEDATA(folderPath, "txtOutput")
                    txtboxOutput2.Text = folderPath
                Else
                    errorValue = UPONEDATEDATA(folderPath, "txtOutput")
                    txtboxOutput2.Text = ""
                End If
                SelectForm.ListFilesAndFolders(folderPath)
            End If

        Catch ex As Exception
            ErrorHandler($"{ex.Message & ex.StackTrace & ex.Source}", errorValue)
        End Try
    End Sub
    '올려놓은 파일 체크리스트 박스 업데이트 함수
    Function OpenOutputFolder()
        Try
            Dim path As String = GETValue("txtOutput")
            If Not String.IsNullOrEmpty(path) AndAlso Directory.Exists(path) Then
                Process.Start(path)
                Return 1
            Else
                PrintLog("HardPDF.vb, OpenOutputFolder() path가 null")
                Return -1
            End If
        Catch ex As Exception
            PrintLog($"{ex.Message & ex.StackTrace & ex.Source}")
            Return -1
        End Try
    End Function

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
        PanelRound(40, btn_selectAll)

        txtboxInput.Padding = New Padding(100)

        txtboxOutput2.Text = GETValue("txtOutput")
        Update_chkLst_putLst()
        Update_cbbox_workLst()
        Update_cbbox_workLst()

        'EXE ComboBox를 처음에 선택
        cbbox_workLst.SelectedIndex = 0
    End Sub

    'Component 4 모서리를 깎는 함수
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
            For Each file In chkLst_putFilelst.CheckedItems
                errorValue = settingPath.REMOVEDATA(file.split(vbTab)(1), "putFiles")
            Next
            Update_chkLst_putLst()
            commandBox.Text = ""

            '현재 실행파일
            exe_path = String.Empty
            exe_command = New List(Of String)
            exe_file = New List(Of String)

            '업로드 된 파일 목록 체크 풀기
            unChkSelectFile()
            CMDunChkSelectFile()
        Catch ex As Exception
            ErrorHandler($"{ex.Message & ex.StackTrace & ex.Source}", errorValue)
        End Try
    End Sub
    'Private Sub btn_delAllputFIle_Click(sender As Object, e As EventArgs) Handles btn_delAllputFIle.Click
    '    Try
    '        For Each file In chkLst_putFilelst.Items
    '            settingPath.REMOVEDATA(file, "putFiles")
    '        Next
    '        Update_chkLst_putLst()
    '        txtboxInput.Text = ""
    '    Catch ex As Exception
    '        ErrorHandler("HardPDF.vb btn_delAllputFIle_Click 삭제 실패", errorValue)
    '    End Try
    'End Sub

    '작업 리스트 갱신
    Sub Update_cbbox_workLst()
        cbbox_workLst.Items.Clear()
        For Each item In GETValue("cbrUtil")
            If item <> String.Empty Then
                Dim key As String() = item.ToString.Split("\\")
                cbbox_workLst.Items.Add(key(key.Count - 1))
            End If
        Next
    End Sub

    '올려놓은 파일 체크리스트
    Sub Update_chkLst_putLst()
        chkLst_putFilelst.Items.Clear()
        Dim jsonArray As JArray = GETValue("putFiles")
        For Each d In jsonArray
            If d <> String.Empty Then
                chkLst_putFilelst.Items.Add($"{Path.GetExtension(d)}{vbTab}{d}")
            End If
        Next
    End Sub

    'Private Sub cbbox_workLst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbox_workLst.SelectedIndexChanged
    '    SetExeSelectBox()
    '    exe_cmd = New List(Of String)
    '    FormatCommand(cbbox_workLst.SelectedItem, "e")
    'End Sub
    'Private Sub lst_commandBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_commandBox.SelectedIndexChanged
    '    FormatCommand(lst_commandBox.SelectedItem.split(" ")(0), "ec")
    'End Sub
    'str : 문자열
    'state 어디 문자열인지
    ' str, state 를 받아서 command를 만들어주는 함수
    'Sub FormatCommand(str, state)
    '    'Output 일때
    '    If state = "o" Then
    '        opt = $"{str}"
    '    ElseIf state = "e" Then '실행파일 이름
    '        Dim pathArray As JArray = GETValue("cbrUtil")
    '        For i = 0 To pathArray.Count - 1
    '            If pathArray(i).ToString().Split("\")(pathArray.Count) = str Then
    '                str = pathArray(i).ToString()
    '            End If
    '        Next
    '        exename = $"{str}"
    '    ElseIf state = "ec" Then ' 실행파일의 명령어
    '        If exe_cmd.IndexOf(str) < 0 Then ' 배열에 없음 -1 있음 -1 보다 큰 수
    '            exe_cmd.Add($"{str}")
    '        End If
    '    End If
    '    setCommandBox()
    'End Sub
    '현재 선택한 파일들
    Public checkFiles As List(Of String)
    Public i As Integer = 0
    'Sub setCommandBox()
    '    cmd = $"{exename} {String.Join(" ", exe_cmd)}"
    '    ' 명령어 임시 저장
    '    Dim cmd_result As String = String.Empty
    '    '선택한 파일 초기화
    '    checkFiles = New List(Of String)
    '    For Each f In chkLst_putFilelst.CheckedItems
    '        checkFiles.Add(f)
    '    Next

    '    'cmd에 아무값이 없으면 " " 값이 나옴 
    '    If cmd <> " " Then
    '        '체크한 파일이 1개 이상일때
    '        If checkFiles.Count > 1 Then
    '            For j = 0 To checkFiles.Count - 1
    '                cmd_result += " " & FormatCommand2(cmd)
    '                i += j
    '            Next
    '            commandBox.Text = cmd_result
    '        Else
    '            commandBox.Text = FormatCommand2(cmd)
    '        End If
    '    Else
    '        commandBox.Text = FormatCommand3(commandBox.Text)
    '    End If
    '    i = 0
    'End Sub
    '현재 command box에 존재 유무 체크
    'Sub GetCheckNowCMDBox()
    '    '임시 보관 리스트 변수
    '    Dim exe_cmd2 As New List(Of String)

    '    For Each cmd In exe_cmd 'cmd 명령어
    '        For Each cmdSTR In commandBox.Text.Split(" ")
    '            If cmdSTR = cmd Then
    '                exe_cmd2.Add(cmd)
    '            End If
    '        Next
    '    Next
    '    exe_cmd = exe_cmd2
    'End Sub
    'Private Sub commandBox_TextChanged(sender As Object, e As EventArgs) Handles commandBox.TextChanged
    '    GetCheckNowCMDBox()
    'End Sub
    'history에서 올린 파일을 선택할 때 기존 값에서 변경해주는 함수
    'CMD 에 아무값이 있을때
    'Function FormatCommand3(str As String)
    '    '입력받은 경로를 붙여줘야하는 명령어들
    '    Dim tt As New List(Of String) From {"-o", "-D", "-i", "-C"}
    '    rs = str
    '    For Each t In tt
    '        If t = "-o" Then
    '            If rs.IndexOf("-o") <> -1 Then
    '                '이전에 Command Box에 있던 경로 값
    '                Dim preopt2 As String = rs.Substring(rs.IndexOf("-o") + 2).Trim.Split(" ")(0)

    '                Dim opt2 As String = Path.ChangeExtension(opt, ".pdf")
    '                rs = rs.Replace(preopt2, opt2)
    '            End If
    '        End If

    '        If t = "-D" Then
    '            If rs.IndexOf("-D") <> -1 Then
    '                Dim prepath As String = rs.Substring(rs.IndexOf("-D") + 2).Trim.Split(" ")(0)
    '                rs = rs.Replace(prepath, txtboxOutput2.Text)
    '            End If
    '        End If

    '        If t = "-i" Then
    '            If rs.IndexOf("-i") <> -1 Then
    '                Dim preopt As String = rs.Substring(rs.IndexOf("-i") + 2).Trim.Split(" ")(0)
    '                rs = rs.Replace(preopt, chkLst_putFilelst.CheckedItems.ToString) 'check
    '            End If
    '        End If

    '        If t = "-C" Then
    '            If rs.IndexOf("-C") <> -1 Then
    '                Dim preopt As String = rs.Substring(rs.IndexOf("-C") + 2).Trim.Split(" ")(0)
    '                rs = rs.Replace(preopt, """PDFMODE Yes""")
    '            End If
    '        End If
    '    Next
    '    Return rs
    'End Function
    '문자열을 주면 문자열이 null 이면 0 아니면 문자 길이를 주는 함수
    Function chr_len(str As String) As Integer
        If str <> String.Empty Then
            Return 0
        Else
            Return str.Length
        End If
    End Function
    'CMD 에 아무값이 없을때
    'Function FormatCommand2(str As String)
    '    '입력받은 경로를 붙여줘야하는 명령어들
    '    Dim tt As New List(Of String) From {"-o", "-D", "-i", "-C"}
    '    rs = str
    '    For Each t In tt
    '        If t = "-o" Then
    '            If rs.IndexOf("-o") <> -1 Then
    '                Dim opt2 As String = Path.ChangeExtension(opt, ".pdf")
    '                rs = rs.Substring(0, rs.IndexOf("-o") + 2) & $" {opt2} " & rs.Substring(rs.IndexOf("-o") + 2)
    '            End If
    '        End If

    '        If t = "-D" Then
    '            If rs.IndexOf("-D") <> -1 Then
    '                rs = rs.Substring(0, rs.IndexOf("-D") + 2) & $" {txtboxOutput2.Text} " & rs.Substring(rs.IndexOf("-D") + +2)
    '            End If
    '        End If

    '        If t = "-i" Then
    '            If rs.IndexOf("-i") <> -1 Then
    '                rs = rs.Substring(0, rs.IndexOf("-i") + 2) & $" {checkFiles(i)} " & rs.Substring(rs.IndexOf("-i") + 2)
    '            End If
    '        End If

    '        If t = "-C" Then
    '            If rs.IndexOf("-C") <> -1 Then
    '                rs = rs.Substring(0, rs.IndexOf("-C") + 2) & $" {"""PDFMODE Yes"""} " & rs.Substring(rs.IndexOf("-C") + 2)
    '            End If
    '        End If
    '    Next
    '    Return rs
    'End Function

    Private Sub btn_cmdClear_Click(sender As Object, e As EventArgs) Handles btn_cmdClear.Click
        commandBox.Text = ""

        '현재 실행파일
        exe_path = cbbox_workLst.SelectedItem
        exe_command = New List(Of String)
        exe_file = New List(Of String)

        '업로드 된 파일 목록 체크 풀기
        unChkSelectFile()
        CMDunChkSelectFile()
    End Sub
    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        History.Show()
    End Sub
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Try
            If commandBox.Text <> String.Empty Then
                SetProcessAndLog(commandBox.Text)

                Else
                    PrintLog($"명령어가 공백")
            End If
        Catch ex As Exception
            ErrorHandler($"{ex.Message & ex.StackTrace & ex.Source}", errorValue)
        End Try
    End Sub
    'EXE Command와 로그를 찍는 함수
    Sub SetProcessAndLog(cmdText As String)
        Dim currentdt As DateTime = DateTime.Now

        Dim dates As String = $"{currentdt.Year}.{chkz(currentdt.Month)}.{chkz(currentdt.Day)} {chkz(currentdt.Hour)}:{chkz(currentdt.Minute)}:{chkz(currentdt.Second)}"
        Dim text As String = $"{commandBox.Text}"

        errorValue = NTBProcess.MultiProcessFn(commandBox.Text, Me)
        'Command History에 남김
        WriteLog(dates, text, GETValue("cmd"))
        sForm.ListFilesAndFolders(GETValue("txtOutput"))
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        errorValue = OpenOutputFolder()
        If errorValue = -1 Then
            ErrorHandler("HardPdf.vb Button2_Click 결과 폴더 비정상", errorValue)
        End If
    End Sub
    Private Sub txtInputLb_LostFocus(sender As Object, e As EventArgs) Handles txtInputLb.LostFocus
        txtInputLb.Visible = True
    End Sub
    Private Sub btn_selectAll_Click(sender As Object, e As EventArgs) Handles btn_selectAll.Click
        If chkBtn = False Then
            chkAllSelectFile()
            GenerateCommand()
        ElseIf chkBtn = True Then
            unChkSelectFile()
            GenerateCommand()
        End If
    End Sub
    '업로드된 파일 목록체크리스트 체크
    Sub chkAllSelectFile()
        chkBtn = True
        For i = 0 To chkLst_putFilelst.Items.Count - 1
            chkLst_putFilelst.SetItemChecked(i, True)
        Next
    End Sub
    '업로드된 파일 목록체크리스트 해제
    Sub unChkSelectFile()
        chkBtn = False
        For i = 0 To chkLst_putFilelst.Items.Count - 1
            chkLst_putFilelst.SetItemChecked(i, False)
        Next
    End Sub

    'EXE 명령어 목록체크리스트 체크
    Sub CMDchkAllSelectFile()
        CMDchk = True
        For i = 0 To lst_commandBox.Items.Count - 1
            lst_commandBox.SetItemChecked(i, True)
        Next
    End Sub
    'EXE 명령어 목록체크리스트 해제
    Sub CMDunChkSelectFile()
        CMDchk = False
        For i = 0 To lst_commandBox.Items.Count - 1
            lst_commandBox.SetItemChecked(i, False)
        Next
    End Sub

    '배열 값을 넣어주는 함수
    Sub SetValueLoop(values, s)
        Try
            If values IsNot Nothing Then
                For Each value In values
                    s(value) = 1
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub SetValue2(value, ByRef properT)
        Try
            If value IsNot Nothing Then
                properT = value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    ' EXE, EXE Command, File 의 변화를 감지해서 CMD 박스에 넣어주는 기능
    ' B
    Private Sub listCommandBox(sender As Object, e As ItemCheckEventArgs) Handles lst_commandBox.ItemCheck
        Dim checkedItem As String = lst_commandBox.Items(e.Index).ToString.Split(" ")(0).Trim
        If e.NewValue = CheckState.Checked Then
            If Not exe_command.Contains(checkedItem) Then
                exe_command.Add(checkedItem)
            End If
        Else
            If exe_command.Contains(checkedItem) Then
                exe_command.Remove(checkedItem)
            End If
        End If

        preformat = String.Empty
        'formatbool = False


        GenerateCommand()
    End Sub
    ' 파일 선택할때마다 input Box 변화하기
    'C
    Sub chkLst_putFilelst_SelectedIndexChange(sender As Object, e As ItemCheckEventArgs) Handles chkLst_putFilelst.ItemCheck

        Dim checkedItems As String() = chkLst_putFilelst.Items(e.Index).ToString.Split(vbTab)
        Dim checkedItem As String = String.Empty
        If checkedItems.Count <> 1 Then
            checkedItem = checkedItems(1)
        Else
            checkedItem = checkedItems(0)
        End If
        If e.NewValue = CheckState.Checked Then
            If Not exe_file.Contains(checkedItem) Then
                exe_file.Add(checkedItem)
            End If
        Else
            If exe_file.Contains(checkedItem) Then
                exe_file.Remove(checkedItem)
            End If
        End If
        'GenerateCommand()
    End Sub
    Sub chkLst_putFilelst_SelectedIndexChange(sender As Object, e As EventArgs) Handles chkLst_putFilelst.SelectedIndexChanged, chkLst_putFilelst.ItemCheck
        If chkLst_putFilelst.SelectedItem <> Nothing Then
            Dim intxt As String() = chkLst_putFilelst.SelectedItem.split(vbTab)
            If intxt.Count <> 1 Then
                txtboxInput.Text = intxt(1)
            Else
                txtboxInput.Text = intxt(0)
            End If
            txtboxOutput2.Text = chkFileAnsdFolder2(GETValue("txtOutput"))
            GenerateCommand()
        End If
    End Sub
    'lst_commandBox 리스트에 데이터 추가
    'A
    Sub SetExeSelectBox(sender As Object, e As EventArgs) Handles cbbox_workLst.SelectedIndexChanged
        lst_commandBox.Items.Clear()
        commandBox.Text = ""
        exe_path = String.Empty
        exe_command = New List(Of String)
        exe_file = New List(Of String)
        unChkSelectFile()

        '찾고자 하는 키
        Dim targetKey As String = "cbrUtilCmd"
        Dim jsonDT As Object = GETCMDVALUE(targetKey, cbbox_workLst.SelectedItem)
        For Each d In jsonDT.Properties()
            lst_commandBox.Items.Add($"{d.Name.Trim}        {d.Value}")
        Next
        SetValue2(cbbox_workLst.SelectedItem, exe_path)
    End Sub

    Sub GenerateCommand()
        Dim result As String = String.Empty
        Dim preResult As String = String.Empty
        Dim cntAnd As Integer = 0
        preCommandBoxText = commandBox.Text
        commandBox.Text = ""
        If exe_file.Count <> 0 Then
            For Each fp In exe_file
                For Each c In exe_command
                    If c = "-i" Then
                        result += " " + c + " " + fp
                    ElseIf c = "-o" Then
                        If exe_path.ToUpper = "CRTACVRES.EXE" Then
                            '이전에 이미 입력을 했었다면
                            If preformat <> String.Empty Then
                                result += " " + c + " " + ChangeFileExtension(fp, "." & preformat)
                            Else
                                If format <> String.Empty Then
                                    result += " " + c + " " + ChangeFileExtension(fp, "." & preformat)
                                Else
                                    format = InputBox(output)
                                    result += " " + c + " " + ChangeFileExtension(fp, "." & format)
                                End If
                                'formatbool = True
                                preformat = format
                            End If
                        Else
                            result += " " + c + " " + txtboxOutput2.Text
                        End If
                    ElseIf c = "-D" Then
                        If exe_path.ToUpper = "COBRADOC.EXE" Then
                            result += " " + c + " " + txtboxOutput2.Text
                        ElseIf exe_path.ToUpper = "CRTPDFC.EXE" Then
                            result += " " + c + " "
                        End If
                    ElseIf c = "-C" Then
                        If exe_path.ToUpper = "COBRADOC.EXE" Then
                            result += " " + c + " " + """PDFMODE Yes"""
                        Else
                            result += " " + c + " "
                        End If
                    Else
                        result += " " + c + " "
                    End If
                Next
                If cntAnd <> 0 Then
                    preResult += $" & {changeExePath(exe_path)} {result.Trim}"
                Else
                    preResult += $" {changeExePath(exe_path)} {result.Trim}"
                End If

                cntAnd += 1
                result = String.Empty
            Next
            commandBox.Text = preResult.Trim
        Else
            For Each c In exe_command
                result += " " + c
            Next
            commandBox.Text += $"{changeExePath(exe_path)} {result.Trim}"
        End If
    End Sub

    Function ChangeFileExtension(filePath As String, newExtension As String) As String
        Dim directoryPath As String = Path.GetDirectoryName(filePath)
        Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(filePath)
        Dim newFilePath As String = Path.Combine(directoryPath, $"{fileNameWithoutExtension}{newExtension}")
        Return newFilePath
    End Function
    Function changeExePath(n As String)
        For Each p In GETValue("cbrUtil")
            If p.ToString.IndexOf(n) <> -1 Then
                Return p.ToString
            End If
        Next
        Return n
    End Function

End Class