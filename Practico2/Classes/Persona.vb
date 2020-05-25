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

    Public Function GetNombre() As String
        Return Me.nombre
    End Function

    Public Function GetId() As Integer
        Return Me.id
    End Function

    Public Function GetApellido() As String
        Return Me.apellido
    End Function

    Public Function GetDireccion() As String
        Return Me.direccion
    End Function

    Public Function GetTelefono() As String
        Return Me.telefono
    End Function

    Public Function ValidarID() As Boolean

        ' Validar que sea numero, menor a 99
        Return True
    End Function

    Public Function ValidaNombre() As Boolean
        ' Validar que tenga menos de 20 caracteres
        Return True
    End Function

    Public Function ValidarApellido() As Boolean
        ' Validar que tenga menos de 20 caracteres
        Return True
    End Function

    Public Function ValidarDireccion() As Boolean
        ' Validar que tenga menos de 50 caracteres
        Return True
    End Function

    Public Function ValidarTelefono() As Boolean
        ' Validar que sea numero, de hasta 9 cifras
        Return True
    End Function
End Class
