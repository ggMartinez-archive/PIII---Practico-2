Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        Dim formularioDatos As New FrmDatos

        If Char.IsNumber(txtId.Text) Then
            p.SetId(txtId.Text)
        End If
        p.SetNombre(txtNombre.Text)
        p.SetApellido(txtApellido.Text)
        p.SetDireccion(txtDireccion.Text)
        p.SetTelefono(txtTelefonos.Text)

        If p.ValidarID Then
            formularioDatos.txtIDIngresado.Text = p.GetId().ToString
        Else
            formularioDatos.txtIDIngresado.Text = "Error"
        End If

        If p.ValidaNombre Then
            formularioDatos.txtNombreIngresado.Text = p.GetNombre
        Else
            formularioDatos.txtNombreIngresado.Text = "Error"
        End If

        If p.ValidarApellido Then
            formularioDatos.txtApellidoIngresado.Text = p.GetApellido
        Else
            formularioDatos.txtApellidoIngresado.Text = "Error"
        End If

        If p.ValidarDireccion Then
            formularioDatos.txtDireccionIngresada.Text = p.GetDireccion
        Else
            formularioDatos.txtDireccionIngresada.Text = "Error"
        End If

        If p.ValidarTelefono Then
            formularioDatos.txtTelefonoIngresado.Text = p.GetTelefono
        Else
            formularioDatos.txtTelefonoIngresado.Text = "Error"
        End If

        formularioDatos.Show()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub
End Class
