
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports FarmaciaCapaDatos
Public Class NegocioClasePedido

    Public Function NegpedidoInsertar(_Codigo As String, _totalpagar As Double, _numeroOrden As String, _cliente As String, _farmaceutico As String, _fechapedido As Date, _estado As String, negDetallePedido As List(Of ClaseDetallePedido)) As String
        Dim mensaje = ""
        Dim nPedido As New FarmaciaCapaDatos.ClasePedido(_Codigo, _totalpagar, _numeroOrden, _cliente, _farmaceutico, _fechapedido, _estado)
        nPedido.ListaDetallePedido = negDetallePedido
        'Ejecutar el método definido en la capa de acceso a datos
        'For Each detallePedido In nPedido.ListaDetallePedido
        '    If Not detallePedido.esStockValido Then
        '        Return "No hay stock."
        '    End If
        'Next

        If nPedido.pedidoInsertar(nPedido) Then
            mensaje = "Se registro el pedido."
        Else
            mensaje = "No se registro el pedido."
        End If
        Return mensaje
    End Function

    Public Function negnumeropedido() As Integer
        Dim danumeropedido As New ClasePedido()
        Dim numeropedido = danumeropedido.AutogenerarNumeroDeBoleta
        Return numeropedido
    End Function
End Class
