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

    Public Function GetNombre(text As String)
        Return Me.nombre
    End Function

    Public Function GetId(text As String)
        Return Me.id
    End Function

    Public Function GetApellido(text As String)
        Return Me.apellido
    End Function

    Public Function GetDireccion(text As String)
        Return Me.direccion
    End Function

    Public Function GetTelefono(text As Integer)
        Return Me.telefono
    End Function

    Public Function ValidarID(ByVal id As String)
        ' Validar que sea numero, menor a 99

        If (id >= 99) Then
            MsgBox("Error en ID")
            Return False
        Else
            Return Me.id
        End If

    End Function

    Public Function ValidaNombre(ByVal nombre As String)
        ' Validar que tenga menos de 20 caracteres
        If (nombre.Length >= 20) Then
            MsgBox("Error en Nombre")
            Return False
        Else
            Return Me.nombre

        End If
    End Function

    Public Function ValidarApellido(ByVal apellido As String)
        ' Validar que tenga menos de 20 caracteres
        If (apellido.Length >= 20) Then
            MsgBox("Excede máximo de caracteres")
            Return False
        Else
            Return Me.apellido
        End If

    End Function

    Public Function ValidarDireccion(ByVal direccion As String)
        ' Validar que tenga menos de 50 caracteres
        If (direccion.Length >= 50) Then
            Return False
        Else
            Return Me.direccion
        End If

    End Function

    Public Function ValidarTelefono(ByVal telefono As String)
        ' Validar que sea numero, de hasta 9 cifras
        If (telefono.Length > 9) Then
            Return False
        Else
            Return Me.telefono

        End If

    End Function
End Class
