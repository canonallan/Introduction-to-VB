Imports System.Data.SqlClient

Public Class DiagnosisForm
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\HospitaldbVB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FillPatientCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from PatientTbl", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        PatIdCb.DataSource = Tbl
        PatIdCb.DisplayMember = "PatId"
        PatIdCb.ValueMember = "PatId"
        Con.Close()
    End Sub

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from DiagnosisTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DiagnosisDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub FillTreatmentCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from TreatmentTbl", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        TreatCb.DataSource = Tbl
        TreatCb.DisplayMember = "TreatDesc"
        TreatCb.ValueMember = "TreatDesc"
        Con.Close()
    End Sub
    Private Sub MaskedTextBox3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MedicineTb.MaskInputRejected

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PatNameCb_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PatNameTb.MaskInputRejected

    End Sub

    Private Sub DiagnosisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillPatientCombo()
        FillTreatmentCombo()
        populate()
    End Sub

    Private Sub PatIdCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PatIdCb.SelectedIndexChanged

    End Sub
    Private Sub PatIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PatIdCb.SelectionChangeCommitted
        Con.Open()
        Dim query = "select * from PatientTbl where PatId= " & PatIdCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            PatNameTb.Text = reader(1)
        End While
        Con.Close()
    End Sub

    Private Sub TreatCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TreatCb.SelectedIndexChanged

    End Sub

    Private Sub TreatCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles TreatCb.SelectionChangeCommitted
        Con.Open()
        Dim query = "select * from TreatmentTbl where TreatDesc= '" & TreatCb.SelectedValue.ToString() & "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            CostTb.Text = reader(2)
        End While
        Con.Close()
    End Sub

    Dim cost As Integer
    Dim Treat As String


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        cost = 0

        If CostTb.Text = "Cost" Then
            cost = 500
            Treat = "None"
        Else
            cost += Convert.ToInt32(CostTb.Text)
            Treat = TreatCb.SelectedValue.ToString()
        End If

        Con.Open()
        Dim query As String
        query = "insert into DiagnosisTbl values(" & DiagId.Text & ", " & PatIdCb.SelectedValue.ToString() & ", '" & PatNameTb.Text & "', '" & SymptomsTb.Text & "', '" & MedicineTb.Text & "', '" & DiagTb.Text & "', '" & Treat & "', " & cost & " )"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Diagnosis Successfully Added")

        Con.Close()
        populate()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If DiagId.Text = " " Or SymptomsTb.Text = " " Or MedicineTb.Text = " " Or DiagTb.Text = " " Then
            MsgBox("Incomplete Information")
        Else
            If CostTb.Text = "Cost" Then
                cost = 500
                Treat = "None"
            Else
                cost += Convert.ToInt32(CostTb.Text)
                Treat = TreatCb.SelectedValue.ToString()
            End If
            Con.Open()
            Dim cmd As New SqlCommand("update DiagnosisTbl set PatId = '" & PatIdCb.SelectedValue.ToString() & "', PatName= '" & PatNameTb.Text & "', Symptoms = '" & SymptomsTb.Text & "', Medicines= '" & MedicineTb.Text & "', Diagnosis = '" & DiagTb.Text & "', Treatment = '" & TreatCb.SelectedValue.ToString() & "', Cost = " & cost & "
                                            where DiagId = " & DiagId.Text & " ", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Diagnosis Updated Successfully")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If DiagId.Text = "" Then
            MsgBox("Enter The Diagnosis Id")
        Else
            Con.Open()
            Dim query As String
            query = "delete from DiagnosisTbl where DiagId = " & DiagId.Text & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox(" Diagnosis Successfully Deleted")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim log = New LoginForm
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim startX As Integer = 50
        Dim startY As Integer = 50

        ' Loop through each row and column of the DataGridView
        For rowIndex As Integer = 0 To DiagnosisDGV.Rows.Count - 1
            Dim row As DataGridViewRow = DiagnosisDGV.Rows(rowIndex)
            For colIndex As Integer = 0 To DiagnosisDGV.Columns.Count - 1
                ' Get the value from the current cell
                Dim cellValue As String = row.Cells(colIndex).Value.ToString()

                ' Calculate the position to draw the text
                Dim drawX As Integer = startX + (colIndex * 100)
                Dim drawY As Integer = startY + (rowIndex * 20)

                ' Draw the text on the printing page
                e.Graphics.DrawString(cellValue, Me.DiagnosisDGV.Font, Brushes.Black, drawX, drawY)
            Next
        Next

        ' Indicate that no more pages are pending
        e.HasMorePages = False

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub CostTb_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles CostTb.MaskInputRejected

    End Sub
End Class