<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbIncluir = New System.Windows.Forms.ToolStripButton()
        Me.tsbExcluir = New System.Windows.Forms.ToolStripButton()
        Me.tsbAlterar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalvar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbConsulta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCons_Dependente = New System.Windows.Forms.ToolStripButton()
        Me.tsbSair = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 383)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 22)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(566, 361)
        Me.TextBox1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIncluir, Me.tsbExcluir, Me.tsbAlterar, Me.tsbSalvar, Me.tsbCancelar, Me.tsbConsulta, Me.tsbCons_Dependente, Me.tsbSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(579, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbIncluir
        '
        Me.tsbIncluir.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tsbIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbIncluir.Image = CType(resources.GetObject("tsbIncluir.Image"), System.Drawing.Image)
        Me.tsbIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIncluir.Name = "tsbIncluir"
        Me.tsbIncluir.Size = New System.Drawing.Size(44, 22)
        Me.tsbIncluir.Text = "Incluir"
        '
        'tsbExcluir
        '
        Me.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbExcluir.Image = CType(resources.GetObject("tsbExcluir.Image"), System.Drawing.Image)
        Me.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExcluir.Name = "tsbExcluir"
        Me.tsbExcluir.Size = New System.Drawing.Size(46, 22)
        Me.tsbExcluir.Text = "Excluir"
        '
        'tsbAlterar
        '
        Me.tsbAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAlterar.Image = CType(resources.GetObject("tsbAlterar.Image"), System.Drawing.Image)
        Me.tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAlterar.Name = "tsbAlterar"
        Me.tsbAlterar.Size = New System.Drawing.Size(46, 22)
        Me.tsbAlterar.Text = "Alterar"
        '
        'tsbSalvar
        '
        Me.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSalvar.Image = CType(resources.GetObject("tsbSalvar.Image"), System.Drawing.Image)
        Me.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalvar.Name = "tsbSalvar"
        Me.tsbSalvar.Size = New System.Drawing.Size(42, 22)
        Me.tsbSalvar.Text = "Salvar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(57, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'tsbConsulta
        '
        Me.tsbConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbConsulta.Image = CType(resources.GetObject("tsbConsulta.Image"), System.Drawing.Image)
        Me.tsbConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsulta.Name = "tsbConsulta"
        Me.tsbConsulta.Size = New System.Drawing.Size(58, 22)
        Me.tsbConsulta.Text = "Consulta"
        '
        'tsbCons_Dependente
        '
        Me.tsbCons_Dependente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCons_Dependente.Image = CType(resources.GetObject("tsbCons_Dependente.Image"), System.Drawing.Image)
        Me.tsbCons_Dependente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCons_Dependente.Name = "tsbCons_Dependente"
        Me.tsbCons_Dependente.Size = New System.Drawing.Size(125, 22)
        Me.tsbCons_Dependente.Text = "Consulta Dependente"
        '
        'tsbSair
        '
        Me.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSair.Image = CType(resources.GetObject("tsbSair.Image"), System.Drawing.Image)
        Me.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSair.Name = "tsbSair"
        Me.tsbSair.Size = New System.Drawing.Size(30, 22)
        Me.tsbSair.Text = "Sair"
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbIncluir As ToolStripButton
    Friend WithEvents tsbExcluir As ToolStripButton
    Friend WithEvents tsbAlterar As ToolStripButton
    Friend WithEvents tsbSalvar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents tsbConsulta As ToolStripButton
    Friend WithEvents tsbCons_Dependente As ToolStripButton
    Friend WithEvents tsbSair As ToolStripButton
End Class
