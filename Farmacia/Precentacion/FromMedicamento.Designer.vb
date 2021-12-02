<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FromMedicamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromMedicamento))
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LvMedicamento1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbRegistroMedicamentos = New System.Windows.Forms.GroupBox()
        Me.cboAdministrador = New System.Windows.Forms.ComboBox()
        Me.cboPrecentaciones = New System.Windows.Forms.ComboBox()
        Me.cboCategorias = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateFechaCaducidad = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtLaboratorio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPrecioCompra = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEspecificaciones = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCitioHubicacion = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.LvMedicamento2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtBuscarMedicamentos = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioHubicacion = New System.Windows.Forms.RadioButton()
        Me.RadioNombre = New System.Windows.Forms.RadioButton()
        Me.RadioLaboratorio = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbRegistroMedicamentos.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-74, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(851, 59)
        Me.Label1.TabIndex = 4
        Me.Label1.Tag = " "
        Me.Label1.Text = "Medicamentos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.ImageKey = "cerrar.png"
        Me.cmdCerrar.ImageList = Me.imagenes
        Me.cmdCerrar.Location = New System.Drawing.Point(14, 367)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(133, 42)
        Me.cmdCerrar.TabIndex = 12
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ImageKey = "cancelar.png"
        Me.cmdCancelar.ImageList = Me.imagenes
        Me.cmdCancelar.Location = New System.Drawing.Point(164, 367)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(133, 42)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.ImageKey = "eliminar.png"
        Me.cmdEliminar.ImageList = Me.imagenes
        Me.cmdEliminar.Location = New System.Drawing.Point(305, 367)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(133, 39)
        Me.cmdEliminar.TabIndex = 10
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
        Me.cmdEditar.Location = New System.Drawing.Point(444, 367)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(133, 40)
        Me.cmdEditar.TabIndex = 9
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.ImageKey = "agregar.png"
        Me.cmdAgregar.ImageList = Me.imagenes
        Me.cmdAgregar.Location = New System.Drawing.Point(588, 365)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(133, 41)
        Me.cmdAgregar.TabIndex = 8
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(777, 602)
        Me.TabControl1.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.LvMedicamento1)
        Me.TabPage1.Controls.Add(Me.gbRegistroMedicamentos)
        Me.TabPage1.Controls.Add(Me.cmdAgregar)
        Me.TabPage1.Controls.Add(Me.cmdEditar)
        Me.TabPage1.Controls.Add(Me.cmdEliminar)
        Me.TabPage1.Controls.Add(Me.cmdCancelar)
        Me.TabPage1.Controls.Add(Me.cmdCerrar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(769, 576)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro Medicamentos"
        '
        'LvMedicamento1
        '
        Me.LvMedicamento1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19})
        Me.LvMedicamento1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LvMedicamento1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvMedicamento1.FullRowSelect = True
        Me.LvMedicamento1.GridLines = True
        Me.LvMedicamento1.HideSelection = False
        Me.LvMedicamento1.HoverSelection = True
        Me.LvMedicamento1.Location = New System.Drawing.Point(3, 423)
        Me.LvMedicamento1.Name = "LvMedicamento1"
        Me.LvMedicamento1.Size = New System.Drawing.Size(763, 150)
        Me.LvMedicamento1.TabIndex = 13
        Me.LvMedicamento1.UseCompatibleStateImageBehavior = False
        Me.LvMedicamento1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Laboratorio"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Especificaciones"
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Stock"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "PrecioCompra"
        Me.ColumnHeader15.Width = 100
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "PrecioVenta"
        Me.ColumnHeader16.Width = 100
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "CitioHubicacion"
        Me.ColumnHeader17.Width = 100
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "FechaDeEntrada"
        Me.ColumnHeader18.Width = 100
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "FechaDeCaducidad"
        Me.ColumnHeader19.Width = 100
        '
        'gbRegistroMedicamentos
        '
        Me.gbRegistroMedicamentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbRegistroMedicamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gbRegistroMedicamentos.Controls.Add(Me.cboAdministrador)
        Me.gbRegistroMedicamentos.Controls.Add(Me.cboPrecentaciones)
        Me.gbRegistroMedicamentos.Controls.Add(Me.cboCategorias)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label2)
        Me.gbRegistroMedicamentos.Controls.Add(Me.DateFechaCaducidad)
        Me.gbRegistroMedicamentos.Controls.Add(Me.DateFechaEntrada)
        Me.gbRegistroMedicamentos.Controls.Add(Me.txtStock)
        Me.gbRegistroMedicamentos.Controls.Add(Me.txtLaboratorio)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label16)
        Me.gbRegistroMedicamentos.Controls.Add(Me.txtPrecioCompra)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label17)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label18)
        Me.gbRegistroMedicamentos.Controls.Add(Me.txtEspecificaciones)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label19)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label20)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label21)
        Me.gbRegistroMedicamentos.Controls.Add(Me.txtCitioHubicacion)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label22)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label23)
        Me.gbRegistroMedicamentos.Controls.Add(Me.txtPrecioVenta)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label24)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label26)
        Me.gbRegistroMedicamentos.Controls.Add(Me.txtNombre)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label27)
        Me.gbRegistroMedicamentos.Controls.Add(Me.txtCodigo)
        Me.gbRegistroMedicamentos.Controls.Add(Me.Label28)
        Me.gbRegistroMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbRegistroMedicamentos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegistroMedicamentos.Location = New System.Drawing.Point(14, 21)
        Me.gbRegistroMedicamentos.Name = "gbRegistroMedicamentos"
        Me.gbRegistroMedicamentos.Size = New System.Drawing.Size(735, 309)
        Me.gbRegistroMedicamentos.TabIndex = 4
        Me.gbRegistroMedicamentos.TabStop = False
        Me.gbRegistroMedicamentos.Text = "Registro Medicamentos"
        '
        'cboAdministrador
        '
        Me.cboAdministrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAdministrador.FormattingEnabled = True
        Me.cboAdministrador.Location = New System.Drawing.Point(504, 129)
        Me.cboAdministrador.Name = "cboAdministrador"
        Me.cboAdministrador.Size = New System.Drawing.Size(225, 23)
        Me.cboAdministrador.Sorted = True
        Me.cboAdministrador.TabIndex = 39
        '
        'cboPrecentaciones
        '
        Me.cboPrecentaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrecentaciones.FormattingEnabled = True
        Me.cboPrecentaciones.Location = New System.Drawing.Point(504, 93)
        Me.cboPrecentaciones.Name = "cboPrecentaciones"
        Me.cboPrecentaciones.Size = New System.Drawing.Size(225, 23)
        Me.cboPrecentaciones.Sorted = True
        Me.cboPrecentaciones.TabIndex = 38
        '
        'cboCategorias
        '
        Me.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategorias.FormattingEnabled = True
        Me.cboCategorias.Location = New System.Drawing.Point(504, 55)
        Me.cboCategorias.Name = "cboCategorias"
        Me.cboCategorias.Size = New System.Drawing.Size(225, 23)
        Me.cboCategorias.Sorted = True
        Me.cboCategorias.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(403, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Presentaciones"
        '
        'DateFechaCaducidad
        '
        Me.DateFechaCaducidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaCaducidad.Location = New System.Drawing.Point(533, 237)
        Me.DateFechaCaducidad.Name = "DateFechaCaducidad"
        Me.DateFechaCaducidad.Size = New System.Drawing.Size(134, 21)
        Me.DateFechaCaducidad.TabIndex = 35
        '
        'DateFechaEntrada
        '
        Me.DateFechaEntrada.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEntrada.Location = New System.Drawing.Point(533, 199)
        Me.DateFechaEntrada.Name = "DateFechaEntrada"
        Me.DateFechaEntrada.Size = New System.Drawing.Size(130, 21)
        Me.DateFechaEntrada.TabIndex = 34
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(165, 166)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(65, 21)
        Me.txtStock.TabIndex = 33
        '
        'txtLaboratorio
        '
        Me.txtLaboratorio.Location = New System.Drawing.Point(170, 89)
        Me.txtLaboratorio.Name = "txtLaboratorio"
        Me.txtLaboratorio.Size = New System.Drawing.Size(192, 21)
        Me.txtLaboratorio.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(408, 137)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 17)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Administrador"
        '
        'txtPrecioCompra
        '
        Me.txtPrecioCompra.Location = New System.Drawing.Point(165, 204)
        Me.txtPrecioCompra.Name = "txtPrecioCompra"
        Me.txtPrecioCompra.Size = New System.Drawing.Size(65, 21)
        Me.txtPrecioCompra.TabIndex = 26
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(44, 207)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 17)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Precio  de  Compra"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(430, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 17)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Categoria"
        '
        'txtEspecificaciones
        '
        Me.txtEspecificaciones.Location = New System.Drawing.Point(165, 126)
        Me.txtEspecificaciones.Multiline = True
        Me.txtEspecificaciones.Name = "txtEspecificaciones"
        Me.txtEspecificaciones.Size = New System.Drawing.Size(197, 26)
        Me.txtEspecificaciones.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Location = New System.Drawing.Point(119, 169)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 17)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Stock"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(419, 199)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 17)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Fecha de  Entrada"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(86, 93)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 17)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Laboratorio"
        '
        'txtCitioHubicacion
        '
        Me.txtCitioHubicacion.Location = New System.Drawing.Point(166, 280)
        Me.txtCitioHubicacion.Name = "txtCitioHubicacion"
        Me.txtCitioHubicacion.Size = New System.Drawing.Size(112, 21)
        Me.txtCitioHubicacion.TabIndex = 13
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Location = New System.Drawing.Point(44, 280)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(117, 17)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Citio De hubicacion"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(403, 237)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(126, 17)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Fecha de  Caducidad"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(165, 231)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(65, 21)
        Me.txtPrecioVenta.TabIndex = 9
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(55, 231)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(101, 17)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Precio  de Venta"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(55, 129)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(106, 17)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "Especificaciones"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(165, 57)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(130, 21)
        Me.txtNombre.TabIndex = 3
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 60)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(155, 17)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Nombre Del Medicamento"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(75, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(130, 21)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.UseWaitCursor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(23, 20)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 17)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Codigo"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btnAgregar)
        Me.TabPage2.Controls.Add(Me.LvMedicamento2)
        Me.TabPage2.Controls.Add(Me.txtBuscarMedicamentos)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(769, 576)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Buscar Medicamentos"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(601, 144)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 35
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'LvMedicamento2
        '
        Me.LvMedicamento2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader20})
        Me.LvMedicamento2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvMedicamento2.FullRowSelect = True
        Me.LvMedicamento2.GridLines = True
        Me.LvMedicamento2.HideSelection = False
        Me.LvMedicamento2.HoverSelection = True
        Me.LvMedicamento2.Location = New System.Drawing.Point(3, 202)
        Me.LvMedicamento2.Name = "LvMedicamento2"
        Me.LvMedicamento2.Size = New System.Drawing.Size(763, 150)
        Me.LvMedicamento2.TabIndex = 34
        Me.LvMedicamento2.UseCompatibleStateImageBehavior = False
        Me.LvMedicamento2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Codigo"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nombre"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Laboratorio"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Especificaciones"
        Me.ColumnHeader8.Width = 180
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Stock"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "PrecioCompra"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "PrecioVenta"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "CitioHubicacion"
        Me.ColumnHeader12.Width = 100
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "FechaDeEntrada"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "FechaDeCaducidad"
        Me.ColumnHeader20.Width = 100
        '
        'txtBuscarMedicamentos
        '
        Me.txtBuscarMedicamentos.Location = New System.Drawing.Point(331, 144)
        Me.txtBuscarMedicamentos.Name = "txtBuscarMedicamentos"
        Me.txtBuscarMedicamentos.Size = New System.Drawing.Size(264, 20)
        Me.txtBuscarMedicamentos.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(157, 143)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(159, 20)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Buscar Medicamento"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.RadioHubicacion)
        Me.GroupBox2.Controls.Add(Me.RadioNombre)
        Me.GroupBox2.Controls.Add(Me.RadioLaboratorio)
        Me.GroupBox2.Location = New System.Drawing.Point(161, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(439, 76)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipos De Busqueda"
        '
        'RadioHubicacion
        '
        Me.RadioHubicacion.AutoSize = True
        Me.RadioHubicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioHubicacion.Location = New System.Drawing.Point(261, 26)
        Me.RadioHubicacion.Name = "RadioHubicacion"
        Me.RadioHubicacion.Size = New System.Drawing.Size(156, 19)
        Me.RadioHubicacion.TabIndex = 2
        Me.RadioHubicacion.TabStop = True
        Me.RadioHubicacion.Text = "Por Citio Hubicacion"
        Me.RadioHubicacion.UseVisualStyleBackColor = True
        '
        'RadioNombre
        '
        Me.RadioNombre.AutoSize = True
        Me.RadioNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioNombre.Location = New System.Drawing.Point(6, 26)
        Me.RadioNombre.Name = "RadioNombre"
        Me.RadioNombre.Size = New System.Drawing.Size(102, 19)
        Me.RadioNombre.TabIndex = 1
        Me.RadioNombre.TabStop = True
        Me.RadioNombre.Text = "Por Nombre"
        Me.RadioNombre.UseVisualStyleBackColor = True
        '
        'RadioLaboratorio
        '
        Me.RadioLaboratorio.AutoSize = True
        Me.RadioLaboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioLaboratorio.Location = New System.Drawing.Point(114, 26)
        Me.RadioLaboratorio.Name = "RadioLaboratorio"
        Me.RadioLaboratorio.Size = New System.Drawing.Size(125, 19)
        Me.RadioLaboratorio.TabIndex = 0
        Me.RadioLaboratorio.TabStop = True
        Me.RadioLaboratorio.Text = "Por Laboratorio"
        Me.RadioLaboratorio.UseVisualStyleBackColor = True
        '
        'FromMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(777, 663)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(740, 500)
        Me.Name = "FromMedicamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicamento"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbRegistroMedicamentos.ResumeLayout(False)
        Me.gbRegistroMedicamentos.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imagenes As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdCerrar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmdEditar As Button
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LvMedicamento1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPrecioCompra As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEspecificaciones As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtCitioHubicacion As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DateFechaCaducidad As DateTimePicker
    Friend WithEvents DateFechaEntrada As DateTimePicker
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtLaboratorio As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboAdministrador As ComboBox
    Friend WithEvents cboPrecentaciones As ComboBox
    Friend WithEvents cboCategorias As ComboBox
    Friend WithEvents txtBuscarMedicamentos As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioHubicacion As RadioButton
    Friend WithEvents RadioNombre As RadioButton
    Friend WithEvents RadioLaboratorio As RadioButton
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents LvMedicamento2 As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Private WithEvents gbRegistroMedicamentos As GroupBox
    Friend WithEvents btnAgregar As Button
End Class
