<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lst_commandBox = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtboxOutput2 = New System.Windows.Forms.TextBox()
        Me.txtboxOutput = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkLst_putFilelst = New System.Windows.Forms.ListBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.commandBox = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtboxInput = New System.Windows.Forms.TextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_cmdClear = New System.Windows.Forms.Button()
        Me.btn_history = New System.Windows.Forms.Button()
        Me.btn_putFileDelete = New System.Windows.Forms.Button()
        Me.cbbox_workLst = New System.Windows.Forms.ComboBox()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.Panel4.Location = New System.Drawing.Point(65, 270)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(492, 192)
        Me.Panel4.TabIndex = 17
        '
        'lst_commandBox
        '
        Me.lst_commandBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lst_commandBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_commandBox.Font = New System.Drawing.Font("굴림", 13.0!)
        Me.lst_commandBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lst_commandBox.FormattingEnabled = True
        Me.lst_commandBox.ItemHeight = 17
        Me.lst_commandBox.Location = New System.Drawing.Point(20, 13)
        Me.lst_commandBox.Name = "lst_commandBox"
        Me.lst_commandBox.Size = New System.Drawing.Size(448, 153)
        Me.lst_commandBox.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtboxOutput2)
        Me.Panel2.Controls.Add(Me.txtboxOutput)
        Me.Panel2.Location = New System.Drawing.Point(65, 153)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(492, 65)
        Me.Panel2.TabIndex = 18
        '
        'txtboxOutput2
        '
        Me.txtboxOutput2.AllowDrop = True
        Me.txtboxOutput2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtboxOutput2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxOutput2.Font = New System.Drawing.Font("굴림", 13.0!)
        Me.txtboxOutput2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtboxOutput2.Location = New System.Drawing.Point(21, 11)
        Me.txtboxOutput2.Multiline = True
        Me.txtboxOutput2.Name = "txtboxOutput2"
        Me.txtboxOutput2.Size = New System.Drawing.Size(447, 42)
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
        Me.Panel3.Location = New System.Drawing.Point(623, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(439, 185)
        Me.Panel3.TabIndex = 19
        '
        'chkLst_putFilelst
        '
        Me.chkLst_putFilelst.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.chkLst_putFilelst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkLst_putFilelst.Font = New System.Drawing.Font("굴림", 13.0!)
        Me.chkLst_putFilelst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.chkLst_putFilelst.FormattingEnabled = True
        Me.chkLst_putFilelst.ItemHeight = 17
        Me.chkLst_putFilelst.Location = New System.Drawing.Point(20, 16)
        Me.chkLst_putFilelst.Name = "chkLst_putFilelst"
        Me.chkLst_putFilelst.Size = New System.Drawing.Size(400, 136)
        Me.chkLst_putFilelst.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel5.Controls.Add(Me.commandBox)
        Me.Panel5.Location = New System.Drawing.Point(623, 308)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(449, 111)
        Me.Panel5.TabIndex = 20
        '
        'commandBox
        '
        Me.commandBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.commandBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.commandBox.Font = New System.Drawing.Font("굴림", 13.0!)
        Me.commandBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.commandBox.Location = New System.Drawing.Point(20, 12)
        Me.commandBox.Name = "commandBox"
        Me.commandBox.Size = New System.Drawing.Size(405, 86)
        Me.commandBox.TabIndex = 10
        Me.commandBox.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtboxInput)
        Me.Panel1.Location = New System.Drawing.Point(65, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 65)
        Me.Panel1.TabIndex = 21
        '
        'txtboxInput
        '
        Me.txtboxInput.AllowDrop = True
        Me.txtboxInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtboxInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxInput.Font = New System.Drawing.Font("굴림", 13.0!)
        Me.txtboxInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtboxInput.Location = New System.Drawing.Point(21, 11)
        Me.txtboxInput.Multiline = True
        Me.txtboxInput.Name = "txtboxInput"
        Me.txtboxInput.Size = New System.Drawing.Size(447, 42)
        Me.txtboxInput.TabIndex = 1
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_start.Location = New System.Drawing.Point(930, 425)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(142, 36)
        Me.btn_start.TabIndex = 12
        Me.btn_start.Text = "작업실행"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'btn_cmdClear
        '
        Me.btn_cmdClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_cmdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cmdClear.Font = New System.Drawing.Font("굴림", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cmdClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_cmdClear.Location = New System.Drawing.Point(623, 425)
        Me.btn_cmdClear.Name = "btn_cmdClear"
        Me.btn_cmdClear.Size = New System.Drawing.Size(142, 36)
        Me.btn_cmdClear.TabIndex = 13
        Me.btn_cmdClear.Text = "비우기"
        Me.btn_cmdClear.UseVisualStyleBackColor = False
        '
        'btn_history
        '
        Me.btn_history.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btn_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_history.Font = New System.Drawing.Font("굴림", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_history.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_history.Location = New System.Drawing.Point(777, 425)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Size = New System.Drawing.Size(142, 36)
        Me.btn_history.TabIndex = 14
        Me.btn_history.Text = "History"
        Me.btn_history.UseVisualStyleBackColor = False
        '
        'btn_putFileDelete
        '
        Me.btn_putFileDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_putFileDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_putFileDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_putFileDelete.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_putFileDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btn_putFileDelete.Location = New System.Drawing.Point(777, 257)
        Me.btn_putFileDelete.Name = "btn_putFileDelete"
        Me.btn_putFileDelete.Size = New System.Drawing.Size(142, 38)
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
        Me.cbbox_workLst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cbbox_workLst.Location = New System.Drawing.Point(65, 242)
        Me.cbbox_workLst.Name = "cbbox_workLst"
        Me.cbbox_workLst.Size = New System.Drawing.Size(492, 25)
        Me.cbbox_workLst.TabIndex = 16
        '
        'HardPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1137, 528)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btn_putFileDelete)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lst_commandBox As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtboxOutput2 As TextBox
    Friend WithEvents txtboxOutput As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents chkLst_putFilelst As ListBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents commandBox As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtboxInput As TextBox
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_cmdClear As Button
    Friend WithEvents btn_history As Button
    Friend WithEvents btn_putFileDelete As Button
    Friend WithEvents cbbox_workLst As ComboBox
End Class
