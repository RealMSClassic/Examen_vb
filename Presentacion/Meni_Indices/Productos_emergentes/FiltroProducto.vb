Public Class filtroProducto
    Private Sub btnAcepFiltro_Click(sender As Object, e As EventArgs) Handles btnAcepFiltro.Click
        If rbtnProducto.Checked = True Then
            Productos.llave = "Nombre"

        ElseIf rbtnIdpro.Checked = True Then

            Productos.llave = "ID"

        ElseIf rbtnpre.Checked = True Then
            Productos.llave = "Precio"

        End If
        Me.Close()
    End Sub


End Class