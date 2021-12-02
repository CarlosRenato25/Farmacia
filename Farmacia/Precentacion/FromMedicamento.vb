
Imports System.Data
Imports System.Data.SqlClient
Imports FarmaciaCapaNegocio
Public Class FromMedicamento
    Dim dsDatos As DataSet
    Dim vMedicamentoPosicion As Integer = 0
    Dim dvMedicamentos As DataView
    Private Sub ProductosCarga(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        MostrarMedicamentos()
        LlenarLista()
        LlenarLista2()
    End Sub
    Private Sub LlenarLista()
        LvMedicamento1.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("MedicamentosDeBotica").Rows.Count - 1
            LvMedicamento1.Items.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosCodigo").ToString)
            LvMedicamento1.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosNombre").ToString)
            LvMedicamento1.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosLaboratorio").ToString)
            LvMedicamento1.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosEspecificaciones").ToString)
            LvMedicamento1.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosStock").ToString)
            LvMedicamento1.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosPrecioDeCompra").ToString)
            LvMedicamento1.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosPrecioDeVenta").ToString)
            LvMedicamento1.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosCito").ToString)
            LvMedicamento1.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosFechaDeEntrada").ToString)
            LvMedicamento1.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosFechaVenceMedicamento").ToString)

        Next
    End Sub
    Private Sub LlenarLista2()
        LvMedicamento2.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("MedicamentosDeBotica").Rows.Count - 1
            LvMedicamento2.Items.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosCodigo").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosNombre").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosLaboratorio").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosEspecificaciones").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosStock").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosPrecioDeCompra").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosPrecioDeVenta").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosCito").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosFechaDeEntrada").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosFechaVenceMedicamento").ToString)

        Next
    End Sub
    Private Sub MostrarMedicamentos()
        If dsDatos.Tables("MedicamentosDeBotica").Rows.Count > 0 Then
            txtCodigo.Text = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosCodigo").ToString
            txtNombre.Text = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosNombre").ToString
            txtLaboratorio.Text = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosLaboratorio").ToString
            txtEspecificaciones.Text = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosEspecificaciones").ToString
            txtStock.Text = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosStock").ToString
            txtPrecioCompra.Text = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosPrecioDeCompra").ToString
            txtPrecioVenta.Text = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosPrecioDeVenta").ToString
            txtCitioHubicacion.Text = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosCito").ToString
            DateFechaEntrada.Text = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosFechaDeEntrada").ToString
            DateFechaCaducidad.Text = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosFechaVenceMedicamento").ToString
            cboAdministrador.SelectedValue = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosAdministradorCodigo")
            cboCategorias.SelectedValue = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosCategoriasCodigo")
            cboPrecentaciones.SelectedValue = dsDatos.Tables("MedicamentosDeBotica").Rows(vMedicamentoPosicion).Item("MedicamentosPrecentacionesCodigo")
        End If
    End Sub
    Private Sub CrearDataSet()
        dsDatos = New DataSet
        Dim pmedicmamentos As New NegocioClaseMedicamentos
        dsDatos.Tables.Add(pmedicmamentos.crearmedicamentoslistados)
        dsDatos.Tables.Add(pmedicmamentos.crearadministradorlistados)
        dsDatos.Tables.Add(pmedicmamentos.crearcategorialistados)
        dsDatos.Tables.Add(pmedicmamentos.crearpresentaioneslistados)

        'llenar el texbox
        cboAdministrador.DataSource = dsDatos.Tables("Administradora")
        cboAdministrador.DisplayMember = "AdministradorNombre"
        cboAdministrador.ValueMember = "AdministradorCodigo"

        cboCategorias.DataSource = dsDatos.Tables("Categorias")
        cboCategorias.DisplayMember = "CategoriaNombre"
        cboCategorias.ValueMember = "CategoriasCodigo"

        cboPrecentaciones.DataSource = dsDatos.Tables("Precentacion")
        cboPrecentaciones.DisplayMember = "PrecentacionesNombre"
        cboPrecentaciones.ValueMember = "PrecentacionesCodigo"
        Controles(False, False, False, False, False, False, False, False, False, False, False, False, False, False, True)
    End Sub
    Private Sub SeleccionarMedicamentos(sender As Object, e As EventArgs) Handles LvMedicamento1.SelectedIndexChanged
        If LvMedicamento1.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("MedicamentosDeBotica").Rows.Count - 1
            If LvMedicamento1.SelectedItems(0).Text = dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosCodigo").ToString Then
                vMedicamentoPosicion = i
                Exit For
            End If
        Next

        MostrarMedicamentos()

    End Sub
    Private Sub SeleccionarMedicamentos1(sender As Object, e As EventArgs) Handles LvMedicamento2.SelectedIndexChanged
        If LvMedicamento2.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("MedicamentosDeBotica").Rows.Count - 1
            If LvMedicamento2.SelectedItems(0).Text = dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosCodigo").ToString Then
                vMedicamentoPosicion = i
                Exit For
            End If
        Next

        MostrarMedicamentos()

    End Sub

    Private Sub Controles(Codigo As Boolean, Nombre As Boolean, laboratorio As Boolean, Especificaciones As Boolean,
      Stock As Boolean, precioCompra As Boolean, precioVenta As Boolean, CitioHubicacion As Boolean, administrador As Boolean, categorias As Boolean, precentaciones As Boolean, RegistroAdministrador As Boolean, FechaDeEntrada As Boolean, FechaCaducidad As Boolean, Lista As Boolean)
        txtCodigo.Enabled = Codigo
        txtNombre.Enabled = Nombre
        txtLaboratorio.Enabled = laboratorio
        txtEspecificaciones.Enabled = Especificaciones
        txtStock.Enabled = Stock
        txtPrecioCompra.Enabled = precioCompra
        txtPrecioVenta.Enabled = precioVenta
        txtCitioHubicacion.Enabled = CitioHubicacion
        cboAdministrador.Enabled = administrador
        cboCategorias.Enabled = categorias
        cboPrecentaciones.Enabled = precentaciones
        gbRegistroMedicamentos.Enabled = RegistroAdministrador
        DateFechaEntrada.Enabled = FechaDeEntrada
        DateFechaCaducidad.Enabled = FechaCaducidad
        LvMedicamento1.Enabled = Lista


    End Sub
    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean, Cancelar As Boolean, Salir As Boolean)
        cmdAgregar.Enabled = Agregar
        cmdEditar.Enabled = Editar
        cmdEliminar.Enabled = Eliminar
        cmdCancelar.Enabled = Cancelar
        cmdCerrar.Enabled = Salir


    End Sub
    Private Sub ProductosAgregar(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdAgregar.Text = "Agregar" Then
            cmdAgregar.Text = "Guardar"
            Botones(True, False, False, True, False)
            Controles(False, True, True, True, True, True, True, True, True, True, True, True, True, True, False)
            txtCodigo.Clear() : txtNombre.Clear() : txtLaboratorio.Clear() : txtEspecificaciones.Clear() : txtStock.Clear() : txtPrecioCompra.Clear() : txtPrecioVenta.Clear() : txtCitioHubicacion.Clear()
            txtCodigo.Focus()
            txtNombre.Select()

        Else
            If Len(Trim(txtNombre.Text)) = 0 Then
                MessageBox.Show("Falta el nombre")

                Exit Sub
            End If
            If Len(Trim(txtLaboratorio.Text)) = 0 Then
                MessageBox.Show("Falta el laboratorio")

                Exit Sub
            End If
            If Len(Trim(txtEspecificaciones.Text)) = 0 Then
                MessageBox.Show("Falta las especificaciones")

                Exit Sub
            End If
            If Len(Trim(txtCitioHubicacion.Text)) = 0 Then
                MessageBox.Show("Falta la hubicacion")

                Exit Sub
            End If
            'Consistencia de los datos
            'Precio
            If (txtStock.Text) = False Then
                MessageBox.Show("Stock incorrecto...")
                Exit Sub
            End If
            'Precio
            If CompruebaIngresoDatoNumerico(txtPrecioCompra.Text) = False Then
                MessageBox.Show("precio de Compra incorrecto...")
                Exit Sub
            End If
            If CompruebaIngresoDatoNumerico(txtPrecioVenta.Text) = False Then
                MessageBox.Show("precio de Venta incorrecto...")
                Exit Sub
            End If

            Dim nmedicamentosagregar As New NegocioClaseMedicamentos
            If nmedicamentosagregar.negMedicamentosInsertar(txtCodigo.Text, txtNombre.Text, txtLaboratorio.Text, txtEspecificaciones.Text, txtStock.Text, txtPrecioCompra.Text, txtPrecioVenta.Text, txtLaboratorio.Text, DateFechaEntrada.Text, DateFechaCaducidad.Text, cboCategorias.SelectedValue, cboPrecentaciones.SelectedValue, cboAdministrador.SelectedValue, "A") Then
                MessageBox.Show("Registro insertado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
            Else
                MessageBox.Show("No se pudo insertar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            cmdAgregar.Text = "Agregar"

                Botones(True, True, True, False, True)
                Controles(False, False, False, False, False, False, False, False, False, False, False, False, False, False, True)
            End If

    End Sub
    Private Sub proveedorEditar(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Editar" Then
            cmdEditar.Text = "Guardar"
            Botones(False, True, False, True, False)
            Controles(False, True, True, True, True, True, True, True, True, True, True, True, True, True, False)
            vMedicamentoPosicion = 2 'DOS es Editar
            txtNombre.Focus()
            txtNombre.Select()
        Else  'Guardar

            If Len(Trim(txtNombre.Text)) = 0 Then
                MessageBox.Show("Falta el nombre")

                Exit Sub
            End If
            If Len(Trim(txtLaboratorio.Text)) = 0 Then
                MessageBox.Show("Falta laboratorio")

                Exit Sub
            End If
            If Len(Trim(txtEspecificaciones.Text)) = 0 Then
                MessageBox.Show("Falta especificaciones")

                Exit Sub
            End If
            If Len(Trim(txtCitioHubicacion.Text)) = 0 Then
                MessageBox.Show("Falta la hubicacion ")

                Exit Sub
            End If
            'Consistencia de los datos
            'Precio
            If CompruebaIngresoDatoNumerico(txtStock.Text) = False Then
                MessageBox.Show("Stock incorrecto...")
                Exit Sub
            End If
            'Precio
            If CompruebaIngresoDatoNumerico(txtPrecioCompra.Text) = False Then
                MessageBox.Show("precio de Compra incorrecto...")
                Exit Sub
            End If
            If CompruebaIngresoDatoNumerico(txtPrecioVenta.Text) = False Then
                MessageBox.Show("precio de Venta incorrecto...")
                Exit Sub
            End If

            Dim nmedicamentoseditar As New NegocioClaseMedicamentos
            If nmedicamentoseditar.negMedicamentosEditar(txtCodigo.Text, txtNombre.Text, txtLaboratorio.Text, txtEspecificaciones.Text, txtStock.Text, txtPrecioCompra.Text, txtPrecioVenta.Text, txtLaboratorio.Text, DateFechaEntrada.Text, DateFechaCaducidad.Text, cboCategorias.SelectedValue, cboPrecentaciones.SelectedValue, cboAdministrador.SelectedValue, "A") Then
                MessageBox.Show("Registro editado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
            Else
                MessageBox.Show("No se pudo insertar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            cmdEditar.Text = "Editar"
            Controles(False, False, False, False, False, False, False, False, False, False, False, False, False, False, True)
            Botones(True, True, True, False, True)
        End If
    End Sub
    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("¿Desea eliminar" & vbCrLf & txtNombre.Text & "?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) = DialogResult.OK Then

            Dim nmedicamentoseliminar As New NegocioClaseMedicamentos
            If nmedicamentoseliminar.negMedicamentoseliminar(txtCodigo.Text, txtNombre.Text, txtLaboratorio.Text, txtEspecificaciones.Text, txtStock.Text, txtPrecioCompra.Text, txtPrecioVenta.Text, txtLaboratorio.Text, DateFechaEntrada.Text, DateFechaCaducidad.Text, cboCategorias.SelectedValue, cboPrecentaciones.SelectedValue, cboAdministrador.SelectedValue, "A") Then
                MessageBox.Show("Registro eliminado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
                vMedicamentoPosicion = 0
                MostrarMedicamentos()
            Else
                MessageBox.Show("No se pudo insertar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If
        End If
    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdAgregar.Text = "Agregar"
        cmdEditar.Text = "Editar"
        Botones(True, True, True, False, True)
        vMedicamentoPosicion = 0
        Controles(False, False, False, False, False, False, False, False, False, False, False, False, False, False, True)
        MostrarMedicamentos()
    End Sub
    'MedicamentosCodigo nchar(50),
    'MedicamentosNombre nvarchar (50),
    'MedicamentosLaboratorio nvarchar(50),
    'MedicamentosEspecificaciones nvarchar(100),
    'MedicamentosStock Numeric(10, 2),
    'MedicamentosPrecioDeCompra numeric (10,2) ,
    'MedicamentosPrecioDeVenta numeric(10, 2),
    'MedicamentosCito nvarchar(50),
    'MedicamentosFechaDeEntrada  date,
    'MedicamentosFechaVenceMedicamento  date ,
    'MedicamentosCategoriasCodigo nchar(17),
    'MedicamentosPrecentacionesCodigo nchar(17),
    'MedicamentosAdministradorCodigo nchar(17),
    'MedicamentosEstado nchar(1) Not null,
    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Private Sub DatoEscribir(sender As Object, e As EventArgs) Handles txtBuscarMedicamentos.TextChanged
        If RadioNombre.Checked = True Then
            vMedicamentoPosicion = 0
            'Por Libro
            dvMedicamentos = New DataView(dsDatos.Tables("MedicamentosDeBotica"))
            dvMedicamentos.RowFilter = "MedicamentosNombre like '%" & txtBuscarMedicamentos.Text & "%'"
            LvMedicamento2.Columns.Clear()
            LvMedicamento2.Columns.Add("MedicamentosCodigo", 150)
            LvMedicamento2.Columns.Add("MedicamentosNombre", 150)
            LvMedicamento2.Columns.Add("MedicamentosLaboratorio", 160)
            LvMedicamento2.Columns.Add("MedicamentosEspecificaciones", 200)
            LvMedicamento2.Columns.Add("MedicamentosStock", 160)
            LvMedicamento2.Columns.Add("MedicamentosPrecioDeCompra", 160)
            LvMedicamento2.Columns.Add("MedicamentosPrecioDeVenta", 160)
            LvMedicamento2.Columns.Add("MedicamentosCito", 200)
            LvMedicamento2.Columns.Add("MedicamentosFechaDeEntrada", 200)
            LvMedicamento2.Columns.Add("MedicamentosFechaVenceMedicamento", 200)
            LvMedicamento2.Items.Clear()

            For i As Integer = 0 To dvMedicamentos.Count - 1
                LvMedicamento2.Items.Add(dvMedicamentos.Item(i).Item("MedicamentosCodigo").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosNombre").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosLaboratorio").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosEspecificaciones").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosStock").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosPrecioDeCompra").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosPrecioDeVenta").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosCito").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosFechaDeEntrada").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosFechaVenceMedicamento").ToString)
            Next

        ElseIf RadioLaboratorio.Checked = True Then
            vMedicamentoPosicion = 1
            dvMedicamentos = New DataView(dsDatos.Tables("MedicamentosDeBotica"))
            dvMedicamentos.RowFilter = "MedicamentosLaboratorio like '%" & txtBuscarMedicamentos.Text & "%'"
            LvMedicamento2.Columns.Clear()
            LvMedicamento2.Columns.Add("MedicamentosCodigo", 150)
            LvMedicamento2.Columns.Add("MedicamentosNombre", 150)
            LvMedicamento2.Columns.Add("MedicamentosLaboratorio", 160)
            LvMedicamento2.Columns.Add("MedicamentosEspecificaciones", 200)
            LvMedicamento2.Columns.Add("MedicamentosStock", 160)
            LvMedicamento2.Columns.Add("MedicamentosPrecioDeCompra", 160)
            LvMedicamento2.Columns.Add("MedicamentosPrecioDeVenta", 160)
            LvMedicamento2.Columns.Add("MedicamentosCito", 200)
            LvMedicamento2.Columns.Add("MedicamentosFechaDeEntrada", 200)
            LvMedicamento2.Columns.Add("MedicamentosFechaVenceMedicamento", 200)
            LvMedicamento2.Items.Clear()

            For i As Integer = 0 To dvMedicamentos.Count - 1
                LvMedicamento2.Items.Add(dvMedicamentos.Item(i).Item("MedicamentosCodigo").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosNombre").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosLaboratorio").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosEspecificaciones").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosStock").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosPrecioDeCompra").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosPrecioDeVenta").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosCito").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosFechaDeEntrada").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosFechaVenceMedicamento").ToString)
            Next

        Else
            vMedicamentoPosicion = 2
            dvMedicamentos = New DataView(dsDatos.Tables("MedicamentosDeBotica"))
            dvMedicamentos.RowFilter = "MedicamentosCito like '%" & txtBuscarMedicamentos.Text & "%'"
            LvMedicamento2.Columns.Clear()
            LvMedicamento2.Columns.Add("MedicamentosCodigo", 150)
            LvMedicamento2.Columns.Add("MedicamentosNombre", 150)
            LvMedicamento2.Columns.Add("MedicamentosLaboratorio", 160)
            LvMedicamento2.Columns.Add("MedicamentosEspecificaciones", 200)
            LvMedicamento2.Columns.Add("MedicamentosStock", 160)
            LvMedicamento2.Columns.Add("MedicamentosPrecioDeCompra", 160)
            LvMedicamento2.Columns.Add("MedicamentosPrecioDeVenta", 160)
            LvMedicamento2.Columns.Add("MedicamentosCito", 200)
            LvMedicamento2.Columns.Add("MedicamentosFechaDeEntrada", 200)
            LvMedicamento2.Columns.Add("MedicamentosFechaVenceMedicamento", 200)
            LvMedicamento2.Items.Clear()

            For i As Integer = 0 To dvMedicamentos.Count - 1
                LvMedicamento2.Items.Add(dvMedicamentos.Item(i).Item("MedicamentosCodigo").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosNombre").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosLaboratorio").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosEspecificaciones").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosStock").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosPrecioDeCompra").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosPrecioDeVenta").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosCito").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosFechaDeEntrada").ToString)
                LvMedicamento2.Items(i).SubItems.Add(dvMedicamentos.Item(i).Item("MedicamentosFechaVenceMedicamento").ToString)
            Next

        End If

    End Sub
    Private Sub optdni_Click(sender As Object, e As EventArgs) Handles RadioNombre.Click
        vMedicamentoPosicion = 0
        txtBuscarMedicamentos.Clear()
        'Autores
        LvMedicamento2.Columns.Clear()
        LvMedicamento2.Columns.Add("MedicamentosCodigo", 200)
        LvMedicamento2.Columns.Add("MedicamentosNombre", 300)
        LvMedicamento2.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("MedicamentosDeBotica").Rows.Count - 1
            LvMedicamento2.Items.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosCodigo").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosNombre").ToString)

        Next
    End Sub
    Private Sub optlaboratorio_Click(sender As Object, e As EventArgs) Handles RadioLaboratorio.Click
        vMedicamentoPosicion = 2
        txtBuscarMedicamentos.Clear()
        'Autores
        LvMedicamento2.Columns.Clear()
        LvMedicamento2.Columns.Add("MedicamentosCodigo", 200)
        LvMedicamento2.Columns.Add("MedicamentosLaboratorio", 300)
        LvMedicamento2.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("MedicamentosDeBotica").Rows.Count - 1
            LvMedicamento2.Items.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosCodigo").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosLaboratorio").ToString)

        Next
    End Sub
    Private Sub optnombre_Click(sender As Object, e As EventArgs) Handles RadioHubicacion.Click
        vMedicamentoPosicion = 1
        txtBuscarMedicamentos.Clear()
        'Autores
        LvMedicamento2.Columns.Clear()
        LvMedicamento2.Columns.Add("MedicamentosCodigo", 200)
        LvMedicamento2.Columns.Add("MedicamentosCito", 300)
        LvMedicamento2.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("MedicamentosDeBotica").Rows.Count - 1
            LvMedicamento2.Items.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosCodigo").ToString)
            LvMedicamento2.Items(i).SubItems.Add(dsDatos.Tables("MedicamentosDeBotica").Rows(i).Item("MedicamentosCito").ToString)

        Next
    End Sub


    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        NumerosyDecimal(txtStock, e)
    End Sub

    Private Sub txtPrecioCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioCompra.KeyPress
        NumerosyDecimal(txtPrecioCompra, e)
    End Sub

    Private Sub txtPrecioVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioVenta.KeyPress
        NumerosyDecimal(txtPrecioVenta, e)
    End Sub

    Private Sub RadioNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RadioNombre.CheckedChanged

    End Sub


End Class