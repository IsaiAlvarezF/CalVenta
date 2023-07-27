Public Class FrmAccesoRemotos
    Private Sub FrmAccesoRemotos(sender As Object, e As EventArgs)
        Me.DgvConsultar.ClearSelection()
        Me.Show()
        ' Habilitar el reconocimiento de la tecla Enter
        Me.AcceptButton = BtnInsertar



    End Sub
    Private Sub Agregar()
        Try
            Dim lu As New LAccesos()
            lu.InsertarAcceso(TxtUsuario.Text, TxtAnydesk.Text, TxtRustDesk.Text, TxtPassAny.Text, TxtPassRust.Text)
            Me.TxtUsuario.Text = Nothing
            Me.TxtAnydesk.Text = Nothing
            Me.TxtRustDesk.Text = Nothing
            Me.TxtPassAny.Text = Nothing
            Me.TxtPassRust.Text = Nothing
            Me.TxtUsuario.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Eliminar()
        Try
            Dim selected As DataGridViewSelectedRowCollection = DgvConsultar.SelectedRows
            Dim la As New LAccesos()
            Dim acceso As New DAccesoRemotos

            If selected.Count > 0 Then
                For i As Integer = 0 To selected.Count - 1
                    la.EliminarAcceso(selected.Item(i).Cells.Item(0).Value)
                Next
                MsgBox("Los usuarios se han eliminado correctamente")
                acceso.consulta(TextConsultar.Text, DgvConsultar)
            Else
                MsgBox("No hay filas seleccionadas")
            End If
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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Eliminar()

    End Sub

    Private Sub FrmAccesoRemotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textoConsulta As String = TextConsultar.Text.Trim()

        Try
            Dim lu As New LAccesos
            Dim dt As DataTable = lu.consultarAcceso

            DgvConsultar.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextConsultar.TextChanged
        Dim objeto As New DAccesoRemotos

        objeto.consulta(TextConsultar.Text, DgvConsultar)
    End Sub

    Private Sub IconBuscar_Click(sender As Object, e As EventArgs) Handles IconBuscar.Click
        TextConsultar.Text = ""

        Dim objeto As New DAccesoRemotos

        objeto.consulta(TextConsultar.Text, DgvConsultar)

    End Sub

End Class