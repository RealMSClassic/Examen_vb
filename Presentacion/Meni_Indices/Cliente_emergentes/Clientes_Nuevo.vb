Imports Intermedio
Imports Datos
Public Class Clientes_Nuevo
    Dim Qclientes As Query_Clientes = New Query_Clientes
    Dim negocio As negocioCliente = New negocioCliente
    Private Sub Clientes_Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clientes.Enabled = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim cliente As Entidad.entidadClientes = New Entidad.entidadClientes
            cliente.Telefono = txtTelefono.Text
        cliente.Nombre = txtNombre.Text
        cliente.Correo = txtCorreo.Text
            If negocio.verificar(cliente) = False Then

            Else
                Try
                    negocio.AgregarCliente(cliente)
                    Clientes.grillClientes.DataSource = Qclientes.Mostrar
                    Clientes.Enabled = True
                    Me.Close()

                Catch ex As Exception

                End Try


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clientes.Enabled = True
        Me.Close()
    End Sub

    Private Sub Clientes_Nuevo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Clientes.Enabled = True
    End Sub
End Class