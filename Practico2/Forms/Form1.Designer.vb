<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioDatos
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
        Me.LabelId = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Location = New System.Drawing.Point(75, 58)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(16, 13)
        Me.LabelId.TabIndex = 0
        Me.LabelId.Text = "Id"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(75, 89)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombre.TabIndex = 1
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelApellido
        '
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.Location = New System.Drawing.Point(75, 114)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(44, 13)
        Me.LabelApellido.TabIndex = 2
        Me.LabelApellido.Text = "Apellido"
        '
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Location = New System.Drawing.Point(75, 148)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LabelDireccion.TabIndex = 3
        Me.LabelDireccion.Text = "Direccion"
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Location = New System.Drawing.Point(75, 179)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LabelTelefono.TabIndex = 4
        Me.LabelTelefono.Text = "Telefono"
        '
        'FormularioDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 284)
        Me.Controls.Add(Me.LabelTelefono)
        Me.Controls.Add(Me.LabelDireccion)
        Me.Controls.Add(Me.LabelApellido)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelId)
        Me.Name = "FormularioDatos"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelId As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelApellido As Label
    Friend WithEvents LabelDireccion As Label
    Friend WithEvents LabelTelefono As Label
End Class
