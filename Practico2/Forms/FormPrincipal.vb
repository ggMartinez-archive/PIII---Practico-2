Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        CargaDatos(p)
        'ModuloVarios.ValidacionDatos(p)
        MuestraFormularioDatos(p)


    End Sub
    'Carga datos del formPrincipal a la Clase Persona

    Private Sub CargaDatos(p As Persona)
        p.SetId(txtId.Text)
        p.SetNombre(txtNombre.Text)
        p.SetApellido(txtApellido.Text)
        p.SetDireccion(txtDireccion.Text)
        p.SetTelefono(txtbTelefono.Text)


    End Sub
    'Carga datos de la clase persona a formulario Datos

    Private Sub MuestraFormularioDatos(p As Persona)

        ModuloVarios.identificador = p.GetId()
        ModuloVarios.nombre = p.GetNombre()
        ModuloVarios.apellido = p.GetApellido()
        ModuloVarios.direccion = p.GetDireccion()
        ModuloVarios.telefono = p.GetTelefono()
        FormularioDatos.Show()
    End Sub
    'Boton Salir

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress
        ModuloVarios.ValidaSoloNumeros(e)
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        ModuloVarios.ValidaSoloLetras(e)
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        ModuloVarios.ValidaSoloLetras(e)
    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        ModuloVarios.ValidaSoloLetras(e)
    End Sub

    Private Sub txtbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbTelefono.KeyPress
        ModuloVarios.ValidaSoloNumeros(e)
    End Sub

End Class
