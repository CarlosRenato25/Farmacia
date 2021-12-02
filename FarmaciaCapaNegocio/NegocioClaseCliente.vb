Imports System.Data.SqlClient
Imports FarmaciaCapaDatos
Public Class NegocioClaseCliente
    Public Function NegClientesInsertar(ncodigoclientes As String, nnombre As String, tipoDocuemento As String, numerodocumento As String, ntelefono As String, ndireccion As String, nfechaNacimiento As String, nsexo As String, ncodigoAdministrador As String, nestado As String) As Boolean

        Dim nClaseClientes As New FarmaciaCapaDatos.ClaseClientes(ncodigoclientes, nnombre, tipoDocuemento, numerodocumento, ntelefono, ndireccion, nfechaNacimiento, nsexo, ncodigoAdministrador, nestado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseClientes.ClientesInsertar(nClaseClientes) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function NegClientesEditar(ncodigoclientes As String, nnombre As String, tipoDocumento As String, numeroDocumento As String, ntelefono As String, ndireccion As String, nfechaNacimiento As String, nsexo As String, ncodigoAdministrador As String, nestado As String) As Boolean

        Dim nClaseClientes As New FarmaciaCapaDatos.ClaseClientes(ncodigoclientes, nnombre, tipoDocumento, numeroDocumento, ntelefono, ndireccion, nfechaNacimiento, nsexo, ncodigoAdministrador, nestado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseClientes.ClientesEditar(nClaseClientes) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function NegClientesEliminar(ncodigoclientes As String, nnombre As String, tipoDocumento As String, numeroDocumento As String, ntelefono As String, ndireccion As String, nfechaNacimiento As String, nsexo As String, ncodigoAdministrador As String, nestado As String) As Boolean

        Dim nClaseClientes As New FarmaciaCapaDatos.ClaseClientes(ncodigoclientes, nnombre, tipoDocumento, numeroDocumento, ntelefono, ndireccion, nfechaNacimiento, nsexo, ncodigoAdministrador, nestado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseClientes.ClientesEliminar(nClaseClientes) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CreaTableAClientes() As DataTable
        Dim nClaseclientes As New ClaseClientes
        Return nClaseclientes.clientesListados()
    End Function
    Public Function CreaTableAdministrador() As DataTable
        Dim nClaseclientes As New ClaseClientes
        Return nClaseclientes.administradorlistados()
    End Function

End Class
