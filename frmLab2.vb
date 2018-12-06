Public Class frmLab2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim totalvis, totalcom, commisvis, commiscom, total, commis As Integer
        totalvis = txtTotalVis.Text
        totalcom = txtTotalCom.Text

        commisvis = totalvis * 5 / 100
        commiscom = totalcom * 10 / 100

        total = totalvis + totalcom
        commis = commisvis + commiscom

        lblCommisVis.Text = commisvis
        lblCommisCom.Text = commiscom

        lblCMS.Text = commis
        lblTotal.Text = total
    End Sub

    Private Sub frmLab2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class