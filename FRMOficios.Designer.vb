<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMOficios
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNoOficio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaC = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBAsunto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBDirigido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBObservaciones = New System.Windows.Forms.TextBox()
        Me.CBUsuario = New System.Windows.Forms.ComboBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBRO_OFICIOSDataSet = New DIARIOSA.LIBRO_OFICIOSDataSet()
        Me.GroupBoxDatosOficio = New System.Windows.Forms.GroupBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.UsuarioTableAdapter = New DIARIOSA.LIBRO_OFICIOSDataSetTableAdapters.UsuarioTableAdapter()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBRO_OFICIOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDatosOficio.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No de Oficio:"
        '
        'TBNoOficio
        '
        Me.TBNoOficio.Enabled = False
        Me.TBNoOficio.Location = New System.Drawing.Point(37, 45)
        Me.TBNoOficio.MaxLength = 6
        Me.TBNoOficio.Multiline = True
        Me.TBNoOficio.Name = "TBNoOficio"
        Me.TBNoOficio.Size = New System.Drawing.Size(85, 20)
        Me.TBNoOficio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(293, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de Captura"
        '
        'DateTimePickerFechaC
        '
        Me.DateTimePickerFechaC.Enabled = False
        Me.DateTimePickerFechaC.Location = New System.Drawing.Point(289, 45)
        Me.DateTimePickerFechaC.Name = "DateTimePickerFechaC"
        Me.DateTimePickerFechaC.Size = New System.Drawing.Size(235, 20)
        Me.DateTimePickerFechaC.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Asunto:"
        '
        'TBAsunto
        '
        Me.TBAsunto.Location = New System.Drawing.Point(15, 42)
        Me.TBAsunto.Multiline = True
        Me.TBAsunto.Name = "TBAsunto"
        Me.TBAsunto.Size = New System.Drawing.Size(481, 47)
        Me.TBAsunto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dirigido:"
        '
        'TBDirigido
        '
        Me.TBDirigido.Location = New System.Drawing.Point(15, 120)
        Me.TBDirigido.Multiline = True
        Me.TBDirigido.Name = "TBDirigido"
        Me.TBDirigido.Size = New System.Drawing.Size(481, 30)
        Me.TBDirigido.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Observación:"
        '
        'TBObservaciones
        '
        Me.TBObservaciones.Location = New System.Drawing.Point(16, 175)
        Me.TBObservaciones.Multiline = True
        Me.TBObservaciones.Name = "TBObservaciones"
        Me.TBObservaciones.Size = New System.Drawing.Size(481, 93)
        Me.TBObservaciones.TabIndex = 9
        '
        'CBUsuario
        '
        Me.CBUsuario.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UsuarioBindingSource, "Nombre", True))
        Me.CBUsuario.DataSource = Me.UsuarioBindingSource
        Me.CBUsuario.DisplayMember = "Nombre"
        Me.CBUsuario.FormattingEnabled = True
        Me.CBUsuario.Location = New System.Drawing.Point(15, 288)
        Me.CBUsuario.Name = "CBUsuario"
        Me.CBUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CBUsuario.Size = New System.Drawing.Size(156, 21)
        Me.CBUsuario.TabIndex = 10
        Me.CBUsuario.ValueMember = "Nombre"
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.LIBRO_OFICIOSDataSet
        '
        'LIBRO_OFICIOSDataSet
        '
        Me.LIBRO_OFICIOSDataSet.DataSetName = "LIBRO_OFICIOSDataSet"
        Me.LIBRO_OFICIOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxDatosOficio
        '
        Me.GroupBoxDatosOficio.Controls.Add(Me.CBUsuario)
        Me.GroupBoxDatosOficio.Controls.Add(Me.TBObservaciones)
        Me.GroupBoxDatosOficio.Controls.Add(Me.Label5)
        Me.GroupBoxDatosOficio.Controls.Add(Me.TBDirigido)
        Me.GroupBoxDatosOficio.Controls.Add(Me.Label4)
        Me.GroupBoxDatosOficio.Controls.Add(Me.TBAsunto)
        Me.GroupBoxDatosOficio.Controls.Add(Me.Label3)
        Me.GroupBoxDatosOficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatosOficio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBoxDatosOficio.Location = New System.Drawing.Point(23, 90)
        Me.GroupBoxDatosOficio.Name = "GroupBoxDatosOficio"
        Me.GroupBoxDatosOficio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBoxDatosOficio.Size = New System.Drawing.Size(510, 338)
        Me.GroupBoxDatosOficio.TabIndex = 11
        Me.GroupBoxDatosOficio.TabStop = False
        Me.GroupBoxDatosOficio.Text = "Datos del Oficio:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=LIBRO_OFICIOS;Integrated Secu" & _
    "rity=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.DIARIOSA.My.Resources.Resources.GUARDAR2
        Me.BtnGuardar.Location = New System.Drawing.Point(539, 123)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(85, 37)
        Me.BtnGuardar.TabIndex = 13
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(539, 339)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(85, 35)
        Me.BtnRegresar.TabIndex = 15
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'FRMOficios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(633, 447)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBoxDatosOficio)
        Me.Controls.Add(Me.DateTimePickerFechaC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBNoOficio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRMOficios"
        Me.Text = "Diario Oficial"
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBRO_OFICIOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDatosOficio.ResumeLayout(False)
        Me.GroupBoxDatosOficio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBNoOficio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFechaC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBAsunto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBDirigido As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents CBUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxDatosOficio As System.Windows.Forms.GroupBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents LIBRO_OFICIOSDataSet As DIARIOSA.LIBRO_OFICIOSDataSet
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuarioTableAdapter As DIARIOSA.LIBRO_OFICIOSDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button

End Class
