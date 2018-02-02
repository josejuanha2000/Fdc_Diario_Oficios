Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FRMOficios
    'Dim sw As Integer = 0
    Private Sub FRMOficios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call buscar_ultimo_oficio()
        'TODO: esta línea de código carga datos en la tabla 'LIBRO_OFICIOSDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.LIBRO_OFICIOSDataSet.Usuario)
        'TODO: esta línea de código carga datos en la tabla 'LIBRO_OFICIOSDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.LIBRO_OFICIOSDataSet.Usuario)
        Call bloquear_Botones()
    End Sub
    Sub buscar_ultimo_oficio()
        Try
            Me.SqlConnection1.Open()
            Dim comsql As New SqlClient.SqlCommand
            comsql.Connection = Me.SqlConnection1
            comsql.CommandText = ("select top 1 * from Oficio order by no_oficio desc")
            Dim DRoficio As SqlClient.SqlDataReader
            DRoficio = comsql.ExecuteReader(CommandBehavior.CloseConnection)
            DRoficio.Read()
            TBNoOficio.Text = DRoficio("No_oficio") + 1
            DRoficio.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub guardar()
        Try
            Dim guardar As String
            Me.SqlConnection1.Open()
            guardar = MsgBox("Esta seguro de guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If guardar = vbYes Then
                Dim Altaoficio As String = "INSERT INTO Oficio (No_oficio,Fecha_Captura,Asunto,Dirigido,Observacion,Usuario) values(@No_oficio,@Fecha_Captura,@Asunto,@Dirigido,@Observacion,@Usuario)"
                Dim conex1 As New SqlClient.SqlCommand(Altaoficio, Me.SqlConnection1)
                conex1.Parameters.Add(New SqlParameter("@No_oficio", SqlDbType.Int, 6)).Value = Me.TBNoOficio.Text
                conex1.Parameters.Add(New SqlParameter("@Fecha_Captura", SqlDbType.SmallDateTime)).Value = Me.DateTimePickerFechaC.Text
                conex1.Parameters.Add(New SqlParameter("@Asunto", SqlDbType.NVarChar, 50)).Value = Me.TBAsunto.Text
                conex1.Parameters.Add(New SqlParameter("@Dirigido", SqlDbType.NVarChar, 50)).Value = Me.TBDirigido.Text
                conex1.Parameters.Add(New SqlParameter("@Observacion", SqlDbType.NVarChar, -1)).Value = Me.TBObservaciones.Text
                conex1.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.NVarChar, 50)).Value = Me.CBUsuario.Text
                conex1.CommandText = Altaoficio
                conex1.ExecuteNonQuery()
                MsgBox("Datos guardados correctamente", , "Guardar")
                'BtnNuevo.Enabled = True
                Call limpiar()
                Me.SqlConnection1.Close()
                Call buscar_ultimo_oficio()
                TBAsunto.Focus()
                Call bloquear_Botones()
            Else
                Me.SqlConnection1.Close()
            End If
        Catch es As Exception
            MsgBox(es.ToString)
            Me.SqlConnection1.Close()
        End Try
    End Sub
    Sub buscar_oficio()
        Try
            Me.SqlConnection1.Open()
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
    Private Sub TBNoOficio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNoOficio.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If Char.IsSeparator(e.KeyChar) Then
                    e.Handled = True
                Else
                    If Char.IsLower(e.KeyChar) Then
                        e.Handled = False
                    End If
                End If
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            TBAsunto.Focus()
        End If
    End Sub
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Call guardar()
    End Sub
    Sub bloquear_Botones()
        'BtnNuevo.Enabled = False
        BtnGuardar.Enabled = False
    End Sub
    Sub limpiar()
        TBAsunto.Clear()
        TBDirigido.Clear()
        TBObservaciones.Clear()
    End Sub
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        'Dim salir As String
        'salir = MsgBox("Esta seguro que desea salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Salir ?")
        'If salir = vbYes Then
        ' End
        ' Else
        ' TBAsunto.Focus()
        ' End If
        Me.Close()

    End Sub
    Private Sub TBAsunto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBAsunto.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            BtnGuardar.Enabled = True
        End If
    End Sub

   
End Class

