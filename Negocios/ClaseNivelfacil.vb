Imports System.Windows.Forms

Public Class ClaseNivelfacil
#Region "Variables"
    Dim vec1() As Integer = {0, 0, 0, 0}
    Dim vec2() As Integer = {0, 0, 0, 0}

#End Region

#Region "Metodos"



    '//Asignamos numeros aleatorios a las picture box y subimos las imagenes
    Public Sub NumerosAleatorios(vector1() As Integer, pic0 As PictureBox, pic1 As PictureBox,
                      pic2 As PictureBox, pic3 As PictureBox, lblInfoNumeros As Label)

        Dim numeroAleatorio, contadorNumerosAleatorios As Integer
        Dim validaNumero As Boolean

        lblInfoNumeros.Text = ""
        vector1 = {0, 0, 0, 0}
        validaNumero = False
        contadorNumerosAleatorios = 0

        Do While (contadorNumerosAleatorios < 4)
            Randomize()
            numeroAleatorio = (CInt(Rnd() * 41)) + 1

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
                        vec1(j) = vector1(j)
                        contadorNumerosAleatorios += 1
                        Exit For
                    End If
                Next
            End If

        Loop

        For k = 0 To 3 Step 1
            lblInfoNumeros.Text += Str(vector1(k))
            Select Case k
                Case 0

                    pic0.ImageLocation = "C:\Users\micha\source\repos\tonto3\tonto3\Imagenes\a" + Str(vector1(k)) + ".jpg"
                Case 1
                    pic1.ImageLocation = "C:\Users\micha\source\repos\tonto3\tonto3\Imagenes\a" + Str(vector1(k)) + ".jpg"
                Case 2
                    pic2.ImageLocation = "C:\Users\micha\source\repos\tonto3\tonto3\Imagenes\a" + Str(vector1(k)) + ".jpg"
                Case 3
                    pic3.ImageLocation = "C:\Users\micha\source\repos\tonto3\tonto3\Imagenes\a" + Str(vector1(k)) + ".jpg"
            End Select
        Next

    End Sub '// Fin metodo NumerosAleatorios

    Public Sub pasarNumeros(vectorAux() As Integer)
        For i = 0 To vec1.Length - 1 Step 1
            vectorAux(i) = vec1(i)
        Next
    End Sub

    Public Sub Parejas(iVector() As Integer, iVector2() As Integer)

        For i = 0 To iVector.Length - 1 Step 1
            MessageBox.Show("El vector1 vale " + Str(iVector(i)))
        Next


        For j = 0 To iVector2.Length - 1 Step 1
            MessageBox.Show("El vector2 vale " + Str(iVector2(j)))
        Next

    End Sub



#End Region

End Class
