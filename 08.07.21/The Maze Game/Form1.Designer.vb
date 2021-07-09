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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nicknameBox = New System.Windows.Forms.TextBox()
        Me.goBut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(64, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to The Maze! Please input your name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nicknameBox
        '
        Me.nicknameBox.Location = New System.Drawing.Point(147, 127)
        Me.nicknameBox.Name = "nicknameBox"
        Me.nicknameBox.Size = New System.Drawing.Size(187, 22)
        Me.nicknameBox.TabIndex = 1
        '
        'goBut
        '
        Me.goBut.Location = New System.Drawing.Point(184, 183)
        Me.goBut.Name = "goBut"
        Me.goBut.Size = New System.Drawing.Size(102, 44)
        Me.goBut.TabIndex = 2
        Me.goBut.Text = "Let's go!"
        Me.goBut.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Maze_Game.My.Resources.Resources.dark_honeycomb
        Me.ClientSize = New System.Drawing.Size(484, 271)
        Me.Controls.Add(Me.goBut)
        Me.Controls.Add(Me.nicknameBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "The Maze Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nicknameBox As TextBox
    Friend WithEvents goBut As Button
End Class
