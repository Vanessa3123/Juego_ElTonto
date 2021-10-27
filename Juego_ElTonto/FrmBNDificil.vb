Imports Negocios
Public Class FrmBNDificil
    Dim obj_JugarDificil As New ClaseNivelDificil
    Public contador As Integer = 0
    Public contador1 As Integer = 0

    Dim vector1(25) As Integer
    Dim vector2(25) As Integer
    Dim CartaTonto As Integer = 0
    Dim posicionVector1 As Integer = 0
    Dim valorPosicionVector1 As Integer = 0
    Dim posicionVector2 As Integer = 0
    Dim valorPosicionVector2 As Integer = 0
    Dim index As Integer
    Dim cartaOponente As Integer
    Dim contJugador1 As Integer = 26
    Dim contadorMaquina As Integer = 26

    Private Sub FrmBNDificil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador1 = 150
        Me.lblMin.Text = contador1
        Me.tiempoDif.Enabled = True

        For i = 0 To 25 Step 1
            vector1(i) = 0
        Next

        For j = 0 To 25 Step 1
            vector2(j) = 0
        Next
    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        grpCartas.Visible = True
        btnRevolverCartas.Visible = True
    End Sub

    Private Sub tiempoDif_Tick(sender As Object, e As EventArgs) Handles tiempoDif.Tick

        contador = contador - 1
        Me.lblMin.Text = contador1
        If contador1 = 0 Then
            Me.tiempoDif.Enabled = False

        End If

    End Sub

    Private Sub btnRevolverCartas_Click(sender As Object, e As EventArgs) Handles btnRevolverCartas.Click
        Try
            Dim numeroAleatorio As Integer
            Randomize()
            numeroAleatorio = (CInt(Rnd() * 25)) + 1
            CartaTonto = numeroAleatorio


#Region "Llenado Vector 1"

            Dim contadorNumerosAleatorios As Integer = 0
            Dim validaNumero As Boolean = False

            lblInfoNumeros1.Text = ""

            Do While (contadorNumerosAleatorios < 26)

                numeroAleatorio = (CInt(Rnd() * 25)) + 1

                For i = 0 To 25 Step 1
                    If vector1(i) = numeroAleatorio Then
                        validaNumero = True
                        Exit For
                    Else
                        validaNumero = False

                    End If
                Next


                If validaNumero = False Then
                    For j = 0 To 25 Step 1
                        If vector1(j) = 0 Then
                            vector1(j) = numeroAleatorio
                            contadorNumerosAleatorios += 1
                            Exit For
                        End If
                    Next
                End If

            Loop

            For k = 0 To 25 Step 1
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
                    Case 4
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic5.ImageLocation = strArchivo
                    Case 5
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic6.ImageLocation = strArchivo
                    Case 6
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic7.ImageLocation = strArchivo
                    Case 7
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic8.ImageLocation = strArchivo
                    Case 8
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic9.ImageLocation = strArchivo
                    Case 9
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic10.ImageLocation = strArchivo
                    Case 10
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic11.ImageLocation = strArchivo
                    Case 11
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic12.ImageLocation = strArchivo
                    Case 12
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic13.ImageLocation = strArchivo
                    Case 13
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic14.ImageLocation = strArchivo
                    Case 14
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic15.ImageLocation = strArchivo
                    Case 15
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic16.ImageLocation = strArchivo
                    Case 16
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic17.ImageLocation = strArchivo
                    Case 17
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic18.ImageLocation = strArchivo
                    Case 18
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic19.ImageLocation = strArchivo
                    Case 19
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic20.ImageLocation = strArchivo
                    Case 20
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic21.ImageLocation = strArchivo
                    Case 21
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic22.ImageLocation = strArchivo
                    Case 22
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic23.ImageLocation = strArchivo
                    Case 23
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic24.ImageLocation = strArchivo
                    Case 24
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic25.ImageLocation = strArchivo
                    Case 25
                        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(vector1(k)) + ".jpg".Trim)
                        pic26.ImageLocation = strArchivo
                End Select
            Next
#End Region '// fin llenado del vector uno de imagenes

#Region "Llenado Vector 2 (vector oponente)"
            Dim numeroAleatorio2 As Integer
            Dim contadorNumerosAleatorios2 As Integer = 0
            Dim validaNumero2 As Boolean = False

            lblInfoNumeros2.Text = ""

            Do While (contadorNumerosAleatorios2 < 26)
                Randomize()
                numeroAleatorio2 = (CInt(Rnd() * 25)) + 1

                For i = 0 To 25 Step 1
                    If vector2(i) = numeroAleatorio2 Then
                        validaNumero2 = True
                        Exit For
                    Else
                        validaNumero2 = False

                    End If
                Next

                If validaNumero2 = False Then
                    For j = 0 To 25 Step 1
                        If vector2(j) = 0 Then
                            vector2(j) = numeroAleatorio2
                            contadorNumerosAleatorios2 += 1

                            Exit For
                        End If
                    Next
                End If
            Loop

            ''// fin llenado del vector 2 de imagenes

            CartaTonto = numeroAleatorio2
            lblNumTonto.Text = Str(CartaTonto)

