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
        TabPrincipal = New TabControl()
        TabPage1 = New TabPage()
        LblUsuario = New Label()
        BtnEliminar = New Button()
        BtnModificar = New Button()
        BtnConsultar = New Button()
        BtnAgregar = New Button()
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
        UsuAgregados = New TabPage()
        DataGridUsuAgregados = New DataGridView()
        NombreUsuario = New DataGridViewTextBoxColumn()
        AccesoAnydesk = New DataGridViewTextBoxColumn()
        AccesoRuskDesk = New DataGridViewTextBoxColumn()
        PassAny = New DataGridViewTextBoxColumn()
        PassRusk = New DataGridViewTextBoxColumn()
        TextUsuario = New TextBox()
        LabelNota = New Label()
        TabPrincipal.SuspendLayout()
        TabPage1.SuspendLayout()
        TabAgregar.SuspendLayout()
        UsuAgregados.SuspendLayout()
        CType(DataGridUsuAgregados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabPrincipal
        ' 
        TabPrincipal.Controls.Add(TabPage1)
        TabPrincipal.Controls.Add(TabAgregar)
        TabPrincipal.Controls.Add(UsuAgregados)
        TabPrincipal.Location = New Point(12, 12)
        TabPrincipal.Name = "TabPrincipal"
        TabPrincipal.SelectedIndex = 0
        TabPrincipal.Size = New Size(355, 318)
        TabPrincipal.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(LabelNota)
        TabPage1.Controls.Add(TextUsuario)
        TabPage1.Controls.Add(LblUsuario)
        TabPage1.Controls.Add(BtnEliminar)
        TabPage1.Controls.Add(BtnModificar)
        TabPage1.Controls.Add(BtnConsultar)
        TabPage1.Controls.Add(BtnAgregar)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(347, 290)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Acceso"
        TabPage1.UseVisualStyleBackColor = True
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
        BtnEliminar.Location = New Point(249, 252)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(75, 23)
        BtnEliminar.TabIndex = 3
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.UseVisualStyleBackColor = True
        ' 
        ' BtnModificar
        ' 
        BtnModificar.Location = New Point(168, 252)
        BtnModificar.Name = "BtnModificar"
        BtnModificar.Size = New Size(75, 23)
        BtnModificar.TabIndex = 2
        BtnModificar.Text = "Modificar"
        BtnModificar.UseVisualStyleBackColor = True
        ' 
        ' BtnConsultar
        ' 
        BtnConsultar.Location = New Point(87, 253)
        BtnConsultar.Name = "BtnConsultar"
        BtnConsultar.Size = New Size(75, 23)
        BtnConsultar.TabIndex = 1
        BtnConsultar.Text = "Consultar"
        BtnConsultar.UseVisualStyleBackColor = True
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.Location = New Point(6, 253)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(75, 23)
        BtnAgregar.TabIndex = 0
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = True
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
        TabAgregar.Size = New Size(347, 290)
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
        LblDatosUsuario.Location = New Point(15, 23)
        LblDatosUsuario.Name = "LblDatosUsuario"
        LblDatosUsuario.Size = New Size(96, 15)
        LblDatosUsuario.TabIndex = 0
        LblDatosUsuario.Text = "Datos de Usuario"
        ' 
        ' UsuAgregados
        ' 
        UsuAgregados.Controls.Add(DataGridUsuAgregados)
        UsuAgregados.Location = New Point(4, 24)
        UsuAgregados.Name = "UsuAgregados"
        UsuAgregados.Size = New Size(347, 290)
        UsuAgregados.TabIndex = 2
        UsuAgregados.Text = "Usuarios Agregados"
        UsuAgregados.UseVisualStyleBackColor = True
        ' 
        ' DataGridUsuAgregados
        ' 
        DataGridUsuAgregados.AllowUserToAddRows = False
        DataGridUsuAgregados.AllowUserToDeleteRows = False
        DataGridUsuAgregados.AllowUserToOrderColumns = True
        DataGridUsuAgregados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridUsuAgregados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridUsuAgregados.Columns.AddRange(New DataGridViewColumn() {NombreUsuario, AccesoAnydesk, AccesoRuskDesk, PassAny, PassRusk})
        DataGridUsuAgregados.Dock = DockStyle.Fill
        DataGridUsuAgregados.Location = New Point(0, 0)
        DataGridUsuAgregados.Name = "DataGridUsuAgregados"
        DataGridUsuAgregados.ReadOnly = True
        DataGridUsuAgregados.RowTemplate.Height = 25
        DataGridUsuAgregados.Size = New Size(347, 290)
        DataGridUsuAgregados.TabIndex = 0
        ' 
        ' NombreUsuario
        ' 
        NombreUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        NombreUsuario.HeaderText = "Nombre Usuario"
        NombreUsuario.Name = "NombreUsuario"
        NombreUsuario.ReadOnly = True
        NombreUsuario.Width = 109
        ' 
        ' AccesoAnydesk
        ' 
        AccesoAnydesk.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        AccesoAnydesk.HeaderText = "Anydesk ID"
        AccesoAnydesk.Name = "AccesoAnydesk"
        AccesoAnydesk.ReadOnly = True
        AccesoAnydesk.Width = 84
        ' 
        ' AccesoRuskDesk
        ' 
        AccesoRuskDesk.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        AccesoRuskDesk.HeaderText = "Rusk Desk ID"
        AccesoRuskDesk.Name = "AccesoRuskDesk"
        AccesoRuskDesk.ReadOnly = True
        AccesoRuskDesk.Width = 81
        ' 
        ' PassAny
        ' 
        PassAny.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        PassAny.HeaderText = "Contraseña Anydesk"
        PassAny.Name = "PassAny"
        PassAny.ReadOnly = True
        PassAny.Width = 128
        ' 
        ' PassRusk
        ' 
        PassRusk.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        PassRusk.HeaderText = "Contraseña Rusk Desk"
        PassRusk.Name = "PassRusk"
        PassRusk.ReadOnly = True
        PassRusk.Width = 113
        ' 
        ' TextUsuario
        ' 
        TextUsuario.Location = New Point(62, 16)
        TextUsuario.Name = "TextUsuario"
        TextUsuario.Size = New Size(262, 23)
        TextUsuario.TabIndex = 5
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
        ' FrmAccesoRemotos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(375, 343)
        Controls.Add(TabPrincipal)
        Name = "FrmAccesoRemotos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Acceso Remotos"
        TabPrincipal.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabAgregar.ResumeLayout(False)
        TabAgregar.PerformLayout()
        UsuAgregados.ResumeLayout(False)
        CType(DataGridUsuAgregados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
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
    Friend WithEvents UsuAgregados As TabPage
    Friend WithEvents DataGridUsuAgregados As DataGridView
    Friend WithEvents NombreUsuario As DataGridViewTextBoxColumn
    Friend WithEvents AccesoAnydesk As DataGridViewTextBoxColumn
    Friend WithEvents AccesoRuskDesk As DataGridViewTextBoxColumn
    Friend WithEvents PassAny As DataGridViewTextBoxColumn
    Friend WithEvents PassRusk As DataGridViewTextBoxColumn
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents LabelNota As Label
End Class
