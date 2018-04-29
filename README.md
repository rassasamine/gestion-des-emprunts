# gestion-des-emprunts
TP vb .NET

Ce programme permet au bibliothécaire de gérer les emprunts effectués par les
étudiants de l’ISET de Jendouba. Les données d’emprunts sont enregistrées dans la base
« Biblio.mdb » contenant les tables suivantes : 

Etudiant (CIN, NCE, Nom, Prénom, Adresse, CodeGroupe)
Livre (ISBN, CodeL, Titre, Année, Editeur, nbExemplaires)
Emprunt (NCE, CodeL, DateEmprunt, DateRetour)

 Le bouton Vérifier permet au bibliothécaire de vérifier si l’étudiant désirant emprunter un
nouveau livre a rendu tous les livres qu’il a déjà empruntés. S’il existe un livre non rendu,
le bibliothécaire ne peut pas passer l’emprunt (boutons Disponibilité et Enregistrer
emprunt désactivés).
 Le bouton Disponibilité permet (après avoir saisi le code du livre) de vérifier si le livre à
emprunter est disponible. Si le nombre d’exemplaires disponibles est différent de 0, le bouton
Enregistrer emprunt sera activé pour enregistrer l’opération.
 Le bouton Enregistrer emprunt permet d’enregistrer l’opération d’emprunt et de mettre à jour
le nombre d’exemplaires disponibles.
 Le bouton Rendre livre permet (après avoir saisi le numéro de la carte d’étudiant et le code du
livre) de récupérer un livre déjà emprunté (c'est-à-dire ajouter la date de retour) et de mettre à
jour le nombre d’exemplaires disponibles.

![alt text](https://raw.githubusercontent.com/rassasamine/gestion-des-emprunts/master/emprunt.png)
