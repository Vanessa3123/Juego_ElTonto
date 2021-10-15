Imports Negocios
Public Class FrmBNDificil
    Dim obj_JugarDificil As New ClaseNivelDificil
    Public contador As Integer = 0
    Public contador1 As Integer = 0

    Private Sub FrmBNDificil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador1 = 150
        Me.lblMin.Text = contador1
        Me.tiempoDif.Enabled = True
    End Sub

    Private Sub tiempoDif_Tick(sender As Object, e As EventArgs) Handles tiempoDif.Tick

        contador = contador - 1
        Me.lblMin.Text = contador1
        If contador1 = 0 Then
            Me.tiempoDif.Enabled = False

        End If

    End Sub

    Private Sub btnAtacar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click

    End Sub

End Class