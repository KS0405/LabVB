Public Class frmLab1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblYear.Text = Val(txtSalary.Text * 12)
        lblTax.Text = txtSalary.Text * 0.05
        lblTotal.Text = lblYear.Text - lblTax.Text
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class
