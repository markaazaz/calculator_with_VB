Public Class Form1
    Dim Nilai As Double
    Dim aritmatikOP As String
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtBox.Text = txtBox.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtBox.Text = txtBox.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtBox.Text = txtBox.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtBox.Text = txtBox.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtBox.Text = txtBox.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtBox.Text = txtBox.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtBox.Text = txtBox.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtBox.Text = txtBox.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtBox.Text = txtBox.Text & "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtBox.Text = txtBox.Text & "0"
    End Sub

    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        txtBox.Text = txtBox.Text & "00"
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Nilai = Val(txtBox.Text)
        aritmatikOP = "+"
        txtBox.Text = Nothing
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Nilai = Val(txtBox.Text)
        aritmatikOP = "-"
        txtBox.Text = Nothing
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Nilai = Val(txtBox.Text)
        aritmatikOP = "*"
        txtBox.Text = Nothing
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Nilai = Val(txtBox.Text)
        aritmatikOP = "/"
        txtBox.Text = Nothing
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtBox.Text = Nothing
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        If aritmatikOP = "+" Then
            txtBox.Text = Nilai + Val(txtBox.Text)

        ElseIf aritmatikOP = "-" Then
            txtBox.Text = Nilai - Val(txtBox.Text)

        ElseIf aritmatikOP = "*" Then
            txtBox.Text = Nilai * Val(txtBox.Text)

        ElseIf aritmatikOP = "/" Then
            txtBox.Text = Nilai / Val(txtBox.Text)
        End If
    End Sub
End Class
