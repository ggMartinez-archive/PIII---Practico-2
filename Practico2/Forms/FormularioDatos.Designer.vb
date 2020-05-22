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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtId_Recibido = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre_Recibido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtApellido_Recibido = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtDireccion_Recibido = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtTelefonos_Recibido = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recibido"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(12, 44)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 9
        Me.lblID.Text = "ID"
        '
        'txtId_Recibido
        '
        Me.txtId_Recibido.Location = New System.Drawing.Point(12, 60)
        Me.txtId_Recibido.Name = "txtId_Recibido"
        Me.txtId_Recibido.Size = New System.Drawing.Size(100, 20)
        Me.txtId_Recibido.TabIndex = 10
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(131, 44)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre_Recibido
        '
        Me.txtNombre_Recibido.Location = New System.Drawing.Point(132, 60)
        Me.txtNombre_Recibido.Name = "txtNombre_Recibido"
        Me.txtNombre_Recibido.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre_Recibido.TabIndex = 12
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(131, 83)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 13
        Me.lblApellido.Text = "Apellido"
        '
        'txtApellido_Recibido
        '
        Me.txtApellido_Recibido.Location = New System.Drawing.Point(132, 99)
        Me.txtApellido_Recibido.Name = "txtApellido_Recibido"
        Me.txtApellido_Recibido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido_Recibido.TabIndex = 14
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(12, 83)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 15
        Me.lblTelefono.Text = "Direccion"
        '
        'txtDireccion_Recibido
        '
        Me.txtDireccion_Recibido.Location = New System.Drawing.Point(12, 99)
        Me.txtDireccion_Recibido.Name = "txtDireccion_Recibido"
        Me.txtDireccion_Recibido.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion_Recibido.TabIndex = 16
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(12, 122)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(49, 13)
        Me.lblDireccion.TabIndex = 17
        Me.lblDireccion.Text = "Telefono"
        '
        'txtTelefonos_Recibido
        '
        Me.txtTelefonos_Recibido.Location = New System.Drawing.Point(12, 138)
        Me.txtTelefonos_Recibido.Multiline = True
        Me.txtTelefonos_Recibido.Name = "txtTelefonos_Recibido"
        Me.txtTelefonos_Recibido.Size = New System.Drawing.Size(220, 23)
        Me.txtTelefonos_Recibido.TabIndex = 18
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalir.Location = New System.Drawing.Point(75, 206)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 23)
        Me.BtnSalir.TabIndex = 19
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'FormularioDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(244, 299)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.txtTelefonos_Recibido)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtDireccion_Recibido)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtApellido_Recibido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtNombre_Recibido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtId_Recibido)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormularioDatos"
        Me.Text = "FormularioDatos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtId_Recibido As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre_Recibido As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtApellido_Recibido As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtDireccion_Recibido As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtTelefonos_Recibido As TextBox
    Friend WithEvents BtnSalir As Button
End Class
