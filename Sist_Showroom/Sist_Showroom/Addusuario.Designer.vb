<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addusuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addusuario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Buttcerrar = New System.Windows.Forms.Button()
        Me.Labusuario = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripeliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.Toolstlupa = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CheckBoxenvios = New System.Windows.Forms.CheckBox()
        Me.CheckBoxcierre = New System.Windows.Forms.CheckBox()
        Me.CheckBoxdevol = New System.Windows.Forms.CheckBox()
        Me.CheckBoxcanje = New System.Windows.Forms.CheckBox()
        Me.CheckBoxcompras = New System.Windows.Forms.CheckBox()
        Me.CheckBoxventas = New System.Windows.Forms.CheckBox()
        Me.Labrol = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Labpass = New System.Windows.Forms.Label()
        Me.Labuser = New System.Windows.Forms.Label()
        Me.labname = New System.Windows.Forms.Label()
        Me.TextBoxbusqueda = New System.Windows.Forms.TextBox()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.bttmas = New System.Windows.Forms.Button()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Buttcerrar)
        Me.Panel1.Controls.Add(Me.Labusuario)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 83)
        Me.Panel1.TabIndex = 0
        '
        'Buttcerrar
        '
        Me.Buttcerrar.FlatAppearance.BorderSize = 0
        Me.Buttcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttcerrar.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttcerrar.ForeColor = System.Drawing.Color.White
        Me.Buttcerrar.Location = New System.Drawing.Point(776, 0)
        Me.Buttcerrar.Name = "Buttcerrar"
        Me.Buttcerrar.Size = New System.Drawing.Size(68, 40)
        Me.Buttcerrar.TabIndex = 4
        Me.Buttcerrar.Text = "X"
        Me.Buttcerrar.UseVisualStyleBackColor = True
        '
        'Labusuario
        '
        Me.Labusuario.AutoSize = True
        Me.Labusuario.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labusuario.Location = New System.Drawing.Point(334, 25)
        Me.Labusuario.Name = "Labusuario"
        Me.Labusuario.Size = New System.Drawing.Size(113, 23)
        Me.Labusuario.TabIndex = 0
        Me.Labusuario.Text = "USUARIOS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripeliminar})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 53)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(96, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripeliminar
        '
        Me.ToolStripeliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripeliminar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripeliminar.ForeColor = System.Drawing.Color.White
        Me.ToolStripeliminar.Name = "ToolStripeliminar"
        Me.ToolStripeliminar.Size = New System.Drawing.Size(88, 23)
        Me.ToolStripeliminar.Text = "Eliminar"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.MenuStrip2)
        Me.Panel3.Controls.Add(Me.TextBoxbusqueda)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 83)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(834, 125)
        Me.Panel3.TabIndex = 1
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toolstlupa})
        Me.MenuStrip2.Location = New System.Drawing.Point(33, 46)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(36, 24)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'Toolstlupa
        '
        Me.Toolstlupa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Toolstlupa.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Toolstlupa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Toolstlupa.Image = CType(resources.GetObject("Toolstlupa.Image"), System.Drawing.Image)
        Me.Toolstlupa.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Toolstlupa.Name = "Toolstlupa"
        Me.Toolstlupa.Size = New System.Drawing.Size(28, 20)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Labpass)
        Me.Panel4.Controls.Add(Me.Labuser)
        Me.Panel4.Controls.Add(Me.labname)
        Me.Panel4.Controls.Add(Me.MenuStrip3)
        Me.Panel4.Location = New System.Drawing.Point(12, 214)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(724, 256)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.CheckBoxenvios)
        Me.Panel5.Controls.Add(Me.CheckBoxcierre)
        Me.Panel5.Controls.Add(Me.CheckBoxdevol)
        Me.Panel5.Controls.Add(Me.CheckBoxcanje)
        Me.Panel5.Controls.Add(Me.CheckBoxcompras)
        Me.Panel5.Controls.Add(Me.CheckBoxventas)
        Me.Panel5.Controls.Add(Me.Labrol)
        Me.Panel5.Location = New System.Drawing.Point(382, 138)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(314, 102)
        Me.Panel5.TabIndex = 6
        '
        'CheckBoxenvios
        '
        Me.CheckBoxenvios.AutoSize = True
        Me.CheckBoxenvios.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxenvios.Location = New System.Drawing.Point(219, 41)
        Me.CheckBoxenvios.Name = "CheckBoxenvios"
        Me.CheckBoxenvios.Size = New System.Drawing.Size(63, 20)
        Me.CheckBoxenvios.TabIndex = 9
        Me.CheckBoxenvios.Text = "Envíos"
        Me.CheckBoxenvios.UseVisualStyleBackColor = True
        '
        'CheckBoxcierre
        '
        Me.CheckBoxcierre.AutoSize = True
        Me.CheckBoxcierre.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxcierre.Location = New System.Drawing.Point(219, 67)
        Me.CheckBoxcierre.Name = "CheckBoxcierre"
        Me.CheckBoxcierre.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxcierre.TabIndex = 8
        Me.CheckBoxcierre.Text = "Cierre Caja"
        Me.CheckBoxcierre.UseVisualStyleBackColor = True
        '
        'CheckBoxdevol
        '
        Me.CheckBoxdevol.AutoSize = True
        Me.CheckBoxdevol.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxdevol.Location = New System.Drawing.Point(109, 67)
        Me.CheckBoxdevol.Name = "CheckBoxdevol"
        Me.CheckBoxdevol.Size = New System.Drawing.Size(88, 20)
        Me.CheckBoxdevol.TabIndex = 7
        Me.CheckBoxdevol.Text = "Devolución"
        Me.CheckBoxdevol.UseVisualStyleBackColor = True
        '
        'CheckBoxcanje
        '
        Me.CheckBoxcanje.AutoSize = True
        Me.CheckBoxcanje.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxcanje.Location = New System.Drawing.Point(109, 41)
        Me.CheckBoxcanje.Name = "CheckBoxcanje"
        Me.CheckBoxcanje.Size = New System.Drawing.Size(60, 20)
        Me.CheckBoxcanje.TabIndex = 6
        Me.CheckBoxcanje.Text = "Canje"
        Me.CheckBoxcanje.UseVisualStyleBackColor = True
        '
        'CheckBoxcompras
        '
        Me.CheckBoxcompras.AutoSize = True
        Me.CheckBoxcompras.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxcompras.Location = New System.Drawing.Point(11, 67)
        Me.CheckBoxcompras.Name = "CheckBoxcompras"
        Me.CheckBoxcompras.Size = New System.Drawing.Size(78, 20)
        Me.CheckBoxcompras.TabIndex = 5
        Me.CheckBoxcompras.Text = "Compras"
        Me.CheckBoxcompras.UseVisualStyleBackColor = True
        '
        'CheckBoxventas
        '
        Me.CheckBoxventas.AutoSize = True
        Me.CheckBoxventas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxventas.Location = New System.Drawing.Point(11, 41)
        Me.CheckBoxventas.Name = "CheckBoxventas"
        Me.CheckBoxventas.Size = New System.Drawing.Size(66, 20)
        Me.CheckBoxventas.TabIndex = 4
        Me.CheckBoxventas.Text = "Ventas"
        Me.CheckBoxventas.UseVisualStyleBackColor = True
        '
        'Labrol
        '
        Me.Labrol.AutoSize = True
        Me.Labrol.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labrol.Location = New System.Drawing.Point(7, 10)
        Me.Labrol.Name = "Labrol"
        Me.Labrol.Size = New System.Drawing.Size(73, 19)
        Me.Labrol.TabIndex = 2
        Me.Labrol.Text = "Permisos"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(98, 103)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(598, 20)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(98, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(598, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(598, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Labpass
        '
        Me.Labpass.AutoSize = True
        Me.Labpass.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labpass.Location = New System.Drawing.Point(3, 101)
        Me.Labpass.Name = "Labpass"
        Me.Labpass.Size = New System.Drawing.Size(88, 19)
        Me.Labpass.TabIndex = 2
        Me.Labpass.Text = "Contraseña"
        '
        'Labuser
        '
        Me.Labuser.AutoSize = True
        Me.Labuser.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labuser.Location = New System.Drawing.Point(3, 60)
        Me.Labuser.Name = "Labuser"
        Me.Labuser.Size = New System.Drawing.Size(63, 19)
        Me.Labuser.TabIndex = 1
        Me.Labuser.Text = "Usuario"
        '
        'labname
        '
        Me.labname.AutoSize = True
        Me.labname.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labname.Location = New System.Drawing.Point(3, 18)
        Me.labname.Name = "labname"
        Me.labname.Size = New System.Drawing.Size(73, 19)
        Me.labname.TabIndex = 0
        Me.labname.Text = "Nombres"
        '
        'TextBoxbusqueda
        '
        Me.TextBoxbusqueda.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxbusqueda.Location = New System.Drawing.Point(100, 40)
        Me.TextBoxbusqueda.Name = "TextBoxbusqueda"
        Me.TextBoxbusqueda.Size = New System.Drawing.Size(665, 30)
        Me.TextBoxbusqueda.TabIndex = 2
        '
        'Datalistado
        '
        Me.Datalistado.AllowUserToAddRows = False
        Me.Datalistado.AllowUserToDeleteRows = False
        Me.Datalistado.AllowUserToResizeRows = False
        Me.Datalistado.BackgroundColor = System.Drawing.Color.White
        Me.Datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado.Location = New System.Drawing.Point(12, 214)
        Me.Datalistado.Name = "Datalistado"
        Me.Datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datalistado.Size = New System.Drawing.Size(721, 256)
        Me.Datalistado.TabIndex = 2
        '
        'bttmas
        '
        Me.bttmas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bttmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bttmas.FlatAppearance.BorderSize = 0
        Me.bttmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttmas.Font = New System.Drawing.Font("Tahoma", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttmas.ForeColor = System.Drawing.Color.White
        Me.bttmas.Location = New System.Drawing.Point(744, 261)
        Me.bttmas.Name = "bttmas"
        Me.bttmas.Size = New System.Drawing.Size(90, 120)
        Me.bttmas.TabIndex = 0
        Me.bttmas.Text = "+"
        Me.bttmas.UseVisualStyleBackColor = False
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.GuardarCambiosToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(62, 214)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(210, 26)
        Me.MenuStrip3.TabIndex = 7
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(72, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar cambios"
        '
        'Addusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(834, 482)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.bttmas)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Datalistado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Addusuario"
        Me.Text = "Addusuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Labusuario As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripeliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents Toolstlupa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBoxbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Labpass As System.Windows.Forms.Label
    Friend WithEvents Labuser As System.Windows.Forms.Label
    Friend WithEvents labname As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Labrol As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxventas As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxenvios As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxcierre As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxdevol As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxcanje As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxcompras As System.Windows.Forms.CheckBox
    Friend WithEvents Buttcerrar As System.Windows.Forms.Button
    Friend WithEvents bttmas As System.Windows.Forms.Button
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
