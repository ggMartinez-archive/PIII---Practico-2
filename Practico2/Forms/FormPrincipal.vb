Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        Dim f As New FormularioDatos

        Dim comprueba As Integer

        'Validacion Id
        If p.ValidarID(txtId.Text) = True Then
            comprueba += 1
        End If

        'Validacion Nombre
        If p.ValidaNombre(txtNombre.Text) = True Then
            comprueba += 1
        End If

        'Validacion Apellido
        If p.ValidarApellido(txtApellido.Text) = True Then
            comprueba += 1
        End If

        'Validacion Direccion
        If p.ValidarDireccion(txtDireccion.Text) = True Then
            comprueba += 1
        End If

        'Validacion Telefono
        If p.ValidarTelefono(txtTelefonos.Text) = True Then
            comprueba += 1
        End If

        If comprueba = 5 Then

            f.LabelId.Text = txtId.Text
            f.LabelNombre.Text = txtNombre.Text
            f.LabelApellido.Text = txtApellido.Text
            f.LabelDireccion.Text = txtDireccion.Text
            f.LabelTelefono.Text = txtTelefonos.Text

            f.Show()

        End If


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub


End Class
