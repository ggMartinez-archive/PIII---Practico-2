Public Class Persona

    Private id As Integer
    Private nombre As String
    Private apellido As String
    Private telefono As String
    Private direccion As String

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

    Public Function ValidarID()
        ' Validar que sea numero, menor a 99
        If Me.id < 99 And IsNumeric(Me.id) Then
            Return True

        End If

        Return False
    End Function

    Public Function ValidaNombre()
        ' Validar que tenga menos de 20 caracteres
        Dim contador As String
        contador = Len(Me.nombre)
        If contador < 20 Then
            Return True
        End If
        Return False
    End Function

    Public Function ValidarApellido()
        ' Validar que tenga menos de 20 caracteres
        Dim contador As String
        contador = Len(Me.apellido)
        If contador < 20 Then
            Return True
        End If
        Return False
    End Function

    Public Function ValidarDireccion()
        ' Validar que tenga menos de 50 caracteres
        Dim contador As String
        contador = Len(Me.direccion)
        If contador < 50 Then
            Return True
        End If
        Return False
    End Function

    Public Function ValidarTelefono()
        ' Validar que sea numero, de hasta 9 cifras
        Dim contador As String

        contador = Len(Me.telefono)
        If contador <= 9 And IsNumeric(Me.telefono) Then
            Return True
        End If
        Return False
    End Function
End Class
