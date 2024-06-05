Public Class Opciones3
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        FrmNivel3.TimConteo.Enabled = True
        FrmNivel3.Show()
        Me.Hide()
    End Sub

    Private Sub LblMusica1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMusica1.Click
        FrmMenu.AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath & "\musicas\musica1.mp3"
    End Sub

    Private Sub LblMusica2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMusica2.Click
        FrmMenu.AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath & "\musicas\musica2.mp3"
    End Sub

    Private Sub LblMusica3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMusica3.Click
        FrmMenu.AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath & "\musicas\musica3.mp3"
    End Sub
End Class