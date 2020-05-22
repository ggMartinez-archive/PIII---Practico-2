<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormularioDatos
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblDirecion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(45, 25)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(45, 76)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(45, 127)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido"
        '
        'lblDirecion
        '
        Me.lblDirecion.AutoSize = True
        Me.lblDirecion.Location = New System.Drawing.Point(45, 178)
        Me.lblDirecion.Name = "lblDirecion"
        Me.lblDirecion.Size = New System.Drawing.Size(52, 13)
        Me.lblDirecion.TabIndex = 3
        Me.lblDirecion.Text = "Direccion"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(45, 229)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "Telefono"
        '
        'frmFormularioDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 275)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDirecion)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmFormularioDatos"
        Me.Text = "Formulario de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblDirecion As Label
    Friend WithEvents lblTelefono As Label
End Class
