<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromProveedor))
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.tabProveedor = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvProveedores = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.gbRegistroProveedor = New System.Windows.Forms.GroupBox()
        Me.cboAdministrador = New System.Windows.Forms.ComboBox()
        Me.pbFotoProveedores = New System.Windows.Forms.PictureBox()
        Me.LnkFoto = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFechaDeEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbSexo = New System.Windows.Forms.GroupBox()
        Me.radiofemenino = New System.Windows.Forms.RadioButton()
        Me.radiomasculino = New System.Windows.Forms.RadioButton()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvproveedor1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdAgregarBusqueda = New System.Windows.Forms.Button()
        Me.txtBusquedaProveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.RadNombre = New System.Windows.Forms.RadioButton()
        Me.RadDni = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabProveedor.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbRegistroProveedor.SuspendLayout()
        CType(Me.pbFotoProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSexo.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbBusqueda.SuspendLayout()
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
        'tabProveedor
        '
        Me.tabProveedor.Controls.Add(Me.TabPage1)
        Me.tabProveedor.Controls.Add(Me.TabPage2)
        Me.tabProveedor.Location = New System.Drawing.Point(0, 62)
        Me.tabProveedor.Name = "tabProveedor"
        Me.tabProveedor.SelectedIndex = 0
        Me.tabProveedor.Size = New System.Drawing.Size(730, 469)
        Me.tabProveedor.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lvProveedores)
        Me.TabPage1.Controls.Add(Me.cmdCerrar)
        Me.TabPage1.Controls.Add(Me.gbRegistroProveedor)
        Me.TabPage1.Controls.Add(Me.cmdCancelar)
        Me.TabPage1.Controls.Add(Me.cmdAgregar)
        Me.TabPage1.Controls.Add(Me.cmdEliminar)
        Me.TabPage1.Controls.Add(Me.cmdEditar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(722, 443)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "RegistroProveedores"
        '
        'lvProveedores
        '
        Me.lvProveedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvProveedores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProveedores.FullRowSelect = True
        Me.lvProveedores.GridLines = True
        Me.lvProveedores.HideSelection = False
        Me.lvProveedores.HoverSelection = True
        Me.lvProveedores.Location = New System.Drawing.Point(3, 307)
        Me.lvProveedores.Name = "lvProveedores"
        Me.lvProveedores.Size = New System.Drawing.Size(716, 133)
        Me.lvProveedores.TabIndex = 31
        Me.lvProveedores.UseCompatibleStateImageBehavior = False
        Me.lvProveedores.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Codigo"
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
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Dni"
        Me.ColumnHeader1.Width = 115
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Telefono"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FechaEntrada"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sexo"
        Me.ColumnHeader5.Width = 160
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Direccion"
        Me.ColumnHeader6.Width = 160
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.ImageKey = "cerrar.png"
        Me.cmdCerrar.ImageList = Me.imagenes
        Me.cmdCerrar.Location = New System.Drawing.Point(581, 194)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(133, 42)
        Me.cmdCerrar.TabIndex = 30
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'gbRegistroProveedor
        '
        Me.gbRegistroProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbRegistroProveedor.Controls.Add(Me.cboAdministrador)
        Me.gbRegistroProveedor.Controls.Add(Me.pbFotoProveedores)
        Me.gbRegistroProveedor.Controls.Add(Me.LnkFoto)
        Me.gbRegistroProveedor.Controls.Add(Me.Label10)
        Me.gbRegistroProveedor.Controls.Add(Me.dtpFechaDeEntrada)
        Me.gbRegistroProveedor.Controls.Add(Me.Label9)
        Me.gbRegistroProveedor.Controls.Add(Me.gbSexo)
        Me.gbRegistroProveedor.Controls.Add(Me.txtDni)
        Me.gbRegistroProveedor.Controls.Add(Me.Label8)
        Me.gbRegistroProveedor.Controls.Add(Me.txtDireccion)
        Me.gbRegistroProveedor.Controls.Add(Me.Label6)
        Me.gbRegistroProveedor.Controls.Add(Me.txtApellidos)
        Me.gbRegistroProveedor.Controls.Add(Me.Label5)
        Me.gbRegistroProveedor.Controls.Add(Me.txtNombre)
        Me.gbRegistroProveedor.Controls.Add(Me.Label4)
        Me.gbRegistroProveedor.Controls.Add(Me.txtTelefono)
        Me.gbRegistroProveedor.Controls.Add(Me.Label3)
        Me.gbRegistroProveedor.Controls.Add(Me.txtCodigo)
        Me.gbRegistroProveedor.Controls.Add(Me.Label2)
        Me.gbRegistroProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegistroProveedor.Location = New System.Drawing.Point(6, -2)
        Me.gbRegistroProveedor.Name = "gbRegistroProveedor"
        Me.gbRegistroProveedor.Size = New System.Drawing.Size(558, 294)
        Me.gbRegistroProveedor.TabIndex = 21
        Me.gbRegistroProveedor.TabStop = False
        Me.gbRegistroProveedor.Text = "Proveedor"
        '
        'cboAdministrador
        '
        Me.cboAdministrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAdministrador.FormattingEnabled = True
        Me.cboAdministrador.Location = New System.Drawing.Point(104, 234)
        Me.cboAdministrador.Name = "cboAdministrador"
        Me.cboAdministrador.Size = New System.Drawing.Size(225, 24)
        Me.cboAdministrador.Sorted = True
        Me.cboAdministrador.TabIndex = 29
        '
        'pbFotoProveedores
        '
        Me.pbFotoProveedores.BackColor = System.Drawing.SystemColors.Control
        Me.pbFotoProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFotoProveedores.Location = New System.Drawing.Point(349, 33)
        Me.pbFotoProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.pbFotoProveedores.Name = "pbFotoProveedores"
        Me.pbFotoProveedores.Size = New System.Drawing.Size(158, 138)
        Me.pbFotoProveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFotoProveedores.TabIndex = 28
        Me.pbFotoProveedores.TabStop = False
        '
        'LnkFoto
        '
        Me.LnkFoto.AutoSize = True
        Me.LnkFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkFoto.Location = New System.Drawing.Point(399, 181)
        Me.LnkFoto.Name = "LnkFoto"
        Me.LnkFoto.Size = New System.Drawing.Size(43, 18)
        Me.LnkFoto.TabIndex = 27
        Me.LnkFoto.TabStop = True
        Me.LnkFoto.Text = "Foto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "FechaDe Entrada"
        '
        'dtpFechaDeEntrada
        '
        Me.dtpFechaDeEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeEntrada.Location = New System.Drawing.Point(141, 270)
        Me.dtpFechaDeEntrada.Name = "dtpFechaDeEntrada"
        Me.dtpFechaDeEntrada.Size = New System.Drawing.Size(113, 22)
        Me.dtpFechaDeEntrada.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Administrador"
        '
        'gbSexo
        '
        Me.gbSexo.Controls.Add(Me.radiofemenino)
        Me.gbSexo.Controls.Add(Me.radiomasculino)
        Me.gbSexo.Location = New System.Drawing.Point(349, 216)
        Me.gbSexo.Margin = New System.Windows.Forms.Padding(2)
        Me.gbSexo.Name = "gbSexo"
        Me.gbSexo.Padding = New System.Windows.Forms.Padding(2)
        Me.gbSexo.Size = New System.Drawing.Size(159, 73)
        Me.gbSexo.TabIndex = 22
        Me.gbSexo.TabStop = False
        Me.gbSexo.Text = "Sexo"
        '
        'radiofemenino
        '
        Me.radiofemenino.AutoSize = True
        Me.radiofemenino.Location = New System.Drawing.Point(14, 43)
        Me.radiofemenino.Margin = New System.Windows.Forms.Padding(2)
        Me.radiofemenino.Name = "radiofemenino"
        Me.radiofemenino.Size = New System.Drawing.Size(94, 20)
        Me.radiofemenino.TabIndex = 1
        Me.radiofemenino.Text = "Femenino"
        Me.radiofemenino.UseVisualStyleBackColor = True
        '
        'radiomasculino
        '
        Me.radiomasculino.AutoSize = True
        Me.radiomasculino.Location = New System.Drawing.Point(14, 19)
        Me.radiomasculino.Margin = New System.Windows.Forms.Padding(2)
        Me.radiomasculino.Name = "radiomasculino"
        Me.radiomasculino.Size = New System.Drawing.Size(96, 20)
        Me.radiomasculino.TabIndex = 0
        Me.radiomasculino.Text = "Masculino"
        Me.radiomasculino.UseVisualStyleBackColor = True
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(119, 160)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(151, 22)
        Me.txtDni.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "DNI"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(119, 121)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(151, 22)
        Me.txtDireccion.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Direccion"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(119, 93)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(151, 22)
        Me.txtApellidos.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Apellidos"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(119, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(151, 22)
        Me.txtNombre.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(119, 193)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(150, 22)
        Me.txtTelefono.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(119, 33)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(151, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ImageKey = "cancelar.png"
        Me.cmdCancelar.ImageList = Me.imagenes
        Me.cmdCancelar.Location = New System.Drawing.Point(581, 147)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(133, 44)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.ImageKey = "agregar.png"
        Me.cmdAgregar.ImageList = Me.imagenes
        Me.cmdAgregar.Location = New System.Drawing.Point(581, 8)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(133, 45)
        Me.cmdAgregar.TabIndex = 26
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.ImageKey = "eliminar.png"
        Me.cmdEliminar.ImageList = Me.imagenes
        Me.cmdEliminar.Location = New System.Drawing.Point(583, 104)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(133, 37)
        Me.cmdEliminar.TabIndex = 28
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdEditar
        '
        Me.cmdEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditar.ImageKey = "editar.png"
        Me.cmdEditar.ImageList = Me.imagenes
        Me.cmdEditar.Location = New System.Drawing.Point(581, 59)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(133, 40)
        Me.cmdEditar.TabIndex = 27
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.lvproveedor1)
        Me.TabPage2.Controls.Add(Me.cmdAgregarBusqueda)
        Me.TabPage2.Controls.Add(Me.txtBusquedaProveedor)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.gbBusqueda)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(722, 443)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Busqueda De Proveedores"
        '
        'lvproveedor1
        '
        Me.lvproveedor1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.lvproveedor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvproveedor1.FullRowSelect = True
        Me.lvproveedor1.GridLines = True
        Me.lvproveedor1.HideSelection = False
        Me.lvproveedor1.HoverSelection = True
        Me.lvproveedor1.Location = New System.Drawing.Point(-4, 229)
        Me.lvproveedor1.Name = "lvproveedor1"
        Me.lvproveedor1.Size = New System.Drawing.Size(716, 133)
        Me.lvproveedor1.TabIndex = 35
        Me.lvproveedor1.UseCompatibleStateImageBehavior = False
        Me.lvproveedor1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Codigo"
        Me.ColumnHeader7.Width = 100
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
        Me.ColumnHeader12.Text = "Dni"
        Me.ColumnHeader12.Width = 100
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Telefono"
        Me.ColumnHeader13.Width = 90
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "FechaEntrada"
        Me.ColumnHeader14.Width = 120
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Sexo"
        Me.ColumnHeader15.Width = 160
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Direccion"
        Me.ColumnHeader16.Width = 160
        '
        'cmdAgregarBusqueda
        '
        Me.cmdAgregarBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarBusqueda.Location = New System.Drawing.Point(477, 142)
        Me.cmdAgregarBusqueda.Name = "cmdAgregarBusqueda"
        Me.cmdAgregarBusqueda.Size = New System.Drawing.Size(110, 31)
        Me.cmdAgregarBusqueda.TabIndex = 34
        Me.cmdAgregarBusqueda.Text = "Agregar"
        Me.cmdAgregarBusqueda.UseVisualStyleBackColor = True
        '
        'txtBusquedaProveedor
        '
        Me.txtBusquedaProveedor.Location = New System.Drawing.Point(233, 146)
        Me.txtBusquedaProveedor.Name = "txtBusquedaProveedor"
        Me.txtBusquedaProveedor.Size = New System.Drawing.Size(214, 20)
        Me.txtBusquedaProveedor.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(62, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Buscar Proveedor"
        '
        'gbBusqueda
        '
        Me.gbBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbBusqueda.Controls.Add(Me.RadNombre)
        Me.gbBusqueda.Controls.Add(Me.RadDni)
        Me.gbBusqueda.Location = New System.Drawing.Point(141, 28)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(375, 87)
        Me.gbBusqueda.TabIndex = 31
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Tipos De Busqueda"
        '
        'RadNombre
        '
        Me.RadNombre.AutoSize = True
        Me.RadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNombre.Location = New System.Drawing.Point(216, 31)
        Me.RadNombre.Name = "RadNombre"
        Me.RadNombre.Size = New System.Drawing.Size(102, 19)
        Me.RadNombre.TabIndex = 1
        Me.RadNombre.Text = "Por Nombre"
        Me.RadNombre.UseVisualStyleBackColor = True
        '
        'RadDni
        '
        Me.RadDni.AutoSize = True
        Me.RadDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDni.Location = New System.Drawing.Point(63, 31)
        Me.RadDni.Name = "RadDni"
        Me.RadDni.Size = New System.Drawing.Size(75, 19)
        Me.RadDni.TabIndex = 0
        Me.RadDni.Text = "Por DNI"
        Me.RadDni.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(730, 59)
        Me.Label1.TabIndex = 19
        Me.Label1.Tag = " "
        Me.Label1.Text = "Proveedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FromProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(730, 531)
        Me.Controls.Add(Me.tabProveedor)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(700, 570)
        Me.Name = "FromProveedor"
        Me.Text = "Proveedores"
        Me.tabProveedor.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbRegistroProveedor.ResumeLayout(False)
        Me.gbRegistroProveedor.PerformLayout()
        CType(Me.pbFotoProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSexo.ResumeLayout(False)
        Me.gbSexo.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imagenes As ImageList
    Friend WithEvents tabProveedor As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lvProveedores As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents cmdCerrar As Button
    Friend WithEvents gbRegistroProveedor As GroupBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmdEditar As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmdAgregarBusqueda As Button
    Friend WithEvents txtBusquedaProveedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents gbBusqueda As GroupBox
    Friend WithEvents RadNombre As RadioButton
    Friend WithEvents RadDni As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents gbSexo As GroupBox
    Friend WithEvents radiofemenino As RadioButton
    Friend WithEvents radiomasculino As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpFechaDeEntrada As DateTimePicker
    Friend WithEvents pbFotoProveedores As PictureBox
    Friend WithEvents LnkFoto As LinkLabel
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents cboAdministrador As ComboBox
    Friend WithEvents lvproveedor1 As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
End Class
