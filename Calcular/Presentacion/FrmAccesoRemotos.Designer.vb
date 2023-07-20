<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccesoRemotos
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
        Me.TabPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TabAgregar = New System.Windows.Forms.TabPage()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.LblPRust = New System.Windows.Forms.Label()
        Me.LblPAny = New System.Windows.Forms.Label()
        Me.LvlRust = New System.Windows.Forms.Label()
        Me.LblAny = New System.Windows.Forms.Label()
        Me.TxtPassRust = New System.Windows.Forms.TextBox()
        Me.TxtPassAny = New System.Windows.Forms.TextBox()
        Me.TxtRustDesk = New System.Windows.Forms.TextBox()
        Me.TxtAnydesk = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.LblDatosUsuario = New System.Windows.Forms.Label()
        Me.TabPrincipal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabAgregar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Controls.Add(Me.TabPage1)
        Me.TabPrincipal.Controls.Add(Me.TabAgregar)
        Me.TabPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.SelectedIndex = 0
        Me.TabPrincipal.Size = New System.Drawing.Size(355, 318)
        Me.TabPrincipal.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LblUsuario)
        Me.TabPage1.Controls.Add(Me.BtnEliminar)
        Me.TabPage1.Controls.Add(Me.BtnModificar)
        Me.TabPage1.Controls.Add(Me.BtnConsultar)
        Me.TabPage1.Controls.Add(Me.BtnAgregar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(347, 290)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Acceso"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(9, 24)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(50, 15)
        Me.LblUsuario.TabIndex = 4
        Me.LblUsuario.Text = "Usuario:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(249, 252)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(168, 252)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(87, 253)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 1
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(6, 253)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TabAgregar
        '
        Me.TabAgregar.Controls.Add(Me.LblUser)
        Me.TabAgregar.Controls.Add(Me.BtnInsertar)
        Me.TabAgregar.Controls.Add(Me.LblPRust)
        Me.TabAgregar.Controls.Add(Me.LblPAny)
        Me.TabAgregar.Controls.Add(Me.LvlRust)
        Me.TabAgregar.Controls.Add(Me.LblAny)
        Me.TabAgregar.Controls.Add(Me.TxtPassRust)
        Me.TabAgregar.Controls.Add(Me.TxtPassAny)
        Me.TabAgregar.Controls.Add(Me.TxtRustDesk)
        Me.TabAgregar.Controls.Add(Me.TxtAnydesk)
        Me.TabAgregar.Controls.Add(Me.TxtUsuario)
        Me.TabAgregar.Controls.Add(Me.LblDatosUsuario)
        Me.TabAgregar.Location = New System.Drawing.Point(4, 24)
        Me.TabAgregar.Name = "TabAgregar"
        Me.TabAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAgregar.Size = New System.Drawing.Size(347, 290)
        Me.TabAgregar.TabIndex = 1
        Me.TabAgregar.Text = "Agregar usuario"
        Me.TabAgregar.UseVisualStyleBackColor = True
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Location = New System.Drawing.Point(7, 54)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(113, 15)
        Me.LblUser.TabIndex = 11
        Me.LblUser.Text = "Nombre de Usuario:"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Location = New System.Drawing.Point(123, 238)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(105, 23)
        Me.BtnInsertar.TabIndex = 10
        Me.BtnInsertar.Text = "Insertar Usuario"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'LblPRust
        '
        Me.LblPRust.AutoSize = True
        Me.LblPRust.Location = New System.Drawing.Point(205, 159)
        Me.LblPRust.Name = "LblPRust"
        Me.LblPRust.Size = New System.Drawing.Size(111, 15)
        Me.LblPRust.TabIndex = 9
        Me.LblPRust.Text = "Password RustDesk:"
        '
        'LblPAny
        '
        Me.LblPAny.AutoSize = True
        Me.LblPAny.Location = New System.Drawing.Point(12, 159)
        Me.LblPAny.Name = "LblPAny"
        Me.LblPAny.Size = New System.Drawing.Size(108, 15)
        Me.LblPAny.TabIndex = 8
        Me.LblPAny.Text = "Password Anydesk:"
        '
        'LvlRust
        '
        Me.LvlRust.AutoSize = True
        Me.LvlRust.Location = New System.Drawing.Point(204, 84)
        Me.LvlRust.Name = "LvlRust"
        Me.LvlRust.Size = New System.Drawing.Size(71, 15)
        Me.LvlRust.TabIndex = 7
        Me.LvlRust.Text = "Id RustDesk:"
        '
        'LblAny
        '
        Me.LblAny.AutoSize = True
        Me.LblAny.Location = New System.Drawing.Point(15, 84)
        Me.LblAny.Name = "LblAny"
        Me.LblAny.Size = New System.Drawing.Size(68, 15)
        Me.LblAny.TabIndex = 6
        Me.LblAny.Text = "Id Anydesk:"
        '
        'TxtPassRust
        '
        Me.TxtPassRust.Location = New System.Drawing.Point(204, 188)
        Me.TxtPassRust.Name = "TxtPassRust"
        Me.TxtPassRust.Size = New System.Drawing.Size(112, 23)
        Me.TxtPassRust.TabIndex = 5
        '
        'TxtPassAny
        '
        Me.TxtPassAny.Location = New System.Drawing.Point(15, 188)
        Me.TxtPassAny.Name = "TxtPassAny"
        Me.TxtPassAny.Size = New System.Drawing.Size(118, 23)
        Me.TxtPassAny.TabIndex = 4
        '
        'TxtRustDesk
        '
        Me.TxtRustDesk.Location = New System.Drawing.Point(205, 111)
        Me.TxtRustDesk.Name = "TxtRustDesk"
        Me.TxtRustDesk.Size = New System.Drawing.Size(112, 23)
        Me.TxtRustDesk.TabIndex = 3
        '
        'TxtAnydesk
        '
        Me.TxtAnydesk.Location = New System.Drawing.Point(15, 111)
        Me.TxtAnydesk.Name = "TxtAnydesk"
        Me.TxtAnydesk.Size = New System.Drawing.Size(118, 23)
        Me.TxtAnydesk.TabIndex = 2
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(126, 51)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(135, 23)
        Me.TxtUsuario.TabIndex = 1
        '
        'LblDatosUsuario
        '
        Me.LblDatosUsuario.AutoSize = True
        Me.LblDatosUsuario.Location = New System.Drawing.Point(15, 23)
        Me.LblDatosUsuario.Name = "LblDatosUsuario"
        Me.LblDatosUsuario.Size = New System.Drawing.Size(96, 15)
        Me.LblDatosUsuario.TabIndex = 0
        Me.LblDatosUsuario.Text = "Datos de Usuario"
        '
        'FrmAccesoRemotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(375, 343)
        Me.Controls.Add(Me.TabPrincipal)
        Me.Name = "FrmAccesoRemotos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso Remotos"
        Me.TabPrincipal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabAgregar.ResumeLayout(False)
        Me.TabAgregar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPrincipal As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LblUsuario As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TabAgregar As TabPage
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents LblDatosUsuario As Label
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents LblPRust As Label
    Friend WithEvents LblPAny As Label
    Friend WithEvents LvlRust As Label
    Friend WithEvents LblAny As Label
    Friend WithEvents TxtPassRust As TextBox
    Friend WithEvents TxtPassAny As TextBox
    Friend WithEvents TxtRustDesk As TextBox
    Friend WithEvents TxtAnydesk As TextBox
    Friend WithEvents LblUser As Label
End Class
