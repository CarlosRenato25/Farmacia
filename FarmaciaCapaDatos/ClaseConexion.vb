Imports System.Data.SqlClient

Public Class ClaseConexion
    Public cn As SqlConnection
    Public transaction As SqlTransaction
    Public ccadena = "Data Source=DESKTOP-P623U4M\SQLEXPRESS;Initial Catalog=Farmacia;Integrated Security=True"

    Public Sub AbrirConexion()
        cn = New SqlConnection(ccadena)
        cn.Open()
    End Sub

    Public Sub CerrarConexion()
        cn.Close()
    End Sub

    Public Sub IniciarTransaccion()
        transaction = cn.BeginTransaction
    End Sub

    Public Sub EjecutarTransaccion()
        transaction.Commit()
        transaction = Nothing
    End Sub

    Public Sub CancelarTransaccion()
        transaction.Rollback()
        transaction = Nothing
    End Sub

End Class
