Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        Dim Id As Integer = txtId.Text
        Dim Nombre As String = txtNombre.Text
        Dim Apellido As String = txtApellido.Text
        Dim Direccion As String = txtDireccion.Text
        Dim Telefono As String = txtTelefonos.Text

        p.SetId(Id)
        p.SetNombre(Nombre)
        p.SetApellido(Apellido)
        p.SetDireccion(Direccion)
        p.SetTelefono(Telefono)

        If p.ValidarID = True Then
            FormularioDatos.LabelId.Text = p.GetId

        Else
            MsgBox("Id no puede ser mas grade que 99")
        End If

        If p.ValidaNombre = True Then
            FormularioDatos.LabelNombre.Text = p.GetNombre
        Else
            MsgBox("El nombre no puede tener más de 19 caracteres")
        End If

        If p.ValidarApellido = True Then
            FormularioDatos.LabelApellido.Text = p.GetApellido
        Else
            MsgBox("El apellido no pude tener más de 19 caracteres")
        End If

        If p.ValidarDireccion = True Then
            FormularioDatos.LabelDireccion.Text = p.GetDireccion
        Else
            MsgBox("La direccion no puede tener más de 59 caracteres")
        End If

        If p.ValidarTelefono = True Then
            FormularioDatos.LabelTelefono.Text = p.GetTelefono
        Else
            MsgBox("El Telefono debe ser un numero y debe tener menos de 10 caracters")
        End If

        FormularioDatos.Show()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
