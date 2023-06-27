Imports System.Security.Cryptography
Imports DOITCBR.logger
Imports System.IO
Public Class SelectForm
    Public preForm As Form
    Public staticPath As String = String.Empty
    Private Sub SelectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'ini 파일 초기화
            Settinginit()
            logger.loggerInit(settingPath.data("logPath"))
            OpenOutputFolder()
            HardForm()
            '파일 및 폴더 나열
            ListFilesAndFolders(settingPath.data("txtOutput"))
        Catch ex As Exception
            logger.log($"{ex}", "w")
        End Try
    End Sub
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
    Sub HardForm()
        If preForm IsNot Nothing AndAlso Not preForm.IsDisposed Then
            preForm.Close()
        End If
        PreFormFn(New HardPDF)
    End Sub
    '대용량 PDF 변환 버튼
    Private Sub btn_hard_Click(sender As Object, e As EventArgs) Handles btn_hard.Click
        HardForm()
    End Sub
    '일반용량 PDF 변환 버튼
    Private Sub btn_normal_Click(sender As Object, e As EventArgs)
        If preForm IsNot Nothing AndAlso Not preForm.IsDisposed Then
            preForm.Close()
        End If
        PreFormFn(New NormalPDF)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
    '폴더 경로를 주면 결과창이 업데이트 됨
    Sub ListFilesAndFolders(staticPath)
        Try
            folderList.Items.Clear()
            pathBox.Text = staticPath
            Dim items As New List(Of ListViewItem)
            Dim Files As String() = Directory.GetFiles(staticPath)
            For Each file As String In Files
                Dim fileInfo As New FileInfo(file)
                Dim item As New ListViewItem(fileInfo.Name)
                item.SubItems.Add("파일")
                item.Tag = file
                items.Add(item)
            Next
            Dim folders As String() = Directory.GetDirectories(staticPath)

            For Each folder As String In folders
                Dim folderInfo As New DirectoryInfo(folder)
                Dim item As New ListViewItem(folderInfo.Name)
                item.SubItems.Add("폴더")
                item.Tag = folder
                items.Add(item)
            Next
            folderList.Items.AddRange(items.ToArray())
        Catch ex As Exception
            logger.log(ex.ToString, "w")
            ListFilesAndFolders(data("txtOutput"))
        End Try
    End Sub

    Private Sub logMSG_TextChanged(sender As Object, e As EventArgs) Handles logMSG.TextChanged
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

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Settinginit()
        OpenOutputFolder()
    End Sub

    Private Sub pathBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pathBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If pathBox.Text Is Nothing Or pathBox.Text = "" Then
                pathBox.Text = settingPath.data("txtOutput")
            End If
            Dim path As String = pathBox.Text
            ListFilesAndFolders(path)
        End If
    End Sub

    Private Sub 환경설정ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 환경설정ToolStripMenuItem.Click
        NTBProcess.settingFile()
    End Sub

End Class
