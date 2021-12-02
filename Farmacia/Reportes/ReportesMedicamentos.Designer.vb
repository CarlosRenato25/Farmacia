<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesMedicamentos
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
        Me.crvListaMedicamentos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvListaMedicamentos
        '
        Me.crvListaMedicamentos.ActiveViewIndex = -1
        Me.crvListaMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvListaMedicamentos.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvListaMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvListaMedicamentos.Location = New System.Drawing.Point(0, 0)
        Me.crvListaMedicamentos.Name = "crvListaMedicamentos"
        Me.crvListaMedicamentos.Size = New System.Drawing.Size(800, 380)
        Me.crvListaMedicamentos.TabIndex = 0
        '
        'ReportesMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 380)
        Me.Controls.Add(Me.crvListaMedicamentos)
        Me.Name = "ReportesMedicamentos"
        Me.Text = "ReportesMedicamentos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvListaMedicamentos As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
