<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        RichTextBox1 = New RichTextBox()
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        AbrirToolStripMenuItem = New ToolStripMenuItem()
        NuevoToolStripMenuItem = New ToolStripMenuItem()
        EdicionToolStripMenuItem = New ToolStripMenuItem()
        PegarToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        CortarToolStripMenuItem = New ToolStripMenuItem()
        RehacerToolStripMenuItem = New ToolStripMenuItem()
        DeshacerToolStripMenuItem = New ToolStripMenuItem()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        ColorToolStripMenuItem = New ToolStripMenuItem()
        FuenteToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Location = New Point(0, 0)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(800, 426)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.Bottom
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdicionToolStripMenuItem, FormatoToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 426)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SalirToolStripMenuItem, GuardarToolStripMenuItem, AbrirToolStripMenuItem, NuevoToolStripMenuItem})
        ArchivoToolStripMenuItem.Image = My.Resources.Resources.WhatsApp_Image_2026_09_03_at_12_37_23_AM
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(76, 20)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Image = My.Resources.Resources.salir
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(116, 22)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' GuardarToolStripMenuItem
        ' 
        GuardarToolStripMenuItem.Image = My.Resources.Resources.guardar
        GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        GuardarToolStripMenuItem.Size = New Size(116, 22)
        GuardarToolStripMenuItem.Text = "Guardar"
        ' 
        ' AbrirToolStripMenuItem
        ' 
        AbrirToolStripMenuItem.Image = My.Resources.Resources.abrir
        AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        AbrirToolStripMenuItem.Size = New Size(116, 22)
        AbrirToolStripMenuItem.Text = "Abrir"
        ' 
        ' NuevoToolStripMenuItem
        ' 
        NuevoToolStripMenuItem.Image = My.Resources.Resources.nuevo
        NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        NuevoToolStripMenuItem.Size = New Size(116, 22)
        NuevoToolStripMenuItem.Text = "Nuevo"
        ' 
        ' EdicionToolStripMenuItem
        ' 
        EdicionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PegarToolStripMenuItem, CopiarToolStripMenuItem, CortarToolStripMenuItem, RehacerToolStripMenuItem, DeshacerToolStripMenuItem})
        EdicionToolStripMenuItem.Image = My.Resources.Resources.WhatsApp_Image_2026_09_03_at_12_39_23_AM
        EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        EdicionToolStripMenuItem.Size = New Size(74, 20)
        EdicionToolStripMenuItem.Text = "Edicion"
        ' 
        ' PegarToolStripMenuItem
        ' 
        PegarToolStripMenuItem.Image = My.Resources.Resources.pegar
        PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        PegarToolStripMenuItem.Size = New Size(122, 22)
        PegarToolStripMenuItem.Text = "Pegar"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Image = My.Resources.Resources.copiar
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(122, 22)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' CortarToolStripMenuItem
        ' 
        CortarToolStripMenuItem.Image = My.Resources.Resources.tijeraa
        CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        CortarToolStripMenuItem.Size = New Size(122, 22)
        CortarToolStripMenuItem.Text = "Cortar"
        ' 
        ' RehacerToolStripMenuItem
        ' 
        RehacerToolStripMenuItem.Image = My.Resources.Resources.rehacer
        RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        RehacerToolStripMenuItem.ShowShortcutKeys = False
        RehacerToolStripMenuItem.Size = New Size(122, 22)
        RehacerToolStripMenuItem.Text = "Rehacer"
        ' 
        ' DeshacerToolStripMenuItem
        ' 
        DeshacerToolStripMenuItem.Image = My.Resources.Resources.deshacer
        DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        DeshacerToolStripMenuItem.Size = New Size(122, 22)
        DeshacerToolStripMenuItem.Text = "Deshacer"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ColorToolStripMenuItem, FuenteToolStripMenuItem})
        FormatoToolStripMenuItem.Image = My.Resources.Resources.WhatsApp_Image_2026_09_03_at_12_40_35_AM
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(80, 20)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' ColorToolStripMenuItem
        ' 
        ColorToolStripMenuItem.Image = My.Resources.Resources.WhatsApp_Image_2026_09_03_at_12_45_34_AM
        ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        ColorToolStripMenuItem.Size = New Size(110, 22)
        ColorToolStripMenuItem.Text = "Color"
        ' 
        ' FuenteToolStripMenuItem
        ' 
        FuenteToolStripMenuItem.Image = My.Resources.Resources.WhatsApp_Image_2026_09_03_at_12_43_05_AM
        FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        FuenteToolStripMenuItem.Size = New Size(110, 22)
        FuenteToolStripMenuItem.Text = "Fuente"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Location = New Point(0, 404)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(RichTextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Form2"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
