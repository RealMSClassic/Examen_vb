Imports Intermedio
Imports Datos
Public Class Clientes
    Public llave As String = "Cliente"



    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim a As Query_Clientes = New Query_Clientes
        grillClientes.DataSource = a.Mostrar
    End Sub
    Public Sub cargargrillaBusqueda2(ByVal bus As String, ByVal tipo As String)
        Dim a As Query_Clientes = New Query_Clientes
        grillClientes.DataSource = a.Buscar(bus, tipo)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Clientes_Nuevo.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Cliente_Modificar.txtID.Text = "" Then
        Else
            Cliente_Modificar.Show()
        End If

    End Sub

    Private Sub grillClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillClientes.CellClick
        habilitarbtn()

        If verificarLista() = True Then
            Dim asa As negocioCliente = New negocioCliente
            Cliente_Modificar.txtID.Text = asa.BackModificar(checkid2).Id
            Cliente_Modificar.txtNombre.Text = asa.BackModificar(checkid2).Nombre
            Cliente_Modificar.txtTelefono.Text = asa.BackModificar(checkid2).Telefono
            Cliente_Modificar.txtCorreo.Text = asa.BackModificar(checkid2).Correo

        End If
        If Cliente_Modificar.txtID.Text = "" Then
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
    Private Function checkid2() As Integer

        Dim i As Integer = CInt(grillClientes.CurrentRow.Index)
        Dim idcheck As String = grillClientes.Item(0, i).Value()

        Dim IdShear As Integer = CInt(idcheck)

        Return IdShear
    End Function

    Private Sub grillClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        Dim asa As negocioCliente = New negocioCliente
        Cliente_Modificar.txtID.Text = asa.BackModificar(checkid2).Id
        Cliente_Modificar.txtNombre.Text = asa.BackModificar(checkid2).Nombre
        Cliente_Modificar.txtTelefono.Text = asa.BackModificar(checkid2).Telefono
        Cliente_Modificar.txtCorreo.Text = asa.BackModificar(checkid2).Correo

    End Sub

    Private Sub grillClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim asa As negocioCliente = New negocioCliente
        Cliente_Modificar.txtID.Text = asa.BackModificar(checkid2).Id
        Cliente_Modificar.txtNombre.Text = asa.BackModificar(checkid2).Nombre
        Cliente_Modificar.txtTelefono.Text = asa.BackModificar(checkid2).Telefono
        Cliente_Modificar.txtCorreo.Text = asa.BackModificar(checkid2).Correo

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim eliminar As negocioCliente = New negocioCliente

        Dim r As Byte
        r = MsgBox("Esta Seguro en Eliminar Cliente?", MsgBoxStyle.YesNo, "Actualizar datos")
        If r = vbYes Then

            eliminar.elimnar(checkid2)
            cargargrilla()
        End If

    End Sub
    Private Function filtroCheck(ByVal a As Integer) As String
        Dim llave As String = ""
        If a = 1 Then
            llave = "Cliente"
        ElseIf a = 2 Then
            llave = "ID"

        ElseIf a = 3 Then
            llave = "Telefono"

        End If

        Return llave
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        If txtBuscarCliente.Text = "" Then
            cargargrilla()
        Else

            cargargrillaBusqueda2(txtBuscarCliente.Text.ToString, llave)

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles brnFiltro.Click
        frmfiltro.Show()
    End Sub




End Class