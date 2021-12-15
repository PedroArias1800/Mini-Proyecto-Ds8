Imports Newtonsoft.Json

Public Class BuscarPersona
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim id As Integer
        Dim datos(), data1(), data2(), data3() As String
        id = Val(idPersona.Text)

        If idPersona.Text = "" Then
            MsgBox("Primero inserte el ID de un usuario...", vbYes, "Ha ocurrido un error")

        Else
            Dim JsonData As String = JsonConvert.SerializeObject(Servicios.FindPerson(id))

            If JsonData.Length = 4 Then
                MsgBox("No existe un usuario con ese ID. Intente nuevamente...", vbYes, "Ups! Algo salió mal :(")
            Else
                datos = Split(JsonData, ":{")

                data1 = Split(datos(0), "{")
                data2 = Split(datos(1), "},")
                data3 = Split(datos(2), "},")
                rtb1.Text = data1(1)
                rtb2.Text = data2(0)
                rtb3.Text = data3(0)
                data3 = Split(data3(1), "}")

                rtb1.Text = rtb1.Text & data3(0)

            End If

        End If

    End Sub

    Private Sub BuscarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        Label2.Left = Me.Width / 2 - (Label2.Width / 2)
        Label5.Left = Me.Width / 2 - (Label5.Width / 2)
    End Sub

    Private Sub idPersona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idPersona.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class