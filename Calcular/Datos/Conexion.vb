Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Conexion
    Private cadenaConexion As String = "Data Source=LAPTOP-CSURA\SOPORTIT;Initial Catalog=SoporteIt;Integrated Security=True"
    'Configurar acceso a base de datos
    Public Function conectar(ByRef con As SqlConnection) As Boolean
        con = New SqlConnection(cadenaConexion)
        'Using con As New SqlConnection("Data Source=LAPTOP-CSURA\SOPORTIT;Initial Catalog=SoporteIt;Integrated Security=True")
        '    con.Open()

        'End Using

        'Try


        'Catch ex As Exception
        'Finally

        'End Try
        Try
            con.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Public Sub desconectar(ByRef con As SqlConnection)

        Try
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Esto es una prueba

End Class
