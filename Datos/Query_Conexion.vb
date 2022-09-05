Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Data.Sql
Imports System.Configuration.ConfigurationManager
Public Class Query_Conexion
    Private cn As SqlConnection
    Private _llave As String = ConfigurationManager.ConnectionStrings("cn").ToString
    Private dt As DataTable

    Public Sub probar()
        cn = New SqlConnection(_llave)
        cn.Open()
        If cn.State = 1 Then
            MsgBox("Coneccion establecida")
        Else
            MsgBox("Error en la Conexion")
        End If

    End Sub
End Class
