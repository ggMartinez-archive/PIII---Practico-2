Public Class FrmPrincipal
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Dim l As New List(Of String)
        Dim p As New Persona

        For Each line As String In Me.txtTelefonos.Text.Split(vbLf)
            l.Add(line)
        Next
        p.SetTelefono(l)

        MsgBox(p.GetTelefono())

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Const YES As Integer = 6

        If MsgBox("Desea Salir?", MsgBoxStyle.YesNo) = YES Then
            Application.Exit()
        End If
    End Sub
End Class
