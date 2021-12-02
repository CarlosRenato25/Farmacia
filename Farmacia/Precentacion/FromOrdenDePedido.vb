Imports FarmaciaCapaNegocio
Imports FarmaciaCapaDatos

Public Class FromOrdenDePedido
    Dim dtcliente As DataTable
    Dim dtmedicamentos As DataTable
    Dim pedido As ClasePedido
    Private Sub cargarcliente()
        Dim negcliente As New NegocioClaseCliente
        dtcliente = negcliente.CreaTableAClientes
        cboClienteDNI.ValueMember = "ClienteCodigo"
        cboClienteDNI.DisplayMember = "ClienteNumeroDocumento"
        cboClienteDNI.DataSource = dtcliente
    End Sub

    Private Sub Inicializar()
        pedido = New ClasePedido
        dtpFechaPedido.Value = Date.Now
    End Sub

    Private Sub mostrarclientes()
        txtCodigoCliente.Text = dtcliente.Rows(cboClienteDNI.SelectedIndex).Item("ClienteCodigo").ToString
        txtNombreCliente.Text = dtcliente.Rows(cboClienteDNI.SelectedIndex).Item("ClienteNombre").ToString
        txtRucCliente.Text = dtcliente.Rows(cboClienteDNI.SelectedIndex).Item("ClienteNumeroDocumento").ToString
        txtTipoDocumento.Text = dtcliente.Rows(cboClienteDNI.SelectedIndex).Item("ClienteTipoDocumento").ToString
        txtDireccionCliente.Text = dtcliente.Rows(cboClienteDNI.SelectedIndex).Item("ClienteDireccion").ToString

    End Sub
    Private Sub cargarMedicamentos()
        Dim negmedicamentos As New NegocioClaseMedicamentos
        dtmedicamentos = negmedicamentos.crearmedicamentoslistados
        cboNombreMedicamento.ValueMember = "MedicamentosCodigo"
        cboNombreMedicamento.DisplayMember = "MedicamentosNombre"
        cboNombreMedicamento.DataSource = dtmedicamentos
    End Sub

    Private Sub mostrarMedicamentos()
        txtCodigoMedicamento.Text = dtmedicamentos.Rows(cboNombreMedicamento.SelectedIndex).Item("MedicamentosCodigo").ToString
        TxtStock.Text = dtmedicamentos.Rows(cboNombreMedicamento.SelectedIndex).Item("MedicamentosStock").ToString
        txtPrecioMedicamento.Text = dtmedicamentos.Rows(cboNombreMedicamento.SelectedIndex).Item("MedicamentosPrecioDeVenta").ToString
    End Sub





    Private Sub autogenerarNumeroPedido()
        Dim negpedido As New NegocioClasePedido

        txtNumeroPedido.Text = negpedido.negnumeropedido
    End Sub




    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub FromOrdenDePedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autogenerarNumeroPedido()
        cargarcliente()
        cargarMedicamentos()
        limpiarControlesCliente()
        limpiarControlesProducto()
        Inicializar()
    End Sub

    Public Sub limpiarControlesCliente()
        cboClienteDNI.SelectedIndex = -1
        txtCodigoCliente.Clear()
        txtTipoDocumento.Clear()
        txtNombreCliente.Clear()
        txtRucCliente.Clear()
        txtDireccionCliente.Clear()
    End Sub
    Public Sub limpiarControlesProducto()
        cboNombreMedicamento.SelectedIndex = -1
        txtCodigoMedicamento.Clear()
        txtCantidadMedicamento.Clear()
        txtPrecioMedicamento.Clear()
        TxtStock.Clear()
        lvDetallePedido.Items.Clear()
    End Sub

    Private Sub cboClienteDNI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClienteDNI.SelectedIndexChanged
        If cboClienteDNI.SelectedIndex <> -1 Then
            mostrarclientes()
        End If

    End Sub

    Private Sub cboNombreMedicamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreMedicamento.SelectedIndexChanged
        If cboNombreMedicamento.SelectedIndex <> -1 Then
            mostrarMedicamentos()
        End If
    End Sub

    Private Sub LlenarListaDetallePedido()
        lvDetallePedido.Items.Clear()
        For i As Integer = 0 To pedido.ListaDetallePedido.Count - 1
            Dim detallePedido = pedido.ListaDetallePedido(i)
            lvDetallePedido.Items().Add(detallePedido.Medicamento.Codigo)
            lvDetallePedido.Items(i).SubItems.Add(detallePedido.Medicamento.nombre)
            lvDetallePedido.Items(i).SubItems.Add(detallePedido.Cantidad.ToString)
            lvDetallePedido.Items(i).SubItems.Add(detallePedido.Precio.ToString)
            lvDetallePedido.Items(i).SubItems.Add(detallePedido.DetalleImporte.ToString)
        Next

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        If cboNombreMedicamento.SelectedIndex <> -1 And Trim(txtPrecioMedicamento.Text) <> "" And Trim(txtCodigoMedicamento.Text) <> "" And Trim(txtCantidadMedicamento.Text) <> "" Then
            Dim claseDetallePedido As New ClaseDetallePedido
            Dim claseMedicamento As New ClaseMedicamentos
            claseMedicamento.Codigo = txtCodigoMedicamento.Text
            claseMedicamento.nombre = cboNombreMedicamento.Text
            claseDetallePedido.Medicamento = claseMedicamento
            claseDetallePedido.Cantidad = Double.Parse(txtCantidadMedicamento.Text)
            claseDetallePedido.Precio = Double.Parse(txtPrecioMedicamento.Text)
            claseDetallePedido.DetalleImporte = claseDetallePedido.CalcularImporte
            pedido.AgregarDetallePedido(claseDetallePedido)
            pedido.totalpagar = pedido.CalcularTotalAPagar
            txttotalAPagar.Text = pedido.totalpagar
            limpiarControlesProducto()
            LlenarListaDetallePedido()
        End If
    End Sub

    Private Sub calcularVuelto()
        If txtSumaRecibida.Text.Trim <> "" Then
            Dim sumaRecibida = Double.Parse(txtSumaRecibida.Text)
            If sumaRecibida > pedido.totalpagar Then
                txtVuelto.Text = sumaRecibida - pedido.totalpagar
                Exit Sub
            End If
        End If
        txtVuelto.Text = 0
    End Sub

    Private Sub txtSumaRecibida_TextChanged(sender As Object, e As EventArgs) Handles txtSumaRecibida.TextChanged
        calcularVuelto()
    End Sub

    Private Sub btnRegistarVenta_Click(sender As Object, e As EventArgs) Handles btnRegistarVenta.Click
        Dim cliente = txtCodigoCliente.Text.Trim
        Dim totalApagar As Double
        Double.TryParse(txttotalAPagar.Text.Trim, totalApagar)
        Dim numeroorden = pedido.AutogenerarNumeroDeBoleta
        Dim fechapedido = dtpFechaPedido.Value.ToString

        If cliente <> "" And pedido.ListaDetallePedido.Count > 0 And fechapedido <> "" And totalApagar > 0 Then
            Dim negocio = New NegocioClasePedido
            Dim mensaje = negocio.NegpedidoInsertar(0, totalApagar, numeroorden, cliente, farmaceutico, fechapedido, "", pedido.ListaDetallePedido)
            MessageBox.Show(mensaje)
            limpiarControlesCliente()
            limpiarControlesProducto()
            Inicializar()
            autogenerarNumeroPedido()
            txttotalAPagar.Clear()

        End If
    End Sub
End Class