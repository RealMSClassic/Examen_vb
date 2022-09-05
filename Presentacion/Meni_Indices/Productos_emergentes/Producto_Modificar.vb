Imports Intermedio
Imports Datos
Public Class Producto_Modificar
    Dim nombre As String
    Dim precio As Decimal
    Dim categoria As String
    Dim Qclientes As Query_Producto = New Query_Producto
    Dim negocio As negocioProducto = New negocioProducto
    Private Sub Producto_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Productos.Enabled = False
        If txtID.Text = "" Then
        Else
            nombre = txtNombre.Text
            precio = CDec(txtTelefono.Text)
            categoria = txtCorreo.Text
        End If


    End Sub

    Private Function Verificar(ByVal nombre3 As String, ByVal precio3 As Decimal, ByVal categoria3 As String) As Boolean
        Dim llave As Boolean
        If Not nombre = nombre3 Then
            llave = True
        ElseIf Not precio = precio3 Then
            llave = True
        ElseIf Not categoria = categoria3 Then
            llave = True

        Else
            llave = False
        End If
        Return llave
    End Function

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If txtID.Text = "" Then
        Else
            Dim id2 As Integer = CInt(txtID.Text)
            Dim nombre2 As String = txtNombre.Text
            Dim precio2 As String = txtTelefono.Text
            Dim categoria2 As String = txtCorreo.Text
            If Verificar(nombre2, precio2, categoria2) = True Then
                Dim r As Byte
                r = MsgBox("Esta Seguro actualizar", MsgBoxStyle.YesNo, "Actualizar datos")
                If r = vbYes Then
                    Dim entidad As Entidad.entidadProducto = New Entidad.entidadProducto
                    entidad.Id = id2
                    entidad.Nombre = nombre2
                    Dim pendi As String = txtTelefono.Text
                    Dim a As String = Replace(pendi, ",", ".")
                    entidad.Precio = a
                    entidad.Categoria = categoria2

                    negocio.EditarProducto(entidad)
                    Productos.cargargrilla()
                    Productos.deshabilitarbtn()




                    Me.Close()
                End If

            Else
                MsgBox("Sin Cambios")
                Productos.deshabilitarbtn()

            End If

        End If


    End Sub
    Private Sub checkid()

        Dim i As Integer = CInt(Clientes.grillClientes.CurrentRow.Index)
        Dim idcheck As String = Clientes.grillClientes.Item(0, i).Value()

        'datosABox(idcheck)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Productos.deshabilitarbtn()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged

    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Producto_Modificar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Productos.Enabled = True
    End Sub
End Class