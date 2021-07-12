<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BackPanel = New System.Windows.Forms.Panel()
        Me.platform = New System.Windows.Forms.Panel()
        Me.ball = New System.Windows.Forms.Panel()
        Me.pointsLab = New System.Windows.Forms.Label()
        Me.BackPanelUp = New System.Windows.Forms.Panel()
        Me.BackPanelBottom = New System.Windows.Forms.Panel()
        Me.BackPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackPanel
        '
        Me.BackPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackPanel.Controls.Add(Me.pointsLab)
        Me.BackPanel.Controls.Add(Me.ball)
        Me.BackPanel.Controls.Add(Me.platform)
        Me.BackPanel.Location = New System.Drawing.Point(12, 28)
        Me.BackPanel.Name = "BackPanel"
        Me.BackPanel.Size = New System.Drawing.Size(550, 300)
        Me.BackPanel.TabIndex = 0
        '
        'platform
        '
        Me.platform.BackColor = System.Drawing.Color.White
        Me.platform.Location = New System.Drawing.Point(20, 80)
        Me.platform.Name = "platform"
        Me.platform.Size = New System.Drawing.Size(10, 130)
        Me.platform.TabIndex = 2
        '
        'ball
        '
        Me.ball.BackColor = System.Drawing.Color.White
        Me.ball.Location = New System.Drawing.Point(480, 140)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(10, 10)
        Me.ball.TabIndex = 3
        '
        'pointsLab
        '
        Me.pointsLab.AutoSize = True
        Me.pointsLab.Font = New System.Drawing.Font("Monotype Corsiva", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pointsLab.Location = New System.Drawing.Point(251, 10)
        Me.pointsLab.Name = "pointsLab"
        Me.pointsLab.Size = New System.Drawing.Size(42, 53)
        Me.pointsLab.TabIndex = 4
        Me.pointsLab.Text = "0"
        '
        'BackPanelUp
        '
        Me.BackPanelUp.Location = New System.Drawing.Point(12, -10)
        Me.BackPanelUp.Name = "BackPanelUp"
        Me.BackPanelUp.Size = New System.Drawing.Size(550, 10)
        Me.BackPanelUp.TabIndex = 1
        '
        'BackPanelBottom
        '
        Me.BackPanelBottom.Location = New System.Drawing.Point(12, 331)
        Me.BackPanelBottom.Name = "BackPanelBottom"
        Me.BackPanelBottom.Size = New System.Drawing.Size(550, 10)
        Me.BackPanelBottom.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(582, 353)
        Me.Controls.Add(Me.BackPanelBottom)
        Me.Controls.Add(Me.BackPanelUp)
        Me.Controls.Add(Me.BackPanel)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Goal Saver"
        Me.BackPanel.ResumeLayout(False)
        Me.BackPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackPanel As Panel
    Friend WithEvents platform As Panel
    Friend WithEvents ball As Panel
    Friend WithEvents pointsLab As Label
    Friend WithEvents BackPanelUp As Panel
    Friend WithEvents BackPanelBottom As Panel
End Class
