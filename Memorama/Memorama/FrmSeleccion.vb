Public Class FrmSeleccion

    Private Sub LblSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSi.Click
        If Label1.Text = "¿DESEA IR AL NIVEL 2?" Then
            FrmNivel2.Show()
            Me.Hide()
            FrmNiveles.Hide()
        ElseIf Label1.Text = "¿DESEA IR AL NIVEL 3?" Then
            FrmNivel3.Show()
            Me.Hide()
            FrmNiveles.Hide()
        ElseIf Label1.Text = "¿DESEA IR AL NIVEL 1?" Then
            FrmNivel1.Show()
            Me.Hide()
            FrmNiveles.Hide()
        End If
    End Sub

    Private Sub LblNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblNo.Click
        FrmNiveles.Show()
        Me.Hide()
    End Sub
End Class