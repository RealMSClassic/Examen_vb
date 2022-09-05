Public Class filtroVentas
    Private Sub btnAcepFiltro_Click(sender As Object, e As EventArgs) Handles btnAcepFiltro.Click
        If rbtFecha.Checked = True Then
            Ventas.cargargrilla()
            Ventas.llave = "Fecha"
            nomostrar()
        ElseIf rbtCliente.Checked = True Then

            Ventas.cargargrilla()
            Ventas.llave = "Cliente"
            mostrar()

        End If
        Me.Close()
    End Sub
    Public Sub mostrar()

        Ventas.txtBuscarVentas.Visible = True
        Ventas.dtpIni.Visible = False
        Ventas.dtpEnd.Visible = False
        Ventas.brnFecha.Visible = False
    End Sub
    Private Sub nomostrar()
        Ventas.txtBuscarVentas.Text = ""
        Ventas.txtBuscarVentas.Visible = False
        Ventas.dtpIni.Visible = True
        Ventas.dtpEnd.Visible = True
        Ventas.brnFecha.Visible = True
    End Sub
End Class