Imports Intermedio
Imports Datos
Public Class Producto_Nuevo
    Dim Qclientes As Query_Producto = New Query_Producto
    Dim negocio As negocioProducto = New negocioProducto

    Private Sub Producto_Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim producto As Entidad.entidadProducto = New Entidad.entidadProducto
        producto.Nombre = txtNombre.Text

        If txtTelefono.Text = "" Then
            producto.Precio = 0.0
        Else
            Dim pendi As String = txtTelefono.Text
            Dim a As String = Replace(pendi, ",", ".")

            producto.Precio = a
        End If

        producto.Categoria = txtCorreo.Text

        If negocio.verificar(producto) = False Then

        Else
            negocio.AgregarProducto(producto)
            Productos.grillClientes.DataSource = Qclientes.Mostrar
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) 
        MsgBox(txtTelefono.Text)
    End Sub
End Class