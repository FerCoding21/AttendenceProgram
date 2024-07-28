<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Ibtn_Administrar = New FontAwesome.Sharp.IconButton()
        Me.Ibtn_cerrar = New FontAwesome.Sharp.IconButton()
        Me.Ibtn_Editar = New FontAwesome.Sharp.IconButton()
        Me.Ibtn_Consultar = New FontAwesome.Sharp.IconButton()
        Me.Ibtn_Eliminar = New FontAwesome.Sharp.IconButton()
        Me.Ibtn_Actualizar = New FontAwesome.Sharp.IconButton()
        Me.Ibtn_Insertar = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelBarratitulo = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelBarratitulo.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Ibtn_Administrar)
        Me.Panel1.Controls.Add(Me.Ibtn_cerrar)
        Me.Panel1.Controls.Add(Me.Ibtn_Editar)
        Me.Panel1.Controls.Add(Me.Ibtn_Consultar)
        Me.Panel1.Controls.Add(Me.Ibtn_Eliminar)
        Me.Panel1.Controls.Add(Me.Ibtn_Actualizar)
        Me.Panel1.Controls.Add(Me.Ibtn_Insertar)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 597)
        Me.Panel1.TabIndex = 0
        '
        'Ibtn_Administrar
        '
        Me.Ibtn_Administrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ibtn_Administrar.FlatAppearance.BorderSize = 0
        Me.Ibtn_Administrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ibtn_Administrar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ibtn_Administrar.ForeColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Administrar.IconChar = FontAwesome.Sharp.IconChar.Tasks
        Me.Ibtn_Administrar.IconColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Administrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Ibtn_Administrar.IconSize = 46
        Me.Ibtn_Administrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Administrar.Location = New System.Drawing.Point(0, 529)
        Me.Ibtn_Administrar.Name = "Ibtn_Administrar"
        Me.Ibtn_Administrar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Ibtn_Administrar.Size = New System.Drawing.Size(252, 67)
        Me.Ibtn_Administrar.TabIndex = 13
        Me.Ibtn_Administrar.Text = "Administrar"
        Me.Ibtn_Administrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Administrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Ibtn_Administrar.UseVisualStyleBackColor = True
        '
        'Ibtn_cerrar
        '
        Me.Ibtn_cerrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ibtn_cerrar.FlatAppearance.BorderSize = 0
        Me.Ibtn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ibtn_cerrar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ibtn_cerrar.ForeColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_cerrar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.Ibtn_cerrar.IconColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_cerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Ibtn_cerrar.IconSize = 46
        Me.Ibtn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_cerrar.Location = New System.Drawing.Point(0, 462)
        Me.Ibtn_cerrar.Name = "Ibtn_cerrar"
        Me.Ibtn_cerrar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Ibtn_cerrar.Size = New System.Drawing.Size(252, 67)
        Me.Ibtn_cerrar.TabIndex = 15
        Me.Ibtn_cerrar.Text = "Cerrar Sesión"
        Me.Ibtn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Ibtn_cerrar.UseVisualStyleBackColor = True
        '
        'Ibtn_Editar
        '
        Me.Ibtn_Editar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ibtn_Editar.FlatAppearance.BorderSize = 0
        Me.Ibtn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ibtn_Editar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ibtn_Editar.ForeColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Editar.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.Ibtn_Editar.IconColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Editar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Ibtn_Editar.IconSize = 46
        Me.Ibtn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Editar.Location = New System.Drawing.Point(0, 395)
        Me.Ibtn_Editar.Name = "Ibtn_Editar"
        Me.Ibtn_Editar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Ibtn_Editar.Size = New System.Drawing.Size(252, 67)
        Me.Ibtn_Editar.TabIndex = 14
        Me.Ibtn_Editar.Text = "Editar Usuario"
        Me.Ibtn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Ibtn_Editar.UseVisualStyleBackColor = True
        '
        'Ibtn_Consultar
        '
        Me.Ibtn_Consultar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ibtn_Consultar.FlatAppearance.BorderSize = 0
        Me.Ibtn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ibtn_Consultar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ibtn_Consultar.ForeColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Consultar.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.Ibtn_Consultar.IconColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Consultar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Ibtn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Consultar.Location = New System.Drawing.Point(0, 328)
        Me.Ibtn_Consultar.Name = "Ibtn_Consultar"
        Me.Ibtn_Consultar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Ibtn_Consultar.Size = New System.Drawing.Size(252, 67)
        Me.Ibtn_Consultar.TabIndex = 12
        Me.Ibtn_Consultar.Text = "Consultar"
        Me.Ibtn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Ibtn_Consultar.UseVisualStyleBackColor = True
        '
        'Ibtn_Eliminar
        '
        Me.Ibtn_Eliminar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ibtn_Eliminar.FlatAppearance.BorderSize = 0
        Me.Ibtn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ibtn_Eliminar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ibtn_Eliminar.ForeColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.Ibtn_Eliminar.IconColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Ibtn_Eliminar.IconSize = 43
        Me.Ibtn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Eliminar.Location = New System.Drawing.Point(0, 261)
        Me.Ibtn_Eliminar.Name = "Ibtn_Eliminar"
        Me.Ibtn_Eliminar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Ibtn_Eliminar.Size = New System.Drawing.Size(252, 67)
        Me.Ibtn_Eliminar.TabIndex = 11
        Me.Ibtn_Eliminar.Text = "Eliminar"
        Me.Ibtn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Ibtn_Eliminar.UseVisualStyleBackColor = True
        '
        'Ibtn_Actualizar
        '
        Me.Ibtn_Actualizar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ibtn_Actualizar.FlatAppearance.BorderSize = 0
        Me.Ibtn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ibtn_Actualizar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ibtn_Actualizar.ForeColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Actualizar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.Ibtn_Actualizar.IconColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Actualizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Ibtn_Actualizar.IconSize = 45
        Me.Ibtn_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Actualizar.Location = New System.Drawing.Point(0, 194)
        Me.Ibtn_Actualizar.Name = "Ibtn_Actualizar"
        Me.Ibtn_Actualizar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Ibtn_Actualizar.Size = New System.Drawing.Size(252, 67)
        Me.Ibtn_Actualizar.TabIndex = 10
        Me.Ibtn_Actualizar.Text = "Actualizar"
        Me.Ibtn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Ibtn_Actualizar.UseVisualStyleBackColor = True
        '
        'Ibtn_Insertar
        '
        Me.Ibtn_Insertar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ibtn_Insertar.FlatAppearance.BorderSize = 0
        Me.Ibtn_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ibtn_Insertar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ibtn_Insertar.ForeColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Insertar.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.Ibtn_Insertar.IconColor = System.Drawing.Color.Gainsboro
        Me.Ibtn_Insertar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Ibtn_Insertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Insertar.Location = New System.Drawing.Point(0, 127)
        Me.Ibtn_Insertar.Name = "Ibtn_Insertar"
        Me.Ibtn_Insertar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Ibtn_Insertar.Size = New System.Drawing.Size(252, 67)
        Me.Ibtn_Insertar.TabIndex = 9
        Me.Ibtn_Insertar.Text = "Registar"
        Me.Ibtn_Insertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ibtn_Insertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Ibtn_Insertar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(252, 127)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'PanelBarratitulo
        '
        Me.PanelBarratitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PanelBarratitulo.Controls.Add(Me.IconButton2)
        Me.PanelBarratitulo.Controls.Add(Me.IconButton1)
        Me.PanelBarratitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarratitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarratitulo.Name = "PanelBarratitulo"
        Me.PanelBarratitulo.Size = New System.Drawing.Size(1008, 54)
        Me.PanelBarratitulo.TabIndex = 0
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
        Me.IconButton2.Location = New System.Drawing.Point(932, 12)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(29, 28)
        Me.IconButton2.TabIndex = 4
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
        Me.IconButton1.Location = New System.Drawing.Point(967, 12)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(29, 28)
        Me.IconButton1.TabIndex = 3
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(756, 597)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(252, 54)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(756, 597)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 651)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBarratitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelBarratitulo.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBarratitulo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents Ibtn_Consultar As FontAwesome.Sharp.IconButton
    Friend WithEvents Ibtn_Eliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents Ibtn_Actualizar As FontAwesome.Sharp.IconButton
    Friend WithEvents Ibtn_Insertar As FontAwesome.Sharp.IconButton
    Friend WithEvents Ibtn_cerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents Ibtn_Editar As FontAwesome.Sharp.IconButton
    Friend WithEvents Ibtn_Administrar As FontAwesome.Sharp.IconButton
End Class
