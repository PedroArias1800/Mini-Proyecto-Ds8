﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DividirEnteros
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(417, 304)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 39)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(173, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(684, 36)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "El método utilizado del WebService es AddInteger"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(451, 377)
        Me.txtResultado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(327, 34)
        Me.txtResultado.TabIndex = 24
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(491, 238)
        Me.txtNum2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(327, 34)
        Me.txtNum2.TabIndex = 23
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(491, 177)
        Me.txtNum1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(327, 34)
        Me.txtNum1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(277, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 36)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Resultado:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 36)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Segundo Número:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 36)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Primer Númeroo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(328, 78)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(427, 37)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "División De Números Enteros"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DividirEnteros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DividirEnteros"
        Me.Text = "FormDividirEnteros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
End Class
