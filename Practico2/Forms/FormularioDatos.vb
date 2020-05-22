Public Class FormularioDatos
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblID.Click

    End Sub

    Private Sub FormularioDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Persona

        If p.ValidarID() Then
            Me.Label1.Text = p.GetId

        End If

    End Sub
End Class