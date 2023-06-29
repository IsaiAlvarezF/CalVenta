<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PrecioConIva = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.TipoCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.Button()
        Me.MontoIngresado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrecioSinIva = New System.Windows.Forms.TextBox()
        Me.LimpiarHistorial = New System.Windows.Forms.Button()
        Me.TabPrincipal = New System.Windows.Forms.TabControl()
        Me.TabCalcular = New System.Windows.Forms.TabPage()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.TabHistorial = New System.Windows.Forms.TabPage()
        Me.ListHistorial = New System.Windows.Forms.ListBox()
        Me.ListLeyendaHistorial = New System.Windows.Forms.ListBox()
        Me.TabPrincipal.SuspendLayout()
        Me.TabCalcular.SuspendLayout()
        Me.TabHistorial.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrecioConIva
        '
        Me.PrecioConIva.Location = New System.Drawing.Point(108, 126)
        Me.PrecioConIva.Name = "PrecioConIva"
        Me.PrecioConIva.ReadOnly = True
        Me.PrecioConIva.Size = New System.Drawing.Size(173, 23)
        Me.PrecioConIva.TabIndex = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CALCULADORA DE VENTA"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(302, 15)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 4
        Me.Calcular.Text = "Calcular "
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(302, 44)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 5
        Me.Limpiar.Text = "Limpiar "
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'TipoCliente
        '
        Me.TipoCliente.DisplayMember = "Empleado,Cliente"
        Me.TipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoCliente.FormattingEnabled = True
        Me.TipoCliente.Items.AddRange(New Object() {"Empleado", "Cliente"})
        Me.TipoCliente.Location = New System.Drawing.Point(108, 12)
        Me.TipoCliente.Name = "TipoCliente"
        Me.TipoCliente.Size = New System.Drawing.Size(173, 23)
        Me.TipoCliente.TabIndex = 1
        Me.TipoCliente.ValueMember = "0,1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tipo de cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Ingrese monto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Precio total:"
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(302, 73)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 6
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'MontoIngresado
        '
        Me.MontoIngresado.Location = New System.Drawing.Point(108, 41)
        Me.MontoIngresado.MaxLength = 100
        Me.MontoIngresado.Name = "MontoIngresado"
        Me.MontoIngresado.Size = New System.Drawing.Size(173, 23)
        Me.MontoIngresado.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Precio sin IVA:"
        '
        'PrecioSinIva
        '
        Me.PrecioSinIva.Location = New System.Drawing.Point(108, 94)
        Me.PrecioSinIva.Name = "PrecioSinIva"
        Me.PrecioSinIva.ReadOnly = True
        Me.PrecioSinIva.Size = New System.Drawing.Size(173, 23)
        Me.PrecioSinIva.TabIndex = 100
        '
        'LimpiarHistorial
        '
        Me.LimpiarHistorial.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LimpiarHistorial.Location = New System.Drawing.Point(423, 6)
        Me.LimpiarHistorial.Name = "LimpiarHistorial"
        Me.LimpiarHistorial.Size = New System.Drawing.Size(98, 23)
        Me.LimpiarHistorial.TabIndex = 19
        Me.LimpiarHistorial.Text = "Limpiar Historial"
        Me.LimpiarHistorial.UseVisualStyleBackColor = True
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Controls.Add(Me.TabCalcular)
        Me.TabPrincipal.Controls.Add(Me.TabHistorial)
        Me.TabPrincipal.Location = New System.Drawing.Point(0, 27)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.Padding = New System.Drawing.Point(0, 0)
        Me.TabPrincipal.SelectedIndex = 0
        Me.TabPrincipal.Size = New System.Drawing.Size(535, 194)
        Me.TabPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabPrincipal.TabIndex = 21
        '
        'TabCalcular
        '
        Me.TabCalcular.Controls.Add(Me.NombreTxt)
        Me.TabCalcular.Controls.Add(Me.Nombre)
        Me.TabCalcular.Controls.Add(Me.TipoCliente)
        Me.TabCalcular.Controls.Add(Me.Label2)
        Me.TabCalcular.Controls.Add(Me.Label5)
        Me.TabCalcular.Controls.Add(Me.Calcular)
        Me.TabCalcular.Controls.Add(Me.Limpiar)
        Me.TabCalcular.Controls.Add(Me.PrecioConIva)
        Me.TabCalcular.Controls.Add(Me.PrecioSinIva)
        Me.TabCalcular.Controls.Add(Me.Label4)
        Me.TabCalcular.Controls.Add(Me.Salir)
        Me.TabCalcular.Controls.Add(Me.MontoIngresado)
        Me.TabCalcular.Controls.Add(Me.Label3)
        Me.TabCalcular.Location = New System.Drawing.Point(4, 24)
        Me.TabCalcular.Name = "TabCalcular"
        Me.TabCalcular.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCalcular.Size = New System.Drawing.Size(527, 166)
        Me.TabCalcular.TabIndex = 0
        Me.TabCalcular.Text = "Calcular"
        Me.TabCalcular.UseVisualStyleBackColor = True
        '
        'NombreTxt
        '
        Me.NombreTxt.Location = New System.Drawing.Point(108, 69)
        Me.NombreTxt.MaxLength = 100
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(173, 23)
        Me.NombreTxt.TabIndex = 3
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(6, 69)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(54, 15)
        Me.Nombre.TabIndex = 14
        Me.Nombre.Text = "Nombre:"
        '
        'TabHistorial
        '
        Me.TabHistorial.Controls.Add(Me.ListHistorial)
        Me.TabHistorial.Controls.Add(Me.ListLeyendaHistorial)
        Me.TabHistorial.Controls.Add(Me.LimpiarHistorial)
        Me.TabHistorial.Location = New System.Drawing.Point(4, 24)
        Me.TabHistorial.Name = "TabHistorial"
        Me.TabHistorial.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHistorial.Size = New System.Drawing.Size(527, 166)
        Me.TabHistorial.TabIndex = 1
        Me.TabHistorial.Text = "Historial"
        Me.TabHistorial.UseVisualStyleBackColor = True
        '
        'ListHistorial
        '
        Me.ListHistorial.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListHistorial.FormattingEnabled = True
        Me.ListHistorial.HorizontalScrollbar = True
        Me.ListHistorial.Location = New System.Drawing.Point(3, 6)
        Me.ListHistorial.Name = "ListHistorial"
        Me.ListHistorial.ScrollAlwaysVisible = True
        Me.ListHistorial.Size = New System.Drawing.Size(412, 134)
        Me.ListHistorial.TabIndex = 22
        '
        'ListLeyendaHistorial
        '
        Me.ListLeyendaHistorial.BackColor = System.Drawing.Color.White
        Me.ListLeyendaHistorial.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListLeyendaHistorial.FormattingEnabled = True
        Me.ListLeyendaHistorial.ItemHeight = 12
        Me.ListLeyendaHistorial.Location = New System.Drawing.Point(421, 35)
        Me.ListLeyendaHistorial.Name = "ListLeyendaHistorial"
        Me.ListLeyendaHistorial.Size = New System.Drawing.Size(100, 88)
        Me.ListLeyendaHistorial.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(547, 227)
        Me.Controls.Add(Me.TabPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cal "
        Me.TabPrincipal.ResumeLayout(False)
        Me.TabCalcular.ResumeLayout(False)
        Me.TabCalcular.PerformLayout()
        Me.TabHistorial.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrecioConIva As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents TipoCliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Salir As Button
    Friend WithEvents MontoIngresado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PrecioSinIva As TextBox
    Friend WithEvents LimpiarHistorial As Button
    Friend WithEvents TabPrincipal As TabControl
    Friend WithEvents TabCalcular As TabPage
    Friend WithEvents TabHistorial As TabPage
    Friend WithEvents ListLeyendaHistorial As ListBox
    Friend WithEvents ListHistorial As ListBox
    Friend WithEvents NombreTxt As TextBox
    Friend WithEvents Nombre As Label
End Class
