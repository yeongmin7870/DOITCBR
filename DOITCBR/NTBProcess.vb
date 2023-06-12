Imports System.IO

Module NTBProcess
    Sub CobraProcess(inputPath, outputPath, background)
        Try
            Dim filePath As String = "C:\cobra\COBRA2000\cobradoc.exe"
            Dim filePath2 As String = "C:\cobra\COBRA2000\crtpdfc.exe"

            Dim arguments As String = $"-i {inputPath} -D {outputPath} {Chkbackground(background)} -C ""PDFMODE YES"""
            Dim arguments2 As String = $"-i {ChgEtention(inputPath)}"
            ProcessFn(filePath, arguments)
            ProcessFn(filePath2, arguments2)
        Catch ex As Exception
            logger.log("NTBProcess 모듈파일에서 doc과 crtpdfc 실행과정에서 오류가 났습니다.", "w")
            logger.log(ex.Message, "w")
        End Try
    End Sub
    Function Chkbackground(background As Integer) As String
        If background = 1 Then
            Return "-J"
        ElseIf background = -1 Then
            Return ""
        Else
            Return ""
        End If
    End Function

    Sub ProcessFn(filepath, arguments)
        Dim process As New Process()
        process.StartInfo.FileName = filepath
        process.StartInfo.Arguments = arguments
        '결과를 읽기 위해 
        process.StartInfo.RedirectStandardOutput = True
        '출력을 읽기 위해
        process.StartInfo.UseShellExecute = False
        process.Start()
        '결과 읽기
        Dim output As String = process.StandardOutput.ReadToEnd()
        logger.log($"{output}", "i")
        process.WaitForExit()
    End Sub
    Function ChgEtention(pth)
        Dim newPath As String = Path.ChangeExtension(pth, ".dat")
        Return newPath
    End Function
End Module
