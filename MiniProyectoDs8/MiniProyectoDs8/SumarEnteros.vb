Imports Newtonsoft.Json

Public Class SumarEnteros
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Integer
        Dim datas() As String
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Primero inserte 2 valores para sumarlos...", vbYes, "Ha ocurrido un error...")

        Else
            TextBox3.Text = Servicios.AddInteger(num1, num2)
            Dim JsonData As String = JsonConvert.SerializeObject(Servicios.FindPerson(num1))
            datas = Split(JsonData, "-")

        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SumarEnteros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        Label2.Left = Me.Width / 2 - (Label2.Width / 2)
        Label5.Left = Me.Width / 2 - (Label5.Width / 2)
    End Sub
End Class