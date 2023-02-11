<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDemo
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
        Me.DisplayTextGroupBox = New System.Windows.Forms.GroupBox()
        Me.SampleTextBox = New System.Windows.Forms.TextBox()
        Me.FontGroupBox = New System.Windows.Forms.GroupBox()
        Me.GaramondRadioButton = New System.Windows.Forms.RadioButton()
        Me.MagnetoRadioButton = New System.Windows.Forms.RadioButton()
        Me.TahomaRadioButton = New System.Windows.Forms.RadioButton()
        Me.FontStyleGroupBox = New System.Windows.Forms.GroupBox()
        Me.ItalicCheckBox = New System.Windows.Forms.CheckBox()
        Me.BoldCheckBox = New System.Windows.Forms.CheckBox()
        Me.BoldItalicCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GreenRadioButton = New System.Windows.Forms.RadioButton()
        Me.BlueRadioButton = New System.Windows.Forms.RadioButton()
        Me.RedRadioButton = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplayTextGroupBox.SuspendLayout()
        Me.FontGroupBox.SuspendLayout()
        Me.FontStyleGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DisplayTextGroupBox
        '
        Me.DisplayTextGroupBox.Controls.Add(Me.SampleTextBox)
        Me.DisplayTextGroupBox.Location = New System.Drawing.Point(29, 26)
        Me.DisplayTextGroupBox.Name = "DisplayTextGroupBox"
        Me.DisplayTextGroupBox.Size = New System.Drawing.Size(140, 51)
        Me.DisplayTextGroupBox.TabIndex = 0
        Me.DisplayTextGroupBox.TabStop = False
        Me.DisplayTextGroupBox.Text = "Display Text"
        '
        'SampleTextBox
        '
        Me.SampleTextBox.Location = New System.Drawing.Point(6, 18)
        Me.SampleTextBox.Name = "SampleTextBox"
        Me.SampleTextBox.Size = New System.Drawing.Size(106, 23)
        Me.SampleTextBox.TabIndex = 1
        Me.SampleTextBox.Text = "Sample Text"
        '
        'FontGroupBox
        '
        Me.FontGroupBox.Controls.Add(Me.TahomaRadioButton)
        Me.FontGroupBox.Controls.Add(Me.MagnetoRadioButton)
        Me.FontGroupBox.Controls.Add(Me.GaramondRadioButton)
        Me.FontGroupBox.Location = New System.Drawing.Point(284, 26)
        Me.FontGroupBox.Name = "FontGroupBox"
        Me.FontGroupBox.Size = New System.Drawing.Size(365, 51)
        Me.FontGroupBox.TabIndex = 2
        Me.FontGroupBox.TabStop = False
        Me.FontGroupBox.Text = "Font         "
        '
        'GaramondRadioButton
        '
        Me.GaramondRadioButton.AutoSize = True
        Me.GaramondRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.GaramondRadioButton.Name = "GaramondRadioButton"
        Me.GaramondRadioButton.Size = New System.Drawing.Size(81, 19)
        Me.GaramondRadioButton.TabIndex = 3
        Me.GaramondRadioButton.TabStop = True
        Me.GaramondRadioButton.Text = "Garamond"
        Me.GaramondRadioButton.UseVisualStyleBackColor = True
        '
        'MagnetoRadioButton
        '
        Me.MagnetoRadioButton.AutoSize = True
        Me.MagnetoRadioButton.Location = New System.Drawing.Point(132, 19)
        Me.MagnetoRadioButton.Name = "MagnetoRadioButton"
        Me.MagnetoRadioButton.Size = New System.Drawing.Size(73, 19)
        Me.MagnetoRadioButton.TabIndex = 4
        Me.MagnetoRadioButton.TabStop = True
        Me.MagnetoRadioButton.Text = "Magneto"
        Me.MagnetoRadioButton.UseVisualStyleBackColor = True
        '
        'TahomaRadioButton
        '
        Me.TahomaRadioButton.AutoSize = True
        Me.TahomaRadioButton.Location = New System.Drawing.Point(254, 19)
        Me.TahomaRadioButton.Name = "TahomaRadioButton"
        Me.TahomaRadioButton.Size = New System.Drawing.Size(67, 19)
        Me.TahomaRadioButton.TabIndex = 5
        Me.TahomaRadioButton.TabStop = True
        Me.TahomaRadioButton.Text = "Tahoma"
        Me.TahomaRadioButton.UseVisualStyleBackColor = True
        '
        'FontStyleGroupBox
        '
        Me.FontStyleGroupBox.Controls.Add(Me.BoldItalicCheckBox)
        Me.FontStyleGroupBox.Controls.Add(Me.BoldCheckBox)
        Me.FontStyleGroupBox.Controls.Add(Me.ItalicCheckBox)
        Me.FontStyleGroupBox.Location = New System.Drawing.Point(284, 105)
        Me.FontStyleGroupBox.Name = "FontStyleGroupBox"
        Me.FontStyleGroupBox.Size = New System.Drawing.Size(140, 158)
        Me.FontStyleGroupBox.TabIndex = 2
        Me.FontStyleGroupBox.TabStop = False
        Me.FontStyleGroupBox.Text = "Font Style  "
        '
        'ItalicCheckBox
        '
        Me.ItalicCheckBox.AutoSize = True
        Me.ItalicCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.ItalicCheckBox.Location = New System.Drawing.Point(10, 22)
        Me.ItalicCheckBox.Name = "ItalicCheckBox"
        Me.ItalicCheckBox.Size = New System.Drawing.Size(75, 19)
        Me.ItalicCheckBox.TabIndex = 0
        Me.ItalicCheckBox.Text = "        Italic"
        Me.ItalicCheckBox.UseVisualStyleBackColor = True
        '
        'BoldCheckBox
        '
        Me.BoldCheckBox.AutoSize = True
        Me.BoldCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BoldCheckBox.Location = New System.Drawing.Point(10, 64)
        Me.BoldCheckBox.Name = "BoldCheckBox"
        Me.BoldCheckBox.Size = New System.Drawing.Size(75, 19)
        Me.BoldCheckBox.TabIndex = 1
        Me.BoldCheckBox.Text = "        Bold"
        Me.BoldCheckBox.UseVisualStyleBackColor = True
        '
        'BoldItalicCheckBox
        '
        Me.BoldItalicCheckBox.AutoSize = True
        Me.BoldItalicCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BoldItalicCheckBox.Location = New System.Drawing.Point(10, 112)
        Me.BoldItalicCheckBox.Name = "BoldItalicCheckBox"
        Me.BoldItalicCheckBox.Size = New System.Drawing.Size(109, 19)
        Me.BoldItalicCheckBox.TabIndex = 2
        Me.BoldItalicCheckBox.Text = "        Bold Italic"
        Me.BoldItalicCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RedRadioButton)
        Me.GroupBox1.Controls.Add(Me.BlueRadioButton)
        Me.GroupBox1.Controls.Add(Me.GreenRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(446, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 158)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Font Style  "
        '
        'GreenRadioButton
        '
        Me.GreenRadioButton.AutoSize = True
        Me.GreenRadioButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GreenRadioButton.Location = New System.Drawing.Point(16, 22)
        Me.GreenRadioButton.Name = "GreenRadioButton"
        Me.GreenRadioButton.Size = New System.Drawing.Size(60, 19)
        Me.GreenRadioButton.TabIndex = 6
        Me.GreenRadioButton.TabStop = True
        Me.GreenRadioButton.Text = "&Green"
        Me.GreenRadioButton.UseVisualStyleBackColor = True
        '
        'BlueRadioButton
        '
        Me.BlueRadioButton.AutoSize = True
        Me.BlueRadioButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BlueRadioButton.Location = New System.Drawing.Point(16, 64)
        Me.BlueRadioButton.Name = "BlueRadioButton"
        Me.BlueRadioButton.Size = New System.Drawing.Size(50, 19)
        Me.BlueRadioButton.TabIndex = 7
        Me.BlueRadioButton.TabStop = True
        Me.BlueRadioButton.Text = "&Blue"
        Me.BlueRadioButton.UseVisualStyleBackColor = True
        '
        'RedRadioButton
        '
        Me.RedRadioButton.AutoSize = True
        Me.RedRadioButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RedRadioButton.Location = New System.Drawing.Point(16, 111)
        Me.RedRadioButton.Name = "RedRadioButton"
        Me.RedRadioButton.Size = New System.Drawing.Size(47, 19)
        Me.RedRadioButton.TabIndex = 8
        Me.RedRadioButton.TabStop = True
        Me.RedRadioButton.Text = "&Red"
        Me.RedRadioButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(29, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 201)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(50, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&Load Picture"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.Location = New System.Drawing.Point(370, 333)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(68, 33)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FormDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 416)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FontStyleGroupBox)
        Me.Controls.Add(Me.FontGroupBox)
        Me.Controls.Add(Me.DisplayTextGroupBox)
        Me.Name = "FormDemo"
        Me.Text = "FormDemo"
        Me.DisplayTextGroupBox.ResumeLayout(False)
        Me.DisplayTextGroupBox.PerformLayout()
        Me.FontGroupBox.ResumeLayout(False)
        Me.FontGroupBox.PerformLayout()
        Me.FontStyleGroupBox.ResumeLayout(False)
        Me.FontStyleGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisplayTextGroupBox As GroupBox
    Friend WithEvents SampleTextBox As TextBox
    Friend WithEvents FontGroupBox As GroupBox
    Friend WithEvents TahomaRadioButton As RadioButton
    Friend WithEvents MagnetoRadioButton As RadioButton
    Friend WithEvents GaramondRadioButton As RadioButton
    Friend WithEvents FontStyleGroupBox As GroupBox
    Friend WithEvents BoldItalicCheckBox As CheckBox
    Friend WithEvents BoldCheckBox As CheckBox
    Friend WithEvents ItalicCheckBox As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ExitButton As Button
End Class
