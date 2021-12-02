
Imports System.Data.SqlClient
Imports FarmaciaCapaDatos

Public Class NegocioClasePrecentacion
    Public Function NegPrecentacionesInsertar(nprecentacionCodigo As String, nprecentacionNombre As String, nprecentacionDescripcion As String, nprecentacionEstado As String) As Boolean

        Dim nClasepresentaciones As New FarmaciaCapaDatos.ClasePrecentacion(nprecentacionCodigo, nprecentacionNombre, nprecentacionDescripcion,
                     nprecentacionEstado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClasepresentaciones.precentacionesInsertar(nClasepresentaciones) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function NegPrecentacionesEditar(nprecentacionCodigo As String, nprecentacionNombre As String, nprecentacionDescripcion As String, nprecentacionEstado As String) As Boolean
        Dim nClasePreentacion As New FarmaciaCapaDatos.ClasePrecentacion(nprecentacionCodigo, nprecentacionNombre, nprecentacionDescripcion, nprecentacionEstado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClasePreentacion.precentacionesEditar(nClasePreentacion) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function NegPrecentacionesEliminar(nprecentacionCodigo As String, nprecentacionNombre As String, nprecentacionDescripcion As String, nprecentacionEstado As String) As Boolean

        Dim nClasePrecentaciones As New FarmaciaCapaDatos.ClasePrecentacion(nprecentacionCodigo, nprecentacionNombre, nprecentacionDescripcion, nprecentacionEstado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClasePrecentaciones.categoriaEliminar(nClasePrecentaciones) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CreaTablePrecentaciones() As DataTable
        Dim nClasecategorias As New ClasePrecentacion
        Return nClasecategorias.PrecentacionesListados()
    End Function
End Class
