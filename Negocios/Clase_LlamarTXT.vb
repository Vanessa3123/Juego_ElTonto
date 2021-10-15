Public Class Clase_LlamarTXT
    Public Shared Sub llamarescritura(ByVal ruta As String, ByVal strAutor As String, ByVal strAutor2 As String, ByVal strAutor3 As String, ByVal dtFecha As Date, ByVal dmlVersion As Decimal,
       ByVal strInformacion As String)
        Dim obj As New Datos.Clase_EscrituraTXT
        obj.GeneraArchivo(ruta, strAutor, strAutor2, strAutor3, dtFecha, dmlVersion, strInformacion)
    End Sub

    Public Shared Sub llamarescrituraagregar(ByVal ruta As String, ByVal strAutor As String, ByVal strAutor2 As String, ByVal strAutor3 As String, ByVal dtFecha As Date, ByVal dmlVersion As Decimal,
       ByVal strInformacion As String)
        Dim obj As New Datos.Clase_EscrituraTXT

        obj.GeneraArchivoagregar(ruta, strAutor, strAutor2, strAutor3, dtFecha, dmlVersion, strInformacion)
    End Sub

End Class
