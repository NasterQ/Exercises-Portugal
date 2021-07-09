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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.helloBut = New System.Windows.Forms.Button()
        Me.hello = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.submitBut = New System.Windows.Forms.Button()
        Me.greetingsLab = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.countryCombo = New System.Windows.Forms.ComboBox()
        Me.Radio1 = New System.Windows.Forms.RadioButton()
        Me.Radio2 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.detailsLab = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exercise 1 and 2"
        '
        'helloBut
        '
        Me.helloBut.Location = New System.Drawing.Point(32, 74)
        Me.helloBut.Name = "helloBut"
        Me.helloBut.Size = New System.Drawing.Size(120, 39)
        Me.helloBut.TabIndex = 1
        Me.helloBut.Text = "Click me!"
        Me.helloBut.UseVisualStyleBackColor = True
        '
        'hello
        '
        Me.hello.AutoSize = True
        Me.hello.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.hello.Location = New System.Drawing.Point(32, 132)
        Me.hello.Name = "hello"
        Me.hello.Size = New System.Drawing.Size(146, 25)
        Me.hello.TabIndex = 2
        Me.hello.Text = "Click the button"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Exercise 3"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(297, 74)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(133, 22)
        Me.nameBox.TabIndex = 5
        '
        'submitBut
        '
        Me.submitBut.Location = New System.Drawing.Point(437, 72)
        Me.submitBut.Name = "submitBut"
        Me.submitBut.Size = New System.Drawing.Size(75, 23)
        Me.submitBut.TabIndex = 6
        Me.submitBut.Text = "Submit"
        Me.submitBut.UseVisualStyleBackColor = True
        '
        'greetingsLab
        '
        Me.greetingsLab.AutoSize = True
        Me.greetingsLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.greetingsLab.Location = New System.Drawing.Point(292, 132)
        Me.greetingsLab.Name = "greetingsLab"
        Me.greetingsLab.Size = New System.Drawing.Size(153, 25)
        Me.greetingsLab.TabIndex = 7
        Me.greetingsLab.Text = "Hello, someone!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Exercise 4"
        '
        'countryCombo
        '
        Me.countryCombo.FormattingEnabled = True
        Me.countryCombo.Items.AddRange(New Object() {"England", "Poland", "Portugal"})
        Me.countryCombo.Location = New System.Drawing.Point(31, 272)
        Me.countryCombo.Name = "countryCombo"
        Me.countryCombo.Size = New System.Drawing.Size(121, 24)
        Me.countryCombo.TabIndex = 9
        '
        'Radio1
        '
        Me.Radio1.AutoSize = True
        Me.Radio1.Location = New System.Drawing.Point(31, 348)
        Me.Radio1.Name = "Radio1"
        Me.Radio1.Size = New System.Drawing.Size(53, 21)
        Me.Radio1.TabIndex = 10
        Me.Radio1.TabStop = True
        Me.Radio1.Text = "Yes"
        Me.Radio1.UseVisualStyleBackColor = True
        '
        'Radio2
        '
        Me.Radio2.AutoSize = True
        Me.Radio2.Location = New System.Drawing.Point(31, 375)
        Me.Radio2.Name = "Radio2"
        Me.Radio2.Size = New System.Drawing.Size(47, 21)
        Me.Radio2.TabIndex = 11
        Me.Radio2.TabStop = True
        Me.Radio2.Text = "No"
        Me.Radio2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(292, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Exercise 5"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Show results"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'detailsLab
        '
        Me.detailsLab.AutoSize = True
        Me.detailsLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.detailsLab.Location = New System.Drawing.Point(292, 445)
        Me.detailsLab.Name = "detailsLab"
        Me.detailsLab.Size = New System.Drawing.Size(114, 25)
        Me.detailsLab.TabIndex = 14
        Me.detailsLab.Text = "Your details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Show your country?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(582, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(427, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(732, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 29)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Exercise 6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(673, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Zgon, your best place to be!"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(732, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 29)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Exercise 7"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(678, 436)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(232, 48)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Click here to see a secret!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1037, 535)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.detailsLab)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Radio2)
        Me.Controls.Add(Me.Radio1)
        Me.Controls.Add(Me.countryCombo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.greetingsLab)
        Me.Controls.Add(Me.submitBut)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.hello)
        Me.Controls.Add(Me.helloBut)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Exercises for 06.07.21"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents helloBut As Button
    Friend WithEvents hello As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents submitBut As Button
    Friend WithEvents greetingsLab As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents countryCombo As ComboBox
    Friend WithEvents Radio1 As RadioButton
    Friend WithEvents Radio2 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents detailsLab As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
End Class
