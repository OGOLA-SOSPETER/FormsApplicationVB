Public Class FormDemo
    Private Sub MagnetoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetoRadioButton.CheckedChanged
        If MagnetoRadioButton.Checked = True Then
            SampleTextBox.Font = New Font("Magneto", SampleTextBox.Font.Size, SampleTextBox.Font.Style)
        End If
    End Sub

    Private Sub TahomaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TahomaRadioButton.CheckedChanged
        If TahomaRadioButton.Checked = True Then
            SampleTextBox.Font = New Font("Tahoma", SampleTextBox.Font.Size, SampleTextBox.Font.Style)
        End If

    End Sub

    Private Sub GaramondRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GaramondRadioButton.CheckedChanged
        If GaramondRadioButton.Checked = True Then
            SampleTextBox.Font = New Font("Garamond", SampleTextBox.Font.Size, SampleTextBox.Font.Style)
        End If
    End Sub

    Private Sub BoldItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldItalicCheckBox.CheckedChanged
        If BoldItalicCheckBox.Checked = True Then
            SampleTextBox.Font = New Font(SampleTextBox.Font, SampleTextBox.Font.Style Or FontStyle.Bold + FontStyle.Italic)
        Else
            SampleTextBox.Font = New Font(SampleTextBox.Font, SampleTextBox.Font.Style And Not FontStyle.Bold + FontStyle.Italic)
        End If
    End Sub

    Private Sub BoldCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldCheckBox.CheckedChanged
        If BoldCheckBox.Checked = True Then
            SampleTextBox.Font = New Font(SampleTextBox.Font, SampleTextBox.Font.Style Or FontStyle.Bold)
        Else
            SampleTextBox.Font = New Font(SampleTextBox.Font, SampleTextBox.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub ItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicCheckBox.CheckedChanged
        If ItalicCheckBox.Checked = True Then
            SampleTextBox.Font = New Font(SampleTextBox.Font, SampleTextBox.Font.Style Or FontStyle.Italic)
        Else
            SampleTextBox.Font = New Font(SampleTextBox.Font, SampleTextBox.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub FormDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Formwelcome.Show()
        Me.Hide()

    End Sub
End Class