<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegisAsistecia
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
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.CmbLecciones = New System.Windows.Forms.ComboBox()
        Me.CmbObservación = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMaterias = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtespe = New System.Windows.Forms.TextBox()
        Me.txtseccion = New System.Windows.Forms.TextBox()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.txtseguape = New System.Windows.Forms.TextBox()
        Me.txtpriape = New System.Windows.Forms.TextBox()
        Me.txtcedu = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblConfContraseña = New System.Windows.Forms.Label()
        Me.lblcedu = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DtpFecha
        '
        Me.DtpFecha.CustomFormat = ""
        Me.DtpFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(549, 202)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(156, 27)
        Me.DtpFecha.TabIndex = 155
        '
        'CmbLecciones
        '
        Me.CmbLecciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLecciones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLecciones.FormattingEnabled = True
        Me.CmbLecciones.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CmbLecciones.Location = New System.Drawing.Point(549, 271)
        Me.CmbLecciones.Name = "CmbLecciones"
        Me.CmbLecciones.Size = New System.Drawing.Size(156, 25)
        Me.CmbLecciones.TabIndex = 154
        '
        'CmbObservación
        '
        Me.CmbObservación.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbObservación.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbObservación.FormattingEnabled = True
        Me.CmbObservación.Items.AddRange(New Object() {"Ausencia", "Tardía"})
        Me.CmbObservación.Location = New System.Drawing.Point(549, 135)
        Me.CmbObservación.Name = "CmbObservación"
        Me.CmbObservación.Size = New System.Drawing.Size(156, 25)
        Me.CmbObservación.TabIndex = 151
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(300, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 88)
        Me.Button1.TabIndex = 150
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtMaterias
        '
        Me.txtMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaterias.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterias.Location = New System.Drawing.Point(550, 341)
        Me.txtMaterias.Name = "txtMaterias"
        Me.txtMaterias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaterias.Size = New System.Drawing.Size(154, 20)
        Me.txtMaterias.TabIndex = 146
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(549, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Observación:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(549, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 20)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Fecha:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(549, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 20)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "Lecciones:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(549, 307)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 20)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "Materia:"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(301, 341)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox4.Size = New System.Drawing.Size(154, 20)
        Me.TextBox4.TabIndex = 139
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(301, 273)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox3.Size = New System.Drawing.Size(154, 20)
        Me.TextBox3.TabIndex = 138
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(301, 205)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(154, 20)
        Me.TextBox2.TabIndex = 143
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(301, 137)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 141
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(299, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 20)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Cédula:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(299, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 20)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "Primer apellido:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(299, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 20)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Segundo apellido:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(299, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 20)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Nombre:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(300, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 20)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Profesor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(47, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 20)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Estudiante"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtespe
        '
        Me.txtespe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtespe.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtespe.Location = New System.Drawing.Point(52, 477)
        Me.txtespe.Name = "txtespe"
        Me.txtespe.ReadOnly = True
        Me.txtespe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtespe.Size = New System.Drawing.Size(154, 20)
        Me.txtespe.TabIndex = 134
        '
        'txtseccion
        '
        Me.txtseccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtseccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtseccion.Location = New System.Drawing.Point(52, 409)
        Me.txtseccion.Name = "txtseccion"
        Me.txtseccion.ReadOnly = True
        Me.txtseccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtseccion.Size = New System.Drawing.Size(154, 20)
        Me.txtseccion.TabIndex = 126
        '
        'txtnom
        '
        Me.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnom.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom.Location = New System.Drawing.Point(52, 341)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.ReadOnly = True
        Me.txtnom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnom.Size = New System.Drawing.Size(154, 20)
        Me.txtnom.TabIndex = 132
        '
        'txtseguape
        '
        Me.txtseguape.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtseguape.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtseguape.Location = New System.Drawing.Point(52, 273)
        Me.txtseguape.Name = "txtseguape"
        Me.txtseguape.ReadOnly = True
        Me.txtseguape.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtseguape.Size = New System.Drawing.Size(154, 20)
        Me.txtseguape.TabIndex = 124
        '
        'txtpriape
        '
        Me.txtpriape.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpriape.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpriape.Location = New System.Drawing.Point(52, 205)
        Me.txtpriape.Name = "txtpriape"
        Me.txtpriape.ReadOnly = True
        Me.txtpriape.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtpriape.Size = New System.Drawing.Size(154, 20)
        Me.txtpriape.TabIndex = 130
        '
        'txtcedu
        '
        Me.txtcedu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcedu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedu.Location = New System.Drawing.Point(52, 137)
        Me.txtcedu.Name = "txtcedu"
        Me.txtcedu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcedu.Size = New System.Drawing.Size(154, 20)
        Me.txtcedu.TabIndex = 128
        '
        'lblContraseña
        '
        Me.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContraseña.BackColor = System.Drawing.Color.Transparent
        Me.lblContraseña.Enabled = False
        Me.lblContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.Silver
        Me.lblContraseña.Location = New System.Drawing.Point(50, 375)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(158, 20)
        Me.lblContraseña.TabIndex = 125
        Me.lblContraseña.Text = "Sección:"
        '
        'lblConfContraseña
        '
        Me.lblConfContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblConfContraseña.BackColor = System.Drawing.Color.Transparent
        Me.lblConfContraseña.Enabled = False
        Me.lblConfContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfContraseña.ForeColor = System.Drawing.Color.Silver
        Me.lblConfContraseña.Location = New System.Drawing.Point(50, 443)
        Me.lblConfContraseña.Name = "lblConfContraseña"
        Me.lblConfContraseña.Size = New System.Drawing.Size(158, 20)
        Me.lblConfContraseña.TabIndex = 133
        Me.lblConfContraseña.Text = "Especialidad:"
        '
        'lblcedu
        '
        Me.lblcedu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblcedu.BackColor = System.Drawing.Color.Transparent
        Me.lblcedu.Enabled = False
        Me.lblcedu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcedu.ForeColor = System.Drawing.Color.Silver
        Me.lblcedu.Location = New System.Drawing.Point(50, 103)
        Me.lblcedu.Name = "lblcedu"
        Me.lblcedu.Size = New System.Drawing.Size(158, 20)
        Me.lblcedu.TabIndex = 127
        Me.lblcedu.Text = "Cédula:"
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Enabled = False
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Silver
        Me.lblNombre.Location = New System.Drawing.Point(50, 171)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(158, 20)
        Me.lblNombre.TabIndex = 129
        Me.lblNombre.Text = "Primer apellido:"
        '
        'lblApellidos
        '
        Me.lblApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblApellidos.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidos.Enabled = False
        Me.lblApellidos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.ForeColor = System.Drawing.Color.Silver
        Me.lblApellidos.Location = New System.Drawing.Point(50, 239)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(158, 20)
        Me.lblApellidos.TabIndex = 123
        Me.lblApellidos.Text = "Segundo apellido:"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Enabled = False
        Me.lblEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Silver
        Me.lblEmail.Location = New System.Drawing.Point(50, 307)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(158, 20)
        Me.lblEmail.TabIndex = 131
        Me.lblEmail.Text = "Nombre:"
        '
        'FormRegisAsistecia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(756, 597)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.CmbLecciones)
        Me.Controls.Add(Me.CmbObservación)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMaterias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtespe)
        Me.Controls.Add(Me.txtseccion)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.txtseguape)
        Me.Controls.Add(Me.txtpriape)
        Me.Controls.Add(Me.txtcedu)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblConfContraseña)
        Me.Controls.Add(Me.lblcedu)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRegisAsistecia"
        Me.Text = "FormRegisAsistecia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents CmbLecciones As ComboBox
    Friend WithEvents CmbObservación As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtMaterias As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtespe As TextBox
    Friend WithEvents txtseccion As TextBox
    Friend WithEvents txtnom As TextBox
    Friend WithEvents txtseguape As TextBox
    Friend WithEvents txtpriape As TextBox
    Friend WithEvents txtcedu As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblConfContraseña As Label
    Friend WithEvents lblcedu As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblEmail As Label
End Class
