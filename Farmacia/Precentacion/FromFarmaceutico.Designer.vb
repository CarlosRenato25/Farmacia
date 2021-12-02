<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromFarmaceutico
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromFarmaceutico))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvFarmaceutico1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbRegistroFarmaceutico = New System.Windows.Forms.GroupBox()
        Me.cboAdministrador = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaDeEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaDeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.pbFotoFarmaceutico = New System.Windows.Forms.PictureBox()
        Me.LnkFoto = New System.Windows.Forms.LinkLabel()
        Me.gbSexo = New System.Windows.Forms.GroupBox()
        Me.RadioFemenino = New System.Windows.Forms.RadioButton()
        Me.RadioMasculino = New System.Windows.Forms.RadioButton()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvFarmaceutico2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtBuscarFarmaceutico = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioNombre = New System.Windows.Forms.RadioButton()
        Me.RadioDni = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbRegistroFarmaceutico.SuspendLayout()
        CType(Me.pbFotoFarmaceutico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSexo.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(754, 59)
        Me.Label1.TabIndex = 6
        Me.Label1.Tag = " "
        Me.Label1.Text = "Farmaceutico"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.ImageKey = "cerrar.png"
        Me.cmdCerrar.ImageList = Me.imagenes
        Me.cmdCerrar.Location = New System.Drawing.Point(581, 216)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(141, 45)
        Me.cmdCerrar.TabIndex = 22
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ImageKey = "cancelar.png"
        Me.cmdCancelar.ImageList = Me.imagenes
        Me.cmdCancelar.Location = New System.Drawing.Point(581, 166)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(141, 47)
        Me.cmdCancelar.TabIndex = 21
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.ImageKey = "eliminar.png"
        Me.cmdEliminar.ImageList = Me.imagenes
        Me.cmdEliminar.Location = New System.Drawing.Point(581, 123)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(141, 40)
        Me.cmdEliminar.TabIndex = 20
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdEditar
        '
        Me.cmdEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditar.ImageKey = "editar.png"
        Me.cmdEditar.ImageList = Me.imagenes
        Me.cmdEditar.Location = New System.Drawing.Point(581, 77)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(141, 43)
        Me.cmdEditar.TabIndex = 19
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.ImageKey = "agregar.png"
        Me.cmdAgregar.ImageList = Me.imagenes
        Me.cmdAgregar.Location = New System.Drawing.Point(581, 26)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(141, 48)
        Me.cmdAgregar.TabIndex = 18
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 62)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(736, 492)
        Me.TabControl1.TabIndex = 37
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lvFarmaceutico1)
        Me.TabPage1.Controls.Add(Me.gbRegistroFarmaceutico)
        Me.TabPage1.Controls.Add(Me.cmdAgregar)
        Me.TabPage1.Controls.Add(Me.cmdEditar)
        Me.TabPage1.Controls.Add(Me.cmdEliminar)
        Me.TabPage1.Controls.Add(Me.cmdCancelar)
        Me.TabPage1.Controls.Add(Me.cmdCerrar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(728, 466)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "RegistroFamaceutico"
        '
        'lvFarmaceutico1
        '
        Me.lvFarmaceutico1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.lvFarmaceutico1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvFarmaceutico1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFarmaceutico1.FullRowSelect = True
        Me.lvFarmaceutico1.GridLines = True
        Me.lvFarmaceutico1.HideSelection = False
        Me.lvFarmaceutico1.HoverSelection = True
        Me.lvFarmaceutico1.Location = New System.Drawing.Point(3, 330)
        Me.lvFarmaceutico1.Name = "lvFarmaceutico1"
        Me.lvFarmaceutico1.Size = New System.Drawing.Size(722, 133)
        Me.lvFarmaceutico1.TabIndex = 24
        Me.lvFarmaceutico1.UseCompatibleStateImageBehavior = False
        Me.lvFarmaceutico1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Codigo"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Nombre"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Apellidos"
        Me.ColumnHeader9.Width = 120
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Telefono"
        Me.ColumnHeader10.Width = 120
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Direccion"
        Me.ColumnHeader11.Width = 120
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "DNI"
        Me.ColumnHeader12.Width = 100
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "FechaDeEntrada"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "FechaDeNacimineto"
        Me.ColumnHeader14.Width = 100
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Sexo"
        '
        'gbRegistroFarmaceutico
        '
        Me.gbRegistroFarmaceutico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbRegistroFarmaceutico.Controls.Add(Me.cboAdministrador)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.Label9)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.Label4)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.dtpFechaDeEntrada)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.Label3)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.dtpFechaDeNacimiento)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.pbFotoFarmaceutico)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.LnkFoto)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.gbSexo)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.txtDni)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.Label11)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.txtDireccion)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.Label12)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.txtApellidos)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.Label13)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.txtNombres)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.Label14)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.txtTelefono)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.Label15)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.txtCodigo)
        Me.gbRegistroFarmaceutico.Controls.Add(Me.Label16)
        Me.gbRegistroFarmaceutico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegistroFarmaceutico.Location = New System.Drawing.Point(6, 17)
        Me.gbRegistroFarmaceutico.Name = "gbRegistroFarmaceutico"
        Me.gbRegistroFarmaceutico.Size = New System.Drawing.Size(569, 296)
        Me.gbRegistroFarmaceutico.TabIndex = 6
        Me.gbRegistroFarmaceutico.TabStop = False
        Me.gbRegistroFarmaceutico.Text = "Farmaseutico"
        '
        'cboAdministrador
        '
        Me.cboAdministrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAdministrador.FormattingEnabled = True
        Me.cboAdministrador.Location = New System.Drawing.Point(328, 220)
        Me.cboAdministrador.Name = "cboAdministrador"
        Me.cboAdministrador.Size = New System.Drawing.Size(225, 24)
        Me.cboAdministrador.Sorted = True
        Me.cboAdministrador.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(239, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Administrador"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Fecha De Entrada"
        '
        'dtpFechaDeEntrada
        '
        Me.dtpFechaDeEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeEntrada.Location = New System.Drawing.Point(121, 224)
        Me.dtpFechaDeEntrada.Name = "dtpFechaDeEntrada"
        Me.dtpFechaDeEntrada.Size = New System.Drawing.Size(114, 22)
        Me.dtpFechaDeEntrada.TabIndex = 33
        Me.dtpFechaDeEntrada.Value = New Date(2019, 11, 11, 17, 36, 27, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Fecha Nacimiento"
        '
        'dtpFechaDeNacimiento
        '
        Me.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeNacimiento.Location = New System.Drawing.Point(121, 264)
        Me.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento"
        Me.dtpFechaDeNacimiento.Size = New System.Drawing.Size(114, 22)
        Me.dtpFechaDeNacimiento.TabIndex = 31
        Me.dtpFechaDeNacimiento.Value = New Date(2019, 11, 11, 17, 36, 27, 0)
        '
        'pbFotoFarmaceutico
        '
        Me.pbFotoFarmaceutico.BackColor = System.Drawing.SystemColors.Control
        Me.pbFotoFarmaceutico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFotoFarmaceutico.Location = New System.Drawing.Point(395, 20)
        Me.pbFotoFarmaceutico.Margin = New System.Windows.Forms.Padding(2)
        Me.pbFotoFarmaceutico.Name = "pbFotoFarmaceutico"
        Me.pbFotoFarmaceutico.Size = New System.Drawing.Size(158, 138)
        Me.pbFotoFarmaceutico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFotoFarmaceutico.TabIndex = 30
        Me.pbFotoFarmaceutico.TabStop = False
        '
        'LnkFoto
        '
        Me.LnkFoto.AutoSize = True
        Me.LnkFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkFoto.Location = New System.Drawing.Point(445, 168)
        Me.LnkFoto.Name = "LnkFoto"
        Me.LnkFoto.Size = New System.Drawing.Size(43, 18)
        Me.LnkFoto.TabIndex = 29
        Me.LnkFoto.TabStop = True
        Me.LnkFoto.Text = "Foto"
        '
        'gbSexo
        '
        Me.gbSexo.Controls.Add(Me.RadioFemenino)
        Me.gbSexo.Controls.Add(Me.RadioMasculino)
        Me.gbSexo.Location = New System.Drawing.Point(211, 58)
        Me.gbSexo.Name = "gbSexo"
        Me.gbSexo.Size = New System.Drawing.Size(179, 88)
        Me.gbSexo.TabIndex = 19
        Me.gbSexo.TabStop = False
        Me.gbSexo.Text = "Sexo"
        '
        'RadioFemenino
        '
        Me.RadioFemenino.AutoSize = True
        Me.RadioFemenino.Location = New System.Drawing.Point(15, 50)
        Me.RadioFemenino.Name = "RadioFemenino"
        Me.RadioFemenino.Size = New System.Drawing.Size(94, 20)
        Me.RadioFemenino.TabIndex = 1
        Me.RadioFemenino.TabStop = True
        Me.RadioFemenino.Text = "Femenino"
        Me.RadioFemenino.UseVisualStyleBackColor = True
        '
        'RadioMasculino
        '
        Me.RadioMasculino.AutoSize = True
        Me.RadioMasculino.Location = New System.Drawing.Point(15, 24)
        Me.RadioMasculino.Name = "RadioMasculino"
        Me.RadioMasculino.Size = New System.Drawing.Size(96, 20)
        Me.RadioMasculino.TabIndex = 0
        Me.RadioMasculino.TabStop = True
        Me.RadioMasculino.Text = "Masculino"
        Me.RadioMasculino.UseVisualStyleBackColor = True
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(71, 179)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(129, 22)
        Me.txtDni.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "DNI"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(70, 151)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(130, 22)
        Me.txtDireccion.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Direccion"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(70, 93)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(130, 22)
        Me.txtApellidos.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Telefono"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(68, 56)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(132, 22)
        Me.txtNombres.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Apellidos"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(70, 123)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(130, 22)
        Me.txtTelefono.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Nombres"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(58, 23)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(142, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Codigo"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.lvFarmaceutico2)
        Me.TabPage2.Controls.Add(Me.txtBuscarFarmaceutico)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(728, 466)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BusquedaFarmaceutico"
        '
        'lvFarmaceutico2
        '
        Me.lvFarmaceutico2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.lvFarmaceutico2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFarmaceutico2.FullRowSelect = True
        Me.lvFarmaceutico2.GridLines = True
        Me.lvFarmaceutico2.HideSelection = False
        Me.lvFarmaceutico2.HoverSelection = True
        Me.lvFarmaceutico2.Location = New System.Drawing.Point(3, 211)
        Me.lvFarmaceutico2.Name = "lvFarmaceutico2"
        Me.lvFarmaceutico2.Size = New System.Drawing.Size(722, 133)
        Me.lvFarmaceutico2.TabIndex = 37
        Me.lvFarmaceutico2.UseCompatibleStateImageBehavior = False
        Me.lvFarmaceutico2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Apellidos"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Telefono"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Direccion"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DNI"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "FechaDeEntrada"
        Me.ColumnHeader16.Width = 100
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "FechaDeNacimineto"
        Me.ColumnHeader17.Width = 100
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Sexo"
        '
        'txtBuscarFarmaceutico
        '
        Me.txtBuscarFarmaceutico.Location = New System.Drawing.Point(263, 146)
        Me.txtBuscarFarmaceutico.Name = "txtBuscarFarmaceutico"
        Me.txtBuscarFarmaceutico.Size = New System.Drawing.Size(281, 20)
        Me.txtBuscarFarmaceutico.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 18)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Buscar Farmaceuico"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RadioNombre)
        Me.GroupBox1.Controls.Add(Me.RadioDni)
        Me.GroupBox1.Location = New System.Drawing.Point(198, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 80)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos De Busqueda"
        '
        'RadioNombre
        '
        Me.RadioNombre.AutoSize = True
        Me.RadioNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioNombre.Location = New System.Drawing.Point(188, 31)
        Me.RadioNombre.Name = "RadioNombre"
        Me.RadioNombre.Size = New System.Drawing.Size(102, 19)
        Me.RadioNombre.TabIndex = 1
        Me.RadioNombre.Text = "Por Nombre"
        Me.RadioNombre.UseVisualStyleBackColor = True
        '
        'RadioDni
        '
        Me.RadioDni.AutoSize = True
        Me.RadioDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDni.Location = New System.Drawing.Point(63, 31)
        Me.RadioDni.Name = "RadioDni"
        Me.RadioDni.Size = New System.Drawing.Size(75, 19)
        Me.RadioDni.TabIndex = 0
        Me.RadioDni.Text = "Por DNI"
        Me.RadioDni.UseVisualStyleBackColor = True
        '
        'FromFarmaceutico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(770, 600)
        Me.Name = "FromFarmaceutico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Farmaceutico"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbRegistroFarmaceutico.ResumeLayout(False)
        Me.gbRegistroFarmaceutico.PerformLayout()
        CType(Me.pbFotoFarmaceutico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSexo.ResumeLayout(False)
        Me.gbSexo.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents imagenes As ImageList
    Friend WithEvents cmdCerrar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmdEditar As Button
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gbRegistroFarmaceutico As GroupBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtBuscarFarmaceutico As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioNombre As RadioButton
    Friend WithEvents RadioDni As RadioButton
    Friend WithEvents lvFarmaceutico1 As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents gbSexo As GroupBox
    Friend WithEvents RadioFemenino As RadioButton
    Friend WithEvents RadioMasculino As RadioButton
    Friend WithEvents pbFotoFarmaceutico As PictureBox
    Friend WithEvents LnkFoto As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaDeNacimiento As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaDeEntrada As DateTimePicker
    Friend WithEvents cboAdministrador As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents lvFarmaceutico2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
End Class
