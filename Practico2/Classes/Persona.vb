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

    Public Function ValidarID(id As Integer)
        ' Validar que sea numero, menor a 99
        Return If(Me.id < 99, True, DirectCast(MsgBox("La ID debe ser menor a 99"), Object))
    End Function

    Public Function ValidaNombre(nombre As String)
        ' Validar que tenga menos de 20 caracteres
        Return If(nombre.Length < 20, True, DirectCast(MsgBox("El nombre debe tener menos de 20 caracteres"), Object))
    End Function

    Public Function ValidarApellido(apellido)
        ' Validar que tenga menos de 20 caracteres
        Return If(apellido.Length < 20, True, DirectCast(MsgBox("El apellido debe tener menos de 20 caracteres"), Object))
    End Function

    Public Function ValidarDireccion(direccion As String)
        ' Validar que tenga menos de 50 caracteres
        Return If(direccion.Length < 20, True, DirectCast(MsgBox("La direccion debe tener menos de 50 caracteres"), Object))
    End Function

    Public Function ValidarTelefono(telefono As String)
        ' Validar que sea numero, de hasta 9 cifras
        Return If(nombre.Length < 20, True, DirectCast(MsgBox("El telefono debe tener 9 cifras"), Object))
    End Function
End Class
