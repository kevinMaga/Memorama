Public Class Salir

    Private Sub LblSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSi.Click
        Close()
        FrmMenu.Close()
    End Sub

    Private Sub LblNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblNo.Click
        Me.Hide()
    End Sub
End Class