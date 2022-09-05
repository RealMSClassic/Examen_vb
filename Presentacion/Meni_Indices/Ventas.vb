Imports Datos
Imports Intermedio
Public Class Ventas
    Public llave As String = "ID"
    Dim consulta As negociosVenta = New negociosVenta
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrilla()

    End Sub
    Public Sub cargargrilla()

        grillVentas.DataSource = consulta.cargar_ventas


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Agregar_Venta.Show()
    End Sub

    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarVentas.TextChanged
        If txtBuscarVentas.Text = "" Then
            cargargrilla()
        Else

            cargargrillaBusqueda2(txtBuscarVentas.Text, llave)

        End If
    End Sub
    Public Sub cargargrillaBusqueda2(ByVal bus As String, ByVal tipo As String)
        Dim a As Query_Venta = New Query_Venta
        grillVentas.DataSource = a.BuscarFil(bus, tipo)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filtroVentas.Show()
    End Sub

    Private Sub grillVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillVentas.CellDoubleClick
        ResumenVenta.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Query_Venta = New Query_Venta
        a.EliminarListaVentas(checkid)
        cargargrilla()
    End Sub
    Private Function checkid() As Integer
        Dim i As Integer = CInt(grillVentas.CurrentRow.Index)
        Dim idcheck As String = grillVentas.Item(0, i).Value()
        MsgBox(idcheck)
        Return CInt(idcheck)

    End Function
End Class