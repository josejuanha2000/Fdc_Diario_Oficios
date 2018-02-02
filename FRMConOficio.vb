Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FRMConOficio
    'Dim sw As Integer = 0
    Private iposicion As Integer
    Private ds As DataSet
    Private da As SqlDataAdapter

    Private Sub FRMConOficio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.Open()
        Me.da = New SqlDataAdapter("SELECT * FROM Oficio", Me.SqlConnection1)
        Me.ds = New DataSet
        Me.da.Fill(ds, "Oficio")
        'DataGridView1.DataSource = DS.Tables("Tmaestro")
        Me.SqlConnection1.Close()
        Me.iposicion = 0
        Me.cargar_datos()

    End Sub
    Sub cargar_datos()
        'Try
        'sw = 1
        Dim drow As DataRow
        drow = Me.ds.Tables("Oficio").Rows(Me.iposicion)
        Me.TBNoOficio.Text = drow("no_oficio")
        Me.DateTimePickerFechaC.Text = drow("fecha_captura")
        Me.TBAsunto.Text = drow("Asunto")
        Me.TBDirigido.Text = drow("Dirigido")
        Me.TBObservaciones.Text = drow("Observacion")
        Me.CBUsuario.Text = drow("Usuario")
        Me.LblReg.Text = "Registro " & Me.iposicion + 1 & " de " & Me.ds.Tables("Oficio").Rows.Count
    End Sub
    Sub buscar_oficio()
        'CONSQL.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=EPROFESIONALES;Integrated Security=True"
        'CONSQL.Open()
        'sw = 2
        Try
            Me.SqlConnection1.Open()
            Dim drowbuscar As DataRow
            drowbuscar = Me.ds.Tables("oficio").Rows(Me.iposicion)
            Dim comsql As New SqlClient.SqlCommand
            comsql.Connection = Me.SqlConnection1
            'comsql.CommandText = ("select top 1 * from Oficio order by no_oficio desc")
            comsql.CommandText = ("select * from oficio where no_oficio=" & TBNoOficio.Text)
            Dim DRoficio As SqlClient.SqlDataReader
            DRoficio = comsql.ExecuteReader(CommandBehavior.CloseConnection)
            DRoficio.Read()
            Me.DateTimePickerFechaC.Text = DRoficio("Fecha_Captura")
            Me.TBAsunto.Text = DRoficio("Asunto")
            Me.TBDirigido.Text = DRoficio("Dirigido")
            Me.TBObservaciones.Text = DRoficio("Observacion")
            Me.CBUsuario.Text = DRoficio("Usuario")
            'Me.LblReg.Text = "Registro " & Me.iposicion & " de " & Me.ds.Tables("Oficio").Rows.Count
            'Me.LblReg.Text = "Registro" & TBNoOficio.Text & "de " & Me.ds.Tables("oficios").Rows.Count
            DRoficio.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub

    Private Sub BtnBuscarOficio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarOficio.Click
        Call buscar_oficio()
    End Sub
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        'Dim salir As String
        'salir = MsgBox("Esta seguro que desea salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Salir ?")
        'If salir = vbYes Then
        ' End
        ' Else
        ' TBNoOficio.Focus()
        ' End If
        Me.Close()
    End Sub
    Private Sub BtnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrimero.Click
        Me.iposicion = 0
        Me.cargar_datos()
    End Sub

    Private Sub BtnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSiguiente.Click
        If Me.iposicion = Me.ds.Tables("oficio").Rows.Count - 1 Then
            MessageBox.Show("Ultimo registro")
        Else
            Me.iposicion += 1
            Me.cargar_datos()
        End If
    End Sub

    Private Sub BtnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnterior.Click
        If Me.iposicion = 0 Then
            MessageBox.Show("Prime registro")
        Else
            Me.iposicion -= 1
            Me.cargar_datos()
        End If

    End Sub

    Private Sub BtnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUltimo.Click
        Me.iposicion = (Me.ds.Tables("oficio").Rows.Count - 1)
        Me.cargar_datos()
    End Sub
End Class