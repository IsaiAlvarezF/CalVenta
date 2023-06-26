Public Class Form1

    Private Sub Form1(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Habilitar el reconocimiento de la tecla Enter
        Me.AcceptButton = Calcular
        TipoCliente.SelectedItem = "Empleado"
        Me.LeyendaHistorial.Text = "Historial vacío..."
    End Sub

    Private Sub Calculo()
        Try
            Dim MontoInicial, ValorTotalSinIva, Total As Double
            If TipoCliente.SelectedItem IsNot Nothing Then
                Dim Op As String = TipoCliente.SelectedItem.ToString()
                MontoInicial = Double.Parse(Me.MontoIngresado.Text)
                If (Op = "Empleado") Then
                    ValorTotalSinIva = MontoInicial / 0.9
                    Total = ValorTotalSinIva * 1.13
                    Me.PrecioSinIva.Text = FormatCurrency(ValorTotalSinIva)
                    Me.PrecioConIva.Text = FormatCurrency(Total)
                ElseIf (Op = "Cliente") Then
                    ValorTotalSinIva = MontoInicial / 0.8
                    Total = ValorTotalSinIva * 1.13
                    Me.PrecioSinIva.Text = FormatCurrency(ValorTotalSinIva)
                    Me.PrecioConIva.Text = FormatCurrency(Total)
                End If
                LlenarHistorial()
            Else
                MessageBox.Show("Por favor, selecciona una opción.")
            End If
        Catch ex As FormatException
            MessageBox.Show("Por favor, ingresa un valor.")
        End Try
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Calculo()
            e.Handled = True ' Evitar el "ding" de sonido al presionar Enter
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Calculo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Me.MontoIngresado.Text = Nothing
        Me.PrecioConIva.Text = Nothing
        Me.PrecioSinIva.Text = Nothing
        Me.TipoCliente.Text = Nothing
        TipoCliente.SelectedItem = "Empleado"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub LlenarHistorial()
        Me.Historial5.Text = Me.Historial4.Text
        Me.Historial4.Text = Me.Historial3.Text
        Me.Historial3.Text = Me.Historial2.Text
        Me.Historial2.Text = Me.Historial1.Text
        Me.Historial1.Text = "Monto ingresado: " & FormatCurrency(Me.MontoIngresado.Text) & "; Precio total: " & Me.PrecioConIva.Text & "; Precio sin IVA: " & Me.PrecioSinIva.Text
        Me.LeyendaHistorial.Text = Nothing
    End Sub

    Private Sub LimpiarHistorial_Click(sender As Object, e As EventArgs) Handles LimpiarHistorial.Click
        Me.Historial5.Text = Nothing
        Me.Historial4.Text = Nothing
        Me.Historial3.Text = Nothing
        Me.Historial2.Text = Nothing
        Me.Historial1.Text = Nothing
        Me.LeyendaHistorial.Text = "Historial vacío..."
    End Sub

End Class