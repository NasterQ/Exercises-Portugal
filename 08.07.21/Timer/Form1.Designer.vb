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
        Me.components = New System.ComponentModel.Container()
        Me.startBut = New System.Windows.Forms.Button()
        Me.stopBut = New System.Windows.Forms.Button()
        Me.refBut = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerLab = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'startBut
        '
        Me.startBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.startBut.Location = New System.Drawing.Point(524, 38)
        Me.startBut.Name = "startBut"
        Me.startBut.Size = New System.Drawing.Size(209, 121)
        Me.startBut.TabIndex = 0
        Me.startBut.Text = "Start"
        Me.startBut.UseVisualStyleBackColor = True
        '
        'stopBut
        '
        Me.stopBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.stopBut.Location = New System.Drawing.Point(524, 165)
        Me.stopBut.Name = "stopBut"
        Me.stopBut.Size = New System.Drawing.Size(209, 121)
        Me.stopBut.TabIndex = 1
        Me.stopBut.Text = "Stop"
        Me.stopBut.UseVisualStyleBackColor = True
        '
        'refBut
        '
        Me.refBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.refBut.Location = New System.Drawing.Point(524, 356)
        Me.refBut.Name = "refBut"
        Me.refBut.Size = New System.Drawing.Size(209, 47)
        Me.refBut.TabIndex = 2
        Me.refBut.Text = "Refresh"
        Me.refBut.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'timerLab
        '
        Me.timerLab.AutoSize = True
        Me.timerLab.Font = New System.Drawing.Font("Bauhaus 93", 32.0!, System.Drawing.FontStyle.Bold)
        Me.timerLab.Location = New System.Drawing.Point(36, 165)
        Me.timerLab.Name = "timerLab"
        Me.timerLab.Size = New System.Drawing.Size(346, 62)
        Me.timerLab.TabIndex = 3
        Me.timerLab.Text = "00:00:00:00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 415)
        Me.Controls.Add(Me.timerLab)
        Me.Controls.Add(Me.refBut)
        Me.Controls.Add(Me.stopBut)
        Me.Controls.Add(Me.startBut)
        Me.Name = "Form1"
        Me.Text = "Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startBut As Button
    Friend WithEvents stopBut As Button
    Friend WithEvents refBut As Button
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents timerLab As Label
End Class
