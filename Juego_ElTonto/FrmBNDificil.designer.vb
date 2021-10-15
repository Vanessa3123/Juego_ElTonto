<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBNDificil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MejoresTiemposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.txtUsuarioB = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tiempoDif = New System.Windows.Forms.Timer(Me.components)
        Me.lblI = New System.Windows.Forms.Label()
        Me.lblPuntosDi = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.MejoresTiemposToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1061, 28)
        Me.MenuStrip1.TabIndex = 684
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'MejoresTiemposToolStripMenuItem
        '
        Me.MejoresTiemposToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MejoresTiemposToolStripMenuItem.Name = "MejoresTiemposToolStripMenuItem"
        Me.MejoresTiemposToolStripMenuItem.Size = New System.Drawing.Size(115, 24)
        Me.MejoresTiemposToolStripMenuItem.Text = "Mejores Tiempos"
        '
        'btnJugar
        '
        Me.btnJugar.BackColor = System.Drawing.Color.Firebrick
        Me.btnJugar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJugar.ForeColor = System.Drawing.Color.White
        Me.btnJugar.Location = New System.Drawing.Point(70, 107)
        Me.btnJugar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(310, 30)
        Me.btnJugar.TabIndex = 915
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'lblMin
        '
        Me.lblMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMin.Location = New System.Drawing.Point(465, 53)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(91, 39)
        Me.lblMin.TabIndex = 914
        Me.lblMin.Text = "00"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuarioB
        '
        Me.txtUsuarioB.Location = New System.Drawing.Point(70, 56)
        Me.txtUsuarioB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsuarioB.Name = "txtUsuarioB"
        Me.txtUsuarioB.ReadOnly = True
        Me.txtUsuarioB.Size = New System.Drawing.Size(310, 21)
        Me.txtUsuarioB.TabIndex = 908
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(9, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 20)
        Me.Label19.TabIndex = 907
        Me.Label19.Text = "Usuario:"
        '
        'tiempoDif
        '
        '
        'lblI
        '
        Me.lblI.AutoSize = True
        Me.lblI.Location = New System.Drawing.Point(19, 572)
        Me.lblI.Name = "lblI"
        Me.lblI.Size = New System.Drawing.Size(10, 16)
        Me.lblI.TabIndex = 1104
        Me.lblI.Text = "I"
        '
        'lblPuntosDi
        '
        Me.lblPuntosDi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPuntosDi.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntosDi.Location = New System.Drawing.Point(468, 107)
        Me.lblPuntosDi.Name = "lblPuntosDi"
        Me.lblPuntosDi.Size = New System.Drawing.Size(72, 27)
        Me.lblPuntosDi.TabIndex = 1204
        Me.lblPuntosDi.Text = "Puntos"
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(369, 668)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(310, 38)
        Me.btnMostrar.TabIndex = 1205
        Me.btnMostrar.Text = "Mostrar Solucion"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnstop
        '
        Me.btnstop.BackColor = System.Drawing.Color.Brown
        Me.btnstop.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstop.ForeColor = System.Drawing.Color.White
        Me.btnstop.Location = New System.Drawing.Point(69, 133)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(310, 31)
        Me.btnstop.TabIndex = 1206
        Me.btnstop.Text = "Detener"
        Me.btnstop.UseVisualStyleBackColor = False
        '
        'FrmBNDificil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1061, 657)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.lblPuntosDi)
        Me.Controls.Add(Me.lblI)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.txtUsuarioB)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmBNDificil"
        Me.Text = "Nivel Dificil"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MejoresTiemposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnJugar As Button
    Friend WithEvents lblMin As Label
    Friend WithEvents txtUsuarioB As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tiempoDif As Timer
    Friend WithEvents lblI As Label
    Friend WithEvents lblPuntosDi As Label
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnstop As Button
End Class
