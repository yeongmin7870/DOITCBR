<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class History
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
        Me.cmdHistory = New System.Windows.Forms.ListBox()
        Me.historyNavbar = New System.Windows.Forms.Panel()
        Me.lb_exit = New System.Windows.Forms.Label()
        Me.historyNavbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdHistory
        '
        Me.cmdHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cmdHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdHistory.Font = New System.Drawing.Font("굴림", 10.0!)
        Me.cmdHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdHistory.FormattingEnabled = True
        Me.cmdHistory.HorizontalScrollbar = True
        Me.cmdHistory.Location = New System.Drawing.Point(14, 65)
        Me.cmdHistory.Name = "cmdHistory"
        Me.cmdHistory.ScrollAlwaysVisible = True
        Me.cmdHistory.Size = New System.Drawing.Size(1307, 559)
        Me.cmdHistory.TabIndex = 0
        '
        'historyNavbar
        '
        Me.historyNavbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.historyNavbar.Controls.Add(Me.lb_exit)
        Me.historyNavbar.Location = New System.Drawing.Point(14, 19)
        Me.historyNavbar.Margin = New System.Windows.Forms.Padding(10)
        Me.historyNavbar.Name = "historyNavbar"
        Me.historyNavbar.Size = New System.Drawing.Size(1307, 32)
        Me.historyNavbar.TabIndex = 7
        '
        'lb_exit
        '
        Me.lb_exit.AutoSize = True
        Me.lb_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_exit.Font = New System.Drawing.Font("굴림", 13.0!)
        Me.lb_exit.ForeColor = System.Drawing.Color.Transparent
        Me.lb_exit.Location = New System.Drawing.Point(1272, 7)
        Me.lb_exit.Name = "lb_exit"
        Me.lb_exit.Size = New System.Drawing.Size(26, 18)
        Me.lb_exit.TabIndex = 2
        Me.lb_exit.Text = "❌"
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1333, 636)
        Me.Controls.Add(Me.historyNavbar)
        Me.Controls.Add(Me.cmdHistory)
        Me.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "History"
        Me.Text = "History"
        Me.historyNavbar.ResumeLayout(False)
        Me.historyNavbar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdHistory As ListBox
    Friend WithEvents historyNavbar As Panel
    Friend WithEvents lb_exit As Label
End Class
