Public Class Clase_Jugar
    Dim jugador As String

    Public Sub Cronometro()
        Dim Seconds As Integer

        Dim startTime As DateTime
        Dim endTime As DateTime
        Dim currentTime As DateTime
        Dim timeSpan As TimeSpan

        startTime = DateTime.Now
        endTime = startTime.AddSeconds(Seconds)
        currentTime = startTime

        Do While currentTime < endTime

            currentTime = DateTime.Now
            timeSpan = currentTime - startTime

        Loop

    End Sub

End Class
