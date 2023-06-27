<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Me.cmdHistory = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdHistory
        '
        Me.cmdHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdHistory.FormattingEnabled = True
        Me.cmdHistory.HorizontalScrollbar = True
        Me.cmdHistory.ItemHeight = 12
        Me.cmdHistory.Location = New System.Drawing.Point(0, 0)
        Me.cmdHistory.Name = "cmdHistory"
        Me.cmdHistory.ScrollAlwaysVisible = True
        Me.cmdHistory.Size = New System.Drawing.Size(776, 426)
        Me.cmdHistory.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdHistory)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 426)
        Me.Panel1.TabIndex = 1
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "History"
        Me.Text = "History"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdHistory As ListBox
    Friend WithEvents Panel1 As Panel
End Class
