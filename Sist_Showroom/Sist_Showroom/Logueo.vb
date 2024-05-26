Public Class Logueo
    'la caja
    Private Sub Logueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'close para que el programa se cierre cuando se cliquea X
    Private Sub Buttexit_Click(sender As Object, e As EventArgs) Handles Buttexit.Click
        Close()
    End Sub
    'se cambió el evento de textbox por defecto a "click" así cuando se cliquea queda "" y luego aparece el focus (|) que parpadea
    Private Sub Textboxus_Click(sender As Object, e As EventArgs) Handles Textboxus.Click
        Textboxus.Text = ""
        Textboxus.Focus()
    End Sub
    'se cambió el evento de textbox por defecto a "click" así cuando se cliquea queda "" y luego aparece el focus (|) que parpadea
    Private Sub Textboxpass_Click(sender As Object, e As EventArgs) Handles Textboxpass.Click
        Textboxpass.Text = ""
        Textboxpass.Focus()
    End Sub

End Class

