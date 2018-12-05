Public Class Lap1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbltotal.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim txt As Double = TextBox1.Text
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double

        num1 = txt * 12
        num2 = num1 * 0.05
        num3 = num1 - num2

        lblnet.Text = lblnet.Text + "  =  " + num1.ToString("###,###,###") + "  บาท"
        lbltax.Text = lbltax.Text + "  =  " + num2.ToString("###,###,###") + "  บาท"
        lbltotal.Text = lbltotal.Text + "  =  " + num3.ToString("###,###,###") + "  บาท"
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class
