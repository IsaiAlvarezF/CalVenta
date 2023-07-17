<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccesosRemoto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxtAnydesk = New System.Windows.Forms.TextBox()
        Me.TextRustDesk = New System.Windows.Forms.TextBox()
        Me.LblRuskDesk = New System.Windows.Forms.Label()
        Me.LblPasswords = New System.Windows.Forms.Label()
        Me.LblAnydesk = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtPassAny = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TxtPassRust = New System.Windows.Forms.TextBox()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(23, 285)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar "
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(125, 285)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(222, 285)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(298, 311)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Crear nuevo Usuario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(7, 21)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(50, 15)
        Me.LblUsuario.TabIndex = 3
        Me.LblUsuario.Text = "Usuario:"
        '
        'TxtAnydesk
        '
        Me.TxtAnydesk.Location = New System.Drawing.Point(0, 99)
        Me.TxtAnydesk.Name = "TxtAnydesk"
        Me.TxtAnydesk.Size = New System.Drawing.Size(120, 23)
        Me.TxtAnydesk.TabIndex = 6
        '
        'TextRustDesk
        '
        Me.TextRustDesk.Location = New System.Drawing.Point(142, 99)
        Me.TextRustDesk.Name = "TextRustDesk"
        Me.TextRustDesk.Size = New System.Drawing.Size(139, 23)
        Me.TextRustDesk.TabIndex = 7
        '
        'LblRuskDesk
        '
        Me.LblRuskDesk.AutoSize = True
        Me.LblRuskDesk.Location = New System.Drawing.Point(142, 66)
        Me.LblRuskDesk.Name = "LblRuskDesk"
        Me.LblRuskDesk.Size = New System.Drawing.Size(60, 15)
        Me.LblRuskDesk.TabIndex = 5
        Me.LblRuskDesk.Text = "RuskDesk:"
        '
        'LblPasswords
        '
        Me.LblPasswords.AutoSize = True
        Me.LblPasswords.Location = New System.Drawing.Point(90, 160)
        Me.LblPasswords.Name = "LblPasswords"
        Me.LblPasswords.Size = New System.Drawing.Size(75, 15)
        Me.LblPasswords.TabIndex = 10
        Me.LblPasswords.Text = "Contraseñas:"
        '
        'LblAnydesk
        '
        Me.LblAnydesk.AutoSize = True
        Me.LblAnydesk.Location = New System.Drawing.Point(7, 66)
        Me.LblAnydesk.Name = "LblAnydesk"
        Me.LblAnydesk.Size = New System.Drawing.Size(68, 15)
        Me.LblAnydesk.TabIndex = 4
        Me.LblAnydesk.Text = "Id Anydesk:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LblPasswords)
        Me.TabPage2.Controls.Add(Me.LblRuskDesk)
        Me.TabPage2.Controls.Add(Me.TxtPassAny)
        Me.TabPage2.Controls.Add(Me.LblAnydesk)
        Me.TabPage2.Controls.Add(Me.TxtAnydesk)
        Me.TabPage2.Controls.Add(Me.LblUsuario)
        Me.TabPage2.Controls.Add(Me.TextRustDesk)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(298, 311)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Accesos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtPassAny
        '
        Me.TxtPassAny.Location = New System.Drawing.Point(3, 195)
        Me.TxtPassAny.Name = "TxtPassAny"
        Me.TxtPassAny.Size = New System.Drawing.Size(120, 23)
        Me.TxtPassAny.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(306, 339)
        Me.TabControl1.TabIndex = 11
        '
        'TxtPassRust
        '
        Me.TxtPassRust.Location = New System.Drawing.Point(158, 231)
        Me.TxtPassRust.Name = "TxtPassRust"
        Me.TxtPassRust.Size = New System.Drawing.Size(139, 23)
        Me.TxtPassRust.TabIndex = 9
        '
        'AccesosRemoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(330, 363)
        Me.Controls.Add(Me.TxtPassRust)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "AccesosRemoto"
        Me.Text = "AccesosRemoto"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LblUsuario As Label
    Friend WithEvents TxtAnydesk As TextBox
    Friend WithEvents TextRustDesk As TextBox
    Friend WithEvents LblRuskDesk As Label
    Friend WithEvents LblPasswords As Label
    Friend WithEvents LblAnydesk As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtPassAny As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TxtPassRust As TextBox
End Class
