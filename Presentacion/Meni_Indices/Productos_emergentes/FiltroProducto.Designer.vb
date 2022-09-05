<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filtroProducto
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
        Me.rbtnpre = New System.Windows.Forms.RadioButton()
        Me.rbtnIdpro = New System.Windows.Forms.RadioButton()
        Me.rbtnProducto = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnAcepFiltro
        '
        Me.btnAcepFiltro.BackColor = System.Drawing.Color.Blue
        Me.btnAcepFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcepFiltro.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnAcepFiltro.ForeColor = System.Drawing.Color.White
        Me.btnAcepFiltro.Location = New System.Drawing.Point(230, 74)
        Me.btnAcepFiltro.Name = "btnAcepFiltro"
        Me.btnAcepFiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnAcepFiltro.TabIndex = 16
        Me.btnAcepFiltro.Text = "Agregar"
        Me.btnAcepFiltro.UseVisualStyleBackColor = False
        '
        'rbtnpre
        '
        Me.rbtnpre.AutoSize = True
        Me.rbtnpre.Location = New System.Drawing.Point(215, 42)
        Me.rbtnpre.Name = "rbtnpre"
        Me.rbtnpre.Size = New System.Drawing.Size(55, 17)
        Me.rbtnpre.TabIndex = 15
        Me.rbtnpre.TabStop = True
        Me.rbtnpre.Text = "Precio"
        Me.rbtnpre.UseVisualStyleBackColor = True
        '
        'rbtnIdpro
        '
        Me.rbtnIdpro.AutoSize = True
        Me.rbtnIdpro.Location = New System.Drawing.Point(119, 42)
        Me.rbtnIdpro.Name = "rbtnIdpro"
        Me.rbtnIdpro.Size = New System.Drawing.Size(36, 17)
        Me.rbtnIdpro.TabIndex = 14
        Me.rbtnIdpro.TabStop = True
        Me.rbtnIdpro.Text = "ID"
        Me.rbtnIdpro.UseVisualStyleBackColor = True
        '
        'rbtnProducto
        '
        Me.rbtnProducto.AutoSize = True
        Me.rbtnProducto.Location = New System.Drawing.Point(26, 42)
        Me.rbtnProducto.Name = "rbtnProducto"
        Me.rbtnProducto.Size = New System.Drawing.Size(68, 17)
        Me.rbtnProducto.TabIndex = 13
        Me.rbtnProducto.TabStop = True
        Me.rbtnProducto.Text = "Producto"
        Me.rbtnProducto.UseVisualStyleBackColor = True
        '
        'filtroProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(317, 99)
        Me.Controls.Add(Me.btnAcepFiltro)
        Me.Controls.Add(Me.rbtnpre)
        Me.Controls.Add(Me.rbtnIdpro)
        Me.Controls.Add(Me.rbtnProducto)
        Me.Name = "filtroProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAcepFiltro As Button
    Friend WithEvents rbtnpre As RadioButton
    Friend WithEvents rbtnIdpro As RadioButton
    Friend WithEvents rbtnProducto As RadioButton
End Class
