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
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Txtbox1
        '
        Me.Txtbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txtbox1.Location = New System.Drawing.Point(109, 89)
        Me.Txtbox1.Name = "Txtbox1"
        Me.Txtbox1.Size = New System.Drawing.Size(294, 20)
        Me.Txtbox1.TabIndex = 0
        Me.Txtbox1.Text = "1er monto"
        '
        'txtbox2
        '
        Me.txtbox2.Location = New System.Drawing.Point(114, 143)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(288, 20)
        Me.txtbox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(121, 347)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(281, 20)
        Me.TextBox3.TabIndex = 2
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 534)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.Txtbox1)
        Me.Name = "Calculadora"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtbox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
