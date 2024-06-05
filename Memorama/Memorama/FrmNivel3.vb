Public Class FrmNivel3

    Dim Aciertos As Byte
    Dim Fallas As Byte
    Dim clic As Byte
    Dim Ima_act As String
    Dim Ele_act As Byte
    Dim Ima_nue As String
    Dim Ele_nue As Byte
    Dim Max As Integer
    Dim segundos As Byte

    Private Function Aleatorio1(ByVal minimo As Long, ByVal maximo As Long) As Long
        Randomize()
        Aleatorio1 = CLng((minimo - maximo) * Rnd() + maximo)
    End Function

    Sub ver_pareja()

        If Ima_nue = Ima_act Then

            Aciertos = Aciertos + 1

            If Aciertos = Max Then
                FrmVictoria.Show()
                Me.Hide()
                TimConteo.Enabled = False
            End If

            Select Case (Ele_nue)
                Case 1 : Pbx1.Enabled = False
                Case 2 : Pbx2.Enabled = False
                Case 3 : Pbx3.Enabled = False
                Case 4 : Pbx4.Enabled = False
                Case 5 : Pbx5.Enabled = False
                Case 6 : Pbx6.Enabled = False
                Case 7 : Pbx7.Enabled = False
                Case 8 : Pbx8.Enabled = False
                Case 9 : Pbx9.Enabled = False
                Case 10 : Pbx10.Enabled = False
                Case 11 : Pbx11.Enabled = False
                Case 12 : Pbx12.Enabled = False
                Case 13 : Pbx13.Enabled = False
                Case 14 : Pbx14.Enabled = False
                Case 15 : Pbx15.Enabled = False
                Case 16 : Pbx16.Enabled = False
                Case 17 : Pbx17.Enabled = False
                Case 18 : Pbx18.Enabled = False
                Case 19 : Pbx19.Enabled = False
                Case 20 : Pbx20.Enabled = False
                Case 21 : Pbx21.Enabled = False
                Case 22 : Pbx22.Enabled = False
                Case 23 : Pbx23.Enabled = False
                Case 24 : Pbx24.Enabled = False
            End Select

            Select Case (Ele_act)
                Case 1 : Pbx1.Enabled = False
                Case 2 : Pbx2.Enabled = False
                Case 3 : Pbx3.Enabled = False
                Case 4 : Pbx4.Enabled = False
                Case 5 : Pbx5.Enabled = False
                Case 6 : Pbx6.Enabled = False
                Case 7 : Pbx7.Enabled = False
                Case 8 : Pbx8.Enabled = False
                Case 9 : Pbx9.Enabled = False
                Case 10 : Pbx10.Enabled = False
                Case 11 : Pbx11.Enabled = False
                Case 12 : Pbx12.Enabled = False
                Case 13 : Pbx13.Enabled = False
                Case 14 : Pbx14.Enabled = False
                Case 15 : Pbx15.Enabled = False
                Case 16 : Pbx16.Enabled = False
                Case 17 : Pbx17.Enabled = False
                Case 18 : Pbx18.Enabled = False
                Case 19 : Pbx19.Enabled = False
                Case 20 : Pbx20.Enabled = False
                Case 21 : Pbx21.Enabled = False
                Case 22 : Pbx22.Enabled = False
                Case 23 : Pbx23.Enabled = False
                Case 24 : Pbx24.Enabled = False
            End Select
        Else
            GroupBox1.Enabled = False
            TimVer.Enabled = True
        End If

    End Sub


    Private Sub Pbx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbx1.Click
        Select Case Pbx1.Tag

            Case "1" : Pbx1.Image = My.Resources.Par_1_3
            Case "2" : Pbx1.Image = My.Resources.Par_2_3
            Case "3" : Pbx1.Image = My.Resources.Par_3_3
            Case "4" : Pbx1.Image = My.Resources.Par_4_3
            Case "5" : Pbx1.Image = My.Resources.Par_5_3
            Case "6" : Pbx1.Image = My.Resources.Par_6_3
            Case "7" : Pbx1.Image = My.Resources.Par_7_3
            Case "8" : Pbx1.Image = My.Resources.Par_8_3
            Case "9 " : Pbx1.Image = My.Resources.Par_9_3
            Case "10 " : Pbx1.Image = My.Resources.Par_10_3
            Case "11 " : Pbx1.Image = My.Resources.Par_11_3
            Case "12 " : Pbx1.Image = My.Resources.Par_12_3
            Case "13 " : Pbx1.Image = My.Resources.Par_13_3
            Case "14 " : Pbx1.Image = My.Resources.Par_14_3
            Case "15 " : Pbx1.Image = My.Resources.Par_15_3
            Case "16 " : Pbx1.Image = My.Resources.Par_16_3
            Case "17 " : Pbx1.Image = My.Resources.Par_17_3
            Case "18 " : Pbx1.Image = My.Resources.Par_18_3
            Case "19 " : Pbx1.Image = My.Resources.Par_19_3
            Case "20 " : Pbx1.Image = My.Resources.Par_20_3
            Case "21 " : Pbx1.Image = My.Resources.Par_21_3
            Case "22 " : Pbx1.Image = My.Resources.Par_22_3
            Case "23 " : Pbx1.Image = My.Resources.Par_23_3
            Case "24 " : Pbx1.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx1.Tag)

        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx1.Tag
            Ele_act = 1
        Else
            clic = 0
            Ima_nue = Pbx1.Tag
            Ele_nue = 1
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx2_Click(sender As System.Object, e As System.EventArgs) Handles Pbx2.Click
        Select Case Pbx2.Tag

            Case "1" : Pbx2.Image = My.Resources.Par_1_3
            Case "2" : Pbx2.Image = My.Resources.Par_2_3
            Case "3" : Pbx2.Image = My.Resources.Par_3_3
            Case "4" : Pbx2.Image = My.Resources.Par_4_3
            Case "5" : Pbx2.Image = My.Resources.Par_5_3
            Case "6" : Pbx2.Image = My.Resources.Par_6_3
            Case "7" : Pbx2.Image = My.Resources.Par_7_3
            Case "8" : Pbx2.Image = My.Resources.Par_8_3
            Case "9 " : Pbx2.Image = My.Resources.Par_9_3
            Case "10 " : Pbx2.Image = My.Resources.Par_10_3
            Case "11 " : Pbx2.Image = My.Resources.Par_11_3
            Case "12 " : Pbx2.Image = My.Resources.Par_12_3
            Case "13 " : Pbx2.Image = My.Resources.Par_13_3
            Case "14 " : Pbx2.Image = My.Resources.Par_14_3
            Case "15 " : Pbx2.Image = My.Resources.Par_15_3
            Case "16 " : Pbx2.Image = My.Resources.Par_16_3
            Case "17 " : Pbx2.Image = My.Resources.Par_17_3
            Case "18 " : Pbx2.Image = My.Resources.Par_18_3
            Case "19 " : Pbx2.Image = My.Resources.Par_19_3
            Case "20 " : Pbx2.Image = My.Resources.Par_20_3
            Case "21 " : Pbx2.Image = My.Resources.Par_21_3
            Case "22 " : Pbx2.Image = My.Resources.Par_22_3
            Case "23 " : Pbx2.Image = My.Resources.Par_23_3
            Case "24 " : Pbx2.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx2.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx2.Tag
            Ele_act = 2
        Else
            clic = 0
            Ima_nue = Pbx2.Tag
            Ele_nue = 2
            ver_pareja()
        End If
    End Sub


    Private Sub Pbx3_Click(sender As System.Object, e As System.EventArgs) Handles Pbx3.Click
        Select Case Pbx3.Tag

            Case "1" : Pbx3.Image = My.Resources.Par_1_3
            Case "2" : Pbx3.Image = My.Resources.Par_2_3
            Case "3" : Pbx3.Image = My.Resources.Par_3_3
            Case "4" : Pbx3.Image = My.Resources.Par_4_3
            Case "5" : Pbx3.Image = My.Resources.Par_5_3
            Case "6" : Pbx3.Image = My.Resources.Par_6_3
            Case "7" : Pbx3.Image = My.Resources.Par_7_3
            Case "8" : Pbx3.Image = My.Resources.Par_8_3
            Case "9 " : Pbx3.Image = My.Resources.Par_9_3
            Case "10 " : Pbx3.Image = My.Resources.Par_10_3
            Case "11 " : Pbx3.Image = My.Resources.Par_11_3
            Case "12 " : Pbx3.Image = My.Resources.Par_12_3
            Case "13 " : Pbx3.Image = My.Resources.Par_13_3
            Case "14 " : Pbx3.Image = My.Resources.Par_14_3
            Case "15 " : Pbx3.Image = My.Resources.Par_15_3
            Case "16 " : Pbx3.Image = My.Resources.Par_16_3
            Case "17 " : Pbx3.Image = My.Resources.Par_17_3
            Case "18 " : Pbx3.Image = My.Resources.Par_18_3
            Case "19 " : Pbx3.Image = My.Resources.Par_19_3
            Case "20 " : Pbx3.Image = My.Resources.Par_20_3
            Case "21 " : Pbx3.Image = My.Resources.Par_21_3
            Case "22 " : Pbx3.Image = My.Resources.Par_22_3
            Case "23 " : Pbx3.Image = My.Resources.Par_23_3
            Case "24 " : Pbx3.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx3.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx3.Tag
            Ele_act = 3
        Else
            clic = 0
            Ima_nue = Pbx3.Tag
            Ele_nue = 3
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx4_Click(sender As System.Object, e As System.EventArgs) Handles Pbx4.Click
        Select Case Pbx4.Tag

            Case "1" : Pbx4.Image = My.Resources.Par_1_3
            Case "2" : Pbx4.Image = My.Resources.Par_2_3
            Case "3" : Pbx4.Image = My.Resources.Par_3_3
            Case "4" : Pbx4.Image = My.Resources.Par_4_3
            Case "5" : Pbx4.Image = My.Resources.Par_5_3
            Case "6" : Pbx4.Image = My.Resources.Par_6_3
            Case "7" : Pbx4.Image = My.Resources.Par_7_3
            Case "8" : Pbx4.Image = My.Resources.Par_8_3
            Case "9 " : Pbx4.Image = My.Resources.Par_9_3
            Case "10 " : Pbx4.Image = My.Resources.Par_10_3
            Case "11 " : Pbx4.Image = My.Resources.Par_11_3
            Case "12 " : Pbx4.Image = My.Resources.Par_12_3
            Case "13 " : Pbx4.Image = My.Resources.Par_13_3
            Case "14 " : Pbx4.Image = My.Resources.Par_14_3
            Case "15 " : Pbx4.Image = My.Resources.Par_15_3
            Case "16 " : Pbx4.Image = My.Resources.Par_16_3
            Case "17 " : Pbx4.Image = My.Resources.Par_17_3
            Case "18 " : Pbx4.Image = My.Resources.Par_18_3
            Case "19 " : Pbx4.Image = My.Resources.Par_19_3
            Case "20 " : Pbx4.Image = My.Resources.Par_20_3
            Case "21 " : Pbx4.Image = My.Resources.Par_21_3
            Case "22 " : Pbx4.Image = My.Resources.Par_22_3
            Case "23 " : Pbx4.Image = My.Resources.Par_23_3
            Case "24 " : Pbx4.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx4.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx4.Tag
            Ele_act = 4
        Else
            clic = 0
            Ima_nue = Pbx4.Tag
            Ele_nue = 4
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx5_Click(sender As System.Object, e As System.EventArgs) Handles Pbx5.Click
        Select Case Pbx5.Tag

            Case "1" : Pbx5.Image = My.Resources.Par_1_3
            Case "2" : Pbx5.Image = My.Resources.Par_2_3
            Case "3" : Pbx5.Image = My.Resources.Par_3_3
            Case "4" : Pbx5.Image = My.Resources.Par_4_3
            Case "5" : Pbx5.Image = My.Resources.Par_5_3
            Case "6" : Pbx5.Image = My.Resources.Par_6_3
            Case "7" : Pbx5.Image = My.Resources.Par_7_3
            Case "8" : Pbx5.Image = My.Resources.Par_8_3
            Case "9 " : Pbx5.Image = My.Resources.Par_9_3
            Case "10 " : Pbx5.Image = My.Resources.Par_10_3
            Case "11 " : Pbx5.Image = My.Resources.Par_11_3
            Case "12 " : Pbx5.Image = My.Resources.Par_12_3
            Case "13 " : Pbx5.Image = My.Resources.Par_13_3
            Case "14 " : Pbx5.Image = My.Resources.Par_14_3
            Case "15 " : Pbx5.Image = My.Resources.Par_15_3
            Case "16 " : Pbx5.Image = My.Resources.Par_16_3
            Case "17 " : Pbx5.Image = My.Resources.Par_17_3
            Case "18 " : Pbx5.Image = My.Resources.Par_18_3
            Case "19 " : Pbx5.Image = My.Resources.Par_19_3
            Case "20 " : Pbx5.Image = My.Resources.Par_20_3
            Case "21 " : Pbx5.Image = My.Resources.Par_21_3
            Case "22 " : Pbx5.Image = My.Resources.Par_22_3
            Case "23 " : Pbx5.Image = My.Resources.Par_23_3
            Case "24 " : Pbx5.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx3.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx5.Tag
            Ele_act = 5
        Else
            clic = 0
            Ima_nue = Pbx5.Tag
            Ele_nue = 5
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx6_Click(sender As System.Object, e As System.EventArgs) Handles Pbx6.Click
        Select Case Pbx6.Tag

            Case "1" : Pbx6.Image = My.Resources.Par_1_3
            Case "2" : Pbx6.Image = My.Resources.Par_2_3
            Case "3" : Pbx6.Image = My.Resources.Par_3_3
            Case "4" : Pbx6.Image = My.Resources.Par_4_3
            Case "5" : Pbx6.Image = My.Resources.Par_5_3
            Case "6" : Pbx6.Image = My.Resources.Par_6_3
            Case "7" : Pbx6.Image = My.Resources.Par_7_3
            Case "8" : Pbx6.Image = My.Resources.Par_8_3
            Case "9 " : Pbx6.Image = My.Resources.Par_9_3
            Case "10 " : Pbx6.Image = My.Resources.Par_10_3
            Case "11 " : Pbx6.Image = My.Resources.Par_11_3
            Case "12 " : Pbx6.Image = My.Resources.Par_12_3
            Case "13 " : Pbx6.Image = My.Resources.Par_13_3
            Case "14 " : Pbx6.Image = My.Resources.Par_14_3
            Case "15 " : Pbx6.Image = My.Resources.Par_15_3
            Case "16 " : Pbx6.Image = My.Resources.Par_16_3
            Case "17 " : Pbx6.Image = My.Resources.Par_17_3
            Case "18 " : Pbx6.Image = My.Resources.Par_18_3
            Case "19 " : Pbx6.Image = My.Resources.Par_19_3
            Case "20 " : Pbx6.Image = My.Resources.Par_20_3
            Case "21 " : Pbx6.Image = My.Resources.Par_21_3
            Case "22 " : Pbx6.Image = My.Resources.Par_22_3
            Case "23 " : Pbx6.Image = My.Resources.Par_23_3
            Case "24 " : Pbx6.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx6.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx6.Tag
            Ele_act = 6
        Else
            clic = 0
            Ima_nue = Pbx6.Tag
            Ele_nue = 6
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx7_Click(sender As System.Object, e As System.EventArgs) Handles Pbx7.Click
        Select Case Pbx7.Tag

            Case "1" : Pbx7.Image = My.Resources.Par_1_3
            Case "2" : Pbx7.Image = My.Resources.Par_2_3
            Case "3" : Pbx7.Image = My.Resources.Par_3_3
            Case "4" : Pbx7.Image = My.Resources.Par_4_3
            Case "5" : Pbx7.Image = My.Resources.Par_5_3
            Case "6" : Pbx7.Image = My.Resources.Par_6_3
            Case "7" : Pbx7.Image = My.Resources.Par_7_3
            Case "8" : Pbx7.Image = My.Resources.Par_8_3
            Case "9 " : Pbx7.Image = My.Resources.Par_9_3
            Case "10 " : Pbx7.Image = My.Resources.Par_10_3
            Case "11 " : Pbx7.Image = My.Resources.Par_11_3
            Case "12 " : Pbx7.Image = My.Resources.Par_12_3
            Case "13 " : Pbx7.Image = My.Resources.Par_13_3
            Case "14 " : Pbx7.Image = My.Resources.Par_14_3
            Case "15 " : Pbx7.Image = My.Resources.Par_15_3
            Case "16 " : Pbx7.Image = My.Resources.Par_16_3
            Case "17 " : Pbx7.Image = My.Resources.Par_17_3
            Case "18 " : Pbx7.Image = My.Resources.Par_18_3
            Case "19 " : Pbx7.Image = My.Resources.Par_19_3
            Case "20 " : Pbx7.Image = My.Resources.Par_20_3
            Case "21 " : Pbx7.Image = My.Resources.Par_21_3
            Case "22 " : Pbx7.Image = My.Resources.Par_22_3
            Case "23 " : Pbx7.Image = My.Resources.Par_23_3
            Case "24 " : Pbx7.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx7.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx7.Tag
            Ele_act = 7
        Else
            clic = 0
            Ima_nue = Pbx7.Tag
            Ele_nue = 7
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx8_Click(sender As System.Object, e As System.EventArgs) Handles Pbx8.Click
        Select Case Pbx8.Tag

            Case "1" : Pbx8.Image = My.Resources.Par_1_3
            Case "2" : Pbx8.Image = My.Resources.Par_2_3
            Case "3" : Pbx8.Image = My.Resources.Par_3_3
            Case "4" : Pbx8.Image = My.Resources.Par_4_3
            Case "5" : Pbx8.Image = My.Resources.Par_5_3
            Case "6" : Pbx8.Image = My.Resources.Par_6_3
            Case "7" : Pbx8.Image = My.Resources.Par_7_3
            Case "8" : Pbx8.Image = My.Resources.Par_8_3
            Case "9 " : Pbx8.Image = My.Resources.Par_9_3
            Case "10 " : Pbx8.Image = My.Resources.Par_10_3
            Case "11 " : Pbx8.Image = My.Resources.Par_11_3
            Case "12 " : Pbx8.Image = My.Resources.Par_12_3
            Case "13 " : Pbx8.Image = My.Resources.Par_13_3
            Case "14 " : Pbx8.Image = My.Resources.Par_14_3
            Case "15 " : Pbx8.Image = My.Resources.Par_15_3
            Case "16 " : Pbx8.Image = My.Resources.Par_16_3
            Case "17 " : Pbx8.Image = My.Resources.Par_17_3
            Case "18 " : Pbx8.Image = My.Resources.Par_18_3
            Case "19 " : Pbx8.Image = My.Resources.Par_19_3
            Case "20 " : Pbx8.Image = My.Resources.Par_20_3
            Case "21 " : Pbx8.Image = My.Resources.Par_21_3
            Case "22 " : Pbx8.Image = My.Resources.Par_22_3
            Case "23 " : Pbx8.Image = My.Resources.Par_23_3
            Case "24 " : Pbx8.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx8.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx8.Tag
            Ele_act = 8
        Else
            clic = 0
            Ima_nue = Pbx8.Tag
            Ele_nue = 8
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx9_Click(sender As System.Object, e As System.EventArgs) Handles Pbx9.Click
        Select Case Pbx9.Tag

            Case "1" : Pbx9.Image = My.Resources.Par_1_3
            Case "2" : Pbx9.Image = My.Resources.Par_2_3
            Case "3" : Pbx9.Image = My.Resources.Par_3_3
            Case "4" : Pbx9.Image = My.Resources.Par_4_3
            Case "5" : Pbx9.Image = My.Resources.Par_5_3
            Case "6" : Pbx9.Image = My.Resources.Par_6_3
            Case "7" : Pbx9.Image = My.Resources.Par_7_3
            Case "8" : Pbx9.Image = My.Resources.Par_8_3
            Case "9 " : Pbx9.Image = My.Resources.Par_9_3
            Case "10 " : Pbx9.Image = My.Resources.Par_10_3
            Case "11 " : Pbx9.Image = My.Resources.Par_11_3
            Case "12 " : Pbx9.Image = My.Resources.Par_12_3
            Case "13 " : Pbx9.Image = My.Resources.Par_13_3
            Case "14 " : Pbx9.Image = My.Resources.Par_14_3
            Case "15 " : Pbx9.Image = My.Resources.Par_15_3
            Case "16 " : Pbx9.Image = My.Resources.Par_16_3
            Case "17 " : Pbx9.Image = My.Resources.Par_17_3
            Case "18 " : Pbx9.Image = My.Resources.Par_18_3
            Case "19 " : Pbx9.Image = My.Resources.Par_19_3
            Case "20 " : Pbx9.Image = My.Resources.Par_20_3
            Case "21 " : Pbx9.Image = My.Resources.Par_21_3
            Case "22 " : Pbx9.Image = My.Resources.Par_22_3
            Case "23 " : Pbx9.Image = My.Resources.Par_23_3
            Case "24 " : Pbx9.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx9.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx9.Tag
            Ele_act = 9
        Else
            clic = 0
            Ima_nue = Pbx9.Tag
            Ele_nue = 9
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx10_Click(sender As System.Object, e As System.EventArgs) Handles Pbx10.Click
        Select Case Pbx10.Tag

            Case "1" : Pbx10.Image = My.Resources.Par_1_3
            Case "2" : Pbx10.Image = My.Resources.Par_2_3
            Case "3" : Pbx10.Image = My.Resources.Par_3_3
            Case "4" : Pbx10.Image = My.Resources.Par_4_3
            Case "5" : Pbx10.Image = My.Resources.Par_5_3
            Case "6" : Pbx10.Image = My.Resources.Par_6_3
            Case "7" : Pbx10.Image = My.Resources.Par_7_3
            Case "8" : Pbx10.Image = My.Resources.Par_8_3
            Case "9 " : Pbx10.Image = My.Resources.Par_9_3
            Case "10 " : Pbx10.Image = My.Resources.Par_10_3
            Case "11 " : Pbx10.Image = My.Resources.Par_11_3
            Case "12 " : Pbx10.Image = My.Resources.Par_12_3
            Case "13 " : Pbx10.Image = My.Resources.Par_13_3
            Case "14 " : Pbx10.Image = My.Resources.Par_14_3
            Case "15 " : Pbx10.Image = My.Resources.Par_15_3
            Case "16 " : Pbx10.Image = My.Resources.Par_16_3
            Case "17 " : Pbx10.Image = My.Resources.Par_17_3
            Case "18 " : Pbx10.Image = My.Resources.Par_18_3
            Case "19 " : Pbx10.Image = My.Resources.Par_19_3
            Case "20 " : Pbx10.Image = My.Resources.Par_20_3
            Case "21 " : Pbx10.Image = My.Resources.Par_21_3
            Case "22 " : Pbx10.Image = My.Resources.Par_22_3
            Case "23 " : Pbx10.Image = My.Resources.Par_23_3
            Case "24 " : Pbx10.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx10.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx10.Tag
            Ele_act = 10
        Else
            clic = 0
            Ima_nue = Pbx10.Tag
            Ele_nue = 10
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx11_Click(sender As System.Object, e As System.EventArgs) Handles Pbx11.Click
        Select Case Pbx11.Tag

            Case "1" : Pbx11.Image = My.Resources.Par_1_3
            Case "2" : Pbx11.Image = My.Resources.Par_2_3
            Case "3" : Pbx11.Image = My.Resources.Par_3_3
            Case "4" : Pbx11.Image = My.Resources.Par_4_3
            Case "5" : Pbx11.Image = My.Resources.Par_5_3
            Case "6" : Pbx11.Image = My.Resources.Par_6_3
            Case "7" : Pbx11.Image = My.Resources.Par_7_3
            Case "8" : Pbx11.Image = My.Resources.Par_8_3
            Case "9 " : Pbx11.Image = My.Resources.Par_9_3
            Case "10 " : Pbx11.Image = My.Resources.Par_10_3
            Case "11 " : Pbx11.Image = My.Resources.Par_11_3
            Case "12 " : Pbx11.Image = My.Resources.Par_12_3
            Case "13 " : Pbx11.Image = My.Resources.Par_13_3
            Case "14 " : Pbx11.Image = My.Resources.Par_14_3
            Case "15 " : Pbx11.Image = My.Resources.Par_15_3
            Case "16 " : Pbx11.Image = My.Resources.Par_16_3
            Case "17 " : Pbx11.Image = My.Resources.Par_17_3
            Case "18 " : Pbx11.Image = My.Resources.Par_18_3
            Case "19 " : Pbx11.Image = My.Resources.Par_19_3
            Case "20 " : Pbx11.Image = My.Resources.Par_20_3
            Case "21 " : Pbx11.Image = My.Resources.Par_21_3
            Case "22 " : Pbx11.Image = My.Resources.Par_22_3
            Case "23 " : Pbx11.Image = My.Resources.Par_23_3
            Case "24 " : Pbx11.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx11.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx11.Tag
            Ele_act = 11
        Else
            clic = 0
            Ima_nue = Pbx11.Tag
            Ele_nue = 11
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx12_Click(sender As System.Object, e As System.EventArgs) Handles Pbx12.Click
        Select Case Pbx12.Tag

            Case "1" : Pbx12.Image = My.Resources.Par_1_3
            Case "2" : Pbx12.Image = My.Resources.Par_2_3
            Case "3" : Pbx12.Image = My.Resources.Par_3_3
            Case "4" : Pbx12.Image = My.Resources.Par_4_3
            Case "5" : Pbx12.Image = My.Resources.Par_5_3
            Case "6" : Pbx12.Image = My.Resources.Par_6_3
            Case "7" : Pbx12.Image = My.Resources.Par_7_3
            Case "8" : Pbx12.Image = My.Resources.Par_8_3
            Case "9 " : Pbx12.Image = My.Resources.Par_9_3
            Case "10 " : Pbx12.Image = My.Resources.Par_10_3
            Case "11 " : Pbx12.Image = My.Resources.Par_11_3
            Case "12 " : Pbx12.Image = My.Resources.Par_12_3
            Case "13 " : Pbx12.Image = My.Resources.Par_13_3
            Case "14 " : Pbx12.Image = My.Resources.Par_14_3
            Case "15 " : Pbx12.Image = My.Resources.Par_15_3
            Case "16 " : Pbx12.Image = My.Resources.Par_16_3
            Case "17 " : Pbx12.Image = My.Resources.Par_17_3
            Case "18 " : Pbx12.Image = My.Resources.Par_18_3
            Case "19 " : Pbx12.Image = My.Resources.Par_19_3
            Case "20 " : Pbx12.Image = My.Resources.Par_20_3
            Case "21 " : Pbx12.Image = My.Resources.Par_21_3
            Case "22 " : Pbx12.Image = My.Resources.Par_22_3
            Case "23 " : Pbx12.Image = My.Resources.Par_23_3
            Case "24 " : Pbx12.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx12.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx12.Tag
            Ele_act = 12
        Else
            clic = 0
            Ima_nue = Pbx12.Tag
            Ele_nue = 12
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx13_Click(sender As System.Object, e As System.EventArgs) Handles Pbx13.Click
        Select Case Pbx13.Tag

            Case "1" : Pbx13.Image = My.Resources.Par_1_3
            Case "2" : Pbx13.Image = My.Resources.Par_2_3
            Case "3" : Pbx13.Image = My.Resources.Par_3_3
            Case "4" : Pbx13.Image = My.Resources.Par_4_3
            Case "5" : Pbx13.Image = My.Resources.Par_5_3
            Case "6" : Pbx13.Image = My.Resources.Par_6_3
            Case "7" : Pbx13.Image = My.Resources.Par_7_3
            Case "8" : Pbx13.Image = My.Resources.Par_8_3
            Case "9 " : Pbx13.Image = My.Resources.Par_9_3
            Case "10 " : Pbx13.Image = My.Resources.Par_10_3
            Case "11 " : Pbx13.Image = My.Resources.Par_11_3
            Case "12 " : Pbx13.Image = My.Resources.Par_12_3
            Case "13 " : Pbx13.Image = My.Resources.Par_13_3
            Case "14 " : Pbx13.Image = My.Resources.Par_14_3
            Case "15 " : Pbx13.Image = My.Resources.Par_15_3
            Case "16 " : Pbx13.Image = My.Resources.Par_16_3
            Case "17 " : Pbx13.Image = My.Resources.Par_17_3
            Case "18 " : Pbx13.Image = My.Resources.Par_18_3
            Case "19 " : Pbx13.Image = My.Resources.Par_19_3
            Case "20 " : Pbx13.Image = My.Resources.Par_20_3
            Case "21 " : Pbx13.Image = My.Resources.Par_21_3
            Case "22 " : Pbx13.Image = My.Resources.Par_22_3
            Case "23 " : Pbx13.Image = My.Resources.Par_23_3
            Case "24 " : Pbx13.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx13.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx13.Tag
            Ele_act = 13
        Else
            clic = 0
            Ima_nue = Pbx13.Tag
            Ele_nue = 13
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx14_Click(sender As System.Object, e As System.EventArgs) Handles Pbx14.Click
        Select Case Pbx14.Tag

            Case "1" : Pbx14.Image = My.Resources.Par_1_3
            Case "2" : Pbx14.Image = My.Resources.Par_2_3
            Case "3" : Pbx14.Image = My.Resources.Par_3_3
            Case "4" : Pbx14.Image = My.Resources.Par_4_3
            Case "5" : Pbx14.Image = My.Resources.Par_5_3
            Case "6" : Pbx14.Image = My.Resources.Par_6_3
            Case "7" : Pbx14.Image = My.Resources.Par_7_3
            Case "8" : Pbx14.Image = My.Resources.Par_8_3
            Case "9 " : Pbx14.Image = My.Resources.Par_9_3
            Case "10 " : Pbx14.Image = My.Resources.Par_10_3
            Case "11 " : Pbx14.Image = My.Resources.Par_11_3
            Case "12 " : Pbx14.Image = My.Resources.Par_12_3
            Case "13 " : Pbx14.Image = My.Resources.Par_13_3
            Case "14 " : Pbx14.Image = My.Resources.Par_14_3
            Case "15 " : Pbx14.Image = My.Resources.Par_15_3
            Case "16 " : Pbx14.Image = My.Resources.Par_16_3
            Case "17 " : Pbx14.Image = My.Resources.Par_17_3
            Case "18 " : Pbx14.Image = My.Resources.Par_18_3
            Case "19 " : Pbx14.Image = My.Resources.Par_19_3
            Case "20 " : Pbx14.Image = My.Resources.Par_20_3
            Case "21 " : Pbx14.Image = My.Resources.Par_21_3
            Case "22 " : Pbx14.Image = My.Resources.Par_22_3
            Case "23 " : Pbx14.Image = My.Resources.Par_23_3
            Case "24 " : Pbx14.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx14.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx14.Tag
            Ele_act = 14
        Else
            clic = 0
            Ima_nue = Pbx14.Tag
            Ele_nue = 14
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx15_Click(sender As System.Object, e As System.EventArgs) Handles Pbx15.Click
        Select Case Pbx15.Tag

            Case "1" : Pbx15.Image = My.Resources.Par_1_3
            Case "2" : Pbx15.Image = My.Resources.Par_2_3
            Case "3" : Pbx15.Image = My.Resources.Par_3_3
            Case "4" : Pbx15.Image = My.Resources.Par_4_3
            Case "5" : Pbx15.Image = My.Resources.Par_5_3
            Case "6" : Pbx15.Image = My.Resources.Par_6_3
            Case "7" : Pbx15.Image = My.Resources.Par_7_3
            Case "8" : Pbx15.Image = My.Resources.Par_8_3
            Case "9 " : Pbx15.Image = My.Resources.Par_9_3
            Case "10 " : Pbx15.Image = My.Resources.Par_10_3
            Case "11 " : Pbx15.Image = My.Resources.Par_11_3
            Case "12 " : Pbx15.Image = My.Resources.Par_12_3
            Case "13 " : Pbx15.Image = My.Resources.Par_13_3
            Case "14 " : Pbx15.Image = My.Resources.Par_14_3
            Case "15 " : Pbx15.Image = My.Resources.Par_15_3
            Case "16 " : Pbx15.Image = My.Resources.Par_16_3
            Case "17 " : Pbx15.Image = My.Resources.Par_17_3
            Case "18 " : Pbx15.Image = My.Resources.Par_18_3
            Case "19 " : Pbx15.Image = My.Resources.Par_19_3
            Case "20 " : Pbx15.Image = My.Resources.Par_20_3
            Case "21 " : Pbx15.Image = My.Resources.Par_21_3
            Case "22 " : Pbx15.Image = My.Resources.Par_22_3
            Case "23 " : Pbx15.Image = My.Resources.Par_23_3
            Case "24 " : Pbx15.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx15.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx15.Tag
            Ele_act = 15
        Else
            clic = 0
            Ima_nue = Pbx15.Tag
            Ele_nue = 15
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx16_Click(sender As System.Object, e As System.EventArgs) Handles Pbx16.Click
        Select Case Pbx16.Tag

            Case "1" : Pbx16.Image = My.Resources.Par_1_3
            Case "2" : Pbx16.Image = My.Resources.Par_2_3
            Case "3" : Pbx16.Image = My.Resources.Par_3_3
            Case "4" : Pbx16.Image = My.Resources.Par_4_3
            Case "5" : Pbx16.Image = My.Resources.Par_5_3
            Case "6" : Pbx16.Image = My.Resources.Par_6_3
            Case "7" : Pbx16.Image = My.Resources.Par_7_3
            Case "8" : Pbx16.Image = My.Resources.Par_8_3
            Case "9 " : Pbx16.Image = My.Resources.Par_9_3
            Case "10 " : Pbx16.Image = My.Resources.Par_10_3
            Case "11 " : Pbx16.Image = My.Resources.Par_11_3
            Case "12 " : Pbx16.Image = My.Resources.Par_12_3
            Case "13 " : Pbx16.Image = My.Resources.Par_13_3
            Case "14 " : Pbx16.Image = My.Resources.Par_14_3
            Case "15 " : Pbx16.Image = My.Resources.Par_15_3
            Case "16 " : Pbx16.Image = My.Resources.Par_16_3
            Case "17 " : Pbx16.Image = My.Resources.Par_17_3
            Case "18 " : Pbx16.Image = My.Resources.Par_18_3
            Case "19 " : Pbx16.Image = My.Resources.Par_19_3
            Case "20 " : Pbx16.Image = My.Resources.Par_20_3
            Case "21 " : Pbx16.Image = My.Resources.Par_21_3
            Case "22 " : Pbx16.Image = My.Resources.Par_22_3
            Case "23 " : Pbx16.Image = My.Resources.Par_23_3
            Case "24 " : Pbx16.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx16.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx16.Tag
            Ele_act = 16
        Else
            clic = 0
            Ima_nue = Pbx16.Tag
            Ele_nue = 16
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx17_Click(sender As System.Object, e As System.EventArgs) Handles Pbx17.Click
        Select Case Pbx17.Tag

            Case "1" : Pbx17.Image = My.Resources.Par_1_3
            Case "2" : Pbx17.Image = My.Resources.Par_2_3
            Case "3" : Pbx17.Image = My.Resources.Par_3_3
            Case "4" : Pbx17.Image = My.Resources.Par_4_3
            Case "5" : Pbx17.Image = My.Resources.Par_5_3
            Case "6" : Pbx17.Image = My.Resources.Par_6_3
            Case "7" : Pbx17.Image = My.Resources.Par_7_3
            Case "8" : Pbx17.Image = My.Resources.Par_8_3
            Case "9 " : Pbx17.Image = My.Resources.Par_9_3
            Case "10 " : Pbx17.Image = My.Resources.Par_10_3
            Case "11 " : Pbx17.Image = My.Resources.Par_11_3
            Case "12 " : Pbx17.Image = My.Resources.Par_12_3
            Case "13 " : Pbx17.Image = My.Resources.Par_13_3
            Case "14 " : Pbx17.Image = My.Resources.Par_14_3
            Case "15 " : Pbx17.Image = My.Resources.Par_15_3
            Case "16 " : Pbx17.Image = My.Resources.Par_16_3
            Case "17 " : Pbx17.Image = My.Resources.Par_17_3
            Case "18 " : Pbx17.Image = My.Resources.Par_18_3
            Case "19 " : Pbx17.Image = My.Resources.Par_19_3
            Case "20 " : Pbx17.Image = My.Resources.Par_20_3
            Case "21 " : Pbx17.Image = My.Resources.Par_21_3
            Case "22 " : Pbx17.Image = My.Resources.Par_22_3
            Case "23 " : Pbx17.Image = My.Resources.Par_23_3
            Case "24 " : Pbx17.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx17.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx17.Tag
            Ele_act = 17
        Else
            clic = 0
            Ima_nue = Pbx17.Tag
            Ele_nue = 17
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx18_Click(sender As System.Object, e As System.EventArgs) Handles Pbx18.Click
        Select Case Pbx18.Tag

            Case "1" : Pbx18.Image = My.Resources.Par_1_3
            Case "2" : Pbx18.Image = My.Resources.Par_2_3
            Case "3" : Pbx18.Image = My.Resources.Par_3_3
            Case "4" : Pbx18.Image = My.Resources.Par_4_3
            Case "5" : Pbx18.Image = My.Resources.Par_5_3
            Case "6" : Pbx18.Image = My.Resources.Par_6_3
            Case "7" : Pbx18.Image = My.Resources.Par_7_3
            Case "8" : Pbx18.Image = My.Resources.Par_8_3
            Case "9 " : Pbx18.Image = My.Resources.Par_9_3
            Case "10 " : Pbx18.Image = My.Resources.Par_10_3
            Case "11 " : Pbx18.Image = My.Resources.Par_11_3
            Case "12 " : Pbx18.Image = My.Resources.Par_12_3
            Case "13 " : Pbx18.Image = My.Resources.Par_13_3
            Case "14 " : Pbx18.Image = My.Resources.Par_14_3
            Case "15 " : Pbx18.Image = My.Resources.Par_15_3
            Case "16 " : Pbx18.Image = My.Resources.Par_16_3
            Case "17 " : Pbx18.Image = My.Resources.Par_17_3
            Case "18 " : Pbx18.Image = My.Resources.Par_18_3
            Case "19 " : Pbx18.Image = My.Resources.Par_19_3
            Case "20 " : Pbx18.Image = My.Resources.Par_20_3
            Case "21 " : Pbx18.Image = My.Resources.Par_21_3
            Case "22 " : Pbx18.Image = My.Resources.Par_22_3
            Case "23 " : Pbx18.Image = My.Resources.Par_23_3
            Case "24 " : Pbx18.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx18.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx18.Tag
            Ele_act = 18
        Else
            clic = 0
            Ima_nue = Pbx18.Tag
            Ele_nue = 18
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx19_Click(sender As System.Object, e As System.EventArgs) Handles Pbx19.Click
        Select Case Pbx19.Tag

            Case "1" : Pbx19.Image = My.Resources.Par_1_3
            Case "2" : Pbx19.Image = My.Resources.Par_2_3
            Case "3" : Pbx19.Image = My.Resources.Par_3_3
            Case "4" : Pbx19.Image = My.Resources.Par_4_3
            Case "5" : Pbx19.Image = My.Resources.Par_5_3
            Case "6" : Pbx19.Image = My.Resources.Par_6_3
            Case "7" : Pbx19.Image = My.Resources.Par_7_3
            Case "8" : Pbx19.Image = My.Resources.Par_8_3
            Case "9 " : Pbx19.Image = My.Resources.Par_9_3
            Case "10 " : Pbx19.Image = My.Resources.Par_10_3
            Case "11 " : Pbx19.Image = My.Resources.Par_11_3
            Case "12 " : Pbx19.Image = My.Resources.Par_12_3
            Case "13 " : Pbx19.Image = My.Resources.Par_13_3
            Case "14 " : Pbx19.Image = My.Resources.Par_14_3
            Case "15 " : Pbx19.Image = My.Resources.Par_15_3
            Case "16 " : Pbx19.Image = My.Resources.Par_16_3
            Case "17 " : Pbx19.Image = My.Resources.Par_17_3
            Case "18 " : Pbx19.Image = My.Resources.Par_18_3
            Case "19 " : Pbx19.Image = My.Resources.Par_19_3
            Case "20 " : Pbx19.Image = My.Resources.Par_20_3
            Case "21 " : Pbx19.Image = My.Resources.Par_21_3
            Case "22 " : Pbx19.Image = My.Resources.Par_22_3
            Case "23 " : Pbx19.Image = My.Resources.Par_23_3
            Case "24 " : Pbx19.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx19.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx19.Tag
            Ele_act = 19
        Else
            clic = 0
            Ima_nue = Pbx19.Tag
            Ele_nue = 19
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx20_Click(sender As System.Object, e As System.EventArgs) Handles Pbx20.Click
        Select Case Pbx20.Tag

            Case "1" : Pbx20.Image = My.Resources.Par_1_3
            Case "2" : Pbx20.Image = My.Resources.Par_2_3
            Case "3" : Pbx20.Image = My.Resources.Par_3_3
            Case "4" : Pbx20.Image = My.Resources.Par_4_3
            Case "5" : Pbx20.Image = My.Resources.Par_5_3
            Case "6" : Pbx20.Image = My.Resources.Par_6_3
            Case "7" : Pbx20.Image = My.Resources.Par_7_3
            Case "8" : Pbx20.Image = My.Resources.Par_8_3
            Case "9 " : Pbx20.Image = My.Resources.Par_9_3
            Case "10 " : Pbx20.Image = My.Resources.Par_10_3
            Case "11 " : Pbx20.Image = My.Resources.Par_11_3
            Case "12 " : Pbx20.Image = My.Resources.Par_12_3
            Case "13 " : Pbx20.Image = My.Resources.Par_13_3
            Case "14 " : Pbx20.Image = My.Resources.Par_14_3
            Case "15 " : Pbx20.Image = My.Resources.Par_15_3
            Case "16 " : Pbx20.Image = My.Resources.Par_16_3
            Case "17 " : Pbx20.Image = My.Resources.Par_17_3
            Case "18 " : Pbx20.Image = My.Resources.Par_18_3
            Case "19 " : Pbx20.Image = My.Resources.Par_19_3
            Case "20 " : Pbx20.Image = My.Resources.Par_20_3
            Case "21 " : Pbx20.Image = My.Resources.Par_21_3
            Case "22 " : Pbx20.Image = My.Resources.Par_22_3
            Case "23 " : Pbx20.Image = My.Resources.Par_23_3
            Case "24 " : Pbx20.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx20.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx20.Tag
            Ele_act = 20
        Else
            clic = 0
            Ima_nue = Pbx20.Tag
            Ele_nue = 20
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx21_Click(sender As System.Object, e As System.EventArgs) Handles Pbx21.Click
        Select Case Pbx21.Tag

            Case "1" : Pbx21.Image = My.Resources.Par_1_3
            Case "2" : Pbx21.Image = My.Resources.Par_2_3
            Case "3" : Pbx21.Image = My.Resources.Par_3_3
            Case "4" : Pbx21.Image = My.Resources.Par_4_3
            Case "5" : Pbx21.Image = My.Resources.Par_5_3
            Case "6" : Pbx21.Image = My.Resources.Par_6_3
            Case "7" : Pbx21.Image = My.Resources.Par_7_3
            Case "8" : Pbx21.Image = My.Resources.Par_8_3
            Case "9 " : Pbx21.Image = My.Resources.Par_9_3
            Case "10 " : Pbx21.Image = My.Resources.Par_10_3
            Case "11 " : Pbx21.Image = My.Resources.Par_11_3
            Case "12 " : Pbx21.Image = My.Resources.Par_12_3
            Case "13 " : Pbx21.Image = My.Resources.Par_13_3
            Case "14 " : Pbx21.Image = My.Resources.Par_14_3
            Case "15 " : Pbx21.Image = My.Resources.Par_15_3
            Case "16 " : Pbx21.Image = My.Resources.Par_16_3
            Case "17 " : Pbx21.Image = My.Resources.Par_17_3
            Case "18 " : Pbx21.Image = My.Resources.Par_18_3
            Case "19 " : Pbx21.Image = My.Resources.Par_19_3
            Case "20 " : Pbx21.Image = My.Resources.Par_20_3
            Case "21 " : Pbx21.Image = My.Resources.Par_21_3
            Case "22 " : Pbx21.Image = My.Resources.Par_22_3
            Case "23 " : Pbx21.Image = My.Resources.Par_23_3
            Case "24 " : Pbx21.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx21.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx21.Tag
            Ele_act = 21
        Else
            clic = 0
            Ima_nue = Pbx21.Tag
            Ele_nue = 21
            ver_pareja()
        End If
    End Sub



    Private Sub Pbx22_Click(sender As System.Object, e As System.EventArgs) Handles Pbx22.Click
        Select Case Pbx22.Tag

            Case "1" : Pbx22.Image = My.Resources.Par_1_3
            Case "2" : Pbx22.Image = My.Resources.Par_2_3
            Case "3" : Pbx22.Image = My.Resources.Par_3_3
            Case "4" : Pbx22.Image = My.Resources.Par_4_3
            Case "5" : Pbx22.Image = My.Resources.Par_5_3
            Case "6" : Pbx22.Image = My.Resources.Par_6_3
            Case "7" : Pbx22.Image = My.Resources.Par_7_3
            Case "8" : Pbx22.Image = My.Resources.Par_8_3
            Case "9 " : Pbx22.Image = My.Resources.Par_9_3
            Case "10 " : Pbx22.Image = My.Resources.Par_10_3
            Case "11 " : Pbx22.Image = My.Resources.Par_11_3
            Case "12 " : Pbx22.Image = My.Resources.Par_12_3
            Case "13 " : Pbx22.Image = My.Resources.Par_13_3
            Case "14 " : Pbx22.Image = My.Resources.Par_14_3
            Case "15 " : Pbx22.Image = My.Resources.Par_15_3
            Case "16 " : Pbx22.Image = My.Resources.Par_16_3
            Case "17 " : Pbx22.Image = My.Resources.Par_17_3
            Case "18 " : Pbx22.Image = My.Resources.Par_18_3
            Case "19 " : Pbx22.Image = My.Resources.Par_19_3
            Case "20 " : Pbx22.Image = My.Resources.Par_20_3
            Case "21 " : Pbx22.Image = My.Resources.Par_21_3
            Case "22 " : Pbx22.Image = My.Resources.Par_22_3
            Case "23 " : Pbx22.Image = My.Resources.Par_23_3
            Case "24 " : Pbx22.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx22.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx22.Tag
            Ele_act = 22
        Else
            clic = 0
            Ima_nue = Pbx22.Tag
            Ele_nue = 22
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx23_Click(sender As System.Object, e As System.EventArgs) Handles Pbx23.Click
        Select Case Pbx23.Tag

            Case "1" : Pbx23.Image = My.Resources.Par_1_3
            Case "2" : Pbx23.Image = My.Resources.Par_2_3
            Case "3" : Pbx23.Image = My.Resources.Par_3_3
            Case "4" : Pbx23.Image = My.Resources.Par_4_3
            Case "5" : Pbx23.Image = My.Resources.Par_5_3
            Case "6" : Pbx23.Image = My.Resources.Par_6_3
            Case "7" : Pbx23.Image = My.Resources.Par_7_3
            Case "8" : Pbx23.Image = My.Resources.Par_8_3
            Case "9 " : Pbx23.Image = My.Resources.Par_9_3
            Case "10 " : Pbx23.Image = My.Resources.Par_10_3
            Case "11 " : Pbx23.Image = My.Resources.Par_11_3
            Case "12 " : Pbx23.Image = My.Resources.Par_12_3
            Case "13 " : Pbx23.Image = My.Resources.Par_13_3
            Case "14 " : Pbx23.Image = My.Resources.Par_14_3
            Case "15 " : Pbx23.Image = My.Resources.Par_15_3
            Case "16 " : Pbx23.Image = My.Resources.Par_16_3
            Case "17 " : Pbx23.Image = My.Resources.Par_17_3
            Case "18 " : Pbx23.Image = My.Resources.Par_18_3
            Case "19 " : Pbx23.Image = My.Resources.Par_19_3
            Case "20 " : Pbx23.Image = My.Resources.Par_20_3
            Case "21 " : Pbx23.Image = My.Resources.Par_21_3
            Case "22 " : Pbx23.Image = My.Resources.Par_22_3
            Case "23 " : Pbx23.Image = My.Resources.Par_23_3
            Case "24 " : Pbx23.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx23.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx23.Tag
            Ele_act = 23
        Else
            clic = 0
            Ima_nue = Pbx23.Tag
            Ele_nue = 23
            ver_pareja()
        End If
    End Sub

    Private Sub Pbx24_Click(sender As System.Object, e As System.EventArgs) Handles Pbx24.Click
        Select Case Pbx24.Tag

            Case "1" : Pbx24.Image = My.Resources.Par_1_3
            Case "2" : Pbx24.Image = My.Resources.Par_2_3
            Case "3" : Pbx24.Image = My.Resources.Par_3_3
            Case "4" : Pbx24.Image = My.Resources.Par_4_3
            Case "5" : Pbx24.Image = My.Resources.Par_5_3
            Case "6" : Pbx24.Image = My.Resources.Par_6_3
            Case "7" : Pbx24.Image = My.Resources.Par_7_3
            Case "8" : Pbx24.Image = My.Resources.Par_8_3
            Case "9 " : Pbx24.Image = My.Resources.Par_9_3
            Case "10 " : Pbx24.Image = My.Resources.Par_10_3
            Case "11 " : Pbx24.Image = My.Resources.Par_11_3
            Case "12 " : Pbx24.Image = My.Resources.Par_12_3
            Case "13 " : Pbx24.Image = My.Resources.Par_13_3
            Case "14 " : Pbx24.Image = My.Resources.Par_14_3
            Case "15 " : Pbx24.Image = My.Resources.Par_15_3
            Case "16 " : Pbx24.Image = My.Resources.Par_16_3
            Case "17 " : Pbx24.Image = My.Resources.Par_17_3
            Case "18 " : Pbx24.Image = My.Resources.Par_18_3
            Case "19 " : Pbx24.Image = My.Resources.Par_19_3
            Case "20 " : Pbx24.Image = My.Resources.Par_20_3
            Case "21 " : Pbx24.Image = My.Resources.Par_21_3
            Case "22 " : Pbx24.Image = My.Resources.Par_22_3
            Case "23 " : Pbx24.Image = My.Resources.Par_23_3
            Case "24 " : Pbx24.Image = My.Resources.Par_24_3
            Case Else : MsgBox("Ninguno" & Pbx24.Tag)
        End Select
        If clic = 0 Then
            clic = 1
            Ima_act = Pbx24.Tag
            Ele_act = 24
        Else
            clic = 0
            Ima_nue = Pbx24.Tag
            Ele_nue = 24
            ver_pareja()
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TimVer_Tick(sender As System.Object, e As System.EventArgs) Handles TimVer.Tick
        segundos = segundos + 1
        If segundos >= 3 Then
            TimVer.Enabled = False
            segundos = 0
            GroupBox1.Enabled = True
            lblmensaje.Text = "       "
            Select Case (Ele_nue)
                Case 1 : Pbx1.Image = My.Resources.Icono
                Case 2 : Pbx2.Image = My.Resources.Icono
                Case 3 : Pbx3.Image = My.Resources.Icono
                Case 4 : Pbx4.Image = My.Resources.Icono
                Case 5 : Pbx5.Image = My.Resources.Icono
                Case 6 : Pbx6.Image = My.Resources.Icono
                Case 7 : Pbx7.Image = My.Resources.Icono
                Case 8 : Pbx8.Image = My.Resources.Icono
                Case 9 : Pbx9.Image = My.Resources.Icono
                Case 10 : Pbx10.Image = My.Resources.Icono
                Case 11 : Pbx11.Image = My.Resources.Icono
                Case 12 : Pbx12.Image = My.Resources.Icono
                Case 13 : Pbx13.Image = My.Resources.Icono
                Case 14 : Pbx14.Image = My.Resources.Icono
                Case 15 : Pbx15.Image = My.Resources.Icono
                Case 16 : Pbx16.Image = My.Resources.Icono
                Case 17 : Pbx17.Image = My.Resources.Icono
                Case 18 : Pbx18.Image = My.Resources.Icono
                Case 19 : Pbx19.Image = My.Resources.Icono
                Case 20 : Pbx20.Image = My.Resources.Icono
                Case 21 : Pbx21.Image = My.Resources.Icono
                Case 22 : Pbx22.Image = My.Resources.Icono
                Case 23 : Pbx23.Image = My.Resources.Icono
                Case 24 : Pbx24.Image = My.Resources.Icono


            End Select
            Select Case (Ele_act)
                Case 1 : Pbx1.Image = My.Resources.Icono
                Case 2 : Pbx2.Image = My.Resources.Icono
                Case 3 : Pbx3.Image = My.Resources.Icono
                Case 4 : Pbx4.Image = My.Resources.Icono
                Case 5 : Pbx5.Image = My.Resources.Icono
                Case 6 : Pbx6.Image = My.Resources.Icono
                Case 7 : Pbx7.Image = My.Resources.Icono
                Case 8 : Pbx8.Image = My.Resources.Icono
                Case 9 : Pbx9.Image = My.Resources.Icono
                Case 10 : Pbx10.Image = My.Resources.Icono
                Case 11 : Pbx11.Image = My.Resources.Icono
                Case 12 : Pbx12.Image = My.Resources.Icono
                Case 13 : Pbx13.Image = My.Resources.Icono
                Case 14 : Pbx14.Image = My.Resources.Icono
                Case 15 : Pbx15.Image = My.Resources.Icono
                Case 16 : Pbx16.Image = My.Resources.Icono
                Case 17 : Pbx17.Image = My.Resources.Icono
                Case 18 : Pbx18.Image = My.Resources.Icono
                Case 19 : Pbx19.Image = My.Resources.Icono
                Case 20 : Pbx20.Image = My.Resources.Icono
                Case 21 : Pbx21.Image = My.Resources.Icono
                Case 22 : Pbx22.Image = My.Resources.Icono
                Case 23 : Pbx23.Image = My.Resources.Icono
                Case 24 : Pbx24.Image = My.Resources.Icono


            End Select
        End If
    End Sub


    Private Sub TimConteo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimConteo.Tick
        LblConteo.Text = LblConteo.Text - 1
        If LblConteo.Text = "0" Then
            TimConteo.Enabled = False
            FrmPerdiste.Show()
        End If
    End Sub

    Private Sub PbxJugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxJugar.Click
        LblConteo.Text = "60"
        TimConteo.Enabled = True

        If PbxJugar.Enabled = True Then
            Pbx1.Enabled = True
            Pbx2.Enabled = True
            Pbx3.Enabled = True
            Pbx4.Enabled = True
            Pbx5.Enabled = True
            Pbx6.Enabled = True
            Pbx7.Enabled = True
            Pbx8.Enabled = True
            Pbx9.Enabled = True
            Pbx10.Enabled = True
            Pbx11.Enabled = True
            Pbx12.Enabled = True
            Pbx13.Enabled = True
            Pbx14.Enabled = True
            Pbx15.Enabled = True
            Pbx16.Enabled = True
            Pbx17.Enabled = True
            Pbx18.Enabled = True
            Pbx19.Enabled = True
            Pbx20.Enabled = True
            Pbx21.Enabled = True
            Pbx22.Enabled = True
            Pbx23.Enabled = True
            Pbx24.Enabled = True

            Pbx1.Image = My.Resources.Icono
            Pbx2.Image = My.Resources.Icono
            Pbx3.Image = My.Resources.Icono
            Pbx4.Image = My.Resources.Icono
            Pbx5.Image = My.Resources.Icono
            Pbx6.Image = My.Resources.Icono
            Pbx7.Image = My.Resources.Icono
            Pbx8.Image = My.Resources.Icono
            Pbx9.Image = My.Resources.Icono
            Pbx10.Image = My.Resources.Icono
            Pbx11.Image = My.Resources.Icono
            Pbx12.Image = My.Resources.Icono
            Pbx13.Image = My.Resources.Icono
            Pbx14.Image = My.Resources.Icono
            Pbx15.Image = My.Resources.Icono
            Pbx16.Image = My.Resources.Icono
            Pbx17.Image = My.Resources.Icono
            Pbx18.Image = My.Resources.Icono
            Pbx19.Image = My.Resources.Icono
            Pbx20.Image = My.Resources.Icono
            Pbx21.Image = My.Resources.Icono
            Pbx22.Image = My.Resources.Icono
            Pbx23.Image = My.Resources.Icono
            Pbx24.Image = My.Resources.Icono

            Pbx1.Show()
            Pbx2.Show()
            Pbx3.Show()
            Pbx4.Show()
            Pbx5.Show()
            Pbx6.Show()
            Pbx7.Show()
            Pbx8.Show()
            Pbx9.Show()
            Pbx10.Show()
            Pbx11.Show()
            Pbx12.Show()
            Pbx13.Show()
            Pbx14.Show()
            Pbx15.Show()
            Pbx16.Show()
            Pbx17.Show()
            Pbx18.Show()
            Pbx19.Show()
            Pbx20.Show()
            Pbx21.Show()
            Pbx22.Show()
            Pbx23.Show()
            Pbx24.Show()
            Randomize()

            Dim i, j As Integer
            Dim pareja As Integer
            Dim conta As Integer
            Dim vec(24) As Integer
            ListBox1.Items.Clear()

            Max = 12
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
            Pbx1.Tag = vec(1)
            Pbx2.Tag = vec(2)
            Pbx3.Tag = vec(3)
            Pbx4.Tag = vec(4)
            Pbx5.Tag = vec(5)
            Pbx6.Tag = vec(6)
            Pbx7.Tag = vec(7)
            Pbx8.Tag = vec(8)
            Pbx9.Tag = vec(9)
            Pbx10.Tag = vec(10)
            Pbx11.Tag = vec(11)
            Pbx12.Tag = vec(12)
            Pbx13.Tag = vec(13)
            Pbx14.Tag = vec(14)
            Pbx15.Tag = vec(15)
            Pbx16.Tag = vec(16)
            Pbx17.Tag = vec(17)
            Pbx18.Tag = vec(18)
            Pbx19.Tag = vec(19)
            Pbx20.Tag = vec(20)
            Pbx21.Tag = vec(21)
            Pbx22.Tag = vec(22)
            Pbx23.Tag = vec(23)
            Pbx24.Tag = vec(24)
            clic = 0
            Aciertos = 0
            Fallas = 0
            Max = 12
            GroupBox1.Enabled = True

        End If
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
        TimConteo.Enabled = False
        salir3.Show()
    End Sub

    Private Sub Pbxvolumen1_Click(sender As System.Object, e As System.EventArgs) Handles Pbxvolumen1.Click
        If Pbxvolumen1.Visible = True And Pbxvolumen1.Enabled = True Then

            FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.pause()
            Pbxvolumen2.Enabled = True
            Pbxvolumen2.Visible = True
            Pbxvolumen1.Visible = False
            Pbxvolumen1.Enabled = False

        End If
    End Sub

    Private Sub Pbxvolumen2_Click(sender As System.Object, e As System.EventArgs) Handles Pbxvolumen2.Click
        If Pbxvolumen2.Visible = True And Pbxvolumen2.Enabled = True Then

            FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.play()
            Pbxvolumen1.Enabled = True
            Pbxvolumen1.Visible = True
            Pbxvolumen2.Visible = False
            Pbxvolumen2.Enabled = False
        End If
    End Sub

    Private Sub PictureBox25_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox25.Click
        Opciones3.Show()
        TimConteo.Enabled = False
    End Sub

   
End Class
