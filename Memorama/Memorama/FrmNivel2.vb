Public Class FrmNivel2
    Dim Aciertos As Byte
    Dim Fallas As Byte
    Dim clic As Byte
    Dim Img_Act As String
    Dim Ele_Act As Byte
    Dim Img_Nue As String
    Dim Ele_Nue As Byte
    Dim Max As Integer
    Dim segundos As Byte

    Private Function Aleatorio1(ByVal minimo As Long, ByVal maximo As Long) As Long
        Randomize()
        Aleatorio1 = CLng((minimo - maximo) * Rnd() + maximo)
    End Function

    Private Sub Pbxvolumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbxvolumen1.Click

        If Pbxvolumen1.Visible = True And Pbxvolumen1.Enabled = True Then

            FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.pause()
            Pbxvolumen2.Enabled = True
            Pbxvolumen2.Visible = True
            Pbxvolumen1.Visible = False
            Pbxvolumen1.Enabled = False

        End If
    End Sub

    Private Sub Pbxvolumen2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbxvolumen2.Click

        If Pbxvolumen2.Visible = True And Pbxvolumen2.Enabled = True Then

            FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.play()
            Pbxvolumen1.Enabled = True
            Pbxvolumen1.Visible = True
            Pbxvolumen2.Visible = False
            Pbxvolumen2.Enabled = False
        End If

    End Sub

    Sub ver_pareja()

        If Img_Nue = Img_Act Then

            Aciertos = Aciertos + 1

            If Aciertos = Max Then
                FrmSiguiente2.Show()
                Me.Hide()
                tim_conteo.Enabled = False
            End If

            Select Case (Ele_Nue)
                Case 1 : PictureBox1.Enabled = False
                Case 2 : PictureBox2.Enabled = False
                Case 3 : PictureBox3.Enabled = False
                Case 4 : PictureBox4.Enabled = False
                Case 5 : PictureBox5.Enabled = False
                Case 6 : PictureBox6.Enabled = False
                Case 7 : PictureBox7.Enabled = False
                Case 8 : PictureBox8.Enabled = False
                Case 9 : PictureBox9.Enabled = False
                Case 10 : PictureBox10.Enabled = False
                Case 11 : PictureBox11.Enabled = False
                Case 12 : PictureBox12.Enabled = False
                Case 13 : PictureBox13.Enabled = False
                Case 14 : PictureBox14.Enabled = False
                Case 15 : PictureBox15.Enabled = False
                Case 16 : PictureBox16.Enabled = False
            End Select
            Select Case (Ele_Act)
                Case 1 : PictureBox1.Enabled = False
                Case 2 : PictureBox2.Enabled = False
                Case 3 : PictureBox3.Enabled = False
                Case 4 : PictureBox4.Enabled = False
                Case 5 : PictureBox5.Enabled = False
                Case 6 : PictureBox6.Enabled = False
                Case 7 : PictureBox7.Enabled = False
                Case 8 : PictureBox8.Enabled = False
                Case 9 : PictureBox9.Enabled = False
                Case 10 : PictureBox10.Enabled = False
                Case 11 : PictureBox11.Enabled = False
                Case 12 : PictureBox12.Enabled = False
                Case 13 : PictureBox13.Enabled = False
                Case 14 : PictureBox14.Enabled = False
                Case 15 : PictureBox15.Enabled = False
                Case 16 : PictureBox16.Enabled = False
            End Select
        Else
            GroupBox1.Enabled = False
            tim_verparejas.Enabled = True

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Select Case PictureBox1.Tag
            Case "1" : PictureBox1.Image = My.Resources.pic1
            Case "2" : PictureBox1.Image = My.Resources.pic2
            Case "3" : PictureBox1.Image = My.Resources.pic3
            Case "4" : PictureBox1.Image = My.Resources.pic4
            Case "5" : PictureBox1.Image = My.Resources.pic5
            Case "6" : PictureBox1.Image = My.Resources.pic6
            Case "7" : PictureBox1.Image = My.Resources.pic7
            Case "8" : PictureBox1.Image = My.Resources.pic8
            Case "9" : PictureBox1.Image = My.Resources.pic9
            Case "10" : PictureBox1.Image = My.Resources.pic10
            Case "11" : PictureBox1.Image = My.Resources.pic11
            Case "12" : PictureBox1.Image = My.Resources.pic12
            Case "13" : PictureBox1.Image = My.Resources.pic13
            Case "14" : PictureBox1.Image = My.Resources.pic14
            Case "15" : PictureBox1.Image = My.Resources.pic15
            Case "16" : PictureBox1.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox1.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox1.Tag
            Ele_Act = 1
        Else
            clic = 0
            Img_Nue = PictureBox1.Tag
            Ele_Nue = 1
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Select Case PictureBox2.Tag
            Case "1" : PictureBox2.Image = My.Resources.pic1
            Case "2" : PictureBox2.Image = My.Resources.pic2
            Case "3" : PictureBox2.Image = My.Resources.pic3
            Case "4" : PictureBox2.Image = My.Resources.pic4
            Case "5" : PictureBox2.Image = My.Resources.pic5
            Case "6" : PictureBox2.Image = My.Resources.pic6
            Case "7" : PictureBox2.Image = My.Resources.pic7
            Case "8" : PictureBox2.Image = My.Resources.pic8
            Case "9" : PictureBox2.Image = My.Resources.pic9
            Case "10" : PictureBox2.Image = My.Resources.pic10
            Case "11" : PictureBox2.Image = My.Resources.pic11
            Case "12" : PictureBox2.Image = My.Resources.pic12
            Case "13" : PictureBox2.Image = My.Resources.pic13
            Case "14" : PictureBox2.Image = My.Resources.pic14
            Case "15" : PictureBox2.Image = My.Resources.pic15
            Case "16" : PictureBox2.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox2.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox2.Tag
            Ele_Act = 2
        Else
            clic = 0
            Img_Nue = PictureBox2.Tag
            Ele_Nue = 2
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Select Case PictureBox3.Tag
            Case "1" : PictureBox3.Image = My.Resources.pic1
            Case "2" : PictureBox3.Image = My.Resources.pic2
            Case "3" : PictureBox3.Image = My.Resources.pic3
            Case "4" : PictureBox3.Image = My.Resources.pic4
            Case "5" : PictureBox3.Image = My.Resources.pic5
            Case "6" : PictureBox3.Image = My.Resources.pic6
            Case "7" : PictureBox3.Image = My.Resources.pic7
            Case "8" : PictureBox3.Image = My.Resources.pic8
            Case "9" : PictureBox3.Image = My.Resources.pic9
            Case "10" : PictureBox3.Image = My.Resources.pic10
            Case "11" : PictureBox3.Image = My.Resources.pic11
            Case "12" : PictureBox3.Image = My.Resources.pic12
            Case "13" : PictureBox3.Image = My.Resources.pic13
            Case "14" : PictureBox3.Image = My.Resources.pic14
            Case "15" : PictureBox3.Image = My.Resources.pic15
            Case "16" : PictureBox3.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox3.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox3.Tag
            Ele_Act = 3
        Else
            clic = 0
            Img_Nue = PictureBox3.Tag
            Ele_Nue = 3
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Select Case PictureBox4.Tag
            Case "1" : PictureBox4.Image = My.Resources.pic1
            Case "2" : PictureBox4.Image = My.Resources.pic2
            Case "3" : PictureBox4.Image = My.Resources.pic3
            Case "4" : PictureBox4.Image = My.Resources.pic4
            Case "5" : PictureBox4.Image = My.Resources.pic5
            Case "6" : PictureBox4.Image = My.Resources.pic6
            Case "7" : PictureBox4.Image = My.Resources.pic7
            Case "8" : PictureBox4.Image = My.Resources.pic8
            Case "9" : PictureBox4.Image = My.Resources.pic9
            Case "10" : PictureBox4.Image = My.Resources.pic10
            Case "11" : PictureBox4.Image = My.Resources.pic11
            Case "12" : PictureBox4.Image = My.Resources.pic12
            Case "13" : PictureBox4.Image = My.Resources.pic13
            Case "14" : PictureBox4.Image = My.Resources.pic14
            Case "15" : PictureBox4.Image = My.Resources.pic15
            Case "16" : PictureBox4.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox4.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox4.Tag
            Ele_Act = 4
        Else
            clic = 0
            Img_Nue = PictureBox4.Tag
            Ele_Nue = 4
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Select Case PictureBox5.Tag
            Case "1" : PictureBox5.Image = My.Resources.pic1
            Case "2" : PictureBox5.Image = My.Resources.pic2
            Case "3" : PictureBox5.Image = My.Resources.pic3
            Case "4" : PictureBox5.Image = My.Resources.pic4
            Case "5" : PictureBox5.Image = My.Resources.pic5
            Case "6" : PictureBox5.Image = My.Resources.pic6
            Case "7" : PictureBox5.Image = My.Resources.pic7
            Case "8" : PictureBox5.Image = My.Resources.pic8
            Case "9" : PictureBox5.Image = My.Resources.pic9
            Case "10" : PictureBox5.Image = My.Resources.pic10
            Case "11" : PictureBox5.Image = My.Resources.pic11
            Case "12" : PictureBox5.Image = My.Resources.pic12
            Case "13" : PictureBox5.Image = My.Resources.pic13
            Case "14" : PictureBox5.Image = My.Resources.pic14
            Case "15" : PictureBox5.Image = My.Resources.pic15
            Case "16" : PictureBox5.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox5.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox5.Tag
            Ele_Act = 5
        Else
            clic = 0
            Img_Nue = PictureBox5.Tag
            Ele_Nue = 5
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Select Case PictureBox6.Tag
            Case "1" : PictureBox6.Image = My.Resources.pic1
            Case "2" : PictureBox6.Image = My.Resources.pic2
            Case "3" : PictureBox6.Image = My.Resources.pic3
            Case "4" : PictureBox6.Image = My.Resources.pic4
            Case "5" : PictureBox6.Image = My.Resources.pic5
            Case "6" : PictureBox6.Image = My.Resources.pic6
            Case "7" : PictureBox6.Image = My.Resources.pic7
            Case "8" : PictureBox6.Image = My.Resources.pic8
            Case "9" : PictureBox6.Image = My.Resources.pic9
            Case "10" : PictureBox6.Image = My.Resources.pic10
            Case "11" : PictureBox6.Image = My.Resources.pic11
            Case "12" : PictureBox6.Image = My.Resources.pic12
            Case "13" : PictureBox6.Image = My.Resources.pic13
            Case "14" : PictureBox6.Image = My.Resources.pic14
            Case "15" : PictureBox6.Image = My.Resources.pic15
            Case "16" : PictureBox6.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox6.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox6.Tag
            Ele_Act = 6
        Else
            clic = 0
            Img_Nue = PictureBox6.Tag
            Ele_Nue = 6
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Select Case PictureBox7.Tag
            Case "1" : PictureBox7.Image = My.Resources.pic1
            Case "2" : PictureBox7.Image = My.Resources.pic2
            Case "3" : PictureBox7.Image = My.Resources.pic3
            Case "4" : PictureBox7.Image = My.Resources.pic4
            Case "5" : PictureBox7.Image = My.Resources.pic5
            Case "6" : PictureBox7.Image = My.Resources.pic6
            Case "7" : PictureBox7.Image = My.Resources.pic7
            Case "8" : PictureBox7.Image = My.Resources.pic8
            Case "9" : PictureBox7.Image = My.Resources.pic9
            Case "10" : PictureBox7.Image = My.Resources.pic10
            Case "11" : PictureBox7.Image = My.Resources.pic11
            Case "12" : PictureBox7.Image = My.Resources.pic12
            Case "13" : PictureBox7.Image = My.Resources.pic13
            Case "14" : PictureBox7.Image = My.Resources.pic14
            Case "15" : PictureBox7.Image = My.Resources.pic15
            Case "16" : PictureBox7.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox7.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox7.Tag
            Ele_Act = 7
        Else
            clic = 0
            Img_Nue = PictureBox7.Tag
            Ele_Nue = 7
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Select Case PictureBox8.Tag
            Case "1" : PictureBox8.Image = My.Resources.pic1
            Case "2" : PictureBox8.Image = My.Resources.pic2
            Case "3" : PictureBox8.Image = My.Resources.pic3
            Case "4" : PictureBox8.Image = My.Resources.pic4
            Case "5" : PictureBox8.Image = My.Resources.pic5
            Case "6" : PictureBox8.Image = My.Resources.pic6
            Case "7" : PictureBox8.Image = My.Resources.pic7
            Case "8" : PictureBox8.Image = My.Resources.pic8
            Case "9" : PictureBox8.Image = My.Resources.pic9
            Case "10" : PictureBox8.Image = My.Resources.pic10
            Case "11" : PictureBox8.Image = My.Resources.pic11
            Case "12" : PictureBox8.Image = My.Resources.pic12
            Case "13" : PictureBox8.Image = My.Resources.pic13
            Case "14" : PictureBox8.Image = My.Resources.pic14
            Case "15" : PictureBox8.Image = My.Resources.pic15
            Case "16" : PictureBox8.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox8.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox8.Tag
            Ele_Act = 8
        Else
            clic = 0
            Img_Nue = PictureBox8.Tag
            Ele_Nue = 8
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Select Case PictureBox9.Tag
            Case "1" : PictureBox9.Image = My.Resources.pic1
            Case "2" : PictureBox9.Image = My.Resources.pic2
            Case "3" : PictureBox9.Image = My.Resources.pic3
            Case "4" : PictureBox9.Image = My.Resources.pic4
            Case "5" : PictureBox9.Image = My.Resources.pic5
            Case "6" : PictureBox9.Image = My.Resources.pic6
            Case "7" : PictureBox9.Image = My.Resources.pic7
            Case "8" : PictureBox9.Image = My.Resources.pic8
            Case "9" : PictureBox9.Image = My.Resources.pic9
            Case "10" : PictureBox9.Image = My.Resources.pic10
            Case "11" : PictureBox9.Image = My.Resources.pic11
            Case "12" : PictureBox9.Image = My.Resources.pic12
            Case "13" : PictureBox9.Image = My.Resources.pic13
            Case "14" : PictureBox9.Image = My.Resources.pic14
            Case "15" : PictureBox9.Image = My.Resources.pic15
            Case "16" : PictureBox9.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox9.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox9.Tag
            Ele_Act = 9
        Else
            clic = 0
            Img_Nue = PictureBox9.Tag
            Ele_Nue = 9
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Select Case PictureBox10.Tag
            Case "1" : PictureBox10.Image = My.Resources.pic1
            Case "2" : PictureBox10.Image = My.Resources.pic2
            Case "3" : PictureBox10.Image = My.Resources.pic3
            Case "4" : PictureBox10.Image = My.Resources.pic4
            Case "5" : PictureBox10.Image = My.Resources.pic5
            Case "6" : PictureBox10.Image = My.Resources.pic6
            Case "7" : PictureBox10.Image = My.Resources.pic7
            Case "8" : PictureBox10.Image = My.Resources.pic8
            Case "9" : PictureBox10.Image = My.Resources.pic9
            Case "10" : PictureBox10.Image = My.Resources.pic10
            Case "11" : PictureBox10.Image = My.Resources.pic11
            Case "12" : PictureBox10.Image = My.Resources.pic12
            Case "13" : PictureBox10.Image = My.Resources.pic13
            Case "14" : PictureBox10.Image = My.Resources.pic14
            Case "15" : PictureBox10.Image = My.Resources.pic15
            Case "16" : PictureBox10.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox10.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox10.Tag
            Ele_Act = 10
        Else
            clic = 0
            Img_Nue = PictureBox10.Tag
            Ele_Nue = 10
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Select Case PictureBox11.Tag
            Case "1" : PictureBox11.Image = My.Resources.pic1
            Case "2" : PictureBox11.Image = My.Resources.pic2
            Case "3" : PictureBox11.Image = My.Resources.pic3
            Case "4" : PictureBox11.Image = My.Resources.pic4
            Case "5" : PictureBox11.Image = My.Resources.pic5
            Case "6" : PictureBox11.Image = My.Resources.pic6
            Case "7" : PictureBox11.Image = My.Resources.pic7
            Case "8" : PictureBox11.Image = My.Resources.pic8
            Case "9" : PictureBox11.Image = My.Resources.pic9
            Case "10" : PictureBox11.Image = My.Resources.pic10
            Case "11" : PictureBox11.Image = My.Resources.pic11
            Case "12" : PictureBox11.Image = My.Resources.pic12
            Case "13" : PictureBox11.Image = My.Resources.pic13
            Case "14" : PictureBox11.Image = My.Resources.pic14
            Case "15" : PictureBox11.Image = My.Resources.pic15
            Case "16" : PictureBox11.Image = My.Resources.pic15
            Case Else : MsgBox("Ninguno" & PictureBox11.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox11.Tag
            Ele_Act = 11
        Else
            clic = 0
            Img_Nue = PictureBox11.Tag
            Ele_Nue = 11
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Select Case PictureBox12.Tag
            Case "1" : PictureBox12.Image = My.Resources.pic1
            Case "2" : PictureBox12.Image = My.Resources.pic2
            Case "3" : PictureBox12.Image = My.Resources.pic3
            Case "4" : PictureBox12.Image = My.Resources.pic4
            Case "5" : PictureBox12.Image = My.Resources.pic5
            Case "6" : PictureBox12.Image = My.Resources.pic6
            Case "7" : PictureBox12.Image = My.Resources.pic7
            Case "8" : PictureBox12.Image = My.Resources.pic8
            Case "9" : PictureBox12.Image = My.Resources.pic9
            Case "10" : PictureBox12.Image = My.Resources.pic10
            Case "11" : PictureBox12.Image = My.Resources.pic11
            Case "12" : PictureBox12.Image = My.Resources.pic12
            Case "13" : PictureBox12.Image = My.Resources.pic13
            Case "14" : PictureBox12.Image = My.Resources.pic14
            Case "15" : PictureBox12.Image = My.Resources.pic15
            Case "16" : PictureBox12.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox12.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox12.Tag
            Ele_Act = 12
        Else
            clic = 0
            Img_Nue = PictureBox12.Tag
            Ele_Nue = 12
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Select Case PictureBox13.Tag
            Case "1" : PictureBox13.Image = My.Resources.pic1
            Case "2" : PictureBox13.Image = My.Resources.pic2
            Case "3" : PictureBox13.Image = My.Resources.pic3
            Case "4" : PictureBox13.Image = My.Resources.pic4
            Case "5" : PictureBox13.Image = My.Resources.pic5
            Case "6" : PictureBox13.Image = My.Resources.pic6
            Case "7" : PictureBox13.Image = My.Resources.pic7
            Case "8" : PictureBox13.Image = My.Resources.pic8
            Case "9" : PictureBox13.Image = My.Resources.pic9
            Case "10" : PictureBox13.Image = My.Resources.pic10
            Case "11" : PictureBox13.Image = My.Resources.pic11
            Case "12" : PictureBox13.Image = My.Resources.pic12
            Case "13" : PictureBox13.Image = My.Resources.pic13
            Case "14" : PictureBox13.Image = My.Resources.pic14
            Case "15" : PictureBox13.Image = My.Resources.pic15
            Case "16" : PictureBox13.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox13.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox13.Tag
            Ele_Act = 13
        Else
            clic = 0
            Img_Nue = PictureBox13.Tag
            Ele_Nue = 13
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Select Case PictureBox14.Tag
            Case "1" : PictureBox14.Image = My.Resources.pic1
            Case "2" : PictureBox14.Image = My.Resources.pic2
            Case "3" : PictureBox14.Image = My.Resources.pic3
            Case "4" : PictureBox14.Image = My.Resources.pic4
            Case "5" : PictureBox14.Image = My.Resources.pic5
            Case "6" : PictureBox14.Image = My.Resources.pic6
            Case "7" : PictureBox14.Image = My.Resources.pic7
            Case "8" : PictureBox14.Image = My.Resources.pic8
            Case "9" : PictureBox14.Image = My.Resources.pic9
            Case "10" : PictureBox14.Image = My.Resources.pic10
            Case "11" : PictureBox14.Image = My.Resources.pic11
            Case "12" : PictureBox14.Image = My.Resources.pic12
            Case "13" : PictureBox14.Image = My.Resources.pic13
            Case "14" : PictureBox14.Image = My.Resources.pic14
            Case "15" : PictureBox14.Image = My.Resources.pic15
            Case "16" : PictureBox14.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox14.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox14.Tag
            Ele_Act = 14
        Else
            clic = 0
            Img_Nue = PictureBox14.Tag
            Ele_Nue = 14
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Select Case PictureBox15.Tag
            Case "1" : PictureBox15.Image = My.Resources.pic1
            Case "2" : PictureBox15.Image = My.Resources.pic2
            Case "3" : PictureBox15.Image = My.Resources.pic3
            Case "4" : PictureBox15.Image = My.Resources.pic4
            Case "5" : PictureBox15.Image = My.Resources.pic5
            Case "6" : PictureBox15.Image = My.Resources.pic6
            Case "7" : PictureBox15.Image = My.Resources.pic7
            Case "8" : PictureBox15.Image = My.Resources.pic8
            Case "9" : PictureBox15.Image = My.Resources.pic9
            Case "10" : PictureBox15.Image = My.Resources.pic10
            Case "11" : PictureBox15.Image = My.Resources.pic11
            Case "12" : PictureBox15.Image = My.Resources.pic12
            Case "13" : PictureBox15.Image = My.Resources.pic13
            Case "14" : PictureBox15.Image = My.Resources.pic14
            Case "15" : PictureBox15.Image = My.Resources.pic15
            Case "16" : PictureBox15.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox15.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox15.Tag
            Ele_Act = 15
        Else
            clic = 0
            Img_Nue = PictureBox15.Tag
            Ele_Nue = 15
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        Select Case PictureBox16.Tag
            Case "1" : PictureBox16.Image = My.Resources.pic1
            Case "2" : PictureBox16.Image = My.Resources.pic2
            Case "3" : PictureBox16.Image = My.Resources.pic3
            Case "4" : PictureBox16.Image = My.Resources.pic4
            Case "5" : PictureBox16.Image = My.Resources.pic5
            Case "6" : PictureBox16.Image = My.Resources.pic6
            Case "7" : PictureBox16.Image = My.Resources.pic7
            Case "8" : PictureBox16.Image = My.Resources.pic8
            Case "9" : PictureBox16.Image = My.Resources.pic9
            Case "10" : PictureBox16.Image = My.Resources.pic10
            Case "11" : PictureBox16.Image = My.Resources.pic11
            Case "12" : PictureBox16.Image = My.Resources.pic12
            Case "13" : PictureBox16.Image = My.Resources.pic13
            Case "14" : PictureBox16.Image = My.Resources.pic14
            Case "15" : PictureBox16.Image = My.Resources.pic15
            Case "16" : PictureBox16.Image = My.Resources.pic16
            Case Else : MsgBox("Ninguno" & PictureBox16.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox16.Tag
            Ele_Act = 16
        Else
            clic = 0
            Img_Nue = PictureBox16.Tag
            Ele_Nue = 16
            ver_pareja()
        End If
    End Sub


    Private Sub tim_conteo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tim_conteo.Tick
        LblConteo.Text = LblConteo.Text - 1
        If LblConteo.Text = "0" Then
            tim_conteo.Enabled = False
            FrmPerdiste2.Show()
        End If
    End Sub

    Private Sub PbxJugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxJugar.Click

        LblConteo.Text = "40"
        tim_conteo.Enabled = True


        If PbxJugar.Enabled = True Then
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True

            PictureBox1.Image = My.Resources.signo
            PictureBox2.Image = My.Resources.signo
            PictureBox3.Image = My.Resources.signo
            PictureBox4.Image = My.Resources.signo
            PictureBox5.Image = My.Resources.signo
            PictureBox6.Image = My.Resources.signo
            PictureBox7.Image = My.Resources.signo
            PictureBox8.Image = My.Resources.signo
            PictureBox9.Image = My.Resources.signo
            PictureBox10.Image = My.Resources.signo
            PictureBox11.Image = My.Resources.signo
            PictureBox12.Image = My.Resources.signo
            PictureBox13.Image = My.Resources.signo
            PictureBox14.Image = My.Resources.signo
            PictureBox15.Image = My.Resources.signo
            PictureBox16.Image = My.Resources.signo

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()
            PictureBox5.Show()
            PictureBox6.Show()
            PictureBox7.Show()
            PictureBox8.Show()
            PictureBox9.Show()
            PictureBox10.Show()
            PictureBox11.Show()
            PictureBox12.Show()
            PictureBox13.Show()
            PictureBox14.Show()
            PictureBox15.Show()
            PictureBox16.Show()
            Randomize()

            Dim i, j As Integer
            Dim pareja As Integer
            Dim conta As Integer
            Dim vec(16) As Integer
            ListBox1.Items.Clear()

            Max = 8
            For i = 1 To Max * 2
                vec(i) = 0
            Next
            i = 1
            Do While i <= Max * 2
                pareja = Rnd() * Max + 1
                If pareja <= Max Then
                    conta = 0
                    For j = 1 To Max * 2
                        If vec(j) = pareja Then
                            conta = conta + 1
                        End If
                    Next
                    If conta < 2 Then
                        vec(i) = pareja
                        ListBox1.Items.Add(i & " " & vec(i) & "con" & conta)
                        i = i + 1
                    End If
                End If
            Loop

            PictureBox1.Tag = vec(1)
            PictureBox2.Tag = vec(2)
            PictureBox3.Tag = vec(3)
            PictureBox4.Tag = vec(4)
            PictureBox5.Tag = vec(5)
            PictureBox6.Tag = vec(6)
            PictureBox7.Tag = vec(7)
            PictureBox8.Tag = vec(8)
            PictureBox9.Tag = vec(9)
            PictureBox10.Tag = vec(10)
            PictureBox11.Tag = vec(11)
            PictureBox12.Tag = vec(12)
            PictureBox13.Tag = vec(13)
            PictureBox14.Tag = vec(14)
            PictureBox15.Tag = vec(15)
            PictureBox16.Tag = vec(16)
            clic = 0
            Aciertos = 0
            Fallas = 0
            Max = 8
            GroupBox1.Enabled = True
        End If
    End Sub
    

    Private Sub tim_verparejas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tim_verparejas.Tick
        segundos = segundos + 1
        If segundos >= 3 Then
            tim_verparejas.Enabled = False
            segundos = 0
            GroupBox1.Enabled = True
            Select Case (Ele_Nue)
                Case 1 : PictureBox1.Image = My.Resources.signo
                Case 2 : PictureBox2.Image = My.Resources.signo
                Case 3 : PictureBox3.Image = My.Resources.signo
                Case 4 : PictureBox4.Image = My.Resources.signo
                Case 5 : PictureBox5.Image = My.Resources.signo
                Case 6 : PictureBox6.Image = My.Resources.signo
                Case 7 : PictureBox7.Image = My.Resources.signo
                Case 8 : PictureBox8.Image = My.Resources.signo
                Case 9 : PictureBox9.Image = My.Resources.signo
                Case 10 : PictureBox10.Image = My.Resources.signo
                Case 11 : PictureBox11.Image = My.Resources.signo
                Case 12 : PictureBox12.Image = My.Resources.signo
                Case 13 : PictureBox13.Image = My.Resources.signo
                Case 14 : PictureBox14.Image = My.Resources.signo
                Case 15 : PictureBox15.Image = My.Resources.signo
                Case 16 : PictureBox16.Image = My.Resources.signo
            End Select
            Select Case (Ele_Act)
                Case 1 : PictureBox1.Image = My.Resources.signo
                Case 2 : PictureBox2.Image = My.Resources.signo
                Case 3 : PictureBox3.Image = My.Resources.signo
                Case 4 : PictureBox4.Image = My.Resources.signo
                Case 5 : PictureBox5.Image = My.Resources.signo
                Case 6 : PictureBox6.Image = My.Resources.signo
                Case 7 : PictureBox7.Image = My.Resources.signo
                Case 8 : PictureBox8.Image = My.Resources.signo
                Case 9 : PictureBox9.Image = My.Resources.signo
                Case 10 : PictureBox10.Image = My.Resources.signo
                Case 11 : PictureBox11.Image = My.Resources.signo
                Case 12 : PictureBox12.Image = My.Resources.signo
                Case 13 : PictureBox13.Image = My.Resources.signo
                Case 14 : PictureBox14.Image = My.Resources.signo
                Case 15 : PictureBox15.Image = My.Resources.signo
                Case 16 : PictureBox16.Image = My.Resources.signo
            End Select
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PbxJugar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxJugar.MouseEnter
        My.Computer.Audio.Play(My.Resources.interaccion, AudioPlayMode.Background)

        PbxJugar.Height = 80
        PbxJugar.Width = 260
    End Sub

    Private Sub PbxJugar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PbxJugar.MouseLeave
        My.Computer.Audio.Stop()
        PbxJugar.Height = 69
        PbxJugar.Width = 245
    End Sub

    Private Sub PbxSal_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxSal.MouseEnter
        My.Computer.Audio.Play(My.Resources.interaccion, AudioPlayMode.Background)
        PbxSal.Height = 80
        PbxSal.Width = 260
    End Sub

    Private Sub PbxSal_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PbxSal.MouseLeave
        My.Computer.Audio.Stop()
        PbxSal.Height = 69
        PbxSal.Width = 245
    End Sub

    Private Sub PbxSal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxSal.Click
        tim_conteo.Enabled = False
        Salir2.Show()

    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        opciones2.Show()
        tim_conteo.Enabled = False
    End Sub
End Class
