Imports System.Data.SqlClient
Public Class DoctorsForm
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\HospitaldbVB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub MaskedTextBox4_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles DocSpecTb.MaskInputRejected

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DoctorId_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles DocidTb.MaskInputRejected

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Con.Open()
        Dim query As String
        query = "insert into DoctorTbl values(" & DocidTb.Text & ", '" & DocNameTb.Text & "', " & DocExpTb.Text & ", '" & DocGenderCb.SelectedItem.ToString() & "', '" & DocSpecTb.Text & "', '" & DocPassTb.Text & "'  )"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Doctor Successfully Added")

        Con.Close()
        populate()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from DoctorTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DoctorDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub DoctorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If DocidTb.Text = "" Then
            MsgBox("Enter The Doctor Id")
        Else
            Con.Open()
            Dim query As String
            query = "delete from DoctorTbl where Docid = " & DocidTb.Text & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox(" Doctor Successfully Deleted")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If DocidTb.Text = " " Or DocNameTb.Text = " " Or DocPassTb.Text = " " Or DocSpecTb.Text = " " Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("update DoctorTbl set DocName = '" & DocNameTb.Text & "', DocExp= '" & DocExpTb.Text & "', DocGender= '" & DocGenderCb.SelectedItem.ToString() & "', DocSpec= '" & DocSpecTb.Text & "', DocPass = '" & DocPassTb.Text & "'
                                            where Docid = " & DocidTb.Text & " ", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Doctor Updated Successfully")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub DoctorDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DoctorDGV.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim log = New LoginForm
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pat = New PatientForm
        pat.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rec = New Receptionist
        rec.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim treat = New TreatmentForm
        treat.Show()
        Me.Hide()
    End Sub
End Class