Imports System.Data
Imports System.Data.SqlClient


Public Class ClaseAdministradora
    Dim clasecon As New ClaseConexion
    Private _codigo As String
    Private _nombre As String
    Private _apellidos As String
    Private _sexo As String
    Private _ruc As String
    Private _telefono As String
    Private _dni As String
    Private _direccion As String
    Private _fechaNacimineto As Date
    Private _fechadeEntrada As Date
    Private _foto() As Byte
    Private _stado As String

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

    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
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

    Public Property Ruc As String
        Get
            Return _ruc
        End Get
        Set(value As String)
            _ruc = value
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

    Public Property Dni As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
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

    Public Property FechaNacimineto As Date
        Get
            Return _fechaNacimineto
        End Get
        Set(value As Date)
            _fechaNacimineto = value
        End Set
    End Property

    Public Property FechadeEntrada As Date
        Get
            Return _fechadeEntrada
        End Get
        Set(value As Date)
            _fechadeEntrada = value
        End Set
    End Property

    Public Property Foto As Byte()
        Get
            Return _foto
        End Get
        Set(value As Byte())
            _foto = value
        End Set
    End Property

    Public Property Stado As String
        Get
            Return _stado
        End Get
        Set(value As String)
            _stado = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(codigo As String, nombre As String, apellidos As String, sexo As String, ruc As String, telefono As String, dni As String, direccion As String, fechaNacimineto As Date, fechadeEntrada As Date, foto() As Byte, stado As String)
        Me.Codigo = codigo
        Me.Nombre = nombre
        Me.Apellidos = apellidos
        Me.Sexo = sexo
        Me.Ruc = ruc
        Me.Telefono = telefono
        Me.Dni = dni
        Me.Direccion = direccion
        Me.FechaNacimineto = fechaNacimineto
        Me.FechadeEntrada = fechadeEntrada
        Me.Foto = foto
        Me.Stado = stado
    End Sub
    Private Sub New(vAdministradorCodigo As String)
        Me.Codigo = vAdministradorCodigo
    End Sub

    Public Function administradorListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim daAdministradora As New SqlDataAdapter("spAdministradorlistados", cn)
        Dim dtAdministradora As New DataTable("Administradora")
        daAdministradora.Fill(dtAdministradora)
        Return dtAdministradora
    End Function

    Public Function administradoraInsertar(cClaseAdministradora As ClaseAdministradora) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena

        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim coadministradorAgregar As New SqlCommand("spAdministradorInsertada", cn)
        coadministradorAgregar.CommandType = CommandType.StoredProcedure


        coadministradorAgregar.Parameters.Add(New SqlParameter("@AdministradorNombre", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseAdministradora.Nombre
        coadministradorAgregar.Parameters.Add(New SqlParameter("@AdministradorApellidos", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseAdministradora.Apellidos
        coadministradorAgregar.Parameters.Add(New SqlParameter("@AdministradorRuc", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseAdministradora.Ruc
        coadministradorAgregar.Parameters.Add(New SqlParameter("@AdministradorTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = cClaseAdministradora.Telefono
        coadministradorAgregar.Parameters.Add(New SqlParameter("@AdministradorDni", SqlDbType.NVarChar, 8, ParameterDirection.Input)).Value = cClaseAdministradora.Dni
        coadministradorAgregar.Parameters.Add(New SqlParameter("@AdministradorDireccion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseAdministradora.Direccion
        '@EmpleadosMaterno nvarchar(50) 
        coadministradorAgregar.Parameters.Add(New SqlParameter("@AdministradorFechaNacimiento", SqlDbType.Date)).Value = cClaseAdministradora.FechaNacimineto
        coadministradorAgregar.Parameters.Add(New SqlParameter("@AdministradorFechaDeEntrada", SqlDbType.Date)).Value = cClaseAdministradora.FechadeEntrada
        '@EmpleadosSexo nchar(1)IIf(ptnMasculino.Checked = True, "M", "F")
        coadministradorAgregar.Parameters.Add(New SqlParameter("@AdministradorSexo", SqlDbType.NChar, 1)).Value = cClaseAdministradora.Sexo
        coadministradorAgregar.Parameters.Add(New SqlParameter("@AdministradoraEstado", SqlDbType.NChar, 1, ParameterDirection.Input)).Value = "A"


        coadministradorAgregar.Parameters.Add(New SqlParameter("@AdministradorFoto", SqlDbType.Image)).Value = cClaseAdministradora.Foto


        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            coadministradorAgregar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try

    End Function
    Public Function administradoraEditar(cClaseAdministradora As ClaseAdministradora) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        'SP:
        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim coAdministradoraEditar As New SqlCommand("spAdministradoraModificar", cn)
        coAdministradoraEditar.CommandType = CommandType.StoredProcedure


        coAdministradoraEditar.Parameters.Add(New SqlParameter("@AdministradorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cClaseAdministradora.Codigo
        coAdministradoraEditar.Parameters.Add(New SqlParameter("@AdministradorNombre", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseAdministradora.Nombre
        coAdministradoraEditar.Parameters.Add(New SqlParameter("@AdministradorApellidos", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseAdministradora.Apellidos
        coAdministradoraEditar.Parameters.Add(New SqlParameter("@AdministradorRuc", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseAdministradora.Ruc
        coAdministradoraEditar.Parameters.Add(New SqlParameter("@AdministradorTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = cClaseAdministradora.Telefono
        coAdministradoraEditar.Parameters.Add(New SqlParameter("@AdministradorDni", SqlDbType.NVarChar, 8, ParameterDirection.Input)).Value = cClaseAdministradora.Dni
        coAdministradoraEditar.Parameters.Add(New SqlParameter("@AdministradorDireccion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseAdministradora.Direccion
        '@EmpleadosMaterno nvarchar(50) 

        coAdministradoraEditar.Parameters.Add(New SqlParameter("@AdministradorFechaNacimiento", SqlDbType.Date)).Value = cClaseAdministradora.FechaNacimineto
        coAdministradoraEditar.Parameters.Add(New SqlParameter("@AdministradorFechaDeEntrada", SqlDbType.Date)).Value = cClaseAdministradora.FechadeEntrada
        '@EmpleadosSexo nchar(1)
        coAdministradoraEditar.Parameters.Add(New SqlParameter("@AdministradorSexo", SqlDbType.NChar, 1)).Value = cClaseAdministradora.Sexo

        '@EmpleadosMaterno nvarchar(50) 
        coAdministradoraEditar.Parameters.Add(New SqlParameter("@AdministradorFoto", SqlDbType.Image)).Value = cClaseAdministradora.Foto
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            coAdministradoraEditar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function

    Public Function AdministradoraEliminar(cClaseAdministradora As ClaseAdministradora) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena

        'SP:
        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim coAdministradoraEliminar As New SqlCommand("spEliminarAdministradora", cn)
        coAdministradoraEliminar.CommandType = CommandType.StoredProcedure
        coAdministradoraEliminar.Parameters.Add(New SqlParameter("@AdministradorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cClaseAdministradora.Codigo
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If
        'Ejecutar el comando
        Try
            cn.Open()
            coAdministradoraEliminar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function

End Class
