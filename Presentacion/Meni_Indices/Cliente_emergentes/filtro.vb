Public Class frmfiltro
    Private Sub frmfiltro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtnCliente.Checked = False
        rbtnId.Checked = False
        rbtnTelefono.Checked = False
        Clientes.Enabled = False
    End Sub

    Private Sub btnAcepFiltro_Click(sender As Object, e As EventArgs) Handles btnAcepFiltro.Click
        If rbtnCliente.Checked = True Then
            Clientes.llave = "Cliente"

        ElseIf rbtnId.Checked = True Then

            Clientes.llave = "ID"

        ElseIf rbtnTelefono.Checked = True Then
            Clientes.llave = "Telefono"

        End If
        Clientes.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmfiltro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Clientes.Enabled = True
    End Sub
End Class