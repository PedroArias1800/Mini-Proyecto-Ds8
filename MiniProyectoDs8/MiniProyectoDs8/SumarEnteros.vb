﻿Imports Newtonsoft.Json

Public Class SumarEnteros
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Integer
        Dim datas() As String
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        TextBox3.Text = Servicios.AddInteger(num1, num2)
        Dim JsonData As String = JsonConvert.SerializeObject(Servicios.FindPerson(num1))
        datas = Split(JsonData, "-")
        MsgBox(JsonData)
    End Sub

    Private Sub SumarEnteros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class