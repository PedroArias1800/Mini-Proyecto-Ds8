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

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        BuscarPersona.MdiParent = Me
        BuscarPersona.WindowState = FormWindowState.Maximized
        BuscarPersona.Show()
    End Sub
    Private Sub ObtenerConjuntoDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObtenerConjuntoDeDatosToolStripMenuItem.Click
        GetDataSetByName.MdiParent = Me
        GetDataSetByName.WindowState = FormWindowState.Maximized
        GetDataSetByName.Show()
    End Sub

    Private Sub ObtenerListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObtenerListaToolStripMenuItem.Click
        GetListByNamevb.MdiParent = Me
        GetListByNamevb.WindowState = FormWindowState.Maximized
        GetListByNamevb.Show()
    End Sub

    Private Sub BuscarCiudadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarCiudadToolStripMenuItem.Click
        __LookupCity.MdiParent = Me
        __LookupCity.WindowState = FormWindowState.Maximized
        __LookupCity.Show()
    End Sub

    Private Sub MiniProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
