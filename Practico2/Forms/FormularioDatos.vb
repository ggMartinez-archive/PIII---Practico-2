Public Class FormularioDatos

    Private Sub FormDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblIDResultado.Text = ModuloVarios.identificador
        lblNombreResultado.Text = ModuloVarios.nombre
        lblApellidoResultado.Text = ModuloVarios.apellido
        lblDireccionResultado.Text = ModuloVarios.direccion
        lblTelefonoResultado.Text = ModuloVarios.telefono

    End Sub


End Class