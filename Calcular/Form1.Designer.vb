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
        TextBox2 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        TipoCliente = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button3 = New Button()
        TextBox1 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(127, 202)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(173, 23)
        TextBox2.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(127, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 15)
        Label1.TabIndex = 3
        Label1.Text = "CALCULADORA DE VENTA"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(69, 253)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Calcular "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(161, 253)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 5
        Button2.Text = "Limpiar "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TipoCliente
        ' 
        TipoCliente.DropDownStyle = ComboBoxStyle.DropDownList
        TipoCliente.FormattingEnabled = True
        TipoCliente.Items.AddRange(New Object() {"Empleado", "Cliente"})
        TipoCliente.Location = New Point(127, 68)
        TipoCliente.Name = "TipoCliente"
        TipoCliente.Size = New Size(121, 23)
        TipoCliente.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 9
        Label2.Text = "Tipo de cliente"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 10
        Label3.Text = "Ingrese monto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 11
        Label4.Text = "Precio total "
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(266, 253)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 6
        Button3.Text = "Salir"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(127, 126)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(173, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 12
        Label5.Text = "Precio sin IVA"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(127, 168)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(173, 23)
        TextBox3.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(369, 315)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TipoCliente)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(TextBox2)
        ForeColor = SystemColors.InactiveCaptionText
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        Text = "Cal "
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TipoCliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
