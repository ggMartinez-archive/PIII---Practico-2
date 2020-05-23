Public Class FrmPrincipal

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona

        If txtId.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtDireccion.Text = "" Or txtTelefonos.Text = "" Then
            MsgBox("Por favor, llene todos los campos")
        ElseIf Not p.ValidarID(txtId.Text) Then
            MsgBox("Solo numeros, menor a 99", MsgBoxStyle.Information, "ID")
        ElseIf Not p.ValidaNombre(txtNombre.Text) Then
            MsgBox("Debe nombre debe contener menos de 20 caracteres", MsgBoxStyle.Information, "Nombre")
        ElseIf Not p.ValidarApellido(txtApellido.Text) Then
            MsgBox("El Apellido debe contener menos de 20 caracteres", MsgBoxStyle.Information, "Apellido")
        ElseIf Not p.ValidarDireccion(txtDireccion.Text) Then
            MsgBox("La direccion debe contener menos de 50 caracteres", MsgBoxStyle.Information, "Direccion")
        ElseIf Not p.ValidarTelefono(txtTelefonos.Text) Then
            MsgBox("El telefono debe ser numero, de hasta 9 cifras", MsgBoxStyle.Information, "Telefono")
        Else
            p.SetId(txtId.Text)
            p.SetNombre(txtNombre.Text)
            p.SetApellido(txtApellido.Text)
            p.SetDireccion(txtDireccion.Text)
            p.SetTelefono(txtTelefonos.Text)

            FormularioDatos.txtId.Text = p.GetId
            FormularioDatos.txtNombre.Text = p.GetNombre
            FormularioDatos.txtApellido.Text = p.GetApellido
            FormularioDatos.txtDireccion.Text = p.GetDireccion
            FormularioDatos.txtTelefono.Text = p.GetTelefono
            FormularioDatos.Show()
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If

    End Sub

End Class
