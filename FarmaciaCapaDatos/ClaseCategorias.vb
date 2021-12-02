
Imports System.Data
Imports System.Data.SqlClient
Public Class ClaseCategorias

    Dim clasecon As New ClaseConexion
    Private _codigo As String
    Private _nombre As String
    Private _descripcion As String
    Private _estado As String

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
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(vCategoriacodigo As String, vcategorianombre As String, vcategoriadescripcion As String, vcategoriaestado As String)
        Me.Codigo = vCategoriacodigo
        Me.Nombre = vcategorianombre
        Me.Descripcion = vcategoriadescripcion
        Me.Estado = vcategoriaestado
    End Sub
    Private Sub New(vCategoriacodigo As String)
        Me.Codigo = vCategoriacodigo
    End Sub

    Public Function CategoriasListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim dacategorias As New SqlDataAdapter("spCategorialistado", cn)
        Dim dtcategorias As New DataTable("Categorias")
        dacategorias.Fill(dtcategorias)
        Return dtcategorias
    End Function
    Public Function CategoriasInsertar(cClaseCategorias As ClaseCategorias) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena

        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim cocategoriasAgregar As New SqlCommand("spinsertarlistadoategoria", cn)
        cocategoriasAgregar.CommandType = CommandType.StoredProcedure

        Dim pacategoriaCodigo As New SqlParameter
        pacategoriaCodigo.ParameterName = "@CategoriasCodigo"
        pacategoriaCodigo.SqlDbType = SqlDbType.NChar
        pacategoriaCodigo.Size = 17
        pacategoriaCodigo.Direction = ParameterDirection.Input
        pacategoriaCodigo.Value = cClaseCategorias.Codigo

        cocategoriasAgregar.Parameters.Add(pacategoriaCodigo)
        ' @CategoriasCodigo nchar (17),
        '@CategoriaNombre varchar (50),
        '@CategoriaDescripcion nvarchar (100),
        '@CategoriaEstado nchar(1) 
        cocategoriasAgregar.Parameters.Add(New SqlParameter("@CategoriaNombre", SqlDbType.VarChar, 50, ParameterDirection.Input)).Value = cClaseCategorias.Nombre
        cocategoriasAgregar.Parameters.Add(New SqlParameter("@CategoriaDescripcion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseCategorias.Descripcion
        cocategoriasAgregar.Parameters.Add(New SqlParameter("@CategoriaEstado", SqlDbType.NChar, 1, ParameterDirection.Input)).Value = "A"

        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If
        Try
            cn.Open()
            cocategoriasAgregar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function

    Public Function categoriaEditar(cClaseCategorias As ClaseCategorias) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        'SP:
        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim cocategoriaEditar As New SqlCommand("spModificadolistadoCategoria", cn)
        cocategoriaEditar.CommandType = CommandType.StoredProcedure

        cocategoriaEditar.Parameters.Add(New SqlParameter("@CategoriasCodigo", SqlDbType.NChar, 17)).Value = cClaseCategorias.Codigo
        cocategoriaEditar.Parameters.Add(New SqlParameter("@CategoriaNombre", SqlDbType.VarChar, 50, ParameterDirection.Input)).Value = cClaseCategorias.Nombre
        '@EmpleadosPaterno nvarchar(50) 
        cocategoriaEditar.Parameters.Add(New SqlParameter("@CategoriaDescripcion", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cClaseCategorias.Descripcion
        '@EmpleadosMaterno nvarchar(50) 
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            cocategoriaEditar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function

    Public Function categoriaEliminar(cClaseCategorias As ClaseCategorias) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        'SP:
        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim cocategoriaEliminar As New SqlCommand("spEliminarlistadoCategoria", cn)
        cocategoriaEliminar.CommandType = CommandType.StoredProcedure
        cocategoriaEliminar.Parameters.Add(New SqlParameter("@CategoriasCodigo", SqlDbType.NChar, 17)).Value = cClaseCategorias.Codigo
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If
        'Ejecutar el comando
        Try
            cn.Open()
            cocategoriaEliminar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function

End Class
