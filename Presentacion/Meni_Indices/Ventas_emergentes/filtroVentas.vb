Public Class filtroVentas
    Private Sub btnAcepFiltro_Click(sender As Object, e As EventArgs) Handles btnAcepFiltro.Click
        If rbtnIdCliente.Checked = True Then
            Ventas.llave = "IDCliente"

        ElseIf rbtnidVenta.Checked = True Then

            Ventas.llave = "ID"



        End If
        Me.Close()
    End Sub
End Class