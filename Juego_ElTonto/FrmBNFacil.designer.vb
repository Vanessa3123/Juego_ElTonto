<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBNFacil
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
        Me.tiempoFac = New System.Windows.Forms.Timer(Me.components)
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.txtUsuarioB = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtcontador = New System.Windows.Forms.TextBox()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1115, 24)
        Me.MenuStrip1.TabIndex = 374
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'MejoresTiemposToolStripMenuItem
        '
        Me.MejoresTiemposToolStripMenuItem.Name = "MejoresTiemposToolStripMenuItem"
        Me.MejoresTiemposToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.MejoresTiemposToolStripMenuItem.Text = "Mejores Tiempos"
        '
        'tiempoFac
        '
        '
        'btnJugar
        '
        Me.btnJugar.BackColor = System.Drawing.Color.Brown
        Me.btnJugar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJugar.ForeColor = System.Drawing.Color.White
        Me.btnJugar.Location = New System.Drawing.Point(84, 87)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(310, 31)
        Me.btnJugar.TabIndex = 905
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'lblMin
        '
        Me.lblMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMin.Location = New System.Drawing.Point(483, 45)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(65, 32)
        Me.lblMin.TabIndex = 904
        Me.lblMin.Text = "00"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuarioB
        '
        Me.txtUsuarioB.Location = New System.Drawing.Point(84, 48)
        Me.txtUsuarioB.Name = "txtUsuarioB"
        Me.txtUsuarioB.ReadOnly = True
        Me.txtUsuarioB.Size = New System.Drawing.Size(310, 20)
        Me.txtUsuarioB.TabIndex = 898
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(27, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 20)
        Me.Label19.TabIndex = 897
        Me.Label19.Text = "Usuario:"
        '
        'txtcontador
        '
        Me.txtcontador.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontador.Location = New System.Drawing.Point(486, 87)
        Me.txtcontador.Name = "txtcontador"
        Me.txtcontador.ReadOnly = True
        Me.txtcontador.Size = New System.Drawing.Size(100, 24)
        Me.txtcontador.TabIndex = 1006
        Me.txtcontador.Text = "Puntos"
        '
        'btnstop
        '
        Me.btnstop.BackColor = System.Drawing.Color.Brown
        Me.btnstop.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstop.ForeColor = System.Drawing.Color.White
        Me.btnstop.Location = New System.Drawing.Point(84, 114)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(310, 31)
        Me.btnstop.TabIndex = 1009
        Me.btnstop.Text = "Detener"
        Me.btnstop.UseVisualStyleBackColor = False
        '
        'FrmBNFacil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 580)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.txtcontador)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.txtUsuarioB)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmBNFacil"
        Me.Text = "Nivel Facil Batalla Naval"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MejoresTiemposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tiempoFac As Timer
    Friend WithEvents btnJugar As Button
    Friend WithEvents lblMin As Label
    Friend WithEvents txtUsuarioB As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtcontador As TextBox
    Friend WithEvents btnstop As Button
End Class
