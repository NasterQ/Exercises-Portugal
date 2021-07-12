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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.sizeBigLab = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sizeSmallLab = New System.Windows.Forms.Label()
        Me.speedSlowLab = New System.Windows.Forms.Label()
        Me.speedFastLab = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.speedFastLab)
        Me.Panel1.Controls.Add(Me.speedSlowLab)
        Me.Panel1.Controls.Add(Me.sizeSmallLab)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.sizeBigLab)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 330)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Goal Saver!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Size of the platform"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Speed"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(254, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 120)
        Me.Label4.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(179, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Let's Play!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sizeBigLab
        '
        Me.sizeBigLab.AutoSize = True
        Me.sizeBigLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sizeBigLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.sizeBigLab.ForeColor = System.Drawing.Color.DarkOrange
        Me.sizeBigLab.Location = New System.Drawing.Point(47, 193)
        Me.sizeBigLab.Name = "sizeBigLab"
        Me.sizeBigLab.Size = New System.Drawing.Size(62, 34)
        Me.sizeBigLab.TabIndex = 5
        Me.sizeBigLab.Text = "Big"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(35, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(464, 10)
        Me.Label6.TabIndex = 6
        '
        'sizeSmallLab
        '
        Me.sizeSmallLab.AutoSize = True
        Me.sizeSmallLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sizeSmallLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.sizeSmallLab.Location = New System.Drawing.Point(146, 193)
        Me.sizeSmallLab.Name = "sizeSmallLab"
        Me.sizeSmallLab.Size = New System.Drawing.Size(89, 34)
        Me.sizeSmallLab.TabIndex = 7
        Me.sizeSmallLab.Text = "Small"
        '
        'speedSlowLab
        '
        Me.speedSlowLab.AutoSize = True
        Me.speedSlowLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.speedSlowLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.speedSlowLab.ForeColor = System.Drawing.Color.DarkOrange
        Me.speedSlowLab.Location = New System.Drawing.Point(288, 193)
        Me.speedSlowLab.Name = "speedSlowLab"
        Me.speedSlowLab.Size = New System.Drawing.Size(83, 34)
        Me.speedSlowLab.TabIndex = 8
        Me.speedSlowLab.Text = "Slow"
        '
        'speedFastLab
        '
        Me.speedFastLab.AutoSize = True
        Me.speedFastLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.speedFastLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.speedFastLab.Location = New System.Drawing.Point(399, 193)
        Me.speedFastLab.Name = "speedFastLab"
        Me.speedFastLab.Size = New System.Drawing.Size(72, 34)
        Me.speedFastLab.TabIndex = 9
        Me.speedFastLab.Text = "Fast"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(582, 353)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Goal Saver"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents sizeBigLab As Label
    Friend WithEvents sizeSmallLab As Label
    Friend WithEvents speedSlowLab As Label
    Friend WithEvents speedFastLab As Label
End Class
