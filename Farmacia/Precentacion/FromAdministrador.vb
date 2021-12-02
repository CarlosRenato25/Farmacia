Imports System.Data
Imports System.Data.SqlClient
Imports FarmaciaCapaNegocio
Imports System.IO
Public Class FromAdministrador
    Dim dsDatos As DataSet
    Dim vAdministradorPosicion As Integer = 0
    Dim dvAdministrador As DataView



    Private Sub ProductosCarga(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        MostrarAdministrador()
        LlenarLista()
        LlenarLista2()

    End Sub
    Private Sub CrearDataSet()
        dsDatos = New DataSet
        Dim pClaseAdministrador As New NegocioClaseAdministradora
        dsDatos.Tables.Add(pClaseAdministrador.CreaTableAdministrador)


        Controles(False, False, False, False, False, False, False, False, False, False, False, True, True)

    End Sub

    Private Sub MostrarAdministrador()
        If dsDatos.Tables("Administradora").Rows.Count > 0 Then
            txtCodigo.Text = dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorCodigo").ToString
            txtNombre.Text = dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorNombre").ToString
            txtApellidos.Text = dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorApellidos").ToString
            txtRuc.Text = dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorRuc").ToString
            txtTelefono.Text = dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorTelefono").ToString
            txtDNI.Text = dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorDni").ToString
            txtDireccion.Text = dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorDireccion").ToString
            dtpFechaDeNacimiento.Text = dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorFechaNacimiento").ToString
            dtpFechaDeEntrada.Text = dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorFechaDeEntrada").ToString
            'Sexo
            ptnMasculino.Checked = IIf(dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorSexo").ToString = "M", True, False)
            ptnFemenino.Checked = IIf(dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorSexo").ToString = "F", True, False)

            pbFotoAdministrador.Image = Nothing
            Dim fotoEnBytes() As Byte = CType(dsDatos.Tables("Administradora").Rows(vAdministradorPosicion).Item("AdministradorFoto"), Byte())
            Dim fotoEnBits As New MemoryStream(fotoEnBytes)
            pbFotoAdministrador.Image = Image.FromStream(fotoEnBits)
        End If
    End Sub

    Private Sub LlenarLista()
        lvAdministrador1.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Administradora").Rows.Count - 1
            lvAdministrador1.Items.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorCodigo").ToString)
            lvAdministrador1.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorNombre").ToString)
            lvAdministrador1.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorApellidos").ToString)
            lvAdministrador1.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorRuc").ToString)
            lvAdministrador1.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorTelefono").ToString)
            lvAdministrador1.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorDireccion").ToString)
            lvAdministrador1.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorDni").ToString)
            lvAdministrador1.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorSexo").ToString)
            lvAdministrador1.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorFechaNacimiento").ToString)
            lvAdministrador1.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorFechaDeEntrada").ToString)


        Next
    End Sub
    Private Sub LlenarLista2()
        lvAdministrador2.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Administradora").Rows.Count - 1
            lvAdministrador2.Items.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorCodigo").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorNombre").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorApellidos").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorRuc").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorTelefono").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorDireccion").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorDni").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorSexo").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorFechaNacimiento").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorFechaDeEntrada").ToString)
        Next '

    End Sub
    Private Sub SeleccionarAdministrador(sender As Object, e As EventArgs) Handles lvAdministrador1.SelectedIndexChanged
        If lvAdministrador1.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Administradora").Rows.Count - 1
            If lvAdministrador1.SelectedItems(0).Text = dsDatos.Tables("Administradora").Rows(i).Item("AdministradorCodigo").ToString Then
                vAdministradorPosicion = i
                Exit For
            End If
        Next
        MostrarAdministrador()

    End Sub
    Private Sub SeleccionarAdministrador2(sender As Object, e As EventArgs) Handles lvAdministrador2.SelectedIndexChanged
        If lvAdministrador2.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Administradora").Rows.Count - 1
            If lvAdministrador2.SelectedItems(0).Text = dsDatos.Tables("Administradora").Rows(i).Item("AdministradorCodigo").ToString Then
                vAdministradorPosicion = i
                Exit For
            End If
        Next
        MostrarAdministrador()

    End Sub
    Private Sub AdministradorAgregar(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdAgregar.Text = "Agregar" Then
            cmdAgregar.Text = "Guardar"
            Controles(False, True, True, True, True, True, True, True, True, True, True, True, True)
            Botones(True, False, False, True, False)

            txtCodigo.Clear() : txtNombre.Clear() : txtApellidos.Clear() : txtRuc.Clear() : txtDireccion.Clear() : txtTelefono.Clear() : txtDNI.Clear() : pbFotoAdministrador.Image = Nothing
            txtCodigo.Focus()
        Else  'Guardar
            'Consistencias

            If Len(Trim(txtNombre.Text)) = 0 Then
                MessageBox.Show("Falta el nombre")
                Exit Sub
                If Len(Trim(txtApellidos.Text)) = 1 Then
                    MessageBox.Show("Falta los apellidos")
                    Exit Sub
                End If
                If Len(Trim(txtRuc.Text)) = 2 Then
                    MessageBox.Show("Falta el ruc")
                    Exit Sub
                End If
                If Len(Trim(txtDireccion.Text)) = 3 Then
                    MessageBox.Show("Falta  la direccion")
                    Exit Sub
                End If
                If Len(Trim(txtTelefono.Text)) = 5 Then
                    MessageBox.Show("Falta el telefono")
                    Exit Sub
                End If
                If Len(Trim(txtDNI.Text)) = 6 Then
                    MessageBox.Show("Falta el  dni")
                    Exit Sub

                End If
            End If
            Dim pClaseaAdministrador As New NegocioClaseAdministradora
            Dim fotoEnBits As New MemoryStream()
            If Not pbFotoAdministrador.Image Is Nothing Then
                pbFotoAdministrador.Image.Save(fotoEnBits, pbFotoAdministrador.Image.RawFormat)
            Else
                pbFotoAdministrador.Image = Image.FromFile("D:\SIN FOTO.jpg")
                pbFotoAdministrador.Image.Save(fotoEnBits, pbFotoAdministrador.Image.RawFormat)

            End If

            If pClaseaAdministrador.NegAdministradoraInsertar(txtCodigo.Text, txtNombre.Text, txtApellidos.Text, (IIf(ptnMasculino.Checked = True, "M", "F")), txtRuc.Text, txtTelefono.Text, txtDNI.Text, txtDireccion.Text, dtpFechaDeNacimiento.Text, dtpFechaDeEntrada.Text, fotoEnBits.GetBuffer, "A") Then
                MessageBox.Show("Registro insertado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
            Else
                MessageBox.Show("No se pudo insertar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        cmdAgregar.Text = "Agregar"
                Controles(False, False, False, False, False, False, False, False, False, False, False, False, True)
                Botones(True, True, True, False, True)
            End If


    End Sub
    Private Sub Cancelar(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdAgregar.Text = "Agregar"
        cmdEditar.Text = "Editar"
        Botones(True, True, True, False, True)
        vAdministradorPosicion = 0

        Controles(False, False, False, False, False, False, False, False, False, False, False, False, True)
        MostrarAdministrador()
    End Sub
    Private Sub agregarfoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkFoto.LinkClicked
        Dim AbrirFoto As New OpenFileDialog
        AbrirFoto.Filter = "Archivo de Imagen|*.jpg|Mapa de bits|*.bmp|Fotos|*.jpeg"
        If AbrirFoto.ShowDialog = DialogResult.OK Then
            pbFotoAdministrador.ImageLocation = AbrirFoto.FileName
        End If
    End Sub

    Private Sub administradoraEditar(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Editar" Then
            cmdEditar.Text = "Guardar"
            Botones(True, True, False, True, False)
            Controles(False, True, True, True, True, True, False, True, False, True, True, True, False)
            vAdministradorPosicion = 2 'DOS es Editar
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
                If Len(Trim(txtDNI.Text)) = 0 Then
                    MessageBox.Show("Falta el  dni")
                    Exit Sub
                End If
                If Len(Trim(txtTelefono.Text)) = 0 Then
                    MessageBox.Show("Falta el  telefono")
                    Exit Sub
                End If
            End If


            Dim pClaseaAdministrador As New NegocioClaseAdministradora
            Dim fotoEnBits As New MemoryStream()
            If Not pbFotoAdministrador.Image Is Nothing Then
                pbFotoAdministrador.Image.Save(fotoEnBits, pbFotoAdministrador.Image.RawFormat)
            Else
                pbFotoAdministrador.Image = Image.FromFile("‪D:\SIN FOTO.jpg")
                pbFotoAdministrador.Image.Save(fotoEnBits, pbFotoAdministrador.Image.RawFormat)

            End If

            If pClaseaAdministrador.NegAdministradorEditar(txtCodigo.Text, txtNombre.Text, txtApellidos.Text, (IIf(ptnMasculino.Checked = True, "M", "F")), txtRuc.Text, txtTelefono.Text, txtDNI.Text, txtDireccion.Text, dtpFechaDeNacimiento.Text, dtpFechaDeEntrada.Text, fotoEnBits.GetBuffer, "A") Then
                MessageBox.Show("Registro insertado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
            Else
                MessageBox.Show("No se pudo insertar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            cmdEditar.Text = "Editar"
            Controles(False, False, False, False, False, False, False, False, False, False, False, False, True)
            Botones(True, True, True, False, True)
        End If


    End Sub

    Private Sub AdministradoraEliminar(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("¿Desea eliminar" & vbCrLf & txtNombre.Text & "?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim pClaseElminar As New NegocioClaseAdministradora
            Dim fotoEnBits As New MemoryStream()
            If Not pbFotoAdministrador.Image Is Nothing Then
                pbFotoAdministrador.Image.Save(fotoEnBits, pbFotoAdministrador.Image.RawFormat)
            Else
                pbFotoAdministrador.Image = Image.FromFile("D:\SIN FOTO.png")
                pbFotoAdministrador.Image.Save(fotoEnBits, pbFotoAdministrador.Image.RawFormat)

            End If

            If pClaseElminar.NegAdministradoraEliminar(txtCodigo.Text, txtNombre.Text, txtApellidos.Text, (IIf(ptnMasculino.Checked = True, "M", "F")), txtRuc.Text, txtTelefono.Text, txtDNI.Text, txtDireccion.Text, dtpFechaDeNacimiento.Text, dtpFechaDeEntrada.Text, fotoEnBits.GetBuffer, "A") Then
                MessageBox.Show("Registro eliminado ")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
                vAdministradorPosicion = 0
            Else
                MessageBox.Show("No se pudo eliminar el resgistro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            CrearDataSet()
            LlenarLista()
            LlenarLista2()

            vAdministradorPosicion = 0
            MostrarAdministrador()

        End If

    End Sub
    Private Sub Controles(Codigo As Boolean, Nombre As Boolean, Apellidos As Boolean, Ruc As Boolean, Direccion As Boolean,
       FechaNacimiento As Boolean, FechaDeEntrada As Boolean, Telefono As Boolean, dni As Boolean, Sexo As Boolean, RegistroAdministrador As Boolean, foto As Boolean, Lista As Boolean)
        txtCodigo.Enabled = Codigo
        txtNombre.Enabled = Nombre
        txtApellidos.Enabled = Apellidos
        txtRuc.Enabled = Ruc
        txtDireccion.Enabled = Direccion
        dtpFechaDeNacimiento.Enabled = FechaNacimiento
        dtpFechaDeEntrada.Enabled = FechaDeEntrada
        txtTelefono.Enabled = Telefono
        txtDNI.Enabled = dni
        gbSexo.Enabled = Sexo
        gbRegistroAdministrador.Enabled = RegistroAdministrador
        pbFotoAdministrador.Enabled = foto
        lvAdministrador1.Enabled = Lista
        lvAdministrador2.Enabled = Lista


    End Sub
    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean, Cancelar As Boolean, Salir As Boolean)
        cmdAgregar.Enabled = Agregar
        cmdEditar.Enabled = Editar
        cmdEliminar.Enabled = Eliminar
        cmdCancelar.Enabled = Cancelar
        cmdCerrar.Enabled = Salir
    End Sub
    Private Sub DatoEscribir(sender As Object, e As EventArgs) Handles txtBuscadorAdministrador.TextChanged
        If optDni.Checked = True Then

            vAdministradorPosicion = 0
            'Por Libro
            dvAdministrador = New DataView(dsDatos.Tables("Administradora"))
            dvAdministrador.RowFilter = "AdministradorDni like '%" & txtBuscadorAdministrador.Text & "%'"
            lvAdministrador2.Columns.Clear()
            lvAdministrador2.Columns.Add("AdministradorCodigo", 150)
            lvAdministrador2.Columns.Add("AdministradorNombre", 160)
            lvAdministrador2.Columns.Add("AdministradorApellidos", 200)
            lvAdministrador2.Columns.Add("AdministradorRuc", 160)
            lvAdministrador2.Columns.Add("AdministradorDireccion", 160)
            lvAdministrador2.Columns.Add("AdministradorTelefono", 160)
            lvAdministrador2.Columns.Add("AdministradorDni", 200)
            lvAdministrador2.Columns.Add("AdministradorFechaNacimiento", 160)

            lvAdministrador2.Items.Clear()

            For i As Integer = 0 To dvAdministrador.Count - 1
                lvAdministrador2.Items.Add(dvAdministrador.Item(i).Item("AdministradorCodigo").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorNombre").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorApellidos").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorRuc").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorDireccion").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorTelefono").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorDni").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorFechaNacimiento").ToString)

            Next
        Else
            vAdministradorPosicion = 1
            'Por Libro
            dvAdministrador = New DataView(dsDatos.Tables("Administradora"))
            dvAdministrador.RowFilter = "AdministradorNombre like '%" & txtBuscadorAdministrador.Text & "%'"
            lvAdministrador2.Columns.Clear()
            lvAdministrador2.Columns.Add("AdministradorCodigo", 150)
            lvAdministrador2.Columns.Add("AdministradorNombre", 160)
            lvAdministrador2.Columns.Add("AdministradorApellidos", 200)
            lvAdministrador2.Columns.Add("AdministradorRuc", 160)
            lvAdministrador2.Columns.Add("AdministradorDireccion", 160)
            lvAdministrador2.Columns.Add("AdministradorTelefono", 160)
            lvAdministrador2.Columns.Add("AdministradorDni", 200)
            lvAdministrador2.Columns.Add("AdministradorFechaNacimiento", 160)

            lvAdministrador2.Items.Clear()

            For i As Integer = 0 To dvAdministrador.Count - 1
                lvAdministrador2.Items.Add(dvAdministrador.Item(i).Item("AdministradorCodigo").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorNombre").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorApellidos").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorRuc").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorDireccion").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorTelefono").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorDni").ToString)
                lvAdministrador2.Items(i).SubItems.Add(dvAdministrador.Item(i).Item("AdministradorFechaNacimiento").ToString)

            Next

        End If

    End Sub
    Private Sub optdni_Click(sender As Object, e As EventArgs) Handles optDni.Click
        vAdministradorPosicion = 0
        txtBuscadorAdministrador.Clear()
        'Autores
        lvAdministrador2.Columns.Clear()
        lvAdministrador2.Columns.Add("AdministradorCodigo", 200)
        lvAdministrador2.Columns.Add("AdministradorDni", 300)
        lvAdministrador2.Columns.Add("AdministradorNombre", 300)
        lvAdministrador2.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Administradora").Rows.Count - 1
            lvAdministrador2.Items.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorCodigo").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorDni").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorNombre").ToString)
        Next
    End Sub
    Private Sub optnombre_Click(sender As Object, e As EventArgs) Handles optNombre.Click
        vAdministradorPosicion = 1
        txtBuscadorAdministrador.Clear()
        'Autores
        lvAdministrador2.Columns.Clear()
        lvAdministrador2.Columns.Add("AdministradorCodigo", 200)
        lvAdministrador2.Columns.Add("AdministradorNombre", 300)
        lvAdministrador2.Columns.Add("AdministradorDni", 300)
        lvAdministrador2.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Administradora").Rows.Count - 1
            lvAdministrador2.Items.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorCodigo").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorNombre").ToString)
            lvAdministrador2.Items(i).SubItems.Add(dsDatos.Tables("Administradora").Rows(i).Item("AdministradorDni").ToString)
        Next
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdAgregar_ControlRemoved(sender As Object, e As ControlEventArgs) Handles cmdAgregar.ControlRemoved

    End Sub
End Class