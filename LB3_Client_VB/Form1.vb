Public Class Form1
    Const ITERATIONS = 500000
    Private Sub Bt_Late_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Late.Click
        ' пример позднего связывания
        Dim obj As Object
        Dim i As Long
        Dim Start As DateTime = DateTime.Now
        ' Создание объекта с указанным ProgId
        obj = CreateObject("Lb3_autosvr.CoMyMath.1")
        txtResult.Text = obj.Add(TxtOp1.Text, txtOp2.Text)
        For i = 1 To ITERATIONS
            txtResult.Text = obj.Add(TxtOp1.Text, txtOp2.Text)
        Next
        txtTime1.Text = (DateTime.Now - Start).TotalSeconds
        obj = Nothing
    End Sub
    Private Sub Bt_Id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_ID.Click
        ' Пример ID-связывания
        Dim obj As LB3_autosvrLib.CoMyMath 'указание на TypeLib, добавляем ссылку на библитеку в ссылках проекта
        Dim i As Long
        Dim Start As DateTime = DateTime.Now
        obj = New LB3_autosvrLib.CoMyMath
        txtResult.Text = obj.Add(TxtOp1.Text, txtOp2.Text)
        For i = 1 To ITERATIONS
            txtResult.Text = obj.Add(TxtOp1.Text, txtOp2.Text)
        Next
        txtTime2.Text = (DateTime.Now - Start).TotalSeconds
    End Sub
    Private Sub Bt_Vtbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_vtbl.Click
        ' Пример связывания через vtbl(очень раннего связывания)
        Dim i As Long
        Dim obj As New LB3_autosvrLib.CoMyMath
        Dim Start As DateTime = DateTime.Now
        txtResult.Text = obj.Add(TxtOp1.Text, txtOp2.Text)
        For i = 1 To ITERATIONS
            txtResult.Text = obj.Add(TxtOp1.Text, txtOp2.Text)
        Next
        txtTime3.Text = (DateTime.Now - Start).TotalSeconds
    End Sub
End Class