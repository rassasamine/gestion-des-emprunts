Imports System.Data.OleDb

Public Class Form1
    'variable globale
    Dim connexion As OleDbConnection
    Dim numcarte As Integer
    Dim numlivre As Integer
    Dim datesys As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'initialisation
        btnDispo.Enabled = False
        btnEnregEmprunt.Enabled = False

        'Etablir la connexion avec la base de donnée
        Dim ConnexionString As String
        ConnexionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source= C:\Users\Emine 'HusSoka' Rass\Documents\Visual Studio 2017\Projects\Gerer_Emprunts\Gerer_Emprunts\Bibliowin.mdb"
        connexion = New OleDbConnection(ConnexionString)
        connexion.Open()
    End Sub

    Private Sub btnVerif_Click(sender As Object, e As EventArgs) Handles btnVerif.Click

        'Recuperer numero carte etudiant à partir du text box 
        numcarte = Val(txtCarteEtud.Text)

        'Requette de verification
        Dim req As String
        req = "SELECT count(*) FROM emprunt WHERE nce =" & numcarte & " AND dateretour IS NULL"

        'Executer la requette
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(req, connexion)

        'recuperer le resultat
        Dim nb As Integer = cmd.ExecuteScalar()

        'manipuler le resultat
        If (nb = 0) Then
            btnDispo.Enabled = True
        Else
            MsgBox("vous avez " & nb & " livre(s) non rendues")
        End If

    End Sub

    Private Sub btnEnregEmprunt_Click(sender As Object, e As EventArgs) Handles btnEnregEmprunt.Click

        'Recuperer numero carte etudiant et numero du livre à partir des text box et la date systeme
        numcarte = Val(txtCarteEtud.Text)
        numlivre = Val(txtCodeLivre.Text)
        datesys = DateTime.Now().ToString()

        'Requette d'insertion
        Dim insertreq As String
        insertreq = "INSERT INTO emprunt(nce,codelivre,dateemprunt) VALUES (" & numcarte & "," & numlivre & "," & "'" & datesys & "'" & ")"

        'Executer la requette
        Dim insertcmd As OleDbCommand
        insertcmd = New OleDbCommand(insertreq, connexion)
        insertcmd.ExecuteNonQuery()

        'Requette de mise à jour
        Dim majreq As String
        majreq = "UPDATE livre SET nbexemp = nbexemp - 1 WHERE codelivre =" & numlivre & ""

        'Executer la requette
        Dim majcmd As OleDbCommand
        majcmd = New OleDbCommand(majreq, connexion)
        majcmd.ExecuteNonQuery()

    End Sub

    Private Sub btnRendreLivre_Click(sender As Object, e As EventArgs) Handles btnRendreLivre.Click

        'Recuperer numero carte etudiant et numero du livre à partir des text box et la date systeme
        numcarte = Val(txtCarteEtud.Text)
        numlivre = Val(txtCodeLivre.Text)
        datesys = DateTime.Now().ToString()

        'Requette d'insertion
        Dim insertreq As String
        insertreq = "UPDATE emprunt SET dateretour = " & "'" & datesys & "'" & " WHERE nce = " & numcarte & " AND codelivre = " & numlivre & " AND dateretour IS NULL"

        'Executer la requette
        Dim insertcmd As OleDbCommand
        insertcmd = New OleDbCommand(insertreq, connexion)
        insertcmd.ExecuteNonQuery()

        'Requette de mise à jour
        Dim majreq As String
        majreq = "UPDATE livre SET nbexemp = nbexemp + 1 WHERE codelivre =" & numlivre & ""

        'Executer la requette
        Dim majcmd As OleDbCommand
        majcmd = New OleDbCommand(majreq, connexion)
        majcmd.ExecuteNonQuery()
    End Sub

    Private Sub btnDispo_Click(sender As Object, e As EventArgs) Handles btnDispo.Click

        'Recuperer numero du livre à partir du text box 
        numlivre = Val(txtCodeLivre.Text)

        'Requette de verification
        Dim req As String
        req = "SELECT nbexemp FROM livre WHERE codelivre =" & numlivre & ""

        'Executer la requette
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(req, connexion)

        'recupere le resultat
        Dim nbexemp As Integer = cmd.ExecuteScalar()

        'manipuler le resultat
        If (nbexemp <> 0) Then
            btnEnregEmprunt.Enabled = True
        Else
            MsgBox("le livre ayant le code : " & numlivre & " n'est pas disponible")
        End If
    End Sub
End Class
