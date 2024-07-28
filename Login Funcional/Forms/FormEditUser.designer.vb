<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditUser
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPasswAct = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPasswdNew = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblConfContraseña = New System.Windows.Forms.Label()
        Me.txtPasswdNewConf = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
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
        Me.TitleBar.Size = New System.Drawing.Size(497, 55)
        Me.TitleBar.TabIndex = 31
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
        Me.IconButton2.Location = New System.Drawing.Point(416, 12)
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
        Me.IconButton1.Location = New System.Drawing.Point(451, 12)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(29, 28)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(201, 550)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 45)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtPasswAct
        '
        Me.txtPasswAct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswAct.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswAct.Location = New System.Drawing.Point(124, 365)
        Me.txtPasswAct.Name = "txtPasswAct"
        Me.txtPasswAct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPasswAct.Size = New System.Drawing.Size(249, 20)
        Me.txtPasswAct.TabIndex = 38
        Me.txtPasswAct.UseSystemPasswordChar = True
        '
        'txtApellidos
        '
        Me.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellidos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(124, 217)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtApellidos.Size = New System.Drawing.Size(249, 20)
        Me.txtApellidos.TabIndex = 36
        '
        'lblApellidos
        '
        Me.lblApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblApellidos.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidos.Enabled = False
        Me.lblApellidos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.ForeColor = System.Drawing.Color.Silver
        Me.lblApellidos.Location = New System.Drawing.Point(124, 180)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(249, 20)
        Me.lblApellidos.TabIndex = 35
        Me.lblApellidos.Text = "Apellidos:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtPasswAct)
        Me.Panel1.Controls.Add(Me.txtPasswdNew)
        Me.Panel1.Controls.Add(Me.lblContraseña)
        Me.Panel1.Controls.Add(Me.lblConfContraseña)
        Me.Panel1.Controls.Add(Me.txtPasswdNewConf)
        Me.Panel1.Controls.Add(Me.lblCodigo)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtApellidos)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.lblApellidos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 647)
        Me.Panel1.TabIndex = 42
        '
        'txtPasswdNew
        '
        Me.txtPasswdNew.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswdNew.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswdNew.Location = New System.Drawing.Point(124, 439)
        Me.txtPasswdNew.Name = "txtPasswdNew"
        Me.txtPasswdNew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPasswdNew.Size = New System.Drawing.Size(249, 20)
        Me.txtPasswdNew.TabIndex = 50
        Me.txtPasswdNew.UseSystemPasswordChar = True
        '
        'lblContraseña
        '
        Me.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContraseña.BackColor = System.Drawing.Color.Transparent
        Me.lblContraseña.Enabled = False
        Me.lblContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.Silver
        Me.lblContraseña.Location = New System.Drawing.Point(124, 328)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(249, 20)
        Me.lblContraseña.TabIndex = 37
        Me.lblContraseña.Text = "Contraseña actual:"
        '
        'lblConfContraseña
        '
        Me.lblConfContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblConfContraseña.BackColor = System.Drawing.Color.Transparent
        Me.lblConfContraseña.Enabled = False
        Me.lblConfContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfContraseña.ForeColor = System.Drawing.Color.Silver
        Me.lblConfContraseña.Location = New System.Drawing.Point(124, 402)
        Me.lblConfContraseña.Name = "lblConfContraseña"
        Me.lblConfContraseña.Size = New System.Drawing.Size(249, 20)
        Me.lblConfContraseña.TabIndex = 49
        Me.lblConfContraseña.Text = "Nueva contraseña:"
        '
        'txtPasswdNewConf
        '
        Me.txtPasswdNewConf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswdNewConf.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswdNewConf.Location = New System.Drawing.Point(124, 513)
        Me.txtPasswdNewConf.Name = "txtPasswdNewConf"
        Me.txtPasswdNewConf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPasswdNewConf.Size = New System.Drawing.Size(249, 20)
        Me.txtPasswdNewConf.TabIndex = 48
        Me.txtPasswdNewConf.UseSystemPasswordChar = True
        '
        'lblCodigo
        '
        Me.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigo.Enabled = False
        Me.lblCodigo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.Silver
        Me.lblCodigo.Location = New System.Drawing.Point(124, 476)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(249, 20)
        Me.lblCodigo.TabIndex = 47
        Me.lblCodigo.Text = "Confirmar Contraseña:"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(124, 291)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmail.Size = New System.Drawing.Size(249, 20)
        Me.txtEmail.TabIndex = 46
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Enabled = False
        Me.lblEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Silver
        Me.lblEmail.Location = New System.Drawing.Point(124, 254)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(249, 20)
        Me.lblEmail.TabIndex = 45
        Me.lblEmail.Text = "Email:"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(124, 143)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(249, 20)
        Me.txtNombre.TabIndex = 44
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Enabled = False
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Silver
        Me.lblNombre.Location = New System.Drawing.Point(124, 106)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(249, 20)
        Me.lblNombre.TabIndex = 43
        Me.lblNombre.Text = "Nombre:"
        '
        'FormEditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 647)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEditUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "x"
        Me.TitleBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleBar As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPasswAct As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPasswdNew As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblConfContraseña As Label
    Friend WithEvents txtPasswdNewConf As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
End Class
