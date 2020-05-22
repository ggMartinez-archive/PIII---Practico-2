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
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_ape = New System.Windows.Forms.Label()
        Me.lbl_dir = New System.Windows.Forms.Label()
        Me.lbl_tel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(56, 60)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "ID"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Location = New System.Drawing.Point(56, 117)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nom.TabIndex = 1
        Me.lbl_nom.Text = "Nombre"
        '
        'lbl_ape
        '
        Me.lbl_ape.AutoSize = True
        Me.lbl_ape.Location = New System.Drawing.Point(202, 117)
        Me.lbl_ape.Name = "lbl_ape"
        Me.lbl_ape.Size = New System.Drawing.Size(44, 13)
        Me.lbl_ape.TabIndex = 2
        Me.lbl_ape.Text = "Apellido"
        '
        'lbl_dir
        '
        Me.lbl_dir.AutoSize = True
        Me.lbl_dir.Location = New System.Drawing.Point(56, 188)
        Me.lbl_dir.Name = "lbl_dir"
        Me.lbl_dir.Size = New System.Drawing.Size(52, 13)
        Me.lbl_dir.TabIndex = 3
        Me.lbl_dir.Text = "Dirección"
        '
        'lbl_tel
        '
        Me.lbl_tel.AutoSize = True
        Me.lbl_tel.Location = New System.Drawing.Point(202, 188)
        Me.lbl_tel.Name = "lbl_tel"
        Me.lbl_tel.Size = New System.Drawing.Size(49, 13)
        Me.lbl_tel.TabIndex = 4
        Me.lbl_tel.Text = "Teléfono"
        '
        'FormularioDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 259)
        Me.Controls.Add(Me.lbl_tel)
        Me.Controls.Add(Me.lbl_dir)
        Me.Controls.Add(Me.lbl_ape)
        Me.Controls.Add(Me.lbl_nom)
        Me.Controls.Add(Me.lbl_id)
        Me.Name = "FormularioDatos"
        Me.Text = "FormularioDatos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_ape As Label
    Friend WithEvents lbl_dir As Label
    Friend WithEvents lbl_tel As Label
End Class
