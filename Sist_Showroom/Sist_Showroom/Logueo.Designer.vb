<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logueo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logueo))
        Me.Buttexit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.loguin = New System.Windows.Forms.Button()
        Me.Textboxus = New System.Windows.Forms.TextBox()
        Me.Textboxpass = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lebelpass = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttexit
        '
        Me.Buttexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Buttexit.FlatAppearance.BorderSize = 0
        Me.Buttexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttexit.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttexit.ForeColor = System.Drawing.Color.White
        Me.Buttexit.Location = New System.Drawing.Point(624, 12)
        Me.Buttexit.Name = "Buttexit"
        Me.Buttexit.Size = New System.Drawing.Size(53, 43)
        Me.Buttexit.TabIndex = 0
        Me.Buttexit.Text = "X"
        Me.Buttexit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(209, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 198)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Romantic Dates", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(202, 265)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(262, 113)
        Me.Titulo.TabIndex = 2
        Me.Titulo.Text = "Show Room"
        '
        'loguin
        '
        Me.loguin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loguin.FlatAppearance.BorderSize = 0
        Me.loguin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loguin.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loguin.ForeColor = System.Drawing.Color.White
        Me.loguin.Location = New System.Drawing.Point(39, 579)
        Me.loguin.Name = "loguin"
        Me.loguin.Size = New System.Drawing.Size(134, 57)
        Me.loguin.TabIndex = 3
        Me.loguin.Text = "Login"
        Me.loguin.UseVisualStyleBackColor = False
        '
        'Textboxus
        '
        Me.Textboxus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textboxus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textboxus.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textboxus.ForeColor = System.Drawing.Color.Black
        Me.Textboxus.Location = New System.Drawing.Point(196, 392)
        Me.Textboxus.Name = "Textboxus"
        Me.Textboxus.Size = New System.Drawing.Size(318, 23)
        Me.Textboxus.TabIndex = 4
        Me.Textboxus.Text = "Username"
        '
        'Textboxpass
        '
        Me.Textboxpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textboxpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textboxpass.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textboxpass.ForeColor = System.Drawing.Color.Black
        Me.Textboxpass.Location = New System.Drawing.Point(196, 458)
        Me.Textboxpass.Name = "Textboxpass"
        Me.Textboxpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Textboxpass.Size = New System.Drawing.Size(318, 23)
        Me.Textboxpass.TabIndex = 5
        Me.Textboxpass.Text = "Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(196, 421)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 10)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(196, 487)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 10)
        Me.Panel2.TabIndex = 7
        '
        'Lebelpass
        '
        Me.Lebelpass.AutoSize = True
        Me.Lebelpass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lebelpass.Location = New System.Drawing.Point(200, 511)
        Me.Lebelpass.Name = "Lebelpass"
        Me.Lebelpass.Size = New System.Drawing.Size(97, 16)
        Me.Lebelpass.TabIndex = 8
        Me.Lebelpass.Text = "Enter password"
        '
        'Logueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(689, 660)
        Me.Controls.Add(Me.Lebelpass)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Textboxpass)
        Me.Controls.Add(Me.Textboxus)
        Me.Controls.Add(Me.loguin)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Buttexit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Logueo"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Buttexit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Titulo As System.Windows.Forms.Label
    Friend WithEvents loguin As System.Windows.Forms.Button
    Friend WithEvents Textboxus As System.Windows.Forms.TextBox
    Friend WithEvents Textboxpass As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Lebelpass As System.Windows.Forms.Label

End Class
