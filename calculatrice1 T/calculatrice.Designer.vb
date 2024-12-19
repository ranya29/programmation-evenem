<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculatrice
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btplus = New System.Windows.Forms.Button()
        Me.btfois = New System.Windows.Forms.Button()
        Me.btmois = New System.Windows.Forms.Button()
        Me.btsur = New System.Windows.Forms.Button()
        Me.btegale = New System.Windows.Forms.Button()
        Me.btreset = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.lbl_res = New System.Windows.Forms.Label()
        Me.btncp = New System.Windows.Forms.Button()
        Me.btnm = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(19, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label2.Location = New System.Drawing.Point(499, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label3.Location = New System.Drawing.Point(507, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label4.Location = New System.Drawing.Point(515, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label5.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(43, 583)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Resultat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label6.Font = New System.Drawing.Font("Javanese Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(480, 506)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 69)
        Me.Label6.TabIndex = 5
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label7.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(25, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 34)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "B"
        '
        'btplus
        '
        Me.btplus.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btplus.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btplus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btplus.Location = New System.Drawing.Point(612, 174)
        Me.btplus.Name = "btplus"
        Me.btplus.Size = New System.Drawing.Size(103, 94)
        Me.btplus.TabIndex = 7
        Me.btplus.Text = "+"
        Me.btplus.UseVisualStyleBackColor = False
        '
        'btfois
        '
        Me.btfois.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btfois.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btfois.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btfois.Location = New System.Drawing.Point(721, 174)
        Me.btfois.Name = "btfois"
        Me.btfois.Size = New System.Drawing.Size(103, 94)
        Me.btfois.TabIndex = 8
        Me.btfois.Text = "*"
        Me.btfois.UseVisualStyleBackColor = False
        '
        'btmois
        '
        Me.btmois.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btmois.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmois.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btmois.Location = New System.Drawing.Point(830, 174)
        Me.btmois.Name = "btmois"
        Me.btmois.Size = New System.Drawing.Size(103, 94)
        Me.btmois.TabIndex = 9
        Me.btmois.Text = "-"
        Me.btmois.UseVisualStyleBackColor = False
        '
        'btsur
        '
        Me.btsur.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btsur.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btsur.Location = New System.Drawing.Point(721, 282)
        Me.btsur.Name = "btsur"
        Me.btsur.Size = New System.Drawing.Size(103, 94)
        Me.btsur.TabIndex = 10
        Me.btsur.Text = "/"
        Me.btsur.UseVisualStyleBackColor = False
        '
        'btegale
        '
        Me.btegale.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btegale.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btegale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btegale.Location = New System.Drawing.Point(612, 410)
        Me.btegale.Name = "btegale"
        Me.btegale.Size = New System.Drawing.Size(321, 97)
        Me.btegale.TabIndex = 11
        Me.btegale.Text = "="
        Me.btegale.UseVisualStyleBackColor = False
        '
        'btreset
        '
        Me.btreset.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btreset.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btreset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btreset.Location = New System.Drawing.Point(830, 583)
        Me.btreset.Name = "btreset"
        Me.btreset.Size = New System.Drawing.Size(187, 116)
        Me.btreset.TabIndex = 12
        Me.btreset.Text = "Reset"
        Me.btreset.UseVisualStyleBackColor = False
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(111, 139)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(248, 95)
        Me.txt1.TabIndex = 13
        Me.txt1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(111, 266)
        Me.txt2.Multiline = True
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(248, 93)
        Me.txt2.TabIndex = 14
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_res
        '
        Me.lbl_res.AutoSize = True
        Me.lbl_res.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lbl_res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_res.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_res.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_res.Location = New System.Drawing.Point(291, 583)
        Me.lbl_res.Name = "lbl_res"
        Me.lbl_res.Size = New System.Drawing.Size(122, 36)
        Me.lbl_res.TabIndex = 15
        Me.lbl_res.Text = "res ici"
        '
        'btncp
        '
        Me.btncp.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btncp.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btncp.Location = New System.Drawing.Point(612, 282)
        Me.btncp.Name = "btncp"
        Me.btncp.Size = New System.Drawing.Size(103, 94)
        Me.btncp.TabIndex = 16
        Me.btncp.Text = "p"
        Me.btncp.UseVisualStyleBackColor = False
        '
        'btnm
        '
        Me.btnm.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnm.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnm.Location = New System.Drawing.Point(830, 282)
        Me.btnm.Name = "btnm"
        Me.btnm.Size = New System.Drawing.Size(103, 94)
        Me.btnm.TabIndex = 17
        Me.btnm.Text = "%"
        Me.btnm.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SlateGray
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 29)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "calculatrice"
        '
        'calculatrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(1046, 711)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnm)
        Me.Controls.Add(Me.btncp)
        Me.Controls.Add(Me.lbl_res)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btreset)
        Me.Controls.Add(Me.btegale)
        Me.Controls.Add(Me.btsur)
        Me.Controls.Add(Me.btmois)
        Me.Controls.Add(Me.btfois)
        Me.Controls.Add(Me.btplus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Name = "calculatrice"
        Me.Text = "calculatrice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btplus As Button
    Friend WithEvents btfois As Button
    Friend WithEvents btmois As Button
    Friend WithEvents btsur As Button
    Friend WithEvents btegale As Button
    Friend WithEvents btreset As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents lbl_res As Label
    Friend WithEvents btncp As Button
    Friend WithEvents btnm As Button
    Friend WithEvents Label8 As Label
End Class
