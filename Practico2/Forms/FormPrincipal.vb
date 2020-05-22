Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        Dim formulario As New FormularioDatos

        Dim valid As Integer

        If p.ValidarID(txtId.Text) = True Then
            valid += 1
        End If

        If p.ValidaNombre(txtNombre.Text) = True Then
            valid += 1
        End If

        If p.ValidarApellido(txtApellido.Text) = True Then
            valid += 1
        End If

        If p.ValidarDireccion(txtDireccion.Text) = True Then
            valid += 1
        End If

        If p.ValidarTelefono(txtTelefonos.Text) = True Then
            valid += 1
        End If

        If valid = 5 Then

            formulario.lbl_id.Text = txtId.Text
            formulario.lbl_nom.Text = txtNombre.Text
            formulario.lbl_ape.Text = txtApellido.Text
            formulario.lbl_dir.Text = txtDireccion.Text
            formulario.lbl_tel.Text = txtTelefonos.Text

            formulario.Show()

        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub

End Class
