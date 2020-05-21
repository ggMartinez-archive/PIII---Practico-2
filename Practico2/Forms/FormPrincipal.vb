Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        p.SetId(txtId.Text)
        p.SetNombre(txtNombre.Text)
        p.SetApellido(txtApellido.Text)
        p.SetDireccion(txtDireccion.Text)
        p.SetTelefono(txtTelefonos.Text)
        validarDatos(p)
    End Sub

    Private Sub validarDatos(p As Persona)
        If p.ValidarID(p) And p.ValidaNombre(p) And p.ValidarApellido(p) And p.ValidarDireccion(p) And p.ValidarTelefono(p) Then
            mostrarDatosFormularioDePersona(p)
        End If
    End Sub

    Private Sub mostrarDatosFormularioDePersona(p As Persona)
        frmFormularioDatos.lblID.Text = p.GetId
        frmFormularioDatos.lblNombre.Text = p.GetNombre
        frmFormularioDatos.lblApellido.Text = p.GetApellido
        frmFormularioDatos.lblDireccion.Text = p.GetDireccion
        frmFormularioDatos.lblTelefono.Text = p.GetTelefono
        frmFormularioDatos.ShowDialog()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub
End Class
