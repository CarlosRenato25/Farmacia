Imports System.Data.SqlClient
Imports FarmaciaCapaDatos

Public Class NegocioClaseProveedores
    Public Function NegProveedoresInsertar(codigo As String, nombres As String, apellidos As String, direccion As String, sexo As String, dni As String, telefono As String,
         fechaentrada As Date, foto As Byte(), estado As String, administrador As String) As Boolean
        Dim NclaseProveedores As New FarmaciaCapaDatos.ClaseProveedor(codigo, nombres, apellidos, direccion, sexo, dni, telefono, fechaentrada, foto, estado, administrador)
        If NclaseProveedores.ProveedorInsertar(NclaseProveedores) Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function NegProveedoresModificar(codigo As String, nombres As String, apellidos As String, direccion As String, sexo As String, dni As String, telefono As String,
         fechaentrada As Date, foto As Byte(), estado As String, administrador As String) As Boolean
        Dim NclaseProveedores As New FarmaciaCapaDatos.ClaseProveedor(codigo, nombres, apellidos, direccion, sexo, dni, telefono, fechaentrada, foto, estado, administrador)
        If NclaseProveedores.ProveedoresModificar(NclaseProveedores) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function NegProveedoresEliminar(codigo As String, nombres As String, apellidos As String, direccion As String, sexo As String, dni As String, telefono As String,
         fechaentrada As Date, foto As Byte(), estado As String, administrador As String) As Boolean
        Dim nClaseProveedores As New FarmaciaCapaDatos.ClaseProveedor(codigo, nombres, apellidos, direccion, sexo, dni, telefono, fechaentrada, foto, estado, administrador)
        If nClaseProveedores.ProveedoresEliminar(nClaseProveedores) Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function CreateProveedores() As DataTable
        Dim claseproveedores As New ClaseProveedor
        Return claseproveedores.ProveedorListados()
    End Function

    Public Function CreateProveedoresadministrador() As DataTable
        Dim claseproveedoresadministrador As New ClaseProveedor
        Return claseproveedoresadministrador.AdministradorListados()
    End Function
End Class
