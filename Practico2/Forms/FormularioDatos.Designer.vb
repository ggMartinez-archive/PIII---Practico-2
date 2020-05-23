<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioDatos
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
        Me.txtApeFrmDatos = New System.Windows.Forms.TextBox()
        Me.txtNombrFrmDatos = New System.Windows.Forms.TextBox()
        Me.txtDirecFrmDatos = New System.Windows.Forms.TextBox()
        Me.txtTelFrmDatos = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtIdFrmDatos = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtApeFrmDatos
        '
        Me.txtApeFrmDatos.Location = New System.Drawing.Point(101, 87)
        Me.txtApeFrmDatos.Name = "txtApeFrmDatos"
        Me.txtApeFrmDatos.Size = New System.Drawing.Size(100, 20)
        Me.txtApeFrmDatos.TabIndex = 0
        '
        'txtNombrFrmDatos
        '
        Me.txtNombrFrmDatos.Location = New System.Drawing.Point(101, 57)
        Me.txtNombrFrmDatos.Name = "txtNombrFrmDatos"
        Me.txtNombrFrmDatos.Size = New System.Drawing.Size(100, 20)
        Me.txtNombrFrmDatos.TabIndex = 1
        '
        'txtDirecFrmDatos
        '
        Me.txtDirecFrmDatos.Location = New System.Drawing.Point(101, 113)
        Me.txtDirecFrmDatos.Name = "txtDirecFrmDatos"
        Me.txtDirecFrmDatos.Size = New System.Drawing.Size(100, 20)
        Me.txtDirecFrmDatos.TabIndex = 2
        '
        'txtTelFrmDatos
        '
        Me.txtTelFrmDatos.Location = New System.Drawing.Point(101, 143)
        Me.txtTelFrmDatos.Name = "txtTelFrmDatos"
        Me.txtTelFrmDatos.Size = New System.Drawing.Size(100, 20)
        Me.txtTelFrmDatos.TabIndex = 3
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(58, 32)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 9
        Me.lblID.Text = "ID"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(43, 116)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 16
        Me.lblTelefono.Text = "Direccion"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(43, 143)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(49, 13)
        Me.lblDireccion.TabIndex = 15
        Me.lblDireccion.Text = "Telefono"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(46, 86)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 14
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(46, 60)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 13
        Me.lblNombre.Text = "Nombre"
        '
        'txtIdFrmDatos
        '
        Me.txtIdFrmDatos.Location = New System.Drawing.Point(101, 29)
        Me.txtIdFrmDatos.Name = "txtIdFrmDatos"
        Me.txtIdFrmDatos.Size = New System.Drawing.Size(100, 20)
        Me.txtIdFrmDatos.TabIndex = 17
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalir.Location = New System.Drawing.Point(101, 187)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 23)
        Me.BtnSalir.TabIndex = 18
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'FormularioDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 237)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.txtIdFrmDatos)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtTelFrmDatos)
        Me.Controls.Add(Me.txtDirecFrmDatos)
        Me.Controls.Add(Me.txtNombrFrmDatos)
        Me.Controls.Add(Me.txtApeFrmDatos)
        Me.Name = "FormularioDatos"
        Me.Text = "Formulario Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtApeFrmDatos As TextBox
    Friend WithEvents txtNombrFrmDatos As TextBox
    Friend WithEvents txtDirecFrmDatos As TextBox
    Friend WithEvents txtTelFrmDatos As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtIdFrmDatos As TextBox
    Friend WithEvents BtnSalir As Button
End Class
