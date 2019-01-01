Public Class PersonClass

    'declare module/class variables
    Private m_intID As Integer
    Private m_strFirstName As String
    Private m_strLastName As String
    Private m_datBirthDate As Date
    Private m_strHomePhone As String
    Private m_strMobilePhone As String
    Private m_strAddress As String
    Private m_strEmail As String
    Private m_strFavorites As String
    Private m_intGiftCategories As Integer = 0
    Private m_strNotes As String

    'declare class properties
    Public Property ID() As Integer

        Get
            Return m_intID
        End Get
        Set(ByVal value As Integer)
            m_intID = value
        End Set

    End Property

    Public Property FirstName() As String

        Get
            Return m_strFirstName
        End Get
        Set(ByVal value As String)
            m_strFirstName = value
        End Set

    End Property

    Public Property LastName() As String

        Get
            Return m_strLastName
        End Get
        Set(ByVal value As String)
            m_strLastName = value
        End Set

    End Property

    Public Property BirthDay() As Date

        Get
            Return m_datBirthDate
        End Get
        Set(ByVal value As Date)
            If CDate(value) > Now Then Exit Property
            m_datBirthDate = value
        End Set

    End Property

    Public Property HomePhone() As String

        Get
            Return m_strHomePhone
        End Get
        Set(ByVal value As String)
            m_strHomePhone = value
        End Set

    End Property

    Public Property MobilePhone() As String

        Get
            Return m_strMobilePhone
        End Get
        Set(ByVal value As String)
            m_strMobilePhone = value
        End Set

    End Property

    Public Property Address() As String

        Get
            Return m_strAddress
        End Get
        Set(ByVal value As String)
            m_strAddress = value
        End Set

    End Property

    Public Property Email As String

        Get
            Return m_strEmail
        End Get
        Set(ByVal value As String)
            m_strEmail = value
        End Set

    End Property

    Public Property Favorites As String

        Get
            Return m_strFavorites
        End Get
        Set(ByVal value As String)
            m_strFavorites = value
        End Set

    End Property

    Public Property GiftCategories As Integer

        Get
            Return m_intGiftCategories
        End Get
        Set(ByVal value As Integer)
            m_intGiftCategories = value
        End Set

    End Property

    Public Property Notes As String

        Get
            Return m_strNotes
        End Get
        Set(ByVal value As String)
            m_strNotes = value
        End Set

    End Property

    Public ReadOnly Property DisplayName() As String

        Get
            Return Trim(m_strFirstName) & " " & Trim(m_strLastName)
        End Get

    End Property

    Public Sub New(Optional ByVal strFirstName As String = "", Optional ByVal strLastName As String = "")

        m_strFirstName = strFirstName
        m_strLastName = strLastName

    End Sub

End Class