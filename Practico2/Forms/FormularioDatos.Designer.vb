<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDatos
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
        Me.lblIDIngresado = New System.Windows.Forms.Label()
        Me.lblNombreIngresado = New System.Windows.Forms.Label()
        Me.lblApellidoIngresado = New System.Windows.Forms.Label()
        Me.lblDireccionIngresada = New System.Windows.Forms.Label()
        Me.lblTelefonoIngresado = New System.Windows.Forms.Label()
        Me.txtIDIngresado = New System.Windows.Forms.TextBox()
        Me.txtNombreIngresado = New System.Windows.Forms.TextBox()
        Me.txtApellidoIngresado = New System.Windows.Forms.TextBox()
        Me.txtDireccionIngresada = New System.Windows.Forms.TextBox()
        Me.txtTelefonoIngresado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblIDIngresado
        '
        Me.lblIDIngresado.AutoSize = True
        Me.lblIDIngresado.Location = New System.Drawing.Point(12, 9)
        Me.lblIDIngresado.Name = "lblIDIngresado"
        Me.lblIDIngresado.Size = New System.Drawing.Size(71, 13)
        Me.lblIDIngresado.TabIndex = 0
        Me.lblIDIngresado.Text = "ID Ingresado:"
        '
        'lblNombreIngresado
        '
        Me.lblNombreIngresado.AutoSize = True
        Me.lblNombreIngresado.Location = New System.Drawing.Point(12, 35)
        Me.lblNombreIngresado.Name = "lblNombreIngresado"
        Me.lblNombreIngresado.Size = New System.Drawing.Size(96, 13)
        Me.lblNombreIngresado.TabIndex = 1
        Me.lblNombreIngresado.Text = "Nombre ingresado:"
        '
        'lblApellidoIngresado
        '
        Me.lblApellidoIngresado.AutoSize = True
        Me.lblApellidoIngresado.Location = New System.Drawing.Point(12, 61)
        Me.lblApellidoIngresado.Name = "lblApellidoIngresado"
        Me.lblApellidoIngresado.Size = New System.Drawing.Size(96, 13)
        Me.lblApellidoIngresado.TabIndex = 2
        Me.lblApellidoIngresado.Text = "Apellido ingresado:"
        '
        'lblDireccionIngresada
        '
        Me.lblDireccionIngresada.AutoSize = True
        Me.lblDireccionIngresada.Location = New System.Drawing.Point(12, 87)
        Me.lblDireccionIngresada.Name = "lblDireccionIngresada"
        Me.lblDireccionIngresada.Size = New System.Drawing.Size(104, 13)
        Me.lblDireccionIngresada.TabIndex = 3
        Me.lblDireccionIngresada.Text = "Dirección ingresada:"
        '
        'lblTelefonoIngresado
        '
        Me.lblTelefonoIngresado.AutoSize = True
        Me.lblTelefonoIngresado.Location = New System.Drawing.Point(12, 113)
        Me.lblTelefonoIngresado.Name = "lblTelefonoIngresado"
        Me.lblTelefonoIngresado.Size = New System.Drawing.Size(102, 13)
        Me.lblTelefonoIngresado.TabIndex = 4
        Me.lblTelefonoIngresado.Text = "Teléfono Ingresado:"
        '
        'txtIDIngresado
        '
        Me.txtIDIngresado.Location = New System.Drawing.Point(122, 6)
        Me.txtIDIngresado.Name = "txtIDIngresado"
        Me.txtIDIngresado.ReadOnly = True
        Me.txtIDIngresado.Size = New System.Drawing.Size(100, 20)
        Me.txtIDIngresado.TabIndex = 5
        '
        'txtNombreIngresado
        '
        Me.txtNombreIngresado.Location = New System.Drawing.Point(122, 32)
        Me.txtNombreIngresado.Name = "txtNombreIngresado"
        Me.txtNombreIngresado.ReadOnly = True
        Me.txtNombreIngresado.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreIngresado.TabIndex = 6
        '
        'txtApellidoIngresado
        '
        Me.txtApellidoIngresado.Location = New System.Drawing.Point(122, 58)
        Me.txtApellidoIngresado.Name = "txtApellidoIngresado"
        Me.txtApellidoIngresado.ReadOnly = True
        Me.txtApellidoIngresado.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidoIngresado.TabIndex = 7
        '
        'txtDireccionIngresada
        '
        Me.txtDireccionIngresada.Location = New System.Drawing.Point(122, 84)
        Me.txtDireccionIngresada.Name = "txtDireccionIngresada"
        Me.txtDireccionIngresada.ReadOnly = True
        Me.txtDireccionIngresada.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccionIngresada.TabIndex = 8
        '
        'txtTelefonoIngresado
        '
        Me.txtTelefonoIngresado.Location = New System.Drawing.Point(122, 110)
        Me.txtTelefonoIngresado.Name = "txtTelefonoIngresado"
        Me.txtTelefonoIngresado.ReadOnly = True
        Me.txtTelefonoIngresado.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefonoIngresado.TabIndex = 9
        '
        'FrmDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 140)
        Me.Controls.Add(Me.txtTelefonoIngresado)
        Me.Controls.Add(Me.txtDireccionIngresada)
        Me.Controls.Add(Me.txtApellidoIngresado)
        Me.Controls.Add(Me.txtNombreIngresado)
        Me.Controls.Add(Me.txtIDIngresado)
        Me.Controls.Add(Me.lblTelefonoIngresado)
        Me.Controls.Add(Me.lblDireccionIngresada)
        Me.Controls.Add(Me.lblApellidoIngresado)
        Me.Controls.Add(Me.lblNombreIngresado)
        Me.Controls.Add(Me.lblIDIngresado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmDatos"
        Me.Text = "Datos Ingresados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIDIngresado As Label
    Friend WithEvents lblNombreIngresado As Label
    Friend WithEvents lblApellidoIngresado As Label
    Friend WithEvents lblDireccionIngresada As Label
    Friend WithEvents lblTelefonoIngresado As Label
    Friend WithEvents txtIDIngresado As TextBox
    Friend WithEvents txtNombreIngresado As TextBox
    Friend WithEvents txtApellidoIngresado As TextBox
    Friend WithEvents txtDireccionIngresada As TextBox
    Friend WithEvents txtTelefonoIngresado As TextBox
End Class
