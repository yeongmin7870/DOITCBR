<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NormalPDF
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pdfNoBtn = New System.Windows.Forms.RadioButton()
        Me.pdfYesBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCRTACVRES = New System.Windows.Forms.Button()
        Me.btn_doc = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gb_path = New System.Windows.Forms.GroupBox()
        Me.btn_output = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxOutput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxInput = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gb_path.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pdfNoBtn)
        Me.GroupBox2.Controls.Add(Me.pdfYesBtn)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(5, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(815, 57)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PDF 배경이미지"
        '
        'pdfNoBtn
        '
        Me.pdfNoBtn.AutoSize = True
        Me.pdfNoBtn.Font = New System.Drawing.Font("굴림", 18.0!)
        Me.pdfNoBtn.Location = New System.Drawing.Point(396, 20)
        Me.pdfNoBtn.Name = "pdfNoBtn"
        Me.pdfNoBtn.Size = New System.Drawing.Size(43, 28)
        Me.pdfNoBtn.TabIndex = 1
        Me.pdfNoBtn.TabStop = True
        Me.pdfNoBtn.Text = "X"
        Me.pdfNoBtn.UseVisualStyleBackColor = True
        '
        'pdfYesBtn
        '
        Me.pdfYesBtn.AutoSize = True
        Me.pdfYesBtn.Font = New System.Drawing.Font("굴림", 18.0!)
        Me.pdfYesBtn.Location = New System.Drawing.Point(345, 20)
        Me.pdfYesBtn.Name = "pdfYesBtn"
        Me.pdfYesBtn.Size = New System.Drawing.Size(45, 28)
        Me.pdfYesBtn.TabIndex = 0
        Me.pdfYesBtn.TabStop = True
        Me.pdfYesBtn.Text = "O"
        Me.pdfYesBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCRTACVRES)
        Me.GroupBox1.Controls.Add(Me.btn_doc)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(5, 281)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(815, 250)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "작업"
        '
        'btnCRTACVRES
        '
        Me.btnCRTACVRES.Font = New System.Drawing.Font("굴림", 15.0!)
        Me.btnCRTACVRES.Location = New System.Drawing.Point(3, 105)
        Me.btnCRTACVRES.Name = "btnCRTACVRES"
        Me.btnCRTACVRES.Size = New System.Drawing.Size(806, 59)
        Me.btnCRTACVRES.TabIndex = 2
        Me.btnCRTACVRES.Text = "CRTACVRES"
        Me.btnCRTACVRES.UseVisualStyleBackColor = True
        '
        'btn_doc
        '
        Me.btn_doc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_doc.Font = New System.Drawing.Font("굴림", 15.0!)
        Me.btn_doc.Location = New System.Drawing.Point(3, 17)
        Me.btn_doc.Name = "btn_doc"
        Me.btn_doc.Size = New System.Drawing.Size(809, 63)
        Me.btn_doc.TabIndex = 1
        Me.btn_doc.Text = "CobraDoc"
        Me.btn_doc.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.Font = New System.Drawing.Font("굴림", 15.0!)
        Me.Button3.Location = New System.Drawing.Point(3, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(809, 63)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "CobraDoc + CRTACVRES"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'gb_path
        '
        Me.gb_path.Controls.Add(Me.btn_output)
        Me.gb_path.Controls.Add(Me.btn_input)
        Me.gb_path.Controls.Add(Me.Label1)
        Me.gb_path.Controls.Add(Me.txtboxOutput)
        Me.gb_path.Controls.Add(Me.Label2)
        Me.gb_path.Controls.Add(Me.txtboxInput)
        Me.gb_path.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gb_path.Location = New System.Drawing.Point(5, 9)
        Me.gb_path.Name = "gb_path"
        Me.gb_path.Size = New System.Drawing.Size(815, 194)
        Me.gb_path.TabIndex = 9
        Me.gb_path.TabStop = False
        Me.gb_path.Text = "경로설정"
        '
        'btn_output
        '
        Me.btn_output.Location = New System.Drawing.Point(692, 101)
        Me.btn_output.Name = "btn_output"
        Me.btn_output.Size = New System.Drawing.Size(117, 66)
        Me.btn_output.TabIndex = 6
        Me.btn_output.Text = "출력경로설정"
        Me.btn_output.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(692, 31)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(117, 65)
        Me.btn_input.TabIndex = 5
        Me.btn_input.Text = "입력파일찾기"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "입력 경로"
        '
        'txtboxOutput
        '
        Me.txtboxOutput.AllowDrop = True
        Me.txtboxOutput.Font = New System.Drawing.Font("굴림", 10.0!)
        Me.txtboxOutput.Location = New System.Drawing.Point(126, 101)
        Me.txtboxOutput.Multiline = True
        Me.txtboxOutput.Name = "txtboxOutput"
        Me.txtboxOutput.Size = New System.Drawing.Size(560, 65)
        Me.txtboxOutput.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("굴림", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "출력 경로"
        '
        'txtboxInput
        '
        Me.txtboxInput.AllowDrop = True
        Me.txtboxInput.Font = New System.Drawing.Font("굴림", 10.0!)
        Me.txtboxInput.Location = New System.Drawing.Point(126, 31)
        Me.txtboxInput.Multiline = True
        Me.txtboxInput.Name = "txtboxInput"
        Me.txtboxInput.Size = New System.Drawing.Size(560, 61)
        Me.txtboxInput.TabIndex = 1
        '
        'NormalPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(827, 536)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_path)
        Me.Name = "NormalPDF"
        Me.Text = "일반PDF변환"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gb_path.ResumeLayout(False)
        Me.gb_path.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pdfNoBtn As RadioButton
    Friend WithEvents pdfYesBtn As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCRTACVRES As Button
    Friend WithEvents btn_doc As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents gb_path As GroupBox
    Friend WithEvents btn_output As Button
    Friend WithEvents btn_input As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxOutput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxInput As TextBox
End Class
