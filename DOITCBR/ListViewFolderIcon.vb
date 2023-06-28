Imports System.Runtime.InteropServices
'List view 에서 file 과 folder icon을 가져올때 
Module ListViewFolderIcon
    <DllImport("shell32.dll")>
    Public Function SHGetFileInfo(ByVal pszPath As String, ByVal dwFileAttributes As Integer, ByRef psfi As SHFILEINFO, ByVal cbSizeFileInfo As Integer, ByVal uFlags As Integer) As IntPtr
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure SHFILEINFO
        Public hIcon As IntPtr
        Public iIcon As Integer
        Public dwAttributes As Integer
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)>
        Public szTypeName As String
    End Structure

    Public Const SHGFI_ICON As Integer = &H100
    Public Const SHGFI_SMALLICON As Integer = &H1
    Public Const SHGFI_LARGEICON As Integer = &H0
End Module
