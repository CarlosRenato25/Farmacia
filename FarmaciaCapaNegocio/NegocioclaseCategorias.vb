
Imports System.Data.SqlClient
Imports FarmaciaCapaDatos
Public Class NegocioclaseCategorias
    Public Function NegCategoriasInsertar(nCtegoriaCodigo As String, ncategoriaNombre As String, nCategoriaDescripcion As String, nCategoriasEstado As String) As Boolean

        Dim nClaseCategoria As New FarmaciaCapaDatos.ClaseCategorias(nCtegoriaCodigo, ncategoriaNombre, nCategoriaDescripcion,
                     nCategoriasEstado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseCategoria.CategoriasInsertar(nClaseCategoria) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function NegCategoriasEditar(nCtegoriaCodigo As String, ncategoriaNombre As String, nCategoriaDescripcion As String, nCategoriasEstado As String) As Boolean
        Dim nClaseCategoria As New FarmaciaCapaDatos.ClaseCategorias(nCtegoriaCodigo, ncategoriaNombre, nCategoriaDescripcion, nCategoriasEstado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseCategoria.categoriaEditar(nClaseCategoria) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function NegCategoriasEliminar(nCtegoriaCodigo As String, ncategoriaNombre As String, nCategoriaDescripcion As String, nCategoriasEstado As String) As Boolean

        Dim nClaseCategorias As New FarmaciaCapaDatos.ClaseCategorias(nCtegoriaCodigo, ncategoriaNombre, nCategoriaDescripcion, nCategoriasEstado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseCategorias.categoriaEliminar(nClaseCategorias) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CreaTableCategorias() As DataTable
        Dim nClasecategorias As New ClaseCategorias
        Return nClasecategorias.CategoriasListados()
    End Function
End Class
