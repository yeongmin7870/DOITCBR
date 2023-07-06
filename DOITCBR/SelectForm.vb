Imports System.Security.Cryptography
Imports DOITCBR.logger
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Security.Cryptography.X509Certificates
Imports DOITCBR.ListViewFolderIcon

Public Class SelectForm
    Inherits Form

    Public preForm As Form
    Public staticPath As String = String.Empty
    Private Const FILE_ATTRIBUTE_DIRECTORY As UInteger = &H10

    <DllImport("shell32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SHGetFileInfo(pszPath As String, dwFileAttributes As UInteger, ByRef psfi As SHFILEINFO, cbFileInfo As UInteger, uFlags As UInteger) As IntPtr
    End Function

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)>
    Private Structure SHFILEINFO
        Public hIcon As IntPtr
        Public iIcon As Integer
        Public dwAttributes As UInteger
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)>
        Public szTypeName As String
    End Structure

    Private Const SHGFI_ICON As UInteger = &H100
    Private Const SHGFI_SMALLICON As UInteger = &H1

    Private Sub SelectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            errorValue = Init()
            PanelRound(25, Panel5)
            errorValue = logger.loggerInit(GETValue("log"))
            HardForm()
            '파일 및 폴더 나열
            ListFilesAndFolders(GETValue("txtOutput"))
        Catch ex As Exception
            ErrorHandler($"{ex.Message & ex.StackTrace & ex.Source}", errorValue)
        End Try
    End Sub
    '탐색기 폴더 여는 함수
    Sub OpenOutputFolder()
        Dim path As String = GETValue("txtOutput")
        If Not String.IsNullOrEmpty(path) AndAlso Directory.Exists(path) Then
            Process.Start(path)
        Else
            PrintLog($"SelectFrom.vb OpenOutputFolder 유효하지 않은 폴더 경로")
        End If
    End Sub

    Sub HardForm()
        If preForm IsNot Nothing AndAlso Not preForm.IsDisposed Then
            preForm.Close()
        End If
        PreFormFn(New HardPDF)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If preForm IsNot Nothing AndAlso Not preForm.IsDisposed Then
            preForm.Close()
        End If
        PreFormFn(New InfoForm)
    End Sub


    Sub PreFormFn(newform)
        preForm = newform
        preForm.TopLevel = False

        preForm.Parent = Me
        preForm.Size = workDisplay.ClientSize

        preForm.Dock = DockStyle.Fill
        workDisplay.Controls.Add(preForm)
        preForm.Show()
    End Sub

    '파일과 폴더를 나눠서 아이콘 이미지를 가져옴
    Sub UpdateImageList(pth, state)
        Try
            Dim fileInfo As New SHFILEINFO()
            Dim flags As Integer = SHGFI_ICON Or SHGFI_SMALLICON
            Dim icon As Icon
            If state = "folder" Then
                SHGetFileInfo(pth, FILE_ATTRIBUTE_DIRECTORY, fileInfo, Marshal.SizeOf(fileInfo), flags)
                icon = Icon.FromHandle(fileInfo.hIcon)
            ElseIf state = "file" Then
                SHGetFileInfo(pth, 0, fileInfo, Marshal.SizeOf(fileInfo), flags)
                icon = Icon.FromHandle(fileInfo.hIcon)
            End If
            iconImgList.Images.Add(state, icon)
        Catch ex As Exception
            PrintLog($"{ex.Message & ex.StackTrace & ex.Source}")
        End Try
    End Sub
    Dim fileIconIndex As Integer = 0

    '폴더 경로를 주면 결과창이 업데이트 됨
    Sub ListFilesAndFolders(staticPath)
        Try
            If staticPath <> String.Empty Then
                Dim imageList As New ImageList()

                folderList.Items.Clear()
                pathBox.Text = staticPath
                Dim items As New List(Of ListViewItem)
                Dim files As String() = Directory.GetFiles(staticPath)
                For Each file As String In files
                    Dim fileInfo As New FileInfo(file)
                    Dim item As New ListViewItem(fileInfo.Name)
                    item.SubItems.Add("파일")
                    item.Tag = file
                    UpdateImageList(file, "file")
                    item.ImageIndex = fileIconIndex
                    items.Add(item)
                    fileIconIndex += 1
                Next
                Dim folders As String() = Directory.GetDirectories(staticPath)

                For Each folder As String In folders
                    Dim folderInfo As New DirectoryInfo(folder)
                    Dim item As New ListViewItem(folderInfo.Name)
                    item.SubItems.Add("폴더")
                    UpdateImageList(folder, "folder")
                    item.ImageIndex = fileIconIndex
                    item.Tag = folder
                    items.Add(item)
                    fileIconIndex += 1
                Next
                folderList.SmallImageList = iconImgList
                folderList.Items.AddRange(items.ToArray())
            End If
        Catch ex As Exception
            PrintLog($"{ex.Message & ex.StackTrace & ex.Source}")
            '오류가 나면 기본 세팅 Output 경로를 찾음
            ListFilesAndFolders(GETValue("txtOutput"))
        End Try
    End Sub

    Private Sub logMSG_TextChanged(sender As Object, e As EventArgs)
        ScrollToBottom(logMSG)
    End Sub
    Sub ScrollToBottom(txtBox As RichTextBox)
        txtBox.SelectionStart = txtBox.Text.Length
        txtBox.SelectionLength = 0
        txtBox.ScrollToCaret()
    End Sub

    Private Sub folderList_MouseDown(sender As Object, e As MouseEventArgs) Handles folderList.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim seletedItem As ListViewItem = folderList.GetItemAt(e.X, e.Y)
            If seletedItem IsNot Nothing Then
                Dim path As String = CStr(seletedItem.Tag)
                folderList.DoDragDrop(path, DragDropEffects.Copy)
            End If
        End If
    End Sub

    Sub folderList_DoubleClick(sender As Object, e As EventArgs) Handles folderList.DoubleClick
        Try
            If folderList.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = folderList.SelectedItems(0)
                Dim path As String = CStr(selectedItem.Tag)
                staticPath = path
                If selectedItem.SubItems(1).Text = "파일" Then
                    Process.Start(staticPath)
                End If
            End If
        Catch ex As Exception
            PrintLog($"{ex.Message & ex.StackTrace & ex.Source}")
        End Try
    End Sub


    Private Sub pathBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            If pathBox.Text Is Nothing Or pathBox.Text = "" Then
                pathBox.Text = GETValue("txtOutput")
            End If
            Dim path As String = pathBox.Text
            ListFilesAndFolders(path)
        End If
    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click
        errorValue = NTBProcess.settingFile()
        If errorValue = -1 Then
            ErrorHandler("SelectForm.vb ToolStripDropDownButton1_Click DOITCBR.json 없는 경로", errorValue)
        End If
    End Sub


    ' 이동 가능한 폼을 구현하기 위한 Win32 API 함수를 가져옵니다.
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    'Form 마우스로 잡으면 움직이는 함수
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, &H112, &HF012, 0)
        End If
    End Sub
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        RadiusFormBorder()
    End Sub
    '폼 모서리 깎기
    Sub RadiusFormBorder()
        '폼모서리를 둥글게 깎기 위한 영역 생성
        Dim roundedRect As New Rectangle(0, 0, Width, Height)
        Dim path As New GraphicsPath()
        '모서리를 깎기 정도
        Dim cornerRadius As Integer = 90
        path.AddArc(roundedRect.X, roundedRect.Y, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(roundedRect.Right - cornerRadius, roundedRect.Y, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(roundedRect.Right - cornerRadius, roundedRect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(roundedRect.X, roundedRect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90)
        path.CloseAllFigures()

        '폼의 영역을 지정한 영역으로 설정하여 모서리를 둥글게 깎음
        Region = New Region(path)
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

    Private isDragging As Boolean = False
    Private mouseOffset As Point
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        PanelRound(60, Panel1)
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If isDragging Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        isDragging = False
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles workDisplay.Paint
        PanelRound(60, workDisplay)
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        PanelRound(60, Panel3)
    End Sub
    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        PanelRound(60, Panel4)
    End Sub
    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        PanelRound(25, Panel5)
    End Sub
    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click, Label1.Click, Label2.Click
        Process.Start("http://ntbkorea01.cafe24.com/wp/")
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles btn_hard.Click, btn_hard_lb.Click, Label7.Click
        HardForm()
    End Sub

    Private Sub lb_exit_Click(sender As Object, e As EventArgs) Handles lb_exit.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Panel7.Click
        Dim textfile As String = "C:\Windows\System32\notepad.exe"
        ProcessFn(textfile, GETValue("log"))
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, Panel8.Click
        Dim textfile As String = "C:\Windows\System32\notepad.exe"
        ProcessFn(textfile, GETValue("cmd"))
    End Sub
End Class
