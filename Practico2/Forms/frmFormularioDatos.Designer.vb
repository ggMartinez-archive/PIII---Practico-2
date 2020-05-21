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
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblID.Location = New System.Drawing.Point(38, 49)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(25, 22)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "id"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(38, 102)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(75, 22)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(38, 155)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(76, 22)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "apellido"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(38, 208)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(87, 22)
        Me.lblDireccion.TabIndex = 3
        Me.lblDireccion.Text = "direccion"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(38, 261)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(79, 22)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "telefono"
        '
        'frmFormularioDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 372)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmFormularioDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
End Class
