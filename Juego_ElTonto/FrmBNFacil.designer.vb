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
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.pic6 = New System.Windows.Forms.PictureBox()
        Me.pic7 = New System.Windows.Forms.PictureBox()
        Me.pic8 = New System.Windows.Forms.PictureBox()
        Me.btnRevolverCartas = New System.Windows.Forms.Button()
        Me.btnParejas = New System.Windows.Forms.Button()
        Me.pic10 = New System.Windows.Forms.PictureBox()
        Me.grpTomarCarta = New System.Windows.Forms.GroupBox()
        Me.bntTomarCarta = New System.Windows.Forms.Button()
        Me.grpCartas = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTomarCarta.SuspendLayout()
        Me.grpCartas.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.MejoresTiemposToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1487, 30)
        Me.MenuStrip1.TabIndex = 374
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'MejoresTiemposToolStripMenuItem
        '
        Me.MejoresTiemposToolStripMenuItem.Name = "MejoresTiemposToolStripMenuItem"
        Me.MejoresTiemposToolStripMenuItem.Size = New System.Drawing.Size(137, 24)
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
        Me.btnJugar.Location = New System.Drawing.Point(112, 107)
        Me.btnJugar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(413, 38)
        Me.btnJugar.TabIndex = 905
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'lblMin
        '
        Me.lblMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMin.Location = New System.Drawing.Point(644, 55)
        Me.lblMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(87, 39)
        Me.lblMin.TabIndex = 904
        Me.lblMin.Text = "00"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuarioB
        '
        Me.txtUsuarioB.Location = New System.Drawing.Point(112, 59)
        Me.txtUsuarioB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuarioB.Name = "txtUsuarioB"
        Me.txtUsuarioB.ReadOnly = True
        Me.txtUsuarioB.Size = New System.Drawing.Size(412, 22)
        Me.txtUsuarioB.TabIndex = 898
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(36, 59)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 23)
        Me.Label19.TabIndex = 897
        Me.Label19.Text = "Usuario:"
        '
        'txtcontador
        '
        Me.txtcontador.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontador.Location = New System.Drawing.Point(648, 107)
        Me.txtcontador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcontador.Name = "txtcontador"
        Me.txtcontador.ReadOnly = True
        Me.txtcontador.Size = New System.Drawing.Size(132, 29)
        Me.txtcontador.TabIndex = 1006
        Me.txtcontador.Text = "Puntos"
        '
        'btnstop
        '
        Me.btnstop.BackColor = System.Drawing.Color.Brown
        Me.btnstop.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstop.ForeColor = System.Drawing.Color.White
        Me.btnstop.Location = New System.Drawing.Point(112, 140)
        Me.btnstop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(413, 38)
        Me.btnstop.TabIndex = 1009
        Me.btnstop.Text = "Detener"
        Me.btnstop.UseVisualStyleBackColor = False
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(24, 21)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(182, 172)
        Me.pic1.TabIndex = 1010
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.Location = New System.Drawing.Point(259, 21)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(182, 172)
        Me.pic2.TabIndex = 1011
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.Location = New System.Drawing.Point(510, 21)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(182, 172)
        Me.pic3.TabIndex = 1012
        Me.pic3.TabStop = False
        '
        'pic4
        '
        Me.pic4.Location = New System.Drawing.Point(761, 21)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(182, 172)
        Me.pic4.TabIndex = 1013
        Me.pic4.TabStop = False
        '
        'pic5
        '
        Me.pic5.Location = New System.Drawing.Point(24, 244)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(182, 172)
        Me.pic5.TabIndex = 1014
        Me.pic5.TabStop = False
        '
        'pic6
        '
        Me.pic6.Location = New System.Drawing.Point(259, 244)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(182, 172)
        Me.pic6.TabIndex = 1015
        Me.pic6.TabStop = False
        '
        'pic7
        '
        Me.pic7.Location = New System.Drawing.Point(510, 244)
        Me.pic7.Name = "pic7"
        Me.pic7.Size = New System.Drawing.Size(182, 172)
        Me.pic7.TabIndex = 1016
        Me.pic7.TabStop = False
        '
        'pic8
        '
        Me.pic8.Location = New System.Drawing.Point(761, 244)
        Me.pic8.Name = "pic8"
        Me.pic8.Size = New System.Drawing.Size(182, 172)
        Me.pic8.TabIndex = 1017
        Me.pic8.TabStop = False
        '
        'btnRevolverCartas
        '
        Me.btnRevolverCartas.BackColor = System.Drawing.Color.Brown
        Me.btnRevolverCartas.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevolverCartas.ForeColor = System.Drawing.Color.White
        Me.btnRevolverCartas.Location = New System.Drawing.Point(1093, 527)
        Me.btnRevolverCartas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRevolverCartas.Name = "btnRevolverCartas"
        Me.btnRevolverCartas.Size = New System.Drawing.Size(214, 70)
        Me.btnRevolverCartas.TabIndex = 1018
        Me.btnRevolverCartas.Text = "Revolver Cartas"
        Me.btnRevolverCartas.UseVisualStyleBackColor = False
        '
        'btnParejas
        '
        Me.btnParejas.BackColor = System.Drawing.Color.Brown
        Me.btnParejas.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParejas.ForeColor = System.Drawing.Color.White
        Me.btnParejas.Location = New System.Drawing.Point(372, 442)
        Me.btnParejas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnParejas.Name = "btnParejas"
        Me.btnParejas.Size = New System.Drawing.Size(214, 54)
        Me.btnParejas.TabIndex = 1019
        Me.btnParejas.Text = "Hacer Parejas"
        Me.btnParejas.UseVisualStyleBackColor = False
        '
        'pic10
        '
        Me.pic10.Location = New System.Drawing.Point(43, 21)
        Me.pic10.Name = "pic10"
        Me.pic10.Size = New System.Drawing.Size(182, 172)
        Me.pic10.TabIndex = 1020
        Me.pic10.TabStop = False
        '
        'grpTomarCarta
        '
        Me.grpTomarCarta.Controls.Add(Me.bntTomarCarta)
        Me.grpTomarCarta.Controls.Add(Me.pic10)
        Me.grpTomarCarta.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTomarCarta.Location = New System.Drawing.Point(1072, 62)
        Me.grpTomarCarta.Name = "grpTomarCarta"
        Me.grpTomarCarta.Size = New System.Drawing.Size(248, 351)
        Me.grpTomarCarta.TabIndex = 1021
        Me.grpTomarCarta.TabStop = False
        Me.grpTomarCarta.Text = "Tomar Carta del Oponente"
        Me.grpTomarCarta.Visible = False
        '
        'bntTomarCarta
        '
        Me.bntTomarCarta.BackColor = System.Drawing.Color.Brown
        Me.bntTomarCarta.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntTomarCarta.ForeColor = System.Drawing.Color.White
        Me.bntTomarCarta.Location = New System.Drawing.Point(38, 263)
        Me.bntTomarCarta.Margin = New System.Windows.Forms.Padding(4)
        Me.bntTomarCarta.Name = "bntTomarCarta"
        Me.bntTomarCarta.Size = New System.Drawing.Size(187, 49)
        Me.bntTomarCarta.TabIndex = 1022
        Me.bntTomarCarta.Text = "Revolver Cartas"
        Me.bntTomarCarta.UseVisualStyleBackColor = False
        '
        'grpCartas
        '
        Me.grpCartas.Controls.Add(Me.pic8)
        Me.grpCartas.Controls.Add(Me.pic7)
        Me.grpCartas.Controls.Add(Me.btnParejas)
        Me.grpCartas.Controls.Add(Me.pic6)
        Me.grpCartas.Controls.Add(Me.pic5)
        Me.grpCartas.Controls.Add(Me.pic4)
        Me.grpCartas.Controls.Add(Me.pic3)
        Me.grpCartas.Controls.Add(Me.pic2)
        Me.grpCartas.Controls.Add(Me.pic1)
        Me.grpCartas.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCartas.Location = New System.Drawing.Point(2, 181)
        Me.grpCartas.Name = "grpCartas"
        Me.grpCartas.Size = New System.Drawing.Size(974, 503)
        Me.grpCartas.TabIndex = 1022
        Me.grpCartas.TabStop = False
        Me.grpCartas.Text = "Cartas"
        Me.grpCartas.Visible = False
        '
        'FrmBNFacil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1487, 714)
        Me.Controls.Add(Me.grpCartas)
        Me.Controls.Add(Me.grpTomarCarta)
        Me.Controls.Add(Me.btnRevolverCartas)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.txtcontador)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.txtUsuarioB)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmBNFacil"
        Me.Text = "Nivel Facil Batalla Naval"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTomarCarta.ResumeLayout(False)
        Me.grpCartas.ResumeLayout(False)
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
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents pic5 As PictureBox
    Friend WithEvents pic6 As PictureBox
    Friend WithEvents pic7 As PictureBox
    Friend WithEvents pic8 As PictureBox
    Friend WithEvents btnRevolverCartas As Button
    Friend WithEvents btnParejas As Button
    Friend WithEvents pic10 As PictureBox
    Friend WithEvents grpTomarCarta As GroupBox
    Friend WithEvents bntTomarCarta As Button
    Friend WithEvents grpCartas As GroupBox
End Class
