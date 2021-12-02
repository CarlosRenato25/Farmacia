Imports System.Data.SqlClient
Imports FarmaciaCapaDatos
Public Class NegocioClaseMedicamentos
    Public Function negMedicamentosInsertar(Codigo As String, nombre As String, laboratorio As String, especificaciones As String,
     stock As Double, precioCompra As Double, precioVenta As Double, citiolaboratorio As String, fechaEntrada As Date,
      fechaVencimientoMedicamento As Date, categoriaMedicamentos As String, precetacionesMedicamentos As String, administradorMedicamentos As String, estado As String) As Boolean
        Dim nmedicamentosagregar As New FarmaciaCapaDatos.ClaseMedicamentos(Codigo, nombre, laboratorio, especificaciones,
     stock, precioCompra, precioVenta, citiolaboratorio, fechaEntrada, fechaVencimientoMedicamento, categoriaMedicamentos, precetacionesMedicamentos, administradorMedicamentos, estado)
        If nmedicamentosagregar.MedicamentosInsertar(nmedicamentosagregar) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function negMedicamentosEditar(Codigo As String, nombre As String, laboratorio As String, especificaciones As String,
     stock As Double, precioCompra As Double, precioVenta As Double, citiolaboratorio As String, fechaEntrada As Date,
      fechaVencimientoMedicamento As Date, categoriaMedicamentos As String, precetacionesMedicamentos As String, administradorMedicamentos As String, estado As String) As Boolean
        Dim nmedicamentoseditar As New FarmaciaCapaDatos.ClaseMedicamentos(Codigo, nombre, laboratorio, especificaciones,
     stock, precioCompra, precioVenta, citiolaboratorio, fechaEntrada, fechaVencimientoMedicamento, categoriaMedicamentos, precetacionesMedicamentos, administradorMedicamentos, estado)
        If nmedicamentoseditar.MedicamentosEditar(nmedicamentoseditar) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function negMedicamentoseliminar(Codigo As String, nombre As String, laboratorio As String, especificaciones As String,
     stock As Double, precioCompra As Double, precioVenta As Double, citiolaboratorio As String, fechaEntrada As Date,
      fechaVencimientoMedicamento As Date, categoriaMedicamentos As String, precetacionesMedicamentos As String, administradorMedicamentos As String, estado As String) As Boolean
        Dim nmedicamentoseliminar As New FarmaciaCapaDatos.ClaseMedicamentos(Codigo, nombre, laboratorio, especificaciones,
     stock, precioCompra, precioVenta, citiolaboratorio, fechaEntrada, fechaVencimientoMedicamento, categoriaMedicamentos, precetacionesMedicamentos, administradorMedicamentos, estado)
        If nmedicamentoseliminar.medicamentosEliminar(nmedicamentoseliminar) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function crearmedicamentoslistados() As DataTable
        Dim nmedicamentoslistados As New ClaseMedicamentos
        Return nmedicamentoslistados.medicamentosListados()
    End Function
    Public Function crearadministradorlistados() As DataTable
        Dim nmedicamentosadministrador As New ClaseMedicamentos
        Return nmedicamentosadministrador.administradorListados()
    End Function
    Public Function crearcategorialistados() As DataTable
        Dim nmedicamentoscategoria As New ClaseMedicamentos
        Return nmedicamentoscategoria.categoriasListados()
    End Function
    Public Function crearpresentaioneslistados() As DataTable
        Dim nmedicamentospresentaciones As New ClaseMedicamentos
        Return nmedicamentospresentaciones.precentacionesListados()
    End Function
End Class
