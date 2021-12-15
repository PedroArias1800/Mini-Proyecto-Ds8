Module Validaciones
    Public Sub Numerico(ByRef CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Module
