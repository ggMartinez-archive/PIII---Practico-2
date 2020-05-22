<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioDatos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_ID = New System.Windows.Forms.Label()
        Me.Lbl_Apellido = New System.Windows.Forms.Label()
        Me.Lbl_Direccion = New System.Windows.Forms.Label()
        Me.Lbl_Telefono = New System.Windows.Forms.Label()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_ID
        '
        Me.Lbl_ID.AutoSize = True
        Me.Lbl_ID.Location = New System.Drawing.Point(148, 41)
        Me.Lbl_ID.Name = "Lbl_ID"
        Me.Lbl_ID.Size = New System.Drawing.Size(0, 17)
        Me.Lbl_ID.TabIndex = 0
        '
        'Lbl_Apellido
        '
        Me.Lbl_Apellido.AutoSize = True
        Me.Lbl_Apellido.Location = New System.Drawing.Point(148, 109)
        Me.Lbl_Apellido.Name = "Lbl_Apellido"
        Me.Lbl_Apellido.Size = New System.Drawing.Size(0, 17)
        Me.Lbl_Apellido.TabIndex = 1
        '
        'Lbl_Direccion
        '
        Me.Lbl_Direccion.AutoSize = True
        Me.Lbl_Direccion.Location = New System.Drawing.Point(148, 146)
        Me.Lbl_Direccion.Name = "Lbl_Direccion"
        Me.Lbl_Direccion.Size = New System.Drawing.Size(0, 17)
        Me.Lbl_Direccion.TabIndex = 2
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Location = New System.Drawing.Point(148, 182)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(0, 17)
        Me.Lbl_Telefono.TabIndex = 3
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Location = New System.Drawing.Point(148, 75)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(0, 17)
        Me.Lbl_Nombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Apellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Telefono"
        '
        'FormularioDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 259)
        Me.Controls.Add(Me.Lbl_Nombre)
        Me.Controls.Add(Me.Lbl_Telefono)
        Me.Controls.Add(Me.Lbl_Direccion)
        Me.Controls.Add(Me.Lbl_Apellido)
        Me.Controls.Add(Me.Lbl_ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormularioDatos"
        Me.Text = "FormularioDatos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_ID As Label
    Friend WithEvents Lbl_Apellido As Label
    Friend WithEvents Lbl_Direccion As Label
    Friend WithEvents Lbl_Telefono As Label
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
