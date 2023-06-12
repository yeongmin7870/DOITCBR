<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gp_info = New System.Windows.Forms.GroupBox()
        Me.infoFont = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gp_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.gp_info)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'gp_info
        '
        Me.gp_info.Controls.Add(Me.infoFont)
        Me.gp_info.Location = New System.Drawing.Point(3, 3)
        Me.gp_info.Name = "gp_info"
        Me.gp_info.Size = New System.Drawing.Size(794, 444)
        Me.gp_info.TabIndex = 7
        Me.gp_info.TabStop = False
        Me.gp_info.Text = "사용설명서"
        '
        'infoFont
        '
        Me.infoFont.AutoSize = True
        Me.infoFont.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoFont.ForeColor = System.Drawing.Color.Black
        Me.infoFont.Location = New System.Drawing.Point(6, 17)
        Me.infoFont.Name = "infoFont"
        Me.infoFont.Size = New System.Drawing.Size(491, 320)
        Me.infoFont.TabIndex = 7
        Me.infoFont.Text = "필요 조건" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  1. Data 파일 ( txt, spl etc... ) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  2. CBR 파일 (배경이미지 GB 로 세팅할 것)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  3. 배경" &
    "이미지 파일 ( JPG etc... )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "대용량 PDF 변환" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Data -> Ps Data, Lst Data -> PDF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "일반용량 " &
    "PDF 변환" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Data -> Ps Data -> PDF"
        '
        'InfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InfoForm"
        Me.Text = "InfoForm"
        Me.Panel1.ResumeLayout(False)
        Me.gp_info.ResumeLayout(False)
        Me.gp_info.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents gp_info As GroupBox
    Friend WithEvents infoFont As Label
End Class
