Public Class FrmPrincipal

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        If txtId.TextLength = 0 Or txtApellido.TextLength = 0 Or txtNombre.TextLength = 0 Or txtDireccion.TextLength = 0 Or txtTelefonos.TextLength = 0 Then
            MsgBox("Campos Vacios")
        Else
            If p.ValidarID(txtId.Text) Then

            Else
                MsgBox("ID debe ser menor a 99")
            End If

            If p.ValidaNombre(txtNombre.Text) Then

            Else
                MsgBox("Nombre debe ser menor a 20 caracteres")
            End If

            If p.ValidarApellido(txtApellido.Text) Then
            Else
                MsgBox("Apellido debe ser menor a 20 caracteres")
            End If

            If p.ValidarDireccion(txtDireccion.Text) Then
            Else
                MsgBox("Direccion debe ser menor a 50 caracteres")
            End If

            If p.ValidarTelefono(txtTelefonos.Text) Then
            Else
                MsgBox("Telefono de hasta 9 cifras solamente")
            End If
            ' Cargo lo seters.
            p.SetId(txtId.Text)
            p.SetNombre(txtNombre.Text)
            p.SetApellido(txtApellido.Text)
            p.SetDireccion(txtDireccion.Text)
            p.SetTelefono(txtTelefonos.Text)
            ' Muestro FormularioDatos con sus Getters.
            FormularioDatos.Show()
            FormularioDatos.txtIdFrmDatos.Text = p.GetId
            FormularioDatos.txtNombrFrmDatos.Text = p.GetNombre
            FormularioDatos.txtApeFrmDatos.Text = p.GetApellido
            FormularioDatos.txtDirecFrmDatos.Text = p.GetDireccion
            FormularioDatos.txtTelFrmDatos.Text = p.GetTelefono

        End If

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

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub txtTelefonos_TextChanged(sender As Object, e As EventArgs) Handles txtTelefonos.TextChanged

    End Sub
End Class
