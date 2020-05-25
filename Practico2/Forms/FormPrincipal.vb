Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        CargaDatos(p)
        FormDatos.Show()

    End Sub
    Private Sub CargaDatos(p As Persona)


        p.SetId(CInt(txtId.Text))
        p.SetNombre(txtNombre.Text)
        p.SetApellido(txtApellido.Text)
        p.SetDireccion(txtDireccion.Text)
        p.SetTelefono(txtbTelefono.Text)

        DatosPersonas.identificador = Convert.ToString(p.GetId())
        DatosPersonas.nombre = p.GetNombre()
        DatosPersonas.apellido = p.GetApellido()
        DatosPersonas.direccion = p.GetDireccion()
        DatosPersonas.telefono = p.GetTelefono()


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub

End Class
