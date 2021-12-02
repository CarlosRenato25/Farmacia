
Imports System.Data.SqlClient
Imports FarmaciaCapaDatos
Public Class NegocioClaseAdministradora
    Public Function NegAdministradoraInsertar(nAdministradoraCodigo As String, nAdministradoraNombre As String, nAdministradoraApellidos As String, nSexo As String, nruc As String, ntelefono As String, ndni As String, ndireccion As String,
                             nfechanacimiento As Date, nfechaentrada As Date, nfoto() As Byte, nestado As String) As Boolean

        Dim nClaseAdministrador As New FarmaciaCapaDatos.ClaseAdministradora(nAdministradoraCodigo, nAdministradoraNombre, nAdministradoraApellidos, nSexo, nruc, ntelefono, ndni, ndireccion, nfechanacimiento, nfechaentrada, nfoto, nestado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseAdministrador.administradoraInsertar(nClaseAdministrador) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function NegAdministradorEditar(nAdministradoraCodigo As String, nAdministradoraNombre As String, nAdministradoraApellidos As String, nSexo As String, nruc As String, ntelefono As String, ndni As String, ndireccion As String,
                             nfechanacimiento As Date, nfechaentrada As Date, nfoto() As Byte, nestado As String) As Boolean

        Dim nClaseCategoria As New FarmaciaCapaDatos.ClaseAdministradora(nAdministradoraCodigo, nAdministradoraNombre, nAdministradoraApellidos, nSexo, nruc, ntelefono, ndni, ndireccion, nfechanacimiento, nfechaentrada, nfoto, nestado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseCategoria.administradoraEditar(nClaseCategoria) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function NegAdministradoraEliminar(nAdministradoraCodigo As String, nAdministradoraNombre As String, nAdministradoraApellidos As String, nSexo As String, nruc As String, ntelefono As String, ndni As String, ndireccion As String,
                             nfechanacimiento As Date, nfechaentrada As Date, nfoto() As Byte, nestado As String) As Boolean

        Dim nClaseCategorias As New FarmaciaCapaDatos.ClaseAdministradora(nAdministradoraCodigo, nAdministradoraNombre, nAdministradoraApellidos, nSexo, nruc, ntelefono, ndni, ndireccion, nfechanacimiento, nfechaentrada, nfoto, nestado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseCategorias.AdministradoraEliminar(nClaseCategorias) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CreaTableAdministrador() As DataTable
        Dim nClasecategorias As New ClaseAdministradora
        Return nClasecategorias.administradorListados()
    End Function
End Class
