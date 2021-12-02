<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FromCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromCliente))
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvClientes = New System.Windows.Forms.ListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbRegistro = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTipodocumento = New System.Windows.Forms.ComboBox()
        Me.cbAdministrador = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.dtpFechaDeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.gbSexo = New System.Windows.Forms.GroupBox()
        Me.RadioFemenino = New System.Windows.Forms.RadioButton()
        Me.RadioMasculino = New System.Windows.Forms.RadioButton()
        Me.txtNumeroDocumento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Lvclientes1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBuscadorClientes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optNombre = New System.Windows.Forms.RadioButton()
        Me.optNumeroDocumento = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbRegistro.SuspendLayout()
        Me.gbSexo.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(768, 59)
        Me.Label1.TabIndex = 14
        Me.Label1.Tag = " "
        Me.Label1.Text = "Clientes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 62)
        Me.TabControl1.MinimumSize = New System.Drawing.Size(630, 450)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(769, 450)
        Me.TabControl1.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lvClientes)
        Me.TabPage1.Controls.Add(Me.gbRegistro)
        Me.TabPage1.Controls.Add(Me.cmdCancelar)
        Me.TabPage1.Controls.Add(Me.cmdEditar)
        Me.TabPage1.Controls.Add(Me.cmdAgregar)
        Me.TabPage1.Controls.Add(Me.cmdCerrar)
        Me.TabPage1.Controls.Add(Me.cmdEliminar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(761, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro De Clientes"
        '
        'lvClientes
        '
        Me.lvClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvClientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvClientes.FullRowSelect = True
        Me.lvClientes.GridLines = True
        Me.lvClientes.HideSelection = False
        Me.lvClientes.HoverSelection = True
        Me.lvClientes.Location = New System.Drawing.Point(3, 294)
        Me.lvClientes.Name = "lvClientes"
        Me.lvClientes.Size = New System.Drawing.Size(755, 127)
        Me.lvClientes.TabIndex = 40
        Me.lvClientes.UseCompatibleStateImageBehavior = False
        Me.lvClientes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Codigo"
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Nombre"
        Me.ColumnHeader16.Width = 134
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Tipo Documento"
        Me.ColumnHeader18.Width = 120
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Numero Documento"
        Me.ColumnHeader19.Width = 150
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Telefono"
        Me.ColumnHeader20.Width = 120
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Direccion"
        Me.ColumnHeader21.Width = 120
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "FechaNacimiento"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Sexo"
        '
        'gbRegistro
        '
        Me.gbRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbRegistro.Controls.Add(Me.Label5)
        Me.gbRegistro.Controls.Add(Me.cbTipodocumento)
        Me.gbRegistro.Controls.Add(Me.cbAdministrador)
        Me.gbRegistro.Controls.Add(Me.Label4)
        Me.gbRegistro.Controls.Add(Me.lblFechaNacimiento)
        Me.gbRegistro.Controls.Add(Me.dtpFechaDeNacimiento)
        Me.gbRegistro.Controls.Add(Me.gbSexo)
        Me.gbRegistro.Controls.Add(Me.txtNumeroDocumento)
        Me.gbRegistro.Controls.Add(Me.Label11)
        Me.gbRegistro.Controls.Add(Me.txtDireccion)
        Me.gbRegistro.Controls.Add(Me.Label12)
        Me.gbRegistro.Controls.Add(Me.txtNombre)
        Me.gbRegistro.Controls.Add(Me.Label14)
        Me.gbRegistro.Controls.Add(Me.txtTelefono)
        Me.gbRegistro.Controls.Add(Me.Label15)
        Me.gbRegistro.Controls.Add(Me.txtCodigo)
        Me.gbRegistro.Controls.Add(Me.Label16)
        Me.gbRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegistro.Location = New System.Drawing.Point(9, 18)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(570, 270)
        Me.gbRegistro.TabIndex = 32
        Me.gbRegistro.TabStop = False
        Me.gbRegistro.Text = "CLIENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Tipo Documento"
        '
        'cbTipodocumento
        '
        Me.cbTipodocumento.FormattingEnabled = True
        Me.cbTipodocumento.Items.AddRange(New Object() {"DNI", "RUC"})
        Me.cbTipodocumento.Location = New System.Drawing.Point(132, 58)
        Me.cbTipodocumento.Name = "cbTipodocumento"
        Me.cbTipodocumento.Size = New System.Drawing.Size(155, 23)
        Me.cbTipodocumento.TabIndex = 32
        '
        'cbAdministrador
        '
        Me.cbAdministrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAdministrador.FormattingEnabled = True
        Me.cbAdministrador.Location = New System.Drawing.Point(132, 198)
        Me.cbAdministrador.Name = "cbAdministrador"
        Me.cbAdministrador.Size = New System.Drawing.Size(225, 23)
        Me.cbAdministrador.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Administrador"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(309, 36)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(109, 13)
        Me.lblFechaNacimiento.TabIndex = 23
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'dtpFechaDeNacimiento
        '
        Me.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeNacimiento.Location = New System.Drawing.Point(424, 31)
        Me.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento"
        Me.dtpFechaDeNacimiento.Size = New System.Drawing.Size(125, 21)
        Me.dtpFechaDeNacimiento.TabIndex = 22
        Me.dtpFechaDeNacimiento.Value = New Date(2019, 11, 11, 17, 36, 27, 0)
        '
        'gbSexo
        '
        Me.gbSexo.Controls.Add(Me.RadioFemenino)
        Me.gbSexo.Controls.Add(Me.RadioMasculino)
        Me.gbSexo.Location = New System.Drawing.Point(370, 74)
        Me.gbSexo.Name = "gbSexo"
        Me.gbSexo.Size = New System.Drawing.Size(179, 88)
        Me.gbSexo.TabIndex = 18
        Me.gbSexo.TabStop = False
        Me.gbSexo.Text = "Sexo"
        '
        'RadioFemenino
        '
        Me.RadioFemenino.AutoSize = True
        Me.RadioFemenino.Location = New System.Drawing.Point(15, 50)
        Me.RadioFemenino.Name = "RadioFemenino"
        Me.RadioFemenino.Size = New System.Drawing.Size(89, 19)
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
        Me.RadioMasculino.Size = New System.Drawing.Size(91, 19)
        Me.RadioMasculino.TabIndex = 0
        Me.RadioMasculino.TabStop = True
        Me.RadioMasculino.Text = "Masculino"
        Me.RadioMasculino.UseVisualStyleBackColor = True
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(132, 87)
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(155, 21)
        Me.txtNumeroDocumento.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "N°Documento"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(132, 171)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(318, 21)
        Me.txtDireccion.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Direccion"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(132, 114)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(225, 21)
        Me.txtNombre.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 15)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Nombre"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(132, 144)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(225, 21)
        Me.txtTelefono.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 15)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Telefono"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(132, 31)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(155, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(14, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Codigo"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ImageKey = "cancelar.png"
        Me.cmdCancelar.ImageList = Me.imagenes
        Me.cmdCancelar.Location = New System.Drawing.Point(599, 25)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(133, 44)
        Me.cmdCancelar.TabIndex = 36
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdEditar
        '
        Me.cmdEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditar.ImageKey = "editar.png"
        Me.cmdEditar.ImageList = Me.imagenes
        Me.cmdEditar.Location = New System.Drawing.Point(599, 217)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(133, 40)
        Me.cmdEditar.TabIndex = 34
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
        Me.cmdAgregar.Location = New System.Drawing.Point(599, 75)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(133, 45)
        Me.cmdAgregar.TabIndex = 33
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.ImageKey = "cerrar.png"
        Me.cmdCerrar.ImageList = Me.imagenes
        Me.cmdCerrar.Location = New System.Drawing.Point(599, 126)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(133, 42)
        Me.cmdCerrar.TabIndex = 37
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.ImageKey = "eliminar.png"
        Me.cmdEliminar.ImageList = Me.imagenes
        Me.cmdEliminar.Location = New System.Drawing.Point(599, 174)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(133, 40)
        Me.cmdEliminar.TabIndex = 35
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.Lvclientes1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.txtBuscadorClientes)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(761, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Busqueda de clientes"
        '
        'Lvclientes1
        '
        Me.Lvclientes1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.Lvclientes1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lvclientes1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lvclientes1.FullRowSelect = True
        Me.Lvclientes1.GridLines = True
        Me.Lvclientes1.HideSelection = False
        Me.Lvclientes1.HoverSelection = True
        Me.Lvclientes1.Location = New System.Drawing.Point(3, 187)
        Me.Lvclientes1.Name = "Lvclientes1"
        Me.Lvclientes1.Size = New System.Drawing.Size(755, 234)
        Me.Lvclientes1.TabIndex = 43
        Me.Lvclientes1.UseCompatibleStateImageBehavior = False
        Me.Lvclientes1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Codigo"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nombre"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Tipo Documento"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Numero Documento"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Telefono"
        Me.ColumnHeader7.Width = 120
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Direccion"
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "FechaNacimiento"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Sexo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(485, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 31)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBuscadorClientes
        '
        Me.txtBuscadorClientes.Location = New System.Drawing.Point(198, 156)
        Me.txtBuscadorClientes.Name = "txtBuscadorClientes"
        Me.txtBuscadorClientes.Size = New System.Drawing.Size(281, 20)
        Me.txtBuscadorClientes.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Buscar Cliente"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.optNombre)
        Me.GroupBox4.Controls.Add(Me.optNumeroDocumento)
        Me.GroupBox4.Location = New System.Drawing.Point(169, 35)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(339, 80)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipos De Busqueda"
        '
        'optNombre
        '
        Me.optNombre.AutoSize = True
        Me.optNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNombre.Location = New System.Drawing.Point(198, 31)
        Me.optNombre.Name = "optNombre"
        Me.optNombre.Size = New System.Drawing.Size(102, 19)
        Me.optNombre.TabIndex = 1
        Me.optNombre.Text = "Por Nombre"
        Me.optNombre.UseVisualStyleBackColor = True
        '
        'optNumeroDocumento
        '
        Me.optNumeroDocumento.AutoSize = True
        Me.optNumeroDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNumeroDocumento.Location = New System.Drawing.Point(29, 31)
        Me.optNumeroDocumento.Name = "optNumeroDocumento"
        Me.optNumeroDocumento.Size = New System.Drawing.Size(144, 19)
        Me.optNumeroDocumento.TabIndex = 0
        Me.optNumeroDocumento.Text = "Por N° Documento"
        '
        'FromCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(768, 511)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(680, 550)
        Me.Name = "FromCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbRegistro.ResumeLayout(False)
        Me.gbRegistro.PerformLayout()
        Me.gbSexo.ResumeLayout(False)
        Me.gbSexo.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imagenes As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtBuscadorClientes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lvClientes As ListView
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents gbRegistro As GroupBox
    Friend WithEvents cbAdministrador As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents dtpFechaDeNacimiento As DateTimePicker
    Friend WithEvents gbSexo As GroupBox
    Friend WithEvents RadioFemenino As RadioButton
    Friend WithEvents RadioMasculino As RadioButton
    Friend WithEvents txtNumeroDocumento As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdEditar As Button
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents cmdCerrar As Button
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cbTipodocumento As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Lvclientes1 As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optNombre As RadioButton
    Friend WithEvents optNumeroDocumento As RadioButton
End Class
