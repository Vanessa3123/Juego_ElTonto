
Public Class FrmRegistro

    Private Sub btnIntermedio_Click(sender As Object, e As EventArgs) Handles btnIntermedio.Click
        Me.Visible = False
        'enviar el dato actualizado
        FrmBNIntermedio.Show()
        FrmBNIntermedio.txtUsuarioB.Text = txtUsuario.Text
        limpiar()
    End Sub

    Private Sub btnAvanzado_Click(sender As Object, e As EventArgs) Handles btnAvanzado.Click
        Me.Visible = False
        'enviar el dato actualizado
        FrmBNDificil.Show()
        FrmBNDificil.txtUsuarioB.Text = txtUsuario.Text
        limpiar()
    End Sub

    Private Sub FrmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFacil_Click(sender As Object, e As EventArgs) Handles btnFacil.Click
        Me.Visible = False
        'enviar el dato actualizado
        FrmBNFacil.Show()
        FrmBNFacil.txtUsuarioB.Text = txtUsuario.Text
        limpiar()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Sub limpiar()

        txtNombre.Text = ""
        txtUsuario.Text = ""

    End Sub
End Class