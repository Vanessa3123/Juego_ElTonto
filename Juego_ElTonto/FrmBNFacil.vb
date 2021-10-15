Imports Negocios
Public Class FrmBNFacil

    Dim obj_manejar As New ClaseNivelfacil
    Dim obj_jugador As New ClaseJugador
    Public contador As Integer = 0
    Public contador2 As Integer = 0
    Private Sub FrmBNFacil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador2 = 240
        Me.lblMin.Text = contador2
        Me.tiempoFac.Enabled = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tiempoFac.Tick

        contador2 = contador2 - 1
        Me.lblMin.Text = contador2
        If contador2 = 0 Then
            Me.tiempoFac.Enabled = False

        End If
    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        tiempoFac.Start()
        grpCartas.Visible = True
    End Sub

    Private Sub btnParejas_Click(sender As Object, e As EventArgs) Handles btnParejas.Click
        grpTomarCarta.Visible = True
    End Sub
End Class