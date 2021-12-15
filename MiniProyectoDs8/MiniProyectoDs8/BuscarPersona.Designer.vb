<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarPersona
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
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.idPersona = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.rtb2 = New System.Windows.Forms.RichTextBox()
        Me.rtb3 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Buscar
        '
        Me.Buscar.BackColor = System.Drawing.Color.DimGray
        Me.Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.ForeColor = System.Drawing.Color.White
        Me.Buscar.Location = New System.Drawing.Point(451, 129)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(181, 40)
        Me.Buscar.TabIndex = 22
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(209, 451)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(681, 36)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "El método utilizado del WebService es FindPerson"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'idPersona
        '
        Me.idPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPersona.Location = New System.Drawing.Point(577, 89)
        Me.idPersona.Name = "idPersona"
        Me.idPersona.Size = New System.Drawing.Size(121, 34)
        Me.idPersona.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 36)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Inserte Un ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(390, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 37)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Buscar Una Persona"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(427, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 29)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Datos Del Usuario:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 27)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Personales:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(483, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 27)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Residencia:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(828, 235)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 27)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Oficina:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtb1
        '
        Me.rtb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb1.Location = New System.Drawing.Point(50, 265)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(310, 156)
        Me.rtb1.TabIndex = 41
        Me.rtb1.Text = ""
        '
        'rtb2
        '
        Me.rtb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb2.Location = New System.Drawing.Point(386, 265)
        Me.rtb2.Name = "rtb2"
        Me.rtb2.Size = New System.Drawing.Size(310, 156)
        Me.rtb2.TabIndex = 42
        Me.rtb2.Text = ""
        '
        'rtb3
        '
        Me.rtb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb3.Location = New System.Drawing.Point(718, 265)
        Me.rtb3.Name = "rtb3"
        Me.rtb3.Size = New System.Drawing.Size(310, 156)
        Me.rtb3.TabIndex = 43
        Me.rtb3.Text = ""
        '
        'BuscarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1081, 632)
        Me.Controls.Add(Me.rtb3)
        Me.Controls.Add(Me.rtb2)
        Me.Controls.Add(Me.rtb1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.idPersona)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "BuscarPersona"
        Me.Text = "Buscar Persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents idPersona As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents rtb1 As RichTextBox
    Friend WithEvents rtb2 As RichTextBox
    Friend WithEvents rtb3 As RichTextBox
End Class
