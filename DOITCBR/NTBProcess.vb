Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify

Module NTBProcess
    Public resultState As String = String.Empty
    '고속 Cobradoc
    Sub CobraDoc(inputPath, outputPath, background)
        Try
            Dim filePath As String = "C:\cobra\COBRA2000\cobradoc.exe"
            Dim arguments As String = $"-i {inputPath} -D {outputPath} {Chkbackground(background)} -C ""PDFMODE YES"""
            ProcessFn(filePath, arguments)
            logger.log("CRTPDFC Cobradoc 성공적으로 실행 완료", "i")
        Catch ex As Exception
            logger.log("NTBProcess 모듈파일에서 doc 실행과정에서 오류가 났습니다.", "w")
            logger.log(ex.Message, "w")
        End Try
    End Sub
    '일반 Cobradoc
    Sub CobraDoc2(inputPath, outputPath, background)
        Try
            Dim filePath As String = "C:\cobra\COBRA2000\cobradoc.exe"
            Dim arguments As String = $"-i {inputPath} -D {outputPath} {Chkbackground(background)}"
            ProcessFn(filePath, arguments)
            logger.log("CRTAVRES Cobradoc 성공적으로 실행 완료", "i")
        Catch ex As Exception
            logger.log("NTBProcess 모듈파일에서 doc 실행과정에서 오류가 났습니다.", "w")
            logger.log(ex.Message, "w")
        End Try
    End Sub
    'CRTAVRES
    Sub CRTAVRES(inputPath)
        Try
            Dim filePath2 As String = "C:\cobra\COBRA2000\CRTACVRES.exe"
            Dim arguments2 As String = $"-i {ChgEtention(inputPath, "dat")} -o {ChgEtention(inputPath, "pdf")} -O pdfwrite"
            ProcessFn(filePath2, arguments2)
            logger.log("CRTAVRES 성공적으로 실행 완료", "i")
        Catch ex As Exception
            logger.log("NTBProcess 모듈파일에서 doc과 crtpdfc 실행과정에서 오류가 났습니다.", "w")
            logger.log(ex.Message, "w")
        End Try
    End Sub
    'CRPDFC
    Sub CRPDFC(inputPath)
        Try
            Dim filePath2 As String = "C:\cobra\COBRA2000\crtpdfc.exe"
            Dim arguments2 As String = $"-i {ChgEtention(inputPath, "dat")}"
            ProcessFn(filePath2, arguments2)
            logger.log("CRPDFC 성공적으로 실행 완료", "i")
        Catch ex As Exception
            logger.log("NTBProcess 모듈파일에서 doc과 crtpdfc 실행과정에서 오류가 났습니다.", "w")
            logger.log(ex.Message, "w")
        End Try
    End Sub
    Function settingFile()
        Try
            Dim filePath2 As String = "C:\Windows\System32\notepad.exe"
            Dim arguments2 As String = $"{settingPath.settingFilePath}"
            ProcessFn(filePath2, arguments2)
            Return 1
        Catch ex As Exception
            PrintLog($"NTBProcess.vb settingFile 경로 이상")
            Return -1
        End Try
    End Function
    'Cobradoc + CRPDFC
    Sub CobraProcess(inputPath, outputPath, background)
        Try
            Dim filePath As String = "C:\cobra\COBRA2000\cobradoc.exe"
            Dim filePath2 As String = "C:\cobra\COBRA2000\crtpdfc.exe"

            Dim arguments As String = $"-i {inputPath} -D {outputPath} {Chkbackground(background)} -C ""PDFMODE YES"""
            Dim arguments2 As String = $"-i {ChgEtention(inputPath, "dat")}"
            ProcessFn(filePath, arguments)
            ProcessFn(filePath2, arguments2)
        Catch ex As Exception
            logger.log("NTBProcess 모듈파일에서 doc과 crtpdfc 실행과정에서 오류가 났습니다.", "w")
            logger.log(ex.Message, "w")
        End Try
    End Sub
    'Cobradoc + CRPDFC
    Sub CobraProcess2(inputPath, outputPath, background)
        Try
            CobraDoc2(inputPath, outputPath, background)
            CRTAVRES(inputPath)
        Catch ex As Exception
            logger.log("NTBProcess 모듈파일에서 doc과 CRPDFC 실행과정에서 오류가 났습니다.", "w")
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

    Function ProcessFn(filepath, arguments)
        Try
            Dim process As New Process()
            process.StartInfo.FileName = filepath
            process.StartInfo.Arguments = arguments
            '오류를 출력
            process.StartInfo.RedirectStandardError = True
            '결과를 읽기 위해 
            process.StartInfo.RedirectStandardOutput = True
            '출력을 읽기 위해
            process.StartInfo.UseShellExecute = False
            process.Start()
            process.WaitForExit()

            '결과 읽기
            resultState = process.StandardOutput.ReadToEnd()
            Dim errorState = process.StandardError.ReadToEnd()
            If resultState <> String.Empty Then
                logger.log(resultState, "i")
                MessageBox.Show("작업완료")
            End If
            If errorState <> String.Empty Then
                logger.log(errorState, "w")
                MessageBox.Show("작업실패")
            End If
            Return 1
        Catch ex As Exception
            PrintLog($"{ex.Message & ex.StackTrace & ex.Source}")
            Return -1
        End Try
    End Function
    '여러명령줄을 실행하기 위한 함수
    Function MultiProcessFn(cmd As String, ByVal formInstance As HardPDF)
        Try
            '작업전의 해당 경로에 있는 모든 파일 리스트
            Dim prefiles As String() = Directory.GetFiles(GETValue("txtOutput"))


            Dim exeSplit As String() = cmd.Split("&")
            Dim exe_path As New List(Of String)()
            Dim exe_cmd As New List(Of String)()

            For Each cmdPart In exeSplit
                Dim exe_path_ As String = cmdPart.Trim.Split(" ")(0)
                Dim exe_cmd_ As String = cmdPart.Trim.Substring(cmdPart.Trim.IndexOf(" "))

                exe_path.Add(exe_path_)
                exe_cmd.Add(exe_cmd_)
            Next

            For i = 0 To exe_path.Count - 1
                Dim process As New Process()
                process.StartInfo.FileName = exe_path(i)
                process.StartInfo.Arguments = exe_cmd(i)
                '오류를 출력
                process.StartInfo.RedirectStandardError = True
                '결과를 읽기 위해 
                process.StartInfo.RedirectStandardOutput = True
                '출력을 읽기 위해
                process.StartInfo.UseShellExecute = False
                process.Start()
                process.WaitForExit()

                '결과 읽기
                resultState = process.StandardOutput.ReadToEnd()
                Dim errorState = process.StandardError.ReadToEnd()

                logger.log(resultState, "i")
            Next

            '작업후의 해당 경로에 있는 모든 파일 리스트
            Dim nowfiles As New List(Of String)(Directory.GetFiles(GETValue("txtOutput")))
            '작업 결과 파일들
            Dim workfiles As New List(Of String)(nowfiles)
            For Each nf In nowfiles
                For Each pref In prefiles
                    If nf = pref Then
                        workfiles.Remove(nf)
                    End If
                Next
            Next
            'hardpdf에 있는 작업 업로드 파일 추가 작업  
            For Each item In workfiles
                formInstance.chkLst_putFilelst.Items.Add($"{Path.GetExtension(item)}{vbTab}{item}")
                settingPath.UPDATEDATA(item, "putFiles", settingPath.settingFilePath)
            Next

            Return 1
        Catch ex As Exception
            PrintLog($"{ex.Message & ex.StackTrace & ex.Source}")
            Return -1
        End Try
    End Function
    Function ChgEtention(pth, slct)
        Dim newPath As String = String.Empty
        If slct = "dat" Then
            newPath = Path.ChangeExtension(pth, ".dat")
            Return newPath
        ElseIf slct = "pdf" Then
            newPath = Path.ChangeExtension(pth, ".pdf")
            Return newPath
        Else
            newPath = Path.ChangeExtension(pth, ".dat")
            Return newPath
        End If
    End Function
End Module
