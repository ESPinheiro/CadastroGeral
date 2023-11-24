Imports DBOCadastro
Imports System.Data.SqlClient


Public Class FormSimples
    Private cadastro As Cadastro = Nothing

    Private Sub mnuCliente_Click(sender As Object, e As EventArgs) Handles mnuCliente.Click
        If cadastro Is Nothing Then
            cadastro = New Cadastro
            cadastro.Show()
        Else
            If cadastro.IsHandleCreated = True Then
                cadastro.Focus()
            Else
                cadastro = New Cadastro
                cadastro.Show()

            End If
        End If

    End Sub
    'botão teste para se comunicar com banco de dados depois que estiver criado o bd sql server '
    Private Sub TesteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TesteToolStripMenuItem.Click
        Dim cliente As New Cliente
        Dim par As New List(Of SqlParameter)

        '''par.Add(New SqlParameter("@ Cadastro", "Novo Cliente "))'''

        '''Dim SQL As String = "INSERT INTO CLIENTE (Cadastro)VALUES(Novo Cliente)"'''

        '''cliente.NovoCliente(SQL, par) '''

        par.Add(New SqlParameter("@ Cadastro", "A "))
        Dim SQL As String = "SELECT * FROM Cliente WHERE Cadastro Like '%' + @Cadastro + '%'"
        Dim ds As DataSet = cliente.ConsultaDataSet(SQL, par)
        'dgvDados.DataSource = ds.Tables(0)
    End Sub

End Class