#End Region

            btnRevolverCartas.Visible = False
            MessageBox.Show("Para comparar las parejas, toma una carta del oponente,selecciona una carta de tu maso con un clic, y luego selecciona la carta que tomaste del maso del oponente.")

        Catch ex As Exception
            MessageBox.Show(" Ya se revolvio el maso !!!")
            btnRevolverCartas.Visible = False
        End Try

        btnRevolverCartas.Visible = False

        If btnRevolverCartas.Visible = False Then
            grpTomarCarta.Visible = True
        End If
    End Sub

    Private Sub btnVerTonto_Click(sender As Object, e As EventArgs) Handles btnVerTonto.Click
        Dim srRuta As String = Application.StartupPath
        Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(CartaTonto) + ".jpg".Trim)
        picTonto.ImageLocation = strArchivo
    End Sub

    Private Sub bntTomarCarta_Click(sender As Object, e As EventArgs) Handles bntTomarCarta.Click
        tomarCarta(vector2, pic10)

        For i = 0 To 25 Step 1
            If vector1(i) = 0 Then
                contJugador1 -= 1
            End If
        Next

        For i = 0 To 25 Step 1
            If vector2(i) = 0 Then
                contadorMaquina -= 1
            End If

            If contJugador1 = 0 Or contadorMaquina = 0 Then
                grpTonto.Visible = True

                If contJugador1 = 0 Then
                    MessageBox.Show(" El jugador 1 a ganado ya que quedo sin cartas ")
                End If

                If contadorMaquina = 0 Then
                    MessageBox.Show(" La maquina a ganado ya que quedo sin cartas ")
                End If
            End If
        Next
        txtcartasJugador1.Text = Str(contJugador1)
        txtcartasJugadorPc.Text = Str(contadorMaquina)
    End Sub

