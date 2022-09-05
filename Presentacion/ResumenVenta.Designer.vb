<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblIDCompra = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.grillItemVenta = New System.Windows.Forms.DataGridView()
        Me.grillVistaResimen = New System.Windows.Forms.DataGridView()
        Me.grilllclienteID = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblclie = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNVenta = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblVTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.grillItemVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grillVistaResimen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilllclienteID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 4
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(356, 27)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 13)
        Me.lblFecha.TabIndex = 5
        '
        'lblIDCompra
        '
        Me.lblIDCompra.AutoSize = True
        Me.lblIDCompra.Location = New System.Drawing.Point(356, 50)
        Me.lblIDCompra.Name = "lblIDCompra"
        Me.lblIDCompra.Size = New System.Drawing.Size(0, 13)
        Me.lblIDCompra.TabIndex = 6
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(63, 27)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(0, 13)
        Me.lblCliente.TabIndex = 7
        '
        'grillItemVenta
        '
        Me.grillItemVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillItemVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grillItemVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillItemVenta.Location = New System.Drawing.Point(24, 316)
        Me.grillItemVenta.Name = "grillItemVenta"
        Me.grillItemVenta.RowHeadersVisible = False
        Me.grillItemVenta.Size = New System.Drawing.Size(57, 75)
        Me.grillItemVenta.TabIndex = 12
        Me.grillItemVenta.Visible = False
        '
        'grillVistaResimen
        '
        Me.grillVistaResimen.AllowUserToDeleteRows = False
        Me.grillVistaResimen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillVistaResimen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grillVistaResimen.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillVistaResimen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grillVistaResimen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grillVistaResimen.DefaultCellStyle = DataGridViewCellStyle2
        Me.grillVistaResimen.Location = New System.Drawing.Point(10, 98)
        Me.grillVistaResimen.Name = "grillVistaResimen"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillVistaResimen.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grillVistaResimen.RowHeadersVisible = False
        Me.grillVistaResimen.Size = New System.Drawing.Size(449, 307)
        Me.grillVistaResimen.TabIndex = 11
        '
        'grilllclienteID
        '
        Me.grilllclienteID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grilllclienteID.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grilllclienteID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilllclienteID.Location = New System.Drawing.Point(87, 316)
        Me.grilllclienteID.Name = "grilllclienteID"
        Me.grilllclienteID.RowHeadersVisible = False
        Me.grilllclienteID.Size = New System.Drawing.Size(62, 75)
        Me.grilllclienteID.TabIndex = 13
        Me.grilllclienteID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(84, 27)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(39, 13)
        Me.lblID.TabIndex = 15
        Me.lblID.Text = "Label2"
        '
        'lblclie
        '
        Me.lblclie.AutoSize = True
        Me.lblclie.Location = New System.Drawing.Point(84, 60)
        Me.lblclie.Name = "lblclie"
        Me.lblclie.Size = New System.Drawing.Size(39, 13)
        Me.lblclie.TabIndex = 17
        Me.lblclie.Text = "Label3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Cliente"
        '
        'lblNVenta
        '
        Me.lblNVenta.AutoSize = True
        Me.lblNVenta.Location = New System.Drawing.Point(358, 27)
        Me.lblNVenta.Name = "lblNVenta"
        Me.lblNVenta.Size = New System.Drawing.Size(39, 13)
        Me.lblNVenta.TabIndex = 19
        Me.lblNVenta.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(298, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Nº Venta"
        '
        'lblVTotal
        '
        Me.lblVTotal.AutoSize = True
        Me.lblVTotal.Location = New System.Drawing.Point(358, 60)
        Me.lblVTotal.Name = "lblVTotal"
        Me.lblVTotal.Size = New System.Drawing.Size(39, 13)
        Me.lblVTotal.TabIndex = 21
        Me.lblVTotal.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(298, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Total"
        '
        'ResumenVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(471, 439)
        Me.Controls.Add(Me.lblVTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblNVenta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblclie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grillVistaResimen)
        Me.Controls.Add(Me.grilllclienteID)
        Me.Controls.Add(Me.grillItemVenta)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblIDCompra)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label4)
        Me.Name = "ResumenVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen"
        CType(Me.grillItemVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grillVistaResimen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilllclienteID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblIDCompra As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents grillItemVenta As DataGridView
    Friend WithEvents grillVistaResimen As DataGridView
    Friend WithEvents grilllclienteID As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblclie As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNVenta As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblVTotal As Label
    Friend WithEvents Label9 As Label
End Class
