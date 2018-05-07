<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gbEtudiant = New System.Windows.Forms.GroupBox()
        Me.btnVerif = New System.Windows.Forms.Button()
        Me.txtNomEtud = New System.Windows.Forms.TextBox()
        Me.txtCarteEtud = New System.Windows.Forms.TextBox()
        Me.lblNomEtud = New System.Windows.Forms.Label()
        Me.lblCarteEtud = New System.Windows.Forms.Label()
        Me.gbLivre = New System.Windows.Forms.GroupBox()
        Me.btnDispo = New System.Windows.Forms.Button()
        Me.txtTitreLivre = New System.Windows.Forms.TextBox()
        Me.lblTitreLivre = New System.Windows.Forms.Label()
        Me.txtCodeLivre = New System.Windows.Forms.TextBox()
        Me.lblCodeLivre = New System.Windows.Forms.Label()
        Me.btnEnregEmprunt = New System.Windows.Forms.Button()
        Me.btnRendreLivre = New System.Windows.Forms.Button()
        Me.gbEtudiant.SuspendLayout()
        Me.gbLivre.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbEtudiant
        '
        Me.gbEtudiant.Controls.Add(Me.btnVerif)
        Me.gbEtudiant.Controls.Add(Me.txtNomEtud)
        Me.gbEtudiant.Controls.Add(Me.txtCarteEtud)
        Me.gbEtudiant.Controls.Add(Me.lblNomEtud)
        Me.gbEtudiant.Controls.Add(Me.lblCarteEtud)
        Me.gbEtudiant.Location = New System.Drawing.Point(49, 40)
        Me.gbEtudiant.Name = "gbEtudiant"
        Me.gbEtudiant.Size = New System.Drawing.Size(386, 100)
        Me.gbEtudiant.TabIndex = 0
        Me.gbEtudiant.TabStop = False
        Me.gbEtudiant.Text = "&Etudiant"
        '
        'btnVerif
        '
        Me.btnVerif.Location = New System.Drawing.Point(264, 30)
        Me.btnVerif.Name = "btnVerif"
        Me.btnVerif.Size = New System.Drawing.Size(116, 23)
        Me.btnVerif.TabIndex = 4
        Me.btnVerif.Text = "&Vérifier"
        Me.btnVerif.UseVisualStyleBackColor = True
        '
        'txtNomEtud
        '
        Me.txtNomEtud.Location = New System.Drawing.Point(99, 63)
        Me.txtNomEtud.Name = "txtNomEtud"
        Me.txtNomEtud.Size = New System.Drawing.Size(281, 20)
        Me.txtNomEtud.TabIndex = 3
        '
        'txtCarteEtud
        '
        Me.txtCarteEtud.Location = New System.Drawing.Point(99, 34)
        Me.txtCarteEtud.Name = "txtCarteEtud"
        Me.txtCarteEtud.Size = New System.Drawing.Size(158, 20)
        Me.txtCarteEtud.TabIndex = 2
        '
        'lblNomEtud
        '
        Me.lblNomEtud.AutoSize = True
        Me.lblNomEtud.Location = New System.Drawing.Point(10, 66)
        Me.lblNomEtud.Name = "lblNomEtud"
        Me.lblNomEtud.Size = New System.Drawing.Size(85, 13)
        Me.lblNomEtud.TabIndex = 1
        Me.lblNomEtud.Text = "Nom et prénom :"
        '
        'lblCarteEtud
        '
        Me.lblCarteEtud.AutoSize = True
        Me.lblCarteEtud.Location = New System.Drawing.Point(6, 34)
        Me.lblCarteEtud.Name = "lblCarteEtud"
        Me.lblCarteEtud.Size = New System.Drawing.Size(87, 13)
        Me.lblCarteEtud.TabIndex = 0
        Me.lblCarteEtud.Text = "Carte d'étudiant :"
        '
        'gbLivre
        '
        Me.gbLivre.Controls.Add(Me.btnDispo)
        Me.gbLivre.Controls.Add(Me.txtTitreLivre)
        Me.gbLivre.Controls.Add(Me.lblTitreLivre)
        Me.gbLivre.Controls.Add(Me.txtCodeLivre)
        Me.gbLivre.Controls.Add(Me.lblCodeLivre)
        Me.gbLivre.Location = New System.Drawing.Point(49, 172)
        Me.gbLivre.Name = "gbLivre"
        Me.gbLivre.Size = New System.Drawing.Size(386, 100)
        Me.gbLivre.TabIndex = 1
        Me.gbLivre.TabStop = False
        Me.gbLivre.Text = "&Livre"
        '
        'btnDispo
        '
        Me.btnDispo.Location = New System.Drawing.Point(264, 28)
        Me.btnDispo.Name = "btnDispo"
        Me.btnDispo.Size = New System.Drawing.Size(116, 23)
        Me.btnDispo.TabIndex = 4
        Me.btnDispo.Text = "&Disponibilité"
        Me.btnDispo.UseVisualStyleBackColor = True
        '
        'txtTitreLivre
        '
        Me.txtTitreLivre.Location = New System.Drawing.Point(99, 68)
        Me.txtTitreLivre.Name = "txtTitreLivre"
        Me.txtTitreLivre.Size = New System.Drawing.Size(281, 20)
        Me.txtTitreLivre.TabIndex = 3
        '
        'lblTitreLivre
        '
        Me.lblTitreLivre.AutoSize = True
        Me.lblTitreLivre.Location = New System.Drawing.Point(16, 68)
        Me.lblTitreLivre.Name = "lblTitreLivre"
        Me.lblTitreLivre.Size = New System.Drawing.Size(34, 13)
        Me.lblTitreLivre.TabIndex = 2
        Me.lblTitreLivre.Text = "Titre :"
        '
        'txtCodeLivre
        '
        Me.txtCodeLivre.Location = New System.Drawing.Point(99, 32)
        Me.txtCodeLivre.Name = "txtCodeLivre"
        Me.txtCodeLivre.Size = New System.Drawing.Size(158, 20)
        Me.txtCodeLivre.TabIndex = 1
        '
        'lblCodeLivre
        '
        Me.lblCodeLivre.AutoSize = True
        Me.lblCodeLivre.Location = New System.Drawing.Point(13, 32)
        Me.lblCodeLivre.Name = "lblCodeLivre"
        Me.lblCodeLivre.Size = New System.Drawing.Size(38, 13)
        Me.lblCodeLivre.TabIndex = 0
        Me.lblCodeLivre.Text = "Code :"
        '
        'btnEnregEmprunt
        '
        Me.btnEnregEmprunt.Location = New System.Drawing.Point(49, 309)
        Me.btnEnregEmprunt.Name = "btnEnregEmprunt"
        Me.btnEnregEmprunt.Size = New System.Drawing.Size(164, 23)
        Me.btnEnregEmprunt.TabIndex = 2
        Me.btnEnregEmprunt.Text = "&Enregistrer Emprunt"
        Me.btnEnregEmprunt.UseVisualStyleBackColor = True
        '
        'btnRendreLivre
        '
        Me.btnRendreLivre.Location = New System.Drawing.Point(273, 309)
        Me.btnRendreLivre.Name = "btnRendreLivre"
        Me.btnRendreLivre.Size = New System.Drawing.Size(161, 23)
        Me.btnRendreLivre.TabIndex = 3
        Me.btnRendreLivre.Text = "&Rendre Livre"
        Me.btnRendreLivre.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 353)
        Me.Controls.Add(Me.btnRendreLivre)
        Me.Controls.Add(Me.btnEnregEmprunt)
        Me.Controls.Add(Me.gbLivre)
        Me.Controls.Add(Me.gbEtudiant)
        Me.Name = "Form1"
        Me.Text = "Gestion_Emprunts"
        Me.gbEtudiant.ResumeLayout(False)
        Me.gbEtudiant.PerformLayout()
        Me.gbLivre.ResumeLayout(False)
        Me.gbLivre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbEtudiant As GroupBox
    Friend WithEvents gbLivre As GroupBox
    Friend WithEvents lblCarteEtud As Label
    Friend WithEvents lblNomEtud As Label
    Friend WithEvents btnVerif As Button
    Friend WithEvents txtNomEtud As TextBox
    Friend WithEvents txtCarteEtud As TextBox
    Friend WithEvents txtCodeLivre As TextBox
    Friend WithEvents lblCodeLivre As Label
    Friend WithEvents lblTitreLivre As Label
    Friend WithEvents txtTitreLivre As TextBox
    Friend WithEvents btnDispo As Button
    Friend WithEvents btnEnregEmprunt As Button
    Friend WithEvents btnRendreLivre As Button
End Class
