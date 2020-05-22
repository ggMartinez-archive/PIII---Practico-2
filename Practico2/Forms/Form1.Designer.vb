<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtTelefonos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(15, 24)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(16, 13)
        Me.LblId.TabIndex = 0
        Me.LblId.Text = "Id"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(15, 105)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(15, 195)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 2
        Me.LblApellido.Text = "Apellido"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(15, 369)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 3
        Me.LblTelefono.Text = "Telefono"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(15, 283)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LblDireccion.TabIndex = 4
        Me.LblDireccion.Text = "Direccion"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(127, 24)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(132, 20)
        Me.TxtId.TabIndex = 5
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(127, 105)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(132, 20)
        Me.TxtNombre.TabIndex = 6
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(127, 192)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.ReadOnly = True
        Me.TxtApellido.Size = New System.Drawing.Size(132, 20)
        Me.TxtApellido.TabIndex = 7
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(127, 276)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ReadOnly = True
        Me.TxtDireccion.Size = New System.Drawing.Size(132, 20)
        Me.TxtDireccion.TabIndex = 8
        '
        'TxtTelefonos
        '
        Me.TxtTelefonos.Location = New System.Drawing.Point(127, 362)
        Me.TxtTelefonos.Multiline = True
        Me.TxtTelefonos.Name = "TxtTelefonos"
        Me.TxtTelefonos.ReadOnly = True
        Me.TxtTelefonos.Size = New System.Drawing.Size(132, 67)
        Me.TxtTelefonos.TabIndex = 9
        '
        'FrmDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 450)
        Me.Controls.Add(Me.TxtTelefonos)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.LblDireccion)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblId)
        Me.Name = "FrmDatos"
        Me.Text = "Mira tus datos "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblId As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblDireccion As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtTelefonos As TextBox
End Class
