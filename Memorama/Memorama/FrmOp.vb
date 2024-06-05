Public Class FrmOp

    Private Sub LblMus1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMus1.Click
        FrmMenu.AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath & "\musicas\musica1.mp3"
    End Sub

    Private Sub LblMus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMus2.Click
        FrmMenu.AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath & "\musicas\musica2.mp3"
    End Sub

    Private Sub LblMusica3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMusica3.Click
        FrmMenu.AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath & "\musicas\musica3.mp3"
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        FrmNivel1.tim_conteo.Enabled = True
        FrmNivel1.Show()
        Me.Hide()
    End Sub
End Class