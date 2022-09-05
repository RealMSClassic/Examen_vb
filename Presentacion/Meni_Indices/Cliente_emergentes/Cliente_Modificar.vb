Imports Intermedio
Imports Datos
Public Class Cliente_Modificar
    Dim nombre As String
    Dim telefono As String
    Dim correo As String
    Dim Qclientes As Query_Clientes = New Query_Clientes
    Dim negocio As negocioCliente = New negocioCliente

    Private Function Verificar(ByVal nombre3 As String, ByVal telefono3 As String, ByVal correo3 As String) As Boolean
        Dim llave As Boolean
        If Not nombre = nombre3 Then
            llave = True
        ElseIf Not telefono = telefono3 Then
            llave = True
        ElseIf Not correo = correo3 Then
            llave = True

        Else
            llave = False
        End If
        Return llave
    End Function
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If txtID.Text = "" Then


        Else
            Dim id2 As Integer = CInt(txtID.Text)
            Dim nombre2 As String = txtNombre.Text
        Dim telefono2 As String = txtTelefono.Text
            Dim correo2 As String = txtCorreo.Text
            If Verificar(nombre2, telefono2, correo2) = True Then
                Dim r As Byte
                r = MsgBox("Esta Seguro actualizar", MsgBoxStyle.YesNo, "Actualizar datos")
                If r = vbYes Then
                    Dim entidad As Entidad.entidadClientes = New Entidad.entidadClientes
                    entidad.Id = id2
                    entidad.Nombre = nombre2
                    entidad.Correo = correo2
                    entidad.Telefono = telefono2

                    negocio.EditarCliente(entidad)
                    Clientes.cargargrilla()

                    Clientes.deshabilitarbtn()

                    Clientes.Enabled = True
                    Me.Close()



                End If

            Else
                MsgBox("Sin Cambios")
                Clientes.Enabled = True
                Me.Close()

                Clientes.deshabilitarbtn()
            End If
        End If










    End Sub

    Private Sub checkid()

        Dim i As Integer = CInt(Clientes.grillClientes.CurrentRow.Index)
        Dim idcheck As String = Clientes.grillClientes.Item(0, i).Value()

        'datosABox(idcheck)

    End Sub

    Private Sub Cliente_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nombre = txtNombre.Text
        telefono = txtTelefono.Text
        correo = txtCorreo.Text
        Clientes.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clientes.Enabled = True
        Me.Close()
        Clientes.deshabilitarbtn()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

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

    Private Sub Cliente_Modificar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Clientes.Enabled = True
    End Sub
End Class