Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TextBox1.Text = Nothing
        Me.TextBox2.Text = Nothing
        Me.TextBox3.Text = Nothing
        Me.TipoCliente.Text = Nothing
    End Sub

    Private Sub Form1(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Habilitar el reconocimiento de la tecla Enter
        Me.AcceptButton = Button1

    End Sub

    Private Sub Calcular()
        Try
            Dim MontoInicial, ValorTotalSinIva, Total As Double
            If TipoCliente.SelectedItem IsNot Nothing Then
                Dim Op As String = TipoCliente.SelectedItem.ToString()
                MontoInicial = Double.Parse(Me.TextBox1.Text)
                If (Op = "Empleado") Then
                    ValorTotalSinIva = MontoInicial / 0.9
                    Total = ValorTotalSinIva * 1.13
                    Me.TextBox3.Text = FormatCurrency(ValorTotalSinIva)
                    Me.TextBox2.Text = FormatCurrency(Total)
                ElseIf (Op = "Cliente") Then
                    ValorTotalSinIva = MontoInicial / 0.8
                    Total = ValorTotalSinIva * 1.13
                    Me.TextBox3.Text = FormatCurrency(ValorTotalSinIva)
                    Me.TextBox2.Text = FormatCurrency(Total)


                End If
            Else
                MessageBox.Show("Por favor, selecciona una opción.")
            End If

        Catch ex As FormatException
            MessageBox.Show("Por favor, ingresa un valor .")

        End Try
    End Sub



    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Calcular()
            e.Handled = True ' Evitar el "ding" de sonido al presionar Enter
        End If
    End Sub




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Calcular()
    End Sub

    'Comentario de prueba Sura
    'Comentario de prueba Isaí

End Class
