Imports System.Data.SqlClient
Imports System.Data
Imports FarmaciaCapaDatos

Public Class ClasFarmaceutico
    Private Conexion As New ClaseConexion
    Private _Codigo As String
    Private _Nombre As String
    Private _Apellidos As String
    Private __Telefono As String
    Private _Direccion As String
    Private _Dni As String
    Private _fechaEntrada As Date
    Private _FechaNacimiento As Date
    Private _sexo As String
    Private _foto As Byte()
    Private _stado As String
    Private _codigoAdministrador As String


    Public Sub New()
    End Sub

    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _Apellidos
        End Get
        Set(value As String)
            _Apellidos = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return __Telefono
        End Get
        Set(value As String)
            __Telefono = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Dni As String
        Get
            Return _Dni
        End Get
        Set(value As String)
            _Dni = value
        End Set
    End Property

    Public Property FechaEntrada As Date
        Get
            Return _fechaEntrada
        End Get
        Set(value As Date)
            _fechaEntrada = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            _FechaNacimiento = value
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

    Public Property Foto As Byte()
        Get
            Return _foto
        End Get
        Set(value As Byte())
            _foto = value
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

    Public Property Stado As String
        Get
            Return _stado
        End Get
        Set(value As String)
            _stado = value
        End Set
    End Property

    Public Sub New(codigo As String, nombre As String, apellidos As String, telefono As String, direccion As String, dni As String, fechaEntrada As Date, fechaNacimiento As Date, sexo As String, foto() As Byte, codigoAdministrador As String, stado As String)
        Me.New(codigo)
        Me.Nombre = nombre
        Me.Apellidos = apellidos
        Me.Telefono = telefono
        Me.Direccion = direccion
        Me.Dni = dni
        Me.FechaEntrada = fechaEntrada
        Me.FechaNacimiento = fechaNacimiento
        Me.Sexo = sexo
        Me.Foto = foto
        Me.CodigoAdministrador = codigoAdministrador
        Me.Stado = stado
    End Sub
    Private Sub New(_Farmaceutico As String)
        Me.Codigo = _Farmaceutico
    End Sub
    Public Function FarmaceuticoListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        Dim dafarmaceutcio As New SqlDataAdapter("spFarmaceuticolistados", cn)
        Dim dtfarmaceutico As New DataTable("Farmaceutico")
        dafarmaceutcio.Fill(dtfarmaceutico)
        Return dtfarmaceutico
    End Function
    Public Function AdministradorListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        Dim daadministrador As New SqlDataAdapter("spFarmaceuticoListadoAdministradores", cn)
        Dim dtadminitrador As New DataTable("Administradora")
        daadministrador.Fill(dtadminitrador)
        Return dtadminitrador
    End Function
    Public Function farmceuticoInsertar(cClaseFarmaceutcio As ClasFarmaceutico) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        Dim coFarmaceuticoInsertar As New SqlCommand("spFarmaceuticoInsertar", cn)
        coFarmaceuticoInsertar.CommandType = CommandType.StoredProcedure
        coFarmaceuticoInsertar.Parameters.Add(New SqlParameter("@FarmaceuticoNombre", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cClaseFarmaceutcio.Nombre
        coFarmaceuticoInsertar.Parameters.Add(New SqlParameter("@FarmaceuticoApellidos", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cClaseFarmaceutcio.Apellidos
        coFarmaceuticoInsertar.Parameters.Add(New SqlParameter("@FarmaceuticoTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = cClaseFarmaceutcio.Telefono
        coFarmaceuticoInsertar.Parameters.Add(New SqlParameter("@FarmaceuticoDireccion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseFarmaceutcio.Direccion
        coFarmaceuticoInsertar.Parameters.Add(New SqlParameter("@FarmaceuticoDni", SqlDbType.NVarChar, 8, ParameterDirection.Input)).Value = cClaseFarmaceutcio.Dni
        coFarmaceuticoInsertar.Parameters.Add(New SqlParameter("@FarmaceuticoAdministradorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cClaseFarmaceutcio.CodigoAdministrador
        coFarmaceuticoInsertar.Parameters.Add(New SqlParameter("@FarmaceuticoFechaDeNacimiento", SqlDbType.Date)).Value = cClaseFarmaceutcio.FechaNacimiento
        coFarmaceuticoInsertar.Parameters.Add(New SqlParameter("@FarmaceuticoFechaDeEntrada", SqlDbType.Date)).Value = cClaseFarmaceutcio.FechaEntrada
        coFarmaceuticoInsertar.Parameters.Add(New SqlParameter("@FarmaceuticoSexo", SqlDbType.NChar, 1)).Value = cClaseFarmaceutcio.Sexo
        coFarmaceuticoInsertar.Parameters.Add(New SqlParameter("@Farmaceuticofoto", SqlDbType.Image)).Value = cClaseFarmaceutcio.Foto
        coFarmaceuticoInsertar.Parameters.Add(New SqlParameter("@FarmaceuticoEstado", SqlDbType.NChar, 1, ParameterDirection.Input)).Value = "A"
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If
        Try
            cn.Open()

            coFarmaceuticoInsertar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cn.Close()
        End Try
    End Function
    Public Function FarmaceuticoEditar(cClaseFarmaceutcio As ClasFarmaceutico) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        Dim coFarmaceuticoEditar As New SqlCommand("spFarmaceuticoModificar", cn)
        coFarmaceuticoEditar.CommandType = CommandType.StoredProcedure
        coFarmaceuticoEditar.Parameters.Add(New SqlParameter("@FarmaceuticoCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cClaseFarmaceutcio.Codigo
        coFarmaceuticoEditar.Parameters.Add(New SqlParameter("@FarmaceuticoNombre", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cClaseFarmaceutcio.Nombre
        coFarmaceuticoEditar.Parameters.Add(New SqlParameter("@FarmaceuticoApellidos", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cClaseFarmaceutcio.Apellidos
        coFarmaceuticoEditar.Parameters.Add(New SqlParameter("@FarmaceuticoTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = cClaseFarmaceutcio.Telefono
        coFarmaceuticoEditar.Parameters.Add(New SqlParameter("@FarmaceuticoDireccion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseFarmaceutcio.Direccion
        coFarmaceuticoEditar.Parameters.Add(New SqlParameter("@FarmaceuticoDni", SqlDbType.NVarChar, 8, ParameterDirection.Input)).Value = cClaseFarmaceutcio.Dni
        coFarmaceuticoEditar.Parameters.Add(New SqlParameter("@FarmaceuticoAdministradorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cClaseFarmaceutcio.CodigoAdministrador
        coFarmaceuticoEditar.Parameters.Add(New SqlParameter("@FarmaceuticoFechaDeNacimiento", SqlDbType.Date)).Value = cClaseFarmaceutcio.FechaNacimiento
        coFarmaceuticoEditar.Parameters.Add(New SqlParameter("@FarmaceuticoFechaDeEntrada", SqlDbType.Date)).Value = cClaseFarmaceutcio.FechaEntrada
        coFarmaceuticoEditar.Parameters.Add(New SqlParameter("@FarmaceuticoSexo", SqlDbType.NChar, 1)).Value = cClaseFarmaceutcio.Sexo
        coFarmaceuticoEditar.Parameters.Add(New SqlParameter("@Farmaceuticofoto", SqlDbType.Image)).Value = cClaseFarmaceutcio.Foto
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If
        Try
            cn.Open()

            coFarmaceuticoEditar.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cn.Close()
        End Try
    End Function
    Public Function FarmaceuticoEliminar(cClaseadministrador As ClasFarmaceutico) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        'SP:
        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim coFarmaceutcioEliminar As New SqlCommand("spEliminarFarmaceutico", cn)
        coFarmaceutcioEliminar.CommandType = CommandType.StoredProcedure
        coFarmaceutcioEliminar.Parameters.Add(New SqlParameter("@FarmaceuticoCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cClaseadministrador.Codigo
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If
        Try
            cn.Open()

            coFarmaceutcioEliminar.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cn.Close()
        End Try
    End Function
End Class
