<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FromCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromCategoria))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FromCategorias = New System.Windows.Forms.TabControl()
        Me.tbRegistro = New System.Windows.Forms.TabPage()
        Me.lvcategoria = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.Imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdElminar = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.gbRegistro = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcionCategoria = New System.Windows.Forms.TextBox()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.tbBuscarCategoria = New System.Windows.Forms.TabPage()
        Me.lvCategorias = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtBsucarCategorias = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tipBusqueda = New System.Windows.Forms.GroupBox()
        Me.RadDescripcion = New System.Windows.Forms.RadioButton()
        Me.RadNombre = New System.Windows.Forms.RadioButton()
        Me.FromCategorias.SuspendLayout()
        Me.tbRegistro.SuspendLayout()
        Me.gbRegistro.SuspendLayout()
        Me.tbBuscarCategoria.SuspendLayout()
        Me.tipBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(554, 59)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = " "
        Me.Label1.Text = "Categorias"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FromCategorias
        '
        Me.FromCategorias.Controls.Add(Me.tbRegistro)
        Me.FromCategorias.Controls.Add(Me.tbBuscarCategoria)
        Me.FromCategorias.Location = New System.Drawing.Point(12, 62)
        Me.FromCategorias.MinimumSize = New System.Drawing.Size(500, 400)
        Me.FromCategorias.Name = "FromCategorias"
        Me.FromCategorias.SelectedIndex = 0
        Me.FromCategorias.Size = New System.Drawing.Size(542, 403)
        Me.FromCategorias.TabIndex = 28
        '
        'tbRegistro
        '
        Me.tbRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRegistro.Controls.Add(Me.lvcategoria)
        Me.tbRegistro.Controls.Add(Me.cmdCerrar)
        Me.tbRegistro.Controls.Add(Me.cmdCancelar)
        Me.tbRegistro.Controls.Add(Me.cmdElminar)
        Me.tbRegistro.Controls.Add(Me.cmdEditar)
        Me.tbRegistro.Controls.Add(Me.cmdAgregar)
        Me.tbRegistro.Controls.Add(Me.gbRegistro)
        Me.tbRegistro.Location = New System.Drawing.Point(4, 22)
        Me.tbRegistro.Name = "tbRegistro"
        Me.tbRegistro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRegistro.Size = New System.Drawing.Size(534, 377)
        Me.tbRegistro.TabIndex = 0
        Me.tbRegistro.Text = "Resgistro Categoria"
        '
        'lvcategoria
        '
        Me.lvcategoria.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvcategoria.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvcategoria.FullRowSelect = True
        Me.lvcategoria.GridLines = True
        Me.lvcategoria.HideSelection = False
        Me.lvcategoria.Location = New System.Drawing.Point(3, 277)
        Me.lvcategoria.Name = "lvcategoria"
        Me.lvcategoria.Size = New System.Drawing.Size(528, 97)
        Me.lvcategoria.TabIndex = 36
        Me.lvcategoria.UseCompatibleStateImageBehavior = False
        Me.lvcategoria.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Codigo"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Nombres"
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Descripcion"
        Me.ColumnHeader9.Width = 150
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.ImageKey = "cerrar.png"
        Me.cmdCerrar.ImageList = Me.Imagenes
        Me.cmdCerrar.Location = New System.Drawing.Point(391, 94)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(119, 35)
        Me.cmdCerrar.TabIndex = 35
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'Imagenes
        '
        Me.Imagenes.ImageStream = CType(resources.GetObject("Imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.Imagenes.Images.SetKeyName(0, "agregar.png")
        Me.Imagenes.Images.SetKeyName(1, "cancelar.png")
        Me.Imagenes.Images.SetKeyName(2, "eliminar.png")
        Me.Imagenes.Images.SetKeyName(3, "cerrar.png")
        Me.Imagenes.Images.SetKeyName(4, "editar.png")
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ImageKey = "cancelar.png"
        Me.cmdCancelar.ImageList = Me.Imagenes
        Me.cmdCancelar.Location = New System.Drawing.Point(391, 52)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(119, 36)
        Me.cmdCancelar.TabIndex = 34
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdElminar
        '
        Me.cmdElminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdElminar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdElminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdElminar.ImageKey = "eliminar.png"
        Me.cmdElminar.ImageList = Me.Imagenes
        Me.cmdElminar.Location = New System.Drawing.Point(391, 6)
        Me.cmdElminar.Name = "cmdElminar"
        Me.cmdElminar.Size = New System.Drawing.Size(119, 40)
        Me.cmdElminar.TabIndex = 33
        Me.cmdElminar.Text = "Eliminar"
        Me.cmdElminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdElminar.UseVisualStyleBackColor = False
        '
        'cmdEditar
        '
        Me.cmdEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditar.ImageKey = "editar.png"
        Me.cmdEditar.ImageList = Me.Imagenes
        Me.cmdEditar.Location = New System.Drawing.Point(391, 135)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(119, 33)
        Me.cmdEditar.TabIndex = 32
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.ImageKey = "agregar.png"
        Me.cmdAgregar.ImageList = Me.Imagenes
        Me.cmdAgregar.Location = New System.Drawing.Point(391, 174)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(119, 33)
        Me.cmdAgregar.TabIndex = 31
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'gbRegistro
        '
        Me.gbRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbRegistro.Controls.Add(Me.txtCodigo)
        Me.gbRegistro.Controls.Add(Me.Label2)
        Me.gbRegistro.Controls.Add(Me.txtDescripcionCategoria)
        Me.gbRegistro.Controls.Add(Me.txtNombreCategoria)
        Me.gbRegistro.Controls.Add(Me.Descripcion)
        Me.gbRegistro.Controls.Add(Me.nombre)
        Me.gbRegistro.Location = New System.Drawing.Point(6, 21)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(304, 186)
        Me.gbRegistro.TabIndex = 30
        Me.gbRegistro.TabStop = False
        Me.gbRegistro.Text = "Registro"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(79, 31)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(149, 20)
        Me.txtCodigo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Codigo"
        '
        'txtDescripcionCategoria
        '
        Me.txtDescripcionCategoria.Location = New System.Drawing.Point(79, 88)
        Me.txtDescripcionCategoria.Name = "txtDescripcionCategoria"
        Me.txtDescripcionCategoria.Size = New System.Drawing.Size(180, 20)
        Me.txtDescripcionCategoria.TabIndex = 3
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Location = New System.Drawing.Point(79, 62)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(180, 20)
        Me.txtNombreCategoria.TabIndex = 2
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Location = New System.Drawing.Point(10, 92)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Descripcion.TabIndex = 1
        Me.Descripcion.Text = "Descripcion"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Location = New System.Drawing.Point(5, 62)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(44, 13)
        Me.nombre.TabIndex = 0
        Me.nombre.Text = "Nombre"
        '
        'tbBuscarCategoria
        '
        Me.tbBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbBuscarCategoria.Controls.Add(Me.lvCategorias)
        Me.tbBuscarCategoria.Controls.Add(Me.txtBsucarCategorias)
        Me.tbBuscarCategoria.Controls.Add(Me.Label9)
        Me.tbBuscarCategoria.Controls.Add(Me.tipBusqueda)
        Me.tbBuscarCategoria.Location = New System.Drawing.Point(4, 22)
        Me.tbBuscarCategoria.Name = "tbBuscarCategoria"
        Me.tbBuscarCategoria.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBuscarCategoria.Size = New System.Drawing.Size(534, 377)
        Me.tbBuscarCategoria.TabIndex = 1
        Me.tbBuscarCategoria.Text = "Buscar Categoria"
        '
        'lvCategorias
        '
        Me.lvCategorias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.lvCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCategorias.FullRowSelect = True
        Me.lvCategorias.GridLines = True
        Me.lvCategorias.HideSelection = False
        Me.lvCategorias.Location = New System.Drawing.Point(-4, 201)
        Me.lvCategorias.Name = "lvCategorias"
        Me.lvCategorias.Size = New System.Drawing.Size(509, 97)
        Me.lvCategorias.TabIndex = 41
        Me.lvCategorias.UseCompatibleStateImageBehavior = False
        Me.lvCategorias.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 1
        Me.ColumnHeader3.Text = "Nombre"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 2
        Me.ColumnHeader4.Text = "Descripcion"
        Me.ColumnHeader4.Width = 250
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 0
        Me.ColumnHeader6.Text = "Codigo"
        Me.ColumnHeader6.Width = 100
        '
        'txtBsucarCategorias
        '
        Me.txtBsucarCategorias.Location = New System.Drawing.Point(154, 144)
        Me.txtBsucarCategorias.Name = "txtBsucarCategorias"
        Me.txtBsucarCategorias.Size = New System.Drawing.Size(199, 20)
        Me.txtBsucarCategorias.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Buscar Categoria"
        '
        'tipBusqueda
        '
        Me.tipBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tipBusqueda.Controls.Add(Me.RadDescripcion)
        Me.tipBusqueda.Controls.Add(Me.RadNombre)
        Me.tipBusqueda.Location = New System.Drawing.Point(57, 33)
        Me.tipBusqueda.Name = "tipBusqueda"
        Me.tipBusqueda.Size = New System.Drawing.Size(336, 80)
        Me.tipBusqueda.TabIndex = 38
        Me.tipBusqueda.TabStop = False
        Me.tipBusqueda.Text = "Tipos De Busqueda"
        '
        'RadDescripcion
        '
        Me.RadDescripcion.AutoSize = True
        Me.RadDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDescripcion.Location = New System.Drawing.Point(188, 31)
        Me.RadDescripcion.Name = "RadDescripcion"
        Me.RadDescripcion.Size = New System.Drawing.Size(127, 19)
        Me.RadDescripcion.TabIndex = 1
        Me.RadDescripcion.Text = "Por Descripcion"
        Me.RadDescripcion.UseVisualStyleBackColor = True
        '
        'RadNombre
        '
        Me.RadNombre.AutoSize = True
        Me.RadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNombre.Location = New System.Drawing.Point(63, 31)
        Me.RadNombre.Name = "RadNombre"
        Me.RadNombre.Size = New System.Drawing.Size(102, 19)
        Me.RadNombre.TabIndex = 0
        Me.RadNombre.Text = "Por Nombre"
        Me.RadNombre.UseVisualStyleBackColor = True
        '
        'FromCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(554, 461)
        Me.Controls.Add(Me.FromCategorias)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(570, 500)
        Me.Name = "FromCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FromCategoria"
        Me.FromCategorias.ResumeLayout(False)
        Me.tbRegistro.ResumeLayout(False)
        Me.gbRegistro.ResumeLayout(False)
        Me.gbRegistro.PerformLayout()
        Me.tbBuscarCategoria.ResumeLayout(False)
        Me.tbBuscarCategoria.PerformLayout()
        Me.tipBusqueda.ResumeLayout(False)
        Me.tipBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FromCategorias As TabControl
    Friend WithEvents tbRegistro As TabPage
    Friend WithEvents tbBuscarCategoria As TabPage
    Friend WithEvents txtBsucarCategorias As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tipBusqueda As GroupBox
    Friend WithEvents RadDescripcion As RadioButton
    Friend WithEvents RadNombre As RadioButton
    Friend WithEvents cmdCerrar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdElminar As Button
    Friend WithEvents cmdEditar As Button
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents gbRegistro As GroupBox
    Friend WithEvents txtDescripcionCategoria As TextBox
    Friend WithEvents txtNombreCategoria As TextBox
    Friend WithEvents Descripcion As Label
    Friend WithEvents nombre As Label
    Friend WithEvents Imagenes As ImageList
    Friend WithEvents lvcategoria As ListView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lvCategorias As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
End Class
