Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Web.Script.Serialization

Imports System.Xml
Public Class GetListByNamevb
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim Data() As String
        name = txtNombre.Text

        Dim xmlR = XmlReader.Create("https://www.crcind.com/csp/samples/SOAP.Demo.cls?soap_method=GetListByName&name=" & name)
        Dim al As ArrayList = New ArrayList()



        Do While xmlR.Read()


            If xmlR.NodeType = XmlNodeType.Element AndAlso xmlR.Name = "Name" Then
                al.Add(xmlR.ReadElementContentAsString & vbCrLf)

            End If




        Loop






        If al IsNot Nothing Then

            For Each item As String In al

                ListBox1.Items.Add(item)

            Next

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cadena As String
        Dim datas() As String
        cadena = txtNombre.Text

        Dim JsonData As String = ListBox1.Items.Add(JsonConvert.SerializeObject(Servicios.GetListByName(cadena), formatting:=Newtonsoft.Json.Formatting.Indented))
        datas = Split(JsonData, ".")
        Dim alldata As JObject = JObject.Parse(JsonData)
        MsgBox(JsonData)
    End Sub

End Class