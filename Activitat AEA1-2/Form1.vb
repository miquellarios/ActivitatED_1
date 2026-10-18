Public Class Form1
    ' Quan s'obre el formulari
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Afegim noms a la llista esquerra
        ListBox1.Items.Add("Miquel")
        ListBox1.Items.Add("Eva")
        ListBox1.Items.Add("Joel")

        ' Afegim noms a la llista dreta
        ListBox2.Items.Add("Pau")
        ListBox2.Items.Add("Marc")

        ' Desactivem botons que depenen de selecció
        Button1.Enabled = False
        Button3.Enabled = False
    End Sub

    ' Si seleccionem un nom a la llista esquerra
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Activem o desactivem el botó >
        Button1.Enabled = ListBox1.SelectedItem IsNot Nothing
    End Sub

    ' Si seleccionem un nom a la llista dreta
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        ' Activem o desactivem el botó <
        Button3.Enabled = ListBox2.SelectedItem IsNot Nothing
    End Sub

    ' Botó > : mou un nom cap a la dreta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem IsNot Nothing Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    ' Botó >> : mou tots els noms cap a la dreta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each nom In ListBox1.Items
            ListBox2.Items.Add(nom)
        Next
        ListBox1.Items.Clear()
    End Sub

    ' Botó < : torna un nom cap a l'esquerra
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox2.SelectedItem IsNot Nothing Then
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub

    ' Botó << : torna tots els noms cap a l'esquerra
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each nom In ListBox2.Items
            ListBox1.Items.Add(nom)
        Next
        ListBox2.Items.Clear()
    End Sub
End Class