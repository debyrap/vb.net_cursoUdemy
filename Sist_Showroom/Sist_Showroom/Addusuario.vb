Public Class Addusuario

    'la caja
    ' Cuando se abre la caja]/ventana el panel4 de carga de usuarios que visible sea false
    Private Sub Addusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Visible = False
    End Sub

    'close para que el programa se cierre cuando se cliquea
    Private Sub Buttcerrar_Click(sender As Object, e As EventArgs) Handles Buttcerrar.Click
        Close()
    End Sub

    'cuando se cliquea el "más +" que sea visible el panel 4 para la carga de usuario
    Private Sub bttmas_Click(sender As Object, e As EventArgs) Handles bttmas.Click
        Panel4.Visible = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class