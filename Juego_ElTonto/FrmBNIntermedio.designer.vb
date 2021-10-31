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
        Me.btnstop = New System.Windows.Forms.Button()
        Me.txtcartasJugadorPc = New System.Windows.Forms.TextBox()
        Me.txtcartasJugador1 = New System.Windows.Forms.TextBox()
        Me.lblCartasPc = New System.Windows.Forms.Label()
        Me.lblCartasMano = New System.Windows.Forms.Label()
        Me.lblInfoV2 = New System.Windows.Forms.Label()
        Me.grpTonto = New System.Windows.Forms.GroupBox()
        Me.btnVerTonto = New System.Windows.Forms.Button()
        Me.lblNumTonto = New System.Windows.Forms.Label()
        Me.picTonto = New System.Windows.Forms.PictureBox()
        Me.grpCartas = New System.Windows.Forms.GroupBox()
        Me.pic10 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic9 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic8 = New System.Windows.Forms.PictureBox()
        Me.pic12 = New System.Windows.Forms.PictureBox()
        Me.pic11 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic6 = New System.Windows.Forms.PictureBox()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.lblInfoNumeros2 = New System.Windows.Forms.Label()
        Me.lblInfoNumeros1 = New System.Windows.Forms.Label()
        Me.pic7 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.grpTomarCarta = New System.Windows.Forms.GroupBox()
        Me.bntTomarCarta = New System.Windows.Forms.Button()
        Me.picOponente = New System.Windows.Forms.PictureBox()
        Me.btnRevolverCartas = New System.Windows.Forms.Button()
        Me.grpConteo = New System.Windows.Forms.GroupBox()
        Me.btntxt = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnguardar2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grpTonto.SuspendLayout()
        CType(Me.picTonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCartas.SuspendLayout()
        CType(Me.pic10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTomarCarta.SuspendLayout()
        CType(Me.picOponente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConteo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.MejoresTiemposToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1356, 28)
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
        'txtcartasJugadorPc
        '
        Me.txtcartasJugadorPc.Enabled = False
        Me.txtcartasJugadorPc.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcartasJugadorPc.Location = New System.Drawing.Point(213, 93)
        Me.txtcartasJugadorPc.Name = "txtcartasJugadorPc"
        Me.txtcartasJugadorPc.Size = New System.Drawing.Size(155, 24)
        Me.txtcartasJugadorPc.TabIndex = 1215
        '
        'txtcartasJugador1
        '
        Me.txtcartasJugador1.Enabled = False
        Me.txtcartasJugador1.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcartasJugador1.Location = New System.Drawing.Point(213, 15)
        Me.txtcartasJugador1.Name = "txtcartasJugador1"
        Me.txtcartasJugador1.Size = New System.Drawing.Size(155, 24)
        Me.txtcartasJugador1.TabIndex = 1214
        '
        'lblCartasPc
        '
        Me.lblCartasPc.AutoSize = True
        Me.lblCartasPc.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartasPc.Location = New System.Drawing.Point(28, 93)
        Me.lblCartasPc.Name = "lblCartasPc"
        Me.lblCartasPc.Size = New System.Drawing.Size(130, 20)
        Me.lblCartasPc.TabIndex = 1213
        Me.lblCartasPc.Text = "Cartas de la Maquina:"
        '
        'lblCartasMano
        '
        Me.lblCartasMano.AutoSize = True
        Me.lblCartasMano.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartasMano.Location = New System.Drawing.Point(28, 15)
        Me.lblCartasMano.Name = "lblCartasMano"
        Me.lblCartasMano.Size = New System.Drawing.Size(100, 20)
        Me.lblCartasMano.TabIndex = 1212
        Me.lblCartasMano.Text = "Cartas en Mano:"
        '
        'lblInfoV2
        '
        Me.lblInfoV2.AutoSize = True
        Me.lblInfoV2.Location = New System.Drawing.Point(974, 106)
        Me.lblInfoV2.Name = "lblInfoV2"
        Me.lblInfoV2.Size = New System.Drawing.Size(42, 16)
        Me.lblInfoV2.TabIndex = 1211
        Me.lblInfoV2.Text = "vector 2"
        Me.lblInfoV2.Visible = False
        '
        'grpTonto
        '
        Me.grpTonto.Controls.Add(Me.btnVerTonto)
        Me.grpTonto.Controls.Add(Me.lblNumTonto)
        Me.grpTonto.Controls.Add(Me.picTonto)
        Me.grpTonto.Location = New System.Drawing.Point(1089, 532)
        Me.grpTonto.Name = "grpTonto"
        Me.grpTonto.Size = New System.Drawing.Size(244, 234)
        Me.grpTonto.TabIndex = 1210
        Me.grpTonto.TabStop = False
        Me.grpTonto.Visible = False
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
        Me.lblNumTonto.Size = New System.Drawing.Size(65, 16)
        Me.lblNumTonto.TabIndex = 1025
        Me.lblNumTonto.Text = "num del tonto"
        Me.lblNumTonto.Visible = False
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
        'grpCartas
        '
        Me.grpCartas.Controls.Add(Me.pic10)
        Me.grpCartas.Controls.Add(Me.pic4)
        Me.grpCartas.Controls.Add(Me.pic9)
        Me.grpCartas.Controls.Add(Me.pic3)
        Me.grpCartas.Controls.Add(Me.pic8)
        Me.grpCartas.Controls.Add(Me.pic12)
        Me.grpCartas.Controls.Add(Me.pic11)
        Me.grpCartas.Controls.Add(Me.pic2)
        Me.grpCartas.Controls.Add(Me.pic6)
        Me.grpCartas.Controls.Add(Me.pic5)
        Me.grpCartas.Controls.Add(Me.lblInfoNumeros2)
        Me.grpCartas.Controls.Add(Me.lblInfoNumeros1)
        Me.grpCartas.Controls.Add(Me.pic7)
        Me.grpCartas.Controls.Add(Me.pic1)
        Me.grpCartas.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCartas.Location = New System.Drawing.Point(44, 174)
        Me.grpCartas.Name = "grpCartas"
        Me.grpCartas.Size = New System.Drawing.Size(1018, 446)
        Me.grpCartas.TabIndex = 1209
        Me.grpCartas.TabStop = False
        Me.grpCartas.Text = "Cartas"
        Me.grpCartas.Visible = False
        '
        'pic10
        '
        Me.pic10.Location = New System.Drawing.Point(509, 245)
        Me.pic10.Name = "pic10"
        Me.pic10.Size = New System.Drawing.Size(152, 142)
        Me.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic10.TabIndex = 1027
        Me.pic10.TabStop = False
        '
        'pic4
        '
        Me.pic4.Location = New System.Drawing.Point(509, 34)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(152, 163)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 1026
        Me.pic4.TabStop = False
        '
        'pic9
        '
        Me.pic9.Location = New System.Drawing.Point(342, 245)
        Me.pic9.Name = "pic9"
        Me.pic9.Size = New System.Drawing.Size(152, 142)
        Me.pic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic9.TabIndex = 1025
        Me.pic9.TabStop = False
        '
        'pic3
        '
        Me.pic3.Location = New System.Drawing.Point(342, 34)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(152, 163)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 1024
        Me.pic3.TabStop = False
        '
        'pic8
        '
        Me.pic8.Location = New System.Drawing.Point(175, 245)
        Me.pic8.Name = "pic8"
        Me.pic8.Size = New System.Drawing.Size(152, 142)
        Me.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic8.TabIndex = 1023
        Me.pic8.TabStop = False
        '
        'pic12
        '
        Me.pic12.Location = New System.Drawing.Point(844, 245)
        Me.pic12.Name = "pic12"
        Me.pic12.Size = New System.Drawing.Size(152, 142)
        Me.pic12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic12.TabIndex = 1023
        Me.pic12.TabStop = False
        '
        'pic11
        '
        Me.pic11.Location = New System.Drawing.Point(676, 245)
        Me.pic11.Name = "pic11"
        Me.pic11.Size = New System.Drawing.Size(152, 142)
        Me.pic11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic11.TabIndex = 1023
        Me.pic11.TabStop = False
        '
        'pic2
        '
        Me.pic2.Location = New System.Drawing.Point(175, 34)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(152, 163)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 1022
        Me.pic2.TabStop = False
        '
        'pic6
        '
        Me.pic6.Location = New System.Drawing.Point(844, 34)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(152, 163)
        Me.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic6.TabIndex = 1022
        Me.pic6.TabStop = False
        '
        'pic5
        '
        Me.pic5.Location = New System.Drawing.Point(676, 34)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(152, 163)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic5.TabIndex = 1022
        Me.pic5.TabStop = False
        '
        'lblInfoNumeros2
        '
        Me.lblInfoNumeros2.AutoSize = True
        Me.lblInfoNumeros2.Location = New System.Drawing.Point(31, 577)
        Me.lblInfoNumeros2.Name = "lblInfoNumeros2"
        Me.lblInfoNumeros2.Size = New System.Drawing.Size(12, 20)
        Me.lblInfoNumeros2.TabIndex = 1021
        Me.lblInfoNumeros2.Text = "."
        '
        'lblInfoNumeros1
        '
        Me.lblInfoNumeros1.AutoSize = True
        Me.lblInfoNumeros1.Location = New System.Drawing.Point(9, 411)
        Me.lblInfoNumeros1.Name = "lblInfoNumeros1"
        Me.lblInfoNumeros1.Size = New System.Drawing.Size(54, 20)
        Me.lblInfoNumeros1.TabIndex = 1020
        Me.lblInfoNumeros1.Text = "Vector 1"
        Me.lblInfoNumeros1.Visible = False
        '
        'pic7
        '
        Me.pic7.Location = New System.Drawing.Point(13, 245)
        Me.pic7.Name = "pic7"
        Me.pic7.Size = New System.Drawing.Size(152, 142)
        Me.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic7.TabIndex = 1011
        Me.pic7.TabStop = False
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(13, 34)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(152, 163)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 1010
        Me.pic1.TabStop = False
        '
        'grpTomarCarta
        '
        Me.grpTomarCarta.Controls.Add(Me.bntTomarCarta)
        Me.grpTomarCarta.Controls.Add(Me.picOponente)
        Me.grpTomarCarta.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTomarCarta.Location = New System.Drawing.Point(1085, 80)
        Me.grpTomarCarta.Name = "grpTomarCarta"
        Me.grpTomarCarta.Size = New System.Drawing.Size(248, 384)
        Me.grpTomarCarta.TabIndex = 1208
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
        'picOponente
        '
        Me.picOponente.Location = New System.Drawing.Point(43, 21)
        Me.picOponente.Name = "picOponente"
        Me.picOponente.Size = New System.Drawing.Size(182, 172)
        Me.picOponente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOponente.TabIndex = 1020
        Me.picOponente.TabStop = False
        '
        'btnRevolverCartas
        '
        Me.btnRevolverCartas.BackColor = System.Drawing.Color.Brown
        Me.btnRevolverCartas.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevolverCartas.ForeColor = System.Drawing.Color.White
        Me.btnRevolverCartas.Location = New System.Drawing.Point(112, 680)
        Me.btnRevolverCartas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRevolverCartas.Name = "btnRevolverCartas"
        Me.btnRevolverCartas.Size = New System.Drawing.Size(214, 70)
        Me.btnRevolverCartas.TabIndex = 1207
        Me.btnRevolverCartas.Text = "Revolver Cartas"
        Me.btnRevolverCartas.UseVisualStyleBackColor = False
        Me.btnRevolverCartas.Visible = False
        '
        'grpConteo
        '
        Me.grpConteo.Controls.Add(Me.btntxt)
        Me.grpConteo.Controls.Add(Me.txtcartasJugadorPc)
        Me.grpConteo.Controls.Add(Me.txtcartasJugador1)
        Me.grpConteo.Controls.Add(Me.lblCartasPc)
        Me.grpConteo.Controls.Add(Me.lblCartasMano)
        Me.grpConteo.Location = New System.Drawing.Point(413, 645)
        Me.grpConteo.Name = "grpConteo"
        Me.grpConteo.Size = New System.Drawing.Size(409, 138)
        Me.grpConteo.TabIndex = 1216
        Me.grpConteo.TabStop = False
        '
        'btntxt
        '
        Me.btntxt.BackColor = System.Drawing.Color.Moccasin
        Me.btntxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntxt.Location = New System.Drawing.Point(147, 52)
        Me.btntxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btntxt.Name = "btntxt"
        Me.btntxt.Size = New System.Drawing.Size(114, 35)
        Me.btntxt.TabIndex = 1217
        Me.btntxt.Text = "Guardar en TXT"
        Me.btntxt.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.Moccasin
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Location = New System.Drawing.Point(457, 106)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(114, 35)
        Me.btnguardar.TabIndex = 1217
        Me.btnguardar.Text = "Guardar en TXT"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnguardar2
        '
        Me.btnguardar2.BackColor = System.Drawing.Color.Moccasin
        Me.btnguardar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar2.Location = New System.Drawing.Point(457, 106)
        Me.btnguardar2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnguardar2.Name = "btnguardar2"
        Me.btnguardar2.Size = New System.Drawing.Size(114, 35)
        Me.btnguardar2.TabIndex = 1223
        Me.btnguardar2.Text = "Guardar"
        Me.btnguardar2.UseVisualStyleBackColor = False
        '
        'FrmBNIntermedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1356, 749)
        Me.Controls.Add(Me.btnguardar2)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.grpConteo)
        Me.Controls.Add(Me.lblInfoV2)
        Me.Controls.Add(Me.grpTonto)
        Me.Controls.Add(Me.grpCartas)
        Me.Controls.Add(Me.grpTomarCarta)
        Me.Controls.Add(Me.btnRevolverCartas)
        Me.Controls.Add(Me.btnstop)
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
        Me.grpTonto.ResumeLayout(False)
        Me.grpTonto.PerformLayout()
        CType(Me.picTonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCartas.ResumeLayout(False)
        Me.grpCartas.PerformLayout()
        CType(Me.pic10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTomarCarta.ResumeLayout(False)
        CType(Me.picOponente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConteo.ResumeLayout(False)
        Me.grpConteo.PerformLayout()
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
    Friend WithEvents btnstop As Button
    Friend WithEvents txtcartasJugadorPc As TextBox
    Friend WithEvents txtcartasJugador1 As TextBox
    Friend WithEvents lblCartasPc As Label
    Friend WithEvents lblCartasMano As Label
    Friend WithEvents lblInfoV2 As Label
    Friend WithEvents grpTonto As GroupBox
    Friend WithEvents btnVerTonto As Button
    Friend WithEvents lblNumTonto As Label
    Friend WithEvents picTonto As PictureBox
    Friend WithEvents grpCartas As GroupBox
    Friend WithEvents pic10 As PictureBox
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents pic9 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents pic8 As PictureBox
    Friend WithEvents pic12 As PictureBox
    Friend WithEvents pic11 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic6 As PictureBox
    Friend WithEvents pic5 As PictureBox
    Friend WithEvents lblInfoNumeros2 As Label
    Friend WithEvents lblInfoNumeros1 As Label
    Friend WithEvents pic7 As PictureBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents grpTomarCarta As GroupBox
    Friend WithEvents bntTomarCarta As Button
    Friend WithEvents picOponente As PictureBox
    Friend WithEvents btnRevolverCartas As Button
    Friend WithEvents grpConteo As GroupBox
    Friend WithEvents btntxt As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnguardar2 As Button
End Class
