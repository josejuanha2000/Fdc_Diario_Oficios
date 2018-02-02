Public Class MenuDiario
    Private Sub MenuDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        FRMOficios.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FRMConOficio.Show()
    End Sub
    Private Sub Btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Dim salir As String
        salir = MsgBox("Esta seguro que desea salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Salir ?")
        If salir = vbYes Then
            End
        End If
    End Sub
End Class