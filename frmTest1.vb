Public Class frmTest1
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblTax.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'txtHour.Text
        'txtPayRate.Text
        lblTotal.Text = Val(txtHour.Text) * Val(txtPayRate.Text)
        lblTax.Text = Val(lblTotal.Text) * 3 / 100
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCal2_Click(sender As Object, e As EventArgs) Handles btnCal2.Click
        Dim hours As Integer
        Dim payRate, total, tax As Double

        hours = Val(txtHour.Text)
        payRate = Val(txtPayRate.Text)

        total = hours * payRate
        tax = total * 0.03

        lblTotal.Text = total
        lblTax.Text = tax

    End Sub
End Class
