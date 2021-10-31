Public Class llamadaTXT
    Public Shared Sub llamarescritura(ByVal ruta As String, ByVal strusuario As String, ByVal intCronometro As Integer)
        Dim obj As New Datos.Clase_Cronometro
        obj.GeneraArchivoTXT(ruta, strusuario, intCronometro)
    End Sub

    Public Shared Sub llamarescrituraagregar(ByVal ruta As String, ByVal strusuario As String, ByVal intCronometro As Integer)
        Dim obj As New Datos.Clase_Cronometro

        obj.GeneraArchivoagregarTXT(ruta, strusuario, intCronometro)

    End Sub

End Class
