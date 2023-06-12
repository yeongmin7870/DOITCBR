Imports System.IO
Module CheckExistenct
    Function CheckFileExistenct(filePath As String) As Boolean
        If File.Exists(filePath) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function CheckFolderExistence(folderPath As String) As Boolean
        If Directory.Exists(folderPath) Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
