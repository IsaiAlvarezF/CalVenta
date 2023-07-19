Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class DAccesoRemotos
    Inherits Conexion
    Private Id As Integer
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

    Public Sub New()

    End Sub


    Public Property IdUsuario As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
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
    Public Function InsertarAcceso(da As DAccesoRemotos) As Boolean
        Try
            conectar()
            Dim sql As String = "INSERT INTO AccesosRemotos(NombreUsuario,AccesoAnydesk,AccesoRuskDesk, PassAny, PassRust)VALUES('" & da.Nombre_Usuario & "','" &
                                   da.AccesoAnydesk & "','" & da.AccesoRuskDesk & "','" & da.Password_Any & "','" & da.Password_Rust & "' )"
            cmd = New SqlCommand(sql, conexion)
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
            desconectar()

        End Try
    End Function

End Class
