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
        Me.btn_hard = New System.Windows.Forms.Button()
        Me.btn_normal = New System.Windows.Forms.Button()
        Me.gp_select = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.GroupBox()
        Me.logMSG = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pathBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.folderList = New System.Windows.Forms.ListView()
        Me.workDisplay = New System.Windows.Forms.GroupBox()
        Me.gp_select.SuspendLayout()
        Me.txtLog.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_hard
        '
        Me.btn_hard.BackColor = System.Drawing.Color.DarkGray
        Me.btn_hard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hard.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btn_hard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_hard.Location = New System.Drawing.Point(7, 61)
        Me.btn_hard.Name = "btn_hard"
        Me.btn_hard.Size = New System.Drawing.Size(200, 34)
        Me.btn_hard.TabIndex = 0
        Me.btn_hard.Text = "COBRADOC -> CRTPDFC"
        Me.btn_hard.UseVisualStyleBackColor = False
        '
        'btn_normal
        '
        Me.btn_normal.BackColor = System.Drawing.Color.DarkGray
        Me.btn_normal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_normal.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btn_normal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_normal.Location = New System.Drawing.Point(7, 102)
        Me.btn_normal.Name = "btn_normal"
        Me.btn_normal.Size = New System.Drawing.Size(201, 35)
        Me.btn_normal.TabIndex = 1
        Me.btn_normal.Text = "COBRADOC -> CRTAVRES"
        Me.btn_normal.UseVisualStyleBackColor = False
        '
        'gp_select
        '
        Me.gp_select.Controls.Add(Me.Button1)
        Me.gp_select.Controls.Add(Me.btn_hard)
        Me.gp_select.Controls.Add(Me.btn_normal)
        Me.gp_select.Dock = System.Windows.Forms.DockStyle.Left
        Me.gp_select.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gp_select.Location = New System.Drawing.Point(0, 0)
        Me.gp_select.Name = "gp_select"
        Me.gp_select.Size = New System.Drawing.Size(217, 729)
        Me.gp_select.TabIndex = 2
        Me.gp_select.TabStop = False
        Me.gp_select.Text = "작업리스트"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(5, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "사용 설명서"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtLog
        '
        Me.txtLog.Controls.Add(Me.logMSG)
        Me.txtLog.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtLog.Location = New System.Drawing.Point(217, 612)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(1133, 117)
        Me.txtLog.TabIndex = 4
        Me.txtLog.TabStop = False
        Me.txtLog.Text = "작업 상황"
        '
        'logMSG
        '
        Me.logMSG.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.logMSG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logMSG.Font = New System.Drawing.Font("굴림", 10.0!)
        Me.logMSG.ForeColor = System.Drawing.SystemColors.Window
        Me.logMSG.Location = New System.Drawing.Point(3, 17)
        Me.logMSG.Name = "logMSG"
        Me.logMSG.ReadOnly = True
        Me.logMSG.Size = New System.Drawing.Size(1127, 97)
        Me.logMSG.TabIndex = 4
        Me.logMSG.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.folderList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(1077, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(273, 612)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "폴더"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pathBox)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 589)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 21)
        Me.Panel1.TabIndex = 3
        '
        'pathBox
        '
        Me.pathBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pathBox.Location = New System.Drawing.Point(0, 0)
        Me.pathBox.Name = "pathBox"
        Me.pathBox.Size = New System.Drawing.Size(209, 21)
        Me.pathBox.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Honeydew
        Me.Button2.Location = New System.Drawing.Point(209, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 21)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "탐색기"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'folderList
        '
        Me.folderList.BackColor = System.Drawing.Color.Black
        Me.folderList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.folderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.folderList.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Bold)
        Me.folderList.ForeColor = System.Drawing.SystemColors.Info
        Me.folderList.HideSelection = False
        Me.folderList.Location = New System.Drawing.Point(3, 16)
        Me.folderList.MultiSelect = False
        Me.folderList.Name = "folderList"
        Me.folderList.Size = New System.Drawing.Size(267, 594)
        Me.folderList.TabIndex = 0
        Me.folderList.UseCompatibleStateImageBehavior = False
        Me.folderList.View = System.Windows.Forms.View.Tile
        '
        'workDisplay
        '
        Me.workDisplay.AutoSize = True
        Me.workDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.workDisplay.Location = New System.Drawing.Point(223, 11)
        Me.workDisplay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.workDisplay.Name = "workDisplay"
        Me.workDisplay.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.workDisplay.Size = New System.Drawing.Size(848, 599)
        Me.workDisplay.TabIndex = 5
        Me.workDisplay.TabStop = False
        Me.workDisplay.Text = "작업창"
        '
        'SelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.workDisplay)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.gp_select)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Name = "SelectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DOITCBR"
        Me.gp_select.ResumeLayout(False)
        Me.txtLog.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_hard As Button
    Friend WithEvents btn_normal As Button
    Friend WithEvents gp_select As GroupBox
    Friend WithEvents txtLog As GroupBox
    Friend WithEvents logMSG As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents folderList As ListView
    Friend WithEvents pathFolderBox As TextBox
    Friend WithEvents pathBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents workDisplay As GroupBox
End Class
