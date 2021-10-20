Imports Negocios
Public Class FrmBNFacil

    Dim obj_manejar As New ClaseNivelfacil
    Dim obj_jugador As New ClaseJugador
    Public contador As Integer = 0
    Public contador2 As Integer = 0

    Dim vector1() As Integer = {0, 0, 0, 0}
    Dim vector2() As Integer = {0, 0, 0, 0}

    Dim CartaTonto As Integer = 0

    Dim posicionVector1 As Integer = 0
    Dim valorPosicionVector1 As Integer = 0
    Dim posicionVector2 As Integer = 0
    Dim valorPosicionVector2 As Integer = 0

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
        If Not btnParejas.Visible Then
            btnRevolverCartas.Visible = True
        End If


    End Sub

    Private Sub btnParejas_Click(sender As Object, e As EventArgs) Handles btnParejas.Click
        '// lllamamos al metodo que hace las parejas de la clase NiveFacil
        Dim objClaseNivelFacil As New ClaseNivelfacil
        objClaseNivelFacil.Parejas(vector1, vector2, grpTomarCarta, pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8)


    End Sub

    Private Sub btnRevolverCartas_Click(sender As Object, e As EventArgs) Handles btnRevolverCartas.Click
        Try
            Dim numeroAleatorio As Integer
            Randomize()
            numeroAleatorio = (CInt(Rnd() * 9)) + 1
            CartaTonto = numeroAleatorio
            lblNumTonto.Text = Str(CartaTonto)

#Region "Llenado Vector 1"

            Dim contadorNumerosAleatorios As Integer = 0
            Dim validaNumero As Boolean = False

            lblInfoNumeros1.Text = ""

            Do While (contadorNumerosAleatorios < 4)

                numeroAleatorio = (CInt(Rnd() * 9)) + 1

                For i = 0 To 3 Step 1
                    If vector1(i) = numeroAleatorio Then
                        validaNumero = True
                        Exit For
                    Else
                        validaNumero = False

                    End If
                Next


                If validaNumero = False Then
                    For j = 0 To 3 Step 1
                        If vector1(j) = 0 Then
                            vector1(j) = numeroAleatorio
                            contadorNumerosAleatorios += 1
                            Exit For
                        End If
                    Next
                End If






            Loop

            For k = 0 To 3 Step 1
                lblInfoNumeros1.Text += Str(vector1(k))
                Dim srRuta As String = Application.StartupPath
                Select Case k
                    Case 0
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic1.ImageLocation = strArchivo
                    Case 1
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic2.ImageLocation = strArchivo
                    Case 2
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic3.ImageLocation = strArchivo
                    Case 3
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic4.ImageLocation = strArchivo
                End Select
            Next
#End Region '// fin llenado del vector uno de imagenes

#Region "Llenado Vector 2"
            Dim numeroAleatorio2 As Integer
            Dim contadorNumerosAleatorios2 As Integer = 0
            Dim validaNumero2 As Boolean = False

            lblInfoNumeros2.Text = ""

            Do While (contadorNumerosAleatorios2 < 4)
                Randomize()
                numeroAleatorio2 = (CInt(Rnd() * 8)) + 1

                For i = 0 To 3 Step 1
                    If vector2(i) = numeroAleatorio2 Then
                        validaNumero2 = True
                        Exit For
                    Else
                        validaNumero2 = False

                    End If
                Next

                If validaNumero2 = False Then
                    For j = 0 To 3 Step 1
                        If vector2(j) = 0 Then
                            vector2(j) = numeroAleatorio2
                            contadorNumerosAleatorios2 += 1
                            Exit For
                        End If
                    Next
                End If
            Loop

            For k = 0 To 3 Step 1
                lblInfoNumeros2.Text += Str(vector2(k))
                Dim srRuta As String = Application.StartupPath
                Select Case k
                    Case 0
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector2(k)) + ".jpg".Trim)
                        pic5.ImageLocation = strArchivo
                    Case 1
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector2(k)) + ".jpg".Trim)
                        pic6.ImageLocation = strArchivo
                    Case 2
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector2(k)) + ".jpg".Trim)
                        pic7.ImageLocation = strArchivo
                    Case 3
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector2(k)) + ".jpg".Trim)
                        pic8.ImageLocation = strArchivo
                End Select
            Next
