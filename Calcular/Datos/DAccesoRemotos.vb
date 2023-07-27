Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class DAccesoRemotos
    Inherits Conexion
    Private IdUsuario As String
    Private NombreUsuario As String
    Private AccesoAnydesk As String
    Private AccesoRuskDesk As String
    Private PassAny As String
    Private PassRust As String
    Private cmd As SqlCommand

    Public Sub New(Usuario As String, Anydesk As String, RuskDesk As String, pAny As String, pRusk As String)
        NombreUsuario = Usuario
        AccesoAnydesk = Anydesk
        AccesoRuskDesk = RuskDesk
        PassAny = pAny
        PassRust = pRusk
    End Sub

    Friend Function consulta() As DataTable
        Throw New NotImplementedException()
    End Function

    Public Sub New(Id As String)
        IdUsuario = Id
    End Sub

    Public Sub New()
    End Sub

    Public Property IdUsuarioP As String
        Get
            Return IdUsuario
        End Get
        Set(value As String)
            IdUsuario = value
        End Set
    End Property
    Public Property Nombre_Usuario As String
        Get
            Return NombreUsuario
        End Get
        Set(value As String)
            NombreUsuario = value
        End Set
    End Property

    Public Property Acceso_Anydesk As String
        Get
            Return AccesoAnydesk
        End Get
        Set(value As String)
            AccesoAnydesk = value
        End Set
    End Property


    Public Property Acceso_RustDesk As String
        Get
            Return AccesoRuskDesk

        End Get
        Set(value As String)
            AccesoRuskDesk = value
        End Set
    End Property

    Public Property Password_Any As String
        Get
            Return PassAny

        End Get
        Set(value As String)
            PassAny = value
        End Set
    End Property


    Public Property Password_Rust As String
        Get
            Return PassRust

        End Get
        Set(value As String)
            PassRust = value
        End Set
    End Property

    Public Function ConsultarAcceso() As DataTable
        Dim con As SqlConnection = Nothing
        Try
            conectar(con)
            cmd = New SqlCommand("SELECT * FROM AccesosRemotos")
            cmd.Connection = con

            If cmd.ExecuteNonQuery Then
                Dim data As New DataTable
                Dim adapt As New SqlDataAdapter(cmd)

                adapt.Fill(data)

                Return data
            Else
                Return Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally

            desconectar(con)
        End Try
    End Function

    Public adaptador As SqlDataAdapter

    Sub consulta(ByVal Nombre_Usuario As String, ByVal DataGrid As DataGridView)
        Dim con As SqlConnection = Nothing
        Dim data As New DataTable

        Try
            conectar(con)
            adaptador = New SqlDataAdapter("SELECT * FROM SoporteIt.dbo.AccesosRemotos WHERE NombreUsuario LIKE '%" & Nombre_Usuario & "%'", con)
            data = New DataTable
            adaptador.Fill(data)
            DataGrid.DataSource = data



        Catch ex As Exception

        Finally

            desconectar(con)
        End Try
    End Sub

    Public Function InsertarAcceso(da As DAccesoRemotos) As Boolean
        Dim con As SqlConnection = Nothing
        Try
            conectar(con)
            Dim sql As String = "INSERT INTO SoporteIt.dbo.AccesosRemotos(NombreUsuario,AccesoAnydesk,AccesoRuskDesk, PassAny, PassRust)VALUES('" & da.Nombre_Usuario & "','" &
                                   da.AccesoAnydesk & "','" & da.AccesoRuskDesk & "','" & da.Password_Any & "','" & da.Password_Rust & "' )"
            cmd = New SqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                MsgBox("El cliente se ha ingresado correctamemte")
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False


        Finally
            desconectar(con)

        End Try
    End Function

    Public Function EliminarAceso(de As DAccesoRemotos) As Boolean
        Dim con As SqlConnection = Nothing
        Try
            conectar(con)
            Dim sql As String = "DEL_USUARIO"
            cmd = New SqlCommand(sql, con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idUsuario", SqlDbType.VarChar)
            cmd.Parameters("@idusuario").Value = IdUsuario
            If cmd.ExecuteScalar = 1 Then
                'MsgBox("El usuario se ha eliminado correctamente")
                Return True
            Else
                MsgBox("El usuario no existe")
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            desconectar(con)

        End Try
    End Function

End Class
