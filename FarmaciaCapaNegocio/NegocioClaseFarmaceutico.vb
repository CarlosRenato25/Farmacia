Imports FarmaciaCapaDatos
Imports System.Data.SqlClient
Public Class NegocioClaseFarmaceutico
    Public Function NegFarmaceuticoInsertar(ncodigoFamaceutico As String, nnombre As String, napellidos As String, ntelefono As String, nDireccion As String, ndni As String, nfechaEntrada As Date, nfechaNacimiento As Date, nsexo As String, nfoto As Byte(), nCodigoAdministrador As String, nestado As String) As Boolean

        Dim nClaseFarmaceutico As New FarmaciaCapaDatos.ClasFarmaceutico(ncodigoFamaceutico, nnombre, napellidos, ntelefono, nDireccion, ndni, nfechaEntrada, nfechaNacimiento, nsexo, nfoto, nCodigoAdministrador, nestado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseFarmaceutico.farmceuticoInsertar(nClaseFarmaceutico) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function NegFarmaceuticoEditar(ncodigoFamaceutico As String, nnombre As String, napellidos As String, ntelefono As String, nDireccion As String, ndni As String, nfechaEntrada As Date, nfechaNacimiento As Date, nsexo As String, nfoto As Byte(), nCodigoAdministrador As String, nestado As String) As Boolean

        Dim nClaseFamaceutico As New FarmaciaCapaDatos.ClasFarmaceutico(ncodigoFamaceutico, nnombre, napellidos, ntelefono, nDireccion, ndni, nfechaEntrada, nfechaNacimiento, nsexo, nfoto, nCodigoAdministrador, nestado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseFamaceutico.FarmaceuticoEditar(nClaseFamaceutico) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function NegFarmaceuticoEliminasr(ncodigoFamaceutico As String, nnombre As String, napellidos As String, ntelefono As String, nDireccion As String, ndni As String, nfechaEntrada As Date, nfechaNacimiento As Date, nsexo As String, nfoto As Byte(), nCodigoAdministrador As String, nestado As String) As Boolean

        Dim nClaseFamaceutico As New FarmaciaCapaDatos.ClasFarmaceutico(ncodigoFamaceutico, nnombre, napellidos, ntelefono, nDireccion, ndni, nfechaEntrada, nfechaNacimiento, nsexo, nfoto, nCodigoAdministrador, nestado)
        'Ejecutar el método definido en la capa de acceso a datos
        If nClaseFamaceutico.FarmaceuticoEliminar(nClaseFamaceutico) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CreaTableFamaceutcio() As DataTable
        Dim nClaseFamaceutcio As New ClasFarmaceutico
        Return nClaseFamaceutcio.FarmaceuticoListados()
    End Function
    Public Function CreaTableAdministrador() As DataTable
        Dim nClaseclientes As New ClasFarmaceutico
        Return nClaseclientes.AdministradorListados()
    End Function
End Class
