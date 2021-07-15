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
        Me.FileBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pathLab = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ContentBox = New System.Windows.Forms.TextBox()
        Me.SaveBut = New System.Windows.Forms.Button()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numberBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'FileBox
        '
        Me.FileBox.Location = New System.Drawing.Point(47, 55)
        Me.FileBox.Multiline = True
        Me.FileBox.Name = "FileBox"
        Me.FileBox.Size = New System.Drawing.Size(288, 308)
        Me.FileBox.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.Location = New System.Drawing.Point(47, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pathLab
        '
        Me.pathLab.AutoSize = True
        Me.pathLab.BackColor = System.Drawing.Color.Transparent
        Me.pathLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pathLab.Location = New System.Drawing.Point(42, 18)
        Me.pathLab.Name = "pathLab"
        Me.pathLab.Size = New System.Drawing.Size(63, 25)
        Me.pathLab.TabIndex = 2
        Me.pathLab.Text = "Path: "
        '
        'ContentBox
        '
        Me.ContentBox.Location = New System.Drawing.Point(562, 55)
        Me.ContentBox.Multiline = True
        Me.ContentBox.Name = "ContentBox"
        Me.ContentBox.Size = New System.Drawing.Size(226, 308)
        Me.ContentBox.TabIndex = 3
        '
        'SaveBut
        '
        Me.SaveBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.SaveBut.Location = New System.Drawing.Point(562, 369)
        Me.SaveBut.Name = "SaveBut"
        Me.SaveBut.Size = New System.Drawing.Size(142, 31)
        Me.SaveBut.TabIndex = 4
        Me.SaveBut.Text = "Save a file"
        Me.SaveBut.UseVisualStyleBackColor = True
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(392, 89)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(153, 22)
        Me.nameBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(387, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "File Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(387, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Number of Files:"
        '
        'numberBox
        '
        Me.numberBox.Location = New System.Drawing.Point(392, 169)
        Me.numberBox.Name = "numberBox"
        Me.numberBox.Size = New System.Drawing.Size(153, 22)
        Me.numberBox.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.File_Read_and_Saver.My.Resources.Resources.brushed_alu_dark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numberBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.SaveBut)
        Me.Controls.Add(Me.ContentBox)
        Me.Controls.Add(Me.pathLab)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FileBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "File Read and Saver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileBox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents pathLab As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ContentBox As TextBox
    Friend WithEvents SaveBut As Button
    Friend WithEvents nameBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numberBox As TextBox
End Class
