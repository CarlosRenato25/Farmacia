
Imports System.Data
Imports System.Data.SqlClient
Imports FarmaciaCapaNegocio
Public Class FromCategoria
    Dim dsDatos As DataSet
    Dim vCtegoriasPosicion As Integer = 0
    Dim dvCategoria As DataView


    Private Sub ProductosCarga(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        MostarCategorias()
        LlenarLista()
        LlenarLista2()

    End Sub
    Private Sub CrearDataSet()
        dsDatos = New DataSet
        Dim pClaseCategorias As New NegocioclaseCategorias
        dsDatos.Tables.Add(pClaseCategorias.CreaTableCategorias)




    End Sub
    Private Sub LlenarLista()
        lvcategoria.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Categorias").Rows.Count - 1
            lvcategoria.Items.Add(dsDatos.Tables("Categorias").Rows(i).Item("CategoriasCodigo").ToString)
            lvcategoria.Items(i).SubItems.Add(dsDatos.Tables("Categorias").Rows(i).Item("CategoriaNombre").ToString)
            lvcategoria.Items(i).SubItems.Add(dsDatos.Tables("Categorias").Rows(i).Item("CategoriaDescripcion").ToString)

        Next
    End Sub

    Private Sub LlenarLista2()
        lvCategorias.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Categorias").Rows.Count - 1
            lvCategorias.Items.Add(dsDatos.Tables("Categorias").Rows(i).Item("CategoriasCodigo").ToString)
            lvCategorias.Items(i).SubItems.Add(dsDatos.Tables("Categorias").Rows(i).Item("CategoriaNombre").ToString)
            lvCategorias.Items(i).SubItems.Add(dsDatos.Tables("Categorias").Rows(i).Item("CategoriaDescripcion").ToString)

        Next
    End Sub
    Private Sub MostarCategorias()
        If dsDatos.Tables("Categorias").Rows.Count > 0 Then  'Si hay registros
            txtCodigo.Text = dsDatos.Tables("Categorias").Rows(vCtegoriasPosicion).Item("CategoriasCodigo").ToString
            txtNombreCategoria.Text = dsDatos.Tables("Categorias").Rows(vCtegoriasPosicion).Item("CategoriaNombre").ToString
            txtDescripcionCategoria.Text = dsDatos.Tables("Categorias").Rows(vCtegoriasPosicion).Item("CategoriaDescripcion").ToString
            Controles(False, False, False, False, True)
            Botones(True, True, True, True, True)
        Else
            Controles(False, False, False, False, True)
            Botones(True, True, True, False, True)
            txtCodigo.Clear() : txtNombreCategoria.Clear() : txtDescripcionCategoria.Clear()
            txtCodigo.Focus()
        End If
    End Sub

    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean, Cancelar As Boolean, Salir As Boolean)
        cmdAgregar.Enabled = Agregar
        cmdEditar.Enabled = Editar
        cmdElminar.Enabled = Eliminar
        cmdCancelar.Enabled = Cancelar
        cmdCerrar.Enabled = Salir
    End Sub
    Private Sub Controles(codigo As Boolean, Nombre As Boolean, Descripcion As Boolean,
                   Registro As Boolean, Lista As Boolean)
        txtCodigo.Enabled = codigo
        txtNombreCategoria.Enabled = Nombre
        txtDescripcionCategoria.Enabled = Descripcion
        lvcategoria.Enabled = Lista
        gbRegistro.Enabled = Registro

    End Sub


    Private Sub CategoriaSeleccionar(sender As Object, e As EventArgs) Handles lvcategoria.SelectedIndexChanged
        If lvcategoria.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Categorias").Rows.Count - 1
            If lvcategoria.SelectedItems(0).Text = dsDatos.Tables("Categorias").Rows(i).Item("CategoriasCodigo") Then
                vCtegoriasPosicion = i
                Exit For
            End If

        Next
        MostarCategorias()
    End Sub
    Private Sub EmpleadoAgregar(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdAgregar.Text = "Agregar" Then
            cmdAgregar.Text = "Guardar"
            Controles(True, True, True, True, False)
            Botones(True, False, False, True, False)

            txtCodigo.Clear() : txtNombreCategoria.Clear() : txtDescripcionCategoria.Clear()
            txtCodigo.Focus()
        Else  'Guardar
            'Consistencias

            If Len(Trim(txtDescripcionCategoria.Text)) = 0 Then
                MessageBox.Show("Falta la decripcion")
                Exit Sub
            End If
            Dim pClaseCategorias As New NegocioclaseCategorias
            'Consumir la función de insertar el registro
            If pClaseCategorias.NegCategoriasInsertar(txtCodigo.Text, txtNombreCategoria.Text, txtDescripcionCategoria.Text, "A") Then
                MessageBox.Show("Registro insertado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
            Else
                MessageBox.Show("No se pudo insertar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            cmdAgregar.Text = "Agregar"
            Controles(False, False, False, False, True)
            Botones(True, True, True, False, True)

        End If
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdAgregar.Text = "Agregar"
        cmdEditar.Text = "Editar"
        Botones(True, True, True, False, True)
        Controles(False, False, False, False, True)
        MostarCategorias()
    End Sub

    Private Sub CategoriaEditar(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Editar" Then
            cmdEditar.Text = "Guardar"
            Botones(True, True, True, True, False)
            Controles(False, True, True, True, False)

            txtNombreCategoria.Focus()

        Else  'Guardar


            If Len(Trim(txtNombreCategoria.Text)) = 0 Then
                MessageBox.Show("Falta el nombre")
                Exit Sub

                If Len(Trim(txtDescripcionCategoria.Text)) = 0 Then
                    MessageBox.Show("Falta la dexcripcion")
                    Exit Sub
                End If
            End If

            Dim pClaseCategorias As New NegocioclaseCategorias
            'Consumir la función de insertar el registro
            If pClaseCategorias.NegCategoriasEditar(txtCodigo.Text, txtNombreCategoria.Text,
  txtDescripcionCategoria.Text, "A") Then
                MessageBox.Show("Registro modificado")
                CrearDataSet()
                LlenarLista()
                LlenarLista2()
            Else
                MessageBox.Show("No se pudo editar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            cmdEditar.Text = "Editar"
            Controles(False, False, False, False, True)
            Botones(True, True, True, False, True)
        End If

    End Sub


    Private Sub CategoriasEliminar(sender As Object, e As EventArgs) Handles cmdElminar.Click
        If MessageBox.Show("¿Desea eliminar" & vbCrLf & txtNombreCategoria.Text & "?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
            Dim pClaseCategorias As New NegocioclaseCategorias
            'Consumir la función de insertar el registro
            If pClaseCategorias.NegCategoriasEliminar(txtCodigo.Text, txtNombreCategoria.Text, txtDescripcionCategoria.Text, "A") Then
                MessageBox.Show("Registro eliminado")
                CrearDataSet()
                vCtegoriasPosicion = 0
                LlenarLista()
                LlenarLista2()
                MostarCategorias()
            Else
                MessageBox.Show("No se pudo eliminar  el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub CmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtBsucarCategorias_TextChanged(sender As Object, e As EventArgs) Handles txtBsucarCategorias.TextChanged
        If RadNombre.Checked = True Then
            vCtegoriasPosicion = 0
            'Por Libro
            dvCategoria = New DataView(dsDatos.Tables("Categorias"))
            dvCategoria.RowFilter = "CategoriaNombre like '%" & txtBsucarCategorias.Text & "%'"
            lvCategorias.Columns.Clear()
            lvCategorias.Columns.Add("CategoriasCodigo", 150)
            lvCategorias.Columns.Add("CategoriaNombre", 150)
            lvCategorias.Columns.Add("CategoriaDescripcion", 160)


            lvCategorias.Items.Clear()

            For i As Integer = 0 To dvCategoria.Count - 1
                lvCategorias.Items.Add(dvCategoria.Item(i).Item("CategoriasCodigo").ToString)
                lvCategorias.Items(i).SubItems.Add(dvCategoria.Item(i).Item("CategoriaNombre").ToString)
                lvCategorias.Items(i).SubItems.Add(dvCategoria.Item(i).Item("CategoriaDescripcion").ToString)

            Next
        Else
            vCtegoriasPosicion = 1
            dvCategoria = New DataView(dsDatos.Tables("Categorias"))
            dvCategoria.RowFilter = "CategoriaDescripcion like '%" & txtBsucarCategorias.Text & "%'"
            lvCategorias.Columns.Clear()
            lvCategorias.Columns.Add("CategoriasCodigo", 150)
            lvCategorias.Columns.Add("CategoriaNombre", 150)
            lvCategorias.Columns.Add("CategoriaDescripcion", 160)
            lvCategorias.Items.Clear()

            For i As Integer = 0 To dvCategoria.Count - 1
                lvCategorias.Items.Add(dvCategoria.Item(i).Item("CategoriasCodigo").ToString)
                lvCategorias.Items(i).SubItems.Add(dvCategoria.Item(i).Item("CategoriaNombre").ToString)
                lvCategorias.Items(i).SubItems.Add(dvCategoria.Item(i).Item("CategoriaDescripcion").ToString)

            Next
        End If


    End Sub
    Private Sub optdni_Click(sender As Object, e As EventArgs) Handles RadNombre.Click
        vCtegoriasPosicion = 0
        txtBsucarCategorias.Clear()
        'Autores
        lvCategorias.Columns.Clear()
        lvCategorias.Columns.Add("CategoriasCodigo", 150)
        lvCategorias.Columns.Add("CategoriaNombre", 200)

        lvCategorias.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Categorias").Rows.Count - 1
            lvCategorias.Items.Add(dsDatos.Tables("Categorias").Rows(i).Item("CategoriasCodigo").ToString)
            lvCategorias.Items(i).SubItems.Add(dsDatos.Tables("Categorias").Rows(i).Item("CategoriaNombre").ToString)

        Next
    End Sub
    Private Sub optdescripcion_Click(sender As Object, e As EventArgs) Handles RadDescripcion.Click
        vCtegoriasPosicion = 1
        txtBsucarCategorias.Clear()
        'Autores
        lvCategorias.Columns.Clear()
        lvCategorias.Columns.Add("CategoriasCodigo", 150)
        lvCategorias.Columns.Add("CategoriaDescripcion", 200)

        lvCategorias.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Categorias").Rows.Count - 1
            lvCategorias.Items.Add(dsDatos.Tables("Categorias").Rows(i).Item("CategoriasCodigo").ToString)
            lvCategorias.Items(i).SubItems.Add(dsDatos.Tables("Categorias").Rows(i).Item("CategoriaDescripcion").ToString)

        Next
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class