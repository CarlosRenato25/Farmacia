<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FromPrecentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromPrecentacion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvPrecentacion1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdcerrar = New System.Windows.Forms.Button()
        Me.Imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdcancelar = New System.Windows.Forms.Button()
        Me.cmdeliminar = New System.Windows.Forms.Button()
        Me.cmdeditar = New System.Windows.Forms.Button()
        Me.cmdagregar = New System.Windows.Forms.Button()
        Me.gbPrecentaciones = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.DescripcionPrecentacion = New System.Windows.Forms.Label()
        Me.Precentacion = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvPresentacion2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BuscarPrecentaciones = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioDescripcion = New System.Windows.Forms.RadioButton()
        Me.RadioNombre = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbPrecentaciones.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(584, 59)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = " "
        Me.Label1.Text = "Precentaciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 62)
        Me.TabControl1.MinimumSize = New System.Drawing.Size(500, 400)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(500, 400)
        Me.TabControl1.TabIndex = 28
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lvPrecentacion1)
        Me.TabPage1.Controls.Add(Me.cmdcerrar)
        Me.TabPage1.Controls.Add(Me.cmdcancelar)
        Me.TabPage1.Controls.Add(Me.cmdeliminar)
        Me.TabPage1.Controls.Add(Me.cmdeditar)
        Me.TabPage1.Controls.Add(Me.cmdagregar)
        Me.TabPage1.Controls.Add(Me.gbPrecentaciones)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(492, 374)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Precentacion"
        '
        'lvPrecentacion1
        '
        Me.lvPrecentacion1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvPrecentacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvPrecentacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPrecentacion1.FullRowSelect = True
        Me.lvPrecentacion1.GridLines = True
        Me.lvPrecentacion1.HideSelection = False
        Me.lvPrecentacion1.Location = New System.Drawing.Point(3, 274)
        Me.lvPrecentacion1.Name = "lvPrecentacion1"
        Me.lvPrecentacion1.Size = New System.Drawing.Size(486, 97)
        Me.lvPrecentacion1.TabIndex = 30
        Me.lvPrecentacion1.UseCompatibleStateImageBehavior = False
        Me.lvPrecentacion1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Codigo"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nombre"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Descripcion"
        Me.ColumnHeader7.Width = 150
        '
        'cmdcerrar
        '
        Me.cmdcerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdcerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcerrar.ImageKey = "cerrar.png"
        Me.cmdcerrar.ImageList = Me.Imagenes
        Me.cmdcerrar.Location = New System.Drawing.Point(336, 94)
        Me.cmdcerrar.Name = "cmdcerrar"
        Me.cmdcerrar.Size = New System.Drawing.Size(119, 35)
        Me.cmdcerrar.TabIndex = 29
        Me.cmdcerrar.Text = "Cerrar"
        Me.cmdcerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdcerrar.UseVisualStyleBackColor = True
        '
        'Imagenes
        '
        Me.Imagenes.ImageStream = CType(resources.GetObject("Imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.Imagenes.Images.SetKeyName(0, "agregar.png")
        Me.Imagenes.Images.SetKeyName(1, "cancelar.png")
        Me.Imagenes.Images.SetKeyName(2, "cerrar.png")
        Me.Imagenes.Images.SetKeyName(3, "editar.png")
        Me.Imagenes.Images.SetKeyName(4, "eliminar.png")
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdcancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancelar.ImageKey = "cancelar.png"
        Me.cmdcancelar.ImageList = Me.Imagenes
        Me.cmdcancelar.Location = New System.Drawing.Point(336, 52)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(119, 36)
        Me.cmdcancelar.TabIndex = 28
        Me.cmdcancelar.Text = "Cancelar"
        Me.cmdcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdcancelar.UseVisualStyleBackColor = True
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdeliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdeliminar.ImageKey = "eliminar.png"
        Me.cmdeliminar.ImageList = Me.Imagenes
        Me.cmdeliminar.Location = New System.Drawing.Point(336, 6)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(119, 39)
        Me.cmdeliminar.TabIndex = 27
        Me.cmdeliminar.Text = "Eliminar"
        Me.cmdeliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdeliminar.UseVisualStyleBackColor = True
        '
        'cmdeditar
        '
        Me.cmdeditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdeditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdeditar.ImageKey = "editar.png"
        Me.cmdeditar.ImageList = Me.Imagenes
        Me.cmdeditar.Location = New System.Drawing.Point(336, 135)
        Me.cmdeditar.Name = "cmdeditar"
        Me.cmdeditar.Size = New System.Drawing.Size(119, 33)
        Me.cmdeditar.TabIndex = 26
        Me.cmdeditar.Text = "Editar"
        Me.cmdeditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdeditar.UseVisualStyleBackColor = True
        '
        'cmdagregar
        '
        Me.cmdagregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdagregar.ImageKey = "agregar.png"
        Me.cmdagregar.ImageList = Me.Imagenes
        Me.cmdagregar.Location = New System.Drawing.Point(336, 174)
        Me.cmdagregar.Name = "cmdagregar"
        Me.cmdagregar.Size = New System.Drawing.Size(119, 33)
        Me.cmdagregar.TabIndex = 25
        Me.cmdagregar.Text = "Agregar"
        Me.cmdagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdagregar.UseVisualStyleBackColor = True
        '
        'gbPrecentaciones
        '
        Me.gbPrecentaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbPrecentaciones.Controls.Add(Me.txtNombre)
        Me.gbPrecentaciones.Controls.Add(Me.Label2)
        Me.gbPrecentaciones.Controls.Add(Me.txtDescripcion)
        Me.gbPrecentaciones.Controls.Add(Me.txtCodigo)
        Me.gbPrecentaciones.Controls.Add(Me.DescripcionPrecentacion)
        Me.gbPrecentaciones.Controls.Add(Me.Precentacion)
        Me.gbPrecentaciones.Location = New System.Drawing.Point(6, 6)
        Me.gbPrecentaciones.Name = "gbPrecentaciones"
        Me.gbPrecentaciones.Size = New System.Drawing.Size(304, 186)
        Me.gbPrecentaciones.TabIndex = 1
        Me.gbPrecentaciones.TabStop = False
        Me.gbPrecentaciones.Text = "Registro"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(67, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(75, 111)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(67, 39)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'DescripcionPrecentacion
        '
        Me.DescripcionPrecentacion.AutoSize = True
        Me.DescripcionPrecentacion.Location = New System.Drawing.Point(6, 111)
        Me.DescripcionPrecentacion.Name = "DescripcionPrecentacion"
        Me.DescripcionPrecentacion.Size = New System.Drawing.Size(63, 13)
        Me.DescripcionPrecentacion.TabIndex = 1
        Me.DescripcionPrecentacion.Text = "Descripcion"
        '
        'Precentacion
        '
        Me.Precentacion.AutoSize = True
        Me.Precentacion.Location = New System.Drawing.Point(6, 39)
        Me.Precentacion.Name = "Precentacion"
        Me.Precentacion.Size = New System.Drawing.Size(40, 13)
        Me.Precentacion.TabIndex = 0
        Me.Precentacion.Text = "Codigo"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.lvPresentacion2)
        Me.TabPage2.Controls.Add(Me.BuscarPrecentaciones)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(492, 374)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Buscar Precentacion"
        '
        'lvPresentacion2
        '
        Me.lvPresentacion2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvPresentacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPresentacion2.FullRowSelect = True
        Me.lvPresentacion2.GridLines = True
        Me.lvPresentacion2.HideSelection = False
        Me.lvPresentacion2.Location = New System.Drawing.Point(3, 152)
        Me.lvPresentacion2.Name = "lvPresentacion2"
        Me.lvPresentacion2.Size = New System.Drawing.Size(486, 97)
        Me.lvPresentacion2.TabIndex = 38
        Me.lvPresentacion2.UseCompatibleStateImageBehavior = False
        Me.lvPresentacion2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Descripcion"
        Me.ColumnHeader3.Width = 150
        '
        'BuscarPrecentaciones
        '
        Me.BuscarPrecentaciones.Location = New System.Drawing.Point(174, 112)
        Me.BuscarPrecentaciones.Name = "BuscarPrecentaciones"
        Me.BuscarPrecentaciones.Size = New System.Drawing.Size(199, 20)
        Me.BuscarPrecentaciones.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 18)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Buscar Precentaciones"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioDescripcion)
        Me.GroupBox1.Controls.Add(Me.RadioNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 80)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos De Busqueda"
        '
        'RadioDescripcion
        '
        Me.RadioDescripcion.AutoSize = True
        Me.RadioDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDescripcion.Location = New System.Drawing.Point(188, 31)
        Me.RadioDescripcion.Name = "RadioDescripcion"
        Me.RadioDescripcion.Size = New System.Drawing.Size(127, 19)
        Me.RadioDescripcion.TabIndex = 1
        Me.RadioDescripcion.Text = "Por Descripcion"
        Me.RadioDescripcion.UseVisualStyleBackColor = True
        '
        'RadioNombre
        '
        Me.RadioNombre.AutoSize = True
        Me.RadioNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioNombre.Location = New System.Drawing.Point(63, 31)
        Me.RadioNombre.Name = "RadioNombre"
        Me.RadioNombre.Size = New System.Drawing.Size(102, 19)
        Me.RadioNombre.TabIndex = 0
        Me.RadioNombre.Text = "Por Nombre"
        Me.RadioNombre.UseVisualStyleBackColor = True
        '
        'FromPrecentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(600, 500)
        Me.Name = "FromPrecentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FromPrecentacion"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbPrecentaciones.ResumeLayout(False)
        Me.gbPrecentaciones.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gbPrecentaciones As GroupBox
    Friend WithEvents DescripcionPrecentacion As Label
    Friend WithEvents Precentacion As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents cmdcancelar As Button
    Friend WithEvents cmdeliminar As Button
    Friend WithEvents cmdeditar As Button
    Friend WithEvents cmdagregar As Button
    Friend WithEvents cmdcerrar As Button
    Friend WithEvents Imagenes As ImageList
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioDescripcion As RadioButton
    Friend WithEvents RadioNombre As RadioButton
    Friend WithEvents BuscarPrecentaciones As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lvPrecentacion1 As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lvPresentacion2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
