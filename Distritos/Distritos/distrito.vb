
Public Class Distrito
    Private Nome_distrito As String
    Private Populacao_distrito As Integer
    Private numero_distrito As Integer
    Private Area_distrito As Double


    Public Property nome As String
        Get
            Return Nome_distrito
        End Get
        Set(value As String)
            Dim ch() As Char
            ch = value.ToCharArray
            ch(0) = UCase(ch(0))
            For i = 1 To UBound(ch)
                If ch(i) <> " " And ch(i - 1) <> " " Then
                    ch(i) = LCase(ch(i))
                Else
                    ch(i) = UCase(ch(i))
                End If
            Next
            Nome_distrito = CStr(ch)
        End Set
    End Property


    Public Property habitantes As Integer

        Get
            Return Populacao_distrito
        End Get
        Set(value As Integer)
            If value > 0 Then
                Populacao_distrito = value
            End If

        End Set
    End Property


    Public Property area As Double

        Get
            Return Area_distrito
        End Get
        Set(value As Double)
            Area_distrito = value

        End Set
    End Property


    Public Property numero As Integer

        Get
            Return numero_distrito
        End Get
        Set(value As Integer)
            numero_distrito = value

        End Set
    End Property

    Public Function densidade() As Double
        Return Populacao_distrito / Area_distrito
    End Function


    Public Function letras() As String
        Dim st As String = ""
        For i = 0 To 3
            st &= nome(i)

        Next
        Return st
    End Function

End Class
