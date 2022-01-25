Public Class Form1

    Private Const KM2MI = 1.609344
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnTeisenda_Click(sender As Object, e As EventArgs) Handles btnTeisenda.Click
        Try
            txtMillid.Text = txtKilomeetrid.Text / KM2MI
        Catch ex As Exception
            MsgBox("Viga sisendis!")
        End Try
    End Sub
End Class
