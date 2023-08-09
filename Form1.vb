Public Class Form1
    Private Sub btnCalculatePaye_Click(sender As Object, e As EventArgs) Handles btnCalculatePaye.Click
        Dim decSalary, decPaye As Decimal

        Try

            decSalary = CDec(txtSalary.Text)
            decPaye = (decSalary * 0.3)
            lblPaye.Text = decPaye.ToString("C")
        Catch ex As Exception
            MessageBox.Show("You Entered an Invalid Input. Please Enter An Integer")
        End Try

    End Sub

End Class