Public Class FrmMenuPrincipal
    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        Try
            Dim frmPantalla As New FrmRegistro
            With FrmRegistro
                .MdiParent = Me
                .Show()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)

        End Try
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
        Try
            Dim frmPantalla As New FrmAcerca
            With FrmAcerca
                .MdiParent = Me
                .Show()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)

        End Try
    End Sub

    Private Sub InstrucccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstrucccionesToolStripMenuItem.Click
        Try
            Dim frmPantalla As New frmInstrucciones
            With frmInstrucciones
                .MdiParent = Me
                .Show()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)

        End Try
    End Sub

    Private Sub JuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuegoToolStripMenuItem.Click
        'Dim juego As String


    End Sub

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MejoresTiemposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MejoresTiemposToolStripMenuItem.Click
        Try
            Dim frmPantalla As New frmMejores_Tiempos
            With frmMejores_Tiempos
                .MdiParent = Me
                .Show()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)

        End Try
    End Sub
End Class
