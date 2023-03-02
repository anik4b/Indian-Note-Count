Imports System.Globalization
Imports System.Drawing.Printing

Public Class Main

    Dim WithEvents pd As New PrintDocument
    Dim pdd As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim twok, fiveh, twoh, oneh, fifty, twenty, ten, five, coin, data, tencoin, fivecoin, twocoin, onecoin, coinsum As Integer

    Sub ClearAll()
        TextBox1.Clear()
        Label13.Text = 0
        TextBox2.Clear()
        Label14.Text = 0
        TextBox3.Clear()
        Label15.Text = 0
        TextBox4.Clear()
        Label16.Text = 0
        TextBox5.Clear()
        Label17.Text = 0
        TextBox6.Clear()
        Label18.Text = 0
        TextBox7.Clear()
        Label19.Text = 0
        TextBox8.Clear()
        Label20.Text = 0
        TextBox9.Clear()
        Label21.Text = 0
        TextBox11.Clear()
        TextBox12.Clear()
        Label27.Text = 0
        TextBox13.Clear()
        Label28.Text = 0
        TextBox14.Clear()
        Label29.Text = 0
        TextBox15.Clear()
        Label30.Text = 0
        data = 0
        twok = 0
        fiveh = 0
        twoh = 0
        oneh = 0
        fifty = 0
        twenty = 0
        ten = 0
        five = 0
        coin = 0
        tencoin = 0
        fivecoin = 0
        twocoin = 0
        onecoin = 0
        coinsum = 0
        TextBox1.Select()
        Label22.Text = "- Less Coins"
        Me.Height = 600
        Panel3.Hide()
        Label22.Text = "+ Add Coins"
        TextBox10.Clear()
        TextBox10.Enabled = True
    End Sub

    Sub Calculator()
        data = twok + fiveh + twoh + oneh + fifty + twenty + ten + five + coin
        TextBox9.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", data)
    End Sub

    Sub coincal()
        coinsum = tencoin + fivecoin + twocoin + onecoin
        TextBox10.Text = coinsum
    End Sub

    Function NumberToText(ByVal n As Integer) As String

        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", _
                  "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", _
                    "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)

            Case 100 To 199
                Return "One Hundred " & NumberToText(n Mod 100)

            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundreds " & NumberToText(n Mod 100)

            Case 1000 To 1999
                Return "One Thousand " & NumberToText(n Mod 1000)

            Case 2000 To 99999
                Return NumberToText(n \ 1000) & "Thousands " & NumberToText(n Mod 1000)
                '
            Case 100000 To 199999
                Return "One Lakh " & NumberToText(n Mod 100000)

            Case 200000 To 9999999
                Return NumberToText(n \ 100000) & "Lakhs " & NumberToText(n Mod 100000)
                '
            Case 10000000 To 19999999
                Return "One Crore " & NumberToText(n Mod 1000000)

            Case 20000000 To 999999999
                Return NumberToText(n \ 10000000) & "Crore " & NumberToText(n Mod 10000000)

            Case 1000000000 To 1999999999
                Return "One Billion " & NumberToText(n Mod 1000000000)

            Case Else
                Return NumberToText(n \ 1000000000) & "Billion " _
                  & NumberToText(n Mod 1000000000)
        End Select
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If MsgBox("Really Want To Save", vbQuestion + vbYesNo, "Save as Text") = vbYes Then
            Dim savefile As New SaveFileDialog
            savefile.FileName = DateTime.Now.ToString("dd-MM-yyyy--hh-mm-ss")
            savefile.Filter = "Text Document (*.txt)|*.txt"
            savefile.Title = "Save Your Data"
            savefile.ShowDialog()
            If Label22.Text = "+ Add Coins" Then
                Try
                    Dim w As New System.IO.StreamWriter(savefile.FileName)
                    w.WriteLine("Data Saved on " + DateTime.Now.ToString())
                    w.WriteLine()
                    w.WriteLine("₹ 2,000 x " + TextBox1.Text + " = " + Label13.Text)
                    w.WriteLine("₹ 500 x " + TextBox2.Text + " = " + Label14.Text)
                    w.WriteLine("₹ 200 x " + TextBox3.Text + " = " + Label15.Text)
                    w.WriteLine("₹ 100 x " + TextBox4.Text + " = " + Label16.Text)
                    w.WriteLine("₹ 50 x " + TextBox5.Text + " = " + Label17.Text)
                    w.WriteLine("₹ 20 x " + TextBox6.Text + " = " + Label18.Text)
                    w.WriteLine("₹ 10 x " + TextBox7.Text + " = " + Label19.Text)
                    w.WriteLine("₹ 5 x " + TextBox8.Text + " = " + Label20.Text)
                    w.WriteLine("₹ " + Label21.Text + " (Total Coin Value)")
                    w.WriteLine()
                    w.WriteLine("Total Value = " + TextBox9.Text)
                    w.WriteLine("In Words = " + TextBox11.Text)

                    w.Close()
                    'MessageBox.Show("Successfully Saved", "Done")
                    TextBox1.Select()
                Catch ex As Exception
                End Try
            Else
                Try
                    Dim w As New System.IO.StreamWriter(savefile.FileName)
                    w.WriteLine("Data Saved on " + DateTime.Now.ToString())
                    w.WriteLine()
                    w.WriteLine("₹ 2,000 x " + TextBox1.Text + " = " + Label13.Text)
                    w.WriteLine("₹ 500 x " + TextBox2.Text + " = " + Label14.Text)
                    w.WriteLine("₹ 200 x " + TextBox3.Text + " = " + Label15.Text)
                    w.WriteLine("₹ 100 x " + TextBox4.Text + " = " + Label16.Text)
                    w.WriteLine("₹ 50 x " + TextBox5.Text + " = " + Label17.Text)
                    w.WriteLine("₹ 20 x " + TextBox6.Text + " = " + Label18.Text)
                    w.WriteLine("₹ 10 x " + TextBox7.Text + " = " + Label19.Text)
                    w.WriteLine("₹ 5 x " + TextBox8.Text + " = " + Label20.Text)
                    w.WriteLine("₹ " + Label21.Text + " (Total Coin Value)")
                    w.WriteLine()
                    w.WriteLine("Coins Details.............")
                    w.WriteLine("₹ 10 x " + TextBox12.Text + " = " + Label27.Text)
                    w.WriteLine("₹ 5 x " + TextBox13.Text + " = " + Label28.Text)
                    w.WriteLine("₹ 2 x " + TextBox14.Text + " = " + Label29.Text)
                    w.WriteLine("₹ 1 x " + TextBox15.Text + " = " + Label30.Text)
                    w.WriteLine()
                    w.WriteLine("Total Value = " + TextBox9.Text)
                    w.WriteLine("In Words = " + TextBox11.Text)

                    w.Close()
                    'MessageBox.Show("Successfully Saved", "Done")
                    TextBox1.Select()
                Catch ex As Exception
                End Try
            End If
        Else
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown, TextBox3.KeyDown, TextBox4.KeyDown, TextBox5.KeyDown, TextBox6.KeyDown, TextBox7.KeyDown, TextBox8.KeyDown, TextBox10.KeyDown, TextBox12.KeyDown, TextBox13.KeyDown, TextBox14.KeyDown, TextBox15.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress, TextBox8.KeyPress, TextBox10.KeyPress, TextBox12.KeyPress, TextBox13.KeyPress, TextBox15.KeyPress, TextBox14.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text <> Nothing Then
            twok = 2000 * TextBox1.Text
            Label13.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", twok)
        Else
            TextBox1.Text = 0
            Label13.Text = 0
        End If
        Calculator()
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text <> Nothing Then
            fiveh = 500 * TextBox2.Text
            Label14.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", fiveh)
        Else
            TextBox2.Text = 0
            Label14.Text = 0
        End If
        Calculator()
    End Sub

    Private Sub TextBox3_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox2.Select()
        End If
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If TextBox3.Text <> Nothing Then
            twoh = 200 * TextBox3.Text
            Label15.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", twoh)
        Else
            TextBox3.Text = 0
            Label15.Text = 0
        End If
        Calculator()
    End Sub

    Private Sub TextBox4_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox3.Select()
        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
        If TextBox4.Text <> Nothing Then
            oneh = 100 * TextBox4.Text
            Label16.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", oneh)
        Else
            TextBox4.Text = 0
            Label16.Text = 0
        End If
        Calculator()
    End Sub

    Private Sub TextBox5_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox4.Select()
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles TextBox5.Leave
        If TextBox5.Text <> Nothing Then
            fifty = 50 * TextBox5.Text
            Label17.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", fifty)
        Else
            TextBox5.Text = 0
            Label17.Text = 0
        End If
        Calculator()
    End Sub

    Private Sub TextBox6_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox5.Select()
        End If
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.Leave
        If TextBox6.Text <> Nothing Then
            twenty = 20 * TextBox6.Text
            Label18.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", twenty)
        Else
            TextBox6.Text = 0
            Label18.Text = 0
        End If
        Calculator()
    End Sub

    Private Sub TextBox7_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox6.Select()
        End If
    End Sub

    Private Sub TextBox7_Leave(sender As Object, e As EventArgs) Handles TextBox7.Leave
        If TextBox7.Text <> Nothing Then
            ten = 10 * TextBox7.Text
            Label19.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", ten)
        Else
            TextBox7.Text = 0
            Label19.Text = 0
        End If
        Calculator()
    End Sub

    Private Sub TextBox8_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox8.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox7.Select()
        End If
    End Sub

    Private Sub TextBox8_Leave(sender As Object, e As EventArgs) Handles TextBox8.Leave
        If TextBox8.Text <> Nothing Then
            five = 5 * TextBox8.Text
            Label20.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", five)
        Else
            TextBox8.Text = 0
            Label20.Text = 0
        End If
        Calculator()
    End Sub

    Private Sub TextBox10_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox10.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox8.Select()
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If TextBox10.Text <> Nothing Then
            coin = TextBox10.Text
            Label21.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", coin)
        Else
            TextBox10.Text = 0
            Label21.Text = 0
        End If
        Calculator()
    End Sub

    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Button3_Click(sender, e)    'Exit app
        End If

        If (e.KeyCode = Keys.F5) Then
            Button1_Click(sender, e)    'Clear all
        End If

        If TextBox9.Text = 0 Then
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            Button4_Click(sender, e)    'Print Data
        End If

        If TextBox9.Text = 0 Then
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            Button2_Click(sender, e)     'Save as text
        End If

        If (e.KeyCode = Keys.Insert) Then
            Label22_Click(sender, e)         'COIN OPTION
        End If

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        ClearAll()
        Me.Height = 600
        Panel3.Hide()
    End Sub

    Private Sub TextBox9_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text = "0" Then
            TextBox11.Text = "Zero Rupee Only."
            Button2.Enabled = False
            Button4.Enabled = False
        Else
            TextBox11.Text = NumberToText(data) & "Rupees Only."          'number in words
            Button2.Enabled = True
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.BackColor = Color.Cyan
        Button4.ForeColor = Color.Black
        Button4.Font = New Font(Button4.Font, FontStyle.Bold)
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.White
        Button4.ForeColor = Color.Black
        Button4.Font = New Font(Button4.Font, FontStyle.Regular)
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.Crimson
        Button3.ForeColor = Color.White
        Button3.Font = New Font(Button3.Font, FontStyle.Bold)
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.White
        Button3.ForeColor = Color.Black
        Button3.Font = New Font(Button3.Font, FontStyle.Regular)
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.Green
        Button2.ForeColor = Color.White
        Button2.Font = New Font(Button2.Font, FontStyle.Bold)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.White
        Button2.ForeColor = Color.Black
        Button2.Font = New Font(Button2.Font, FontStyle.Regular)
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Yellow
        Button1.ForeColor = Color.Black
        Button1.Font = New Font(Button1.Font, FontStyle.Bold)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
        Button1.Font = New Font(Button1.Font, FontStyle.Regular)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pdd.Document = pd
        pdd.ShowDialog()
    End Sub

    Private Sub pd_BeginPrint(sender As Object, e As PrintEventArgs) Handles pd.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 380, 500)
        pd.DefaultPageSettings = pagesetup
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As PrintPageEventArgs) Handles pd.PrintPage
        Dim f As New Font("Calibri", 12, FontStyle.Regular)
        Dim fb As New Font("Calibri", 12, FontStyle.Bold)
        Dim s As New Font("Calibri", 8, FontStyle.Regular)
        Dim h As New Font("Calibri", 20, FontStyle.Bold)
        Dim w As New Font("Arial", 8, FontStyle.Italic)

        Dim cm As Integer = pd.DefaultPageSettings.PaperSize.Width / 2
        Dim line As String = "-------------------------------------------------------------------"
        Dim center As New StringFormat
        center.Alignment = StringAlignment.Center

        Dim rf As RectangleF = New RectangleF(10, 295, 360, 250)
        Dim rf2 As RectangleF = New RectangleF(10, 410, 360, 250)

        If Label22.Text = "+ Add Coins" Then
            e.Graphics.DrawString("Indian Note Count", h, Brushes.Black, cm, 12, center)
            e.Graphics.DrawString("v2.0", s, Brushes.Gray, 300, 28)
            e.Graphics.DrawString(line, f, Brushes.Black, cm, 38, center)
            e.Graphics.DrawString("Data Saved on " + DateTime.Now.ToString(), s, Brushes.Black, 10, 54)
            e.Graphics.DrawString("₹ 2,000 x " + TextBox1.Text + " = " + Label13.Text, f, Brushes.Black, 10, 75)
            e.Graphics.DrawString("₹ 500 x " + TextBox2.Text + " = " + Label14.Text, f, Brushes.Black, 10, 95)
            e.Graphics.DrawString("₹ 200 x " + TextBox3.Text + " = " + Label15.Text, f, Brushes.Black, 10, 115)
            e.Graphics.DrawString("₹ 100 x " + TextBox4.Text + " = " + Label16.Text, f, Brushes.Black, 10, 135)
            e.Graphics.DrawString("₹ 50 x " + TextBox5.Text + " = " + Label17.Text, f, Brushes.Black, 10, 155)
            e.Graphics.DrawString("₹ 20 x " + TextBox6.Text + " = " + Label18.Text, f, Brushes.Black, 10, 175)
            e.Graphics.DrawString("₹ 10 x " + TextBox7.Text + " = " + Label19.Text, f, Brushes.Black, 10, 195)
            e.Graphics.DrawString("₹ 5 x " + TextBox8.Text + " = " + Label20.Text, f, Brushes.Black, 10, 215)
            e.Graphics.DrawString("₹ " + Label21.Text + " (Total Coin Value)", f, Brushes.Black, 10, 235)
            e.Graphics.DrawString("Total Value = " + TextBox9.Text, fb, Brushes.Black, 10, 275)
            e.Graphics.DrawString("In Words = " + TextBox11.Text, w, Brushes.Black, rf)
            e.Graphics.DrawString(line, f, Brushes.Black, cm, 315, center)
            e.Graphics.DrawString("* End Report *", f, Brushes.Black, cm, 335, center)
        Else
            e.Graphics.DrawString("Indian Note Count", h, Brushes.Black, cm, 12, center)
            e.Graphics.DrawString("v2.0", s, Brushes.Gray, 300, 28)
            e.Graphics.DrawString(line, f, Brushes.Black, cm, 38, center)
            e.Graphics.DrawString("Data Saved on " + DateTime.Now.ToString(), s, Brushes.Black, 10, 54)
            e.Graphics.DrawString("₹ 2,000 x " + TextBox1.Text + " = " + Label13.Text, f, Brushes.Black, 10, 75)
            e.Graphics.DrawString("₹ 500 x " + TextBox2.Text + " = " + Label14.Text, f, Brushes.Black, 10, 95)
            e.Graphics.DrawString("₹ 200 x " + TextBox3.Text + " = " + Label15.Text, f, Brushes.Black, 10, 115)
            e.Graphics.DrawString("₹ 100 x " + TextBox4.Text + " = " + Label16.Text, f, Brushes.Black, 10, 135)
            e.Graphics.DrawString("₹ 50 x " + TextBox5.Text + " = " + Label17.Text, f, Brushes.Black, 10, 155)
            e.Graphics.DrawString("₹ 20 x " + TextBox6.Text + " = " + Label18.Text, f, Brushes.Black, 10, 175)
            e.Graphics.DrawString("₹ 10 x " + TextBox7.Text + " = " + Label19.Text, f, Brushes.Black, 10, 195)
            e.Graphics.DrawString("₹ 5 x " + TextBox8.Text + " = " + Label20.Text, f, Brushes.Black, 10, 215)
            e.Graphics.DrawString("₹ " + Label21.Text + " (Total Coin Value)", f, Brushes.Black, 10, 235)
            e.Graphics.DrawString("Coins Details.............", f, Brushes.Black, 10, 270)
            e.Graphics.DrawString("₹ 10 x " + TextBox12.Text + " = " + Label27.Text, f, Brushes.Black, 10, 290)
            e.Graphics.DrawString("₹ 5 x " + TextBox13.Text + " = " + Label28.Text, f, Brushes.Black, 10, 310)
            e.Graphics.DrawString("₹ 2 x " + TextBox14.Text + " = " + Label29.Text, f, Brushes.Black, 10, 330)
            e.Graphics.DrawString("₹ 1 x " + TextBox15.Text + " = " + Label30.Text, f, Brushes.Black, 10, 350)
            e.Graphics.DrawString("Total Value = " + TextBox9.Text, fb, Brushes.Black, 10, 390)
            e.Graphics.DrawString("In Words = " + TextBox11.Text, w, Brushes.Black, rf2)
            e.Graphics.DrawString(line, f, Brushes.Black, cm, 430, center)
            e.Graphics.DrawString("* End Report *", f, Brushes.Black, cm, 450, center)
        End If

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        If Label22.Text = "+ Add Coins" Then
            Label22.Text = "- Less Coins"
            Me.Height = 757
            Panel3.Show()
            TextBox10.Enabled = False
            TextBox12.Clear()
            Label27.Text = 0
            TextBox13.Clear()
            Label28.Text = 0
            TextBox14.Clear()
            Label29.Text = 0
            TextBox15.Clear()
            Label30.Text = 0
            TextBox10.Text = 0
            TextBox12.Select()
        ElseIf Label22.Text = "- Less Coins" Then
            Me.Height = 600
            Panel3.Hide()
            Label22.Text = "+ Add Coins"
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox12_Leave(sender As Object, e As EventArgs) Handles TextBox12.Leave
        If TextBox12.Text <> Nothing Then
            tencoin = 10 * TextBox12.Text
            Label27.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", tencoin)
        Else
            TextBox12.Text = 0
            Label27.Text = 0
        End If
    End Sub

    Private Sub label27_TextChanged(sender As Object, e As EventArgs) Handles Label27.TextChanged
        coincal()
    End Sub

    Private Sub TextBox13_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox13.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox12.Select()
        End If
    End Sub

    Private Sub TextBox13_Leave(sender As Object, e As EventArgs) Handles TextBox13.Leave
        If TextBox13.Text <> Nothing Then
            fivecoin = 5 * TextBox13.Text
            Label28.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", fivecoin)
        Else
            TextBox13.Text = 0
            Label28.Text = 0
        End If
    End Sub

    Private Sub label28_TextChanged(sender As Object, e As EventArgs) Handles Label28.TextChanged
        coincal()
    End Sub

    Private Sub TextBox14_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox14.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox13.Select()
        End If
    End Sub

    Private Sub TextBox14_Leave(sender As Object, e As EventArgs) Handles TextBox14.Leave
        If TextBox14.Text <> Nothing Then
            twocoin = 2 * TextBox14.Text
            Label29.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", twocoin)
        Else
            TextBox14.Text = 0
            Label29.Text = 0
        End If
    End Sub

    Private Sub label29_TextChanged(sender As Object, e As EventArgs) Handles Label29.TextChanged
        coincal()
    End Sub

    Private Sub TextBox15_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox15.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox14.Select()
        End If
    End Sub

    Private Sub TextBox15_Leave(sender As Object, e As EventArgs) Handles TextBox15.Leave
        If TextBox15.Text <> Nothing Then
            onecoin = TextBox15.Text
            Label30.Text = String.Format(New CultureInfo("hi-IN", True), "{0:n0}", onecoin)
        Else
            TextBox15.Text = 0
            Label30.Text = 0
        End If
    End Sub

    Private Sub label30_TextChanged(sender As Object, e As EventArgs) Handles Label30.TextChanged
        coincal()
    End Sub

    Private Sub TextBox11_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox11.KeyUp
        If e.KeyCode = Keys.Up Then
            TextBox9.Select()
        End If
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.White
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black
    End Sub

End Class