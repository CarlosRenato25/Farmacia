
Imports System.Data.SqlClient
Imports System.Data
Imports FarmaciaCapaDatos
Public Class ClaseMedicamentos
    Private clasecon As New ClaseConexion
    Private _codigo As String
    Private _nombre As String
    Private _laboratorio As String
    Private _especificaciones As String
    Private _stock As Double
    Private _precioCompra As Double
    Private _precioVenta As Double
    Private _citiolaboratorio As String
    Private _fechaEntrada As Date
    Private _fechaVencimientoMedicamento As Date
    Private _categoriaMedicamentos As String
    Private _precetacionesMedicamentos As String
    Private _administrdorMedicamentos As String
    Private _estado As String

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property laboratorio As String
        Get
            Return _laboratorio
        End Get
        Set(value As String)
            _laboratorio = value
        End Set
    End Property

    Public Property especificaciones As String
        Get
            Return _especificaciones
        End Get
        Set(value As String)
            _especificaciones = value
        End Set
    End Property

    Public Property stock As Double
        Get
            Return _stock
        End Get
        Set(value As Double)
            _stock = value
        End Set
    End Property

    Public Property preciocompra As Double
        Get
            Return _precioCompra
        End Get
        Set(value As Double)
            _precioCompra = value
        End Set
    End Property

    Public Property precioventa As Double
        Get
            Return _precioVenta
        End Get
        Set(value As Double)
            _precioVenta = value
        End Set
    End Property

    Public Property citiolaboratorio As String
        Get
            Return _citiolaboratorio
        End Get
        Set(value As String)
            _citiolaboratorio = value
        End Set
    End Property
    Public Property fechaentrada As Date
        Get
            Return _fechaEntrada
        End Get
        Set(value As Date)
            _fechaEntrada = value
        End Set
    End Property

    Public Property fechaVencimientoMedicamento As Date
        Get
            Return _fechaVencimientoMedicamento
        End Get
        Set(value As Date)
            _fechaVencimientoMedicamento = value
        End Set
    End Property

    Public Property categoriaMedicamentos As String
        Get
            Return _categoriaMedicamentos
        End Get
        Set(value As String)
            _categoriaMedicamentos = value
        End Set
    End Property

    Public Property precetacionesMedicamentos As String
        Get
            Return _precetacionesMedicamentos
        End Get
        Set(value As String)
            _precetacionesMedicamentos = value
        End Set
    End Property

    Public Property administradorMedicamentos As String
        Get
            Return _administrdorMedicamentos
        End Get
        Set(value As String)
            _administrdorMedicamentos = value
        End Set
    End Property

    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property


    Public Sub New()
    End Sub

    Public Sub New(Codigo As String, nombre As String, laboratorio As String, especificaciones As String,
     stock As Double, precioCompra As Double, precioVenta As Double, citiolaboratorio As String, fechaEntrada As Date,
      fechaVencimientoMedicamento As Date, categoriaMedicamentos As String, precetacionesMedicamentos As String, administradorMedicamentos As String, estado As String)
        Me.Codigo = Codigo
        Me.nombre = nombre
        Me.laboratorio = laboratorio
        Me.especificaciones = especificaciones
        Me.stock = stock
        Me.preciocompra = precioCompra
        Me.precioventa = precioVenta
        Me.citiolaboratorio = citiolaboratorio
        Me.fechaentrada = fechaEntrada
        Me.fechaVencimientoMedicamento = fechaVencimientoMedicamento
        Me.categoriaMedicamentos = categoriaMedicamentos
        Me.precetacionesMedicamentos = precetacionesMedicamentos
        Me.administradorMedicamentos = administradorMedicamentos
        Me.estado = estado
    End Sub
    Private Sub New(vmedicmanetosCodigo As String)
        Me.Codigo = vmedicmanetosCodigo
    End Sub
    Public Function medicamentosListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim damedicamentos As New SqlDataAdapter("spMedicamentoslistados", cn)
        Dim dtmedicamentos As New DataTable("MedicamentosDeBotica")
        damedicamentos.Fill(dtmedicamentos)
        Return dtmedicamentos
    End Function

    Public Function administradorListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim damedicamentos As New SqlDataAdapter("spMedicamentosListadoAdministradores", cn)
        Dim dtmedicamentos As New DataTable("Administradora")
        damedicamentos.Fill(dtmedicamentos)
        Return dtmedicamentos
    End Function

    Public Function categoriasListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim damedicamentos As New SqlDataAdapter("spMedicamentosListadoCategorias", cn)
        Dim dtmedicamentos As New DataTable("Categorias")
        damedicamentos.Fill(dtmedicamentos)
        Return dtmedicamentos
    End Function

    Public Function precentacionesListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim damedicamentos As New SqlDataAdapter("spMedicamentosListadoPrecentaciones", cn)
        Dim dtmedicamentos As New DataTable("Precentacion")
        damedicamentos.Fill(dtmedicamentos)
        Return dtmedicamentos
    End Function
    Public Function MedicamentosInsertar(cclaseMedicamentos As ClaseMedicamentos) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim coMedicamentoAgregar As New SqlCommand("spMedicamentosInsertar", cn)
        coMedicamentoAgregar.CommandType = CommandType.StoredProcedure

        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosNombre", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cclaseMedicamentos.nombre
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosLaboratorio", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cclaseMedicamentos.laboratorio
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosEspecificaciones", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cclaseMedicamentos.especificaciones
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosStock", SqlDbType.Decimal)).Value = cclaseMedicamentos.stock
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosPrecioDeCompra", SqlDbType.Decimal)).Value = cclaseMedicamentos.preciocompra
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosPrecioDeVenta", SqlDbType.Decimal)).Value = cclaseMedicamentos.precioventa
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosCito", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cclaseMedicamentos.citiolaboratorio
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosFechaDeEntrada", SqlDbType.Date)).Value = cclaseMedicamentos.fechaentrada
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosFechaVenceMedicamento", SqlDbType.Date)).Value = cclaseMedicamentos.fechaVencimientoMedicamento
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosCategoriasCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cclaseMedicamentos.categoriaMedicamentos
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosPrecentacionesCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cclaseMedicamentos.precetacionesMedicamentos
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosAdministradorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cclaseMedicamentos.administradorMedicamentos
        coMedicamentoAgregar.Parameters.Add(New SqlParameter("@MedicamentosEstado", SqlDbType.NChar, 1, ParameterDirection.Input)).Value = "A"

        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            coMedicamentoAgregar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function

    Public Function MedicamentosEditar(cclaseMedicamentos As ClaseMedicamentos) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        Dim coMedicamentoeditar As New SqlCommand("spMedicamentosModificar", cn)
        coMedicamentoeditar.CommandType = CommandType.StoredProcedure

        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosCodigo", SqlDbType.NChar, 50, ParameterDirection.Input)).Value = cclaseMedicamentos.Codigo
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosNombre", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cclaseMedicamentos.nombre
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosLaboratorio", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cclaseMedicamentos.laboratorio
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosEspecificaciones", SqlDbType.NVarChar, 100, ParameterDirection.Input)).Value = cclaseMedicamentos.especificaciones
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosStock", SqlDbType.Decimal)).Value = cclaseMedicamentos.stock
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosPrecioDeCompra", SqlDbType.Decimal)).Value = cclaseMedicamentos.preciocompra
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosPrecioDeVenta", SqlDbType.Decimal)).Value = cclaseMedicamentos.precioventa
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosCito", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cclaseMedicamentos.citiolaboratorio
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosFechaDeEntrada", SqlDbType.Date)).Value = cclaseMedicamentos.fechaentrada
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosFechaVenceMedicamento", SqlDbType.Date)).Value = cclaseMedicamentos.fechaVencimientoMedicamento
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosCategoriasCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cclaseMedicamentos.categoriaMedicamentos
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosPrecentacionesCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cclaseMedicamentos.precetacionesMedicamentos
        coMedicamentoeditar.Parameters.Add(New SqlParameter("@MedicamentosAdministradorCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cclaseMedicamentos.administradorMedicamentos

        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            coMedicamentoeditar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function
    Public Function medicamentosEliminar(cClasemedicamantos As ClaseMedicamentos) As Boolean
        Dim cn As New SqlConnection
        cn.ConnectionString = clasecon.ccadena
        'SP:
        'Comando (SQLCommand): CommandText, CommandType, Connection
        Dim comedicmantosEliminar As New SqlCommand("spEliminarMedicamentos", cn)
        comedicmantosEliminar.CommandType = CommandType.StoredProcedure
        comedicmantosEliminar.Parameters.Add(New SqlParameter("@MedicamentosCodigo", SqlDbType.NChar, 50, ParameterDirection.Input)).Value = cClasemedicamantos.Codigo
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If
        'Ejecutar el comando
        Try
            cn.Open()
            comedicmantosEliminar.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cn.Close()
        End Try
    End Function

End Class
