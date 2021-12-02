
Imports System.Data
Imports System.Data.SqlClient
Imports FarmaciaCapaNegocio
Public Class FromCliente
    Dim dsDatos As DataSet
    Dim vClientePosicion As Integer = 0
    Dim dvCliente As DataView

    Private Sub ClienteCarga(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        MostrarClientes()
        LlenarLista()
        LlenarLista2()
        LimpiarControles()
        Controles(False, False, False, False, False, False, False, False, False, False, True)
    End Sub
    Private Sub LlenarLista()
        lvClientes.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Cliente").Rows.Count - 1
            lvClientes.Items.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteCodigo").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteNombre").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteTipoDocumento").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteNumeroDocumento").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteTelefono").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteDireccion").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteFechaDeNacimiento").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteSexo").ToString)
        Next
    End Sub
    Private Sub LlenarLista2()
        Lvclientes1.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Cliente").Rows.Count - 1
            Lvclientes1.Items.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteCodigo").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteNombre").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteTipoDocumento").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteNumeroDocumento").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteTelefono").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteDireccion").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteFechaDeNacimiento").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteSexo").ToString)
        Next
    End Sub
    Private Sub MostrarClientes()
        If dsDatos.Tables("Cliente").Rows.Count > 0 Then
            txtCodigo.Text = dsDatos.Tables("Cliente").Rows(vClientePosicion).Item("ClienteCodigo").ToString
            txtNombre.Text = dsDatos.Tables("Cliente").Rows(vClientePosicion).Item("ClienteNombre").ToString
            txtDireccion.Text = dsDatos.Tables("Cliente").Rows(vClientePosicion).Item("ClienteDireccion").ToString
            cbTipodocumento.Text = dsDatos.Tables("Cliente").Rows(vClientePosicion).Item("ClienteTipoDocumento").ToString
            txtTelefono.Text = dsDatos.Tables("Cliente").Rows(vClientePosicion).Item("ClienteTelefono").ToString
            txtNumeroDocumento.Text = dsDatos.Tables("Cliente").Rows(vClientePosicion).Item("ClienteNumeroDocumento").ToString
            cbAdministrador.SelectedValue = dsDatos.Tables("Cliente").Rows(vClientePosicion).Item("ClienteAdministradorCodigo")

            dtpFechaDeNacimiento.Text = dsDatos.Tables("Cliente").Rows(vClientePosicion).Item("ClienteFechaDeNacimiento").ToString
            RadioMasculino.Checked = IIf(dsDatos.Tables("Cliente").Rows(vClientePosicion).Item("ClienteSexo").ToString = "M", True, False)
            RadioFemenino.Checked = IIf(dsDatos.Tables("Cliente").Rows(vClientePosicion).Item("ClienteSexo").ToString = "F", True, False)

        End If

    End Sub
    Private Sub CrearDataSet()
        dsDatos = New DataSet
        Dim pClaseClientes As New NegocioClaseCliente
        dsDatos.Tables.Add(pClaseClientes.CreaTableAClientes)
        dsDatos.Tables.Add(pClaseClientes.CreaTableAdministrador)

        'llenar el texbox
        cbAdministrador.DataSource = dsDatos.Tables("Administradora")
        cbAdministrador.DisplayMember = "AdministradorNombre"
        cbAdministrador.ValueMember = "AdministradorCodigo"
    End Sub
    Private Sub SeleccionarClientes(sender As Object, e As EventArgs) Handles lvClientes.SelectedIndexChanged
        If lvClientes.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Cliente").Rows.Count - 1
            If lvClientes.SelectedItems(0).Text = dsDatos.Tables("Cliente").Rows(i).Item("ClienteCodigo").ToString Then
                vClientePosicion = i
                Exit For
            End If
        Next

        MostrarClientes()
    End Sub
    Private Sub SeleccionarClientes2(sender As Object, e As EventArgs)
        If Lvclientes1.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Cliente").Rows.Count - 1
            If Lvclientes1.SelectedItems(0).Text = dsDatos.Tables("Cliente").Rows(i).Item("ClienteCodigo").ToString Then
                vClientePosicion = i
                Exit For
            End If
        Next


        MostrarClientes()
    End Sub
    Private Sub Controles(Codigo As Boolean, Nombre As Boolean, Direccion As Boolean,
   FechaDenacimiento As Boolean, Telefono As Boolean, tipodocumento As Boolean, numerodocumento As Boolean, Sexo As Boolean, ClienteAdministrador As Boolean, RegistroAdministrador As Boolean, Lista As Boolean)
        txtCodigo.Enabled = Codigo
        txtNombre.Enabled = Nombre
        txtDireccion.Enabled = Direccion
        txtNumeroDocumento.Enabled = numerodocumento
        txtTelefono.Enabled = Telefono
        cbTipodocumento.Enabled = tipodocumento
        dtpFechaDeNacimiento.Enabled = FechaDenacimiento
        gbSexo.Enabled = Sexo
        cbAdministrador.Enabled = ClienteAdministrador
        gbRegistro.Enabled = RegistroAdministrador
        lvClientes.Enabled = Lista
    End Sub
    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean, Cancelar As Boolean, Salir As Boolean)
        cmdAgregar.Enabled = Agregar
        cmdEditar.Enabled = Editar
        cmdEliminar.Enabled = Eliminar
        cmdCancelar.Enabled = Cancelar
        cmdCerrar.Enabled = Salir



    End Sub
    Private Sub LimpiarControles()
        RadioMasculino.Checked = False
        RadioFemenino.Checked = False
        dtpFechaDeNacimiento.Value = Now
        txtCodigo.Clear() : txtNombre.Clear() : txtDireccion.Clear() : txtTelefono.Clear() : txtNumeroDocumento.Clear()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdAgregar.Text = "Agregar" Then
            cmdAgregar.Text = "Guardar"
            Controles(False, True, True, True, True, True, True, True, True, True, False)
            Botones(True, False, False, True, False)
            LimpiarControles()
            activarfechaySexo()
            'txtCodigo.Clear() : txtNombre.Clear() : txtDireccion.Clear() : txtTelefono.Clear() : txtNumeroDocumento.Clear()
            'txtCodigo.Focus()

        Else
            If Len(Trim(txtNumeroDocumento.Text)) = 0 Then
                MessageBox.Show("Falta el numero ducumento")
                Exit Sub
            End If
            If Len(Trim(txtNombre.Text)) = 0 Then
                MessageBox.Show("Falta el nombre")

                Exit Sub
            End If
            If Len(Trim(txtTelefono.Text)) = 0 Then
                MessageBox.Show("Falta el  telefono")
                Exit Sub
            End If
            If Len(Trim(txtDireccion.Text)) = 0 Then
                MessageBox.Show("Falta  la direccion")
                Exit Sub
            End If

            Dim pClaseClintes As New NegocioClaseCliente
            Dim sexo = ""
            If RadioMasculino.Checked Then
                sexo = "M"
            ElseIf RadioFemenino.Checked Then
                sexo = "F"
            End If
            Dim Fecha = ""
            If cbTipodocumento.Text = "DNI" Then
                Fecha = dtpFechaDeNacimiento.Text
            End If
            If pClaseClintes.NegClientesInsertar(txtCodigo.Text, txtNombre.Text, cbTipodocumento.Text, txtNumeroDocumento.Text, txtTelefono.Text, txtDireccion.Text, Fecha, sexo, cbAdministrador.SelectedValue, "A") Then
                MessageBox.Show("Registro insertado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
                LimpiarControles()
                activarfechaySexo()
            Else
                MessageBox.Show("No se pudo insertar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            cmdAgregar.Text = "Agregar"
            Botones(True, True, True, False, True)
            Controles(False, False, False, False, False, False, False, False, False, False, True)
        End If

    End Sub
    Private Sub ClienteEditar(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Editar" Then
            cmdEditar.Text = "Guardar"
            Botones(False, True, False, True, False)
            Controles(False, True, True, True, True, False, True, True, True, True, False)
            activarfechaySexo()
            vClientePosicion = 2 'DOS es Editar
            txtNombre.Focus()
        Else  'Guardar

            If Len(Trim(txtNumeroDocumento.Text)) = 0 Then
                MessageBox.Show("Falta el numero ducumento")
                Exit Sub
            End If
            If Len(Trim(txtNombre.Text)) = 0 Then
                MessageBox.Show("Falta el nombre")

                Exit Sub
            End If
            If Len(Trim(txtTelefono.Text)) = 0 Then
                MessageBox.Show("Falta el  telefono")
                Exit Sub
            End If
            If Len(Trim(txtDireccion.Text)) = 0 Then
                MessageBox.Show("Falta  la direccion")
                Exit Sub
            End If

            Dim pClaseClintes As New NegocioClaseCliente

            Dim sexo = ""
            If RadioMasculino.Checked Then
                sexo = "M"
            ElseIf RadioFemenino.Checked Then
                sexo = "F"
            End If
            Dim Fecha = ""
            If cbTipodocumento.Text = "DNI" Then
                Fecha = dtpFechaDeNacimiento.Text
            End If
            If pClaseClintes.NegClientesEditar(txtCodigo.Text, txtNombre.Text, cbTipodocumento.Text, txtNumeroDocumento.Text, txtTelefono.Text, txtDireccion.Text, Fecha, sexo, cbAdministrador.SelectedValue, "A") Then
                MessageBox.Show("Registro editado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
                LimpiarControles()
                activarfechaySexo()
            Else
                MessageBox.Show("No se pudo insertar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            cmdEditar.Text = "Editar"
            Controles(False, False, False, False, False, False, False, False, False, False, True)
            Botones(True, True, True, False, True)
        End If
    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdAgregar.Text = "Agregar"
        cmdEditar.Text = "Editar"
        Botones(True, True, True, False, True)
        vClientePosicion = 0

        Controles(False, False, False, False, False, False, False, False, False, False, True)
        MostrarClientes()
    End Sub
    Private Sub AdministradorEliminar(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("¿Desea eliminar" & vbCrLf & txtNombre.Text & "?", "Eliminación de clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
            Dim pClaseClintes As New NegocioClaseCliente
            If pClaseClintes.NegClientesEliminar(txtCodigo.Text, txtNombre.Text, txtNumeroDocumento.Text, cbTipodocumento.SelectedValue, txtTelefono.Text, txtDireccion.Text, dtpFechaDeNacimiento.Text, (IIf(RadioMasculino.Checked = True, "M", "F")), cbAdministrador.SelectedValue, "A") Then
                MessageBox.Show("Registro eliminado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
                MostrarClientes()
                vClientePosicion = 0
            Else
                MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

    End Sub
    Private Sub DatoEscribir(sender As Object, e As EventArgs) Handles txtBuscadorClientes.TextChanged
        'ClienteCodigo nchar(17),
        'ClienteNombre nvarchar (50),
        'ClienteTipoDucumento nvarchar(20),
        'ClienteNumeroDocumento nvarchar (15),
        'ClienteTelefono nvarchar(9),
        'ClienteSexo nchar (1),
        'ClienteDireccion nvarchar(100),
        'ClienteFechaDeNacimiento Date,
        'ClienteEstado nchar(1) Not null,
        'ClienteAdministradorCodigo nchar(17),
        If optNumeroDocumento.Checked Then
            vClientePosicion = 0
            'Por Libro
            dvCliente = New DataView(dsDatos.Tables("Cliente"))
            dvCliente.RowFilter = "ClienteNumerDocumento like '%" & txtBuscadorClientes.Text & "%'"
            Lvclientes1.Columns.Clear()
            Lvclientes1.Columns.Add("ClienteCodigo", 150)
            Lvclientes1.Columns.Add("ClienteNombre", 160)
            Lvclientes1.Columns.Add("Tipo Documento", 200)
            Lvclientes1.Columns.Add("Numero Docuemento", 200)
            Lvclientes1.Columns.Add("ClienteTelefono", 160)
            Lvclientes1.Columns.Add("ClienteDireccion", 200)
            Lvclientes1.Columns.Add("ClienteFechaDeNacimiento", 200)
            Lvclientes1.Columns.Add("ClienteSexo", 160)
            Lvclientes1.Items.Clear()

            For i As Integer = 0 To dvCliente.Count - 1
                Lvclientes1.Items.Add(dvCliente.Item(i).Item("ClienteCodigo").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteNombre").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteTipoDocumento").ToString)
                'Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteRuc").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteNumeroDocumento").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteTelefono").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteDireccion").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteFechaDeNacimiento").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteSexo").ToString)

            Next
        Else
            vClientePosicion = 1
            dvCliente = New DataView(dsDatos.Tables("Cliente"))
            dvCliente.RowFilter = "ClienteNombre like '%" & txtBuscadorClientes.Text & "%'"
            Lvclientes1.Columns.Clear()
            Lvclientes1.Columns.Add("ClienteCodigo", 150)
            Lvclientes1.Columns.Add("ClienteNombre", 160)
            Lvclientes1.Columns.Add("TipoDocumento", 200)
            Lvclientes1.Columns.Add("NumeroDocumento", 200)
            Lvclientes1.Columns.Add("ClienteTelefono", 160)
            Lvclientes1.Columns.Add("ClienteDireccion", 200)
            Lvclientes1.Columns.Add("ClienteFechaDeNacimiento", 200)
            Lvclientes1.Columns.Add("ClienteSexo", 160)
            Lvclientes1.Items.Clear()

            For i As Integer = 0 To dvCliente.Count - 1
                Lvclientes1.Items.Add(dvCliente.Item(i).Item("ClienteCodigo").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteNombre").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteTipoDocumento").ToString)
                'Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteRuc").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteNumeroDocumento").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteTelefono").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteDireccion").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteFechaDeNacimiento").ToString)
                Lvclientes1.Items(i).SubItems.Add(dvCliente.Item(i).Item("ClienteSexo").ToString)

            Next
        End If

    End Sub
    Private Sub optdni1_Click(sender As Object, e As EventArgs)
        vClientePosicion = 0
        txtBuscadorClientes.Clear()
        'Autores
        Lvclientes1.Columns.Clear()
        Lvclientes1.Columns.Add("ClienteCodigo", 200)
        Lvclientes1.Columns.Add("ClienteDni", 300)
        Lvclientes1.Columns.Add("ClienteNombre", 300)
        Lvclientes1.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Cliente").Rows.Count - 1
            Lvclientes1.Items.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteCodigo").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteDni").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteNombre").ToString)
        Next
    End Sub
    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cbTipodocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipodocumento.SelectedIndexChanged
        If cbTipodocumento.Text = "DNI" Then
            txtNumeroDocumento.MaxLength = 8
            dtpFechaDeNacimiento.Enabled = True
            gbSexo.Enabled = True
            dtpFechaDeNacimiento.Visible = True
            gbSexo.Visible = True
            lblFechaNacimiento.Visible = True
        ElseIf cbTipodocumento.Text = "RUC" Then
            txtNumeroDocumento.MaxLength = 11
            dtpFechaDeNacimiento.Enabled = False
            gbSexo.Enabled = False
            dtpFechaDeNacimiento.Visible = False
            gbSexo.Visible = False
            lblFechaNacimiento.Visible = False
        End If
    End Sub

    Private Sub activarfechaySexo()
        If cbTipodocumento.Text = "DNI" Then
            dtpFechaDeNacimiento.Enabled = True
            gbSexo.Enabled = True
            dtpFechaDeNacimiento.Visible = True
            gbSexo.Visible = True
            lblFechaNacimiento.Visible = True
        ElseIf cbTipodocumento.Text = "RUC" Then
            dtpFechaDeNacimiento.Enabled = False
            gbSexo.Enabled = False
            dtpFechaDeNacimiento.Visible = False
            gbSexo.Visible = False
            lblFechaNacimiento.Visible = False
        End If
    End Sub


    Private Sub txtNumeroDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroDocumento.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub optNumeroDocumento_Click(sender As Object, e As EventArgs) Handles optNumeroDocumento.Click
        vClientePosicion = 0
        txtBuscadorClientes.Clear()
        'Autores
        Lvclientes1.Columns.Clear()
        Lvclientes1.Columns.Add("ClienteCodigo", 200)
        Lvclientes1.Columns.Add("ClienteNumeroDocumento", 300)
        Lvclientes1.Columns.Add("ClienteNombre", 300)
        Lvclientes1.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Cliente").Rows.Count - 1
            Lvclientes1.Items.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteCodigo").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteNumeroDocumento").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteNombre").ToString)
        Next
    End Sub

    Private Sub optNombre_Click(sender As Object, e As EventArgs) Handles optNombre.Click
        vClientePosicion = 0
        txtBuscadorClientes.Clear()
        'Autores
        Lvclientes1.Columns.Clear()
        Lvclientes1.Columns.Add("ClienteCodigo", 200)
        Lvclientes1.Columns.Add("ClienteNumeroDocumento", 300)
        Lvclientes1.Columns.Add("ClienteNombre", 300)
        Lvclientes1.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Cliente").Rows.Count - 1
            Lvclientes1.Items.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteCodigo").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteNumeroDocumento").ToString)
            Lvclientes1.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteNombre").ToString)
        Next
    End Sub







    ' @ClienteNombre nvarchar (50),
    '@ClienteApellidos nvarchar (50),
    '@ClienteRuc nvarchar (50),
    '@ClienteDni nvarchar(8),
    '@ClienteTelefono nvarchar (9),
    '@ClienteSexo nchar (1),
    '@ClienteDireccion nvarchar (100) ,
    '@ClienteFechaDeNacimiento date,
    '@ClienteEstado nchar(1),
    '@ClienteAdministradorCodigo nchar(17)+"




End Class