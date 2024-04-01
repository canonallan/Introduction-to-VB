Imports System.Data.SqlClient
Public Class TreatmentForm
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\HospitaldbVB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub TreatmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Con.Open()
        Dim query As String
        query = "insert into TreatmentTbl values(" & TreatIdTb.Text & ", '" & TreatDescTb.Text & "', " & TreatCostTb.Text & " )"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Treatment Successfully Added")

        Con.Close()
        populate()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from TreatmentTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        TreatDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TreatIdTb.Text = "" Then
            MsgBox("Enter The Treat Id")
        Else
            Con.Open()
            Dim query As String
            query = "delete from TreatmentTbl where TreatId = " & TreatIdTb.Text & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox(" Treatment Successfully Deleted")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TreatIdTb.Text = " " Or TreatDescTb.Text = " " Or TreatCostTb.Text = " " Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("update TreatmentTbl set TreatDesc = '" & TreatDescTb.Text & "', TreatCost= '" & TreatCostTb.Text & "'
                                            where TreatId = " & TreatIdTb.Text & " ", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Treatment Updated Successfully")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim doc = New DoctorsForm
        doc.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rec = New Receptionist
        rec.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pat = New PatientForm
        pat.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim log = New LoginForm
        log.Show()
        Me.Hide()
    End Sub
End Class