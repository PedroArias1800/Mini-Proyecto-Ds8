Public Class MiniProyecto
    Private Sub PresentaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentaciónToolStripMenuItem.Click
        Presentacion.MdiParent = Me
        Presentacion.WindowState = FormWindowState.Maximized
        Presentacion.Show()
    End Sub
    Private Sub SumaDeEnterosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaDeEnterosToolStripMenuItem.Click
        SumarEnteros.MdiParent = Me
        SumarEnteros.WindowState = FormWindowState.Maximized
        SumarEnteros.Show()
    End Sub



    Private Sub ObtenerConjuntoDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObtenerConjuntoDeDatosToolStripMenuItem.Click
        GetListByNamevb.MdiParent = Me
        GetListByNamevb.WindowState = FormWindowState.Maximized
        GetListByNamevb.Show()
    End Sub

    Private Sub DividirEnterosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DividirEnterosToolStripMenuItem.Click
        DividirEnteros.MdiParent = Me
        DividirEnteros.WindowState = FormWindowState.Maximized
        DividirEnteros.Show()
    End Sub
End Class
