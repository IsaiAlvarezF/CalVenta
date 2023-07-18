Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Conexion

    Protected conexion As New SqlConnection("Data Source=SOPORT-IT;Initial Catalog=SoporteIt;Integrated Security=True")

    Public Function conectar() As Boolean

        Try
            conexion.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Public Sub desconectar()

        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
