Imports Negocios

Public Class FrmBNIntermedio
    Dim objTiempo As New Clase_Jugar
    Dim obj_jugar As New ClaseNivelintermedio
    Public contador As Integer = 0
    Public contador3 As Integer = 0
    Private Sub FrmBNIntermedio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador3 = 180
        Me.lblMin.Text = contador3
        Me.TiempoInt.Enabled = True

    End Sub

    Private Sub btnAtacar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        TiempoInt.Start()
    End Sub

    Private Sub TiempoInt_Tick(sender As Object, e As EventArgs) Handles TiempoInt.Tick
        contador3 = contador3 - 1
        Me.lblMin.Text = contador3
        If contador3 = 0 Then
            Me.TiempoInt.Enabled = False

        End If
    End Sub

End Class


