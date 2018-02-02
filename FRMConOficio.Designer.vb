<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMConOficio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.GroupBoxDatosOficio = New System.Windows.Forms.GroupBox()
        Me.LblReg = New System.Windows.Forms.Label()
        Me.CBUsuario = New System.Windows.Forms.ComboBox()
        Me.TBObservaciones = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBDirigido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBAsunto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaC = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNoOficio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnBuscarOficio = New System.Windows.Forms.Button()
        Me.GroupBoxDatosOficio.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(486, 369)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(75, 27)
        Me.BtnRegresar.TabIndex = 22
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'GroupBoxDatosOficio
        '
        Me.GroupBoxDatosOficio.Controls.Add(Me.LblReg)
        Me.GroupBoxDatosOficio.Controls.Add(Me.CBUsuario)
        Me.GroupBoxDatosOficio.Controls.Add(Me.TBObservaciones)
        Me.GroupBoxDatosOficio.Controls.Add(Me.Label5)
        Me.GroupBoxDatosOficio.Controls.Add(Me.TBDirigido)
        Me.GroupBoxDatosOficio.Controls.Add(Me.Label4)
        Me.GroupBoxDatosOficio.Controls.Add(Me.TBAsunto)
        Me.GroupBoxDatosOficio.Controls.Add(Me.Label3)
        Me.GroupBoxDatosOficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatosOficio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBoxDatosOficio.Location = New System.Drawing.Point(16, 62)
        Me.GroupBoxDatosOficio.Name = "GroupBoxDatosOficio"
        Me.GroupBoxDatosOficio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBoxDatosOficio.Size = New System.Drawing.Size(514, 292)
        Me.GroupBoxDatosOficio.TabIndex = 20
        Me.GroupBoxDatosOficio.TabStop = False
        Me.GroupBoxDatosOficio.Text = "Datos del Oficio:"
        '
        'LblReg
        '
        Me.LblReg.AutoSize = True
        Me.LblReg.Location = New System.Drawing.Point(37, 261)
        Me.LblReg.Name = "LblReg"
        Me.LblReg.Size = New System.Drawing.Size(66, 13)
        Me.LblReg.TabIndex = 28
        Me.LblReg.Text = "Lblregistro"
        '
        'CBUsuario
        '
        Me.CBUsuario.DisplayMember = "Nombre"
        Me.CBUsuario.FormattingEnabled = True
        Me.CBUsuario.Location = New System.Drawing.Point(340, 253)
        Me.CBUsuario.Name = "CBUsuario"
        Me.CBUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CBUsuario.Size = New System.Drawing.Size(156, 21)
        Me.CBUsuario.TabIndex = 10
        Me.CBUsuario.ValueMember = "Nombre"
        '
        'TBObservaciones
        '
        Me.TBObservaciones.Enabled = False
        Me.TBObservaciones.Location = New System.Drawing.Point(16, 144)
        Me.TBObservaciones.Multiline = True
        Me.TBObservaciones.Name = "TBObservaciones"
        Me.TBObservaciones.Size = New System.Drawing.Size(481, 93)
        Me.TBObservaciones.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Observación:"
        '
        'TBDirigido
        '
        Me.TBDirigido.Enabled = False
        Me.TBDirigido.Location = New System.Drawing.Point(15, 93)
        Me.TBDirigido.Multiline = True
        Me.TBDirigido.Name = "TBDirigido"
        Me.TBDirigido.Size = New System.Drawing.Size(481, 30)
        Me.TBDirigido.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dirigido:"
        '
        'TBAsunto
        '
        Me.TBAsunto.Enabled = False
        Me.TBAsunto.Location = New System.Drawing.Point(15, 26)
        Me.TBAsunto.Multiline = True
        Me.TBAsunto.Name = "TBAsunto"
        Me.TBAsunto.Size = New System.Drawing.Size(481, 47)
        Me.TBAsunto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Asunto:"
        '
        'DateTimePickerFechaC
        '
        Me.DateTimePickerFechaC.Enabled = False
        Me.DateTimePickerFechaC.Location = New System.Drawing.Point(270, 25)
        Me.DateTimePickerFechaC.Name = "DateTimePickerFechaC"
        Me.DateTimePickerFechaC.Size = New System.Drawing.Size(235, 20)
        Me.DateTimePickerFechaC.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha de Captura"
        '
        'TBNoOficio
        '
        Me.TBNoOficio.Location = New System.Drawing.Point(23, 25)
        Me.TBNoOficio.MaxLength = 6
        Me.TBNoOficio.Multiline = True
        Me.TBNoOficio.Name = "TBNoOficio"
        Me.TBNoOficio.Size = New System.Drawing.Size(85, 20)
        Me.TBNoOficio.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "No de Oficio:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=LIBRO_OFICIOS;Integrated Secu" & _
    "rity=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'BtnPrimero
        '
        Me.BtnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrimero.Location = New System.Drawing.Point(97, 370)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(83, 24)
        Me.BtnPrimero.TabIndex = 24
        Me.BtnPrimero.Text = "Primero"
        Me.BtnPrimero.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.Location = New System.Drawing.Point(186, 370)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(83, 24)
        Me.BtnSiguiente.TabIndex = 25
        Me.BtnSiguiente.Text = "Siguiente"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.Location = New System.Drawing.Point(275, 370)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(83, 24)
        Me.BtnAnterior.TabIndex = 26
        Me.BtnAnterior.Text = "Anterior"
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnUltimo
        '
        Me.BtnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUltimo.Location = New System.Drawing.Point(364, 370)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(83, 24)
        Me.BtnUltimo.TabIndex = 27
        Me.BtnUltimo.Text = "Ultimo"
        Me.BtnUltimo.UseVisualStyleBackColor = True
        '
        'BtnBuscarOficio
        '
        Me.BtnBuscarOficio.Image = Global.DIARIOSA.My.Resources.Resources.BUSCAR
        Me.BtnBuscarOficio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarOficio.Location = New System.Drawing.Point(114, 23)
        Me.BtnBuscarOficio.Name = "BtnBuscarOficio"
        Me.BtnBuscarOficio.Size = New System.Drawing.Size(78, 26)
        Me.BtnBuscarOficio.TabIndex = 23
        Me.BtnBuscarOficio.Text = "Buscar"
        Me.BtnBuscarOficio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarOficio.UseVisualStyleBackColor = True
        '
        'FRMConOficio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(589, 418)
        Me.Controls.Add(Me.BtnUltimo)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnAnterior)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnPrimero)
        Me.Controls.Add(Me.BtnBuscarOficio)
        Me.Controls.Add(Me.GroupBoxDatosOficio)
        Me.Controls.Add(Me.DateTimePickerFechaC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBNoOficio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRMConOficio"
        Me.Text = "FRMConOficio"
        Me.GroupBoxDatosOficio.ResumeLayout(False)
        Me.GroupBoxDatosOficio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents GroupBoxDatosOficio As System.Windows.Forms.GroupBox
    Friend WithEvents CBUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents TBObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBDirigido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBAsunto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFechaC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNoOficio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents BtnBuscarOficio As System.Windows.Forms.Button
    Friend WithEvents BtnPrimero As System.Windows.Forms.Button
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnAnterior As System.Windows.Forms.Button
    Friend WithEvents BtnUltimo As System.Windows.Forms.Button
    Friend WithEvents LblReg As System.Windows.Forms.Label
End Class
