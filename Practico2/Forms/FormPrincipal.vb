Public Class FrmPrincipal

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        Dim form As New FormularioDatos

        Dim validacion As Integer

        'Validacion Id
        If p.ValidarID(txtId.Text) = True Then
            validacion += 1
            txtId.BackColor = Color.White
        Else
            txtId.BackColor = Color.Red
        End If

        'Validacion Nombre
        If p.ValidaNombre(txtNombre.Text) = True Then
            validacion += 1
            txtNombre.BackColor = Color.White
        Else
            txtNombre.BackColor = Color.Red
        End If

        'Validacion Apellido
        If p.ValidarApellido(txtApellido.Text) = True Then
            validacion += 1
            txtApellido.BackColor = Color.White
        Else
            txtApellido.BackColor = Color.Red
        End If

        'Validacion Direccion
        If p.ValidarDireccion(txtDireccion.Text) = True Then
            validacion += 1
            txtDireccion.BackColor = Color.White
        Else
            txtDireccion.BackColor = Color.Red
        End If

        'Validacion Telefono
        If p.ValidarTelefono(Val(txtTelefonos.Text)) = True Then
            validacion += 1
            txtTelefonos.BackColor = Color.White
        Else
            txtTelefonos.BackColor = Color.Red
        End If

        If validacion = 5 Then

            form.Lbl_ID.Text = txtId.Text
            form.Lbl_Nombre.Text = txtNombre.Text
            form.Lbl_Apellido.Text = txtApellido.Text
            form.Lbl_Direccion.Text = txtDireccion.Text
            form.Lbl_Telefono.Text = Val(txtTelefonos.Text)

            form.Show()

            txtId.Clear()
            txtNombre.Clear()
            txtApellido.Clear()
            txtDireccion.Clear()
            txtTelefonos.Clear()

        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub

End Class
