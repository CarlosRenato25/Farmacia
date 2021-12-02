Public Class FromPrincipal
    Private Sub PrincipalCarga(sender As Object, e As EventArgs) Handles MyBase.Load
        cboConsultas.Items.AddRange(NumeroConsultas)
        cboConsultas.Items.Add("NumeroBotica:1234566")
        cboConsultas.Sorted = True
        cboConsultas.DropDownStyle = ComboBoxStyle.DropDownList
        cboConsultas.SelectedIndex = 1



        Me.Show()
    End Sub
    Private Sub OpcionesPrincipalesRegistros(sender As Object, e As EventArgs) _
        Handles mnuMedicamentos.Click, mnuAdministrador.Click, mnuClientes.Click,
        mnuFarmaceutico.Click, mnuProveedor.Click, mnuVentas.Click, mnuPedido.Click, mnuPrecentacion.Click, mnuCategoria.Click

        If sender Is mnuMedicamentos Then
            Medicamentos()
        ElseIf sender Is mnuClientes Then
            Clientes()
        ElseIf sender Is mnuAdministrador Then
            Admistrador()
        ElseIf sender Is mnuFarmaceutico Then
            Farmaceutico()
        ElseIf sender Is mnuProveedor Then
            Proveedor()
        ElseIf sender Is mnuVentas Then
            Ventas()
        ElseIf sender Is mnuPedido Then
            Pedido()
        ElseIf sender Is mnuPrecentacion Then
            precentacion()
        ElseIf sender Is mnuCategoria Then
            categorias()



        End If
    End Sub
    Private Sub Medicamentos()
        Dim fMEdicamentos As New FromMedicamento
        Dim fprincipal As FromPrincipal = Me
        Dim f As Form
        For Each f In fPrincipal.MdiChildren
            If f.Name = fMEdicamentos.Name Then
                f.Select()
                Exit Sub
            End If
        Next
        fMEdicamentos.MdiParent = Me
        fMEdicamentos.Show()



    End Sub

    Private Sub Clientes()
        Dim fClientes As New FromCliente
        fClientes.MdiParent = Me
        fClientes.Show()

    End Sub

    Private Sub Admistrador()
        Dim fadmistrador As New FromAdministrador
        fadmistrador.MdiParent = Me
        fadmistrador.Show()
    End Sub
    Private Sub Farmaceutico()
        Dim fFarmaceutico As New FromFarmaceutico
        fFarmaceutico.MdiParent = Me
        fFarmaceutico.Show()
    End Sub
    Private Sub Proveedor()
        Dim fProveedor As New FromProveedor
        fProveedor.MdiParent = Me
        fProveedor.Show()
    End Sub
    Private Sub Ventas()
        Dim fVentas As New FromVentasVendidas
        fVentas.MdiParent = Me
        fVentas.Show()
    End Sub
    Private Sub Pedido()
        Dim fpedido As New FromOrdenDePedido
        fpedido.MdiParent = Me
        fpedido.Show()
    End Sub
    Private Sub precentacion()
        Dim fprecentacion As New FromPrecentacion
        fprecentacion.MdiParent = Me
        fprecentacion.Show()
    End Sub
    Private Sub categorias()
        Dim fcategorias As New FromCategoria
        fcategorias.MdiParent = Me
        fcategorias.Show()

    End Sub
    Private Sub OrdenDePedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPedido.Click

    End Sub

    Private Sub CboConsultas_Click(sender As Object, e As EventArgs) Handles cboConsultas.Click

    End Sub

    Private Sub HeWord_Click(sender As Object, e As EventArgs) Handles HeWord.Click
        Process.Start("Winword.exe")
    End Sub

    Private Sub HerExcel_Click(sender As Object, e As EventArgs) Handles HerExcel.Click
        Process.Start("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE")
    End Sub

    Private Sub HerCalculadora_Click(sender As Object, e As EventArgs) Handles HerCalculadora.Click
        Process.Start("C:\Calculadora")
    End Sub

    Private Sub HerBlocDeNotas_Click(sender As Object, e As EventArgs) Handles HerBlocDeNotas.Click
        Process.Start("%windir%\system32\notepad.exe")
    End Sub
    Private Sub HerPaint_Click(sender As Object, e As EventArgs) Handles HerPaint.Click
        Process.Start("%windir%\system32\mspaint.exe")
    End Sub

    Private Sub CitioWebConsultas_Click(sender As Object, e As EventArgs) Handles CitioWebConsultas.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
    End Sub
End Class
