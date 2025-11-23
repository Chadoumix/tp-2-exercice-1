Imports System.Windows.Forms
Module Module1
    Sub Main()
        Dim nom As String
        Dim prenom As String
        Dim age As Integer

        nom = InputBox("etrez votre nom")
        prenom = InputBox("entrez votre prenom")
        age = InputBox("entrez votre age")
        MessageBox.Show("le nom est " & nom & "le prenom est " & prenom & "l age est " & age)




    End Sub

End Module
