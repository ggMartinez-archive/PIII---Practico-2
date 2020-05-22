Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        CargarPersona(p)
        If p.ValidarID Then
            If p.ValidaNombre Then
                If p.ValidarApellido Then
                    If p.ValidarDireccion Then
                        If p.ValidarTelefono Then


                        Else
                            MsgBox("Error en el Telefono")
                        End If
                    Else
                        MsgBox("Error en la Direccion")
                    End If
                Else
                    MsgBox("Error en el Apellido")
                End If
            Else
                MsgBox("Error en el Nombre")
            End If
        Else
            MsgBox("Error en el ID")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub

    Private Sub CargarPersona(p As Persona)
        p.SetId(txtId.Text)
        p.SetNombre(txtNombre.Text)
        p.SetApellido(txtApellido.Text)
        p.SetDireccion(txtId.Text)
        p.SetTelefono(txtTelefonos.Text)
    End Sub

End Class
