Public Class Form1

    Private Const KM2MI = 1.609344


    Private Sub btnTeisenda_Click(sender As Object, e As EventArgs) Handles btnTeisenda.Click
        Try
            txtMillid.Text = teisenda(txtKilomeetrid.Text)
        Catch ex As Exception
            MsgBox("Viga sisendis!")
        End Try
    End Sub
    Function teisenda(ByVal km As Double) As Double
        Return km / KM2MI
    End Function



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ilmKell.Text = DateTime.Now()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 2000
        Timer1.Enabled = True
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        MsgBox("Leidsid vrjatud nupu!")
    End Sub

    Private Sub SulgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SulgeToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
