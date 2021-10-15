Imports System.IO
Public Class Clase_EscrituraTXT
#Region "Metodos"

    Public Sub GeneraArchivo(ByVal ruta As String, ByVal strAutor As String, ByVal strAutor2 As String, ByVal strAutor3 As String, ByVal dtFecha As Date,
            ByVal dmlVersion As Decimal, ByVal strInformacion As String)
        'Variables para abrir el archivo en modo de escritura
        Try
            Dim inputString As String = Convert.ToString("Autor: " & strAutor & " Autor2: " & strAutor2 & " Autor3: " & strAutor3 & " Fecha: " & dtFecha & " Version: " & dmlVersion & " Informacion:" & strInformacion)
            My.Computer.FileSystem.WriteAllText(ruta & ".txt", inputString, True)

            MsgBox("El archivo se generó con éxito primero")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GeneraArchivoagregar(ByVal ruta As String, ByVal strAutor As String, ByVal strAutor2 As String, ByVal strAutor3 As String, ByVal dtFecha As Date,
            ByVal dmlVersion As Decimal, ByVal strInformacion As String)
        'Variables para abrir el archivo en modo de escritura
        Try
            Dim inputString As String = Convert.ToString("Autor: " & strAutor & " Autor2: " & strAutor2 & " Autor3: " & strAutor3 & " Fecha: " & dtFecha & " Version:" & dmlVersion & " Informacion:" & strInformacion)
            File.AppendAllText(ruta, Environment.NewLine + inputString)

            MsgBox("El archivo se generó con éxito")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region



End Class
