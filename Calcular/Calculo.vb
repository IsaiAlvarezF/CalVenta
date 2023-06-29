Option Explicit On
Imports System.IO

Public Class Form1
    Public Const HistorialPath As String = "C:\Users\Son Isai\source\repos\IsaiAlvarezF\CalVenta\Historial.txt"
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

        If NombreTxt.Text.Length = 0 Then
            MessageBox.Show("NO SE INGRESO NOMBRE ")
        End If
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
        Me.NombreTxt.Text = Nothing
        TipoCliente.SelectedItem = "Empleado"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Private Sub LlenarHistorial()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialDia", "Actualizado: " & Date.Now.Date.ToString, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialHora", "A las: " & DateTime.Now.TimeOfDay.ToString, Microsoft.Win32.RegistryValueKind.String)

        If Dir(HistorialPath) = "" Then
            Exit Sub
        End If

        Dim registro As String
        registro = "|Nombre Cliente: " & NombreTxt.Text & " |Monto ingresado: " & FormatCurrency(MontoIngresado.Text) & "| Total sin IVA: " & PrecioSinIva.Text & "| Total con IVA: " & PrecioConIva.Text

        Using writer As New StreamWriter(HistorialPath, True)
            writer.WriteLine(registro)
        End Using

        ObtenerHistorial()
    End Sub
    Private Sub ObtenerHistorial()
        Me.ListLeyendaHistorial.Items.Clear()
        Me.ListLeyendaHistorial.Items.Add(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialDia", Nothing))
        Me.ListLeyendaHistorial.Items.Add(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialHora", Nothing))

        Me.ListHistorial.Items.Clear()

        If Dir(HistorialPath) = "" Then
            Exit Sub
        End If

        Dim strLine As String
        FileOpen(FileNumber:=1, FileName:=HistorialPath, Mode:=OpenMode.Input)
        Do While Not EOF(1)
            strLine = LineInput(1)
            ListHistorial.Items.Add(strLine)
        Loop
        FileClose(1)

        ReordenarHistorial()

        MontoIngresado.Focus()
    End Sub
    Private Sub LimpiarHistorial_Click(sender As Object, e As EventArgs) Handles LimpiarHistorial.Click
        If MessageBox.Show(Me, "¿Desea borrar el historial?", "Limpiar Historial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            System.IO.File.WriteAllText(HistorialPath, "")

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialDia", "Historial vacío...", Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\HistorialCalculadora", "LeyendaHistorialHora", "", Microsoft.Win32.RegistryValueKind.String)
            ObtenerHistorial()
        End If
    End Sub
    Private Sub ReordenarHistorial()
        If ListHistorial.Items.Count > 0 Then
            Dim i As Integer, j As Integer, row As String
            Dim temporal As New ListBox
            Do
                i = ListHistorial.Items.Count - 1
                row = ListHistorial.Items(i)
                temporal.Items.Add(row)
                ListHistorial.Items.RemoveAt(i)
            Loop Until i = 0
            For j = 0 To temporal.Items.Count - 1
                row = temporal.Items(j)
                ListHistorial.Items.Add(row)
            Next
            temporal.Items.Clear()
        End If
    End Sub

    Private Sub TabCalcular_Click(sender As Object, e As EventArgs) Handles TabCalcular.Click

    End Sub

    Private Sub NombreTxt_TextChanged(sender As Object, e As EventArgs) Handles NombreTxt.TextChanged
        If NombreTxt.Text.Length = 0 Then
            MessageBox.Show("Por favor, completa el campo.")
        End If
    End Sub


End Class