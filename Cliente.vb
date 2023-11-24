Imports System.Data.SqlClient

Public Class Cliente
#Region "Propriedades"
    Public Property BancoDados As String
#End Region

#Region "Funcoes"
    Public Function NovoCliente(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As Boolean
        Dim retorno As Boolean = True
        Dim banco As New DataAccess

        Try
            retorno = banco.ExecuteQuery(SQL, parametros)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try
        Return retorno
    End Function

    Public Function AlterarCliente(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As Boolean
        Dim retorno As Boolean = True
        Dim banco As New DataAccess

        Try
            retorno = banco.ExecuteQuery(SQL, parametros)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try
        Return retorno
    End Function

    Public Function ExcluirCliente(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As Boolean
        Dim retorno As Boolean = True
        Dim banco As New DataAccess

        Try
            retorno = banco.ExecuteQuery(SQL, parametros)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try
        Return retorno
    End Function


    Public Function ConsultaDataSet(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As DataSet
        Dim ds As DataSet
        Dim banco As New DataAccess

        Try
            ds = banco.ExecuteDataSet(SQL, parametros)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try
        Return ds
    End Function
#End Region


End Class
