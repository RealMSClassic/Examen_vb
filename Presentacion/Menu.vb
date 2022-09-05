Imports Datos
Public Class Menu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMenuClientes_Click(sender As Object, e As EventArgs) Handles btnMenuClientes.Click
        Clientes.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Query_Conexion = New Query_Conexion
        a.probar()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Productos.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ventas.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        ResumenVenta.Show()
    End Sub
End Class
