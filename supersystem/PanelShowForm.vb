Module PanelShowForm

    Function ShowFormInPanel(form As Form, panel As Panel)
        ' Set form properties
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        ' Clear the panel and add the form
        panel.Controls.Clear()
        panel.Controls.Add(form)

        ' Show the form
        form.Show()
    End Function

End Module
