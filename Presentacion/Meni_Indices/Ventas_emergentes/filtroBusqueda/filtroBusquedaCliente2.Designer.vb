<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filtroBusquedaCliente2
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
        Me.btnAcepFiltro = New System.Windows.Forms.Button()
        Me.rbtnTelefono = New System.Windows.Forms.RadioButton()
        Me.rbtnId = New System.Windows.Forms.RadioButton()
        Me.rbtnCliente = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnAcepFiltro
        '
        Me.btnAcepFiltro.BackColor = System.Drawing.Color.Blue
        Me.btnAcepFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcepFiltro.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnAcepFiltro.ForeColor = System.Drawing.Color.White
        Me.btnAcepFiltro.Location = New System.Drawing.Point(235, 77)
        Me.btnAcepFiltro.Name = "btnAcepFiltro"
        Me.btnAcepFiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnAcepFiltro.TabIndex = 16
        Me.btnAcepFiltro.Text = "Agregar"
        Me.btnAcepFiltro.UseVisualStyleBackColor = False
        '
        'rbtnTelefono
        '
        Me.rbtnTelefono.AutoSize = True
        Me.rbtnTelefono.Location = New System.Drawing.Point(123, 45)
        Me.rbtnTelefono.Name = "rbtnTelefono"
        Me.rbtnTelefono.Size = New System.Drawing.Size(67, 17)
        Me.rbtnTelefono.TabIndex = 15
        Me.rbtnTelefono.TabStop = True
        Me.rbtnTelefono.Text = "Telefono"
        Me.rbtnTelefono.UseVisualStyleBackColor = True
        '
        'rbtnId
        '
        Me.rbtnId.AutoSize = True
        Me.rbtnId.Location = New System.Drawing.Point(235, 45)
        Me.rbtnId.Name = "rbtnId"
        Me.rbtnId.Size = New System.Drawing.Size(56, 17)
        Me.rbtnId.TabIndex = 14
        Me.rbtnId.TabStop = True
        Me.rbtnId.Text = "Correo"
        Me.rbtnId.UseVisualStyleBackColor = True
        '
        'rbtnCliente
        '
        Me.rbtnCliente.AutoSize = True
        Me.rbtnCliente.Location = New System.Drawing.Point(31, 45)
        Me.rbtnCliente.Name = "rbtnCliente"
        Me.rbtnCliente.Size = New System.Drawing.Size(57, 17)
        Me.rbtnCliente.TabIndex = 13
        Me.rbtnCliente.TabStop = True
        Me.rbtnCliente.Text = "Cliente"
        Me.rbtnCliente.UseVisualStyleBackColor = True
        '
        'filtroBusquedaCliente2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(325, 117)
        Me.Controls.Add(Me.btnAcepFiltro)
        Me.Controls.Add(Me.rbtnTelefono)
        Me.Controls.Add(Me.rbtnId)
        Me.Controls.Add(Me.rbtnCliente)
        Me.Name = "filtroBusquedaCliente2"
        Me.Text = "filtroBusquedaCliente2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAcepFiltro As Button
    Friend WithEvents rbtnTelefono As RadioButton
    Friend WithEvents rbtnId As RadioButton
    Friend WithEvents rbtnCliente As RadioButton
End Class
