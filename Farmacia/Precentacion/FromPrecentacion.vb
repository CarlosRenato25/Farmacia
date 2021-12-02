
Imports System.Data
Imports System.Data.SqlClient
Imports FarmaciaCapaNegocio
Public Class FromPrecentacion
    Dim dsDatos As DataSet
    Dim vDescripcionPosicion As Integer = 0
    Dim dvFarmaceutico As DataView
    Private Sub ProductosCarga(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        MostarPrecentaciones()
        LlenarLista()
        LlenarLista2()
    End Sub
    Private Sub CrearDataSet()
        dsDatos = New DataSet
        Dim pClasepresentaciones As New NegocioClasePrecentacion
        dsDatos.Tables.Add(pClasepresentaciones.CreaTablePrecentaciones)

        Controles(False, False, False, False, True)



    End Sub
    Private Sub LlenarLista()
        lvPrecentacion1.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Precentacion").Rows.Count - 1
            lvPrecentacion1.Items.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesCodigo").ToString)
            lvPrecentacion1.Items(i).SubItems.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesNombre").ToString)
            lvPrecentacion1.Items(i).SubItems.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesDescripcion").ToString)
        Next
    End Sub
    Private Sub LlenarLista2()
        lvPresentacion2.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Precentacion").Rows.Count - 1
            lvPresentacion2.Items.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesCodigo").ToString)
            lvPresentacion2.Items(i).SubItems.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesNombre").ToString)
            lvPresentacion2.Items(i).SubItems.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesDescripcion").ToString)
        Next

    End Sub
    Private Sub MostarPrecentaciones()
        txtCodigo.Text = dsDatos.Tables("Precentacion").Rows(vDescripcionPosicion).Item("PrecentacionesCodigo").ToString
        txtNombre.Text = dsDatos.Tables("Precentacion").Rows(vDescripcionPosicion).Item("PrecentacionesNombre").ToString
        txtDescripcion.Text = dsDatos.Tables("Precentacion").Rows(vDescripcionPosicion).Item("PrecentacionesDescripcion").ToString

    End Sub
    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean, Cancelar As Boolean, Salir As Boolean)
        cmdagregar.Enabled = Agregar
        cmdeditar.Enabled = Editar
        cmdeliminar.Enabled = Eliminar
        cmdcancelar.Enabled = Cancelar
        cmdcerrar.Enabled = Salir
    End Sub


    Private Sub Controles(codigo As Boolean, Nombre As Boolean, Descripcion As Boolean,
                          Precentaciones As Boolean, Lista As Boolean)
        txtNombre.Enabled = codigo
        txtCodigo.Enabled = Nombre
        txtDescripcion.Enabled = Descripcion
        lvPrecentacion1.Enabled = Lista
        gbPrecentaciones.Enabled = Precentaciones

    End Sub
    Private Sub CategoriaSeleccionar(sender As Object, e As EventArgs) Handles lvPrecentacion1.SelectedIndexChanged
        If lvPrecentacion1.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Precentacion").Rows.Count - 1
            If lvPrecentacion1.SelectedItems(0).Text = dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesCodigo") Then
                vDescripcionPosicion = i
                Exit For
            End If

        Next
        MostarPrecentaciones()
    End Sub
    Private Sub EmpleadoAgregar(sender As Object, e As EventArgs) Handles cmdagregar.Click
        If cmdagregar.Text = "Agregar" Then
            cmdagregar.Text = "Guardar"
            Controles(True, True, True, True, False)
            Botones(True, False, False, True, False)

            txtCodigo.Clear() : txtNombre.Clear() : txtDescripcion.Clear()
            txtCodigo.Focus()
        Else  'Guardar
            'Consistencias
            If Len(Trim(txtCodigo.Text)) = 0 Then
                MessageBox.Show("Falta codigo")
                Exit Sub
            End If
            If Len(Trim(txtNombre.Text)) = 0 Then
                MessageBox.Show("Falta Nombre")
                Exit Sub
            End If
            If Len(Trim(txtDescripcion.Text)) = 0 Then
                MessageBox.Show("Falta la decripcion")
                Exit Sub
            End If
            Dim pClasePrecentaciones As New NegocioClasePrecentacion
            'Consumir la función de insertar el registro
            If pClasePrecentaciones.NegPrecentacionesInsertar(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, "A") Then
                MessageBox.Show("Registro insertado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
            Else
                MessageBox.Show("No se pudo insertar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            cmdagregar.Text = "Agregar"
            Controles(False, False, False, False, True)
            Botones(True, True, True, False, True)

        End If
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        cmdagregar.Text = "Agregar"
        cmdeditar.Text = "Editar"
        Botones(True, True, True, False, True)
        Controles(False, False, False, False, True)
        MostarPrecentaciones()
    End Sub
    Private Sub PrecentacionesEditar(sender As Object, e As EventArgs) Handles cmdeditar.Click
        If cmdeditar.Text = "Editar" Then
            cmdeditar.Text = "Guardar"
            Botones(True, True, True, True, False)
            Controles(True, False, True, True, False)
            txtCodigo.Focus()
            txtNombre.Focus()
        Else  'Guardar


            If Len(Trim(txtDescripcion.Text)) = 0 Then
                MessageBox.Show("Falta la descripcion")
                Exit Sub
            End If

            Dim pClasePrecentaciones As New NegocioClasePrecentacion
            'Consumir la función de insertar el registro
            If pClasePrecentaciones.NegPrecentacionesEditar(txtCodigo.Text, txtNombre.Text,
                                                    txtDescripcion.Text, "A") Then
                MessageBox.Show("Registro modificado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
            Else
                MessageBox.Show("No se pudo editar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            cmdeditar.Text = "Editar"
            Controles(False, False, False, False, True)
            Botones(True, True, True, False, True)
        End If
    End Sub
    Private Sub PrecentacionesEliminar(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        If MessageBox.Show("¿Desea eliminar" & vbCrLf & txtNombre.Text & "?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
            Dim pClasePrecentaciones As New NegocioClasePrecentacion
            'Consumir la función de insertar el registro
            If pClasePrecentaciones.NegPrecentacionesEliminar(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, "A") Then
                MessageBox.Show("Registro eliminado")
                CrearDataSet()
                vDescripcionPosicion = 0
                LlenarLista()
                LlenarLista2()
                MostarPrecentaciones()
            Else
                MessageBox.Show("No se pudo eliminar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub
    Private Sub CmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdcerrar.Click
        Me.Close()
    End Sub
    Private Sub txtBsucarPrecentacion_TextChanged(sender As Object, e As EventArgs) Handles BuscarPrecentaciones.TextChanged
        If RadioNombre.Checked = True Then
            vDescripcionPosicion = 0
            'Por Libro
            ' @PrecentacionesCodigo nchar (17),
            '@PrecentacionesNombre varchar (50) ,
            '@PrecentacionesDescripcion  nvarchar (100),
            '@PrecentacionesEstado nchar(1)

            dvFarmaceutico = New DataView(dsDatos.Tables("Precentacion"))
            dvFarmaceutico.RowFilter = "PrecentacionesNombre like '%" & BuscarPrecentaciones.Text & "%'"
            lvPresentacion2.Columns.Clear()
            lvPresentacion2.Columns.Add("PrecentacionesCodigo", 150)
            lvPresentacion2.Columns.Add("PrecentacionesNombre", 150)
            lvPresentacion2.Columns.Add("PrecentacionesDescripcion", 160)
            lvPresentacion2.Items.Clear()

            For i As Integer = 0 To dvFarmaceutico.Count - 1
                lvPresentacion2.Items.Add(dvFarmaceutico.Item(i).Item("PrecentacionesCodigo").ToString)
                lvPresentacion2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("PrecentacionesNombre").ToString)
                lvPresentacion2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("PrecentacionesDescripcion").ToString)

            Next
        Else
            vDescripcionPosicion = 1
            dvFarmaceutico = New DataView(dsDatos.Tables("Precentacion"))
            dvFarmaceutico.RowFilter = "PrecentacionesDescripcion like '%" & BuscarPrecentaciones.Text & "%'"
            lvPresentacion2.Columns.Clear()
            lvPresentacion2.Columns.Add("PrecentacionesCodigo", 150)
            lvPresentacion2.Columns.Add("PrecentacionesNombre", 150)
            lvPresentacion2.Columns.Add("PrecentacionesDescripcion", 160)
            lvPresentacion2.Items.Clear()

            For i As Integer = 0 To dvFarmaceutico.Count - 1
                lvPresentacion2.Items.Add(dvFarmaceutico.Item(i).Item("PrecentacionesCodigo").ToString)
                lvPresentacion2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("PrecentacionesNombre").ToString)
                lvPresentacion2.Items(i).SubItems.Add(dvFarmaceutico.Item(i).Item("PrecentacionesDescripcion").ToString)

            Next

        End If

    End Sub
    Private Sub optdni_Click(sender As Object, e As EventArgs) Handles RadioNombre.Click
        vDescripcionPosicion = 0
        BuscarPrecentaciones.Clear()
        'Autores
        lvPresentacion2.Columns.Clear()
        lvPresentacion2.Columns.Add("PrecentacionesCodigo", 150)
        lvPresentacion2.Columns.Add("PrecentacionesNombre", 120)
        lvPresentacion2.Columns.Add("PrecentacionesDescripcion", 150)
        lvPresentacion2.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Precentacion").Rows.Count - 1
            lvPresentacion2.Items.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesCodigo").ToString)
            lvPresentacion2.Items(i).SubItems.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesNombre").ToString)
            lvPresentacion2.Items(i).SubItems.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesDescripcion").ToString)
        Next
    End Sub
    Private Sub optdescripcion_Click(sender As Object, e As EventArgs) Handles RadioDescripcion.Click
        vDescripcionPosicion = 1
        BuscarPrecentaciones.Clear()
        'Autores
        lvPresentacion2.Columns.Clear()
        lvPresentacion2.Columns.Add("PrecentacionesCodigo", 150)
        lvPresentacion2.Columns.Add("PrecentacionesNombre", 150)
        lvPresentacion2.Columns.Add("PrecentacionesDescripcion", 120)
        lvPresentacion2.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Precentacion").Rows.Count - 1
            lvPresentacion2.Items.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesCodigo").ToString)
            lvPresentacion2.Items(i).SubItems.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesNombre").ToString)
            lvPresentacion2.Items(i).SubItems.Add(dsDatos.Tables("Precentacion").Rows(i).Item("PrecentacionesDescripcion").ToString)
        Next
    End Sub

End Class