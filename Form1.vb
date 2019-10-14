Public Class Form1


    Dim operacion As String
    Dim resultado As Nullable(Of Double) = Nothing
    Dim n1 As Nullable(Of Double) = Nothing
    Dim bandera As Boolean


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        borrar()
        TextBox1.Text &= "1"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        borrar()
        TextBox1.Text &= "2"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OperacionesCalcular()

        operacion = "+"


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OperacionesCalcular()

        operacion = ""

    End Sub

    Public Sub OperacionesCalcular()

        n1 = TextBox1.Text

        bandera = True
        n1 = Val(TextBox1.Text)
        If resultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    resultado = resultado + n1
            End Select
            TextBox1.Text = resultado
        Else
            resultado = n1

        End If



    End Sub

    Public Sub borrar()
        If bandera = True Then
            TextBox1.Text = ""
            bandera = False

        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        TextBox1.Text = "0"
        resultado = Nothing
        n1 = Nothing

    End Sub
End Class