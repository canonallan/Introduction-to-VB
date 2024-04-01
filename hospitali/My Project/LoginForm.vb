Imports System.Data.SqlClient

Public Class LoginForm

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\HospitaldbVB.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand

    Private Sub LogReceptionist()
        If UnamepassTb.Text = "" Then
            MsgBox("Enter Receptionist Name")
        ElseIf PasswordTb.Text = "" Then
            MsgBox("Enter password")
        Else
            Con.Open()
            Dim query = "select * from ReceptionistTbl where RecepName = '" & UnamepassTb.Text & "' and password='" & PasswordTb.Text & "'  "
            cmd = New SqlCommand(query, Con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong Username or Password")
            Else
                Dim patient = New PatientForm
                patient.Show()
                Me.Hide()

            End If

            Con.Close()
        End If
    End Sub

    Private Sub LogDoctor()
        If UnamepassTb.Text = "" Then
            MsgBox("Enter Doctor Name")
        ElseIf PasswordTb.Text = "" Then
            MsgBox("Enter password")
        Else
            Con.Open()
            Dim query = "select * from DoctorTbl where DocName = '" & UnamepassTb.Text & "' and Docpass='" & PasswordTb.Text & "'  "
            cmd = New SqlCommand(query, Con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong Doctor or Password")
            Else
                Dim diag = New DiagnosisForm
                diag.Show()
                Me.Hide()

            End If

            Con.Close()
        End If
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles UnamepassTb.MaskInputRejected

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoleCb.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RoleCb.SelectedIndex = -1 Then
            MessageBox.Show("Please select a role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim selectedRole As String = RoleCb.SelectedItem.ToString()

            If selectedRole = "Receptionist" Then
                LogReceptionist()
            ElseIf selectedRole = "Doctor" Then
                LogDoctor()
            End If
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        UnamepassTb.Text = ""
        PasswordTb.Text = ""
    End Sub
End Class