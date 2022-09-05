<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filtroVentas
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
        Me.rbtnIdCliente = New System.Windows.Forms.RadioButton()
        Me.rbtnidVenta = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnAcepFiltro
        '
        Me.btnAcepFiltro.BackColor = System.Drawing.Color.Blue
        Me.btnAcepFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcepFiltro.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnAcepFiltro.ForeColor = System.Drawing.Color.White
        Me.btnAcepFiltro.Location = New System.Drawing.Point(230, 72)
        Me.btnAcepFiltro.Name = "btnAcepFiltro"
        Me.btnAcepFiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnAcepFiltro.TabIndex = 20
        Me.btnAcepFiltro.Text = "Agregar"
        Me.btnAcepFiltro.UseVisualStyleBackColor = False
        '
        'rbtnIdCliente
        '
        Me.rbtnIdCliente.AutoSize = True
        Me.rbtnIdCliente.Location = New System.Drawing.Point(195, 40)
        Me.rbtnIdCliente.Name = "rbtnIdCliente"
        Me.rbtnIdCliente.Size = New System.Drawing.Size(71, 17)
        Me.rbtnIdCliente.TabIndex = 18
        Me.rbtnIdCliente.TabStop = True
        Me.rbtnIdCliente.Text = "ID Cliente"
        Me.rbtnIdCliente.UseVisualStyleBackColor = True
        '
        'rbtnidVenta
        '
        Me.rbtnidVenta.AutoSize = True
        Me.rbtnidVenta.Location = New System.Drawing.Point(63, 40)
        Me.rbtnidVenta.Name = "rbtnidVenta"
        Me.rbtnidVenta.Size = New System.Drawing.Size(67, 17)
        Me.rbtnidVenta.TabIndex = 17
        Me.rbtnidVenta.TabStop = True
        Me.rbtnidVenta.Text = "ID Venta"
        Me.rbtnidVenta.UseVisualStyleBackColor = True
        '
        'filtroVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(317, 99)
        Me.Controls.Add(Me.btnAcepFiltro)
        Me.Controls.Add(Me.rbtnIdCliente)
        Me.Controls.Add(Me.rbtnidVenta)
        Me.MaximizeBox = False
        Me.Name = "filtroVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAcepFiltro As Button
    Friend WithEvents rbtnIdCliente As RadioButton
    Friend WithEvents rbtnidVenta As RadioButton
End Class
