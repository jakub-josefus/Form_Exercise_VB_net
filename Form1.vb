Option Explicit On
Option Strict On
Option Infer On

Imports System.Windows.Forms
Public Class Form1
    Dim S As Double
    Dim v As Integer
    Dim stShowRadioButton As String
    Dim stCheckBox As String
    Dim stCesta As String

    'změna barvy pozadí
    Private Sub Barva_SelectedIndexChanged(sender As Object, e As EventArgs) Handles barva.SelectedIndexChanged
        Dim JmenoBarvy As String
        JmenoBarvy = barva.Text
        Select Case JmenoBarvy
            Case "default"
                Me.BackColor = DefaultBackColor
            Case "hnědá"
                Me.BackColor = Drawing.Color.Brown
            Case "červená"
                Me.BackColor = Drawing.Color.Red
            Case "fialová"
                Me.BackColor = Drawing.Color.Purple
            Case "zelená"
                Me.BackColor = Drawing.Color.Green
            Case "modrá"
                Me.BackColor = Drawing.Color.Blue
            Case Else
        End Select

    End Sub
    'změna barvy pozadí
    'změna barvy pozadí při stisku entru 
    Private Sub Barva_KeyDown(sender As Object, e As KeyEventArgs) Handles barva.KeyDown
        If e.KeyCode = Keys.Enter Then
            Barva_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub
    'změna barvy pozadí při stisku entru 

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("Toto je nápověda...")
    End Sub

    Private Sub ProgressBar_10s(sender As Object, e As EventArgs) Handles MyBase.Load
        stCesta = "Naposledy otevřený soubor: "
        pg10.Maximum = 10000
        Me.tCasovac.Start()
        Me.tCasovac2.Start()
    End Sub

    Private Sub tCasovac_Tick(sender As Object, e As EventArgs) Handles tCasovac.Tick
        Me.pg10.Value += Me.tCasovac.Interval
        If Me.pg10.Value = Me.pg10.Maximum Then Me.tCasovac.Stop()
    End Sub

    Private Sub greenArrow_Click(sender As Object, e As EventArgs) Handles greenArrow.Click
        pg10.Value = 0
        pg10.Maximum = 10000
        Me.tCasovac.Start()
        Me.pg10.Value += Me.tCasovac.Interval
        If Me.pg10.Value = Me.pg10.Maximum Then Me.tCasovac.Stop()

    End Sub

    Private Sub tCasovac_Tick2(sender As Object, e As EventArgs) Handles tCasovac.Tick
        Dim inInterval As Integer
        inInterval = CInt(Me.pg10.Maximum / 1000) - CInt(Me.pg10.Value / 1000)
        lbProgressBar.Text = "Progress bar bude běžet ještě: " + inInterval.ToString + " s"
    End Sub

    Sub Soucet()
        Dim A As Double
        Dim B As Double
        A = Val(Me.tbA.Text.Replace(",", "."))
        B = Val(Me.tbB.Text.Replace(",", "."))
        Me.S = A + B
        Me.lbSoucet.Text = "Součet je: " + Me.S.ToString
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.Click
        Soucet()
    End Sub


    Private Sub tbPosuvnik_Scroll(sender As Object, e As EventArgs) Handles tbPosuvnik.Scroll
        Me.v = tbPosuvnik.Value
        lbProPosuvnik.Text = Me.v.ToString
    End Sub

    Private Sub tbA_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbA.KeyPress, tbB.KeyPress
        ZakazPismen(e)
    End Sub
    Private Sub tbA_TextChanged2(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbA.KeyDown, tbB.KeyDown
        If e.KeyCode = Keys.Enter Then
            Soucet()
        End If
    End Sub


    Sub ZakazPismen(e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) <> 45 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub
    Private Sub tCasovac2_Tick(sender As Object, e As EventArgs) Handles tCasovac2.Tick
        Dim stfinalString As String
        tslCas.Text = TimeOfDay.ToString("H:mm:ss")
        Label1.Text = "Součet je: " + S.ToString + "  Posuvník je: " + v.ToString + vbCrLf + "Výsledek součinu je: " + (S * v).ToString
        stfinalString = (S * v).ToString + stCheckBox + " " + stShowRadioButton + "," + "barva " + barva.Text
        stfinalString = stfinalString.Replace("  ", " ")
        lbVysledekSelect.Text = stfinalString

        tslCesta.Text = stCesta

    End Sub
    Private Sub btVysledek_Click(sender As Object, e As EventArgs) Handles btVysledek.Click
        Soucet()
    End Sub

    Private Sub NumericUpDown1_MouseCaptureChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.MouseCaptureChanged
        Soucet()
    End Sub
    Private Sub rbDrevo_CheckedChanged(sender As Object, e As EventArgs) Handles rbDrevo.CheckedChanged, rbKov.CheckedChanged, rbPlast.CheckedChanged, rbSklo.CheckedChanged
        If rbDrevo.Checked Then
            stShowRadioButton = rbDrevo.Text
        ElseIf rbKov.Checked Then
            stShowRadioButton = rbKov.Text
        ElseIf rbPlast.Checked Then
            stShowRadioButton = rbPlast.Text
        ElseIf rbSklo.Checked Then
            stShowRadioButton = rbSklo.Text
        Else
            stShowRadioButton = ""
        End If
    End Sub

    Private Sub chbDelsi_CheckedChanged(sender As Object, e As EventArgs) Handles chbDelsi.CheckedChanged, chbHlubsi.CheckedChanged, chbVyssi.CheckedChanged
        stCheckBox = ""
        If chbDelsi.Checked Then
            stCheckBox += "_" + chbDelsi.Text + "_"
        End If
        If chbVyssi.Checked Then
            stCheckBox += "_" + chbVyssi.Text + "_"
        End If
        If chbHlubsi.Checked Then
            stCheckBox += "_" + chbHlubsi.Text + "_"
        End If
        stCheckBox = stCheckBox.Replace("__", " ")
        stCheckBox = stCheckBox.Replace("_", " ")
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.MouseDoubleClick
        OtevreniSouboru(2)
    End Sub

    Sub OtevreniSouboru(filIndex As Integer)
        Dim fileReader As System.IO.StreamReader
        Dim drCesta As DialogResult
        Dim stString As String
        OpenFileDialog1.FilterIndex = filIndex
        stString = ""
        drCesta = OpenFileDialog1.ShowDialog()
        If drCesta = DialogResult.OK Then
            fileReader = New IO.StreamReader(OpenFileDialog1.FileName)
            stCesta = "Naposledy otevřený soubor: " + OpenFileDialog1.FileName
            TextBox3.Text = fileReader.ReadToEnd
            fileReader.Close()
        End If
    End Sub
    Private Sub VšechnySouboryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VšechnySouboryToolStripMenuItem.Click
        OtevreniSouboru(1)
    End Sub

    Private Sub DocToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocToolStripMenuItem.Click
        OtevreniSouboru(2)
    End Sub

    Private Sub UložitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UložitToolStripMenuItem.Click
        Uložit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btEsc.Click
        Dim msbAsk As MsgBoxResult
        msbAsk = MsgBox("Chcete soubor uložit?", MsgBoxStyle.YesNoCancel)
        If msbAsk = MsgBoxResult.Yes Then
            Uložit()
            Application.Exit()
        ElseIf msbAsk = MsgBoxResult.No Then
            Application.Exit()
        ElseIf msbAsk = MsgBoxResult.Cancel Then
        End If

    End Sub

    Sub Uložit()
        Dim FileWriter As System.IO.StreamWriter
        Dim drCesta As DialogResult
        drCesta = SaveFileDialog1.ShowDialog
        If drCesta = DialogResult.OK Then
            FileWriter = New IO.StreamWriter(SaveFileDialog1.FileName, False)
            FileWriter.Write(TextBox3.Text)
            FileWriter.Close()
        End If
    End Sub

End Class