<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grillVentas = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtBuscarVentas = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dtpIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.brnFecha = New System.Windows.Forms.Button()
        CType(Me.grillVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nueva Venta"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'grillVentas
        '
        Me.grillVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillVentas.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.grillVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grillVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grillVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grillVentas.DefaultCellStyle = DataGridViewCellStyle4
        Me.grillVentas.EnableHeadersVisualStyles = False
        Me.grillVentas.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grillVentas.Location = New System.Drawing.Point(12, 61)
        Me.grillVentas.MultiSelect = False
        Me.grillVentas.Name = "grillVentas"
        Me.grillVentas.ReadOnly = True
        Me.grillVentas.RowHeadersVisible = False
        Me.grillVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillVentas.Size = New System.Drawing.Size(549, 266)
        Me.grillVentas.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(471, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "FILTROS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtBuscarVentas
        '
        Me.txtBuscarVentas.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtBuscarVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscarVentas.Location = New System.Drawing.Point(12, 333)
        Me.txtBuscarVentas.Name = "txtBuscarVentas"
        Me.txtBuscarVentas.Size = New System.Drawing.Size(379, 20)
        Me.txtBuscarVentas.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(455, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'dtpIni
        '
        Me.dtpIni.Location = New System.Drawing.Point(12, 333)
        Me.dtpIni.Name = "dtpIni"
        Me.dtpIni.Size = New System.Drawing.Size(141, 20)
        Me.dtpIni.TabIndex = 7
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(159, 333)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(140, 20)
        Me.dtpEnd.TabIndex = 8
        '
        'brnFecha
        '
        Me.brnFecha.Location = New System.Drawing.Point(316, 333)
        Me.brnFecha.Name = "brnFecha"
        Me.brnFecha.Size = New System.Drawing.Size(64, 20)
        Me.brnFecha.TabIndex = 9
        Me.brnFecha.Text = "Button4"
        Me.brnFecha.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(573, 369)
        Me.Controls.Add(Me.brnFecha)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpIni)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtBuscarVentas)
        Me.Controls.Add(Me.grillVentas)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.grillVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents grillVentas As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents txtBuscarVentas As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents dtpIni As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents brnFecha As Button
End Class
