﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiniProyecto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PresentaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumaDeEnterosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DividirEnterosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObtenerConjuntoDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObtenerListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarCiudadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PresentaciónToolStripMenuItem, Me.SumaDeEnterosToolStripMenuItem, Me.DividirEnterosToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ObtenerConjuntoDeDatosToolStripMenuItem, Me.ObtenerListaToolStripMenuItem, Me.BuscarCiudadToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1081, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PresentaciónToolStripMenuItem
        '
        Me.PresentaciónToolStripMenuItem.Name = "PresentaciónToolStripMenuItem"
        Me.PresentaciónToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.PresentaciónToolStripMenuItem.Text = "Presentación"
        '
        'SumaDeEnterosToolStripMenuItem
        '
        Me.SumaDeEnterosToolStripMenuItem.Name = "SumaDeEnterosToolStripMenuItem"
        Me.SumaDeEnterosToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.SumaDeEnterosToolStripMenuItem.Text = "Sumar Enteros"
        '
        'DividirEnterosToolStripMenuItem
        '
        Me.DividirEnterosToolStripMenuItem.Name = "DividirEnterosToolStripMenuItem"
        Me.DividirEnterosToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.DividirEnterosToolStripMenuItem.Text = "Dividir Enteros"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.BuscarToolStripMenuItem.Text = "Buscar Persona"
        '
        'ObtenerConjuntoDeDatosToolStripMenuItem
        '
        Me.ObtenerConjuntoDeDatosToolStripMenuItem.Name = "ObtenerConjuntoDeDatosToolStripMenuItem"
        Me.ObtenerConjuntoDeDatosToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.ObtenerConjuntoDeDatosToolStripMenuItem.Text = "Obtener Conjunto De Datos"
        '
        'ObtenerListaToolStripMenuItem
        '
        Me.ObtenerListaToolStripMenuItem.Name = "ObtenerListaToolStripMenuItem"
        Me.ObtenerListaToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.ObtenerListaToolStripMenuItem.Text = "Obtener Lista"
        '
        'BuscarCiudadToolStripMenuItem
        '
        Me.BuscarCiudadToolStripMenuItem.Name = "BuscarCiudadToolStripMenuItem"
        Me.BuscarCiudadToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.BuscarCiudadToolStripMenuItem.Text = "Buscar Ciudad"
        '
        'MiniProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1081, 632)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MiniProyecto"
        Me.Text = "Mini Proyecto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SumaDeEnterosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DividirEnterosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ObtenerConjuntoDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ObtenerListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarCiudadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresentaciónToolStripMenuItem As ToolStripMenuItem
End Class
