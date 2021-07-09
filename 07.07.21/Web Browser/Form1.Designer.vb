<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.linkBox = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.backBut = New System.Windows.Forms.Button()
        Me.forBut = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.refBut = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(1, 48)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(966, 523)
        Me.WebBrowser1.TabIndex = 0
        '
        'linkBox
        '
        Me.linkBox.Location = New System.Drawing.Point(12, 13)
        Me.linkBox.Name = "linkBox"
        Me.linkBox.Size = New System.Drawing.Size(600, 22)
        Me.linkBox.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(618, 13)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(340, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(1037, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 61)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'backBut
        '
        Me.backBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.backBut.Location = New System.Drawing.Point(984, 13)
        Me.backBut.Name = "backBut"
        Me.backBut.Size = New System.Drawing.Size(117, 47)
        Me.backBut.TabIndex = 4
        Me.backBut.Text = "Back"
        Me.backBut.UseVisualStyleBackColor = True
        '
        'forBut
        '
        Me.forBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.forBut.Location = New System.Drawing.Point(1132, 12)
        Me.forBut.Name = "forBut"
        Me.forBut.Size = New System.Drawing.Size(117, 47)
        Me.forBut.TabIndex = 5
        Me.forBut.Text = "Forward"
        Me.forBut.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 574)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1261, 26)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel1
        '
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(49, 20)
        Me.StatusLabel1.Text = "Status"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 18)
        '
        'refBut
        '
        Me.refBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.refBut.Location = New System.Drawing.Point(1037, 434)
        Me.refBut.Name = "refBut"
        Me.refBut.Size = New System.Drawing.Size(179, 61)
        Me.refBut.TabIndex = 7
        Me.refBut.Text = "Refresh"
        Me.refBut.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Web_Browser.My.Resources.Resources.dark_honeycomb
        Me.ClientSize = New System.Drawing.Size(1261, 600)
        Me.Controls.Add(Me.refBut)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.forBut)
        Me.Controls.Add(Me.backBut)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.linkBox)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Form1"
        Me.Text = "M&R Browser"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents linkBox As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents backBut As Button
    Friend WithEvents forBut As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents refBut As Button
End Class
