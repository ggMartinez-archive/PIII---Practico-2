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



        Dim datos As New FormularioDatos

        Dim nombre As String = p.GetNombre()
        Dim apellido As String = p.GetApellido()
        Dim telefono As String = p.GetTelefono()
        Dim direccion As String = p.GetDireccion()

        Dim id As Integer = p.GetId()



        If p.ValidaNombre(nombre) = True Then
            datos.lblNombre.Text = p.GetNombre()
        End If

        If p.ValidarApellido(apellido) = True Then
            datos.lblApellido.Text = p.GetApellido()
        End If

        If p.ValidarID(id) = True Then
            datos.lblID.Text = p.GetId()
        End If

        If p.ValidarDireccion(direccion) = True Then
            datos.lblDireccion.Text = p.GetDireccion()
        End If

        If p.ValidarTelefono(telefono) = True Then
            datos.lblTelefono.Text = p.GetTelefono()
        End If












    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub
End Class
