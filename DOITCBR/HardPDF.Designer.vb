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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HardPDF))
        Me.txtboxInput = New System.Windows.Forms.TextBox()
        Me.txtboxOutput = New System.Windows.Forms.TextBox()
        Me.gb_path = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.btn_output = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.command = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.gb_path.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.command.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtboxInput
        '
        Me.txtboxInput.AllowDrop = True
        Me.txtboxInput.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtboxInput.Font = New System.Drawing.Font("굴림", 10.0!)
        Me.txtboxInput.Location = New System.Drawing.Point(0, 0)
        Me.txtboxInput.Name = "txtboxInput"
        Me.txtboxInput.Size = New System.Drawing.Size(836, 23)
        Me.txtboxInput.TabIndex = 1
        '
        'txtboxOutput
        '
        Me.txtboxOutput.AllowDrop = True
        Me.txtboxOutput.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtboxOutput.Font = New System.Drawing.Font("굴림", 10.0!)
        Me.txtboxOutput.Location = New System.Drawing.Point(0, 21)
        Me.txtboxOutput.Name = "txtboxOutput"
        Me.txtboxOutput.Size = New System.Drawing.Size(836, 23)
        Me.txtboxOutput.TabIndex = 2
        '
        'gb_path
        '
        Me.gb_path.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gb_path.Controls.Add(Me.Panel2)
        Me.gb_path.Controls.Add(Me.Panel1)
        Me.gb_path.ForeColor = System.Drawing.Color.Black
        Me.gb_path.Location = New System.Drawing.Point(29, 12)
        Me.gb_path.Name = "gb_path"
        Me.gb_path.Size = New System.Drawing.Size(972, 64)
        Me.gb_path.TabIndex = 3
        Me.gb_path.TabStop = False
        Me.gb_path.Text = "경로설정"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_input)
        Me.Panel2.Controls.Add(Me.btn_output)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(838, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 44)
        Me.Panel2.TabIndex = 8
        '
        'btn_input
        '
        Me.btn_input.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_input.Location = New System.Drawing.Point(0, 0)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(131, 23)
        Me.btn_input.TabIndex = 5
        Me.btn_input.Text = "입력파일찾기"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'btn_output
        '
        Me.btn_output.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_output.Location = New System.Drawing.Point(0, 21)
        Me.btn_output.Name = "btn_output"
        Me.btn_output.Size = New System.Drawing.Size(132, 23)
        Me.btn_output.TabIndex = 6
        Me.btn_output.Text = "출력경로설정"
        Me.btn_output.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtboxInput)
        Me.Panel1.Controls.Add(Me.txtboxOutput)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 44)
        Me.Panel1.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(23, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(978, 197)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "작업"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Font = New System.Drawing.Font("굴림", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(6, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 78)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "모두 선택"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(3, 17)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(842, 177)
        Me.CheckedListBox1.TabIndex = 3
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 17)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(969, 94)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'command
        '
        Me.command.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.command.Controls.Add(Me.RichTextBox1)
        Me.command.Location = New System.Drawing.Point(23, 418)
        Me.command.Name = "command"
        Me.command.Size = New System.Drawing.Size(975, 114)
        Me.command.TabIndex = 11
        Me.command.TabStop = False
        Me.command.Text = "명령어"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.CheckedListBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(975, 127)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "올려 놓은 파일 리스트"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(3, 17)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(839, 107)
        Me.CheckedListBox2.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(2, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "?"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button3.ForeColor = System.Drawing.Color.Crimson
        Me.Button3.Location = New System.Drawing.Point(2, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 25)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "?"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button4.ForeColor = System.Drawing.Color.Crimson
        Me.Button4.Location = New System.Drawing.Point(5, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 25)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "?"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button5.ForeColor = System.Drawing.Color.Crimson
        Me.Button5.Location = New System.Drawing.Point(5, 82)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 25)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "?"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Location = New System.Drawing.Point(848, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 107)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "도구"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button11)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox4.Location = New System.Drawing.Point(851, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(124, 177)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "도구"
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(6, 98)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 76)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "작업실행"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Font = New System.Drawing.Font("굴림", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(6, 20)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(57, 38)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "모두 선택"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button8.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.Transparent
        Me.Button8.Location = New System.Drawing.Point(6, 64)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 37)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "삭제"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button9.BackColor = System.Drawing.Color.Maroon
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Font = New System.Drawing.Font("굴림", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button9.ForeColor = System.Drawing.Color.Transparent
        Me.Button9.Location = New System.Drawing.Point(64, 20)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(57, 38)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "모두 해제"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button11.BackColor = System.Drawing.Color.Maroon
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button11.Font = New System.Drawing.Font("굴림", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button11.ForeColor = System.Drawing.Color.Transparent
        Me.Button11.Location = New System.Drawing.Point(64, 14)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(57, 78)
        Me.Button11.TabIndex = 4
        Me.Button11.Text = "모두 해제"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'HardPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1010, 544)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.command)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_path)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "HardPDF"
        Me.Text = "대용량 PDF 변환"
        Me.gb_path.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.command.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtboxInput As TextBox
    Friend WithEvents txtboxOutput As TextBox
    Friend WithEvents gb_path As GroupBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_input As Button
    Friend WithEvents btn_output As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents command As GroupBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
End Class
