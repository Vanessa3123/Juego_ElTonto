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
        Me.btnRevolverCartas = New System.Windows.Forms.Button()
        Me.pic10 = New System.Windows.Forms.PictureBox()
        Me.grpTomarCarta = New System.Windows.Forms.GroupBox()
        Me.bntTomarCarta = New System.Windows.Forms.Button()
        Me.grpCartas = New System.Windows.Forms.GroupBox()
        Me.lblInfoNumeros2 = New System.Windows.Forms.Label()
        Me.lblInfoNumeros1 = New System.Windows.Forms.Label()
        Me.picTonto = New System.Windows.Forms.PictureBox()
        Me.btnVerTonto = New System.Windows.Forms.Button()
        Me.lblNumTonto = New System.Windows.Forms.Label()
        Me.grpTonto = New System.Windows.Forms.GroupBox()
        Me.lblInfoV2 = New System.Windows.Forms.Label()
        Me.lblCartasMano = New System.Windows.Forms.Label()
        Me.lblCartasPc = New System.Windows.Forms.Label()
        Me.txtcartasJugador1 = New System.Windows.Forms.TextBox()
        Me.txtcartasJugadorPc = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTomarCarta.SuspendLayout()
        Me.grpCartas.SuspendLayout()
        CType(Me.picTonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTonto.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.MejoresTiemposToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1487, 28)
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
        Me.pic1.Location = New System.Drawing.Point(35, 93)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(182, 172)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 1010
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.Location = New System.Drawing.Point(261, 93)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(182, 172)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 1011
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.Location = New System.Drawing.Point(512, 93)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(182, 172)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 1012
        Me.pic3.TabStop = False
        '
        'pic4
        '
        Me.pic4.Location = New System.Drawing.Point(763, 93)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(182, 172)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 1013
        Me.pic4.TabStop = False
        '
        'btnRevolverCartas
        '
        Me.btnRevolverCartas.BackColor = System.Drawing.Color.Brown
        Me.btnRevolverCartas.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevolverCartas.ForeColor = System.Drawing.Color.White
        Me.btnRevolverCartas.Location = New System.Drawing.Point(175, 647)
        Me.btnRevolverCartas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRevolverCartas.Name = "btnRevolverCartas"
        Me.btnRevolverCartas.Size = New System.Drawing.Size(214, 70)
        Me.btnRevolverCartas.TabIndex = 1018
        Me.btnRevolverCartas.Text = "Revolver Cartas"
        Me.btnRevolverCartas.UseVisualStyleBackColor = False
        Me.btnRevolverCartas.Visible = False
        '
        'pic10
        '
        Me.pic10.Location = New System.Drawing.Point(43, 21)
        Me.pic10.Name = "pic10"
        Me.pic10.Size = New System.Drawing.Size(182, 172)
        Me.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
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
        Me.bntTomarCarta.Location = New System.Drawing.Point(38, 227)
        Me.bntTomarCarta.Margin = New System.Windows.Forms.Padding(4)
        Me.bntTomarCarta.Name = "bntTomarCarta"
        Me.bntTomarCarta.Size = New System.Drawing.Size(187, 49)
        Me.bntTomarCarta.TabIndex = 1022
        Me.bntTomarCarta.Text = "Tomar Carta"
        Me.bntTomarCarta.UseVisualStyleBackColor = False
        '
        'grpCartas
        '
        Me.grpCartas.Controls.Add(Me.lblInfoNumeros2)
        Me.grpCartas.Controls.Add(Me.lblInfoNumeros1)
        Me.grpCartas.Controls.Add(Me.pic4)
        Me.grpCartas.Controls.Add(Me.pic3)
        Me.grpCartas.Controls.Add(Me.pic2)
        Me.grpCartas.Controls.Add(Me.pic1)
        Me.grpCartas.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCartas.Location = New System.Drawing.Point(27, 248)
        Me.grpCartas.Name = "grpCartas"
        Me.grpCartas.Size = New System.Drawing.Size(974, 321)
        Me.grpCartas.TabIndex = 1022
        Me.grpCartas.TabStop = False
        Me.grpCartas.Text = "Cartas"
        Me.grpCartas.Visible = False
        '
        'lblInfoNumeros2
        '
        Me.lblInfoNumeros2.AutoSize = True
        Me.lblInfoNumeros2.Location = New System.Drawing.Point(31, 577)
        Me.lblInfoNumeros2.Name = "lblInfoNumeros2"
        Me.lblInfoNumeros2.Size = New System.Drawing.Size(14, 23)
        Me.lblInfoNumeros2.TabIndex = 1021
        Me.lblInfoNumeros2.Text = "."
        '
        'lblInfoNumeros1
        '
        Me.lblInfoNumeros1.AutoSize = True
        Me.lblInfoNumeros1.Location = New System.Drawing.Point(9, 295)
        Me.lblInfoNumeros1.Name = "lblInfoNumeros1"
        Me.lblInfoNumeros1.Size = New System.Drawing.Size(68, 23)
        Me.lblInfoNumeros1.TabIndex = 1020
        Me.lblInfoNumeros1.Text = "Vector 1"
        '
        'picTonto
        '
        Me.picTonto.Image = Global.Juego_ElTonto.My.Resources.Resources.a_0
        Me.picTonto.Location = New System.Drawing.Point(29, 46)
        Me.picTonto.Name = "picTonto"
        Me.picTonto.Size = New System.Drawing.Size(195, 114)
        Me.picTonto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTonto.TabIndex = 1023
        Me.picTonto.TabStop = False
        '
        'btnVerTonto
        '
        Me.btnVerTonto.BackColor = System.Drawing.Color.Brown
        Me.btnVerTonto.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerTonto.ForeColor = System.Drawing.Color.White
        Me.btnVerTonto.Location = New System.Drawing.Point(37, 175)
        Me.btnVerTonto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVerTonto.Name = "btnVerTonto"
        Me.btnVerTonto.Size = New System.Drawing.Size(187, 49)
        Me.btnVerTonto.TabIndex = 1024
        Me.btnVerTonto.Text = "Ver Carta Tonto"
        Me.btnVerTonto.UseVisualStyleBackColor = False
        '
        'lblNumTonto
        '
        Me.lblNumTonto.AutoSize = True
        Me.lblNumTonto.Location = New System.Drawing.Point(6, 18)
        Me.lblNumTonto.Name = "lblNumTonto"
        Me.lblNumTonto.Size = New System.Drawing.Size(20, 17)
        Me.lblNumTonto.TabIndex = 1025
        Me.lblNumTonto.Text = "..."
        '
        'grpTonto
        '
        Me.grpTonto.Controls.Add(Me.btnVerTonto)
        Me.grpTonto.Controls.Add(Me.lblNumTonto)
        Me.grpTonto.Controls.Add(Me.picTonto)
        Me.grpTonto.Location = New System.Drawing.Point(1086, 472)
        Me.grpTonto.Name = "grpTonto"
        Me.grpTonto.Size = New System.Drawing.Size(244, 234)
        Me.grpTonto.TabIndex = 1026
        Me.grpTonto.TabStop = False
        Me.grpTonto.Visible = False
        '
        'lblInfoV2
        '
        Me.lblInfoV2.AutoSize = True
        Me.lblInfoV2.Location = New System.Drawing.Point(957, 55)
        Me.lblInfoV2.Name = "lblInfoV2"
        Me.lblInfoV2.Size = New System.Drawing.Size(59, 17)
        Me.lblInfoV2.TabIndex = 1027
        Me.lblInfoV2.Text = "vector 2"
        '
        'lblCartasMano
        '
        Me.lblCartasMano.AutoSize = True
        Me.lblCartasMano.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartasMano.Location = New System.Drawing.Point(473, 599)
        Me.lblCartasMano.Name = "lblCartasMano"
        Me.lblCartasMano.Size = New System.Drawing.Size(125, 23)
        Me.lblCartasMano.TabIndex = 1028
        Me.lblCartasMano.Text = "Cartas en Mano:"
        '
        'lblCartasPc
        '
        Me.lblCartasPc.AutoSize = True
        Me.lblCartasPc.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartasPc.Location = New System.Drawing.Point(473, 677)
        Me.lblCartasPc.Name = "lblCartasPc"
        Me.lblCartasPc.Size = New System.Drawing.Size(162, 23)
        Me.lblCartasPc.TabIndex = 1029
        Me.lblCartasPc.Text = "Cartas de la Maquina:"
        '
        'txtcartasJugador1
        '
        Me.txtcartasJugador1.Enabled = False
        Me.txtcartasJugador1.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcartasJugador1.Location = New System.Drawing.Point(658, 599)
        Me.txtcartasJugador1.Name = "txtcartasJugador1"
        Me.txtcartasJugador1.Size = New System.Drawing.Size(155, 28)
        Me.txtcartasJugador1.TabIndex = 1030
        '
        'txtcartasJugadorPc
        '
        Me.txtcartasJugadorPc.Enabled = False
        Me.txtcartasJugadorPc.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcartasJugadorPc.Location = New System.Drawing.Point(658, 677)
        Me.txtcartasJugadorPc.Name = "txtcartasJugadorPc"
        Me.txtcartasJugadorPc.Size = New System.Drawing.Size(155, 28)
        Me.txtcartasJugadorPc.TabIndex = 1031
        '
        'FrmBNFacil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1487, 730)
        Me.Controls.Add(Me.txtcartasJugadorPc)
        Me.Controls.Add(Me.txtcartasJugador1)
        Me.Controls.Add(Me.lblCartasPc)
        Me.Controls.Add(Me.lblCartasMano)
        Me.Controls.Add(Me.lblInfoV2)
        Me.Controls.Add(Me.grpTonto)
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
        CType(Me.pic10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTomarCarta.ResumeLayout(False)
        Me.grpCartas.ResumeLayout(False)
        Me.grpCartas.PerformLayout()
        CType(Me.picTonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTonto.ResumeLayout(False)
        Me.grpTonto.PerformLayout()
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
    Friend WithEvents btnRevolverCartas As Button
    Friend WithEvents pic10 As PictureBox
    Friend WithEvents grpTomarCarta As GroupBox
    Friend WithEvents bntTomarCarta As Button
    Friend WithEvents grpCartas As GroupBox
    Friend WithEvents lblInfoNumeros1 As Label
    Friend WithEvents lblInfoNumeros2 As Label
    Friend WithEvents picTonto As PictureBox
    Friend WithEvents btnVerTonto As Button
    Friend WithEvents lblNumTonto As Label
    Friend WithEvents grpTonto As GroupBox
    Friend WithEvents lblInfoV2 As Label
    Friend WithEvents lblCartasMano As Label
    Friend WithEvents lblCartasPc As Label
    Friend WithEvents txtcartasJugador1 As TextBox
    Friend WithEvents txtcartasJugadorPc As TextBox
End Class
