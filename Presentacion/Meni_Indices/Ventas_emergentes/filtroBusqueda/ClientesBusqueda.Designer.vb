<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientesBusqueda
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grillClientes = New System.Windows.Forms.DataGridView()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.btnFiltro = New System.Windows.Forms.Button()
        CType(Me.grillClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grillClientes
        '
        Me.grillClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillClientes.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.grillClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grillClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grillClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grillClientes.DefaultCellStyle = DataGridViewCellStyle1
        Me.grillClientes.EnableHeadersVisualStyles = False
        Me.grillClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grillClientes.Location = New System.Drawing.Point(12, 58)
        Me.grillClientes.MultiSelect = False
        Me.grillClientes.Name = "grillClientes"
        Me.grillClientes.ReadOnly = True
        Me.grillClientes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grillClientes.RowHeadersVisible = False
        Me.grillClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillClientes.Size = New System.Drawing.Size(349, 253)
        Me.grillClientes.TabIndex = 0
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscarCliente.Location = New System.Drawing.Point(12, 32)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(233, 20)
        Me.txtBuscarCliente.TabIndex = 5
        '
        'btnFiltro
        '
        Me.btnFiltro.BackColor = System.Drawing.Color.Blue
        Me.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFiltro.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFiltro.Location = New System.Drawing.Point(281, 29)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltro.TabIndex = 6
        Me.btnFiltro.Text = "Filtro"
        Me.btnFiltro.UseVisualStyleBackColor = False
        '
        'ClientesBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(373, 323)
        Me.Controls.Add(Me.btnFiltro)
        Me.Controls.Add(Me.txtBuscarCliente)
        Me.Controls.Add(Me.grillClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "ClientesBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.grillClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grillClientes As DataGridView
    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents btnFiltro As Button
End Class
