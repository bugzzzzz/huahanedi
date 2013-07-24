Public Class edi
    Public Class systemtable
        Private _login_name As String
        Private _login_password As String

        Public Property login_name As String
            Get
                Return _login_name
            End Get
            Set(ByVal Value As String)
                _login_name = Value
            End Set
        End Property

        Public Property login_password As String
            Get
                Return _login_password
            End Get
            Set(value As String)
                _login_password = value
            End Set
        End Property

    End Class
End Class
