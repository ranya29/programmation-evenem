Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module gestion_livre
    Public Structure Livre
        Dim ISBN As Integer
        Dim titre As String


        Dim auteur As String

    End Structure

    Public biblio(100) As Livre
    Dim Nb As Integer = 0




    Function AjouterLivre(l As Livre) As Boolean
        If Nb < biblio.Length Then
            biblio(Nb) = l
            Nb = Nb + 1
            Return True
        Else
            Return False
        End If
    End Function
    Sub afficher_Livre(l1 As ListBox, l12 As ListBox, l3 As ListBox)
        For i As Integer = 0 To Nb - 1
            l1.Items.Add(biblio(i).ISBN)
            l12.Items.Add(biblio(i).titre)
            l3.Items.Add(biblio(i).auteur)
        Next

    End Sub
    Sub afficher_Livre2(dgv_livre As DataGridView)
        For i As Integer = 0 To Nb - 1
            Dim livre As Livre = biblio(i)
            dgv_livre.Rows.Add(livre.ISBN, livre.titre, livre.auteur)
        Next
    End Sub


End Module
