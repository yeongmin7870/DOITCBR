﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HardPDF
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lst_commandBox = New System.Windows.Forms.CheckedListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtboxOutput2 = New System.Windows.Forms.TextBox()
        Me.txtboxOutput = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkLst_putFilelst = New System.Windows.Forms.CheckedListBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.commandBox = New System.Windows.Forms.RichTextBox()
        Me.txtInput_Pn = New System.Windows.Forms.Panel()
        Me.txtInputLb = New System.Windows.Forms.Label()
        Me.txtboxInput = New System.Windows.Forms.TextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_cmdClear = New System.Windows.Forms.Button()
        Me.btn_history = New System.Windows.Forms.Button()
        Me.btn_putFileDelete = New System.Windows.Forms.Button()
        Me.cbbox_workLst = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_selectAll = New System.Windows.Forms.Button()
        Me.rd_date = New System.Windows.Forms.RadioButton()
        Me.rd_extension = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.txtInput_Pn.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lst_commandBox)
        Me.Panel4.Location = New System.Drawing.Point(12, 288)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(545, 192)
        Me.Panel4.TabIndex = 17
        '
        'lst_commandBox
        '
        Me.lst_commandBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lst_commandBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_commandBox.Font = New System.Drawing.Font("굴림", 10.0!)
        Me.lst_commandBox.ForeColor = System.Drawing.SystemColors.Info
        Me.lst_commandBox.FormattingEnabled = True
        Me.lst_commandBox.Location = New System.Drawing.Point(16, 15)
        Me.lst_commandBox.Name = "lst_commandBox"
        Me.lst_commandBox.Size = New System.Drawing.Size(511, 162)
        Me.lst_commandBox.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtboxOutput2)
        Me.Panel2.Controls.Add(Me.txtboxOutput)
        Me.Panel2.Location = New System.Drawing.Point(12, 163)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 65)
        Me.Panel2.TabIndex = 18
        '
        'txtboxOutput2
        '
        Me.txtboxOutput2.AllowDrop = True
        Me.txtboxOutput2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtboxOutput2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxOutput2.Font = New System.Drawing.Font("굴림", 10.0!)
        Me.txtboxOutput2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtboxOutput2.Location = New System.Drawing.Point(16, 11)
        Me.txtboxOutput2.Multiline = True
        Me.txtboxOutput2.Name = "txtboxOutput2"
        Me.txtboxOutput2.ReadOnly = True
        Me.txtboxOutput2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtboxOutput2.Size = New System.Drawing.Size(511, 42)
        Me.txtboxOutput2.TabIndex = 1
        '
        'txtboxOutput
        '
        Me.txtboxOutput.AllowDrop = True
        Me.txtboxOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtboxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxOutput.Font = New System.Drawing.Font("굴림", 10.0!)
        Me.txtboxOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtboxOutput.Location = New System.Drawing.Point(21, 11)
        Me.txtboxOutput.Multiline = True
        Me.txtboxOutput.Name = "txtboxOutput"
        Me.txtboxOutput.Size = New System.Drawing.Size(447, 42)
        Me.txtboxOutput.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel3.Controls.Add(Me.chkLst_putFilelst)
        Me.Panel3.Location = New System.Drawing.Point(599, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(536, 185)
        Me.Panel3.TabIndex = 19
        '
        'chkLst_putFilelst
        '
        Me.chkLst_putFilelst.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.chkLst_putFilelst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkLst_putFilelst.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.chkLst_putFilelst.ForeColor = System.Drawing.SystemColors.Window
        Me.chkLst_putFilelst.FormattingEnabled = True
        Me.chkLst_putFilelst.HorizontalScrollbar = True
        Me.chkLst_putFilelst.Location = New System.Drawing.Point(3, 12)
        Me.chkLst_putFilelst.Name = "chkLst_putFilelst"
        Me.chkLst_putFilelst.ScrollAlwaysVisible = True
        Me.chkLst_putFilelst.Size = New System.Drawing.Size(530, 160)
        Me.chkLst_putFilelst.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel5.Controls.Add(Me.commandBox)
        Me.Panel5.Location = New System.Drawing.Point(599, 320)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(536, 111)
        Me.Panel5.TabIndex = 20
        '
        'commandBox
        '
        Me.commandBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.commandBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.commandBox.ForeColor = System.Drawing.SystemColors.Info
        Me.commandBox.Location = New System.Drawing.Point(13, 9)
        Me.commandBox.Name = "commandBox"
        Me.commandBox.Size = New System.Drawing.Size(513, 96)
        Me.commandBox.TabIndex = 26
        Me.commandBox.Text = ""
        '
        'txtInput_Pn
        '
        Me.txtInput_Pn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtInput_Pn.Controls.Add(Me.txtInputLb)
        Me.txtInput_Pn.Controls.Add(Me.txtboxInput)
        Me.txtInput_Pn.Location = New System.Drawing.Point(12, 66)
        Me.txtInput_Pn.Name = "txtInput_Pn"
        Me.txtInput_Pn.Size = New System.Drawing.Size(545, 65)
        Me.txtInput_Pn.TabIndex = 21
        '
        'txtInputLb
        '
        Me.txtInputLb.AllowDrop = True
        Me.txtInputLb.AutoSize = True
        Me.txtInputLb.BackColor = System.Drawing.Color.Transparent
        Me.txtInputLb.Font = New System.Drawing.Font("굴림", 20.0!)
        Me.txtInputLb.ForeColor = System.Drawing.Color.Fuchsia
        Me.txtInputLb.Location = New System.Drawing.Point(89, 18)
        Me.txtInputLb.Name = "txtInputLb"
        Me.txtInputLb.Size = New System.Drawing.Size(363, 27)
        Me.txtInputLb.TabIndex = 2
        Me.txtInputLb.Text = "여기에 파일 끌어다 놓으세요"
        '
        'txtboxInput
        '
        Me.txtboxInput.AllowDrop = True
        Me.txtboxInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtboxInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxInput.Font = New System.Drawing.Font("굴림", 10.0!)
        Me.txtboxInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtboxInput.Location = New System.Drawing.Point(16, 12)
        Me.txtboxInput.Multiline = True
        Me.txtboxInput.Name = "txtboxInput"
        Me.txtboxInput.ReadOnly = True
        Me.txtboxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtboxInput.Size = New System.Drawing.Size(511, 42)
        Me.txtboxInput.TabIndex = 1
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_start.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_start.ForeColor = System.Drawing.Color.Black
        Me.btn_start.Location = New System.Drawing.Point(843, 437)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(292, 36)
        Me.btn_start.TabIndex = 12
        Me.btn_start.Text = "작업실행"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'btn_cmdClear
        '
        Me.btn_cmdClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cmdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cmdClear.Font = New System.Drawing.Font("굴림", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cmdClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_cmdClear.Location = New System.Drawing.Point(599, 437)
        Me.btn_cmdClear.Name = "btn_cmdClear"
        Me.btn_cmdClear.Size = New System.Drawing.Size(101, 36)
        Me.btn_cmdClear.TabIndex = 13
        Me.btn_cmdClear.Text = "비우기"
        Me.btn_cmdClear.UseVisualStyleBackColor = False
        '
        'btn_history
        '
        Me.btn_history.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_history.Font = New System.Drawing.Font("굴림", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_history.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_history.Location = New System.Drawing.Point(706, 436)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Size = New System.Drawing.Size(131, 36)
        Me.btn_history.TabIndex = 14
        Me.btn_history.Text = "사용했던 명령어"
        Me.btn_history.UseVisualStyleBackColor = False
        '
        'btn_putFileDelete
        '
        Me.btn_putFileDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_putFileDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_putFileDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_putFileDelete.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_putFileDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_putFileDelete.Location = New System.Drawing.Point(1003, 252)
        Me.btn_putFileDelete.Name = "btn_putFileDelete"
        Me.btn_putFileDelete.Size = New System.Drawing.Size(132, 33)
        Me.btn_putFileDelete.TabIndex = 15
        Me.btn_putFileDelete.Text = "삭제"
        Me.btn_putFileDelete.UseVisualStyleBackColor = False
        '
        'cbbox_workLst
        '
        Me.cbbox_workLst.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.cbbox_workLst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbox_workLst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbbox_workLst.Font = New System.Drawing.Font("굴림", 13.0!)
        Me.cbbox_workLst.ForeColor = System.Drawing.Color.White
        Me.cbbox_workLst.Location = New System.Drawing.Point(12, 260)
        Me.cbbox_workLst.Name = "cbbox_workLst"
        Me.cbbox_workLst.Size = New System.Drawing.Size(545, 25)
        Me.cbbox_workLst.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("굴림", 20.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(560, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 27)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "📁"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(10, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "1) 작업할 파일" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ""파일 Drag & Drop => 오른쪽 박스에 파일 업로드 됨"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "2) 작업 결과 폴더" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """폴더를 Drag & Drop => 해당 경로에 작업물 떨어짐"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(597, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 24)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "4) 업로드 된 파일" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """작업 할 파일 클릭"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(502, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "3) EXE 명령어 생성기" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """ComboBox 에서 EXE 실행 파일을 선택 => ListBox 에서 명령어 클릭 => 오른쪽 박스 변화"""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(693, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "5) CMD에 입력될 명령어 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "&& 지우지마세요!"""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(712, 476)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(309, 24)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "6) 지금까지 입력했던 CMD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """지금까지 입력했던 명령어, 명령어 클릭 시 재사용 가능"""
        '
        'btn_selectAll
        '
        Me.btn_selectAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_selectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_selectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_selectAll.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_selectAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_selectAll.Location = New System.Drawing.Point(865, 252)
        Me.btn_selectAll.Name = "btn_selectAll"
        Me.btn_selectAll.Size = New System.Drawing.Size(132, 33)
        Me.btn_selectAll.TabIndex = 25
        Me.btn_selectAll.Text = "모두 선택"
        Me.btn_selectAll.UseVisualStyleBackColor = False
        '
        'rd_date
        '
        Me.rd_date.AutoSize = True
        Me.rd_date.Location = New System.Drawing.Point(6, 20)
        Me.rd_date.Name = "rd_date"
        Me.rd_date.Size = New System.Drawing.Size(71, 16)
        Me.rd_date.TabIndex = 26
        Me.rd_date.TabStop = True
        Me.rd_date.Text = "최신날짜"
        Me.rd_date.UseVisualStyleBackColor = True
        '
        'rd_extension
        '
        Me.rd_extension.AutoSize = True
        Me.rd_extension.Location = New System.Drawing.Point(83, 20)
        Me.rd_extension.Name = "rd_extension"
        Me.rd_extension.Size = New System.Drawing.Size(59, 16)
        Me.rd_extension.TabIndex = 27
        Me.rd_extension.TabStop = True
        Me.rd_extension.Text = "확장자"
        Me.rd_extension.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rd_date)
        Me.GroupBox1.Controls.Add(Me.rd_extension)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(993, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 47)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "정렬"
        '
        'HardPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1137, 528)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_selectAll)
        Me.Controls.Add(Me.btn_putFileDelete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txtInput_Pn)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.btn_cmdClear)
        Me.Controls.Add(Me.btn_history)
        Me.Controls.Add(Me.cbbox_workLst)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HardPDF"
        Me.Text = "대용량 PDF 변환"
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.txtInput_Pn.ResumeLayout(False)
        Me.txtInput_Pn.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtboxOutput2 As TextBox
    Friend WithEvents txtboxOutput As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtInput_Pn As Panel
    Friend WithEvents txtboxInput As TextBox
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_cmdClear As Button
    Friend WithEvents btn_history As Button
    Friend WithEvents btn_putFileDelete As Button
    Friend WithEvents cbbox_workLst As ComboBox
    Friend WithEvents Button2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtInputLb As Label
    Friend WithEvents chkLst_putFilelst As CheckedListBox
    Friend WithEvents btn_selectAll As Button
    Friend WithEvents lst_commandBox As CheckedListBox
    Friend WithEvents commandBox As RichTextBox
    Friend WithEvents rd_date As RadioButton
    Friend WithEvents rd_extension As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
