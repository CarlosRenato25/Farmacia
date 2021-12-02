<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FromLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.cmdcancelar = New System.Windows.Forms.Button()
        Me.cmdaceptar = New System.Windows.Forms.Button()
        Me.lbincorrecto = New System.Windows.Forms.Label()
        Me.cmMostarContraseña = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(58, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "INGRESO DE FARMACIA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(58, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USUARIO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(38, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CONTRASEÑA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtContraseña
        '
        Me.txtContraseña.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContraseña.Location = New System.Drawing.Point(148, 156)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(149, 20)
        Me.txtContraseña.TabIndex = 4
        '
        'txtusuario
        '
        Me.txtusuario.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtusuario.Location = New System.Drawing.Point(143, 100)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(149, 20)
        Me.txtusuario.TabIndex = 2
        '
        'cmdcancelar
        '
        Me.cmdcancelar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdcancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancelar.Location = New System.Drawing.Point(50, 220)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(98, 35)
        Me.cmdcancelar.TabIndex = 6
        Me.cmdcancelar.Text = "Cancelar"
        Me.cmdcancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdcancelar.UseVisualStyleBackColor = False
        '
        'cmdaceptar
        '
        Me.cmdaceptar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdaceptar.Location = New System.Drawing.Point(208, 220)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.Size = New System.Drawing.Size(108, 35)
        Me.cmdaceptar.TabIndex = 7
        Me.cmdaceptar.Text = "Aceptar"
        Me.cmdaceptar.UseVisualStyleBackColor = False
        '
        'lbincorrecto
        '
        Me.lbincorrecto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbincorrecto.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbincorrecto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbincorrecto.ImageKey = "(ninguno)"
        Me.lbincorrecto.Location = New System.Drawing.Point(144, 268)
        Me.lbincorrecto.Name = "lbincorrecto"
        Me.lbincorrecto.Size = New System.Drawing.Size(196, 24)
        Me.lbincorrecto.TabIndex = 22
        Me.lbincorrecto.Text = "Usuario Incorrecto"
        Me.lbincorrecto.Visible = False
        '
        'cmMostarContraseña
        '
        Me.cmMostarContraseña.AutoSize = True
        Me.cmMostarContraseña.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmMostarContraseña.Location = New System.Drawing.Point(203, 182)
        Me.cmMostarContraseña.Name = "cmMostarContraseña"
        Me.cmMostarContraseña.Size = New System.Drawing.Size(137, 18)
        Me.cmMostarContraseña.TabIndex = 5
        Me.cmMostarContraseña.Text = "Mostrar Contraseña"
        Me.cmMostarContraseña.UseVisualStyleBackColor = True
        '
        'FromLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Farmacia.My.Resources.Resources.Usuario
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(355, 301)
        Me.Controls.Add(Me.cmMostarContraseña)
        Me.Controls.Add(Me.lbincorrecto)
        Me.Controls.Add(Me.cmdaceptar)
        Me.Controls.Add(Me.cmdcancelar)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FromLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FromLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents cmdcancelar As Button
    Friend WithEvents cmdaceptar As Button
    Friend WithEvents lbincorrecto As Label
    Friend WithEvents cmMostarContraseña As CheckBox
End Class
