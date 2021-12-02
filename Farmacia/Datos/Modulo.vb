
Module ModuloSistema

    Public farmaceutico As String = "ELMI60100001"

    Public Function CompruebaIngresoDatoObligatorio(vTexto As String) As Boolean
        If Len(Trim(vTexto)) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    'Función para dato numérico
    Public Function CompruebaIngresoDatoNumerico(vTexto As String) As Boolean
        If Len(Trim(vTexto)) = 0 Or IsNumeric(vTexto) = False Or Val(vTexto) < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub NumerosyDecimal(ByVal CajaTexto As TextBox, ByVal e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not CajaTexto.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub SoloNumeros(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Module

