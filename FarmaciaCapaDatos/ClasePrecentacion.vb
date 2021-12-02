Imports System.Data
Imports System.Data.SqlClient
Public Class ClasePrecentacion
    Dim Conexion As New ClaseConexion
    Private _codigo As String
    Private _nombre As String
    Private _descripcion As String
    Private _Estado As String

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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(vcodigo As String, vnombre As String, vdescripcion As String, vestado As String)
        Me.Codigo = vcodigo
        Me.Nombre = vnombre
        Me.Descripcion = vdescripcion
        Me.Estado = vestado
    End Sub
    Public Sub New(vcodigo As String)
        Me.Codigo = vcodigo
    End Sub
    Public Function PrecentacionesListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        Dim daPrecentaciones As New SqlDataAdapter("spPrecentacioneslistados", cn)
        Dim dtPrecentaciones As New DataTable("Precentacion")
        daPrecentaciones.Fill(dtPrecentaciones)
        Return dtPrecentaciones

    End Function
    Public Function precentacionesInsertar(cClasePrecentaciones As ClasePrecentacion) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena

        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim coprecentacionAgregar As New SqlCommand("spinsertarlistadoPrecentacion", cn)
        coprecentacionAgregar.CommandType = CommandType.StoredProcedure
        '@PrecentacionesEstado nchar(1)


        Dim paPrecentacionCodigo As New SqlParameter
        paPrecentacionCodigo.ParameterName = "@PrecentacionesCodigo"
        paPrecentacionCodigo.SqlDbType = SqlDbType.NChar
        paPrecentacionCodigo.Size = 17
        paPrecentacionCodigo.Direction = ParameterDirection.Input
        paPrecentacionCodigo.Value = cClasePrecentaciones.Codigo

        coprecentacionAgregar.Parameters.Add(paPrecentacionCodigo)

        '@EmpleadosPaterno nvarchar(50) 

        '@EmpleadosMaterno nvarchar(50) 

        coprecentacionAgregar.Parameters.Add(New SqlParameter("@PrecentacionesNombre", SqlDbType.VarChar, 50, ParameterDirection.Input)).Value = cClasePrecentaciones.Nombre
        coprecentacionAgregar.Parameters.Add(New SqlParameter("@PrecentacionesDescripcion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClasePrecentaciones.Descripcion
        coprecentacionAgregar.Parameters.Add(New SqlParameter("@PrecentacionesEstado", SqlDbType.NChar, 1, ParameterDirection.Input)).Value = "A"
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If
        Try
            cn.Open()
            coprecentacionAgregar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function
    Public Function precentacionesEditar(cClasePrecentaciones As ClasePrecentacion) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        'SP:
        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim coprecentacionesEditar As New SqlCommand("spModificarPrecentacion", cn)
        coprecentacionesEditar.CommandType = CommandType.StoredProcedure

        coprecentacionesEditar.Parameters.Add(New SqlParameter("@PrecentacionesCodigo", SqlDbType.NChar, 17)).Value = cClasePrecentaciones.Codigo
        coprecentacionesEditar.Parameters.Add(New SqlParameter("@PrecentacionesNombre", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cClasePrecentaciones.Nombre
        '@EmpleadosPaterno nvarchar(50) 
        coprecentacionesEditar.Parameters.Add(New SqlParameter("@PrecentacionesDescripcion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClasePrecentaciones.Descripcion
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            coprecentacionesEditar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function
    Public Function categoriaEliminar(cClaseprecentaciones As ClasePrecentacion) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion.ccadena
        'SP:
        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim coPrecentacionesEliminar As New SqlCommand("spEliminarlistados", cn)
        coPrecentacionesEliminar.CommandType = CommandType.StoredProcedure

        coPrecentacionesEliminar.Parameters.Add(New SqlParameter("@PrecentacionesCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cClaseprecentaciones.Codigo
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If
        'Ejecutar el comando
        Try
            cn.Open()
            coPrecentacionesEliminar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function

End Class
