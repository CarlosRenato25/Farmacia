Imports System.Data
Imports System.Data.SqlClient
Imports FarmaciaCapaNegocio
Imports System.IO

Public Class FromFarmaceutico
    Dim dsDatos As DataSet
    Dim vFarmaceuticoPosicion As Integer = 0
    Dim FotoFarmceutico As New MemoryStream
    Dim dvFarmaceutico As DataView
    Private Sub ProductosCarga(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        MostrarFarmaceutico()
        llenarLista()
        llenarLista2()
    End Sub
    Private Sub llenarLista()
        lvFarmaceutico1.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Farmaceutico").Rows.Count - 1
            lvFarmaceutico1.Items.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoCodigo").ToString)
            lvFarmaceutico1.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoNombre").ToString)
            lvFarmaceutico1.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoApellidos").ToString)
            lvFarmaceutico1.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoTelefono").ToString)
            lvFarmaceutico1.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoDireccion").ToString)
            lvFarmaceutico1.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoDni").ToString)
            lvFarmaceutico1.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoFechaDeEntrada").ToString)
            lvFarmaceutico1.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoFechaDeNacimiento").ToString)
            lvFarmaceutico1.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoSexo").ToString)
        Next

    End Sub
    Private Sub llenarLista2()
        lvFarmaceutico2.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Farmaceutico").Rows.Count - 1
            lvFarmaceutico2.Items.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoCodigo").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoNombre").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoApellidos").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoTelefono").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoDireccion").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoDni").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoFechaDeEntrada").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoFechaDeNacimiento").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoSexo").ToString)
        Next

    End Sub
    Private Sub MostrarFarmaceutico()
        If dsDatos.Tables("Farmaceutico").Rows.Count > 0 Then
            txtCodigo.Text = dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("FarmaceuticoCodigo").ToString
            txtNombres.Text = dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("FarmaceuticoNombre").ToString
            txtApellidos.Text = dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("FarmaceuticoApellidos").ToString
            txtDireccion.Text = dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("FarmaceuticoDireccion").ToString
            txtDni.Text = dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("FarmaceuticoDni").ToString
            txtTelefono.Text = dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("FarmaceuticoTelefono").ToString
            cboAdministrador.SelectedValue = dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("FarmaceuticoAdministradorCodigo")
            dtpFechaDeEntrada.Text = dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("FarmaceuticoFechaDeEntrada").ToString
            dtpFechaDeNacimiento.Text = dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("FarmaceuticoFechaDeNacimiento").ToString
            RadioMasculino.Checked = IIf(dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("FarmaceuticoSexo").ToString = "M", True, False)
            RadioFemenino.Checked = IIf(dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("FarmaceuticoSexo").ToString = "F", True, False)
            pbFotoFarmaceutico.Image = Nothing
            Dim fotoEnBytes() As Byte = CType(dsDatos.Tables("Farmaceutico").Rows(vFarmaceuticoPosicion).Item("Farmaceuticofoto"), Byte())
            Dim fotoEnBits As New MemoryStream(fotoEnBytes)
            pbFotoFarmaceutico.Image = Image.FromStream(fotoEnBits)
        End If
    End Sub
    Private Sub CrearDataSet()
        dsDatos = New DataSet
        Dim pClaseClientes As New NegocioClaseFarmaceutico
        dsDatos.Tables.Add(pClaseClientes.CreaTableFamaceutcio)
        dsDatos.Tables.Add(pClaseClientes.CreaTableAdministrador)


        'llenar el texbox
        cboAdministrador.DataSource = dsDatos.Tables("Administradora")
        cboAdministrador.DisplayMember = "AdministradorNombre"
        cboAdministrador.ValueMember = "AdministradorCodigo"
        Controles(False, False, False, False, False, False, False, False, False, False, False, True, True)
    End Sub
    Private Sub SeleccionarFarmaceutico(sender As Object, e As EventArgs) Handles lvFarmaceutico1.SelectedIndexChanged
        If lvFarmaceutico1.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Farmaceutico").Rows.Count - 1
            If lvFarmaceutico1.SelectedItems(0).Text = dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoCodigo").ToString Then
                vFarmaceuticoPosicion = i
                Exit For
            End If
        Next

        MostrarFarmaceutico()

    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdAgregar.Text = "Agregar" Then
            cmdAgregar.Text = "Guardar"
            Controles(False, True, True, True, True, True, True, True, True, True, True, True, False)
            Botones(True, False, False, True, False)

            txtCodigo.Clear() : txtNombres.Clear() : txtApellidos.Clear() : txtDireccion.Clear() : txtTelefono.Clear() : txtDni.Clear() : pbFotoFarmaceutico.Image = Nothing
            txtCodigo.Focus()
        Else
            If Len(Trim(txtNombres.Text)) = 0 Then
                MessageBox.Show("Falta el nombre")
                Exit Sub
            End If
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

            Dim pClaseFamaceutico As New NegocioClaseFarmaceutico
            Dim fotoEnBits As New MemoryStream()
            If Not pbFotoFarmaceutico.Image Is Nothing Then
                pbFotoFarmaceutico.Image.Save(fotoEnBits, pbFotoFarmaceutico.Image.RawFormat)
            Else
                pbFotoFarmaceutico.Image = Image.FromFile("D:\SIN FOTO.jpg")
                pbFotoFarmaceutico.Image.Save(fotoEnBits, pbFotoFarmaceutico.Image.RawFormat)

            End If

            If pClaseFamaceutico.NegFarmaceuticoInsertar(txtCodigo.Text, txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtDireccion.Text, txtDni.Text, dtpFechaDeEntrada.Text, dtpFechaDeNacimiento.Text, (IIf(RadioMasculino.Checked = True, "M", "F")), fotoEnBits.GetBuffer, cboAdministrador.SelectedValue, "A") Then
                MessageBox.Show("Registro insertado")
                CrearDataSet()
                llenarLista()
                llenarLista2()
            Else
                MessageBox.Show("No se pudo insertar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            cmdAgregar.Text = "Agregar"
            Controles(False, False, False, False, False, False, False, False, False, False, False, False, True)
            Botones(True, True, True, False, True)
        End If

    End Sub
    Private Sub proveedorEditar(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Editar" Then
            cmdEditar.Text = "Guardar"
            Botones(False, True, False, True, False)
            Controles(False, True, True, True, True, True, True, True, True, True, True, True, False)
            txtNombres.Focus()
        Else  'Guardar

            If Len(Trim(txtNombres.Text)) = 0 Then
                MessageBox.Show("Falta el nombre")
                Exit Sub
            End If
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


            Dim pClaseFamaceutico As New NegocioClaseFarmaceutico
            Dim fotoEnBits As New MemoryStream()
            If Not pbFotoFarmaceutico.Image Is Nothing Then
                pbFotoFarmaceutico.Image.Save(fotoEnBits, pbFotoFarmaceutico.Image.RawFormat)
            Else
                pbFotoFarmaceutico.Image = Image.FromFile("D:\SIN FOTO.jpg")
                pbFotoFarmaceutico.Image.Save(fotoEnBits, pbFotoFarmaceutico.Image.RawFormat)

            End If

            If pClaseFamaceutico.NegFarmaceuticoEditar(txtCodigo.Text, txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtDireccion.Text, txtDni.Text, dtpFechaDeEntrada.Text, dtpFechaDeNacimiento.Text, (IIf(RadioMasculino.Checked = True, "M", "F")), fotoEnBits.GetBuffer, cboAdministrador.SelectedValue, "A") Then
                MessageBox.Show("Registro insertado")
                CrearDataSet()
                llenarLista()
                llenarLista2()
            Else
                MessageBox.Show("No se pudo editar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            cmdEditar.Text = "Editar"
            Controles(False, False, False, False, False, False, False, False, False, False, False, False, True)
            Botones(True, True, True, False, True)
        End If
    End Sub
    Private Sub AdministradoraEliminar(sender As Object, e As EventArgs) Handles cmdEliminar.Click

        If MessageBox.Show("¿Desea eliminar" & vbCrLf & txtNombres.Text & "?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim pClaseFamaceutico As New NegocioClaseFarmaceutico
            Dim fotoEnBits As New MemoryStream()
            If Not pbFotoFarmaceutico.Image Is Nothing Then
                pbFotoFarmaceutico.Image.Save(fotoEnBits, pbFotoFarmaceutico.Image.RawFormat)
            Else
                pbFotoFarmaceutico.Image = Image.FromFile("D:\SIN FOTO.jpg")
                pbFotoFarmaceutico.Image.Save(fotoEnBits, pbFotoFarmaceutico.Image.RawFormat)

            End If

            If pClaseFamaceutico.NegFarmaceuticoEliminasr(txtCodigo.Text, txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtDireccion.Text, txtDni.Text, dtpFechaDeEntrada.Text, dtpFechaDeNacimiento.Text, (IIf(RadioMasculino.Checked = True, "M", "F")), fotoEnBits.GetBuffer, cboAdministrador.SelectedValue, "A") Then
                MessageBox.Show("Registro eliminado")
                CrearDataSet()
                llenarLista()
                llenarLista2()
                vFarmaceuticoPosicion = 0
            Else
                MessageBox.Show("No se pudo eliminar el resgistro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            CrearDataSet()
            llenarLista()
            llenarLista2()

            vFarmaceuticoPosicion = 0
            MostrarFarmaceutico()

        End If
    End Sub
    Private Sub agregarfoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkFoto.LinkClicked
        Dim AbrirFoto As New OpenFileDialog
        AbrirFoto.Filter = "Archivo de Imagen|*.jpg|Mapa de bits|*.bmp|Fotos|*.jpeg"
        If AbrirFoto.ShowDialog = DialogResult.OK Then
            pbFotoFarmaceutico.ImageLocation = AbrirFoto.FileName
        End If
    End Sub


    Private Sub Controles(Codigo As Boolean, Nombre As Boolean, Apellidos As Boolean, Direccion As Boolean,
     dni As Boolean, Telefono As Boolean, FechaDeEntrada As Boolean, FechaDeNacimiento As Boolean, Sexo As Boolean, FarmaceuticoAdministrador As Boolean, RegistroAdministrador As Boolean, foto As Boolean, Lista As Boolean)
        txtCodigo.Enabled = Codigo
        txtNombres.Enabled = Nombre
        txtApellidos.Enabled = Apellidos
        txtTelefono.Enabled = Direccion
        txtDireccion.Enabled = dni
        txtDni.Enabled = Telefono
        dtpFechaDeEntrada.Enabled = FechaDeEntrada
        dtpFechaDeNacimiento.Enabled = FechaDeNacimiento
        gbSexo.Enabled = Sexo
        cboAdministrador.Enabled = FarmaceuticoAdministrador
        gbRegistroFarmaceutico.Enabled = RegistroAdministrador
        pbFotoFarmaceutico.Enabled = foto
        lvFarmaceutico1.Enabled = Lista



    End Sub
    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean, Cancelar As Boolean, Salir As Boolean)
        cmdAgregar.Enabled = Agregar
        cmdEditar.Enabled = Editar
        cmdEliminar.Enabled = Eliminar
        cmdCancelar.Enabled = Cancelar
        cmdCerrar.Enabled = Salir


    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdAgregar.Text = "Agregar"
        cmdEditar.Text = "Editar"
        MessageBox.Show("Quieres cancelar esta operacion ", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        Botones(True, True, True, False, True)
        vFarmaceuticoPosicion = 0

        Controles(False, False, False, False, False, False, False, False, False, False, False, False, True)
        MostrarFarmaceutico()

    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Desear Realmente Cerrar la Ventana", "Salir de La Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If (opcion = Windows.Forms.DialogResult.OK) Then
            Me.Close()
        End If



    End Sub
    Private Sub DatoEscribir(sender As Object, e As EventArgs) Handles txtBuscarFarmaceutico.TextChanged
        If RadioDni.Checked = True Then
            vFarmaceuticoPosicion = 0
            'Por Libro
            dvFarmaceutico = New DataView(dsDatos.Tables("Farmaceutico"))
            dvFarmaceutico.RowFilter = "FarmaceuticoDni like '%" & txtBuscarFarmaceutico.Text & "%'"
            lvFarmaceutico2.Columns.Clear()
            lvFarmaceutico2.Columns.Add("FarmaceuticoCodigo", 150)
            lvFarmaceutico2.Columns.Add("FarmaceuticoNombre", 160)
            lvFarmaceutico2.Columns.Add("FarmaceuticoApellidos", 200)
            lvFarmaceutico2.Columns.Add("FarmaceuticoTelefono", 160)
            lvFarmaceutico2.Columns.Add("FarmaceuticoDireccion", 160)
            lvFarmaceutico2.Columns.Add("FarmaceuticoDni", 160)
            lvFarmaceutico2.Columns.Add("FarmaceuticoFechaDeEntrada", 200)
            lvFarmaceutico2.Columns.Add("FarmaceuticoFechaDeNacimiento", 200)
            lvFarmaceutico2.Columns.Add("FarmaceuticoSexo", 160)
            lvFarmaceutico2.Items.Clear()

            For i As Integer = 0 To dvFarmaceutico.Count - 1
                lvFarmaceutico2.Items.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoCodigo").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoNombre").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoApellidos").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoTelefono").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoDireccion").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoDni").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoFechaDeEntrada").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoFechaDeNacimiento").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoSexo").ToString)
            Next

        Else
            vFarmaceuticoPosicion = 1
            'Por Libro
            dvFarmaceutico = New DataView(dsDatos.Tables("Farmaceutico"))
            dvFarmaceutico.RowFilter = "FarmaceuticoNombre like '%" & txtBuscarFarmaceutico.Text & "%'"
            lvFarmaceutico2.Columns.Clear()
            lvFarmaceutico2.Columns.Add("FarmaceuticoCodigo", 150)
            lvFarmaceutico2.Columns.Add("FarmaceuticoNombre", 160)
            lvFarmaceutico2.Columns.Add("FarmaceuticoApellidos", 200)
            lvFarmaceutico2.Columns.Add("FarmaceuticoTelefono", 160)
            lvFarmaceutico2.Columns.Add("FarmaceuticoDireccion", 160)
            lvFarmaceutico2.Columns.Add("FarmaceuticoDni", 160)
            lvFarmaceutico2.Columns.Add("FarmaceuticoFechaDeEntrada", 200)
            lvFarmaceutico2.Columns.Add("FarmaceuticoFechaDeNacimiento", 200)
            lvFarmaceutico2.Columns.Add("FarmaceuticoSexo", 160)
            lvFarmaceutico2.Items.Clear()

            For i As Integer = 0 To dvFarmaceutico.Count - 1
                lvFarmaceutico2.Items.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoCodigo").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoNombre").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoApellidos").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoTelefono").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoDireccion").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoDni").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoFechaDeEntrada").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoFechaDeNacimiento").ToString)
                lvFarmaceutico2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("FarmaceuticoSexo").ToString)
            Next
        End If

    End Sub
    Private Sub optdni_Click(sender As Object, e As EventArgs) Handles RadioDni.Click
        vFarmaceuticoPosicion = 0
        txtBuscarFarmaceutico.Clear()
        'Autores
        lvFarmaceutico2.Columns.Clear()
        lvFarmaceutico2.Columns.Add("FarmaceuticoCodigo", 200)
        lvFarmaceutico2.Columns.Add("FarmaceuticoDni", 300)
        lvFarmaceutico2.Columns.Add("FarmaceuticoNombre", 300)
        lvFarmaceutico2.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Farmaceutico").Rows.Count - 1
            lvFarmaceutico2.Items.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoCodigo").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoDni").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoNombre").ToString)
        Next
    End Sub
    Private Sub optNombre_Click(sender As Object, e As EventArgs) Handles RadioNombre.Click
        vFarmaceuticoPosicion = 1
        txtBuscarFarmaceutico.Clear()
        'Autores
        lvFarmaceutico2.Columns.Clear()
        lvFarmaceutico2.Columns.Add("FarmaceuticoCodigo", 200)
        lvFarmaceutico2.Columns.Add("FarmaceuticoNombre", 300)
        lvFarmaceutico2.Columns.Add("FarmaceuticoDni", 300)
        lvFarmaceutico2.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Farmaceutico").Rows.Count - 1
            lvFarmaceutico2.Items.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoCodigo").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoNombre").ToString)
            lvFarmaceutico2.Items(i).SubItems.Add(dsDatos.Tables("Farmaceutico").Rows(i).Item("FarmaceuticoDni").ToString)
        Next
    End Sub
End Class