#End Region '// fin llenado del vector 2 de imagenes

            btnRevolverCartas.Visible = False
            btnParejas.Visible = True

        Catch ex As Exception
            MessageBox.Show(" Ya se revolvio el maso !!!")
        End Try

    End Sub
    Private Sub btnVerTonto_Click(sender As Object, e As EventArgs) Handles btnVerTonto.Click
        Dim srRuta As String = Application.StartupPath
        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(CartaTonto) + ".jpg".Trim)
        picTonto.ImageLocation = strArchivo

    End Sub

    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click
        posicionVector1 = 0
        valorPosicionVector1 = vector1(0)
    End Sub

    Private Sub pic2_Click(sender As Object, e As EventArgs) Handles pic2.Click
        posicionVector1 = 1
        valorPosicionVector1 = vector1(1)
    End Sub

    Private Sub pic3_Click(sender As Object, e As EventArgs) Handles pic3.Click
        posicionVector1 = 2
        valorPosicionVector1 = vector1(2)
    End Sub

    Private Sub pic4_Click(sender As Object, e As EventArgs) Handles pic4.Click
        posicionVector1 = 3
        valorPosicionVector1 = vector1(3)
    End Sub
    Private Sub pic5_Click(sender As Object, e As EventArgs) Handles pic5.Click
        posicionVector2 = 0
        valorPosicionVector2 = vector2(0)

        If valorPosicionVector1 = valorPosicionVector2 Then

            Select Case posicionVector1
                Case 0
                    pic1.ImageLocation = ""
                Case 1
                    pic2.ImageLocation = ""
                Case 2
                    pic3.ImageLocation = ""
                Case 3
                    pic4.ImageLocation = ""
            End Select

            Select Case posicionVector2
                Case 0
                    pic5.ImageLocation = ""
                Case 1
                    pic6.ImageLocation = ""
                Case 2
                    pic7.ImageLocation = ""
                Case 3
                    pic8.ImageLocation = ""
            End Select
        Else
            posicionVector1 = 0
            valorPosicionVector1 = 0
            posicionVector2 = 0
            valorPosicionVector2 = 0
        End If
    End Sub

    Private Sub pic6_Click(sender As Object, e As EventArgs) Handles pic6.Click
        posicionVector2 = 1
        valorPosicionVector2 = vector2(1)

        If valorPosicionVector1 = valorPosicionVector2 Then

            Select Case posicionVector1
                Case 0
                    pic1.ImageLocation = ""
                Case 1
                    pic2.ImageLocation = ""
                Case 2
                    pic3.ImageLocation = ""
                Case 3
                    pic4.ImageLocation = ""
            End Select

            Select Case posicionVector2
                Case 0
                    pic5.ImageLocation = ""
                Case 1
                    pic6.ImageLocation = ""
                Case 2
                    pic7.ImageLocation = ""
                Case 3
                    pic8.ImageLocation = ""
            End Select
        Else
            posicionVector1 = 0
            valorPosicionVector1 = 0
            posicionVector2 = 0
            valorPosicionVector2 = 0
        End If
    End Sub

    Private Sub pic7_Click(sender As Object, e As EventArgs) Handles pic7.Click
        posicionVector2 = 2
        valorPosicionVector2 = vector2(2)

        If valorPosicionVector1 = valorPosicionVector2 Then

            Select Case posicionVector1
                Case 0
                    pic1.ImageLocation = ""
                Case 1
                    pic2.ImageLocation = ""
                Case 2
                    pic3.ImageLocation = ""
                Case 3
                    pic4.ImageLocation = ""
            End Select

            Select Case posicionVector2
                Case 0
                    pic5.ImageLocation = ""
                Case 1
                    pic6.ImageLocation = ""
                Case 2
                    pic7.ImageLocation = ""
                Case 3
                    pic8.ImageLocation = ""
            End Select
        Else
            posicionVector1 = 0
            valorPosicionVector1 = 0
            posicionVector2 = 0
            valorPosicionVector2 = 0
        End If
    End Sub

    Private Sub pic8_Click(sender As Object, e As EventArgs) Handles pic8.Click
        posicionVector2 = 3
        valorPosicionVector2 = vector2(3)

        If valorPosicionVector1 = valorPosicionVector2 Then

            Select Case posicionVector1
                Case 0
                    pic1.ImageLocation = ""
                Case 1
                    pic2.ImageLocation = ""
                Case 2
                    pic3.ImageLocation = ""
                Case 3
                    pic4.ImageLocation = ""
            End Select

            Select Case posicionVector2
                Case 0
                    pic5.ImageLocation = ""
                Case 1
                    pic6.ImageLocation = ""
                Case 2
                    pic7.ImageLocation = ""
                Case 3
                    pic8.ImageLocation = ""
            End Select
        Else
            posicionVector1 = 0
            valorPosicionVector1 = 0
            posicionVector2 = 0
            valorPosicionVector2 = 0
        End If
    End Sub
End Class'// fin class