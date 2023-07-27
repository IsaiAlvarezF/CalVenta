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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TabAgregar = New TabPage()
        LblUser = New Label()
        BtnInsertar = New Button()
        LblPRust = New Label()
        LblPAny = New Label()
        LvlRust = New Label()
        LblAny = New Label()
        TxtPassRust = New TextBox()
        TxtPassAny = New TextBox()
        TxtRustDesk = New TextBox()
        TxtAnydesk = New TextBox()
        TxtUsuario = New TextBox()
        LblDatosUsuario = New Label()
        TabPage1 = New TabPage()
        IconBuscar = New FontAwesome.Sharp.IconButton()
        DgvConsultar = New DataGridView()
        LabelNota = New Label()
        TextConsultar = New TextBox()
        LblUsuario = New Label()
        BtnEliminar = New Button()
        BtnModificar = New Button()
        BtnAgregar = New Button()
        TabPrincipal = New TabControl()
        TabAgregar.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DgvConsultar, ComponentModel.ISupportInitialize).BeginInit()
        TabPrincipal.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabAgregar
        ' 
        TabAgregar.Controls.Add(LblUser)
        TabAgregar.Controls.Add(BtnInsertar)
        TabAgregar.Controls.Add(LblPRust)
        TabAgregar.Controls.Add(LblPAny)
        TabAgregar.Controls.Add(LvlRust)
        TabAgregar.Controls.Add(LblAny)
        TabAgregar.Controls.Add(TxtPassRust)
        TabAgregar.Controls.Add(TxtPassAny)
        TabAgregar.Controls.Add(TxtRustDesk)
        TabAgregar.Controls.Add(TxtAnydesk)
        TabAgregar.Controls.Add(TxtUsuario)
        TabAgregar.Controls.Add(LblDatosUsuario)
        TabAgregar.Location = New Point(4, 24)
        TabAgregar.Name = "TabAgregar"
        TabAgregar.Padding = New Padding(3)
        TabAgregar.Size = New Size(555, 290)
        TabAgregar.TabIndex = 1
        TabAgregar.Text = "Agregar usuario"
        TabAgregar.UseVisualStyleBackColor = True
        ' 
        ' LblUser
        ' 
        LblUser.AutoSize = True
        LblUser.Location = New Point(7, 54)
        LblUser.Name = "LblUser"
        LblUser.Size = New Size(113, 15)
        LblUser.TabIndex = 11
        LblUser.Text = "Nombre de Usuario:"
        ' 
        ' BtnInsertar
        ' 
        BtnInsertar.Location = New Point(123, 238)
        BtnInsertar.Name = "BtnInsertar"
        BtnInsertar.Size = New Size(105, 23)
        BtnInsertar.TabIndex = 10
        BtnInsertar.Text = "Insertar Usuario"
        BtnInsertar.UseVisualStyleBackColor = True
        ' 
        ' LblPRust
        ' 
        LblPRust.AutoSize = True
        LblPRust.Location = New Point(205, 159)
        LblPRust.Name = "LblPRust"
        LblPRust.Size = New Size(111, 15)
        LblPRust.TabIndex = 9
        LblPRust.Text = "Password RustDesk:"
        ' 
        ' LblPAny
        ' 
        LblPAny.AutoSize = True
        LblPAny.Location = New Point(12, 159)
        LblPAny.Name = "LblPAny"
        LblPAny.Size = New Size(108, 15)
        LblPAny.TabIndex = 8
        LblPAny.Text = "Password Anydesk:"
        ' 
        ' LvlRust
        ' 
        LvlRust.AutoSize = True
        LvlRust.Location = New Point(204, 84)
        LvlRust.Name = "LvlRust"
        LvlRust.Size = New Size(71, 15)
        LvlRust.TabIndex = 7
        LvlRust.Text = "Id RustDesk:"
        ' 
        ' LblAny
        ' 
        LblAny.AutoSize = True
        LblAny.Location = New Point(15, 84)
        LblAny.Name = "LblAny"
        LblAny.Size = New Size(68, 15)
        LblAny.TabIndex = 6
        LblAny.Text = "Id Anydesk:"
        ' 
        ' TxtPassRust
        ' 
        TxtPassRust.Location = New Point(204, 188)
        TxtPassRust.Name = "TxtPassRust"
        TxtPassRust.Size = New Size(112, 23)
        TxtPassRust.TabIndex = 5
        ' 
        ' TxtPassAny
        ' 
        TxtPassAny.Location = New Point(15, 188)
        TxtPassAny.Name = "TxtPassAny"
        TxtPassAny.Size = New Size(118, 23)
        TxtPassAny.TabIndex = 4
        ' 
        ' TxtRustDesk
        ' 
        TxtRustDesk.Location = New Point(205, 111)
        TxtRustDesk.Name = "TxtRustDesk"
        TxtRustDesk.Size = New Size(112, 23)
        TxtRustDesk.TabIndex = 3
        ' 
        ' TxtAnydesk
        ' 
        TxtAnydesk.Location = New Point(15, 111)
        TxtAnydesk.Name = "TxtAnydesk"
        TxtAnydesk.Size = New Size(118, 23)
        TxtAnydesk.TabIndex = 2
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.Location = New Point(126, 51)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(135, 23)
        TxtUsuario.TabIndex = 1
        ' 
        ' LblDatosUsuario
        ' 
        LblDatosUsuario.AutoSize = True
        LblDatosUsuario.Location = New Point(12, 20)
        LblDatosUsuario.Name = "LblDatosUsuario"
        LblDatosUsuario.Size = New Size(96, 15)
        LblDatosUsuario.TabIndex = 0
        LblDatosUsuario.Text = "Datos de Usuario"
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(IconBuscar)
        TabPage1.Controls.Add(DgvConsultar)
        TabPage1.Controls.Add(LabelNota)
        TabPage1.Controls.Add(TextConsultar)
        TabPage1.Controls.Add(LblUsuario)
        TabPage1.Controls.Add(BtnEliminar)
        TabPage1.Controls.Add(BtnModificar)
        TabPage1.Controls.Add(BtnAgregar)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(555, 290)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Acceso"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' IconBuscar
        ' 
        IconBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        IconBuscar.IconColor = Color.Black
        IconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBuscar.IconSize = 25
        IconBuscar.Location = New Point(330, 10)
        IconBuscar.Name = "IconBuscar"
        IconBuscar.Size = New Size(34, 32)
        IconBuscar.TabIndex = 8
        IconBuscar.UseVisualStyleBackColor = True
        ' 
        ' DgvConsultar
        ' 
        DgvConsultar.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = Color.AliceBlue
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.Blue
        DgvConsultar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgvConsultar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvConsultar.BackgroundColor = SystemColors.ScrollBar
        DgvConsultar.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgvConsultar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Azure
        DataGridViewCellStyle2.Font = New Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgvConsultar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgvConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvConsultar.Location = New Point(10, 57)
        DgvConsultar.Name = "DgvConsultar"
        DgvConsultar.ReadOnly = True
        DgvConsultar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DgvConsultar.RowTemplate.Height = 25
        DgvConsultar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvConsultar.Size = New Size(523, 165)
        DgvConsultar.TabIndex = 7
        ' 
        ' LabelNota
        ' 
        LabelNota.AutoSize = True
        LabelNota.Font = New Font("Segoe UI", 6.5F, FontStyle.Regular, GraphicsUnit.Point)
        LabelNota.Location = New Point(62, 42)
        LabelNota.Name = "LabelNota"
        LabelNota.Size = New Size(255, 12)
        LabelNota.TabIndex = 6
        LabelNota.Text = "*Actualmente solo se puede ingresar un IdUsuario para eliminar"
        ' 
        ' TextConsultar
        ' 
        TextConsultar.Location = New Point(62, 16)
        TextConsultar.Name = "TextConsultar"
        TextConsultar.Size = New Size(262, 23)
        TextConsultar.TabIndex = 5
        ' 
        ' LblUsuario
        ' 
        LblUsuario.AutoSize = True
        LblUsuario.Location = New Point(6, 19)
        LblUsuario.Name = "LblUsuario"
        LblUsuario.Size = New Size(50, 15)
        LblUsuario.TabIndex = 4
        LblUsuario.Text = "Usuario:"
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.Location = New Point(458, 253)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(75, 23)
        BtnEliminar.TabIndex = 3
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.UseVisualStyleBackColor = True
        ' 
        ' BtnModificar
        ' 
        BtnModificar.Location = New Point(249, 253)
        BtnModificar.Name = "BtnModificar"
        BtnModificar.Size = New Size(75, 23)
        BtnModificar.TabIndex = 2
        BtnModificar.Text = "Modificar"
        BtnModificar.UseVisualStyleBackColor = True
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.Location = New Point(10, 253)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(75, 23)
        BtnAgregar.TabIndex = 0
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = True
        ' 
        ' TabPrincipal
        ' 
        TabPrincipal.Controls.Add(TabPage1)
        TabPrincipal.Controls.Add(TabAgregar)
        TabPrincipal.Location = New Point(12, 12)
        TabPrincipal.Name = "TabPrincipal"
        TabPrincipal.SelectedIndex = 0
        TabPrincipal.Size = New Size(563, 318)
        TabPrincipal.TabIndex = 1
        ' 
        ' FrmAccesoRemotos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(587, 346)
        Controls.Add(TabPrincipal)
        Name = "FrmAccesoRemotos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Acceso Remotos"
        TabAgregar.ResumeLayout(False)
        TabAgregar.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(DgvConsultar, ComponentModel.ISupportInitialize).EndInit()
        TabPrincipal.ResumeLayout(False)
        ResumeLayout(False)
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
