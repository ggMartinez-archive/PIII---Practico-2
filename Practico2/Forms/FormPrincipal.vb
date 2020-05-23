Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ' En este metodo se debe realizar la validacion de los datos del formulario.
        ' Se debe trabajar con la instancia "p" de Persona, cargando los datos del 
        ' formulario en sus atributos, y ejecutando los metodos de validacion.
        ' Una vez validado el formulario, se debe mostrar FormularioDatos con la
        ' informacion proveniente de este formulario.

        Dim p As New Persona
        CargarPersona(p)
        ValidacionesCompletas(p)
        If ValidacionesCompletas(p) = 1 Then
        Else
            FrmDatos.Show()
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub

    Private Sub CargarPersona(p As Persona)
        p.SetId(Val(txtId.Text))
        Console.WriteLine(Val(txtId.Text))
        p.SetNombre(txtNombre.Text)
        p.SetApellido(txtApellido.Text)
        p.SetDireccion(txtDireccion.Text)
        p.SetTelefono(txtTelefonos.Text)
    End Sub

    Public Function ValidacionesCompletas(p As Persona)
        Dim Falso As Integer

        If p.ValidarID Then

        Else
            Falso = 1
        End If

        If p.ValidaNombre Then
        Else
            Falso = 1
        End If

        If p.ValidarApellido Then
        Else
            Falso = 1
        End If

        If p.ValidarDireccion Then
        Else
            Falso = 1
        End If

        If p.ValidarTelefono Then
        Else
            Falso = 1
        End If

        Return Falso
    End Function

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
