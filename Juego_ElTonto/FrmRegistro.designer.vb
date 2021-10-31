<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblNiveles = New System.Windows.Forms.Label()
        Me.btnAvanzado = New System.Windows.Forms.Button()
        Me.btnIntermedio = New System.Windows.Forms.Button()
        Me.btnFacil = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNiveles
        '
        Me.lblNiveles.BackColor = System.Drawing.Color.Brown
        Me.lblNiveles.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNiveles.ForeColor = System.Drawing.Color.White
        Me.lblNiveles.Location = New System.Drawing.Point(40, 139)
        Me.lblNiveles.Name = "lblNiveles"
        Me.lblNiveles.Size = New System.Drawing.Size(93, 20)
        Me.lblNiveles.TabIndex = 20
        Me.lblNiveles.Text = "Niveles:"
        Me.lblNiveles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAvanzado
        '
        Me.btnAvanzado.BackColor = System.Drawing.Color.Tomato
        Me.btnAvanzado.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvanzado.Location = New System.Drawing.Point(161, 237)
        Me.btnAvanzado.Name = "btnAvanzado"
        Me.btnAvanzado.Size = New System.Drawing.Size(137, 32)
        Me.btnAvanzado.TabIndex = 19
        Me.btnAvanzado.Text = "Avanzado"
        Me.btnAvanzado.UseVisualStyleBackColor = False
        '
        'btnIntermedio
        '
        Me.btnIntermedio.BackColor = System.Drawing.Color.Tomato
        Me.btnIntermedio.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntermedio.Location = New System.Drawing.Point(161, 188)
        Me.btnIntermedio.Name = "btnIntermedio"
        Me.btnIntermedio.Size = New System.Drawing.Size(137, 30)
        Me.btnIntermedio.TabIndex = 18
        Me.btnIntermedio.Text = "Intermedio"
        Me.btnIntermedio.UseVisualStyleBackColor = False
        '
        'btnFacil
        '
        Me.btnFacil.BackColor = System.Drawing.Color.Tomato
        Me.btnFacil.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacil.Location = New System.Drawing.Point(161, 138)
        Me.btnFacil.Name = "btnFacil"
        Me.btnFacil.Size = New System.Drawing.Size(137, 32)
        Me.btnFacil.TabIndex = 17
        Me.btnFacil.Text = "Facil"
        Me.btnFacil.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(161, 83)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(137, 25)
        Me.txtUsuario.TabIndex = 14
        '
        'lblUsuario
        '
        Me.lblUsuario.BackColor = System.Drawing.Color.Brown
        Me.lblUsuario.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(40, 82)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(93, 20)
        Me.lblUsuario.TabIndex = 13
        Me.lblUsuario.Text = "Usuario:"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(161, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(137, 25)
        Me.txtNombre.TabIndex = 12
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.Brown
        Me.lblNombre.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(40, 42)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(93, 20)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(497, 391)
        Me.Controls.Add(Me.lblNiveles)
        Me.Controls.Add(Me.btnAvanzado)
        Me.Controls.Add(Me.btnIntermedio)
        Me.Controls.Add(Me.btnFacil)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FrmRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresa tus Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNiveles As Label
    Friend WithEvents btnAvanzado As Button
    Friend WithEvents btnIntermedio As Button
    Friend WithEvents btnFacil As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
End Class
