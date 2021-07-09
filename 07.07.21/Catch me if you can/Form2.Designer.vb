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
        Me.gratzLab = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'gratzLab
        '
        Me.gratzLab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gratzLab.BackColor = System.Drawing.Color.Transparent
        Me.gratzLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gratzLab.ForeColor = System.Drawing.Color.Gold
        Me.gratzLab.Location = New System.Drawing.Point(12, 107)
        Me.gratzLab.Name = "gratzLab"
        Me.gratzLab.Size = New System.Drawing.Size(553, 100)
        Me.gratzLab.TabIndex = 0
        Me.gratzLab.Text = "Congratulations! You've just won the game!"
        Me.gratzLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.Location = New System.Drawing.Point(212, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Finish it!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(577, 344)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gratzLab)
        Me.Name = "Form2"
        Me.Text = "Gratz!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gratzLab As Label
    Friend WithEvents Button1 As Button
End Class
