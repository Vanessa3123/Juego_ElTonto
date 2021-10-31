
Public Class FrmAcerca
    Dim comprobar As Boolean = False
    Dim iEntidaes As New Entidades.Propirdades
    Dim comprobartxt As Boolean
    Private Sub FrmAcerca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btntxt_Click(sender As Object, e As EventArgs) Handles btntxt.Click
        Try
            iEntidaes.strAutor = lblNomb1.Text
            iEntidaes.strAutor2 = lblNomb2.Text
            iEntidaes.strAutor3 = lblNomb3.Text
            iEntidaes.dtFecha = dtpFecha.Value
            iEntidaes.dmlVersion = Convert.ToDecimal(lblvers2.Text)
            iEntidaes.strInformacion = lbltextInfo.Text

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim obj As New Negocios.Clase_LlamarTXT
        Dim ruta As String

        Using sfdArchivotxt As New SaveFileDialog
            If sfdArchivotxt.ShowDialog = DialogResult.OK Then
                ruta = sfdArchivotxt.FileName
                obj.llamarescritura(ruta, iEntidaes.strAutor, iEntidaes.strAutor2, iEntidaes.strAutor3, iEntidaes.dtFecha,
                    iEntidaes.dmlVersion, iEntidaes.strInformacion)
            End If
        End Using

        Exit Sub

    End Sub
End Class