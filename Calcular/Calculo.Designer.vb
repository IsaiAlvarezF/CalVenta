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
        PrecioConIva = New TextBox()
        Label1 = New Label()
        Calcular = New Button()
        Limpiar = New Button()
        TipoCliente = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Salir = New Button()
        MontoIngresado = New TextBox()
        Label5 = New Label()
        PrecioSinIva = New TextBox()
        LimpiarHistorial = New Button()
        TabPrincipal = New TabControl()
        TabCalcular = New TabPage()
        TabHistorial = New TabPage()
        ListHistorial = New ListBox()
        ListLeyendaHistorial = New ListBox()
        TabPrincipal.SuspendLayout()
        TabCalcular.SuspendLayout()
        TabHistorial.SuspendLayout()
        SuspendLayout()
        ' 
        ' PrecioConIva
        ' 
        PrecioConIva.Location = New Point(108, 99)
        PrecioConIva.Name = "PrecioConIva"
        PrecioConIva.ReadOnly = True
        PrecioConIva.Size = New Size(173, 23)
        PrecioConIva.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(168, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 15)
        Label1.TabIndex = 3
        Label1.Text = "CALCULADORA DE VENTA"
        ' 
        ' Calcular
        ' 
        Calcular.Location = New Point(302, 15)
        Calcular.Name = "Calcular"
        Calcular.Size = New Size(75, 23)
        Calcular.TabIndex = 3
        Calcular.Text = "Calcular "
        Calcular.UseVisualStyleBackColor = True
        ' 
        ' Limpiar
        ' 
        Limpiar.Location = New Point(302, 44)
        Limpiar.Name = "Limpiar"
        Limpiar.Size = New Size(75, 23)
        Limpiar.TabIndex = 5
        Limpiar.Text = "Limpiar "
        Limpiar.UseVisualStyleBackColor = True
        ' 
        ' TipoCliente
        ' 
        TipoCliente.DisplayMember = "Empleado,Cliente"
        TipoCliente.DropDownStyle = ComboBoxStyle.DropDownList
        TipoCliente.FormattingEnabled = True
        TipoCliente.Items.AddRange(New Object() {"Empleado", "Cliente"})
        TipoCliente.Location = New Point(108, 12)
        TipoCliente.Name = "TipoCliente"
        TipoCliente.Size = New Size(173, 23)
        TipoCliente.TabIndex = 1
        TipoCliente.ValueMember = "0,1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 15)
        Label2.TabIndex = 9
        Label2.Text = "Tipo de cliente:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 15)
        Label3.TabIndex = 10
        Label3.Text = "Ingrese monto:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 11
        Label4.Text = "Precio total:"
        ' 
        ' Salir
        ' 
        Salir.Location = New Point(302, 73)
        Salir.Name = "Salir"
        Salir.Size = New Size(75, 23)
        Salir.TabIndex = 6
        Salir.Text = "Salir"
        Salir.UseVisualStyleBackColor = True
        ' 
        ' MontoIngresado
        ' 
        MontoIngresado.Location = New Point(108, 41)
        MontoIngresado.MaxLength = 100
        MontoIngresado.Name = "MontoIngresado"
        MontoIngresado.Size = New Size(173, 23)
        MontoIngresado.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 15)
        Label5.TabIndex = 12
        Label5.Text = "Precio sin IVA:"
        ' 
        ' PrecioSinIva
        ' 
        PrecioSinIva.Location = New Point(108, 70)
        PrecioSinIva.Name = "PrecioSinIva"
        PrecioSinIva.ReadOnly = True
        PrecioSinIva.Size = New Size(173, 23)
        PrecioSinIva.TabIndex = 13
        ' 
        ' LimpiarHistorial
        ' 
        LimpiarHistorial.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        LimpiarHistorial.Location = New Point(366, 6)
        LimpiarHistorial.Name = "LimpiarHistorial"
        LimpiarHistorial.Size = New Size(98, 23)
        LimpiarHistorial.TabIndex = 19
        LimpiarHistorial.Text = "Limpiar Historial"
        LimpiarHistorial.UseVisualStyleBackColor = True
        ' 
        ' TabPrincipal
        ' 
        TabPrincipal.Controls.Add(TabCalcular)
        TabPrincipal.Controls.Add(TabHistorial)
        TabPrincipal.Location = New Point(0, 27)
        TabPrincipal.Name = "TabPrincipal"
        TabPrincipal.Padding = New Point(0, 0)
        TabPrincipal.SelectedIndex = 0
        TabPrincipal.Size = New Size(482, 179)
        TabPrincipal.SizeMode = TabSizeMode.FillToRight
        TabPrincipal.TabIndex = 21
        ' 
        ' TabCalcular
        ' 
        TabCalcular.Controls.Add(TipoCliente)
        TabCalcular.Controls.Add(Label2)
        TabCalcular.Controls.Add(Label5)
        TabCalcular.Controls.Add(Calcular)
        TabCalcular.Controls.Add(Limpiar)
        TabCalcular.Controls.Add(PrecioConIva)
        TabCalcular.Controls.Add(PrecioSinIva)
        TabCalcular.Controls.Add(Label4)
        TabCalcular.Controls.Add(Salir)
        TabCalcular.Controls.Add(MontoIngresado)
        TabCalcular.Controls.Add(Label3)
        TabCalcular.Location = New Point(4, 24)
        TabCalcular.Name = "TabCalcular"
        TabCalcular.Padding = New Padding(3)
        TabCalcular.Size = New Size(474, 151)
        TabCalcular.TabIndex = 0
        TabCalcular.Text = "Calcular"
        TabCalcular.UseVisualStyleBackColor = True
        ' 
        ' TabHistorial
        ' 
        TabHistorial.Controls.Add(ListHistorial)
        TabHistorial.Controls.Add(ListLeyendaHistorial)
        TabHistorial.Controls.Add(LimpiarHistorial)
        TabHistorial.Location = New Point(4, 24)
        TabHistorial.Name = "TabHistorial"
        TabHistorial.Padding = New Padding(3)
        TabHistorial.Size = New Size(474, 151)
        TabHistorial.TabIndex = 1
        TabHistorial.Text = "Historial"
        TabHistorial.UseVisualStyleBackColor = True
        ' 
        ' ListHistorial
        ' 
        ListHistorial.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        ListHistorial.FormattingEnabled = True
        ListHistorial.Location = New Point(3, 6)
        ListHistorial.Name = "ListHistorial"
        ListHistorial.Size = New Size(357, 134)
        ListHistorial.TabIndex = 22
        ' 
        ' ListLeyendaHistorial
        ' 
        ListLeyendaHistorial.BackColor = Color.White
        ListLeyendaHistorial.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        ListLeyendaHistorial.FormattingEnabled = True
        ListLeyendaHistorial.ItemHeight = 12
        ListLeyendaHistorial.Location = New Point(366, 35)
        ListLeyendaHistorial.Name = "ListLeyendaHistorial"
        ListLeyendaHistorial.Size = New Size(100, 88)
        ListLeyendaHistorial.TabIndex = 21
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(482, 207)
        Controls.Add(TabPrincipal)
        Controls.Add(Label1)
        ForeColor = SystemColors.InactiveCaptionText
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        Text = "Cal "
        TabPrincipal.ResumeLayout(False)
        TabCalcular.ResumeLayout(False)
        TabCalcular.PerformLayout()
        TabHistorial.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
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
End Class
