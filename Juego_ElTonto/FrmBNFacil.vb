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
    Dim index As Integer
    Dim cartaOponente As Integer
    Dim contJugador1 As Integer = 4
    Dim contadorMaquina As Integer = 4

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

        btnRevolverCartas.Visible = True
    End Sub

    Private Sub btnRevolverCartas_Click(sender As Object, e As EventArgs) Handles btnRevolverCartas.Click
        Try
            Dim numeroAleatorio As Integer
            Randomize()
            numeroAleatorio = (CInt(Rnd() * 3)) + 1
            CartaTonto = numeroAleatorio


#Region "Llenado Vector 1"

            Dim contadorNumerosAleatorios As Integer = 0
            Dim validaNumero As Boolean = False

            lblInfoNumeros1.Text = ""

            Do While (contadorNumerosAleatorios < 4)

                numeroAleatorio = (CInt(Rnd() * 3)) + 1

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

#Region "Llenado Vector 2 (vector oponente)"
            Dim numeroAleatorio2 As Integer
            Dim contadorNumerosAleatorios2 As Integer = 0
            Dim validaNumero2 As Boolean = False

            lblInfoNumeros2.Text = ""

            Do While (contadorNumerosAleatorios2 < 4)
                Randomize()
                numeroAleatorio2 = (CInt(Rnd() * 3)) + 1

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
                            lblInfoV2.Text += Str(vector2(j))
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
            MessageBox.Show("Para comparar las parejas, selecciona una carta de tu maso con un clic, y luego selecciona la carta que tomaste del maso del oponente.")

        Catch ex As Exception
            MessageBox.Show(" Ya se revolvio el maso !!!")
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

    Private Sub pic10_Click(sender As Object, e As EventArgs) Handles pic10.Click

        compararPareja(valorPosicionVector1, posicionVector1, pic1, pic2, pic3, pic4, pic10)
    End Sub

    Private Sub bntTomarCarta_Click(sender As Object, e As EventArgs) Handles bntTomarCarta.Click

        tomarCarta(vector2, pic10)

        For i = 0 To 3 Step 1
            If vector1(i) = 0 Then
                contJugador1 -= 1
            End If
        Next

        For i = 0 To 3 Step 1
            If vector2(i) = 0 Then
                contadorMaquina -= 1
            End If

            If contJugador1 = 0 Or contadorMaquina = 0 Then
                grpTonto.Visible = True

                If contJugador1 = 0 Then
                    MessageBox.Show(" El jugador 1  a ganado ya que quedo sin cartas ")
                End If

                If contadorMaquina = 0 Then
                    MessageBox.Show(" La maquina a ganado ya que quedo sin cartas ")
                End If
            End If
        Next
        txtcartasJugador1.Text = Str(contJugador1)
        txtcartasJugadorPc.Text = Str(contadorMaquina)

        '// compara una poscion azar con lo que tiene el vector dos para elegir una carta
    End Sub







#Region "Metodos Creados"
    Public Sub tomarCarta(vec2() As Integer, pic10 As PictureBox)
        '// compara una poscion azar con lo que tiene el vector dos para elegir una carta
        Randomize()
        index = (CInt(Rnd() * 3))

        For i = 0 To 3 Step 1
            If vec2(index) <> 0 Then
                cartaOponente = vec2(index)
            Else
                index = (CInt(Rnd() * 3))
                cartaOponente = vec2(index)
            End If
        Next

        Select Case cartaOponente
            Case 0
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                pic10.ImageLocation = strArchivo
            Case 1
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                pic10.ImageLocation = strArchivo
            Case 2
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                pic10.ImageLocation = strArchivo
            Case 3
                Dim srRuta As String = Application.StartupPath
                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a" + Str(cartaOponente) + ".jpg".Trim)
                pic10.ImageLocation = strArchivo
        End Select
    End Sub

    Public Sub compararPareja(valorPosicionVector1 As Integer, posicionVector1 As Integer, pic1 As PictureBox, pic2 As PictureBox, pic3 As PictureBox, pic4 As PictureBox, pic10 As PictureBox)

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
            End Select
        Else
            contJugador1 += 1
        End If

        If cartaOponente = valorPosicionVector1 Then
            Select Case index
                Case 0
                    pic10.ImageLocation = ""
                    vector2(index) = 0
                Case 1
                    pic10.ImageLocation = ""
                    vector2(index) = 0
                Case 2
                    pic10.ImageLocation = ""
                    vector2(index) = 0
                Case 3
                    pic10.ImageLocation = ""
                    vector2(index) = 0
            End Select

        Else
            contadorMaquina += 1
        End If
        posicionVector1 = 0
        valorPosicionVector1 = 0
        index = 0
        cartaOponente = 0

    End Sub
#End Region

End Class'// fin class