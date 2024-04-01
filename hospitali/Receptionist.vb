Imports System.Data.SqlClient



Public Class Receptionist
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\HospitaldbVB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim doc = New DoctorsForm
        doc.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles RecepidTb.MaskInputRejected

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Con.Open()
        Dim query As String
        query = "insert into ReceptionistTbl values(" & RecepidTb.Text & ", '" & RecepnameTb.Text & "', '" & ReceppassTb.Text & "', '" & RecepphoneTb.Text & "', '" & RecepaddTb.Text & "' )"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Receptionist Successfully Added")

        Con.Close()
        populate()

    End Sub

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from ReceptionistTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ReceptionistsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Receptionist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If RecepidTb.Text = "" Then
            MsgBox("Enter The Receptionist Id")
        Else
            Con.Open()
            Dim query As String
            query = "delete from ReceptionistTbl where RecepId = " & RecepidTb.Text & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox(" Receptionist Successfully Deleted")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If RecepaddTb.Text = " " Or RecepnameTb.Text = " " Or ReceppassTb.Text = " " Or RecepphoneTb.Text = " " Or RecepaddTb.Text = " " Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("update ReceptionistTbl set RecepName = '" & RecepnameTb.Text & "', password= '" & ReceppassTb.Text & "', phone= '" & RecepphoneTb.Text & "', address= '" & RecepaddTb.Text & "'
                                            where RecepId = " & RecepidTb.Text & " ", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Receptionist Updated")
            Con.Close()
            populate()
        End If
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim treat = New TreatmentForm
        treat.Show()
        Me.Hide()
    End Sub
End Class