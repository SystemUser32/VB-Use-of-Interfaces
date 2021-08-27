Public Class Form1

    Private cannon23mm As Cannon23mm = New Cannon23mm()
    Private cannon37mm As Cannon37mm = New Cannon37mm()
    Private bomb100kg As Bomb100kg = New Bomb100kg()
    Private rockets As Rockets = New Rockets()

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'Absolutely not needed
    End Sub

    Private Sub btn23mmCannons_Click(sender As Object, e As EventArgs) Handles btn23mmCannons.Click
        cannon23mm.IWeaponry_ShootAmmo(lbl23mm, RichTextBox1)
    End Sub

    Private Sub btn37mmCannon_Click(sender As Object, e As EventArgs) Handles btn37mmCannon.Click
        cannon37mm.ShootAmmo(lbl37mm, RichTextBox1)
    End Sub

    Private Sub btn100kgBomb_Click(sender As Object, e As EventArgs) Handles btn100kgBomb.Click
        bomb100kg.ShootAmmo(lblBomb, RichTextBox1)
    End Sub

    Private Sub btnRockets_Click(sender As Object, e As EventArgs) Handles btnRockets.Click
        rockets.ShootAmmo(lblRockets, RichTextBox1)
    End Sub
End Class



