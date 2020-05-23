Public Class Persona

    Private id As Integer
    Private nombre As String
    Private apellido As String
    Private telefono As String
    Private direccion As String
    Friend Validacion As Char

    Public Sub SetId(idRecibido As String)
        Me.id = idRecibido
    End Sub

    Public Sub SetNombre(nombreRecibido As String)
        Me.nombre = nombreRecibido
    End Sub

    Public Sub SetApellido(apellidoRecibido As String)
        Me.apellido = apellidoRecibido
    End Sub

    Public Sub SetTelefono(telefonoRecibido As String)
        Me.telefono = telefonoRecibido
    End Sub

    Public Sub SetDireccion(direccionRecibida As String)
        Me.direccion = direccionRecibida
    End Sub

    Public Function GetNombre()
        Return Me.nombre
    End Function

    Public Function GetId()
        Return Me.id
    End Function

    Public Function GetApellido()
        Return Me.apellido
    End Function

    Public Function GetDireccion()
        Return Me.direccion
    End Function

    Public Function GetTelefono()
        Return Me.telefono
    End Function

    Public Function ValidarID(Validar) As Boolean
        ' Validar que sea numero, menor a 99
        If Char.IsLetter(Validar) Then
            MsgBox("Solo numeros admitidos")
            Return False
        Else
            If Validar <= 99 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function ValidaNombre(Validacion) As Boolean
        ' Validar que tenga menos de 20 caracteres
        If Len(Validacion) < 20 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidarApellido(Validacion) As Boolean
        ' Validar que tenga menos de 20 caracteres
        If Len(Validacion) < 20 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidarDireccion(Validacion) As Boolean
        ' Validar que tenga menos de 50 caracteres
        If Len(Validacion) < 50 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidarTelefono(Validar) As Boolean
        ' Validar que sea numero, de hasta 9 cifras
        If Char.IsLetter(Validar) Then
            MsgBox("Solo numeros admitidos")
            Return False
        Else
            If Len(Validar) <= 9 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
End Class
