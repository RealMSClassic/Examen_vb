Imports Datos
Imports Intermedio
Public Class Ventas
    Public llave As String = "ID"
    Dim consulta As negociosVenta = New negociosVenta
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrilla()
        filtroVentas.mostrar()
    End Sub
    Public Sub cargargrilla()

        grillVentas.DataSource = consulta.cargar_ventas
        grillVentas.Columns("ID").Visible = False
        grillVentas.Columns("IDCliente").Visible = False


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Agregar_Venta.Show()
    End Sub

    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarVentas.TextChanged
        If txtBuscarVentas.Text = "" Then
            cargargrilla()
        Else


            Dim k As New DataView(consulta.cargar_ventas)
            k.RowFilter = String.Format("Cliente like '%{0}%'", txtBuscarVentas.Text)
            grillVentas.DataSource = k
            grillVentas.Columns("ID").Visible = False
            grillVentas.Columns("IDCliente").Visible = False
        End If
    End Sub
    Public Sub cargargrillaBusqueda2(ByVal bus As String, ByVal tipo As String)
        Dim a As Query_Venta = New Query_Venta
        grillVentas.DataSource = a.BuscarFil(bus, tipo)
        grillVentas.Columns("ID").Visible = False
        grillVentas.Columns("IDCliente").Visible = False
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

    Private Sub brnFecha_Click(sender As Object, e As EventArgs) Handles brnFecha.Click
        grillVentas.DataSource = consulta.MostrarVentasFecha(dtpIni.Value.ToString, dtpEnd.Value.ToString)
    End Sub
End Class