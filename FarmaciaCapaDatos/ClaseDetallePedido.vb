Imports System.Data.SqlClient
Imports System.Data
Imports FarmaciaCapaDatos
Imports System.Windows.Forms

Public Class ClaseDetallePedido
    Private conexion As New ClaseConexion
    Private _pedido As ClasePedido
    Private _medicamento As ClaseMedicamentos
    Private _detalleimporte As Double
    Private _cantidad As Double
    Private _precio As Double


    Public Property Pedido As ClasePedido
        Get
            Return _pedido
        End Get
        Set(value As ClasePedido)
            _pedido = value
        End Set
    End Property
    Public Property Medicamento As ClaseMedicamentos
        Get
            Return _medicamento
        End Get
        Set(value As ClaseMedicamentos)
            _medicamento = value
        End Set
    End Property
    Public Property DetalleImporte As Double
        Get
            Return _detalleimporte
        End Get
        Set(value As Double)
            _detalleimporte = value
        End Set
    End Property
    Public Property Cantidad As Double
        Get
            Return _cantidad
        End Get
        Set(value As Double)
            _cantidad = value
        End Set
    End Property
    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property
    Public Sub New()
    End Sub
    Public Sub New(_Codigo As ClasePedido, _medicamento As ClaseMedicamentos, _detalleimporte As Double, _cantidad As Double, _precio As Double)
        Me._pedido = _Codigo
        Me._medicamento = _medicamento
        Me._detalleimporte = _detalleimporte
        Me._cantidad = _cantidad
        Me._precio = _precio

    End Sub
    Private Sub New(vpedidoCodigo As ClasePedido)
        Me.Pedido = vpedidoCodigo
    End Sub

    Public Function CalcularImporte() As Double
        Return _cantidad * _precio
    End Function

    Public Function esStockValido() As Boolean
        Return _medicamento.stock > _cantidad
    End Function

    Public Function detallepedidoListados(pedidoCodido As Integer) As DataTable
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion.ccadena
        Dim codetallepedido As New SqlCommand("spListadoDetallePedido", cn)
        codetallepedido.Parameters.Add(New SqlParameter("@pedidoCodigo", SqlDbType.Int)).Value = pedidoCodido
        codetallepedido.CommandType = CommandType.StoredProcedure
        Dim dadetallepedido As New SqlDataAdapter(codetallepedido)
        Dim dtdetallepedido As New DataTable("DetallePedido")
        dadetallepedido.Fill(dtdetallepedido)
        Return dtdetallepedido
    End Function
    Public Function detallepedidoInsertar(cclasedetallepedido As ClaseDetallePedido, cn As SqlConnection, transaction As SqlTransaction) As Boolean
        'Dim cn As New SqlConnection
        'cn.ConnectionString = conexion.ccadena
        Dim codetallepedido As New SqlCommand("spRegistrarDetallePedido", cn)
        codetallepedido.CommandType = CommandType.StoredProcedure
        codetallepedido.Parameters.Add(New SqlParameter("@PedidoCodigo", SqlDbType.Int)).Value = cclasedetallepedido.Pedido.Codigo
        codetallepedido.Parameters.Add(New SqlParameter("@MedicamentoCodigo", SqlDbType.NChar, 50, ParameterDirection.Input)).Value = cclasedetallepedido.Medicamento.Codigo
        codetallepedido.Parameters.Add(New SqlParameter("@DetallePedidoImporte", SqlDbType.Decimal)).Value = cclasedetallepedido.DetalleImporte
        codetallepedido.Parameters.Add(New SqlParameter("@DetallePedidoCantidad", SqlDbType.Decimal)).Value = cclasedetallepedido.Cantidad
        codetallepedido.Parameters.Add(New SqlParameter("@DetallePedidoPrecio", SqlDbType.Decimal)).Value = cclasedetallepedido.Precio
        codetallepedido.Transaction = transaction

        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            codetallepedido.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            cn.Close()
        End Try
    End Function
End Class
