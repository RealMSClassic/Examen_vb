Imports Intermedio
Imports Datos
Public Class Productos
    Public llave As String = "Nombre"
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrilla()
        deshabilitarbtn()
    End Sub
    Public Sub habilitarbtn()

        btnEditar.Enabled = True
        btnEliminar.Enabled = True
    End Sub
    Public Sub deshabilitarbtn()

        btnEditar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Public Sub cargargrilla()
        Dim a As Query_Producto = New Query_Producto
        grillClientes.DataSource = a.Mostrar
    End Sub
    Public Sub cargargrillaBusqueda(ByVal bus As String)
        Dim a As Query_Producto = New Query_Producto
        grillClientes.DataSource = a.Buscar(bus)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Producto_Nuevo.Show()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Producto_Modificar.txtID.Text = "" Then
            deshabilitarbtn()
        Else
            Producto_Modificar.Show()
            Dim asa As negocioProducto = New negocioProducto
            asa.BackModificar(1)
        End If

    End Sub

    Private Sub grillClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillClientes.CellClick
        habilitarbtn()
        If verificarLista() = True Then

            Dim asa As negocioProducto = New negocioProducto
            Producto_Modificar.txtID.Text = asa.BackModificar(checkid).Id
            Producto_Modificar.txtNombre.Text = asa.BackModificar(checkid).Nombre
            Producto_Modificar.txtTelefono.Text = asa.BackModificar(checkid).Precio.ToString
            Producto_Modificar.txtCorreo.Text = asa.BackModificar(checkid).Categoria
        End If
        If Producto_Modificar.txtID.Text = "" Then
            deshabilitarbtn()
        End If

    End Sub
    Private Function verificarLista() As Boolean
        Dim i3 As Integer = CInt(grillClientes.CurrentRow.Index)
        Dim id As String = grillClientes.Item(0, i3).Value.ToString
        Dim llave As Boolean = False

        If Not id = "" Then
            llave = True
        End If


        Return llave

    End Function
    Private Function checkid() As Integer

        Dim i As Integer = CInt(grillClientes.CurrentRow.Index)
        Dim idcheck As String = grillClientes.Item(0, i).Value()

        Dim IdShear As Integer = CInt(idcheck)

        Return IdShear
    End Function

    Private Sub grillClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim asa As negocioProducto = New negocioProducto
        Producto_Modificar.txtID.Text = asa.BackModificar(checkid).Id
        Producto_Modificar.txtNombre.Text = asa.BackModificar(checkid).Nombre
        Producto_Modificar.txtTelefono.Text = asa.BackModificar(checkid).Precio.ToString
        Producto_Modificar.txtCorreo.Text = asa.BackModificar(checkid).Categoria
    End Sub

    Private Sub grillClientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim asa As negocioProducto = New negocioProducto
        Producto_Modificar.txtID.Text = asa.BackModificar(checkid).Id
        Producto_Modificar.txtNombre.Text = asa.BackModificar(checkid).Nombre
        Producto_Modificar.txtTelefono.Text = asa.BackModificar(checkid).Precio.ToString
        Producto_Modificar.txtCorreo.Text = asa.BackModificar(checkid).Categoria
    End Sub




    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged
        If txtBuscarProducto.Text = "" Then
            cargargrilla()
        Else

            cargargrillaBusqueda2(txtBuscarProducto.Text, llave)

        End If
    End Sub

    Public Sub cargargrillaBusqueda2(ByVal bus As String, ByVal tipo As String)
        Dim a As Query_Producto = New Query_Producto
        grillClientes.DataSource = a.BuscarFil(bus, tipo)
    End Sub



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim eliminar As negocioProducto = New negocioProducto

        Dim r As Byte
        r = MsgBox("Esta Seguro en Eliminar Producto?", MsgBoxStyle.YesNo, "Eliminar")
        If r = vbYes Then

            eliminar.elimnar(checkid)
            cargargrilla()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filtroProducto.Show()
    End Sub
End Class