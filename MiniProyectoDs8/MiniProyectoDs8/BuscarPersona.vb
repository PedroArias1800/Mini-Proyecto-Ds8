Imports Newtonsoft.Json

Public Class BuscarPersona
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim id As Integer
        Dim datos(), data1(), data2(), data3(), data4() As String
        id = Val(idPersona.Text)
        Dim JsonData As String = JsonConvert.SerializeObject(Servicios.FindPerson(id))
        datos = Split(JsonData, ":{")

        data1 = Split(datos(0), "{")
        data2 = Split(datos(1), "},")
        data3 = Split(datos(2), "},")
        rtb1.Text = data1(1)
        rtb2.Text = data2(0)
        rtb3.Text = data3(0)
        data3 = Split(data3(1), "}")

        rtb1.Text = rtb1.Text & data3(0)

        'rtb2.Text = data1(2)
        'rtb3.Text = data1(3)

    End Sub
End Class