Public Class FrmDatos
    Private Sub FrmDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pe As New Persona

        CargarFormulario(pe)

    End Sub

    Public Sub CargarFormulario(pe As Persona)
        TxtId.Text = pe.GetId
        TxtNombre.Text = pe.GetNombre
        TxtApellido.Text = pe.GetApellido
        TxtDireccion.Text = pe.GetDireccion
        TxtTelefonos.Text = pe.GetTelefono

    End Sub
End Class