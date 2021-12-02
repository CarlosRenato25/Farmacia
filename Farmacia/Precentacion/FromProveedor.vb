Imports System.Data
Imports System.Data.SqlClient
Imports FarmaciaCapaNegocio
Imports System.IO
Public Class FromProveedor
    Dim dsDatos As DataSet
    Dim vProveedorPosicion As Integer = 0
    Dim dvProveedor As DataView
    Private Sub ProductosCarga(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        MostrarProveedores()
        LlenarLista()
        LlenarLista2()
    End Sub
    Private Sub LlenarLista()
        lvProveedores.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Proveedores").Rows.Count - 1
            lvProveedores.Items.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorCodigo").ToString)
            lvProveedores.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorNombre").ToString)
            lvProveedores.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorApellidos").ToString)
            lvProveedores.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorDni").ToString)
            lvProveedores.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorTelefono").ToString)
            lvProveedores.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorFechaDeEntrada").ToString)
            lvProveedores.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorSexo").ToString)
            lvProveedores.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorDireccion").ToString)
        Next

    End Sub
    Private Sub LlenarLista2()
        lvproveedor1.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Proveedores").Rows.Count - 1
            lvproveedor1.Items.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorCodigo").ToString)
            lvproveedor1.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorNombre").ToString)
            lvproveedor1.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorApellidos").ToString)
            lvproveedor1.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorDni").ToString)
            lvproveedor1.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorTelefono").ToString)
            lvproveedor1.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorFechaDeEntrada").ToString)
            lvproveedor1.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorSexo").ToString)
            lvproveedor1.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorDireccion").ToString)
        Next
    End Sub
    Private Sub MostrarProveedores()
        If dsDatos.Tables("Proveedores").Rows.Count > 0 Then
            txtCodigo.Text = dsDatos.Tables("Proveedores").Rows(vProveedorPosicion).Item("ProveedorCodigo").ToString
            txtNombre.Text = dsDatos.Tables("Proveedores").Rows(vProveedorPosicion).Item("ProveedorNombre").ToString
            txtApellidos.Text = dsDatos.Tables("Proveedores").Rows(vProveedorPosicion).Item("ProveedorApellidos").ToString
            txtDireccion.Text = dsDatos.Tables("Proveedores").Rows(vProveedorPosicion).Item("ProveedorDireccion").ToString
            txtDni.Text = dsDatos.Tables("Proveedores").Rows(vProveedorPosicion).Item("ProveedorDni").ToString
            txtTelefono.Text = dsDatos.Tables("Proveedores").Rows(vProveedorPosicion).Item("ProveedorTelefono").ToString
            cboAdministrador.SelectedValue = dsDatos.Tables("Proveedores").Rows(vProveedorPosicion).Item("ProveedoraAdministradorCodigo")
            dtpFechaDeEntrada.Text = dsDatos.Tables("Proveedores").Rows(vProveedorPosicion).Item("ProveedorFechaDeEntrada").ToString
            radiomasculino.Checked = IIf(dsDatos.Tables("Proveedores").Rows(vProveedorPosicion).Item("ProveedorSexo").ToString = "M", True, False)
            radiofemenino.Checked = IIf(dsDatos.Tables("Proveedores").Rows(vProveedorPosicion).Item("ProveedorSexo").ToString = "F", True, False)

            pbFotoProveedores.Image = Nothing
            Dim fotoEnBytes() As Byte = CType(dsDatos.Tables("Proveedores").Rows(vProveedorPosicion).Item("Proveedorfoto"), Byte())
            Dim fotoEnBits As New MemoryStream(fotoEnBytes)
            pbFotoProveedores.Image = Image.FromStream(fotoEnBits)





        End If
    End Sub
    Private Sub CrearDataSet()
        dsDatos = New DataSet
        Dim pclaseproveedores As New NegocioClaseProveedores
        dsDatos.Tables.Add(pclaseproveedores.CreateProveedores)
        dsDatos.Tables.Add(pclaseproveedores.CreateProveedoresadministrador)


        cboAdministrador.DataSource = dsDatos.Tables("Administradora")
        cboAdministrador.DisplayMember = "AdministradorNombre"
        cboAdministrador.ValueMember = "AdministradorCodigo"
        Controles(False, False, False, False, False, False, False, False, False, False, True, True)

    End Sub
    Private Sub SeleccionarProveedores(sender As Object, e As EventArgs) Handles lvProveedores.SelectedIndexChanged
        If lvProveedores.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Proveedores").Rows.Count - 1
            If lvProveedores.SelectedItems(0).Text = dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorCodigo").ToString Then
                vProveedorPosicion = i
                Exit For
            End If
        Next

        MostrarProveedores()

    End Sub
    Private Sub SeleccionarProveedores1(sender As Object, e As EventArgs) Handles lvproveedor1.SelectedIndexChanged
        If lvproveedor1.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Proveedores").Rows.Count - 1
            If lvproveedor1.SelectedItems(0).Text = dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorCodigo").ToString Then
                vProveedorPosicion = i
                Exit For
            End If
        Next

        MostrarProveedores()

    End Sub



    Private Sub Controles(Codigo As Boolean, Nombre As Boolean, Apellidos As Boolean, Direccion As Boolean,
      FechaDeEntrada As Boolean, Telefono As Boolean, dni As Boolean, Sexo As Boolean, proveedorAdministrador As Boolean, RegistroAdministrador As Boolean, foto As Boolean, Lista As Boolean)
        txtCodigo.Enabled = Codigo
        txtNombre.Enabled = Nombre
        txtApellidos.Enabled = Apellidos
        txtDireccion.Enabled = Direccion
        txtDni.Enabled = dni
        txtTelefono.Enabled = Telefono
        dtpFechaDeEntrada.Enabled = FechaDeEntrada
        gbSexo.Enabled = Sexo
        cboAdministrador.Enabled = proveedorAdministrador
        gbRegistroProveedor.Enabled = RegistroAdministrador
        pbFotoProveedores.Enabled = foto
        lvProveedores.Enabled = Lista



    End Sub
    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean, Cancelar As Boolean, Salir As Boolean)
        cmdAgregar.Enabled = Agregar
        cmdEditar.Enabled = Editar
        cmdEliminar.Enabled = Eliminar
        cmdCancelar.Enabled = Cancelar
        cmdCerrar.Enabled = Salir


    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdAgregar.Text = "Agregar" Then
            cmdAgregar.Text = "Guardar"
            Controles(False, True, True, True, True, True, True, True, True, True, True, False)
            Botones(True, False, False, True, False)

            txtCodigo.Clear() : txtNombre.Clear() : txtApellidos.Clear() : txtDireccion.Clear() : txtTelefono.Clear() : txtDni.Clear() : pbFotoProveedores.Image = Nothing
            txtCodigo.Focus()
            txtNombre.Select()
        Else
            If Len(Trim(txtNombre.Text)) = 0 Then
                MessageBox.Show("Falta el nombre")

                Exit Sub
                If Len(Trim(txtApellidos.Text)) = 0 Then
                    MessageBox.Show("Falta los apellidos")
                    Exit Sub
                End If
                If Len(Trim(txtDireccion.Text)) = 0 Then
                    MessageBox.Show("Falta  la direccion")
                    Exit Sub
                End If
                If Len(Trim(txtDni.Text)) = 0 Then
                    MessageBox.Show("Falta el  dni")
                    Exit Sub
                End If
                If Len(Trim(txtTelefono.Text)) = 0 Then
                    MessageBox.Show("Falta el  telefono")
                    Exit Sub
                End If

            End If
            Dim pClaseProveedores As New NegocioClaseProveedores
            Dim fotoEnBits As New MemoryStream()
            If Not pbFotoProveedores.Image Is Nothing Then
                pbFotoProveedores.Image.Save(fotoEnBits, pbFotoProveedores.Image.RawFormat)
            Else
                pbFotoProveedores.Image = Image.FromFile("D:\SIN FOTO.jpg")
                pbFotoProveedores.Image.Save(fotoEnBits, pbFotoProveedores.Image.RawFormat)

            End If
            If pClaseProveedores.NegProveedoresInsertar(txtCodigo.Text, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, (IIf(radiomasculino.Checked = True, "M", "F")),
            txtDni.Text, txtTelefono.Text, dtpFechaDeEntrada.Text, fotoEnBits.GetBuffer, "A", cboAdministrador.SelectedValue) Then
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
            Controles(False, False, False, False, False, False, False, False, False, False, False, True)
        End If
    End Sub
    Private Sub proveedorEditar(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Editar" Then
            cmdEditar.Text = "Guardar"
            Botones(False, True, False, True, False)
            Controles(False, True, True, True, True, True, True, True, True, True, True, False)
            vProveedorPosicion = 2 'DOS es Editar
            txtNombre.Focus()
        Else  'Guardar

            If Len(Trim(txtNombre.Text)) = 0 Then
                MessageBox.Show("Falta el nombre")
                Exit Sub

                If Len(Trim(txtApellidos.Text)) = 0 Then
                    MessageBox.Show("Falta los apellidos")
                    Exit Sub
                End If
                If Len(Trim(txtDireccion.Text)) = 0 Then
                    MessageBox.Show("Falta  la direccion")
                    Exit Sub
                End If
                If Len(Trim(txtDni.Text)) = 0 Then
                    MessageBox.Show("Falta  el dni")
                    Exit Sub
                End If
                If Len(Trim(txtTelefono.Text)) = 0 Then
                    MessageBox.Show("Falta   el telefono")
                    Exit Sub
                End If

            End If
            Dim pClaseProveedores As New NegocioClaseProveedores
            Dim fotoEnBits As New MemoryStream()
            If Not pbFotoProveedores.Image Is Nothing Then
                pbFotoProveedores.Image.Save(fotoEnBits, pbFotoProveedores.Image.RawFormat)
            Else
                pbFotoProveedores.Image = Image.FromFile("D:\SIN FOTO.jpg")
                pbFotoProveedores.Image.Save(fotoEnBits, pbFotoProveedores.Image.RawFormat)

            End If
            If pClaseProveedores.NegProveedoresModificar(txtCodigo.Text, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, (IIf(radiomasculino.Checked = True, "M", "F")),
            txtDni.Text, txtTelefono.Text, dtpFechaDeEntrada.Text, fotoEnBits.GetBuffer, "A", cboAdministrador.SelectedValue) Then
                MessageBox.Show("Registro modificado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
            Else
                MessageBox.Show("No se pudo insertar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            cmdEditar.Text = "Editar"
            Controles(False, False, False, False, False, False, False, False, False, False, False, True)
            Botones(True, True, True, False, True)
        End If
    End Sub



    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdAgregar.Text = "Agregar"
        cmdEditar.Text = "Editar"
        Botones(True, True, True, False, True)
        vProveedorPosicion = 0
        Controles(False, False, False, False, False, False, False, False, False, False, False, True)
        MostrarProveedores()
    End Sub
    Private Sub agregarfoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkFoto.LinkClicked
        Dim AbrirFoto As New OpenFileDialog
        AbrirFoto.Filter = "Archivo de Imagen|*.jpg|Mapa de bits|*.bmp|Fotos|*.jpeg"
        If AbrirFoto.ShowDialog = DialogResult.OK Then
            pbFotoProveedores.ImageLocation = AbrirFoto.FileName
        End If
    End Sub
    Private Sub AdministradorEliminar(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("¿Desea eliminar" & vbCrLf & txtNombre.Text & "?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
            Dim pClaseElminar As New NegocioClaseProveedores
            Dim fotoEnBits As New MemoryStream()
            If Not pbFotoProveedores.Image Is Nothing Then
                pbFotoProveedores.Image.Save(fotoEnBits, pbFotoProveedores.Image.RawFormat)
            Else
                pbFotoProveedores.Image = Image.FromFile("D:\SIN FOTO.png")
                pbFotoProveedores.Image.Save(fotoEnBits, pbFotoProveedores.Image.RawFormat)

            End If

            If pClaseElminar.NegProveedoresEliminar(txtCodigo.Text, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, (IIf(radiomasculino.Checked = True, "M", "F")),
            txtDni.Text, txtTelefono.Text, dtpFechaDeEntrada.Text, fotoEnBits.GetBuffer, "A", cboAdministrador.SelectedValue) Then
                MessageBox.Show("Registro eliminado ")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
                vProveedorPosicion = 0
            Else
                MessageBox.Show("No se pudo eliminar el resgistro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            CrearDataSet()
            LlenarLista()
            LlenarLista2()

            vProveedorPosicion = 0
            MostrarProveedores()

        End If
    End Sub
    Private Sub DatoEscribir(sender As Object, e As EventArgs) Handles txtBusquedaProveedor.TextChanged

        If RadDni.Checked = True Then
            vProveedorPosicion = 0
            'Por Libro
            dvProveedor = New DataView(dsDatos.Tables("Proveedores"))
            dvProveedor.RowFilter = "ProveedorDni like '%" & txtBusquedaProveedor.Text & "%'"
            lvproveedor1.Columns.Clear()
            lvproveedor1.Columns.Add("ProveedorCodigo", 150)
            lvproveedor1.Columns.Add("ProveedorNombre", 160)
            lvproveedor1.Columns.Add("ProveedorApellidos", 200)
            lvproveedor1.Columns.Add("ProveedorDni", 160)
            lvproveedor1.Columns.Add("ProveedorTelefono", 160)
            lvproveedor1.Columns.Add("ProveedorFechaDeEntrada", 160)
            lvproveedor1.Columns.Add("ProveedorSexo", 200)
            lvproveedor1.Columns.Add("ProveedorDireccion", 160)
            lvproveedor1.Items.Clear()

            For i As Integer = 0 To dvProveedor.Count - 1
                lvproveedor1.Items.Add(dvProveedor.Item(i).Item("ProveedorCodigo").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorNombre").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorApellidos").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorDni").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorTelefono").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorFechaDeEntrada").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorSexo").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorDireccion").ToString)

            Next
        Else
            vProveedorPosicion = 1
            dvProveedor = New DataView(dsDatos.Tables("Proveedores"))
            dvProveedor.RowFilter = "ProveedorNombre like '%" & txtBusquedaProveedor.Text & "%'"
            lvproveedor1.Columns.Clear()
            lvproveedor1.Columns.Add("ProveedorCodigo", 150)
            lvproveedor1.Columns.Add("ProveedorNombre", 160)
            lvproveedor1.Columns.Add("ProveedorApellidos", 200)
            lvproveedor1.Columns.Add("ProveedorDni", 160)
            lvproveedor1.Columns.Add("ProveedorTelefono", 160)
            lvproveedor1.Columns.Add("ProveedorFechaDeEntrada", 160)
            lvproveedor1.Columns.Add("ProveedorSexo", 200)
            lvproveedor1.Columns.Add("ProveedorDireccion", 160)
            lvproveedor1.Items.Clear()

            For i As Integer = 0 To dvProveedor.Count - 1
                lvproveedor1.Items.Add(dvProveedor.Item(i).Item("ProveedorCodigo").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorNombre").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorApellidos").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorDni").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorTelefono").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorFechaDeEntrada").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorSexo").ToString)
                lvproveedor1.Items(i).SubItems.Add(dvProveedor.Item(i).Item("ProveedorDireccion").ToString)

            Next
        End If

    End Sub
    Private Sub optdni_Click(sender As Object, e As EventArgs) Handles RadDni.Click
        vProveedorPosicion = 0
        txtBusquedaProveedor.Clear()
        'Autores
        lvproveedor1.Columns.Clear()
        lvproveedor1.Columns.Add("ProveedorCodigo", 200)
        lvproveedor1.Columns.Add("ProveedorDni", 300)
        lvproveedor1.Columns.Add("ProveedorNombre", 300)
        lvproveedor1.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Proveedores").Rows.Count - 1
            lvproveedor1.Items.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorCodigo").ToString)
            lvproveedor1.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorDni").ToString)
            lvproveedor1.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorNombre").ToString)
        Next
    End Sub
    Private Sub optnombre_Click(sender As Object, e As EventArgs) Handles RadNombre.Click
        vProveedorPosicion = 1
        txtBusquedaProveedor.Clear()
        'Autores
        lvproveedor1.Columns.Clear()
        lvproveedor1.Columns.Add("ProveedorCodigo", 200)
        lvproveedor1.Columns.Add("ProveedorNombre", 300)
        lvproveedor1.Columns.Add("ProveedorDni", 300)
        lvproveedor1.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Proveedores").Rows.Count - 1
            lvproveedor1.Items.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorCodigo").ToString)
            lvproveedor1.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorNombre").ToString)
            lvproveedor1.Items(i).SubItems.Add(dsDatos.Tables("Proveedores").Rows(i).Item("ProveedorDni").ToString)
        Next
    End Sub
End Class