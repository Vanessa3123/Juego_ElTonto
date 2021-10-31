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
        Me.tiempoFac = New System.Windows.Forms.Timer(Me.components)
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.txtUsuarioB = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.btnRevolverCartas = New System.Windows.Forms.Button()
        Me.grpTomarCarta = New System.Windows.Forms.GroupBox()
        Me.bntTomarCarta = New System.Windows.Forms.Button()
        Me.pic10 = New System.Windows.Forms.PictureBox()
        Me.grpCartas = New System.Windows.Forms.GroupBox()
        Me.lblInfoNumeros2 = New System.Windows.Forms.Label()
        Me.lblInfoNumeros1 = New System.Windows.Forms.Label()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.btnVerTonto = New System.Windows.Forms.Button()
        Me.lblNumTonto = New System.Windows.Forms.Label()
        Me.grpTonto = New System.Windows.Forms.GroupBox()
        Me.picTonto = New System.Windows.Forms.PictureBox()
        Me.lblInfoV2 = New System.Windows.Forms.Label()
        Me.lblCartasMano = New System.Windows.Forms.Label()
        Me.lblCartasPc = New System.Windows.Forms.Label()
        Me.txtcartasJugador1 = New System.Windows.Forms.TextBox()
        Me.txtcartasJugadorPc = New System.Windows.Forms.TextBox()
        Me.btntxt = New System.Windows.Forms.Button()
        Me.grpTomarCarta.SuspendLayout()
        CType(Me.pic10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCartas.SuspendLayout()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTonto.SuspendLayout()
        CType(Me.picTonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tiempoFac
        '
        '
        'btnJugar
        '
        Me.btnJugar.BackColor = System.Drawing.Color.Brown
        Me.btnJugar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJugar.ForeColor = System.Drawing.Color.White
        Me.btnJugar.Location = New System.Drawing.Point(20, 35)
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
        Me.lblMin.Location = New System.Drawing.Point(460, 9)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(65, 32)
        Me.lblMin.TabIndex = 904
        Me.lblMin.Text = "00"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuarioB
        '
        Me.txtUsuarioB.Location = New System.Drawing.Point(84, 9)
        Me.txtUsuarioB.Name = "txtUsuarioB"
        Me.txtUsuarioB.ReadOnly = True
        Me.txtUsuarioB.Size = New System.Drawing.Size(310, 20)
        Me.txtUsuarioB.TabIndex = 898
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(27, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 20)
        Me.Label19.TabIndex = 897
        Me.Label19.Text = "Usuario:"
        '
        'btnstop
        '
        Me.btnstop.BackColor = System.Drawing.Color.Brown
        Me.btnstop.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstop.ForeColor = System.Drawing.Color.White
        Me.btnstop.Location = New System.Drawing.Point(20, 67)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(310, 31)
        Me.btnstop.TabIndex = 1009
        Me.btnstop.Text = "Detener"
        Me.btnstop.UseVisualStyleBackColor = False
        '
        'btnRevolverCartas
        '
        Me.btnRevolverCartas.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnRevolverCartas.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevolverCartas.ForeColor = System.Drawing.Color.White
        Me.btnRevolverCartas.Location = New System.Drawing.Point(95, 399)
        Me.btnRevolverCartas.Name = "btnRevolverCartas"
        Me.btnRevolverCartas.Size = New System.Drawing.Size(160, 57)
        Me.btnRevolverCartas.TabIndex = 1018
        Me.btnRevolverCartas.Text = "Revolver Cartas"
        Me.btnRevolverCartas.UseVisualStyleBackColor = False
        Me.btnRevolverCartas.Visible = False
        '
        'grpTomarCarta
        '
        Me.grpTomarCarta.BackColor = System.Drawing.Color.RoyalBlue
        Me.grpTomarCarta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpTomarCarta.Controls.Add(Me.bntTomarCarta)
        Me.grpTomarCarta.Controls.Add(Me.pic10)
        Me.grpTomarCarta.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTomarCarta.Location = New System.Drawing.Point(786, 9)
        Me.grpTomarCarta.Margin = New System.Windows.Forms.Padding(2)
        Me.grpTomarCarta.Name = "grpTomarCarta"
        Me.grpTomarCarta.Padding = New System.Windows.Forms.Padding(2)
        Me.grpTomarCarta.Size = New System.Drawing.Size(196, 252)
        Me.grpTomarCarta.TabIndex = 1021
        Me.grpTomarCarta.TabStop = False
        Me.grpTomarCarta.Text = "Tomar Carta del Oponente"
        Me.grpTomarCarta.Visible = False
        '
        'bntTomarCarta
        '
        Me.bntTomarCarta.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.bntTomarCarta.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntTomarCarta.ForeColor = System.Drawing.Color.White
        Me.bntTomarCarta.Location = New System.Drawing.Point(28, 184)
        Me.bntTomarCarta.Name = "bntTomarCarta"
        Me.bntTomarCarta.Size = New System.Drawing.Size(140, 40)
        Me.bntTomarCarta.TabIndex = 1022
        Me.bntTomarCarta.Text = "Tomar Carta"
        Me.bntTomarCarta.UseVisualStyleBackColor = False
        '
        'pic10
        '
        Me.pic10.Location = New System.Drawing.Point(32, 17)
        Me.pic10.Margin = New System.Windows.Forms.Padding(2)
        Me.pic10.Name = "pic10"
        Me.pic10.Size = New System.Drawing.Size(136, 140)
        Me.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic10.TabIndex = 1020
        Me.pic10.TabStop = False
        '
        'grpCartas
        '
        Me.grpCartas.BackColor = System.Drawing.Color.RoyalBlue
        Me.grpCartas.Controls.Add(Me.lblInfoNumeros2)
        Me.grpCartas.Controls.Add(Me.lblInfoNumeros1)
        Me.grpCartas.Controls.Add(Me.pic4)
        Me.grpCartas.Controls.Add(Me.pic3)
        Me.grpCartas.Controls.Add(Me.pic2)
        Me.grpCartas.Controls.Add(Me.pic1)
        Me.grpCartas.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCartas.Location = New System.Drawing.Point(20, 117)
        Me.grpCartas.Margin = New System.Windows.Forms.Padding(2)
        Me.grpCartas.Name = "grpCartas"
        Me.grpCartas.Padding = New System.Windows.Forms.Padding(2)
        Me.grpCartas.Size = New System.Drawing.Size(720, 240)
        Me.grpCartas.TabIndex = 1022
        Me.grpCartas.TabStop = False
        Me.grpCartas.Text = "Cartas"
        Me.grpCartas.Visible = False
        '
        'lblInfoNumeros2
        '
        Me.lblInfoNumeros2.AutoSize = True
        Me.lblInfoNumeros2.Location = New System.Drawing.Point(23, 469)
        Me.lblInfoNumeros2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfoNumeros2.Name = "lblInfoNumeros2"
        Me.lblInfoNumeros2.Size = New System.Drawing.Size(12, 20)
        Me.lblInfoNumeros2.TabIndex = 1021
        Me.lblInfoNumeros2.Text = "."
        '
        'lblInfoNumeros1
        '
        Me.lblInfoNumeros1.AutoSize = True
        Me.lblInfoNumeros1.Location = New System.Drawing.Point(7, 240)
        Me.lblInfoNumeros1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfoNumeros1.Name = "lblInfoNumeros1"
        Me.lblInfoNumeros1.Size = New System.Drawing.Size(54, 20)
        Me.lblInfoNumeros1.TabIndex = 1020
        Me.lblInfoNumeros1.Text = "Vector 1"
        Me.lblInfoNumeros1.Visible = False
        '
        'pic4
        '
        Me.pic4.Location = New System.Drawing.Point(572, 76)
        Me.pic4.Margin = New System.Windows.Forms.Padding(2)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(136, 140)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 1013
        Me.pic4.TabStop = False
        '
        'pic3
        '
        Me.pic3.Location = New System.Drawing.Point(384, 76)
        Me.pic3.Margin = New System.Windows.Forms.Padding(2)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(136, 140)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 1012
        Me.pic3.TabStop = False
        '
        'pic2
        '
        Me.pic2.Location = New System.Drawing.Point(196, 76)
        Me.pic2.Margin = New System.Windows.Forms.Padding(2)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(136, 140)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 1011
        Me.pic2.TabStop = False
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(26, 76)
        Me.pic1.Margin = New System.Windows.Forms.Padding(2)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(136, 140)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 1010
        Me.pic1.TabStop = False
        '
        'btnVerTonto
        '
        Me.btnVerTonto.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnVerTonto.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerTonto.ForeColor = System.Drawing.Color.White
        Me.btnVerTonto.Location = New System.Drawing.Point(28, 142)
        Me.btnVerTonto.Name = "btnVerTonto"
        Me.btnVerTonto.Size = New System.Drawing.Size(140, 40)
        Me.btnVerTonto.TabIndex = 1024
        Me.btnVerTonto.Text = "Ver Carta Tonto"
        Me.btnVerTonto.UseVisualStyleBackColor = False
        '
        'lblNumTonto
        '
        Me.lblNumTonto.AutoSize = True
        Me.lblNumTonto.Location = New System.Drawing.Point(4, 15)
        Me.lblNumTonto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumTonto.Name = "lblNumTonto"
        Me.lblNumTonto.Size = New System.Drawing.Size(71, 13)
        Me.lblNumTonto.TabIndex = 1025
        Me.lblNumTonto.Text = "num del tonto"
        Me.lblNumTonto.Visible = False
        '
        'grpTonto
        '
        Me.grpTonto.Controls.Add(Me.btnVerTonto)
        Me.grpTonto.Controls.Add(Me.lblNumTonto)
        Me.grpTonto.Controls.Add(Me.picTonto)
        Me.grpTonto.Location = New System.Drawing.Point(799, 265)
        Me.grpTonto.Margin = New System.Windows.Forms.Padding(2)
        Me.grpTonto.Name = "grpTonto"
        Me.grpTonto.Padding = New System.Windows.Forms.Padding(2)
        Me.grpTonto.Size = New System.Drawing.Size(183, 190)
        Me.grpTonto.TabIndex = 1026
        Me.grpTonto.TabStop = False
        Me.grpTonto.Visible = False
        '
        'picTonto
        '
        Me.picTonto.Image = Global.Juego_ElTonto.My.Resources.Resources.a_0
        Me.picTonto.Location = New System.Drawing.Point(22, 37)
        Me.picTonto.Margin = New System.Windows.Forms.Padding(2)
        Me.picTonto.Name = "picTonto"
        Me.picTonto.Size = New System.Drawing.Size(146, 93)
        Me.picTonto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTonto.TabIndex = 1023
        Me.picTonto.TabStop = False
        '
        'lblInfoV2
        '
        Me.lblInfoV2.AutoSize = True
        Me.lblInfoV2.Location = New System.Drawing.Point(718, 45)
        Me.lblInfoV2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfoV2.Name = "lblInfoV2"
        Me.lblInfoV2.Size = New System.Drawing.Size(46, 13)
        Me.lblInfoV2.TabIndex = 1027
        Me.lblInfoV2.Text = "vector 2"
        Me.lblInfoV2.Visible = False
        '
        'lblCartasMano
        '
        Me.lblCartasMano.AutoSize = True
        Me.lblCartasMano.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartasMano.Location = New System.Drawing.Point(355, 399)
        Me.lblCartasMano.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCartasMano.Name = "lblCartasMano"
        Me.lblCartasMano.Size = New System.Drawing.Size(100, 20)
        Me.lblCartasMano.TabIndex = 1028
        Me.lblCartasMano.Text = "Cartas en Mano:"
        '
        'lblCartasPc
        '
        Me.lblCartasPc.AutoSize = True
        Me.lblCartasPc.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartasPc.Location = New System.Drawing.Point(355, 436)
        Me.lblCartasPc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCartasPc.Name = "lblCartasPc"
        Me.lblCartasPc.Size = New System.Drawing.Size(130, 20)
        Me.lblCartasPc.TabIndex = 1029
        Me.lblCartasPc.Text = "Cartas de la Maquina:"
        '
        'txtcartasJugador1
        '
        Me.txtcartasJugador1.Enabled = False
        Me.txtcartasJugador1.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcartasJugador1.Location = New System.Drawing.Point(505, 395)
        Me.txtcartasJugador1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcartasJugador1.Name = "txtcartasJugador1"
        Me.txtcartasJugador1.Size = New System.Drawing.Size(117, 24)
        Me.txtcartasJugador1.TabIndex = 1030
        '
        'txtcartasJugadorPc
        '
        Me.txtcartasJugadorPc.Enabled = False
        Me.txtcartasJugadorPc.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcartasJugadorPc.Location = New System.Drawing.Point(505, 432)
        Me.txtcartasJugadorPc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcartasJugadorPc.Name = "txtcartasJugadorPc"
        Me.txtcartasJugadorPc.Size = New System.Drawing.Size(117, 24)
        Me.txtcartasJugadorPc.TabIndex = 1031
        '
        'btntxt
        '
        Me.btntxt.BackColor = System.Drawing.Color.Moccasin
        Me.btntxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntxt.Location = New System.Drawing.Point(451, 46)
        Me.btntxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btntxt.Name = "btntxt"
        Me.btntxt.Size = New System.Drawing.Size(114, 35)
        Me.btntxt.TabIndex = 1032
        Me.btntxt.Text = "Guardar en TXT"
        Me.btntxt.UseVisualStyleBackColor = False
        '
        'FrmBNFacil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Juego_ElTonto.My.Resources.Resources.D_NQ_NP_711752_MLA44377760961_122020_V
        Me.ClientSize = New System.Drawing.Size(998, 499)
        Me.Controls.Add(Me.btntxt)
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
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.txtUsuarioB)
        Me.Controls.Add(Me.Label19)
        Me.Name = "FrmBNFacil"
        Me.Text = "Nivel Facil "
        Me.grpTomarCarta.ResumeLayout(False)
        CType(Me.pic10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCartas.ResumeLayout(False)
        Me.grpCartas.PerformLayout()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTonto.ResumeLayout(False)
        Me.grpTonto.PerformLayout()
        CType(Me.picTonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tiempoFac As Timer
    Friend WithEvents btnJugar As Button
    Friend WithEvents lblMin As Label
    Friend WithEvents txtUsuarioB As TextBox
    Friend WithEvents Label19 As Label
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
    Friend WithEvents btntxt As Button
End Class
