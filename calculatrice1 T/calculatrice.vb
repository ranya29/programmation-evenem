Public Class calculatrice
    Dim op As Char
    Private Sub btplus_Click(sender As Object, e As EventArgs) Handles btplus.Click
        op = "+"
    End Sub

    Private Sub btmois_Click(sender As Object, e As EventArgs) Handles btmois.Click
        op = "-"
    End Sub

    Private Sub btfois_Click(sender As Object, e As EventArgs) Handles btfois.Click
        op = "*"
    End Sub

    Private Sub btsur_Click(sender As Object, e As EventArgs) Handles btsur.Click
        op = "/"
    End Sub
    Private Sub btncarre_Click(sender As Object, e As EventArgs) Handles btncp.Click
        op = "p"

    End Sub
    Private Sub btnm_Click(sender As Object, e As EventArgs) Handles btnm.Click
        op = "%"

    End Sub


    Private Sub btegale_Click(sender As Object, e As EventArgs) Handles btegale.Click
        Dim a = Integer.Parse(txt1.Text)
        Dim b = Integer.Parse(txt2.Text)
        Dim test = True
        Dim res As Double
        If IsNumeric(txt1.Text) And IsNumeric(txt2.Text) Then

            If op = "+" Then
                res = a + b
            ElseIf op = "-" Then
                res = a - b
            ElseIf op = "*" Then
                res = a * b
            ElseIf op = "%" Then
                Dim c As Integer = a / b
                res = a - (b * c)
            ElseIf op = "/" Then
                res = a / b


            ElseIf op = "p" Then
                    Dim p As Double
                    Dim i As Double
                    i = 1
                    p = 1
                    While (i <= b)
                        p = p * a
                        i = i + 1

                    End While
                    res = p
                Else
                    MessageBox.Show("Veiller verifier si b!=0 et que v avec choisit l'operateur")
                test = False
            End If
            If test Then
                lbl_res.Text = a.ToString + "" + op + "" + b.ToString + "=" + Res.ToString
            End If
        End If

    End Sub
    Private Sub btreset_Click(sender As Object, e As EventArgs) Handles btreset.Click
        lbl_res.Text = ""




    End Sub

    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged

    End Sub
End Class
