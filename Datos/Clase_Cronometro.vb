Imports System.IO
Public Class Clase_Cronometro

#Region "Metodos"

    Public Sub GeneraArchivoTXT(ByVal ruta As String, ByVal strUsurio As String, ByVal intCronometro As Integer)
        'Variables para abrir el archivo en modo de escritura
        Try
            Dim inputString As String = Convert.ToString("Usuario: " & strUsurio & " Cronometro: " & intCronometro)
            My.Computer.FileSystem.WriteAllText(ruta & ".txt", inputString, True)

            MsgBox("El archivo se generó con éxito primero")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GeneraArchivoagregarTXT(ByVal ruta As String, ByVal strUsurio As String, ByVal intCronometro As Integer)
        'Variables para abrir el archivo en modo de escritura
        Try
            Dim inputString As String = Convert.ToString("Usuario: " & strUsurio & " Cronometro: " & intCronometro)
            File.AppendAllText(ruta, Environment.NewLine + inputString)

            MsgBox("El archivo se generó con éxito")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region


End Class
