Public Class Form1
    Dim motSecret As String
    Dim cpt As Integer = 6
    Dim nbLettres As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Les régles du jeux : entré un mot de votre choix, et un autre joueur devra le deviner en moins de 6 coups.")
        motSecret = InputBox("Entrez le mot à rechercher :", "Mot Secret").ToUpper()
        Label3.Text = cpt.ToString
        nbLettres = motSecret.Length
        Label5.Text = nbLettres.ToString
        If String.IsNullOrEmpty(motSecret) Then
            MessageBox.Show("Vous devez entrer un mot valide.")
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lettreProposee As String = TextBox1.Text.ToUpper()

        If motSecret.Contains(lettreProposee) Then
            MsgBox("Bien joué ! La lettre est dans le mot.")
            nbLettres = nbLettres - 1
            Label5.Text = nbLettres.ToString
        Else
            MsgBox("Dommage ! La lettre n'est pas dans le mot.")
            cpt = cpt - 1
            Label3.Text = cpt.ToString
        End If
        If cpt = 0 Then
            MessageBox.Show("Vous avez perdu ! Le mot était : " & motSecret)
            Me.Close()
        End If
        If nbLettres = 0 Then
            MessageBox.Show("Vous avez gagné ! Le mot était : " & motSecret)
            Me.Close()
        End If
    End Sub
End Class
