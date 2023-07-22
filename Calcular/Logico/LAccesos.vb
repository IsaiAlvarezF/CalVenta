Public Class LAccesos

    Public Function consultarAcceso() As DataTable

        Try
            Dim dc As New DAccesoRemotos()
            Dim dt As DataTable = dc.ConsultarAcceso

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)

            Return Nothing
        End Try

    End Function




    Public Function InsertarAcceso(Usuario As String, Anydesk As String, RuskDesk As String, pAny As String, pRusk As String)
        Dim da As New DAccesoRemotos(Usuario, Anydesk, RuskDesk, pAny, pRusk)

        If da.InsertarAcceso(da) = True Then
            Return True

        Else
            Return False
        End If
    End Function

    Public Function EliminarAcceso(Id As String)
        Dim de As New DAccesoRemotos(Id)

        If de.EliminarAceso(de) = True Then
            Return True

        Else
            Return False
        End If
    End Function



End Class
