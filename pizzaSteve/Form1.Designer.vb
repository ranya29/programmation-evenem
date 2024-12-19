Imports System.Net.Mime.MediaTypeNames

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CB = New System.Windows.Forms.ComboBox()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.ch2 = New System.Windows.Forms.CheckBox()
        Me.ch3 = New System.Windows.Forms.CheckBox()
        Me.ch1 = New System.Windows.Forms.CheckBox()
        Me.ch4 = New System.Windows.Forms.CheckBox()
        Me.res = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CB
        '
        Me.CB.BackColor = System.Drawing.Color.DarkOrange
        Me.CB.FormattingEnabled = True
        Me.CB.Items.AddRange(New Object() {"small", "moyenne", "large ", "X large"})
        Me.CB.Location = New System.Drawing.Point(702, 226)
        Me.CB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CB.Name = "CB"
        Me.CB.Size = New System.Drawing.Size(310, 37)
        Me.CB.TabIndex = 0
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.BackColor = System.Drawing.Color.DarkOrange
        Me.RB3.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB3.Location = New System.Drawing.Point(397, 405)
        Me.RB3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(187, 31)
        Me.RB3.TabIndex = 5
        Me.RB3.TabStop = True
        Me.RB3.Text = "Criute classique"
        Me.RB3.UseVisualStyleBackColor = False
        '
        'ch2
        '
        Me.ch2.AutoSize = True
        Me.ch2.BackColor = System.Drawing.Color.DarkOrange
        Me.ch2.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch2.Location = New System.Drawing.Point(62, 232)
        Me.ch2.Name = "ch2"
        Me.ch2.Size = New System.Drawing.Size(205, 31)
        Me.ch2.TabIndex = 7
        Me.ch2.Text = "MARGHERITA"
        Me.ch2.UseVisualStyleBackColor = False
        '
        'ch3
        '
        Me.ch3.AutoSize = True
        Me.ch3.BackColor = System.Drawing.Color.DarkOrange
        Me.ch3.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch3.Location = New System.Drawing.Point(62, 311)
        Me.ch3.Name = "ch3"
        Me.ch3.Size = New System.Drawing.Size(216, 31)
        Me.ch3.TabIndex = 8
        Me.ch3.Text = "FRUIT DE MER"
        Me.ch3.UseVisualStyleBackColor = False
        '
        'ch1
        '
        Me.ch1.AutoSize = True
        Me.ch1.BackColor = System.Drawing.Color.DarkOrange
        Me.ch1.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch1.Location = New System.Drawing.Point(62, 146)
        Me.ch1.Name = "ch1"
        Me.ch1.Size = New System.Drawing.Size(131, 31)
        Me.ch1.TabIndex = 9
        Me.ch1.Text = "DIABLO"
        Me.ch1.UseVisualStyleBackColor = False
        '
        'ch4
        '
        Me.ch4.AutoSize = True
        Me.ch4.BackColor = System.Drawing.Color.DarkOrange
        Me.ch4.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch4.Location = New System.Drawing.Point(62, 405)
        Me.ch4.Name = "ch4"
        Me.ch4.Size = New System.Drawing.Size(251, 31)
        Me.ch4.TabIndex = 10
        Me.ch4.Text = "QUATRE SAISONS"
        Me.ch4.UseVisualStyleBackColor = False
        '
        'res
        '
        Me.res.BackColor = System.Drawing.Color.DarkOrange
        Me.res.Location = New System.Drawing.Point(702, 583)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(235, 83)
        Me.res.TabIndex = 11
        Me.res.Text = "commander"
        Me.res.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(810, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 29)
        Me.Label1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Engravers MT", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 27)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "NOS PIZZAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Engravers MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 27)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "les croutes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Engravers MT", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 27)
        Me.Label4.TabIndex = 15
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.BackColor = System.Drawing.Color.DarkOrange
        Me.RB1.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB1.Location = New System.Drawing.Point(397, 145)
        Me.RB1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(143, 31)
        Me.RB1.TabIndex = 16
        Me.RB1.TabStop = True
        Me.RB1.Text = "Croute fine"
        Me.RB1.UseVisualStyleBackColor = False
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.BackColor = System.Drawing.Color.DarkOrange
        Me.RB2.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB2.Location = New System.Drawing.Point(397, 269)
        Me.RB2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(174, 31)
        Me.RB2.TabIndex = 17
        Me.RB2.TabStop = True
        Me.RB2.Text = "Croute epaisse"
        Me.RB2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Engravers MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(697, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(330, 27)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Taille de la pizza"
        '
        'bt2
        '
        Me.bt2.BackColor = System.Drawing.Color.DarkOrange
        Me.bt2.Location = New System.Drawing.Point(62, 561)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(272, 166)
        Me.bt2.TabIndex = 21
        Me.bt2.Text = "les ingrédients"
        Me.bt2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1436, 795)
        Me.Controls.Add(Me.bt2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RB2)
        Me.Controls.Add(Me.RB1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.res)
        Me.Controls.Add(Me.ch4)
        Me.Controls.Add(Me.ch1)
        Me.Controls.Add(Me.ch3)
        Me.Controls.Add(Me.ch2)
        Me.Controls.Add(Me.RB3)
        Me.Controls.Add(Me.CB)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Akhbar MT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB As ComboBox
    Friend WithEvents RB3 As RadioButton
    Friend WithEvents ch2 As CheckBox
    Friend WithEvents ch3 As CheckBox
    Friend WithEvents ch1 As CheckBox
    Friend WithEvents ch4 As CheckBox
    Friend WithEvents res As Button
    Friend WithEvents Label1 As Label

    Private Sub res_Click(sender As Object, e As EventArgs) Handles res.Click
        Dim taille = CB.SelectedItem.ToString()
        Dim type As String = ""
        Dim ing As String = ""
        If RB1.Checked Then
            type = "Croute fine"
        ElseIf RB2.Checked Then
            type = "Croute épaisse "
        ElseIf RB3.Checked Then
            type = "Croute classique "
        Else
            MessageBox.Show("veiller xhoisir un croute")


        End If
        Dim commande As String = ""
        If ch1.Checked Then
            ing = "sauce tomate,mozzarela, salami, epice, piment"
            bt2.Text = ing
            commande = "diaplo"
        ElseIf ch2.Checked Then
            ing = "sauce tomate,mozzarela, origan"
            bt2.Text = ing
            commande = "margherita"
        ElseIf ch3.Checked Then
            ing = "sauce tomate,fruit de mer"
            bt2.Text = ing
            commande = "fruit de mers"
        ElseIf ch4.Checked Then
            ing = "sauce tomate,mazzarela, champignions, jambon, artichauts, olives, arigan"
            bt2.Text = ing
            commande = "quatre saisons"
        Else
            MessageBox.Show("vous n'avait aucune commande ")
        End If
        Dim msg As String = "votre pizza est : " + commande + " \n taille : " + taille + " \n type de croute :" + type
        res.Text = msg




    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

    Private Sub Rd1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents RB1 As RadioButton
    Friend WithEvents RB2 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents bt2 As Button
End Class
