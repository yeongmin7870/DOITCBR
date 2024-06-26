﻿Imports System.IO

Module sortModule
    'ListBox Sort 하는 모듈
    Sub SortListBox(listBox, radioButton)
        ' Listbox의 항목을 저장할 리스트
        Dim itemsList As New List(Of String)

        ' Listbox의 모든 항목을 리스트로 복사
        For Each item As String In listBox.Items
            itemsList.Add(item)
        Next

        If radioButton.Equals("최신날짜") Then
            ' 날짜를 기준으로 정렬
            itemsList.Sort(Function(x, y) DateTime.Compare(GetFileDate(x.Split(vbTab)(1)), GetFileDate(y.Split(vbTab)(1))))
        ElseIf radioButton.Equals("확장자") Then
            ' 날짜를 기준으로 정렬
            itemsList.Sort(Function(x, y) String.Compare(IO.Path.GetExtension(x.Split(vbTab)(1)), IO.Path.GetExtension(y.Split(vbTab)(1))))
        End If

        itemsList.Reverse()

        ' Listbox의 항목을 비움
        listBox.Items.Clear()

        ' 정렬된 항목을 Listbox에 추가
        For Each item As String In itemsList
            listBox.Items.Add(item)
        Next
    End Sub

    Sub SortListView(listview, radioBtn)
        ' ListView의 항목을 저장할 List(Of ListViewItem)
        Dim itemsList As New List(Of ListViewItem)

        ' ListView의 모든 항목을 List로 복사
        For Each item As ListViewItem In listview.Items
            itemsList.Add(item)
        Next

        If radioBtn.Equals("최신날짜") Then
            '' 날짜를 기준으로 정렬 (오름차순)
            itemsList.Sort(Function(x, y) DateTime.Compare(GetFileDate(x.Tag), GetFileDate(y.Tag)))
        ElseIf radioBtn.Equals("확장자") Then
            '' 확장자를 기준으로 정렬
            itemsList.Sort(Function(x, y) String.Compare(IO.Path.GetExtension(x.Tag), IO.Path.GetExtension(y.Tag)))
        End If

        ' List를 뒤집어서 가장 최근 날짜가 위로 오도록 함
        itemsList.Reverse()

        ' ListView의 항목을 비움
        listview.Items.Clear()

        ' 정렬된 항목을 ListView에 추가
        For Each item As ListViewItem In itemsList
            Dim fileInfo As New FileInfo(item.Tag.ToString)
            item.Text = $"{Path.GetExtension(fileInfo.Name)}   {fileInfo.Name}"
            listview.Items.Add(item)
        Next
    End Sub

    ' 파일 경로로부터 파일의 생성 날짜를 가져오는 함수
    Public Function GetFileDate(filePath As String) As DateTime
        Dim fileInfo As New IO.FileInfo(filePath)
        Return fileInfo.LastWriteTime
    End Function
    Private Function GetListViewFileDate(filePath As String) As DateTime
        ' dateString을 DateTime 형식으로 변환하여 반환
        Dim dateValue As DateTime
        If DateTime.TryParse(filePath, dateValue) Then
            Return dateValue
        Else
            ' DateTime으로 변환할 수 없는 경우 기본값으로 DateTime.MinValue를 반환
            Return DateTime.MinValue
        End If
    End Function
End Module
