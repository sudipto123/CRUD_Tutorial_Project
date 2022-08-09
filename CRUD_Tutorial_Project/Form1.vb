Imports System.Data.SqlClient

Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim productId As Integer = Convert.ToInt32(txtProductId.Text)
        Dim itemName As String = txtItemName.Text
        Dim design As String = txtDesign.Text
        Dim color As String = cmbColor.Text
        Dim itemDate As DateTime = Convert.ToDateTime(dtpItemDate.Value.ToString("yyyy-MM-dd"))
        Dim wType As String = ""
        If (rbAllowedWt.Checked = True) Then
            wType = "Allowed"
        Else
            wType = "Not Allowed"
        End If
        Dim con As New SqlConnection("Data Source=SUDIPTO\SUDIPTO;Initial Catalog=ProgrammingDB;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("Insert into Product_Setup_Tab values ('" & productId & "','" & itemName & "','" & design & "','" & color & "','" & itemDate & "','" & wType & "')", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Successfully Inserted")
        con.Close()
    End Sub
End Class
