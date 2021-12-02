
Imports System.Data.SqlClient
Public Class ClaseProveedor
    Private Conexion As New ClaseConexion
    Private _codigo As String
    Private _nombre As String
    Private _apellidos As String
    Private _direccion As String
    Private _sexo As String
    Private _dni As String
    Private _telefono As String
    Private _fechaentrada As Date
    Private _foto As Byte()
    Private _estado As String
    Private _administradorCodigo As String

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
    Public Property Nombres As String
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
    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
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
    Public Property Dni As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
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
    Public Property FechaEntrada As Date
        Get
            Return _fechaentrada
        End Get
        Set(value As Date)
            _fechaentrada = value
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
    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
    Public Property Administrador As String
        Get
            Return _administradorCodigo
        End Get
        Set(value As String)
            _administradorCodigo = value
        End Set
    End Property

    Public Sub New(codigo As String, nombres As String, apellidos As String, direccion As String, sexo As String, dni As String, telefono As String,
                   fechaentrada As Date, foto As Byte(), estado As String, administrador As String)
        Me.New(codigo)
        Me.Nombres = nombres
        Me.Apellidos = apellidos
        Me.Direccion = direccion
        Me.Sexo = sexo
        Me.Dni = dni
        Me.Telefono = telefono
        Me.FechaEntrada = fechaentrada
        Me.Foto = foto
        Me.Estado = estado
        Me.Administrador = administrador

    End Sub
    Private Sub New(vProveedor As String)
        Me.Codigo = vProveedor

    End Sub
    Public Function ProveedorListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        Dim daproveedores As New SqlDataAdapter("spProveedorlistados", cn)
        Dim dtprveedores As New DataTable("Proveedores")
        daproveedores.Fill(dtprveedores)
        Return dtprveedores

    End Function

    Public Function AdministradorListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        Dim daAdministrador As New SqlDataAdapter("sproveedoresListadoAdministrador", cn)
        Dim dtAdministrador As New DataTable("Administradora")
        daAdministrador.Fill(dtAdministrador)
        Return dtAdministrador
    End Function

    Public Function ProveedorInsertar(cProveedores As ClaseProveedor) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        Dim coProveedoresInsertar As New SqlCommand("spProveedoraInsertar", cn)
        coProveedoresInsertar.CommandType = CommandType.StoredProcedure
        coProveedoresInsertar.Parameters.Add(New SqlParameter("@ProveedorNombre", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cProveedores.Nombres
        coProveedoresInsertar.Parameters.Add(New SqlParameter("@ProveedorApellidos", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cProveedores.Apellidos
        coProveedoresInsertar.Parameters.Add(New SqlParameter("@ProveedorDireccion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cProveedores.Direccion
        coProveedoresInsertar.Parameters.Add(New SqlParameter("@ProveedorTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = cProveedores.Telefono
        coProveedoresInsertar.Parameters.Add(New SqlParameter("@ProveedorDni", SqlDbType.NVarChar, 8, ParameterDirection.Input)).Value = cProveedores.Dni
        coProveedoresInsertar.Parameters.Add(New SqlParameter("@ProveedoraAdministradorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cProveedores.Administrador
        coProveedoresInsertar.Parameters.Add(New SqlParameter("@ProveedorFechaDeEntrada", SqlDbType.Date)).Value = cProveedores.FechaEntrada
        coProveedoresInsertar.Parameters.Add(New SqlParameter("@ProveedorSexo", SqlDbType.NChar, 1)).Value = cProveedores.Sexo
        coProveedoresInsertar.Parameters.Add(New SqlParameter("@ProveedoraEstado", SqlDbType.NChar, 1, ParameterDirection.Input)).Value = "A"
        coProveedoresInsertar.Parameters.Add(New SqlParameter("@Proveedorfoto", SqlDbType.Image)).Value = cProveedores.Foto

        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            coProveedoresInsertar.ExecuteNonQuery()
            Return True
            MsgBox("los procedimientos se escribieron correctamente ")
        Catch ex As Exception

            Return False
            MsgBox("los procedimientos estan mal escrito")
        Finally
            cn.Close()
        End Try
    End Function

    Public Function ProveedoresModificar(cProveedores As ClaseProveedor) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        Dim coProveedoresModificar As New SqlCommand("spProveedoresModificar", cn)
        coProveedoresModificar.CommandType = CommandType.StoredProcedure
        coProveedoresModificar.Parameters.Add(New SqlParameter("@ProveedoraAdministradorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cProveedores.Administrador
        coProveedoresModificar.Parameters.Add(New SqlParameter("@ProveedorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cProveedores.Codigo
        coProveedoresModificar.Parameters.Add(New SqlParameter("@ProveedorNombre", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cProveedores.Nombres
        coProveedoresModificar.Parameters.Add(New SqlParameter("@ProveedorApellidos", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cProveedores.Apellidos
        coProveedoresModificar.Parameters.Add(New SqlParameter("@ProveedorDireccion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cProveedores.Direccion
        coProveedoresModificar.Parameters.Add(New SqlParameter("@ProveedorTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = cProveedores.Telefono
        coProveedoresModificar.Parameters.Add(New SqlParameter("@ProveedorDni", SqlDbType.NVarChar, 8, ParameterDirection.Input)).Value = cProveedores.Dni
        '@EmpleadosMaterno nvarchar(50) 
        coProveedoresModificar.Parameters.Add(New SqlParameter("@ProveedorFechaDeEntrada", SqlDbType.Date)).Value = cProveedores.FechaEntrada
        '@EmpleadosSexo nchar(1)
        coProveedoresModificar.Parameters.Add(New SqlParameter("@ProveedorSexo", SqlDbType.NChar, 1)).Value = cProveedores.Sexo
        coProveedoresModificar.Parameters.Add(New SqlParameter("@Proveedorfoto", SqlDbType.Image)).Value = cProveedores.Foto
        '@EmpleadosMaterno nvarchar(50) 

        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            coProveedoresModificar.ExecuteNonQuery()
            Return True

        Catch ex As Exception

            Return False

        Finally
            cn.Close()
        End Try
    End Function

    Public Function ProveedoresEliminar(cProveedores As ClaseProveedor) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        Dim coProveedoresElminar As New SqlCommand("spEliminarProveedores", cn)
        coProveedoresElminar.CommandType = CommandType.StoredProcedure
        coProveedoresElminar.Parameters.Add(New SqlParameter("@ProveedorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cProveedores.Codigo

        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            coProveedoresElminar.ExecuteNonQuery()
            Return True

        Catch ex As Exception

            Return False

        Finally
            cn.Close()
        End Try
    End Function
End Class
