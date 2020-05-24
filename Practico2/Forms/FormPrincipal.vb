Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        p.SetId(idRecibido:=txtId.Text)
        p.SetNombre(nombreRecibido:=txtNombre.Text)
        p.SetApellido(apellidoRecibido:=txtNombre.Text)
        p.SetDireccion(direccionRecibida:=txtDireccion.Text)
        p.SetTelefono(telefonoRecibido:=txtTelefonos.Text)


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub
End Class
