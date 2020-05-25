Module ModuloVarios

    Public identificador As Integer
    Public nombre As String
    Public apellido As String
    Public direccion As String
    Public telefono As String

    Public Function ValidacionDatos(p As Persona) As Boolean

        If p.ValidarID Then
        ElseIf p.ValidaNombre() Then

        ElseIf p.ValidarApellido() Then

        ElseIf p.ValidarDireccion() Then

        ElseIf p.ValidarTelefono() Then

            Return True

        End If

    End Function
    Public Sub ValidaSoloNumeros(e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            'No permite escribir
        End If

    End Sub

    Public Sub ValidaSoloLetras(e As KeyPressEventArgs)

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            'No permite escribir
        End If

    End Sub



End Module
