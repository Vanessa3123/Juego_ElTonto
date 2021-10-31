<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAcerca
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
        Me.lblTituloAcercade = New System.Windows.Forms.Label()
        Me.lbltextInfo = New System.Windows.Forms.Label()
        Me.lblvers2 = New System.Windows.Forms.Label()
        Me.lblNomb1 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblfech = New System.Windows.Forms.Label()
        Me.lblVersi = New System.Windows.Forms.Label()
        Me.lblNombr = New System.Windows.Forms.Label()
        Me.btntxt = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblNomb2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTituloAcercade
        '
        Me.lblTituloAcercade.AutoSize = True
        Me.lblTituloAcercade.Font = New System.Drawing.Font("Arial Narrow", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloAcercade.Location = New System.Drawing.Point(306, 20)
        Me.lblTituloAcercade.Name = "lblTituloAcercade"
        Me.lblTituloAcercade.Size = New System.Drawing.Size(185, 25)
        Me.lblTituloAcercade.TabIndex = 57
        Me.lblTituloAcercade.Text = "Informacion General"
        Me.lblTituloAcercade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltextInfo
        '
        Me.lbltextInfo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltextInfo.Location = New System.Drawing.Point(213, 294)
        Me.lbltextInfo.Name = "lbltextInfo"
        Me.lbltextInfo.Size = New System.Drawing.Size(160, 63)
        Me.lbltextInfo.TabIndex = 56
        Me.lbltextInfo.Text = "Lenguaje VB.NET"
        Me.lbltextInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblvers2
        '
        Me.lblvers2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvers2.Location = New System.Drawing.Point(217, 235)
        Me.lblvers2.Name = "lblvers2"
        Me.lblvers2.Size = New System.Drawing.Size(95, 28)
        Me.lblvers2.TabIndex = 54
        Me.lblvers2.Text = "4,7"
        Me.lblvers2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNomb1
        '
        Me.lblNomb1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomb1.Location = New System.Drawing.Point(217, 65)
        Me.lblNomb1.Name = "lblNomb1"
        Me.lblNomb1.Size = New System.Drawing.Size(181, 89)
        Me.lblNomb1.TabIndex = 53
        Me.lblNomb1.Text = "Vanessa Lopez Navarro." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kembly Rivera Sandoval." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Michael Vargas Soto."
        Me.lblNomb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Brown
        Me.lblInfo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(12, 307)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(187, 36)
        Me.lblInfo.TabIndex = 52
        Me.lblInfo.Text = "Informacion Importante:"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblfech
        '
        Me.lblfech.BackColor = System.Drawing.Color.Brown
        Me.lblfech.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfech.ForeColor = System.Drawing.Color.White
        Me.lblfech.Location = New System.Drawing.Point(12, 174)
        Me.lblfech.Name = "lblfech"
        Me.lblfech.Size = New System.Drawing.Size(187, 32)
        Me.lblfech.TabIndex = 51
        Me.lblfech.Text = "Fecha de Creacion:"
        Me.lblfech.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersi
        '
        Me.lblVersi.BackColor = System.Drawing.Color.Brown
        Me.lblVersi.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersi.ForeColor = System.Drawing.Color.White
        Me.lblVersi.Location = New System.Drawing.Point(14, 235)
        Me.lblVersi.Name = "lblVersi"
        Me.lblVersi.Size = New System.Drawing.Size(187, 35)
        Me.lblVersi.TabIndex = 50
        Me.lblVersi.Text = "Version: "
        Me.lblVersi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombr
        '
        Me.lblNombr.BackColor = System.Drawing.Color.Brown
        Me.lblNombr.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombr.ForeColor = System.Drawing.Color.White
        Me.lblNombr.Location = New System.Drawing.Point(12, 65)
        Me.lblNombr.Name = "lblNombr"
        Me.lblNombr.Size = New System.Drawing.Size(195, 45)
        Me.lblNombr.TabIndex = 49
        Me.lblNombr.Text = "Autores: "
        Me.lblNombr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btntxt
        '
        Me.btntxt.BackColor = System.Drawing.Color.DarkGray
        Me.btntxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntxt.Location = New System.Drawing.Point(12, 361)
        Me.btntxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btntxt.Name = "btntxt"
        Me.btntxt.Size = New System.Drawing.Size(114, 35)
        Me.btntxt.TabIndex = 60
        Me.btntxt.Text = "Guardar en TXT"
        Me.btntxt.UseVisualStyleBackColor = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(217, 174)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(233, 25)
        Me.dtpFecha.TabIndex = 61
        '
        'lblNomb2
        '
        Me.lblNomb2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomb2.Location = New System.Drawing.Point(456, 174)
        Me.lblNomb2.Name = "lblNomb2"
        Me.lblNomb2.Size = New System.Drawing.Size(164, 45)
        Me.lblNomb2.TabIndex = 59
        Me.lblNomb2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmAcerca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(683, 423)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btntxt)
        Me.Controls.Add(Me.lblNomb2)
        Me.Controls.Add(Me.lblTituloAcercade)
        Me.Controls.Add(Me.lbltextInfo)
        Me.Controls.Add(Me.lblvers2)
        Me.Controls.Add(Me.lblNomb1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblfech)
        Me.Controls.Add(Me.lblVersi)
        Me.Controls.Add(Me.lblNombr)
        Me.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "FrmAcerca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca de"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloAcercade As Label
    Friend WithEvents lbltextInfo As Label
    Friend WithEvents lblvers2 As Label
    Friend WithEvents lblNomb1 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblfech As Label
    Friend WithEvents lblVersi As Label
    Friend WithEvents lblNombr As Label
    Friend WithEvents btntxt As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblNomb2 As Label
End Class
