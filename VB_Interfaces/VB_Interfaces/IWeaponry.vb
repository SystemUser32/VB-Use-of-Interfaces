'Main weaponry system interface

Public Interface IWeaponry
    Sub ShootAmmo(ByVal l As Label, ByVal r As RichTextBox)
    Sub OutOfAmmoException(ByVal ex As String, ByVal r As RichTextBox)
End Interface

'End of the main interface


Public Class Cannon23mm
    Implements IWeaponry

    Dim ammoQ As Integer = 200
    Dim ex As String = "Out of ammo!"

    Public Sub IWeaponry_ShootAmmo(ByVal l As Label, ByVal r As RichTextBox) Implements IWeaponry.ShootAmmo

        ammoQ -= 2
        l.Text = ammoQ.ToString()

        If ammoQ = 0 Then
            ammoQ = 0
            OutOfAmmoException_IWeaponry(ex, r)
        Else
            r.AppendText("23mm shot----" & vbCrLf)
        End If

    End Sub

    Public Sub OutOfAmmoException_IWeaponry(ByVal ex As String, ByVal r As RichTextBox) Implements IWeaponry.OutOfAmmoException
        MessageBox.Show(ex)
        r.AppendText(ex & vbCrLf)
    End Sub

End Class


Public Class Cannon37mm
    Implements IWeaponry

    Dim ammoQ As Integer = 40
    Dim ex As String = "Out of ammo!"

    Public Sub ShootAmmo(l As Label, r As RichTextBox) Implements IWeaponry.ShootAmmo
        'Throw New NotImplementedException()

        ammoQ -= 2
        l.Text = ammoQ.ToString()

        If ammoQ = 0 Then
            ammoQ = 0
            OutOfAmmoException_IWeaponry(ex, r)
        Else
            r.AppendText("37mm shot----" & vbCrLf)
        End If

    End Sub

    Public Sub OutOfAmmoException_IWeaponry(ex As String, r As RichTextBox) Implements IWeaponry.OutOfAmmoException
        'Throw New NotImplementedException()

        MessageBox.Show(ex)
        r.AppendText(ex & vbCrLf)

    End Sub
End Class


Public Class Bomb100kg
    Implements IWeaponry

    Dim ammoQ As Integer = 2
    Dim ex As String = "Out of ammo!"

    Public Sub ShootAmmo(l As Label, r As RichTextBox) Implements IWeaponry.ShootAmmo
        'Throw New NotImplementedException()

        ammoQ -= 1
        l.Text = ammoQ.ToString()

        If ammoQ = 0 Then
            ammoQ = 0
            OutOfAmmoException_IWeaponry(ex, r)
        Else
            r.AppendText("Bomb dropped----" & vbCrLf)
        End If

    End Sub

    Public Sub OutOfAmmoException_IWeaponry(ex As String, r As RichTextBox) Implements IWeaponry.OutOfAmmoException
        'Throw New NotImplementedException()

        MessageBox.Show(ex)
        r.AppendText(ex & vbCrLf)

    End Sub
End Class

Public Class Rockets
    Implements IWeaponry

    Dim ammoQ As Integer = 6
    Dim ex As String = "Out of ammo!"

    Public Sub ShootAmmo(l As Label, r As RichTextBox) Implements IWeaponry.ShootAmmo
        'Throw New NotImplementedException()

        ammoQ -= 1
        l.Text = ammoQ.ToString()

        If ammoQ = 0 Then
            ammoQ = 0
            OutOfAmmoException_IWeaponry(ex, r)
        Else
            r.AppendText("Rocket fired----" & vbCrLf)
        End If

    End Sub

    Public Sub OutOfAmmoException_IWeaponry(ex As String, r As RichTextBox) Implements IWeaponry.OutOfAmmoException
        'Throw New NotImplementedException()

        MessageBox.Show(ex)
        r.AppendText(ex & vbCrLf)

    End Sub
End Class




