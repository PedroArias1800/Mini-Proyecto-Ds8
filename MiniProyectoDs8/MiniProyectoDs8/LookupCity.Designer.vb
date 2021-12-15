<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class __LookupCity
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.gbxContenido = New System.Windows.Forms.GroupBox()
        Me.gbxContenido.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(259, 200)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(145, 47)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(6, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(581, 114)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Obteniendo Ciudad y Estado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en Base al Código Postal (Zip Code)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consumiendo un W" &
    "S"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtZipCode
        '
        Me.txtZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(338, 156)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(177, 38)
        Me.txtZipCode.TabIndex = 2
        Me.txtZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoPostal.Location = New System.Drawing.Point(131, 159)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(201, 32)
        Me.lblCodigoPostal.TabIndex = 3
        Me.lblCodigoPostal.Text = "Código Postal:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(131, 266)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(112, 32)
        Me.lblEstado.TabIndex = 5
        Me.lblEstado.Text = "Estado:"
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudad.Location = New System.Drawing.Point(131, 310)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(114, 32)
        Me.lblCiudad.TabIndex = 6
        Me.lblCiudad.Text = "Ciudad:"
        '
        'txtCiudad
        '
        Me.txtCiudad.BackColor = System.Drawing.Color.White
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(249, 307)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.ReadOnly = True
        Me.txtCiudad.Size = New System.Drawing.Size(266, 38)
        Me.txtCiudad.TabIndex = 7
        Me.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.White
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(249, 263)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(266, 38)
        Me.txtEstado.TabIndex = 8
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxContenido
        '
        Me.gbxContenido.Controls.Add(Me.lblCiudad)
        Me.gbxContenido.Controls.Add(Me.txtCiudad)
        Me.gbxContenido.Controls.Add(Me.txtEstado)
        Me.gbxContenido.Controls.Add(Me.lblTitulo)
        Me.gbxContenido.Controls.Add(Me.lblEstado)
        Me.gbxContenido.Controls.Add(Me.txtZipCode)
        Me.gbxContenido.Controls.Add(Me.lblCodigoPostal)
        Me.gbxContenido.Controls.Add(Me.btnBuscar)
        Me.gbxContenido.Location = New System.Drawing.Point(250, 102)
        Me.gbxContenido.Name = "gbxContenido"
        Me.gbxContenido.Size = New System.Drawing.Size(614, 362)
        Me.gbxContenido.TabIndex = 9
        Me.gbxContenido.TabStop = False
        Me.gbxContenido.Text = "GroupBox1"
        '
        '__LookupCity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.MiniProyectoDs8.My.Resources.Resources.ciudad
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1122, 599)
        Me.Controls.Add(Me.gbxContenido)
        Me.Name = "__LookupCity"
        Me.Text = "__LookupCity"
        Me.gbxContenido.ResumeLayout(False)
        Me.gbxContenido.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents lblCodigoPostal As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblCiudad As Label
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents gbxContenido As GroupBox
End Class
