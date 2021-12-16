Imports Newtonsoft.Json
Public Class DividirEnteros
    Dim Servicios As New WebServiceSoap.SOAPDemoSoapClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Integer
        'Dim datas() As String
        num1 = Val(txtNum1.Text)
        num2 = Val(txtNum2.Text)

        If num2 = 0 Then
            MsgBox("No se puede dividir entre cero.")

        ElseIf num1 < num2 Then
            MsgBox("El dividendo debe ser mayor que el divisor.")

        Else
            Try
                txtResultado.Text = JsonConvert.SerializeObject(Servicios.DivideInteger(num1, num2))
                'Math.Round(Val(Servicios.DivideInteger(num1, num2)), 0)
                'Servicios.DivideInteger(num1, num2)

            Catch ex As Exception
                MsgBox("Ha ocurrido un error inesperado, vuelva a intentarlo...", vbYes, "Ups! algo ha salido mal :(")

                'En esta función no pudimos encontrar el error que nos arrojaba cuando intentábamos dividir y el resultado era una cifra no exacta(Con Decimales)
                'Por lo que decidimos hacer ese proceso cuando esto sucedía aquí en Visual Basic
                txtResultado.Text = num1 / num2

            End Try
        End If
        'Dim JsonData As String = JsonConvert.SerializeObject(Servicios.DivideInteger(num1, num2))
        'datas = Split(JsonData, "-")
        'MsgBox(JsonData)
    End Sub

    Private Sub txtNum1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum1.KeyPress
        Numerico(txtNum1, e)
    End Sub

    Private Sub txtNum2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum2.KeyPress
        Numerico(txtNum2, e)
    End Sub
    Private Sub DividirEnteros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        Label2.Left = Me.Width / 2 - (Label2.Width / 2)
        Label5.Left = Me.Width / 2 - (Label5.Width / 2)
    End Sub
End Class