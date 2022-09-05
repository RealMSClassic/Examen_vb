<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmfiltro
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
        Me.rbtnCliente = New System.Windows.Forms.RadioButton()
        Me.rbtnId = New System.Windows.Forms.RadioButton()
        Me.rbtnTelefono = New System.Windows.Forms.RadioButton()
        Me.btnAcepFiltro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbtnCliente
        '
        Me.rbtnCliente.AutoSize = True
        Me.rbtnCliente.Location = New System.Drawing.Point(26, 41)
        Me.rbtnCliente.Name = "rbtnCliente"
        Me.rbtnCliente.Size = New System.Drawing.Size(57, 17)
        Me.rbtnCliente.TabIndex = 0
        Me.rbtnCliente.TabStop = True
        Me.rbtnCliente.Text = "Cliente"
        Me.rbtnCliente.UseVisualStyleBackColor = True
        '
        'rbtnId
        '
        Me.rbtnId.AutoSize = True
        Me.rbtnId.Location = New System.Drawing.Point(119, 41)
        Me.rbtnId.Name = "rbtnId"
        Me.rbtnId.Size = New System.Drawing.Size(36, 17)
        Me.rbtnId.TabIndex = 1
        Me.rbtnId.TabStop = True
        Me.rbtnId.Text = "ID"
        Me.rbtnId.UseVisualStyleBackColor = True
        '
        'rbtnTelefono
        '
        Me.rbtnTelefono.AutoSize = True
        Me.rbtnTelefono.Location = New System.Drawing.Point(215, 41)
        Me.rbtnTelefono.Name = "rbtnTelefono"
        Me.rbtnTelefono.Size = New System.Drawing.Size(67, 17)
        Me.rbtnTelefono.TabIndex = 2
        Me.rbtnTelefono.TabStop = True
        Me.rbtnTelefono.Text = "Telefono"
        Me.rbtnTelefono.UseVisualStyleBackColor = True
        '
        'btnAcepFiltro
        '
        Me.btnAcepFiltro.BackColor = System.Drawing.Color.Blue
        Me.btnAcepFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcepFiltro.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnAcepFiltro.ForeColor = System.Drawing.Color.White
        Me.btnAcepFiltro.Location = New System.Drawing.Point(230, 73)
        Me.btnAcepFiltro.Name = "btnAcepFiltro"
        Me.btnAcepFiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnAcepFiltro.TabIndex = 12
        Me.btnAcepFiltro.Text = "Agregar"
        Me.btnAcepFiltro.UseVisualStyleBackColor = False
        '
        'frmfiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(317, 99)
        Me.Controls.Add(Me.btnAcepFiltro)
        Me.Controls.Add(Me.rbtnTelefono)
        Me.Controls.Add(Me.rbtnId)
        Me.Controls.Add(Me.rbtnCliente)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MaximizeBox = False
        Me.Name = "frmfiltro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbtnCliente As RadioButton
    Friend WithEvents rbtnId As RadioButton
    Friend WithEvents rbtnTelefono As RadioButton
    Friend WithEvents btnAcepFiltro As Button
End Class
