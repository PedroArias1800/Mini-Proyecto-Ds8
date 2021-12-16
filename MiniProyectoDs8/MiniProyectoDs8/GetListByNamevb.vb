Imports Newtonsoft.Json

Public Class GetListByNamevb
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient
    Private Sub GetDataSetByName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        Label2.Left = Me.Width / 2 - (Label2.Width / 2)
        Label5.Left = Me.Width / 2 - (Label5.Width / 2)
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim name As String
        Dim datos(), datoPrincipio(), datoFinal() As String
        name = txtName.Text

        If name = "" Then
            MsgBox("Escriba un nombre primero", vbYes, "Error...")
        Else
            Dim JsonData As String = JsonConvert.SerializeObject(Servicios.GetListByName(name))
            datos = Split(JsonData, "},{")

            If CInt(JsonData.Length / 116) = 0 Then
                rtb1.Text = "No hay registros para desplegar"

            ElseIf CInt(JsonData.Length / 116) = 1 Then
                datos = Split(datos(0), "[{")
                datos = Split(datos(1), "}]")
                rtb1.Text = datos(0)

            ElseIf CInt(JsonData.Length / 116) > 1 Then

                datoPrincipio = Split(datos(0), "[{")
                datoFinal = Split(datos(CInt(JsonData.Length / 116)), "}]")

                For x = 0 To CInt(JsonData.Length / 114)
                    If x = 0 Then
                        rtb1.Text = datoPrincipio(1) & vbCrLf
                    ElseIf x = CInt(JsonData.Length / 114) Then
                        rtb1.Text = rtb1.Text & datoFinal(0)
                    Else
                        rtb1.Text = rtb1.Text & datos(x) & vbCrLf
                    End If
                Next

            End If

        End If

    End Sub

End Class