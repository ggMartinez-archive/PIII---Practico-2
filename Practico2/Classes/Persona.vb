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

    Public Function ValidarID(ByRef id As Integer)
        ' Validar que sea numero, menor a 99
        If id >= 100 Then
            Return False
        Else
            Return True
        End If



    End Function

    Public Function ValidaNombre(ByRef nombre As String)
        ' Validar que tenga menos de 20 caracteres
        Dim val As Integer = nombre.Length
        If val <= 20 Then
            Return True
        Else
            Return False

        End If




    End Function

    Public Function ValidarApellido(ByRef apellido As String)
        ' Validar que tenga menos de 20 caracteres
        Dim val As Integer = apellido.Length
        If val <= 20 Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function ValidarDireccion(ByRef direccion As String)
        ' Validar que tenga menos de 50 caracteres
        Dim val As Integer = direccion.Length
        If val <= 50 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ValidarTelefono(ByRef telefono As String)
        ' Validar que sea numero, de hasta 9 cifras
        Dim val As Integer = telefono.Length
        If val <= 99999999 Then
            Return True
        Else
            Return False

        End If

    End Function
End Class
