Public Class FormularioDatos
    Private Sub FormularioDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblID_Click(sender As Object, e As EventArgs) Handles lblID.Click

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6
        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtId_Recibido_TextChanged(sender As Object, e As EventArgs) Handles txtId_Recibido.TextChanged


    End Sub
End Class