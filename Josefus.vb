Option Explicit On
Option Strict On
Option Infer On
Module Josefus
    Sub Main()
        Dim F As New Form1
        Dim stZadej As String
        stZadej = InputBox("Zadej název formuláře:")
        F.Text = stZadej
        F.ShowDialog()
    End Sub
End Module
