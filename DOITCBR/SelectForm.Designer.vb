<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectForm))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.logMSG = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.folderList = New System.Windows.Forms.ListView()
        Me.iconImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pathBox = New System.Windows.Forms.TextBox()
        Me.workDisplay = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_hard = New System.Windows.Forms.Panel()
        Me.btn_hard_lb = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_exit = New System.Windows.Forms.Label()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.btn_hard.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.logMSG)
        Me.Panel3.Location = New System.Drawing.Point(19, 640)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1138, 141)
        Me.Panel3.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(25, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "로그"
        '
        'logMSG
        '
        Me.logMSG.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.logMSG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.logMSG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.logMSG.Location = New System.Drawing.Point(24, 21)
        Me.logMSG.Margin = New System.Windows.Forms.Padding(30)
        Me.logMSG.Name = "logMSG"
        Me.logMSG.ReadOnly = True
        Me.logMSG.Size = New System.Drawing.Size(1094, 102)
        Me.logMSG.TabIndex = 0
        Me.logMSG.Text = ""
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel4.Controls.Add(Me.folderList)
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Location = New System.Drawing.Point(1177, 91)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(154, 690)
        Me.Panel4.TabIndex = 4
        '
        'folderList
        '
        Me.folderList.AllowDrop = True
        Me.folderList.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.folderList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.folderList.Cursor = System.Windows.Forms.Cursors.Default
        Me.folderList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.folderList.HideSelection = False
        Me.folderList.LargeImageList = Me.iconImgList
        Me.folderList.Location = New System.Drawing.Point(5, 74)
        Me.folderList.MultiSelect = False
        Me.folderList.Name = "folderList"
        Me.folderList.ShowItemToolTips = True
        Me.folderList.Size = New System.Drawing.Size(145, 567)
        Me.folderList.SmallImageList = Me.iconImgList
        Me.folderList.TabIndex = 2
        Me.folderList.UseCompatibleStateImageBehavior = False
        Me.folderList.View = System.Windows.Forms.View.Tile
        '
        'iconImgList
        '
        Me.iconImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.iconImgList.ImageSize = New System.Drawing.Size(16, 16)
        Me.iconImgList.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.pathBox)
        Me.Panel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(3, 15)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(148, 43)
        Me.Panel9.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "결과"
        '
        'pathBox
        '
        Me.pathBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pathBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pathBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pathBox.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.pathBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.pathBox.Location = New System.Drawing.Point(0, 30)
        Me.pathBox.Name = "pathBox"
        Me.pathBox.ReadOnly = True
        Me.pathBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.pathBox.Size = New System.Drawing.Size(148, 13)
        Me.pathBox.TabIndex = 0
        '
        'workDisplay
        '
        Me.workDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.workDisplay.Location = New System.Drawing.Point(20, 91)
        Me.workDisplay.Margin = New System.Windows.Forms.Padding(10)
        Me.workDisplay.Name = "workDisplay"
        Me.workDisplay.Size = New System.Drawing.Size(1137, 529)
        Me.workDisplay.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.btn_hard)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.lb_exit)
        Me.Panel1.Controls.Add(Me.ToolStripDropDownButton1)
        Me.Panel1.Location = New System.Drawing.Point(20, 20)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1311, 51)
        Me.Panel1.TabIndex = 6
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel8.Location = New System.Drawing.Point(419, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(81, 45)
        Me.Panel8.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(-4, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "💻명령어파일"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel7.Location = New System.Drawing.Point(314, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(81, 45)
        Me.Panel7.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "📜로그파일"
        '
        'btn_hard
        '
        Me.btn_hard.Controls.Add(Me.btn_hard_lb)
        Me.btn_hard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hard.Location = New System.Drawing.Point(203, 3)
        Me.btn_hard.Name = "btn_hard"
        Me.btn_hard.Size = New System.Drawing.Size(81, 45)
        Me.btn_hard.TabIndex = 0
        '
        'btn_hard_lb
        '
        Me.btn_hard_lb.AutoSize = True
        Me.btn_hard_lb.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hard_lb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn_hard_lb.Location = New System.Drawing.Point(1, 15)
        Me.btn_hard_lb.Name = "btn_hard_lb"
        Me.btn_hard_lb.Size = New System.Drawing.Size(77, 17)
        Me.btn_hard_lb.TabIndex = 2
        Me.btn_hard_lb.Text = "🕒새로고침"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel5.Location = New System.Drawing.Point(18, 9)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(109, 33)
        Me.Panel5.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 5.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 8)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "New Technology Business"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NTB"
        '
        'lb_exit
        '
        Me.lb_exit.AutoSize = True
        Me.lb_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_exit.Font = New System.Drawing.Font("굴림", 20.0!)
        Me.lb_exit.ForeColor = System.Drawing.Color.Transparent
        Me.lb_exit.Location = New System.Drawing.Point(1244, 10)
        Me.lb_exit.Name = "lb_exit"
        Me.lb_exit.Size = New System.Drawing.Size(39, 27)
        Me.lb_exit.TabIndex = 2
        Me.lb_exit.Text = "❌"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.AutoSize = True
        Me.ToolStripDropDownButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("굴림", 20.0!)
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.Transparent
        Me.ToolStripDropDownButton1.Location = New System.Drawing.Point(1210, 10)
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(39, 27)
        Me.ToolStripDropDownButton1.TabIndex = 2
        Me.ToolStripDropDownButton1.Text = "⚙"
        '
        'SelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1350, 800)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.workDisplay)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.btn_hard.ResumeLayout(False)
        Me.btn_hard.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pathFolderBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents logMSG As RichTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents folderList As ListView
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pathBox As TextBox
    Friend WithEvents workDisplay As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_hard As Panel
    Friend WithEvents btn_hard_lb As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_exit As Label
    Friend WithEvents ToolStripDropDownButton1 As Label
    Friend WithEvents iconImgList As ImageList
End Class
