Public Class Form1
    Private rutaArchivoActual As String = ""
    Private documentoModificado As Boolean = False

    ' Detectar cuando se modifica el texto
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        documentoModificado = True
        ActualizarEstado()
    End Sub

    ' Función para confirmar guardado si hay cambios pendientes
    Private Function ConfirmarGuardado() As Boolean
        If documentoModificado Then
            Dim respuesta As DialogResult = MessageBox.Show("El documento ha sido modificado. ¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If respuesta = DialogResult.Yes Then
                GuardarToolStripMenuItem_Click(Nothing, Nothing)
                Return Not documentoModificado
            ElseIf respuesta = DialogResult.No Then
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function

    ' Archivo -> Nuevo
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        If ConfirmarGuardado() Then
            RichTextBox1.Clear()
            rutaArchivoActual = ""
            documentoModificado = False
        End If
    End Sub

    ' Archivo -> Abrir
    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        If ConfirmarGuardado() Then
            OpenFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    RichTextBox1.Text = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
                    rutaArchivoActual = OpenFileDialog1.FileName
                    documentoModificado = False
                Catch ex As Exception
                    MessageBox.Show("Error al abrir el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    ' Archivo -> Guardar
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If String.IsNullOrEmpty(rutaArchivoActual) Then
            GuardarComoToolStripMenuItem_Click(sender, e)
        Else
            Try
                System.IO.File.WriteAllText(rutaArchivoActual, RichTextBox1.Text)
                documentoModificado = False
            Catch ex As Exception
                MessageBox.Show("Error al guardar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Archivo -> Guardar como
    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                System.IO.File.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text)
                rutaArchivoActual = SaveFileDialog1.FileName
                documentoModificado = False
            Catch ex As Exception
                MessageBox.Show("Error al guardar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Archivo -> Salir
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Interceptar el cierre del formulario
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmarGuardado() Then
            e.Cancel = True
        End If
    End Sub
    ' Actualizar contador de palabras y caracteres en la barra de estado
    Private Sub ActualizarEstado()
        Dim texto As String = RichTextBox1.Text.Trim()
        Dim numCaracteres As Integer = RichTextBox1.Text.Length
        Dim numPalabras As Integer = 0

        If Not String.IsNullOrEmpty(texto) Then
            Dim palabras() As String = texto.Split(New Char() {" "c, ControlChars.Lf, ControlChars.Cr, ControlChars.Tab}, StringSplitOptions.RemoveEmptyEntries)
            numPalabras = palabras.Length
        End If

        ' Mostrar datos en la barra de estado
        StatusStrip1.Items.Clear()
        StatusStrip1.Items.Add($"Caracteres: {numCaracteres} | Palabras: {numPalabras}")
    End Sub

    ' Herramientas -> Contar
    Private Sub ContarPalabrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContarPalabrasToolStripMenuItem.Click, ContarCaracteresToolStripMenuItem.Click
        Dim texto As String = RichTextBox1.Text.Trim()
        Dim numCaracteres As Integer = RichTextBox1.Text.Length
        Dim numPalabras As Integer = If(String.IsNullOrEmpty(texto), 0, texto.Split(New Char() {" "c, ControlChars.Lf, ControlChars.Cr, ControlChars.Tab}, StringSplitOptions.RemoveEmptyEntries).Length)

        MessageBox.Show($"Estadísticas del documento:" & vbCrLf & $"Palabras: {numPalabras}" & vbCrLf & $"Caracteres: {numCaracteres}", "Contador", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Herramientas -> Buscar
    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Dim palabra As String = InputBox("Ingrese el texto que desea buscar:", "Buscar texto")
        If Not String.IsNullOrEmpty(palabra) Then
            Dim inicio As Integer = RichTextBox1.Find(palabra)
            If inicio <> -1 Then
                RichTextBox1.Select(inicio, palabra.Length)
                RichTextBox1.Focus()
            Else
                MessageBox.Show("No se encontró el texto buscado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    ' Ayuda -> Acerca de
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MessageBox.Show("TextEdit VB v1.0" & vbCrLf & "Desarrollado para la asignatura Programación de Aplicaciones de Escritorio.", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        If RichTextBox1.CanUndo Then RichTextBox1.Undo()
    End Sub

    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
        If RichTextBox1.CanRedo Then RichTextBox1.Redo()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuenteToolStripMenuItem.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub TextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub
End Class