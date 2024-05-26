<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.Txtbox1 = New System.Windows.Forms.TextBox()
        Me.Txtbox2 = New System.Windows.Forms.TextBox()
        Me.TxtBox3 = New System.Windows.Forms.TextBox()
        Me.Btt1 = New System.Windows.Forms.Button()
        Me.Btt2 = New System.Windows.Forms.Button()
        Me.Btt3 = New System.Windows.Forms.Button()
        Me.Btt4 = New System.Windows.Forms.Button()
        Me.msj1 = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.Button()
        Me.lim = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txtbox1
        '
        Me.Txtbox1.BackColor = System.Drawing.Color.Black
        Me.Txtbox1.Font = New System.Drawing.Font("Miriam Mono CLM", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Txtbox1.ForeColor = System.Drawing.Color.Lime
        Me.Txtbox1.Location = New System.Drawing.Point(109, 89)
        Me.Txtbox1.Name = "Txtbox1"
        Me.Txtbox1.Size = New System.Drawing.Size(294, 33)
        Me.Txtbox1.TabIndex = 0
        Me.Txtbox1.Text = "1er monto"
        '
        'Txtbox2
        '
        Me.Txtbox2.BackColor = System.Drawing.Color.Black
        Me.Txtbox2.Font = New System.Drawing.Font("Miriam Mono CLM", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Txtbox2.ForeColor = System.Drawing.Color.Lime
        Me.Txtbox2.Location = New System.Drawing.Point(109, 143)
        Me.Txtbox2.Name = "Txtbox2"
        Me.Txtbox2.Size = New System.Drawing.Size(294, 33)
        Me.Txtbox2.TabIndex = 1
        Me.Txtbox2.Text = "2do monto"
        '
        'TxtBox3
        '
        Me.TxtBox3.BackColor = System.Drawing.Color.Black
        Me.TxtBox3.Font = New System.Drawing.Font("Miriam Mono CLM", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtBox3.ForeColor = System.Drawing.Color.Lime
        Me.TxtBox3.Location = New System.Drawing.Point(109, 350)
        Me.TxtBox3.Name = "TxtBox3"
        Me.TxtBox3.Size = New System.Drawing.Size(281, 33)
        Me.TxtBox3.TabIndex = 2
        Me.TxtBox3.Text = "Resultado"
        '
        'Btt1
        '
        Me.Btt1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btt1.Font = New System.Drawing.Font("Miriam Mono CLM", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btt1.ForeColor = System.Drawing.Color.White
        Me.Btt1.Location = New System.Drawing.Point(117, 226)
        Me.Btt1.Name = "Btt1"
        Me.Btt1.Size = New System.Drawing.Size(48, 45)
        Me.Btt1.TabIndex = 3
        Me.Btt1.Text = "+"
        Me.Btt1.UseVisualStyleBackColor = False
        '
        'Btt2
        '
        Me.Btt2.BackColor = System.Drawing.Color.Black
        Me.Btt2.Font = New System.Drawing.Font("Miriam Mono CLM", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btt2.ForeColor = System.Drawing.Color.Red
        Me.Btt2.Location = New System.Drawing.Point(193, 226)
        Me.Btt2.Name = "Btt2"
        Me.Btt2.Size = New System.Drawing.Size(50, 45)
        Me.Btt2.TabIndex = 4
        Me.Btt2.Text = "-"
        Me.Btt2.UseVisualStyleBackColor = False
        '
        'Btt3
        '
        Me.Btt3.BackColor = System.Drawing.Color.Black
        Me.Btt3.Font = New System.Drawing.Font("Miriam Mono CLM", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btt3.ForeColor = System.Drawing.Color.White
        Me.Btt3.Location = New System.Drawing.Point(273, 227)
        Me.Btt3.Name = "Btt3"
        Me.Btt3.Size = New System.Drawing.Size(51, 43)
        Me.Btt3.TabIndex = 5
        Me.Btt3.Text = "*"
        Me.Btt3.UseVisualStyleBackColor = False
        '
        'Btt4
        '
        Me.Btt4.BackColor = System.Drawing.Color.Black
        Me.Btt4.Font = New System.Drawing.Font("Miriam Mono CLM", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btt4.ForeColor = System.Drawing.Color.White
        Me.Btt4.Location = New System.Drawing.Point(353, 226)
        Me.Btt4.Name = "Btt4"
        Me.Btt4.Size = New System.Drawing.Size(49, 45)
        Me.Btt4.TabIndex = 6
        Me.Btt4.Text = "/"
        Me.Btt4.UseVisualStyleBackColor = False
        '
        'msj1
        '
        Me.msj1.AutoSize = True
        Me.msj1.Font = New System.Drawing.Font("Miriam Mono CLM", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.msj1.ForeColor = System.Drawing.Color.Blue
        Me.msj1.Location = New System.Drawing.Point(118, 437)
        Me.msj1.Name = "msj1"
        Me.msj1.Size = New System.Drawing.Size(218, 18)
        Me.msj1.TabIndex = 7
        Me.msj1.Text = "C A L C U L A D O R A"
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Salir.Font = New System.Drawing.Font("Miriam Mono CLM", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Salir.Location = New System.Drawing.Point(483, 424)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(113, 71)
        Me.Salir.TabIndex = 8
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'lim
        '
        Me.lim.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lim.Font = New System.Drawing.Font("Miriam Mono CLM", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lim.Location = New System.Drawing.Point(465, 229)
        Me.lim.Name = "lim"
        Me.lim.Size = New System.Drawing.Size(142, 40)
        Me.lim.TabIndex = 9
        Me.lim.Text = "Limpiar"
        Me.lim.UseVisualStyleBackColor = False
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 534)
        Me.Controls.Add(Me.lim)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.msj1)
        Me.Controls.Add(Me.Btt4)
        Me.Controls.Add(Me.Btt3)
        Me.Controls.Add(Me.Btt2)
        Me.Controls.Add(Me.Btt1)
        Me.Controls.Add(Me.TxtBox3)
        Me.Controls.Add(Me.Txtbox2)
        Me.Controls.Add(Me.Txtbox1)
        Me.Name = "Calculadora"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtbox1 As System.Windows.Forms.TextBox
    Friend WithEvents Txtbox2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Btt1 As System.Windows.Forms.Button
    Friend WithEvents Btt2 As System.Windows.Forms.Button
    Friend WithEvents Btt3 As System.Windows.Forms.Button
    Friend WithEvents Btt4 As System.Windows.Forms.Button
    Friend WithEvents msj1 As System.Windows.Forms.Label
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents lim As System.Windows.Forms.Button

End Class
