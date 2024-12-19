Public Class Form1
    Private Sub b_ajouter_Click(sender As Object, e As EventArgs) Handles b_ajouter.Click
        Dim l As Livre
        l.ISBN = t_isbn.Text
        l.titre = t_titre.Text
        l.auteur = t_auteur.Text
        If AjouterLivre(l) Then
            MessageBox.Show("Ajout du livre avec succes")
        Else
            MessageBox.Show("La bibliotheque est saturé!!")
        End If

    End Sub

    Private Sub b_afficher_Click(sender As Object, e As EventArgs) Handles b_afficher.Click
        Form2.Show()
        afficher_Livre(Form2.l1, Form2.l12, Form2.l3)

    End Sub
    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        For i As Integer = 0 To 100 - 1
            ListView1.Items.Add(biblio(i).ISBN)
            ListView1.Items.Add(biblio(i).titre)
            ListView1.Items.Add(biblio(i).auteur)
        Next
    End Sub
    Private Sub bt_affiche2_Click(sender As Object, e As EventArgs) Handles bt_affiche2.Click
        Form3.Show()
        afficher_Livre2(Form3.DGV_Livre)

    End Sub
End Class
