Imports Newtonsoft.Json

Public Class __LookupCity
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim zip As String
        Dim data(), d1(), d2() As String
        zip = txtZipCode.Text
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

    Private Sub __LookupCity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbxContenido.Width = lblTitulo.Width
        gbxContenido.Left = (Me.Width / 2) - (gbxContenido.Width / 2)
        gbxContenido.Top = (Me.Height / 2) - (gbxContenido.Height / 2)
    End Sub
End Class