Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        'a continuación se setean las variables y se validan
        p.SetId(idRecibido:=txtId.Text)
        p.ValidarID(id:=txtId.Text)
        p.SetNombre(nombreRecibido:=txtNombre.Text)
        p.ValidaNombre(nombre:=txtNombre.Text)
        p.SetApellido(apellidoRecibido:=txtNombre.Text)
        p.ValidarApellido(apellido:=txtApellido.Text)
        p.SetDireccion(direccionRecibida:=txtDireccion.Text)
        p.ValidarDireccion(direccion:=txtDireccion.Text)
        p.SetTelefono(telefonoRecibido:=txtTelefonos.Text)
        p.ValidarTelefono(telefono:=txtTelefonos.Text)
        MostrarDatos(p)
        FormMostrarDatosDePersona.Show()


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub

    Private Sub MostrarDatos(p As Persona)
        FormMostrarDatosDePersona.textBoxId.Text = p.GetId
        FormMostrarDatosDePersona.textBoxNombre.Text = p.GetNombre
        FormMostrarDatosDePersona.textBoxApellido.Text = p.GetApellido
        FormMostrarDatosDePersona.textBoxDireccion.Text = p.GetDireccion
        FormMostrarDatosDePersona.textBoxTelefono.Text = p.GetTelefono
    End Sub
End Class
