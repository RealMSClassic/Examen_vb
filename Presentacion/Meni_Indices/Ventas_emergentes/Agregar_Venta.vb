Imports Datos
Imports Intermedio
Public Class Agregar_Venta
    Dim consulta As negociosVenta = New negociosVenta
    Private Sub Agregar_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ventas.Enabled = False

        cargargrilla()
    End Sub

    Public Sub cargargrilla()
        Dim a As Query_Venta = New Query_Venta
        grillVentaProductos.DataSource = a.Mostrar

        grillVentaProductos.Columns("ID").Visible = False




    End Sub

    Private Sub grillVentaProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillVentaProductos.CellClick
        If verificarLista2() = True Then
            checkidVenta()
        End If

    End Sub
    Private Function verificarLista2() As Boolean
        Dim i3 As Integer = CInt(grillVentaProductos.CurrentRow.Index)
        Dim id As String = grillVentaProductos.Item(0, i3).Value.ToString
        Dim llave As Boolean = False

        If Not id = "" Then
            llave = True
        End If


        Return llave

    End Function

    Private Sub checkidVenta()
        Dim i3 As Integer = CInt(grillVentaProductos.CurrentRow.Index)
        datosABoxVenta(i3)
    End Sub
    Private Sub datosABoxVenta(ByVal a As Integer)
        lblNombre.Text = grillVentaProductos.Item(1, a).Value
        lblPrecio.Text = grillVentaProductos.Item(2, a).Value
        lblCategoria.Text = grillVentaProductos.Item(3, a).Value

    End Sub
    Private Sub checkidVenta2()
        Dim i3 As Integer = CInt(grillVentaProductos.CurrentRow.Index)
        AgregarLista(i3)
    End Sub
    Private Sub checkidVenta3()
        Dim i3 As Integer = CInt(grillVentaProductos.CurrentRow.Index)

    End Sub
    Private Sub AgregarLista(ByVal a As Integer)
        Dim id As Integer = grillVentaProductos.Item(0, a).Value
        Dim nombre As String = grillVentaProductos.Item(1, a).Value
        Dim precio As Decimal = CDec(grillVentaProductos.Item(2, a).Value)
        Dim categoria As String = grillVentaProductos.Item(3, a).Value
        Dim cantidad As Integer = txtCantidadVentas.Value


        Dim total As Decimal = cantidad * precio
        grillListaVenta.Rows.Add(id, nombre, precio, cantidad.ToString, total.ToString)
    End Sub
    Private Function verificarLista() As Boolean
        Dim i3 As Integer = CInt(grillVentaProductos.CurrentRow.Index)
        Dim id As Integer = grillVentaProductos.Item(0, i3).Value
        Dim llave As Boolean = False

        For a As Integer = 0 To grillListaVenta.Rows.Count - 1

            If id = grillListaVenta.Rows(a).Cells(0).Value Then
                llave = True
            End If

        Next
        Return llave

    End Function
    Private Sub sumar_lista()
        Dim i3 As Integer = CInt(grillVentaProductos.CurrentRow.Index)
        Dim id As Integer = grillVentaProductos.Item(0, i3).Value


        For a As Integer = 0 To grillListaVenta.Rows.Count - 1

            If id = grillListaVenta.Rows(a).Cells(0).Value Then
                Dim b As Integer = CInt(grillListaVenta.Item(3, a).Value)
                Dim c As Integer = txtCantidadVentas.Value + b
                grillListaVenta.Item(3, a).Value = c.ToString

                Dim pre As Decimal = CDec(grillListaVenta.Item(2, a).Value)
                Dim can As Decimal = CDec(grillListaVenta.Item(3, a).Value)

                grillListaVenta.Item(4, a).Value = (pre * can).ToString

            End If

        Next


    End Sub

    Private Sub btnAgregarLista_Click(sender As Object, e As EventArgs) Handles btnAgregarLista.Click
        Dim a As Integer = CInt(txtCantidadVentas.Value)
        If a >= 1 Then
            If verificarLista() = True Then
                sumar_lista()
            Else
                checkidVenta2()
                Total_Venta()
            End If
        End If
    End Sub

    Private Sub Total_Venta()
        Dim total As Integer
        For a As Integer = 0 To grillListaVenta.Rows.Count - 1

            total += CDec(grillListaVenta.Rows(a).Cells(4).Value)
        Next
        'lblTotal.Text = total.ToString
    End Sub


    Private Sub btnEliminarLista_Click(sender As Object, e As EventArgs) Handles btnEliminarLista.Click
        If grillListaVenta.Rows.Count > 1 Then
            grillListaVenta.Rows.Remove(grillListaVenta.CurrentRow)

        End If

    End Sub

    Private Sub btnModificarLista_Click(sender As Object, e As EventArgs) Handles btnModificarLista.Click
        ''''''
    End Sub

    Private Sub grillListaVenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillListaVenta.CellClick, DataGridView1.CellClick
        If verificarLista3() = True Then
            btnEliminarLista.Enabled = True
            btnModificarLista.Enabled = True
        Else
            btnEliminarLista.Enabled = False
            btnModificarLista.Enabled = False
        End If

    End Sub
    Private Function verificarLista3() As Boolean
        Dim i3 As Integer = CInt(grillListaVenta.CurrentRow.Index)
        Dim id As String = grillListaVenta.Item(0, i3).Value
        Dim llave As Boolean = False

        If Not id = "" Then
            llave = True
        End If


        Return llave

    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnContinuarVenta.Click
        Registrar_Ventas.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarItem.TextChanged


        If txtBuscarItem.Text = "" Then
            cargargrilla()
        Else
            grillVentaProductos.DataSource = consulta.mostrarItemsBusqueda(txtBuscarItem.Text.ToString)
        End If

    End Sub

    Private Sub Agregar_Venta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Ventas.Enabled = True
    End Sub
End Class