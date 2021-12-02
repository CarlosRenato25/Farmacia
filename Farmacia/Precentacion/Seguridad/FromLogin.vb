Public Class FromLogin
    Private Sub cmdaceptar_Click(sender As Object, e As EventArgs) Handles cmdaceptar.Click
        If txtusuario.Text = "elvis" And txtContraseña.Text = "123456789" Then
            FromPrincipal.Show()
            Me.Visible = False
        Else
            lbincorrecto.Visible = True


        End If

    End Sub

    Private Sub Cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        End
    End Sub

    Private Sub FromLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CmMostarContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles cmMostarContraseña.CheckedChanged
        If cmMostarContraseña.Checked = True Then

            txtContraseña.PasswordChar = ""

        ElseIf cmMostarContraseña.Checked = False Then

            txtContraseña.PasswordChar = "*"


        End If

    End Sub

    Private Sub Lbincorrecto_Click(sender As Object, e As EventArgs) Handles lbincorrecto.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub
End Class