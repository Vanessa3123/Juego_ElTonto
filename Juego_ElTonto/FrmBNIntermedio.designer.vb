<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBNIntermedio
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
        Me.txtUsuarioB = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TiempoInt = New System.Windows.Forms.Timer(Me.components)
        Me.lblMin = New System.Windows.Forms.Label()
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.lblPuntos = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1052, 28)
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
        'txtUsuarioB
        '
        Me.txtUsuarioB.Location = New System.Drawing.Point(73, 49)
        Me.txtUsuarioB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsuarioB.Name = "txtUsuarioB"
        Me.txtUsuarioB.ReadOnly = True
        Me.txtUsuarioB.Size = New System.Drawing.Size(310, 21)
        Me.txtUsuarioB.TabIndex = 683
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 20)
        Me.Label19.TabIndex = 678
        Me.Label19.Text = "Usuario:"
        '
        'TiempoInt
        '
        '
        'lblMin
        '
        Me.lblMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMin.Location = New System.Drawing.Point(457, 46)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(100, 39)
        Me.lblMin.TabIndex = 893
        Me.lblMin.Text = "00"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnJugar
        '
        Me.btnJugar.BackColor = System.Drawing.Color.Brown
        Me.btnJugar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJugar.ForeColor = System.Drawing.Color.White
        Me.btnJugar.Location = New System.Drawing.Point(61, 97)
        Me.btnJugar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(310, 28)
        Me.btnJugar.TabIndex = 895
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'lblPuntos
        '
        Me.lblPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntos.Location = New System.Drawing.Point(454, 97)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(103, 28)
        Me.lblPuntos.TabIndex = 1204
        Me.lblPuntos.Text = "Puntos"
        '
        'btnstop
        '
        Me.btnstop.BackColor = System.Drawing.Color.Brown
        Me.btnstop.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstop.ForeColor = System.Drawing.Color.White
        Me.btnstop.Location = New System.Drawing.Point(61, 123)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(310, 31)
        Me.btnstop.TabIndex = 1206
        Me.btnstop.Text = "Detener"
        Me.btnstop.UseVisualStyleBackColor = False
        '
        'FrmBNIntermedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1052, 697)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtUsuarioB)
        Me.Controls.Add(Me.Label19)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmBNIntermedio"
        Me.Text = "FrmBNIntermediovb"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MejoresTiemposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtUsuarioB As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TiempoInt As Timer
    Friend WithEvents lblMin As Label
    Friend WithEvents btnJugar As Button
    Friend WithEvents lblPuntos As Label
    Friend WithEvents btnstop As Button
End Class
