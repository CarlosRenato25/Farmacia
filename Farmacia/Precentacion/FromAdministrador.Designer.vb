<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FromAdministrador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromAdministrador))
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvAdministrador1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.gbRegistroAdministrador = New System.Windows.Forms.GroupBox()
        Me.pbFotoAdministrador = New System.Windows.Forms.PictureBox()
        Me.LnkFoto = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaDeEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.gbSexo = New System.Windows.Forms.GroupBox()
        Me.ptnFemenino = New System.Windows.Forms.RadioButton()
        Me.ptnMasculino = New System.Windows.Forms.RadioButton()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tabBuscarAdministrador = New System.Windows.Forms.TabPage()
        Me.lvAdministrador2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtBuscadorAdministrador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optNombre = New System.Windows.Forms.RadioButton()
        Me.optDni = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbRegistroAdministrador.SuspendLayout()
        CType(Me.pbFotoAdministrador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSexo.SuspendLayout()
        Me.tabBuscarAdministrador.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "agregar.png")
        Me.imagenes.Images.SetKeyName(1, "cancelar.png")
        Me.imagenes.Images.SetKeyName(2, "cerrar.png")
        Me.imagenes.Images.SetKeyName(3, "editar.png")
        Me.imagenes.Images.SetKeyName(4, "eliminar.png")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(734, 59)
        Me.Label1.TabIndex = 26
        Me.Label1.Tag = " "
        Me.Label1.Text = "Administrador"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.tabBuscarAdministrador)
        Me.TabControl1.Location = New System.Drawing.Point(6, 62)
        Me.TabControl1.MinimumSize = New System.Drawing.Size(700, 450)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(728, 450)
        Me.TabControl1.TabIndex = 35
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lvAdministrador1)
        Me.TabPage1.Controls.Add(Me.cmdCerrar)
        Me.TabPage1.Controls.Add(Me.cmdCancelar)
        Me.TabPage1.Controls.Add(Me.cmdEliminar)
        Me.TabPage1.Controls.Add(Me.cmdEditar)
        Me.TabPage1.Controls.Add(Me.cmdAgregar)
        Me.TabPage1.Controls.Add(Me.gbRegistroAdministrador)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(720, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro De Administrador"
        '
        'lvAdministrador1
        '
        Me.lvAdministrador1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.lvAdministrador1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvAdministrador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAdministrador1.FullRowSelect = True
        Me.lvAdministrador1.GridLines = True
        Me.lvAdministrador1.HideSelection = False
        Me.lvAdministrador1.Location = New System.Drawing.Point(3, 288)
        Me.lvAdministrador1.Name = "lvAdministrador1"
        Me.lvAdministrador1.Size = New System.Drawing.Size(714, 133)
        Me.lvAdministrador1.TabIndex = 30
        Me.lvAdministrador1.UseCompatibleStateImageBehavior = False
        Me.lvAdministrador1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Codigo"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Nombre"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Apellidos"
        Me.ColumnHeader11.Width = 120
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "RUC"
        Me.ColumnHeader12.Width = 90
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Telefono"
        Me.ColumnHeader13.Width = 120
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Direccion"
        Me.ColumnHeader14.Width = 120
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "DNI"
        Me.ColumnHeader15.Width = 100
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Sexo"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "FechaDeNacimiento"
        Me.ColumnHeader17.Width = 100
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "FechaDeEntrada"
        Me.ColumnHeader18.Width = 100
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.ImageKey = "cerrar.png"
        Me.cmdCerrar.ImageList = Me.imagenes
        Me.cmdCerrar.Location = New System.Drawing.Point(603, 204)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(109, 42)
        Me.cmdCerrar.TabIndex = 29
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ImageKey = "cancelar.png"
        Me.cmdCancelar.ImageList = Me.imagenes
        Me.cmdCancelar.Location = New System.Drawing.Point(603, 154)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(109, 44)
        Me.cmdCancelar.TabIndex = 28
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.ImageKey = "eliminar.png"
        Me.cmdEliminar.ImageList = Me.imagenes
        Me.cmdEliminar.Location = New System.Drawing.Point(603, 111)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(109, 37)
        Me.cmdEliminar.TabIndex = 27
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdEditar
        '
        Me.cmdEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditar.ImageKey = "editar.png"
        Me.cmdEditar.ImageList = Me.imagenes
        Me.cmdEditar.Location = New System.Drawing.Point(603, 65)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(109, 40)
        Me.cmdEditar.TabIndex = 26
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.ImageKey = "agregar.png"
        Me.cmdAgregar.ImageList = Me.imagenes
        Me.cmdAgregar.Location = New System.Drawing.Point(603, 14)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(109, 45)
        Me.cmdAgregar.TabIndex = 25
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'gbRegistroAdministrador
        '
        Me.gbRegistroAdministrador.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbRegistroAdministrador.Controls.Add(Me.pbFotoAdministrador)
        Me.gbRegistroAdministrador.Controls.Add(Me.LnkFoto)
        Me.gbRegistroAdministrador.Controls.Add(Me.Label4)
        Me.gbRegistroAdministrador.Controls.Add(Me.Label3)
        Me.gbRegistroAdministrador.Controls.Add(Me.dtpFechaDeEntrada)
        Me.gbRegistroAdministrador.Controls.Add(Me.dtpFechaDeNacimiento)
        Me.gbRegistroAdministrador.Controls.Add(Me.gbSexo)
        Me.gbRegistroAdministrador.Controls.Add(Me.txtDNI)
        Me.gbRegistroAdministrador.Controls.Add(Me.Label10)
        Me.gbRegistroAdministrador.Controls.Add(Me.txtRuc)
        Me.gbRegistroAdministrador.Controls.Add(Me.Label11)
        Me.gbRegistroAdministrador.Controls.Add(Me.txtDireccion)
        Me.gbRegistroAdministrador.Controls.Add(Me.Label12)
        Me.gbRegistroAdministrador.Controls.Add(Me.txtApellidos)
        Me.gbRegistroAdministrador.Controls.Add(Me.Label13)
        Me.gbRegistroAdministrador.Controls.Add(Me.txtNombre)
        Me.gbRegistroAdministrador.Controls.Add(Me.Label14)
        Me.gbRegistroAdministrador.Controls.Add(Me.txtTelefono)
        Me.gbRegistroAdministrador.Controls.Add(Me.Label15)
        Me.gbRegistroAdministrador.Controls.Add(Me.txtCodigo)
        Me.gbRegistroAdministrador.Controls.Add(Me.Label16)
        Me.gbRegistroAdministrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegistroAdministrador.Location = New System.Drawing.Point(3, 8)
        Me.gbRegistroAdministrador.Name = "gbRegistroAdministrador"
        Me.gbRegistroAdministrador.Size = New System.Drawing.Size(579, 238)
        Me.gbRegistroAdministrador.TabIndex = 20
        Me.gbRegistroAdministrador.TabStop = False
        Me.gbRegistroAdministrador.Text = "Administrador"
        '
        'pbFotoAdministrador
        '
        Me.pbFotoAdministrador.BackColor = System.Drawing.SystemColors.Control
        Me.pbFotoAdministrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFotoAdministrador.Location = New System.Drawing.Point(414, 21)
        Me.pbFotoAdministrador.Margin = New System.Windows.Forms.Padding(2)
        Me.pbFotoAdministrador.Name = "pbFotoAdministrador"
        Me.pbFotoAdministrador.Size = New System.Drawing.Size(158, 138)
        Me.pbFotoAdministrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFotoAdministrador.TabIndex = 25
        Me.pbFotoAdministrador.TabStop = False
        '
        'LnkFoto
        '
        Me.LnkFoto.AutoSize = True
        Me.LnkFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkFoto.Location = New System.Drawing.Point(464, 169)
        Me.LnkFoto.Name = "LnkFoto"
        Me.LnkFoto.Size = New System.Drawing.Size(43, 18)
        Me.LnkFoto.TabIndex = 24
        Me.LnkFoto.TabStop = True
        Me.LnkFoto.Text = "Foto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "FechaDe Entrada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Fecha Nacimiento"
        '
        'dtpFechaDeEntrada
        '
        Me.dtpFechaDeEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeEntrada.Location = New System.Drawing.Point(126, 212)
        Me.dtpFechaDeEntrada.Name = "dtpFechaDeEntrada"
        Me.dtpFechaDeEntrada.Size = New System.Drawing.Size(113, 22)
        Me.dtpFechaDeEntrada.TabIndex = 20
        '
        'dtpFechaDeNacimiento
        '
        Me.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeNacimiento.Location = New System.Drawing.Point(126, 184)
        Me.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento"
        Me.dtpFechaDeNacimiento.Size = New System.Drawing.Size(114, 22)
        Me.dtpFechaDeNacimiento.TabIndex = 19
        Me.dtpFechaDeNacimiento.Value = New Date(2019, 11, 11, 17, 36, 27, 0)
        '
        'gbSexo
        '
        Me.gbSexo.Controls.Add(Me.ptnFemenino)
        Me.gbSexo.Controls.Add(Me.ptnMasculino)
        Me.gbSexo.Location = New System.Drawing.Point(242, 96)
        Me.gbSexo.Margin = New System.Windows.Forms.Padding(2)
        Me.gbSexo.Name = "gbSexo"
        Me.gbSexo.Padding = New System.Windows.Forms.Padding(2)
        Me.gbSexo.Size = New System.Drawing.Size(129, 76)
        Me.gbSexo.TabIndex = 18
        Me.gbSexo.TabStop = False
        Me.gbSexo.Text = "Sexo"
        '
        'ptnFemenino
        '
        Me.ptnFemenino.AutoSize = True
        Me.ptnFemenino.Location = New System.Drawing.Point(14, 43)
        Me.ptnFemenino.Margin = New System.Windows.Forms.Padding(2)
        Me.ptnFemenino.Name = "ptnFemenino"
        Me.ptnFemenino.Size = New System.Drawing.Size(94, 20)
        Me.ptnFemenino.TabIndex = 1
        Me.ptnFemenino.Text = "Femenino"
        Me.ptnFemenino.UseVisualStyleBackColor = True
        '
        'ptnMasculino
        '
        Me.ptnMasculino.AutoSize = True
        Me.ptnMasculino.Location = New System.Drawing.Point(14, 19)
        Me.ptnMasculino.Margin = New System.Windows.Forms.Padding(2)
        Me.ptnMasculino.Name = "ptnMasculino"
        Me.ptnMasculino.Size = New System.Drawing.Size(96, 20)
        Me.ptnMasculino.TabIndex = 0
        Me.ptnMasculino.Text = "Masculino"
        Me.ptnMasculino.UseVisualStyleBackColor = True
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(309, 66)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 22)
        Me.txtDNI.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(260, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "DNI"
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(80, 118)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(145, 22)
        Me.txtRuc.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "RUC"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(98, 152)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(127, 22)
        Me.txtDireccion.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(34, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Direccion"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(98, 91)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(128, 22)
        Me.txtApellidos.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(34, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Apellidos"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(86, 61)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(139, 22)
        Me.txtNombre.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(34, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Nombre"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(309, 38)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 22)
        Me.txtTelefono.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(246, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Telefono"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(86, 35)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(139, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(34, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Codigo"
        '
        'tabBuscarAdministrador
        '
        Me.tabBuscarAdministrador.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabBuscarAdministrador.Controls.Add(Me.lvAdministrador2)
        Me.tabBuscarAdministrador.Controls.Add(Me.txtBuscadorAdministrador)
        Me.tabBuscarAdministrador.Controls.Add(Me.Label2)
        Me.tabBuscarAdministrador.Controls.Add(Me.GroupBox4)
        Me.tabBuscarAdministrador.Location = New System.Drawing.Point(4, 22)
        Me.tabBuscarAdministrador.Name = "tabBuscarAdministrador"
        Me.tabBuscarAdministrador.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBuscarAdministrador.Size = New System.Drawing.Size(720, 424)
        Me.tabBuscarAdministrador.TabIndex = 1
        Me.tabBuscarAdministrador.Text = "Busqueda Administrador"
        '
        'lvAdministrador2
        '
        Me.lvAdministrador2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader19, Me.ColumnHeader20})
        Me.lvAdministrador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAdministrador2.FullRowSelect = True
        Me.lvAdministrador2.GridLines = True
        Me.lvAdministrador2.HideSelection = False
        Me.lvAdministrador2.Location = New System.Drawing.Point(6, 209)
        Me.lvAdministrador2.Name = "lvAdministrador2"
        Me.lvAdministrador2.Size = New System.Drawing.Size(706, 133)
        Me.lvAdministrador2.TabIndex = 39
        Me.lvAdministrador2.UseCompatibleStateImageBehavior = False
        Me.lvAdministrador2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "nombre"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Apellidos"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "RUC"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Telefono"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Direccion"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Dni"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sexo"
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "FechaDeNacimiento"
        Me.ColumnHeader19.Width = 100
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "FechaDeEntrada"
        Me.ColumnHeader20.Width = 100
        '
        'txtBuscadorAdministrador
        '
        Me.txtBuscadorAdministrador.Location = New System.Drawing.Point(230, 152)
        Me.txtBuscadorAdministrador.Name = "txtBuscadorAdministrador"
        Me.txtBuscadorAdministrador.Size = New System.Drawing.Size(281, 20)
        Me.txtBuscadorAdministrador.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 18)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Buscar Administrador"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.optNombre)
        Me.GroupBox4.Controls.Add(Me.optDni)
        Me.GroupBox4.Location = New System.Drawing.Point(188, 43)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(339, 80)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipos De Busqueda"
        '
        'optNombre
        '
        Me.optNombre.AutoSize = True
        Me.optNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNombre.Location = New System.Drawing.Point(179, 31)
        Me.optNombre.Name = "optNombre"
        Me.optNombre.Size = New System.Drawing.Size(102, 19)
        Me.optNombre.TabIndex = 1
        Me.optNombre.Text = "Por Nombre"
        Me.optNombre.UseVisualStyleBackColor = True
        '
        'optDni
        '
        Me.optDni.AutoSize = True
        Me.optDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDni.Location = New System.Drawing.Point(63, 31)
        Me.optDni.Name = "optDni"
        Me.optDni.Size = New System.Drawing.Size(75, 19)
        Me.optDni.TabIndex = 0
        Me.optDni.Text = "Por DNI"
        '
        'FromAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(750, 550)
        Me.Name = "FromAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbRegistroAdministrador.ResumeLayout(False)
        Me.gbRegistroAdministrador.PerformLayout()
        CType(Me.pbFotoAdministrador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSexo.ResumeLayout(False)
        Me.gbSexo.PerformLayout()
        Me.tabBuscarAdministrador.ResumeLayout(False)
        Me.tabBuscarAdministrador.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imagenes As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cmdCerrar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmdEditar As Button
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents gbRegistroAdministrador As GroupBox
    Friend WithEvents gbSexo As GroupBox
    Friend WithEvents ptnFemenino As RadioButton
    Friend WithEvents ptnMasculino As RadioButton
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tabBuscarAdministrador As TabPage
    Friend WithEvents lvAdministrador1 As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents txtBuscadorAdministrador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optNombre As RadioButton
    Friend WithEvents optDni As RadioButton
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaDeEntrada As DateTimePicker
    Friend WithEvents dtpFechaDeNacimiento As DateTimePicker
    Friend WithEvents LnkFoto As LinkLabel
    Friend WithEvents pbFotoAdministrador As PictureBox
    Friend WithEvents lvAdministrador2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
End Class
