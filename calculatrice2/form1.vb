

Public Class form1
    Dim a As String
    Dim b As String
    Dim op = ""

    Private Sub bt0_Click(sender As Object, e As EventArgs) Handles bt0.Click
        If op = "" Then
            a = a + "0"
        Else
            b = b + 0

        End If
        Text1.Text = a + " " + op + " " + b
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        If op = "" Then
            a = a + "1"
        Else
            b = b + "1"

        End If
        Text1.Text = a + " " + op + " " + b
    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        If op = "" Then
            a = a + "2"
        Else
            b = b + "2"

        End If
        Text1.Text = a + " " + op + " " + b
    End Sub
    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        If op = "" Then
            a = a + "3"
        Else
            b = b + "3"

        End If
        Text1.Text = a + " " + op + " " + b
    End Sub
    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        If op = "" Then
            a = a + "4"
        Else
            b = b + "4"

        End If
        Text1.Text = a + " " + op + " " + b
    End Sub
    Private Sub bt5_Click(sender As Object, e As EventArgs) Handles bt5.Click
        If op = "" Then
            a = a + "5"
        Else
            b = b + "5"

        End If
        Text1.Text = a + " " + op + " " + b
    End Sub
    Private Sub bt6_Click(sender As Object, e As EventArgs) Handles bt6.Click
        If op = "" Then
            a = a + "6"
        Else
            b = b + "6"

        End If
        Text1.Text = a + " " + op + " " + b
    End Sub
    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click
        If op = "" Then
            a = a + "7"
        Else
            b = b + "7"

        End If
        Text1.Text = a + " " + op + " " + b
    End Sub
    Private Sub bt8_Click(sender As Object, e As EventArgs) Handles bt8.Click
        If op = "" Then
            a = a + "8"
        Else
            b = b + "8"

        End If
        Text1.Text = a + " " + op + " " + b
    End Sub
    Private Sub bt9_Click(sender As Object, e As EventArgs) Handles bt9.Click
        If op = "" Then
            a = a + "9"
        Else
            b = b + "9"

        End If
        Text1.Text = a + " " + op + " " + b
    End Sub

    Private Sub btplus_Click(sender As Object, e As EventArgs) Handles btplus.Click
        If Not a = "" Then
            op = "+"
            Text1.Text = a + " " + op + " " + b
        End If
    End Sub
    Private Sub btmois_Click(sender As Object, e As EventArgs) Handles btmois.Click
        If Not a = "" Then
            op = "-"
            Text1.Text = a + " " + op + " " + b
        End If
    End Sub
    Private Sub btfois_Click(sender As Object, e As EventArgs) Handles btfois.Click
        If Not a = "" Then
            op = "*"
            Text1.Text = a + " " + op + " " + b
        End If
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btsur_Click(sender As Object, e As EventArgs) Handles btsur.Click
        If Not a = "" Then
            op = "/"
            Text1.Text = a + " " + op + " " + b
        End If
    End Sub

    Dim rest As Double
    Private Sub btegale_Click(sender As Object, e As EventArgs) Handles btegale.Click
        Dim test As Boolean
        test = True

        If IsNumeric(a) And IsNumeric(b) And Not op = "" Then
            Dim va = Integer.Parse(a)
            Dim vb = Integer.Parse(b)
            If op = "+" Then
                rest = va + vb
            ElseIf op = "-" Then
                rest = va - vb
            ElseIf op = "*" Then
                rest = va * vb
            ElseIf op = "/" Then
                rest = va / vb
            Else
                MessageBox.Show("division par 0")
                test = False
            End If
        Else
            MessageBox.Show("a et b doivent etre des entier")
            test = False
        End If
        If test Then
            Text1.Text = Text1.Text + "=" + rest.ToString

        End If


    End Sub

    Private Sub btC_Click(sender As Object, e As EventArgs) Handles btC.Click
        Text1.Text = " "

        rest = 0
        op = ""
        a = ""
        b = ""

    End Sub
End Class
