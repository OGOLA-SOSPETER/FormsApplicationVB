<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formwelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LoadDemoObjectButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoadDemoObjectButton
        '
        Me.LoadDemoObjectButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LoadDemoObjectButton.Location = New System.Drawing.Point(31, 69)
        Me.LoadDemoObjectButton.Name = "LoadDemoObjectButton"
        Me.LoadDemoObjectButton.Size = New System.Drawing.Size(119, 33)
        Me.LoadDemoObjectButton.TabIndex = 0
        Me.LoadDemoObjectButton.Text = "&Load Demo Object"
        Me.LoadDemoObjectButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LoadDemoObjectButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.Location = New System.Drawing.Point(218, 69)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(101, 33)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 178)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LoadDemoObjectButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadDemoObjectButton As Button
    Friend WithEvents ExitButton As Button
End Class
