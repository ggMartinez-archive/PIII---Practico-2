Public Class FormDatos

    Private Sub FormDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblIDResultado.Text = DatosPersonas.identificador
        lblNombreResultado.Text = DatosPersonas.nombre
        lblApellidoResultado.Text = DatosPersonas.apellido
        lblDireccionResultado.Text = DatosPersonas.direccion
        lblTelefonoResultado.Text = DatosPersonas.telefono

    End Sub


End Class