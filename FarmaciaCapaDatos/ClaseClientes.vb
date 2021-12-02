Imports System.Data.SqlClient
Imports System.Data
Imports FarmaciaCapaDatos

Public Class ClaseClientes
    Private clasecon As New ClaseConexion
    Private _codigo As String
    Private _nombre As String
    Private _TipoDocumento As String
    Private _NumeroDocumento As String
    Private _telefono As String
    Private _direccion As String
    Private _fechaNacimiento As String
    Private _sexo As String
    Private _codigoAdministrador As String
    Private _estado As String


    Public Sub New()
    End Sub

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property


    Public Property TipoDocumento As String
        Get
            Return _TipoDocumento
        End Get
        Set(value As String)
            _TipoDocumento = value
        End Set
    End Property

    Public Property NumeroDocumento As String
        Get
            Return _NumeroDocumento
        End Get
        Set(value As String)
            _NumeroDocumento = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property FechaNacimiento As String
        Get
            Return _fechaNacimiento
        End Get
        Set(value As String)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property

    Public Property CodigoAdministrador As String
        Get
            Return _codigoAdministrador
        End Get
        Set(value As String)
            _codigoAdministrador = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Sub New(codigo As String, nombre As String, tipoDocumento As String, NumeroDocumento As String, telefono As String, direccion As String, fechaNacimiento As String, sexo As String, codigoAdministrador As String, estado As String)
        Me.New(codigo)
        Me.Nombre = nombre
        Me.TipoDocumento = tipoDocumento
        Me.NumeroDocumento = NumeroDocumento
        Me.Telefono = telefono
        Me.Direccion = direccion
        Me.FechaNacimiento = fechaNacimiento
        Me.Sexo = sexo
        Me.CodigoAdministrador = codigoAdministrador
        Me.Estado = estado
    End Sub
    Private Sub New(vClienteCodigo As String)
        Me.Codigo = vClienteCodigo
    End Sub
    Public Function clientesListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim daClientes As New SqlDataAdapter("spClienteslistados", cn)
        Dim dtClientes As New DataTable("Cliente")
        daClientes.Fill(dtClientes)
        Return dtClientes
    End Function
    Public Function administradorlistados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim daAdministrador As New SqlDataAdapter("spClientesListadoAdministradores", cn)
        Dim dtAdministradora As New DataTable("Administradora")
        daAdministrador.Fill(dtAdministradora)
        Return dtAdministradora
    End Function

    Public Function ClientesInsertar(cClaseClientes As ClaseClientes) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim coClientesInsertar As New SqlCommand("spClientesInsertar", cn)
        coClientesInsertar.CommandType = CommandType.StoredProcedure

        coClientesInsertar.Parameters.Add(New SqlParameter("@ClienteNombre", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cClaseClientes.Nombre
        coClientesInsertar.Parameters.Add(New SqlParameter("@ClienteTipoDocumento", SqlDbType.NVarChar, 20, ParameterDirection.Input)).Value = cClaseClientes.TipoDocumento
        coClientesInsertar.Parameters.Add(New SqlParameter("@ClienteTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = cClaseClientes.Telefono
        coClientesInsertar.Parameters.Add(New SqlParameter("@ClienteNumeroDocumento", SqlDbType.NVarChar, 15, ParameterDirection.Input)).Value = cClaseClientes.NumeroDocumento
        coClientesInsertar.Parameters.Add(New SqlParameter("@ClienteDireccion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseClientes.Direccion
        coClientesInsertar.Parameters.Add(New SqlParameter("@ClienteAdministradorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cClaseClientes.CodigoAdministrador
        If cClaseClientes.FechaNacimiento = "" Then
            coClientesInsertar.Parameters.Add(New SqlParameter("@ClienteFechaDeNacimiento", SqlDbType.Date)).Value = DBNull.Value
        Else
            coClientesInsertar.Parameters.Add(New SqlParameter("@ClienteFechaDeNacimiento", SqlDbType.Date)).Value = cClaseClientes.FechaNacimiento
        End If
        coClientesInsertar.Parameters.Add(New SqlParameter("@ClienteSexo", SqlDbType.NChar, 1)).Value = cClaseClientes.Sexo
        coClientesInsertar.Parameters.Add(New SqlParameter("@ClienteEstado", SqlDbType.NChar, 1, ParameterDirection.Input)).Value = "A"

        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            coClientesInsertar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function
    Public Function ClientesEditar(cClaseClientes As ClaseClientes) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim coClientesEditar As New SqlCommand("spClienteModificar", cn)
        coClientesEditar.CommandType = CommandType.StoredProcedure
        coClientesEditar.Parameters.Add(New SqlParameter("@ClienteCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cClaseClientes.Codigo
        coClientesEditar.Parameters.Add(New SqlParameter("@ClienteNombre", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cClaseClientes.Nombre
        coClientesEditar.Parameters.Add(New SqlParameter("@ClienteTipoDocumento", SqlDbType.NVarChar, 20, ParameterDirection.Input)).Value = cClaseClientes.TipoDocumento
        coClientesEditar.Parameters.Add(New SqlParameter("@ClienteTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = cClaseClientes.Telefono
        coClientesEditar.Parameters.Add(New SqlParameter("@ClienteNumeroDocumento", SqlDbType.NVarChar, 15, ParameterDirection.Input)).Value = cClaseClientes.NumeroDocumento
        coClientesEditar.Parameters.Add(New SqlParameter("@ClienteDireccion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseClientes.Direccion
        coClientesEditar.Parameters.Add(New SqlParameter("@ClienteAdministradorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cClaseClientes.CodigoAdministrador
        If cClaseClientes.FechaNacimiento = "" Then
            coClientesEditar.Parameters.Add(New SqlParameter("@ClienteFechaDeNacimiento", SqlDbType.Date)).Value = DBNull.Value
        Else
            coClientesEditar.Parameters.Add(New SqlParameter("@ClienteFechaDeNacimiento", SqlDbType.Date)).Value = cClaseClientes.FechaNacimiento
        End If

        coClientesEditar.Parameters.Add(New SqlParameter("@ClienteSexo", SqlDbType.NChar, 1)).Value = cClaseClientes.Sexo

        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            coClientesEditar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function
    Public Function ClientesEliminar(cClaseClientes As ClaseClientes) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        'SP:
        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim coClientesEliminar As New SqlCommand("spEliminarClientes", cn)
        coClientesEliminar.CommandType = CommandType.StoredProcedure
        coClientesEliminar.Parameters.Add(New SqlParameter("@ClienteCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cClaseClientes.Codigo
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If
        'Ejecutar el comando
        Try
            cn.Open()
            coClientesEliminar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function
End Class
