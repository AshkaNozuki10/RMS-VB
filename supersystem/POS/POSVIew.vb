Public Class POSVIew


    ' Create instances of the other forms
    Private dashboardForm As New Dashboard()
    Private salesForm As New Sales()
    Private ingredientsForm As New Food_Ingredients()
    'Private imsForm As New IMSForm()
    'Private empForm As New EMPForm()

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowFormInPanel(dashboardForm, pnlPOS)
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        ShowFormInPanel(salesForm, pnlPOS)
    End Sub

    Private Sub btnIngredients_Click(sender As Object, e As EventArgs) Handles btnIngredients.Click
        ShowFormInPanel(ingredientsForm, pnlPOS)
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnNnM_Click(sender As Object, e As EventArgs) Handles btnNnM.Click
        If Me.WindowState = FormWindowState.Normal Then
            ' If the form is in normal state, maximize it
            Me.WindowState = FormWindowState.Maximized
        Else
            ' If the form is maximized, restore it to normal state
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class