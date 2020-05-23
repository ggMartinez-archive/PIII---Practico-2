Public Class FrmDatos
    Private Sub FrmDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarFormulario()

    End Sub

    Public Sub CargarFormulario()
        Me.TxtId.Text = FrmPrincipal.txtId.Text
        Me.TxtNombre.Text = FrmPrincipal.txtNombre.Text
        Me.TxtApellido.Text = FrmPrincipal.txtApellido.Text
        Me.TxtDireccion.Text = FrmPrincipal.txtDireccion.Text
        Me.TxtTelefonos.Text = FrmPrincipal.txtTelefonos.Text
    End Sub
End Class