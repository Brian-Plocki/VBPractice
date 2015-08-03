Public Class Person

    Private myName As String
    Private myAge As String
    Private myCity As String
    Private myZip As String


    Property Name() As String

        Get
            Return myName

        End Get

        Set(ByVal value As String)

            myName = value

        End Set

    End Property

    Property Age() As String

        Get
            Return myAge

        End Get

        Set(ByVal value As String)

            myAge = value

        End Set

    End Property

    Property City() As String

        Get
            Return myCity

        End Get

        Set(ByVal value As String)

            myCity = value

        End Set

    End Property

    Property Zip() As String

        Get
            Return myZip

        End Get

        Set(ByVal value As String)

            myZip = value

        End Set

    End Property

    Public Overrides Function ToString() As String
        Return myName.ToString() + " ," + myAge.ToString() + " ," + myCity.ToString() + " ," + myZip.ToString()
    End Function


End Class
