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
        Me.LabelUp = New System.Windows.Forms.Label()
        Me.LabelDown = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelUp
        '
        Me.LabelUp.BackColor = System.Drawing.Color.Transparent
        Me.LabelUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelUp.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelUp.Location = New System.Drawing.Point(0, 111)
        Me.LabelUp.Name = "LabelUp"
        Me.LabelUp.Size = New System.Drawing.Size(727, 70)
        Me.LabelUp.TabIndex = 0
        Me.LabelUp.Text = "You have been blocked!"
        Me.LabelUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDown
        '
        Me.LabelDown.BackColor = System.Drawing.Color.Transparent
        Me.LabelDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelDown.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelDown.Location = New System.Drawing.Point(8, 204)
        Me.LabelDown.Name = "LabelDown"
        Me.LabelDown.Size = New System.Drawing.Size(719, 66)
        Me.LabelDown.TabIndex = 1
        Me.LabelDown.Text = "Press a secret key to unlock!"
        Me.LabelDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Blocker.My.Resources.Resources.dark_honeycomb
        Me.ClientSize = New System.Drawing.Size(728, 440)
        Me.Controls.Add(Me.LabelDown)
        Me.Controls.Add(Me.LabelUp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Blocker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelUp As Label
    Friend WithEvents LabelDown As Label
End Class
