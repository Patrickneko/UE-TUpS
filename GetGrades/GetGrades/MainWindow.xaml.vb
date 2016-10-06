Class MainWindow 

    Private Sub GetClick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Dim a As Integer = TxtI1.Text
        Dim b As Integer = TxtI2.Text
        Dim c As Integer = TxtI3.Text
        Dim d As Integer = TxtI4.Text
        Dim ee As Integer = TxtI5.Text
        Dim f As Integer = TxtI6.Text
        Dim g As Integer = TxtI7.Text
        Dim h As Integer = TxtI8.Text
        Dim i As Integer = TxtI9.Text
        Dim j As Integer = TxtI10.Text
        Dim k As Integer = TxtI11.Text
        Dim l As Integer = Txt12.Text
        Dim SeatW, Qz, AveSw, AveQz, AveRec, AveExam, AveExam2, AveExam3, fG As Double

        SeatW = ((a + b + c + d + l) / 5)
        Qz = ((ee + f + g) / 3)
        AveRec = h * 0.1
        AveSw = SeatW * 0.15
        AveQz = Qz * 0.15
        AveExam = i * 0.15
        AveExam2 = j * 0.2
        AveExam3 = k * 0.25
        fG = AveExam + AveExam2 + AveExam3 + AveQz + AveRec + AveSw

        If fG <= 100 And fG >= 94 Then
            TxtO2.Text = "1.00"
            TxtO3.Text = "Excellent"
        ElseIf fG <= 95 And fG >= 94 Then
            TxtO2.Text = "1.25"
            TxtO3.Text = "VeryGood"
        ElseIf fG <= 93 And fG >= 92 Then
            TxtO2.Text = "1.50"
            TxtO3.Text = "VeryGood"
        ElseIf fG <= 91 And fG >= 89 Then
            TxtO2.Text = "1.75"
            TxtO3.Text = "VeryGood"
        ElseIf fG <= 88 And fG >= 87 Then
            TxtO2.Text = "2.00"
            TxtO3.Text = "Good"
        ElseIf fG <= 86 And fG >= 84 Then
            TxtO2.Text = "2.25"
            TxtO3.Text = "Good"
        ElseIf fG <= 83 And fG >= 82 Then
            TxtO2.Text = "2.50"
            TxtO3.Text = "Fair"
        ElseIf fG <= 81 And fG >= 79 Then
            TxtO2.Text = "2.75"
            TxtO3.Text = "Fair"
        ElseIf fG <= 78 And fG >= 75 Then
            TxtO2.Text = "3.000"
            TxtO3.Text = "Fair"
        Else
            TxtO2.Text = "5.00"
            TxtO3.Text = "Failure"
        End If

        TxtO1.Text = fG
    End Sub


End Class
