Imports Datos
Public Class ClientesBusqueda
    Public llave As String = "Cliente"
    Private Sub ClientesBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrilla()
    End Sub
    Private Sub cargargrilla()
        Dim consulta As Query_Clientes = New Query_Clientes
        grillClientes.DataSource = consulta.Mostrar

    End Sub

    Private Sub tctbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        If txtBuscarCliente.Text = "" Then
            cargargrilla()
        Else

            cargargrillaBusqueda2(txtBuscarCliente.Text.ToString, llave)

        End If
    End Sub
    Public Sub cargargrillaBusqueda2(ByVal bus As String, ByVal tipo As String)
        Dim a As Query_Clientes = New Query_Clientes
        grillClientes.DataSource = a.Buscar(bus, tipo)
    End Sub

    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click
        filtroBusquedaCliente2.Show()
    End Sub

    Private Sub grillClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillClientes.CellDoubleClick
        nombrar()
    End Sub
    Private Sub nombrar()

        If grillClientes.Item(1, grillClientes.CurrentRow.Index).Value.ToString = "" Then
        Else
            Registrar_Ventas.lblID.Text = grillClientes.Item(0, grillClientes.CurrentRow.Index).Value()
            Registrar_Ventas.lblCliente.Text = grillClientes.Item(1, grillClientes.CurrentRow.Index).Value()

            Me.Close()
        End If

    End Sub
End Class