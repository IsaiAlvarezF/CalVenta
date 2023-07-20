﻿Public Class FrmAccesoRemotos
    Private Sub FrmAccesoRemotos(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        ' Habilitar el reconocimiento de la tecla Enter
        Me.AcceptButton = BtnInsertar


    End Sub
    Private Sub Agregar()



        Try
            Dim lu As New LAccesos()
            lu.InsertarAcceso(TxtUsuario.Text, TxtAnydesk.Text, TxtRustDesk.Text, TxtPassAny.Text, TxtPassRust.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmAccesoRemotos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Agregar()
            e.Handled = True ' Evitar el "ding" de sonido al presionar Enter
        End If
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Agregar()
        TabPrincipal.SelectedIndex = 0
        TxtUsuario.Text = Nothing
        TxtAnydesk.Text = Nothing
        TxtRustDesk.Text = Nothing
        TxtPassAny.Text = Nothing
        TxtPassRust.Text = Nothing
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        TabPrincipal.SelectedIndex = 1
    End Sub
End Class