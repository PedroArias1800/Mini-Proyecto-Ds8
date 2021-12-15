Imports Newtonsoft.Json

Public Class __LookupCity
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim zip As String
        Dim data() As String
        zip = txtZipCode.Text
        Dim JsonData As String = JsonConvert.SerializeObject(Servicios.LookupCity(zip))
        'MsgBox(JsonData)
        txtInfo.Text = JsonData
    End Sub
End Class