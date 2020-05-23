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
        If id >= 99 Then
            MsgBox("El numero no puede ser mayor a 99")
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ValidaNombre()
        ' Validar que tenga menos de 20 caracteres
        If nombre.Length > 20 Then
            MsgBox("El nombre no puede tener mas de 20 caracteres")
            Return False
        Else
            Return True
        End If


    End Function

    Public Function ValidarApellido()
        ' Validar que tenga menos de 20 caracteres
        If apellido.Length > 20 Then
            MsgBox("El apellido no puede tener mas de 20 caracteres")
            Return False
        Else
            Return True
        End If


    End Function

    Public Function ValidarDireccion()
        ' Validar que tenga menos de 50 caracteres
        If direccion.Length > 50 Then
            MsgBox("La direccion no debe contener mas de 50 caracteres")
            Return False
        Else
            Return True
        End If

    End Function

    Public Function ValidarTelefono()
        ' Validar que sea numero, de hasta 9 cifras
        If telefono.Length > 9 Then
            MsgBox("El numero no puede ser mayor a 9 cifras")
            Return False
        Else
            Return True
        End If


    End Function
End Class