#Region "Metodos Creados"
    Public Sub tomarCarta(vec2() As Integer, pic10 As PictureBox)
        '// compara una poscion azar con lo que tiene el vector dos para elegir una carta
        Randomize()
        index = (CInt(Rnd() * 25))

        For i = 0 To 11 Step 1
            If vec2(index) <> 0 Then
                cartaOponente = vec2(index)
            Else
                index = (CInt(Rnd() * 25))
                cartaOponente = vec2(index)
            End If
        Next

        Select Case cartaOponente
            Case 0
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                picOponente.ImageLocation = strArchivo
            Case 1
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                picOponente.ImageLocation = strArchivo
            Case 2
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                picOponente.ImageLocation = strArchivo
            Case 3
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                picOponente.ImageLocation = strArchivo
            Case 4
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                picOponente.ImageLocation = strArchivo
            Case 5
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                picOponente.ImageLocation = strArchivo
            Case 6
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                picOponente.ImageLocation = strArchivo
            Case 7
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                picOponente.ImageLocation = strArchivo
            Case 8
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                picOponente.ImageLocation = strArchivo
            Case 9
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                picOponente.ImageLocation = strArchivo
            Case 10
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                picOponente.ImageLocation = strArchivo
            Case 11
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 12
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 13
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 14
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 15
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 16
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 17
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 18
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 19
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 20
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 21
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 22
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 23
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 24
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
            Case 25
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
        End Select
    End Sub '// fin tomarCarta

    Public Sub compararPareja(valorPosicionVector1 As Integer, posicionVector1 As Integer, pic1 As PictureBox, pic2 As PictureBox, pic3 As PictureBox, pic4 As PictureBox, pic5 As PictureBox, pic6 As PictureBox,
                               pic7 As PictureBox, pic8 As PictureBox, pic9 As PictureBox, pic10 As PictureBox, pic11 As PictureBox, pic12 As PictureBox,
                              pic13 As PictureBox, pic14 As PictureBox, pic15 As PictureBox, pic16 As PictureBox, pic17 As PictureBox, pic18 As PictureBox, pic19 As PictureBox, pic120 As PictureBox,
                              pic21 As PictureBox, pic22 As PictureBox, pic23 As PictureBox, pic24 As PictureBox, pic25 As PictureBox, pic26 As PictureBox, picOponente As PictureBox)

        If valorPosicionVector1 = cartaOponente Then

            Select Case posicionVector1
                Case 0
                    pic1.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0

                Case 1
                    pic2.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 2
                    pic3.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 3
                    pic4.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 4
                    pic5.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 5
                    pic6.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 7
                    pic8.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 8
                    pic9.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 9
                    pic10.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 10
                    pic11.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 11
                    pic12.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 12
                    pic13.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 13
                    pic14.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 14
                    pic15.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 15
                    pic16.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 16
                    pic17.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 17
                    pic18.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 18
                    pic19.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 19
                    pic20.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 20
                    pic21.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 21
                    pic22.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 22
                    pic23.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 23
                    pic24.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 24
                    pic25.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
                Case 25
                    pic26.ImageLocation = ""
                    vector1(valorPosicionVector1) = 0
            End Select
            contadorMaquina += 1
        End If

        If cartaOponente = valorPosicionVector1 Then
            Select Case index
                Case 0
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 1
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 2
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 3
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 4
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 5
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 7
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 8
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 9
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 10
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 11
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 12
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 13
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 14
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 15
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 16
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 17
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 18
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 19
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 20
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 21
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 22
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 23
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 24
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
                Case 25
                    picOponente.ImageLocation = ""
                    vector2(index) = 0
            End Select
            contJugador1 += 1
        End If
        posicionVector1 = 0
        valorPosicionVector1 = 0
        index = 0
        cartaOponente = 0

    End Sub '// fin compararPareja

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
        posicionVector1 = 4
        valorPosicionVector1 = vector1(4)
    End Sub

    Private Sub pic6_Click(sender As Object, e As EventArgs) Handles pic6.Click
        posicionVector1 = 5
        valorPosicionVector1 = vector1(5)
    End Sub

    Private Sub pic7_Click(sender As Object, e As EventArgs) Handles pic7.Click
        posicionVector1 = 6
        valorPosicionVector1 = vector1(6)
    End Sub

    Private Sub pic8_Click(sender As Object, e As EventArgs) Handles pic8.Click
        posicionVector1 = 7
        valorPosicionVector1 = vector1(7)
    End Sub

    Private Sub pic9_Click(sender As Object, e As EventArgs) Handles pic9.Click
        posicionVector1 = 8
        valorPosicionVector1 = vector1(8)
    End Sub

    Private Sub pic10_Click(sender As Object, e As EventArgs) Handles pic10.Click
        posicionVector1 = 9
        valorPosicionVector1 = vector1(9)
    End Sub

    Private Sub pic11_Click(sender As Object, e As EventArgs) Handles pic11.Click
        posicionVector1 = 10
        valorPosicionVector1 = vector1(10)
    End Sub

    Private Sub pic12_Click(sender As Object, e As EventArgs) Handles pic12.Click
        posicionVector1 = 11
        valorPosicionVector1 = vector1(11)
    End Sub

    Private Sub pic13_Click(sender As Object, e As EventArgs) Handles pic13.Click
        posicionVector1 = 12
        valorPosicionVector1 = vector1(12)
    End Sub

    Private Sub pic14_Click(sender As Object, e As EventArgs) Handles pic14.Click
        posicionVector1 = 13
        valorPosicionVector1 = vector1(13)
    End Sub

    Private Sub pic15_Click(sender As Object, e As EventArgs) Handles pic15.Click
        posicionVector1 = 14
        valorPosicionVector1 = vector1(14)
    End Sub

    Private Sub pic16_Click(sender As Object, e As EventArgs) Handles pic16.Click
        posicionVector1 = 15
        valorPosicionVector1 = vector1(15)
    End Sub

    Private Sub pic17_Click(sender As Object, e As EventArgs) Handles pic17.Click
        posicionVector1 = 16
        valorPosicionVector1 = vector1(16)
    End Sub

    Private Sub pic18_Click(sender As Object, e As EventArgs) Handles pic18.Click
        posicionVector1 = 17
        valorPosicionVector1 = vector1(17)
    End Sub

    Private Sub pic19_Click(sender As Object, e As EventArgs) Handles pic19.Click
        posicionVector1 = 18
        valorPosicionVector1 = vector1(18)
    End Sub

    Private Sub pic20_Click(sender As Object, e As EventArgs) Handles pic20.Click
        posicionVector1 = 19
        valorPosicionVector1 = vector1(19)
    End Sub

    Private Sub pic21_Click(sender As Object, e As EventArgs) Handles pic21.Click
        posicionVector1 = 20
        valorPosicionVector1 = vector1(20)
    End Sub

    Private Sub pic22_Click(sender As Object, e As EventArgs) Handles pic22.Click
        posicionVector1 = 21
        valorPosicionVector1 = vector1(21)
    End Sub

    Private Sub pic23_Click(sender As Object, e As EventArgs) Handles pic23.Click
        posicionVector1 = 22
        valorPosicionVector1 = vector1(22)
    End Sub

    Private Sub pic24_Click(sender As Object, e As EventArgs) Handles pic24.Click
        posicionVector1 = 23
        valorPosicionVector1 = vector1(23)
    End Sub

    Private Sub pic25_Click(sender As Object, e As EventArgs) Handles pic25.Click
        posicionVector1 = 24
        valorPosicionVector1 = vector1(24)
    End Sub

    Private Sub pic26_Click(sender As Object, e As EventArgs) Handles pic26.Click
        posicionVector1 = 25
        valorPosicionVector1 = vector1(25)
    End Sub

    Private Sub picOponente_Click(sender As Object, e As EventArgs) Handles picOponente.Click
        compararPareja(valorPosicionVector1, posicionVector1, pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12,
                       pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pic21, pic22, pic23, pic24, pic25, pic26, picOponente)
    End Sub


#End Region

End Class