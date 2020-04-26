<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
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

	'Является обязательной для конструктора форм Windows Forms
	Private components As System.ComponentModel.IContainer

	'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
	'Для ее изменения используйте конструктор форм Windows Form.  
	'Не изменяйте ее в редакторе исходного кода.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PictureBox1.Location = New System.Drawing.Point(179, 29)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(379, 282)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.Button1.Location = New System.Drawing.Point(179, 342)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(113, 50)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Start"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(39, 90)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 2
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(39, 171)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(100, 20)
		Me.TextBox2.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.Label1.Location = New System.Drawing.Point(49, 70)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(80, 17)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Achilles Speed"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.Label2.Location = New System.Drawing.Point(49, 151)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 17)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Turtle Speed"
		'
		'Timer1
		'
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.RadioButton1.Location = New System.Drawing.Point(67, 217)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(62, 21)
		Me.RadioButton1.TabIndex = 7
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "Switch"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.Button2.Location = New System.Drawing.Point(312, 342)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(113, 50)
		Me.Button2.TabIndex = 8
		Me.Button2.Text = "Resume"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button3.Location = New System.Drawing.Point(445, 342)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(113, 50)
		Me.Button3.TabIndex = 9
		Me.Button3.Text = "Stop"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(594, 409)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.RadioButton1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Name = "Form1"
		Me.Text = "Zenon"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
End Class
