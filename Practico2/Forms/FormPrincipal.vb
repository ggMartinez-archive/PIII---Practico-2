Public Class FrmPrincipal

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona()
        Dim FormularioDatosVentana As New FormularioDatos()


        Dim Id As String = txtId.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim telefonos As String = txtTelefonos.Text
        Dim direccion As String = txtDireccion.Text



        If p.ValidarID(Id) = True Then
            p.SetId(Id)
            FormularioDatosVentana.txtId_Recibido.Text = txtId.Text

        Else
            MessageBox.Show("Dato incorrecto!", "Id, debe ser numero y no estar vacio",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        If p.ValidaNombre(nombre) = True Then
            p.SetNombre(nombre)
            FormularioDatosVentana.txtNombre_Recibido.Text = txtNombre.Text
        Else
            MessageBox.Show("Dato incorrecto!", "Nombre, debe contener menos de 20 caracteres",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        If p.ValidarApellido(apellido) = True Then
            p.SetApellido(apellido)
            FormularioDatosVentana.txtApellido_Recibido.Text = txtApellido.Text
        Else
            MessageBox.Show("Dato incorrecto!", "Apellido, debe contener menos de 20 caracteres",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


        If p.ValidarDireccion(direccion) = True Then
            p.SetDireccion(direccion)
            FormularioDatosVentana.txtDireccion_Recibido.Text = txtDireccion.Text
        Else
            MessageBox.Show("Dato incorrecto!", "Direccion, debe contener menos de 50 caracteres",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        If p.ValidarTelefono(telefonos) = True Then
            p.SetTelefono(telefonos)
            FormularioDatosVentana.txtTelefonos_Recibido.Text = txtTelefonos.Text
        Else
            MessageBox.Show("Dato incorrecto!", "Telefono, debe contener 9 caracteres",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If



        FormularioDatosVentana.Show()



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
