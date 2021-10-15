Public Class FrmMenuPrincipal
    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        FrmRegistro.Show()
    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        Try
            If cdColores.ShowDialog = DialogResult.OK Then
                Me.BackColor = cdColores.Color
                FrmAcerca.BackColor = cdColores.Color
                FrmRegistro.BackColor = cdColores.Color
                FrmBNFacil.BackColor = cdColores.Color
                FrmBNIntermedio.BackColor = cdColores.Color
                FrmBNDificil.BackColor = cdColores.Color

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Presente")
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        FrmAcerca.Show()
    End Sub

    Private Sub InstrucccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstrucccionesToolStripMenuItem.Click
        frmInstrucciones.Show()
    End Sub

    Private Sub JuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuegoToolStripMenuItem.Click
        Dim juego As String


    End Sub

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
