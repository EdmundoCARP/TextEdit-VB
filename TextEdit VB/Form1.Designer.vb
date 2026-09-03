<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        NuevoToolStripMenuItem = New ToolStripMenuItem()
        AbrirToolStripMenuItem = New ToolStripMenuItem()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        GuardarComoToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        EdicionToolStripMenuItem = New ToolStripMenuItem()
        DeshacerToolStripMenuItem = New ToolStripMenuItem()
        RehacerToolStripMenuItem = New ToolStripMenuItem()
        CortarToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        PegarToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarTodoToolStripMenuItem = New ToolStripMenuItem()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        FuenteToolStripMenuItem = New ToolStripMenuItem()
        TextoToolStripMenuItem = New ToolStripMenuItem()
        HerramientasToolStripMenuItem = New ToolStripMenuItem()
        ContarPalabrasToolStripMenuItem = New ToolStripMenuItem()
        ContarCaracteresToolStripMenuItem = New ToolStripMenuItem()
        BuscarToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        RichTextBox1 = New RichTextBox()
        OpenFileDialog1 = New OpenFileDialog()
        FontDialog1 = New FontDialog()
        FontDialog2 = New FontDialog()
        ColorDialog1 = New ColorDialog()
        SaveFileDialog1 = New SaveFileDialog()
        HoraYFechaToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdicionToolStripMenuItem, FormatoToolStripMenuItem, HerramientasToolStripMenuItem, AyudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NuevoToolStripMenuItem, AbrirToolStripMenuItem, GuardarToolStripMenuItem, GuardarComoToolStripMenuItem, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(60, 20)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' NuevoToolStripMenuItem
        ' 
        NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), Image)
        NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        NuevoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NuevoToolStripMenuItem.Size = New Size(190, 22)
        NuevoToolStripMenuItem.Text = "Nuevo"
        ' 
        ' AbrirToolStripMenuItem
        ' 
        AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        AbrirToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        AbrirToolStripMenuItem.Size = New Size(180, 22)
        AbrirToolStripMenuItem.Text = "Abrir"
        ' 
        ' GuardarToolStripMenuItem
        ' 
        GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        GuardarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.G
        GuardarToolStripMenuItem.Size = New Size(190, 22)
        GuardarToolStripMenuItem.Text = "Guardar"
        ' 
        ' GuardarComoToolStripMenuItem
        ' 
        GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        GuardarComoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        GuardarComoToolStripMenuItem.Size = New Size(190, 22)
        GuardarComoToolStripMenuItem.Text = "Guardar como"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        SalirToolStripMenuItem.Size = New Size(190, 22)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' EdicionToolStripMenuItem
        ' 
        EdicionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DeshacerToolStripMenuItem, RehacerToolStripMenuItem, CortarToolStripMenuItem, CopiarToolStripMenuItem, PegarToolStripMenuItem, SeleccionarTodoToolStripMenuItem})
        EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        EdicionToolStripMenuItem.Size = New Size(58, 20)
        EdicionToolStripMenuItem.Text = "Edicion"
        ' 
        ' DeshacerToolStripMenuItem
        ' 
        DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        DeshacerToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        DeshacerToolStripMenuItem.Size = New Size(204, 22)
        DeshacerToolStripMenuItem.Text = "Deshacer"
        ' 
        ' RehacerToolStripMenuItem
        ' 
        RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        RehacerToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Y
        RehacerToolStripMenuItem.Size = New Size(204, 22)
        RehacerToolStripMenuItem.Text = "Rehacer"
        ' 
        ' CortarToolStripMenuItem
        ' 
        CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        CortarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        CortarToolStripMenuItem.Size = New Size(204, 22)
        CortarToolStripMenuItem.Text = "Cortar"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopiarToolStripMenuItem.Size = New Size(204, 22)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' PegarToolStripMenuItem
        ' 
        PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        PegarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        PegarToolStripMenuItem.Size = New Size(204, 22)
        PegarToolStripMenuItem.Text = "Pegar"
        ' 
        ' SeleccionarTodoToolStripMenuItem
        ' 
        SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        SeleccionarTodoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        SeleccionarTodoToolStripMenuItem.Size = New Size(204, 22)
        SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FuenteToolStripMenuItem, TextoToolStripMenuItem})
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(64, 20)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' FuenteToolStripMenuItem
        ' 
        FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        FuenteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F
        FuenteToolStripMenuItem.Size = New Size(180, 22)
        FuenteToolStripMenuItem.Text = "Fuente"
        ' 
        ' TextoToolStripMenuItem
        ' 
        TextoToolStripMenuItem.Name = "TextoToolStripMenuItem"
        TextoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.E
        TextoToolStripMenuItem.Size = New Size(180, 22)
        TextoToolStripMenuItem.Text = "Texto"
        ' 
        ' HerramientasToolStripMenuItem
        ' 
        HerramientasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ContarPalabrasToolStripMenuItem, ContarCaracteresToolStripMenuItem, BuscarToolStripMenuItem, HoraYFechaToolStripMenuItem})
        HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        HerramientasToolStripMenuItem.Size = New Size(90, 20)
        HerramientasToolStripMenuItem.Text = "Herramientas"
        ' 
        ' ContarPalabrasToolStripMenuItem
        ' 
        ContarPalabrasToolStripMenuItem.Name = "ContarPalabrasToolStripMenuItem"
        ContarPalabrasToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.W
        ContarPalabrasToolStripMenuItem.Size = New Size(208, 22)
        ContarPalabrasToolStripMenuItem.Text = "Contar palabras"
        ' 
        ' ContarCaracteresToolStripMenuItem
        ' 
        ContarCaracteresToolStripMenuItem.Name = "ContarCaracteresToolStripMenuItem"
        ContarCaracteresToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.U
        ContarCaracteresToolStripMenuItem.Size = New Size(208, 22)
        ContarCaracteresToolStripMenuItem.Text = "Contar caracteres"
        ' 
        ' BuscarToolStripMenuItem
        ' 
        BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        BuscarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.B
        BuscarToolStripMenuItem.Size = New Size(180, 22)
        BuscarToolStripMenuItem.Text = "Buscar"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AcercaDeToolStripMenuItem})
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(53, 20)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.ShortcutKeys = Keys.Shift Or Keys.F1
        AcercaDeToolStripMenuItem.Size = New Size(215, 22)
        AcercaDeToolStripMenuItem.Text = "Acerca de"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Location = New Point(0, 24)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(800, 404)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = ""
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' HoraYFechaToolStripMenuItem
        ' 
        HoraYFechaToolStripMenuItem.Name = "HoraYFechaToolStripMenuItem"
        HoraYFechaToolStripMenuItem.Size = New Size(208, 22)
        HoraYFechaToolStripMenuItem.Text = "Hora y fecha"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents FontDialog2 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContarPalabrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContarCaracteresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoraYFechaToolStripMenuItem As ToolStripMenuItem

End Class
