﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.IconBuscar = New FontAwesome.Sharp.IconButton()
        Me.DgvConsultar = New System.Windows.Forms.DataGridView()
        Me.LabelNota = New System.Windows.Forms.Label()
        Me.TextConsultar = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TabPrincipal = New System.Windows.Forms.TabControl()
        Me.TabAgregar.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPrincipal.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TabAgregar.Size = New System.Drawing.Size(555, 290)
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
        Me.LblDatosUsuario.Location = New System.Drawing.Point(12, 20)
        Me.LblDatosUsuario.Name = "LblDatosUsuario"
        Me.LblDatosUsuario.Size = New System.Drawing.Size(96, 15)
        Me.LblDatosUsuario.TabIndex = 0
        Me.LblDatosUsuario.Text = "Datos de Usuario"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.IconBuscar)
        Me.TabPage1.Controls.Add(Me.DgvConsultar)
        Me.TabPage1.Controls.Add(Me.LabelNota)
        Me.TabPage1.Controls.Add(Me.TextConsultar)
        Me.TabPage1.Controls.Add(Me.LblUsuario)
        Me.TabPage1.Controls.Add(Me.BtnEliminar)
        Me.TabPage1.Controls.Add(Me.BtnModificar)
        Me.TabPage1.Controls.Add(Me.BtnAgregar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(555, 290)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Acceso"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'IconBuscar
        '
        Me.IconBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.IconBuscar.IconColor = System.Drawing.Color.Black
        Me.IconBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBuscar.IconSize = 25
        Me.IconBuscar.Location = New System.Drawing.Point(330, 10)
        Me.IconBuscar.Name = "IconBuscar"
        Me.IconBuscar.Size = New System.Drawing.Size(34, 32)
        Me.IconBuscar.TabIndex = 8
        Me.IconBuscar.UseVisualStyleBackColor = True
        '
        'DgvConsultar
        '
        Me.DgvConsultar.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        Me.DgvConsultar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvConsultar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConsultar.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DgvConsultar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvConsultar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvConsultar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultar.Location = New System.Drawing.Point(10, 57)
        Me.DgvConsultar.Name = "DgvConsultar"
        Me.DgvConsultar.ReadOnly = True
        Me.DgvConsultar.RowTemplate.Height = 25
        Me.DgvConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvConsultar.Size = New System.Drawing.Size(523, 165)
        Me.DgvConsultar.TabIndex = 7
        '
        'LabelNota
        '
        Me.LabelNota.AutoSize = True
        Me.LabelNota.Font = New System.Drawing.Font("Segoe UI", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNota.Location = New System.Drawing.Point(62, 42)
        Me.LabelNota.Name = "LabelNota"
        Me.LabelNota.Size = New System.Drawing.Size(255, 12)
        Me.LabelNota.TabIndex = 6
        Me.LabelNota.Text = "*Actualmente solo se puede ingresar un IdUsuario para eliminar"
        '
        'TextConsultar
        '
        Me.TextConsultar.Location = New System.Drawing.Point(62, 16)
        Me.TextConsultar.Name = "TextConsultar"
        Me.TextConsultar.Size = New System.Drawing.Size(262, 23)
        Me.TextConsultar.TabIndex = 5
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(6, 19)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(50, 15)
        Me.LblUsuario.TabIndex = 4
        Me.LblUsuario.Text = "Usuario:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(458, 253)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(249, 253)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(10, 253)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Controls.Add(Me.TabPage1)
        Me.TabPrincipal.Controls.Add(Me.TabAgregar)
        Me.TabPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.SelectedIndex = 0
        Me.TabPrincipal.Size = New System.Drawing.Size(563, 318)
        Me.TabPrincipal.TabIndex = 1
        '
        'FrmAccesoRemotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(587, 346)
        Me.Controls.Add(Me.TabPrincipal)
        Me.Name = "FrmAccesoRemotos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso Remotos"
        Me.TabAgregar.ResumeLayout(False)
        Me.TabAgregar.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabAgregar As TabPage
    Friend WithEvents LblUser As Label
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents LblPRust As Label
    Friend WithEvents LblPAny As Label
    Friend WithEvents LvlRust As Label
    Friend WithEvents LblAny As Label
    Friend WithEvents TxtPassRust As TextBox
    Friend WithEvents TxtPassAny As TextBox
    Friend WithEvents TxtRustDesk As TextBox
    Friend WithEvents TxtAnydesk As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents LblDatosUsuario As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LabelNota As Label
    Friend WithEvents TextConsultar As TextBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TabPrincipal As TabControl
    Friend WithEvents DgvConsultar As DataGridView
    Friend WithEvents IconBuscar As FontAwesome.Sharp.IconButton
End Class
