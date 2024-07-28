<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormElimEst
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtespe = New System.Windows.Forms.TextBox()
        Me.txtseccion = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblConfContraseña = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtseguape = New System.Windows.Forms.TextBox()
        Me.txtpriape = New System.Windows.Forms.TextBox()
        Me.lblcedu = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtcedu = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.TitleBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TitleBar.Controls.Add(Me.IconButton2)
        Me.TitleBar.Controls.Add(Me.IconButton1)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(481, 55)
        Me.TitleBar.TabIndex = 56
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
        Me.IconButton2.Location = New System.Drawing.Point(405, 12)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(29, 28)
        Me.IconButton2.TabIndex = 1
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
        Me.IconButton1.Location = New System.Drawing.Point(440, 12)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(29, 28)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtespe)
        Me.Panel1.Controls.Add(Me.txtseccion)
        Me.Panel1.Controls.Add(Me.lblContraseña)
        Me.Panel1.Controls.Add(Me.lblConfContraseña)
        Me.Panel1.Controls.Add(Me.txtnom)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtseguape)
        Me.Panel1.Controls.Add(Me.txtpriape)
        Me.Panel1.Controls.Add(Me.lblcedu)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.txtcedu)
        Me.Panel1.Controls.Add(Me.lblApellidos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 671)
        Me.Panel1.TabIndex = 55
        '
        'txtespe
        '
        Me.txtespe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtespe.Enabled = False
        Me.txtespe.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtespe.Location = New System.Drawing.Point(116, 521)
        Me.txtespe.Name = "txtespe"
        Me.txtespe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtespe.Size = New System.Drawing.Size(249, 20)
        Me.txtespe.TabIndex = 65
        '
        'txtseccion
        '
        Me.txtseccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtseccion.Enabled = False
        Me.txtseccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtseccion.Location = New System.Drawing.Point(116, 447)
        Me.txtseccion.Name = "txtseccion"
        Me.txtseccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtseccion.Size = New System.Drawing.Size(249, 20)
        Me.txtseccion.TabIndex = 55
        '
        'lblContraseña
        '
        Me.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContraseña.BackColor = System.Drawing.Color.Transparent
        Me.lblContraseña.Enabled = False
        Me.lblContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.Silver
        Me.lblContraseña.Location = New System.Drawing.Point(116, 410)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(249, 20)
        Me.lblContraseña.TabIndex = 54
        Me.lblContraseña.Text = "Sección:"
        '
        'lblConfContraseña
        '
        Me.lblConfContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblConfContraseña.BackColor = System.Drawing.Color.Transparent
        Me.lblConfContraseña.Enabled = False
        Me.lblConfContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfContraseña.ForeColor = System.Drawing.Color.Silver
        Me.lblConfContraseña.Location = New System.Drawing.Point(116, 484)
        Me.lblConfContraseña.Name = "lblConfContraseña"
        Me.lblConfContraseña.Size = New System.Drawing.Size(249, 20)
        Me.lblConfContraseña.TabIndex = 63
        Me.lblConfContraseña.Text = "Especialidad:"
        '
        'txtnom
        '
        Me.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnom.Enabled = False
        Me.txtnom.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom.Location = New System.Drawing.Point(116, 373)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnom.Size = New System.Drawing.Size(249, 20)
        Me.txtnom.TabIndex = 62
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Enabled = False
        Me.lblEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Silver
        Me.lblEmail.Location = New System.Drawing.Point(116, 336)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(249, 20)
        Me.lblEmail.TabIndex = 61
        Me.lblEmail.Text = "Nombre:"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(190, 588)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 45)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtseguape
        '
        Me.txtseguape.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtseguape.Enabled = False
        Me.txtseguape.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtseguape.Location = New System.Drawing.Point(116, 299)
        Me.txtseguape.Name = "txtseguape"
        Me.txtseguape.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtseguape.Size = New System.Drawing.Size(249, 20)
        Me.txtseguape.TabIndex = 53
        '
        'txtpriape
        '
        Me.txtpriape.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpriape.Enabled = False
        Me.txtpriape.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpriape.Location = New System.Drawing.Point(116, 225)
        Me.txtpriape.Name = "txtpriape"
        Me.txtpriape.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtpriape.Size = New System.Drawing.Size(249, 20)
        Me.txtpriape.TabIndex = 60
        '
        'lblcedu
        '
        Me.lblcedu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblcedu.BackColor = System.Drawing.Color.Transparent
        Me.lblcedu.Enabled = False
        Me.lblcedu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcedu.ForeColor = System.Drawing.Color.Silver
        Me.lblcedu.Location = New System.Drawing.Point(116, 114)
        Me.lblcedu.Name = "lblcedu"
        Me.lblcedu.Size = New System.Drawing.Size(249, 20)
        Me.lblcedu.TabIndex = 57
        Me.lblcedu.Text = "Cédula:"
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Enabled = False
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Silver
        Me.lblNombre.Location = New System.Drawing.Point(116, 188)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(249, 20)
        Me.lblNombre.TabIndex = 59
        Me.lblNombre.Text = "Primer apellido:"
        '
        'txtcedu
        '
        Me.txtcedu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcedu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedu.Location = New System.Drawing.Point(116, 151)
        Me.txtcedu.Name = "txtcedu"
        Me.txtcedu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcedu.Size = New System.Drawing.Size(249, 20)
        Me.txtcedu.TabIndex = 58
        '
        'lblApellidos
        '
        Me.lblApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblApellidos.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidos.Enabled = False
        Me.lblApellidos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.ForeColor = System.Drawing.Color.Silver
        Me.lblApellidos.Location = New System.Drawing.Point(116, 262)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(249, 20)
        Me.lblApellidos.TabIndex = 52
        Me.lblApellidos.Text = "Segundo apellido:"
        '
        'Eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(481, 671)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Eliminar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar"
        Me.TitleBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleBar As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtespe As TextBox
    Friend WithEvents txtseccion As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblConfContraseña As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtseguape As TextBox
    Friend WithEvents txtpriape As TextBox
    Friend WithEvents lblcedu As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtcedu As TextBox
    Friend WithEvents lblApellidos As Label
End Class
