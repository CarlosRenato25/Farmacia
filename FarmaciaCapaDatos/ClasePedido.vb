Imports System.Data.SqlClient
Imports System.Data
Imports FarmaciaCapaDatos
Imports System.Windows.Forms

Public Class ClasePedido
    Private conexion As New ClaseConexion
    Private _codigo As Integer
    Private _totalpagar As Double
    Private _numeroOrden As String
    Private _cliente As String
    Private _farmaceutico As String
    Private _fechapedido As Date
    Private _estado As String
    Private _listaDetallePedido As New List(Of ClaseDetallePedido)
    Public Property Codigo As Integer
        Get
            Return _codigo
        End Get
        Set(value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property totalpagar As Double
        Get
            Return _totalpagar
        End Get
        Set(value As Double)
            _totalpagar = value
        End Set
    End Property
    Public Property numeroorden As String
        Get
            Return _numeroOrden
        End Get
        Set(value As String)
            _numeroOrden = value
        End Set
    End Property
    Public Property cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property
    Public Property farmaceutico As String
        Get
            Return _farmaceutico
        End Get
        Set(value As String)
            _farmaceutico = value
        End Set
    End Property

    Public Property fechapedido As Date
        Get
            Return _fechapedido
        End Get
        Set(value As Date)
            _fechapedido = value
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

    Public Property ListaDetallePedido As List(Of ClaseDetallePedido)
        Get
            Return _listaDetallePedido
        End Get
        Set(value As List(Of ClaseDetallePedido))
            _listaDetallePedido = value
        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(_Codigo As Integer, _totalpagar As Double, _numeroOrden As String, _cliente As String, _farmaceutico As String, _fechapedido As Date, _estado As String)
        Me._codigo = _Codigo
        Me._totalpagar = _totalpagar
        Me._numeroOrden = _numeroOrden
        Me._cliente = _cliente
        Me._farmaceutico = _farmaceutico
        Me._fechapedido = _fechapedido
        Me._estado = _estado
    End Sub
    Private Sub New(vpedidoCodigo As Integer)
        Me.Codigo = vpedidoCodigo
    End Sub

    Public Sub AgregarDetallePedido(detallePedido As ClaseDetallePedido)
        _listaDetallePedido.Add(detallePedido)
    End Sub

    Public Function CalcularTotalAPagar() As Double
        Dim totalaPagar = 0
        For Each detallePedido In _listaDetallePedido
            totalaPagar += detallePedido.CalcularImporte
        Next
        Return totalaPagar
    End Function

    Public Function pedidoListados() As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion.ccadena
        Dim dpedido As New SqlDataAdapter("spListadoPedido", cn)
        Dim dtpedido As New DataTable("Pedido")
        dpedido.Fill(dtpedido)
        Return dtpedido
    End Function

    Public Function ListaClientes() As DataSet
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion.ccadena
        Dim dsDatos As New DataSet
        Dim daCliente As New SqlDataAdapter("spClienteslistados", cn)
        daCliente.Fill(dsDatos, "Cliente")
        Return dsDatos
    End Function

    Public Function pedidoInsertar(cclasepedido As ClasePedido) As Boolean
        Dim conexion As New ClaseConexion
        Try
            conexion.AbrirConexion()
            conexion.IniciarTransaccion()
            Dim copedidoinsertar As New SqlCommand("spRegistrarPedido")
            copedidoinsertar.Connection = conexion.cn
            copedidoinsertar.Transaction = conexion.transaction
            copedidoinsertar.CommandType = CommandType.StoredProcedure

            copedidoinsertar.Parameters.Add(New SqlParameter("@pedidoCodigo", SqlDbType.Int)).Direction = ParameterDirection.Output
            copedidoinsertar.Parameters.Add(New SqlParameter("@PedidoTotalApagar", SqlDbType.Decimal)).Value = cclasepedido.totalpagar
            copedidoinsertar.Parameters.Add(New SqlParameter("@PedidoNumeroDeOrden", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = cclasepedido.numeroorden
            copedidoinsertar.Parameters.Add(New SqlParameter("@PedidoClienteCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cclasepedido.cliente
            copedidoinsertar.Parameters.Add(New SqlParameter("@PedidoFarmaceuticoCodigo", SqlDbType.NChar, 17, ParameterDirection.Input)).Value = cclasepedido.farmaceutico
            copedidoinsertar.Parameters.Add(New SqlParameter("@PedidoFechaDePedido", SqlDbType.Date)).Value = cclasepedido.fechapedido
            copedidoinsertar.ExecuteNonQuery()
            cclasepedido._codigo = Integer.Parse(copedidoinsertar.Parameters("@pedidoCodigo").Value.ToString)

            For Each detallePedido In cclasepedido.ListaDetallePedido
                detallePedido.Pedido = cclasepedido
                detallepedidoInsertar(detallePedido, conexion)
            Next
            conexion.EjecutarTransaccion()
            Return True
        Catch ex As Exception
            conexion.CancelarTransaccion()
        Finally
            conexion.CerrarConexion()
        End Try
        Return False
    End Function

    Public Function detallepedidoInsertar(cclasedetallepedido As ClaseDetallePedido, conexion As ClaseConexion) As Boolean
        Try
            Dim codetallepedido As New SqlCommand("spRegistrarDetallePedido")
            codetallepedido.Connection = conexion.cn
            codetallepedido.Transaction = conexion.transaction
            codetallepedido.CommandType = CommandType.StoredProcedure
            codetallepedido.Parameters.Add(New SqlParameter("@PedidoCodigo", SqlDbType.Int)).Value = cclasedetallepedido.Pedido.Codigo
            codetallepedido.Parameters.Add(New SqlParameter("@MedicamentoCodigo", SqlDbType.NChar, 50, ParameterDirection.Input)).Value = cclasedetallepedido.Medicamento.Codigo
            codetallepedido.Parameters.Add(New SqlParameter("@DetallePedidoImporte", SqlDbType.Decimal)).Value = cclasedetallepedido.DetalleImporte
            codetallepedido.Parameters.Add(New SqlParameter("@DetallePedidoCantidad", SqlDbType.Decimal)).Value = cclasedetallepedido.Cantidad
            codetallepedido.Parameters.Add(New SqlParameter("@DetallePedidoPrecio", SqlDbType.Decimal)).Value = cclasedetallepedido.Precio
            codetallepedido.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function AutogenerarNumeroDeBoleta() As Integer
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion.ccadena
        Dim numeroPedido As Integer
        Dim cmd As New SqlCommand("AutogenerarNumeroPedido", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@NumeroPedido", SqlDbType.Int)).Direction = ParameterDirection.Output
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            numeroPedido = cmd.Parameters("@NumeroPedido").Value
        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
        End Try
        Return numeroPedido
    End Function

End Class


