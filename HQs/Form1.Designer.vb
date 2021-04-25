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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TituloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SagaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PsquisaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.CadastroToolStripMenuItem, Me.TabelaToolStripMenuItem, Me.PsquisaToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EdiçãoToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'TabelaToolStripMenuItem
        '
        Me.TabelaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditoraToolStripMenuItem, Me.TituloToolStripMenuItem, Me.SagaToolStripMenuItem, Me.TipoToolStripMenuItem})
        Me.TabelaToolStripMenuItem.Name = "TabelaToolStripMenuItem"
        Me.TabelaToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.TabelaToolStripMenuItem.Text = "Tabela"
        '
        'EditoraToolStripMenuItem
        '
        Me.EditoraToolStripMenuItem.Name = "EditoraToolStripMenuItem"
        Me.EditoraToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.EditoraToolStripMenuItem.Text = "Editora"
        '
        'TituloToolStripMenuItem
        '
        Me.TituloToolStripMenuItem.Name = "TituloToolStripMenuItem"
        Me.TituloToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.TituloToolStripMenuItem.Text = "Titulo"
        '
        'SagaToolStripMenuItem
        '
        Me.SagaToolStripMenuItem.Name = "SagaToolStripMenuItem"
        Me.SagaToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.SagaToolStripMenuItem.Text = "Saga"
        '
        'TipoToolStripMenuItem
        '
        Me.TipoToolStripMenuItem.Name = "TipoToolStripMenuItem"
        Me.TipoToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.TipoToolStripMenuItem.Text = "Tipo"
        '
        'PsquisaToolStripMenuItem
        '
        Me.PsquisaToolStripMenuItem.Name = "PsquisaToolStripMenuItem"
        Me.PsquisaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PsquisaToolStripMenuItem.Text = "Pesquisa"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'EdiçãoToolStripMenuItem
        '
        Me.EdiçãoToolStripMenuItem.Name = "EdiçãoToolStripMenuItem"
        Me.EdiçãoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EdiçãoToolStripMenuItem.Text = "Edição"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 481)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabelaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PsquisaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TituloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SagaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdiçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
