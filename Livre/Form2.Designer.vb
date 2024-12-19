<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        l1 = New ListBox()
        l3 = New ListBox()
        l12 = New ListBox()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SaddleBrown
        Label2.Font = New Font("Algerian", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(367, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 25)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.SaddleBrown
        Label3.Font = New Font("Algerian", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(632, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.SaddleBrown
        Label4.Font = New Font("Algerian", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(65, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 25)
        Label4.TabIndex = 3
        Label4.Text = "ISBN"
        ' 
        ' l1
        ' 
        l1.BackColor = Color.OldLace
        l1.FormattingEnabled = True
        l1.Location = New Point(39, 159)
        l1.Name = "l1"
        l1.Size = New Size(150, 204)
        l1.TabIndex = 7
        ' 
        ' l3
        ' 
        l3.BackColor = Color.OldLace
        l3.FormattingEnabled = True
        l3.Location = New Point(617, 159)
        l3.Name = "l3"
        l3.Size = New Size(150, 204)
        l3.TabIndex = 9
        ' 
        ' l12
        ' 
        l12.BackColor = Color.OldLace
        l12.FormattingEnabled = True
        l12.Location = New Point(330, 159)
        l12.Name = "l12"
        l12.Size = New Size(150, 204)
        l12.TabIndex = 10
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BurlyWood
        ClientSize = New Size(800, 450)
        Controls.Add(l12)
        Controls.Add(l3)
        Controls.Add(l1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents l1 As ListBox
    Friend WithEvents i_titre As ListBox
    Friend WithEvents l3 As ListBox
    Friend WithEvents l2 As ListBox
    Friend WithEvents list1 As ListBox
    Friend WithEvents list2 As ListBox
    Friend WithEvents list3 As ListBox
    Friend WithEvents l12 As ListBox
End Class
