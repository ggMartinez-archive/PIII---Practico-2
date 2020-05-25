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
        If Me.id < 99 Then
            Return True
        Else
            Return MsgBox("La ID debe ser menor a 99")
        End If
    End Function

    Public Function ValidaNombre()
        ' Validar que tenga menos de 20 caracteres
        Dim nombre As Boolean = If(Me.nombre.Length < 20, True, False)
        Return nombre
    End Function

    Public Function ValidarApellido()
        ' Validar que tenga menos de 20 caracteres
        Dim apellido As Boolean = If(Me.apellido.Length < 20, True, False)
        Return apellido
    End Function

    Public Function ValidarDireccion()
        ' Validar que tenga menos de 50 caracteres
        Dim direccion As Boolean = If(Me.direccion.Length < 50, True, False)
        Return direccion
    End Function

    Public Function ValidarTelefono()
        ' Validar que sea numero, de hasta 9 cifras
        Dim telefono As Boolean = If(Me.telefono.Length < 10, True, False)
        Return telefono
    End Function
End Class
