Public Class filtroBusquedaCliente2
    Private Sub filtroBusquedaCliente2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtnCliente.Checked = False
        rbtnId.Checked = False
        rbtnTelefono.Checked = False
        ClientesBusqueda.Enabled = False
    End Sub

    Private Sub btnAcepFiltro_Click(sender As Object, e As EventArgs) Handles btnAcepFiltro.Click
        If rbtnCliente.Checked = True Then
            ClientesBusqueda.llave = "Cliente"

        ElseIf rbtnId.Checked = True Then

            ClientesBusqueda.llave = "Correo"

        ElseIf rbtnTelefono.Checked = True Then
            ClientesBusqueda.llave = "Telefono"

        End If
        ClientesBusqueda.Enabled = True
        Me.Close()
    End Sub
End Class