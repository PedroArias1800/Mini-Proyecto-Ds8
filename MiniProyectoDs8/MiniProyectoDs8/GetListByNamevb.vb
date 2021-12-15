Imports Newtonsoft.Json

Public Class GetListByNamevb
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim texto As String
        Dim datas() As String
        Dim lo As Long
        Dim da As Date
        Dim texto2 As String
        texto = txtNombre.Text
        ListBox1.Items.Add(Servicios.GetListByName(texto))
        Dim JsonData As String = JsonConvert.SerializeObject(Servicios.GetListByName(texto))
        datas = Split(JsonData, "-")
        MsgBox(JsonData)
    End Sub



End Class