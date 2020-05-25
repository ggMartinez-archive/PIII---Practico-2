<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMostrarDatosDePersona
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textBoxId = New System.Windows.Forms.TextBox()
        Me.textBoxNombre = New System.Windows.Forms.TextBox()
        Me.textBoxApellido = New System.Windows.Forms.TextBox()
        Me.textBoxDireccion = New System.Windows.Forms.TextBox()
        Me.textBoxTelefono = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono"
        '
        'textBoxId
        '
        Me.textBoxId.Enabled = False
        Me.textBoxId.Location = New System.Drawing.Point(117, 32)
        Me.textBoxId.Name = "textBoxId"
        Me.textBoxId.Size = New System.Drawing.Size(100, 20)
        Me.textBoxId.TabIndex = 5
        '
        'textBoxNombre
        '
        Me.textBoxNombre.Enabled = False
        Me.textBoxNombre.Location = New System.Drawing.Point(117, 58)
        Me.textBoxNombre.Name = "textBoxNombre"
        Me.textBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNombre.TabIndex = 6
        '
        'textBoxApellido
        '
        Me.textBoxApellido.Enabled = False
        Me.textBoxApellido.Location = New System.Drawing.Point(117, 84)
        Me.textBoxApellido.Name = "textBoxApellido"
        Me.textBoxApellido.Size = New System.Drawing.Size(100, 20)
        Me.textBoxApellido.TabIndex = 7
        '
        'textBoxDireccion
        '
        Me.textBoxDireccion.Enabled = False
        Me.textBoxDireccion.Location = New System.Drawing.Point(117, 107)
        Me.textBoxDireccion.Name = "textBoxDireccion"
        Me.textBoxDireccion.Size = New System.Drawing.Size(100, 20)
        Me.textBoxDireccion.TabIndex = 8
        '
        'textBoxTelefono
        '
        Me.textBoxTelefono.Enabled = False
        Me.textBoxTelefono.Location = New System.Drawing.Point(117, 130)
        Me.textBoxTelefono.Name = "textBoxTelefono"
        Me.textBoxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.textBoxTelefono.TabIndex = 9
        '
        'FormMostrarDatosDePersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 178)
        Me.Controls.Add(Me.textBoxTelefono)
        Me.Controls.Add(Me.textBoxDireccion)
        Me.Controls.Add(Me.textBoxApellido)
        Me.Controls.Add(Me.textBoxNombre)
        Me.Controls.Add(Me.textBoxId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMostrarDatosDePersona"
        Me.Text = "Datos Personales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents textBoxId As TextBox
    Friend WithEvents textBoxNombre As TextBox
    Friend WithEvents textBoxApellido As TextBox
    Friend WithEvents textBoxDireccion As TextBox
    Friend WithEvents textBoxTelefono As TextBox
End Class
