﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSimples
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.TesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro, Me.TesteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuCadastro
        '
        Me.mnuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCliente})
        Me.mnuCadastro.Name = "mnuCadastro"
        Me.mnuCadastro.Size = New System.Drawing.Size(66, 20)
        Me.mnuCadastro.Text = "Cadastro"
        '
        'mnuCliente
        '
        Me.mnuCliente.Name = "mnuCliente"
        Me.mnuCliente.Size = New System.Drawing.Size(180, 22)
        Me.mnuCliente.Text = "Cliente"
        Me.mnuCliente.ToolTipText = "CadastroCliente"
        '
        'TesteToolStripMenuItem
        '
        Me.TesteToolStripMenuItem.Name = "TesteToolStripMenuItem"
        Me.TesteToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.TesteToolStripMenuItem.Text = "teste"
        '
        'FormSimples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormSimples"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Simples"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuCadastro As ToolStripMenuItem
    Friend WithEvents mnuCliente As ToolStripMenuItem
    Friend WithEvents TesteToolStripMenuItem As ToolStripMenuItem
End Class
