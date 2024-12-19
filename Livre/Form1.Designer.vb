<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        t_isbn = New TextBox()
        t_titre = New TextBox()
        t_auteur = New TextBox()
        b_ajouter = New Button()
        b_afficher = New Button()
        Label4 = New Label()
        ListView1 = New ListView()
        bt3 = New Button()
        bt_affiche2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.IndianRed
        Label1.Font = New Font("Algerian", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(101, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 25)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.RosyBrown
        Label2.Font = New Font("Algerian", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(101, 328)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 25)
        Label2.TabIndex = 1
        Label2.Text = "Auteur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.RosyBrown
        Label3.Font = New Font("Algerian", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(101, 239)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 25)
        Label3.TabIndex = 2
        Label3.Text = "Titre"
        ' 
        ' t_isbn
        ' 
        t_isbn.Location = New Point(348, 163)
        t_isbn.Name = "t_isbn"
        t_isbn.Size = New Size(125, 27)
        t_isbn.TabIndex = 3
        ' 
        ' t_titre
        ' 
        t_titre.Location = New Point(348, 239)
        t_titre.Name = "t_titre"
        t_titre.Size = New Size(125, 27)
        t_titre.TabIndex = 4
        ' 
        ' t_auteur
        ' 
        t_auteur.Location = New Point(348, 326)
        t_auteur.Name = "t_auteur"
        t_auteur.Size = New Size(125, 27)
        t_auteur.TabIndex = 5
        ' 
        ' b_ajouter
        ' 
        b_ajouter.BackColor = Color.Brown
        b_ajouter.Font = New Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_ajouter.Location = New Point(85, 504)
        b_ajouter.Name = "b_ajouter"
        b_ajouter.Size = New Size(163, 56)
        b_ajouter.TabIndex = 6
        b_ajouter.Text = "Ajouter"
        b_ajouter.UseVisualStyleBackColor = False
        ' 
        ' b_afficher
        ' 
        b_afficher.BackColor = Color.Brown
        b_afficher.Font = New Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_afficher.Location = New Point(310, 504)
        b_afficher.Name = "b_afficher"
        b_afficher.Size = New Size(163, 56)
        b_afficher.TabIndex = 8
        b_afficher.Text = "Afficher"
        b_afficher.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.LightCoral
        Label4.Font = New Font("Algerian", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(286, 25)
        Label4.TabIndex = 9
        Label4.Text = "vous etes le bienvenue"
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(700, 59)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(257, 308)
        ListView1.TabIndex = 10
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' bt3
        ' 
        bt3.BackColor = Color.Brown
        bt3.Font = New Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bt3.Location = New Point(717, 373)
        bt3.Name = "bt3"
        bt3.Size = New Size(227, 56)
        bt3.TabIndex = 11
        bt3.Text = "afficher la"
        bt3.UseVisualStyleBackColor = False
        ' 
        ' bt_affiche2
        ' 
        bt_affiche2.BackColor = Color.Brown
        bt_affiche2.Font = New Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bt_affiche2.Location = New Point(550, 504)
        bt_affiche2.Name = "bt_affiche2"
        bt_affiche2.Size = New Size(210, 56)
        bt_affiche2.TabIndex = 12
        bt_affiche2.Text = "afficher2"
        bt_affiche2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1053, 730)
        Controls.Add(bt_affiche2)
        Controls.Add(bt3)
        Controls.Add(ListView1)
        Controls.Add(Label4)
        Controls.Add(b_afficher)
        Controls.Add(b_ajouter)
        Controls.Add(t_auteur)
        Controls.Add(t_titre)
        Controls.Add(t_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents t_isbn As TextBox
    Friend WithEvents t_titre As TextBox
    Friend WithEvents t_auteur As TextBox
    Friend WithEvents b_ajouter As Button
    Friend WithEvents b_afficher As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents bt3 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents bt_affiche2 As Button

End Class
