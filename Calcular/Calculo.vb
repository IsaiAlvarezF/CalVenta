Public Class Form1
    Private Sub Form1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        ' Habilitar el reconocimiento de la tecla Enter
        Me.AcceptButton = Calcular
        My.Computer.Registry.CurrentUser.CreateSubKey("HistorialCalculadora")
        ObtenerHistorial()
        MontoIngresado.Select(0, 1)
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
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial5", Me.Historial4.Text, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial4", Me.Historial3.Text, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial3", Me.Historial2.Text, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial2", Me.Historial1.Text, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial1",
                                      "Monto ingresado: " & FormatCurrency(Me.MontoIngresado.Text) & "; Precio total: " & Me.PrecioConIva.Text & "; Precio sin IVA: " & Me.PrecioSinIva.Text, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialDia", "Actualizado: " & DateTime.Now.Date.ToString, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialHora", "A las: " & DateTime.Now.TimeOfDay.ToString, Microsoft.Win32.RegistryValueKind.String)
        ObtenerHistorial()
    End Sub
    Private Sub ObtenerHistorial()
        Me.Historial5.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial5", Nothing)
        Me.Historial4.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial4", Nothing)
        Me.Historial3.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial3", Nothing)
        Me.Historial2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial2", Nothing)
        Me.Historial1.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial1", Nothing)
        Me.ListLeyendaHistorial.Items.Clear()
        Me.ListLeyendaHistorial.Items.Add(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialDia", Nothing))
        Me.ListLeyendaHistorial.Items.Add(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialHora", Nothing))
        MontoIngresado.Focus()
    End Sub
    Private Sub LimpiarHistorial_Click(sender As Object, e As EventArgs) Handles LimpiarHistorial.Click
        If MessageBox.Show(Me, "¿Desea borrar el historial?", "Limpiar Historial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial5", "", Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial4", "", Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial3", "", Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial2", "", Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "Historial1", "", Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialDia", "Historial vacío...", Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialHora", "", Microsoft.Win32.RegistryValueKind.String)
            ObtenerHistorial()
        End If
    End Sub
End Class