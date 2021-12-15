Imports Newtonsoft.Json

Public Class __LookupCity
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim zip As String
        Dim data(), d1(), d2() As String
        zip = txtZipCode.Text
        Dim JsonData As String = JsonConvert.SerializeObject(Servicios.LookupCity(zip))
        data = Split(JsonData, ",")
        d1 = Split(data(1), ":")
        d2 = Split(data(2), ":")
        txtEstado.Text = d2(1)
        txtCiudad.Text = d1(1)
    End Sub
End Class