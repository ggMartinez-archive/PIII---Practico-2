Public Class FormularioDatos

    Private Sub FormularioDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Public Sub txtApeFrmDatos_TextChanged(sender As Object, e As EventArgs) Handles txtApeFrmDatos.TextChanged

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub
End Class