Public Class ClaseJugador
    'Variables a trabajar
    Dim _NombreJugador As String
    Dim _EscogerNivel As String
    Dim _PuntuacionMax As Integer
    Dim _Tiempo As Integer

#Region "Propíedades"
    Public Property NombreJugador As String
        Get
            Return _NombreJugador
        End Get
        Set(value As String)
            _NombreJugador = value
        End Set
    End Property

    Public Property EscogerNivel As String
        Get
            Return _EscogerNivel
        End Get
        Set(value As String)
            _EscogerNivel = value
        End Set
    End Property

    Public Property PuntuacionMax As Integer
        Get
            Return _PuntuacionMax
        End Get
        Set(value As Integer)
            _PuntuacionMax = value
        End Set
    End Property

    Public Property Tiempo As Integer
        Get
            Return _Tiempo
        End Get
        Set(value As Integer)
            _Tiempo = value
        End Set
    End Property



#End Region

#Region "Metodos"
    'Validar Datos
    Sub Validar_Jugador()
        'Validar Nombre
        If Not IsNumeric(_NombreJugador) Then
            Throw New System.Exception("El nombre del jugador tiene que estar compuesto por letras")
        End If
    End Sub


#End Region


End Class
