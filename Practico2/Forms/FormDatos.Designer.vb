<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDatos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblIDResultado = New System.Windows.Forms.Label()
        Me.lblNombreResultado = New System.Windows.Forms.Label()
        Me.lblApellidoResultado = New System.Windows.Forms.Label()
        Me.lblDireccionResultado = New System.Windows.Forms.Label()
        Me.lblTelefonoResultado = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIDResultado
        '
        Me.lblIDResultado.BackColor = System.Drawing.Color.White
        Me.lblIDResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDResultado.Location = New System.Drawing.Point(12, 144)
        Me.lblIDResultado.Name = "lblIDResultado"
        Me.lblIDResultado.Size = New System.Drawing.Size(360, 30)
        Me.lblIDResultado.TabIndex = 0
        Me.lblIDResultado.Text = "identificador "
        Me.lblIDResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombreResultado
        '
        Me.lblNombreResultado.BackColor = System.Drawing.Color.White
        Me.lblNombreResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreResultado.Location = New System.Drawing.Point(12, 208)
        Me.lblNombreResultado.Name = "lblNombreResultado"
        Me.lblNombreResultado.Size = New System.Drawing.Size(360, 30)
        Me.lblNombreResultado.TabIndex = 1
        Me.lblNombreResultado.Text = "nombre"
        Me.lblNombreResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblApellidoResultado
        '
        Me.lblApellidoResultado.BackColor = System.Drawing.Color.White
        Me.lblApellidoResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoResultado.Location = New System.Drawing.Point(12, 280)
        Me.lblApellidoResultado.Name = "lblApellidoResultado"
        Me.lblApellidoResultado.Size = New System.Drawing.Size(360, 30)
        Me.lblApellidoResultado.TabIndex = 2
        Me.lblApellidoResultado.Text = "apellido"
        Me.lblApellidoResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDireccionResultado
        '
        Me.lblDireccionResultado.BackColor = System.Drawing.Color.White
        Me.lblDireccionResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionResultado.Location = New System.Drawing.Point(12, 350)
        Me.lblDireccionResultado.Name = "lblDireccionResultado"
        Me.lblDireccionResultado.Size = New System.Drawing.Size(360, 30)
        Me.lblDireccionResultado.TabIndex = 3
        Me.lblDireccionResultado.Text = "direccion"
        Me.lblDireccionResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTelefonoResultado
        '
        Me.lblTelefonoResultado.BackColor = System.Drawing.Color.White
        Me.lblTelefonoResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoResultado.Location = New System.Drawing.Point(12, 422)
        Me.lblTelefonoResultado.Name = "lblTelefonoResultado"
        Me.lblTelefonoResultado.Size = New System.Drawing.Size(360, 96)
        Me.lblTelefonoResultado.TabIndex = 4
        Me.lblTelefonoResultado.Text = "telefono"
        Me.lblTelefonoResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(12, 115)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(360, 29)
        Me.lblID.TabIndex = 5
        Me.lblID.Text = "ID Usuario"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(12, 174)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(360, 29)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre Usuario"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApellido
        '
        Me.lblApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(13, 251)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(360, 29)
        Me.lblApellido.TabIndex = 7
        Me.lblApellido.Text = "Apellido Usuario"
        Me.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDireccion
        '
        Me.lblDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(13, 321)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(360, 29)
        Me.lblDireccion.TabIndex = 8
        Me.lblDireccion.Text = "Direccion Usuario"
        Me.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTelefono
        '
        Me.lblTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(13, 393)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(360, 29)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Telefono Usuario"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 51)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Datos Peronales"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormDatos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(384, 527)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblTelefonoResultado)
        Me.Controls.Add(Me.lblDireccionResultado)
        Me.Controls.Add(Me.lblApellidoResultado)
        Me.Controls.Add(Me.lblNombreResultado)
        Me.Controls.Add(Me.lblIDResultado)
        Me.Name = "FormDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Usuarios"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblIDResultado As Label
    Friend WithEvents lblNombreResultado As Label
    Friend WithEvents lblApellidoResultado As Label
    Friend WithEvents lblDireccionResultado As Label
    Friend WithEvents lblTelefonoResultado As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents Label1 As Label
End Class
