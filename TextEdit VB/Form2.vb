Public Class Form2
    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Archivos de texto (*.txt)|*.txt"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(saveDialog.FileName, RichTextBox1.Text, False)
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If openDialog.ShowDialog() = DialogResult.OK Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(openDialog.FileName)
        End If
    End Sub
End Class