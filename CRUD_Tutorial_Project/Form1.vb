Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection("Data Source=SUDIPTO\SUDIPTO;Initial Catalog=ProgrammingDB;Integrated Security=True")
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
        con.Open()
        Dim cmd As New SqlCommand("Insert into Product_Setup_Tab values ('" & productId & "','" & itemName & "','" & design & "','" & color & "','" & itemDate & "','" & wType & "')", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Successfully Inserted")
        con.Close()
        LoadDataInGrid()
    End Sub

    Private Sub LoadDataInGrid()
        con.Open()
        Dim cmd As New SqlCommand("select * from Product_Setup_Tab", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        dgvData.DataSource = dt
        con.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
        con.Open()
        Dim cmd As New SqlCommand("update Product_Setup_Tab set ItemName = '" & itemName & "',Design = '" & design & "',Color = '" & color & "',ItemDate = '" & itemDate & "',WarrantyType = '" & wType & "' where Product_ID = '" & productId & "'", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Successfully Updated")
        con.Close()
        LoadDataInGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        con.Open()
        Dim productId As Integer = Convert.ToInt32(txtProductId.Text)
        Dim cmd As New SqlCommand("delete from Product_Setup_Tab where Product_ID = '" & productId & "'", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Successfully Deleted")
        con.Close()
        LoadDataInGrid()
    End Sub
End Class
