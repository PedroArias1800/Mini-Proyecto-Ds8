Public Class MiniProyecto
    Private Sub PresentaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentaciónToolStripMenuItem.Click
        GroupBox1.Visible = False
        Presentacion.MdiParent = Me
        Presentacion.WindowState = FormWindowState.Maximized
        Presentacion.Show()
    End Sub
    Private Sub SumaDeEnterosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaDeEnterosToolStripMenuItem.Click
        GroupBox1.Visible = False
        SumarEnteros.MdiParent = Me
        SumarEnteros.WindowState = FormWindowState.Maximized
        SumarEnteros.Show()
    End Sub
    Private Sub ObtenerListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObtenerListaToolStripMenuItem.Click
        GroupBox1.Visible = False
        GetListByNamevb.MdiParent = Me
        GetListByNamevb.WindowState = FormWindowState.Maximized
        GetListByNamevb.Show()
    End Sub
    Private Sub ObtenerConjuntoDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObtenerConjuntoDeDatosToolStripMenuItem.Click
        GroupBox1.Visible = False
        GetDataSetByName.MdiParent = Me
        GetDataSetByName.WindowState = FormWindowState.Maximized
        GetDataSetByName.Show()
    End Sub
    Private Sub DividirEnterosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DividirEnterosToolStripMenuItem.Click
        GroupBox1.Visible = False
        DividirEnteros.MdiParent = Me
        DividirEnteros.WindowState = FormWindowState.Maximized
        DividirEnteros.Show()
    End Sub

    Private Sub MiniProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        GroupBox1.Visible = False
        BuscarPersona.MdiParent = Me
        BuscarPersona.WindowState = FormWindowState.Maximized
        BuscarPersona.Show()
    End Sub

    Private Sub BuscarCiudadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarCiudadToolStripMenuItem.Click
        LookUpCity.MdiParent = Me
        LookUpCity.WindowState = FormWindowState.Maximized
        LookUpCity.Show()
    End Sub

End Class
