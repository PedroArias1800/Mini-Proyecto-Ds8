﻿Public Class MiniProyecto
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
End Class
