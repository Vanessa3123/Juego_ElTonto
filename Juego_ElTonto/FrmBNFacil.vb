﻿Imports Negocios
Public Class FrmBNFacil

    Dim obj_manejar As New ClaseNivelfacil
    Dim obj_jugador As New ClaseJugador
    Public contador As Integer = 0
    Public contador2 As Integer = 0

    Dim vector1() As Integer = {0, 0, 0, 0}
    Dim vector2() As Integer = {0, 0, 0, 0}
    Dim CartaTonto As Integer = 0

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

        Dim siHayParejas As Boolean = False
        grpTomarCarta.Visible = True

        'Recorremos los vectores en ambos sentidos, donde cumpl la condicion de que sean iguales coloca imagen del escudo
        For i = 0 To vector1.Length - 1 Step 1
            For j = 0 To vector2.Length - 1 Step 1

                If vector1(i).Equals(vector2(j)) Then
                    For k = 0 To 3 Step 1
                        Dim srRuta As String = Application.StartupPath
                        Select Case i
                            Case 0
                                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a 0.jpg")
                                pic1.ImageLocation = strArchivo
                            Case 1
                                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a 0.jpg")
                                pic2.ImageLocation = strArchivo
                            Case 2
                                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a 0.jpg")
                                pic3.ImageLocation = strArchivo
                            Case 3
                                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a 0.jpg")
                                pic4.ImageLocation = strArchivo
                        End Select
                    Next
                End If

                If vector1(j).Equals(vector2(i)) Then
                    For m = 0 To 3 Step 1
                        Dim srRuta As String = Application.StartupPath
                        Select Case i
                            Case 0
                                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a 0.jpg")
                                pic5.ImageLocation = strArchivo
                            Case 1
                                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a 0.jpg")
                                pic6.ImageLocation = strArchivo
                            Case 2
                                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a 0.jpg")
                                pic7.ImageLocation = strArchivo
                            Case 3
                                Dim strArchivo As String = My.Computer.FileSystem.CombinePath(srRuta, "imagenes\a 0.jpg")
                                pic8.ImageLocation = strArchivo
                        End Select
                    Next
                    siHayParejas = True
                End If
            Next
        Next

        If Not siHayParejas Then
            MessageBox.Show("No tienes ninguna Pareja")
        End If

    End Sub

    Private Sub btnRevolverCartas_Click(sender As Object, e As EventArgs) Handles btnRevolverCartas.Click
        Try


#Region "Llenado Vector 1"
            Dim numeroAleatorio As Integer
            Dim contadorNumerosAleatorios As Integer = 0
            Dim validaNumero As Boolean = False

            lblInfoNumeros1.Text = ""

            Do While (contadorNumerosAleatorios < 4)
                Randomize()
                numeroAleatorio = (CInt(Rnd() * 15)) + 1

                CartaTonto = numeroAleatorio
                lblNumTonto.Text = Str(CartaTonto)



                For i = 0 To 3 Step 1
                    If vector1(i) = numeroAleatorio Then
                        validaNumero = True
                    ElseIf vector1(i) = CartaTonto Then
                        validaNumero = False
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

            Do While (contadorNumerosAleatorios2 <4)
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

    Private Sub bntTomarCarta_Click(sender As Object, e As EventArgs) Handles bntTomarCarta.Click

    End Sub
End Class