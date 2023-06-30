Imports System.IO
Imports System.Text
Module Module1


    Public Class subVariables
        Public message As String
        Private iniFilename As String = ""

        Public Sub New(inifile As String, jobcode As String)
            If File.Exists(inifile) Then
                iniFilename = inifile
                s_Jobcode = jobcode
                InitVariables()

            Else
                iniFilename = String.Empty
            End If

        End Sub

#Region "ini파일 읽는 함수"
        Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
           Alias "WritePrivateProfileStringW" (
               ByVal ipApplicationName As String,
               ByVal lpKeyName As String,
               ByVal lpString As String,
               ByVal lpFileName As String) As Int32

        Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
            Alias "GetPrivateProfileStringW" (
                ByVal ipApplicationName As String,
                ByVal lpKeyName As String,
                ByVal lpDefault As String,
                ByVal lpReturnString As String,
                ByVal nSize As Int32,
                ByVal lpFileName As String) As Int32


        Public Sub SetProfile(ByVal Section As String, ByVal ParamName As String, ByVal ParamValue As String, Optional ByVal addinifile As String = "")
            message = String.Empty

            Try
                If addinifile <> "" Then
                    iniFilename = addinifile
                End If

                Dim result As Integer = WritePrivateProfileString(Section, ParamName, ParamValue, iniFilename)
            Catch ex As Exception
                message = String.Format("sDM.ini에서 {0} 섹션 {1} 항목 갱신 중 오류가 발생했습니다.", Section, ParamName)
            End Try

        End Sub


        Public Function GetProfile(ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String, Optional ByVal addinifile As String = "") As String
            Dim result As String = String.Empty
            message = String.Empty

            Try
                If addinifile <> "" Then
                    iniFilename = addinifile
                End If

                Dim ParamValue As String = Space(192)
                Dim lenParamValue As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamValue, Len(ParamValue), iniFilename)
                result = Left(ParamValue, lenParamValue)

                If result = String.Empty Then
                    message = String.Format("ini 파일 {0} 항목 {1}이 없거나 설정되지 않았습니다.", Section, ParamName)
                End If

            Catch ex As Exception
                message = String.Format("ini에서 {0} 섹션 {1} 항목 조회 중 오류가 발생했습니다.", Section, ParamName)
            End Try

            Return result
        End Function

#End Region



#Region "사용할 변수 선언하기"
        Public ReadOnly CobraDoc As String = "Cobradoc.exe"
        Public ReadOnly CrtPdfc As String = "Crtpdfc.exe"
        Public ReadOnly CrtPdfLst As String = "CrtpdfLst.exe"

        Public ReadOnly CrtAcvRes As String = "CrtAcvRes.exe"

        Public ReadOnly CobraCob As String = "Cobracob.exe"
        Public ReadOnly CobraAfp As String = "Cobraafp.exe"




        Public m_SystemLog_Path As String
        Public m_SystemCbr_Path As String
        Public m_SystemImg_Path As String
        Public m_SystemDk_Path As String

        Public s_Jobcode As String
        Public s_JibpostYN As String
        Public s_Jobname As String
        Public s_Sortkey As New List(Of String)
        Public s_Duplex As String
        Public s_Dkjob As String
        Public s_Filemod As Integer
        Public s_Frstlineskip As String
        Public s_Bansong As String
        Public s_Feedback As String
        Public s_Pritntype As String
        Public s_Worktxt As New List(Of String)


        Public s_Fominfo As New Dictionary(Of String, String)
        Public s_Envinfo As New SortedDictionary(Of String, String)

#End Region
#Region "ini파일읽어서 저장하기"
        Private Sub InitVariables()

            m_SystemLog_Path = GetProfile("SYSTEM", "LOGPATH", "")
            m_SystemCbr_Path = GetProfile("SYSTEM", "CBRPATH", "")
            m_SystemImg_Path = GetProfile("SYSTEM", "IMGPATH", "")
            m_SystemDk_Path = GetProfile("SYSTEM", "DKPATH", "")

            s_Jobname = GetProfile(s_Jobcode, "JOBNAME", "")

            For i = 1 To 9
                Dim temp As String = String.Empty
                temp = GetProfile(s_Jobcode, "SORTKEY" & i, "")
                If temp <> "" Then
                    s_Sortkey.Add(temp)
                End If
            Next

            s_JibpostYN = GetProfile(s_Jobcode, "JIBPOSTYN", "")
            s_Filemod = Val(GetProfile(s_Jobcode, "FILEMOD", ""))
            s_Duplex = GetProfile(s_Jobcode, "DUPLEX", "")
            s_Dkjob = GetProfile(s_Jobcode, "DKJOB", "")
            s_Frstlineskip = GetProfile(s_Jobcode, "FRSTLINESKIP", "")
            s_Bansong = GetProfile(s_Jobcode, "BANSONG", "")
            s_Feedback = GetProfile(s_Jobcode, "FEEDBACK", "")
            s_Pritntype = GetProfile(s_Jobcode, "PRINTTYPE", "")

            Dim dictemp() As String = GetProfile(s_Jobcode, "JA_FOM", "").Split("|")
            For i = 0 To dictemp.Length - 1
                Dim temp() As String = dictemp(i).Split(",")
                s_Fominfo.Add(temp(0), temp(1))
            Next

            If GetProfile(s_Jobcode, "JA_FOM2", "") <> "" Then
                dictemp = GetProfile(s_Jobcode, "JA_FOM2", "").Split("|")
                For i = 0 To dictemp.Length - 1
                    Dim temp() As String = dictemp(i).Split(",")
                    s_Fominfo.Add(temp(0), temp(1))
                Next
            End If



            Dim bongtemp() As String = GetProfile(s_Jobcode, "JA_BONG", "").Split("|")

            Dim insu As Integer = 0
            For i = 0 To bongtemp.Length - 1
                Dim temp() As String = bongtemp(i).Split(",")

                If insu = 0 Then
                    insu = 1
                End If
                For j = insu To Val(temp(0))
                    s_Envinfo.Add(j, temp(1))
                Next
                insu = Val(temp(0)) + 1
            Next


            For i = 0 To 9
                Dim temp As String = String.Empty
                temp = GetProfile(s_Jobcode, "WORKORDERTXT" & i, "")
                If temp <> "" Then
                    s_Worktxt.Add(temp)
                End If
            Next



        End Sub

#End Region






    End Class

End Module
