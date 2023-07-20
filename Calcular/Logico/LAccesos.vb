Imports System.Data.SqlClient

Public Class LAccesos
    Public Function InsertarAcceso(Usuario As String, Anydesk As String, RuskDesk As String, pAny As String, pRusk As String)
        Dim da As New DAccesoRemotos(Usuario, Anydesk, RuskDesk, pAny, pRusk)

        If da.InsertarAcceso(da) = True Then
            Return True

        Else
            Return False
        End If
    End Function
End Class
