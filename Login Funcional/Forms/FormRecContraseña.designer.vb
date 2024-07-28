<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecContraseña
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
        Me.PanelFondo = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Labelresultado = New System.Windows.Forms.Label()
        Me.Labelverificacion = New System.Windows.Forms.Label()
        Me.btnenviar = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.PanelFondo.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelFondo
        '
        Me.PanelFondo.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.PanelFondo.Controls.Add(Me.Button1)
        Me.PanelFondo.Controls.Add(Me.TextBox1)
        Me.PanelFondo.Controls.Add(Me.Labelresultado)
        Me.PanelFondo.Controls.Add(Me.Labelverificacion)
        Me.PanelFondo.Controls.Add(Me.btnenviar)
        Me.PanelFondo.Controls.Add(Me.txtemail)
        Me.PanelFondo.Controls.Add(Me.LabelEmail)
        Me.PanelFondo.Controls.Add(Me.PanelTop)
        Me.PanelFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFondo.Location = New System.Drawing.Point(0, 0)
        Me.PanelFondo.Name = "PanelFondo"
        Me.PanelFondo.Size = New System.Drawing.Size(800, 450)
        Me.PanelFondo.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(539, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 45)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Verificar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(498, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 27)
        Me.TextBox1.TabIndex = 8
        '
        'Labelresultado
        '
        Me.Labelresultado.AutoSize = True
        Me.Labelresultado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelresultado.ForeColor = System.Drawing.Color.Silver
        Me.Labelresultado.Location = New System.Drawing.Point(36, 338)
        Me.Labelresultado.Name = "Labelresultado"
        Me.Labelresultado.Size = New System.Drawing.Size(0, 21)
        Me.Labelresultado.TabIndex = 7
        '
        'Labelverificacion
        '
        Me.Labelverificacion.AutoSize = True
        Me.Labelverificacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelverificacion.ForeColor = System.Drawing.Color.Silver
        Me.Labelverificacion.Location = New System.Drawing.Point(494, 119)
        Me.Labelverificacion.Name = "Labelverificacion"
        Me.Labelverificacion.Size = New System.Drawing.Size(187, 21)
        Me.Labelverificacion.TabIndex = 4
        Me.Labelverificacion.Text = "Codigo de verificación"
        '
        'btnenviar
        '
        Me.btnenviar.AutoSize = True
        Me.btnenviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnenviar.FlatAppearance.BorderSize = 0
        Me.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnenviar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnenviar.ForeColor = System.Drawing.Color.White
        Me.btnenviar.Location = New System.Drawing.Point(152, 212)
        Me.btnenviar.Name = "btnenviar"
        Me.btnenviar.Size = New System.Drawing.Size(94, 45)
        Me.btnenviar.TabIndex = 3
        Me.btnenviar.Text = "Enviar"
        Me.btnenviar.UseVisualStyleBackColor = False
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(54, 170)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(310, 27)
        Me.txtemail.TabIndex = 2
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.ForeColor = System.Drawing.Color.Silver
        Me.LabelEmail.Location = New System.Drawing.Point(93, 119)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(236, 21)
        Me.LabelEmail.TabIndex = 1
        Me.LabelEmail.Text = "Ingrese su nombre de usuario"
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.IconButton2)
        Me.PanelTop.Controls.Add(Me.IconButton1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(800, 51)
        Me.PanelTop.TabIndex = 0
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 32
        Me.IconButton2.Location = New System.Drawing.Point(724, 12)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(29, 28)
        Me.IconButton2.TabIndex = 6
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 32
        Me.IconButton1.Location = New System.Drawing.Point(759, 12)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(29, 28)
        Me.IconButton1.TabIndex = 5
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'FormRecContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "FormRecContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRecContraseña"
        Me.TopMost = True
        Me.PanelFondo.ResumeLayout(False)
        Me.PanelFondo.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelFondo As Panel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents LabelEmail As Label
    Friend WithEvents btnenviar As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Labelverificacion As Label
    Friend WithEvents Labelresultado As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
