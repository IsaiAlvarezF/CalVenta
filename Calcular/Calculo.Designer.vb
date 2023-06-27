<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PrecioConIva = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.TipoCliente = New System.Windows.Forms.ComboBox()
        Me.ApplyHighDpiModeEventArgsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.Button()
        Me.MontoIngresado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrecioSinIva = New System.Windows.Forms.TextBox()
        Me.Historial1 = New System.Windows.Forms.TextBox()
        Me.Historial2 = New System.Windows.Forms.TextBox()
        Me.Historial3 = New System.Windows.Forms.TextBox()
        Me.Historial4 = New System.Windows.Forms.TextBox()
        Me.Historial5 = New System.Windows.Forms.TextBox()
        Me.LimpiarHistorial = New System.Windows.Forms.Button()
        Me.LeyendaHistorial = New System.Windows.Forms.TextBox()
        Me.ListaHistorial = New System.Windows.Forms.ListBox()
        CType(Me.ApplyHighDpiModeEventArgsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrecioConIva
        '
        Me.PrecioConIva.Location = New System.Drawing.Point(127, 155)
        Me.PrecioConIva.Name = "PrecioConIva"
        Me.PrecioConIva.ReadOnly = True
        Me.PrecioConIva.Size = New System.Drawing.Size(173, 23)
        Me.PrecioConIva.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CALCULADORA DE VENTA"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(65, 207)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 3
        Me.Calcular.Text = "Calcular "
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(146, 207)
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
        Me.TipoCliente.Location = New System.Drawing.Point(127, 68)
        Me.TipoCliente.Name = "TipoCliente"
        Me.TipoCliente.Size = New System.Drawing.Size(121, 23)
        Me.TipoCliente.TabIndex = 1
        Me.TipoCliente.ValueMember = "0,1"
        '
        'ApplyHighDpiModeEventArgsBindingSource
        '
        Me.ApplyHighDpiModeEventArgsBindingSource.DataSource = GetType(Calcular.My.ApplyHighDpiModeEventArgs)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tipo de cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Ingrese monto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Precio total:"
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(227, 207)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 6
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'MontoIngresado
        '
        Me.MontoIngresado.Location = New System.Drawing.Point(127, 97)
        Me.MontoIngresado.MaxLength = 100
        Me.MontoIngresado.Name = "MontoIngresado"
        Me.MontoIngresado.Size = New System.Drawing.Size(173, 23)
        Me.MontoIngresado.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Precio sin IVA:"
        '
        'PrecioSinIva
        '
        Me.PrecioSinIva.Location = New System.Drawing.Point(127, 126)
        Me.PrecioSinIva.Name = "PrecioSinIva"
        Me.PrecioSinIva.ReadOnly = True
        Me.PrecioSinIva.Size = New System.Drawing.Size(173, 23)
        Me.PrecioSinIva.TabIndex = 13
        '
        'Historial1
        '
        Me.Historial1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Historial1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Historial1.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Historial1.Location = New System.Drawing.Point(845, 31)
        Me.Historial1.Name = "Historial1"
        Me.Historial1.ReadOnly = True
        Me.Historial1.Size = New System.Drawing.Size(345, 14)
        Me.Historial1.TabIndex = 14
        Me.Historial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Historial2
        '
        Me.Historial2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Historial2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Historial2.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Historial2.Location = New System.Drawing.Point(845, 60)
        Me.Historial2.Name = "Historial2"
        Me.Historial2.ReadOnly = True
        Me.Historial2.Size = New System.Drawing.Size(345, 14)
        Me.Historial2.TabIndex = 15
        Me.Historial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Historial3
        '
        Me.Historial3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Historial3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Historial3.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Historial3.Location = New System.Drawing.Point(845, 89)
        Me.Historial3.Name = "Historial3"
        Me.Historial3.ReadOnly = True
        Me.Historial3.Size = New System.Drawing.Size(345, 14)
        Me.Historial3.TabIndex = 16
        Me.Historial3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Historial4
        '
        Me.Historial4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Historial4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Historial4.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Historial4.Location = New System.Drawing.Point(845, 118)
        Me.Historial4.Name = "Historial4"
        Me.Historial4.ReadOnly = True
        Me.Historial4.Size = New System.Drawing.Size(345, 14)
        Me.Historial4.TabIndex = 17
        Me.Historial4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Historial5
        '
        Me.Historial5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Historial5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Historial5.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Historial5.Location = New System.Drawing.Point(845, 147)
        Me.Historial5.Name = "Historial5"
        Me.Historial5.ReadOnly = True
        Me.Historial5.Size = New System.Drawing.Size(345, 14)
        Me.Historial5.TabIndex = 18
        Me.Historial5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LimpiarHistorial
        '
        Me.LimpiarHistorial.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LimpiarHistorial.Location = New System.Drawing.Point(272, 392)
        Me.LimpiarHistorial.Name = "LimpiarHistorial"
        Me.LimpiarHistorial.Size = New System.Drawing.Size(85, 23)
        Me.LimpiarHistorial.TabIndex = 19
        Me.LimpiarHistorial.Text = "Limpiar Historial"
        Me.LimpiarHistorial.UseVisualStyleBackColor = True
        '
        'LeyendaHistorial
        '
        Me.LeyendaHistorial.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LeyendaHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LeyendaHistorial.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LeyendaHistorial.Location = New System.Drawing.Point(25, 397)
        Me.LeyendaHistorial.Name = "LeyendaHistorial"
        Me.LeyendaHistorial.ReadOnly = True
        Me.LeyendaHistorial.Size = New System.Drawing.Size(241, 13)
        Me.LeyendaHistorial.TabIndex = 20
        '
        'ListaHistorial
        '
        Me.ListaHistorial.FormattingEnabled = True
        Me.ListaHistorial.ItemHeight = 15
        Me.ListaHistorial.Location = New System.Drawing.Point(40, 252)
        Me.ListaHistorial.Name = "ListaHistorial"
        Me.ListaHistorial.Size = New System.Drawing.Size(260, 124)
        Me.ListaHistorial.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1260, 427)
        Me.Controls.Add(Me.ListaHistorial)
        Me.Controls.Add(Me.LeyendaHistorial)
        Me.Controls.Add(Me.LimpiarHistorial)
        Me.Controls.Add(Me.Historial5)
        Me.Controls.Add(Me.Historial4)
        Me.Controls.Add(Me.Historial3)
        Me.Controls.Add(Me.Historial2)
        Me.Controls.Add(Me.Historial1)
        Me.Controls.Add(Me.PrecioSinIva)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TipoCliente)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MontoIngresado)
        Me.Controls.Add(Me.PrecioConIva)
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Cal "
        CType(Me.ApplyHighDpiModeEventArgsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ApplyHighDpiModeEventArgsBindingSource As BindingSource
    Friend WithEvents Historial1 As TextBox
    Friend WithEvents Historial2 As TextBox
    Friend WithEvents Historial3 As TextBox
    Friend WithEvents Historial4 As TextBox
    Friend WithEvents Historial5 As TextBox
    Friend WithEvents LimpiarHistorial As Button
    Friend WithEvents LeyendaHistorial As TextBox
    Friend WithEvents ListaHistorial As ListBox
End Class
