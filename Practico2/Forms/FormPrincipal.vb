Public Class FrmPrincipal
    Private Id As String
    Private nombre As String
    Private apellido As String
    Private telefono As String
    Private direccion As String
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona


        Id = txtId.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        telefono = txtTelefonos.Text
        direccion = txtDireccion.Text



        ' p.SetId(Id)
        'p.SetNombre(nombre)
        'p.SetApellido(apellido)
        'p.SetTelefono(telefono)
        'p.SetDireccion(direccion)

        p.ValidarID(txtId)







    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class
