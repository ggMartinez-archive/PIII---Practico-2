Public Class FormularioDatos
    Dim f As New Persona

    Private Sub FormularioDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Print(f.GetId())


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Print(f.GetNombre())


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Print(f.GetApellido())
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Print(f.GetDireccion())
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Print(f.GetTelefono())
    End Sub

End Class