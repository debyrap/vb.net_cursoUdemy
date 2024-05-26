Public Class Calculadora
    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btt1_Click(sender As Object, e As EventArgs) Handles Btt1.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double


        If Not IsNumeric(Txtbox1.Text) Then
            msj1.Text = ("Solo caracteres numéricos")
            Exit Sub
        End If

        If Not IsNumeric(Txtbox2.Text) Then
            msj1.Text = ("Solo caracteres numéricos")
            Exit Sub
        End If

        numero1 = Txtbox1.Text
        numero2 = Txtbox2.Text

        resultado = numero1 + numero2
        TxtBox3.Text = resultado
        msj1.Text = ("La operación se realizó con éxito")

    End Sub

    Private Sub Btt2_Click(sender As Object, e As EventArgs) Handles Btt2.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        If Not IsNumeric(Txtbox1.Text) Then
            msj1.Text = ("Solo caracteres numéricos")
            Exit Sub
        End If

        If Not IsNumeric(Txtbox2.Text) Then
            msj1.Text = ("Solo caracteres numéricos")
            Exit Sub
        End If


        numero1 = Txtbox1.Text
        numero2 = Txtbox2.Text


        resultado = numero1 - numero2
        TxtBox3.Text = resultado
        msj1.Text = ("La operación se realizó con éxito")



    End Sub

    Private Sub Btt3_Click(sender As Object, e As EventArgs) Handles Btt3.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        If Not IsNumeric(Txtbox1.Text) Then
            msj1.Text = ("Solo caracteres numéricos")
            Exit Sub
        End If

        If Not IsNumeric(Txtbox2.Text) Then
            msj1.Text = ("Solo caracteres numéricos")
            Exit Sub
        End If

        numero1 = Txtbox1.Text
        numero2 = Txtbox2.Text
        resultado = numero1 * numero2
        TxtBox3.Text = resultado
        msj1.Text = ("La operación se realizó con éxito")

    End Sub

    Private Sub Btt4_Click(sender As Object, e As EventArgs) Handles Btt4.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        If Not IsNumeric(Txtbox1.Text) Then
            msj1.Text = ("Solo caracteres numéricos")
            Exit Sub
        End If

        If Not IsNumeric(Txtbox2.Text) Then
            msj1.Text = ("Solo caracteres numéricos")
            Exit Sub
        End If

        numero1 = Txtbox1.Text
        numero2 = Txtbox2.Text
        resultado = numero1 / numero2
        TxtBox3.Text = resultado
        msj1.Text = ("La operación se realizó con éxito")

    End Sub

    
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub lim_Click(sender As Object, e As EventArgs) Handles lim.Click
        Txtbox1.Text = " "
        Txtbox2.Text = " "
        TxtBox3.Text = " "
    End Sub
End Class
