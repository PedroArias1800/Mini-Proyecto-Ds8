Imports Newtonsoft.Json

Public Class LookUpCity
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim zip As String
        Dim data(), d1(), d2() As String
        zip = txtCodigoPostal.Text
        Try
            txtEstado.ForeColor = Color.Black
            txtCiudad.ForeColor = Color.Black
            Dim JsonData As String = JsonConvert.SerializeObject(Servicios.LookupCity(zip))
            data = Split(JsonData, ",")
            d1 = Split(data(1), ":")
            d2 = Split(data(2), ":")
            txtEstado.Text = d2(1)
            txtCiudad.Text = d1(1)
        Catch ex As Exception
            txtEstado.Text = "-ERROR-"
            txtCiudad.Text = "NO ENCONTRADO"
            txtEstado.ForeColor = Color.Red
            txtCiudad.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub LookUpCity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        Label2.Left = Me.Width / 2 - (Label2.Width / 2)
        Label5.Left = Me.Width / 2 - (Label5.Width / 2)
    End Sub

    Private Sub txtCodigoPostal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPostal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class