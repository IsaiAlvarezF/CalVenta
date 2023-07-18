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

    Public Sub New(Usuario As String, Anydesk As String, RuskDesk As String, pAny As String, pRusk As String)
        NombreUsuario = Usuario
        AccesoAnydesk = Anydesk
        AccesoRuskDesk = RuskDesk
        PassAny = pAny
        PassRust = pRusk
    End Sub

    Public Sub New()

    End Sub

    Public Function InsertarUsuario(du As DAccesoRemotos) As Boolean

    End Function

End Class
