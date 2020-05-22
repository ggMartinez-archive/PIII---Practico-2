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

    Public Function ValidarID(id As String)
        ' Validar que sea numero, menor a 99

        Dim result As Boolean
        Dim id2 As Integer
        If Integer.TryParse(id, id2) AndAlso id2 > 0 AndAlso id2 < 100 Then

            result = True

        Else
            result = False
        End If

        ValidarID = result



    End Function

    Public Function ValidaNombre(nombre As String)
        ' Validar que tenga menos de 20 caracteres
        Dim result As Boolean
        If nombre.Trim.Length < 20 Then
            result = True
        Else
            result = False

        End If

        ValidaNombre = result

    End Function

    Public Function ValidarApellido(apellido As String)
        ' Validar que tenga menos de 20 caracteres
        Dim result As Boolean
        If apellido.Trim.Length < 20 Then
            result = True
        Else
            result = False

        End If

        ValidarApellido = result

    End Function

    Public Function ValidarDireccion(direccion As String)
        ' Validar que tenga menos de 50 caracteres
        Dim result As Boolean
        If direccion.Trim.Length < 50 Then
            result = True
        Else
            result = False

        End If

        ValidarDireccion = result

    End Function

    Public Function ValidarTelefono(telefono As String)
        ' Validar que sea numero, de hasta 9 cifras
        Dim result As Boolean

        Dim telefono2 As Integer
        If Integer.TryParse(telefono, telefono2) AndAlso telefono > 8 AndAlso telefono < 10 Then
            If telefono.Trim.Length < 10 Then
                result = True
            Else
                result = False
            End If

        End If

        ValidarTelefono = result

    End Function
End Class
