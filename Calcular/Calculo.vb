Public Class Form1

    Private Sub Form1(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Habilitar el reconocimiento de la tecla Enter
        Me.AcceptButton = Calcular

        My.Computer.Registry.CurrentUser.CreateSubKey("Historial5")
        My.Computer.Registry.CurrentUser.CreateSubKey("Historial4")
        My.Computer.Registry.CurrentUser.CreateSubKey("Historial3")
        My.Computer.Registry.CurrentUser.CreateSubKey("Historial2")
        My.Computer.Registry.CurrentUser.CreateSubKey("Historial1")
        My.Computer.Registry.CurrentUser.CreateSubKey("LeyendaHistorial")

        ObtenerHistorial()

        TipoCliente.SelectedItem = "Empleado"
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
                MontoIngresado.Select(0, 100)
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
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Historial5", "Historial5Value", Me.Historial4.Text, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Historial4", "Historial4Value", Me.Historial3.Text, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Historial3", "Historial3Value", Me.Historial2.Text, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Historial2", "Historial2Value", Me.Historial1.Text, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Historial1", "Historial1Value",
                                      "Monto ingresado: " & FormatCurrency(Me.MontoIngresado.Text) & "; Precio total: " & Me.PrecioConIva.Text & "; Precio sin IVA: " & Me.PrecioSinIva.Text, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\LeyendaHistorial", "LeyendaHistorialValue", "Actualizado: " & DateTime.Now.ToString, Microsoft.Win32.RegistryValueKind.String)

        ObtenerHistorial()

    End Sub

    Private Sub ObtenerHistorial()
        Me.Historial5.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Historial5", "Historial5Value", Nothing)
        Me.Historial4.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Historial4", "Historial4Value", Nothing)
        Me.Historial3.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Historial3", "Historial3Value", Nothing)
        Me.Historial2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Historial2", "Historial2Value", Nothing)
        Me.Historial1.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Historial1", "Historial1Value", Nothing)
        Me.LeyendaHistorial.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\LeyendaHistorial", "LeyendaHistorialValue", Nothing)
    End Sub

    Private Sub LimpiarHistorial_Click(sender As Object, e As EventArgs) Handles LimpiarHistorial.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Historial5", "Historial5Value", "", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Historial4", "Historial4Value", "", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Historial3", "Historial3Value", "", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Historial2", "Historial2Value", "", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Historial1", "Historial1Value", "", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\LeyendaHistorial", "LeyendaHistorialValue", "Historial vacío...", Microsoft.Win32.RegistryValueKind.String)
        ObtenerHistorial()
    End Sub

End Class