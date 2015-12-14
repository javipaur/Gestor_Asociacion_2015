<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acciones))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mostrarfoto = New System.Windows.Forms.PictureBox()
        Me.Tobservacion = New System.Windows.Forms.TextBox()
        Me.Bexaminar = New System.Windows.Forms.Button()
        Me.Tibam = New System.Windows.Forms.TextBox()
        Me.Tfoto = New System.Windows.Forms.TextBox()
        Me.Temail = New System.Windows.Forms.TextBox()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Tdni = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Beditar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Bnuevo = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.mostrarfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(198, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(386, 29)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Alta, Baja y Modificación de Socios"
        '
        'mostrarfoto
        '
        Me.mostrarfoto.Location = New System.Drawing.Point(296, 66)
        Me.mostrarfoto.Name = "mostrarfoto"
        Me.mostrarfoto.Size = New System.Drawing.Size(107, 96)
        Me.mostrarfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mostrarfoto.TabIndex = 67
        Me.mostrarfoto.TabStop = False
        '
        'Tobservacion
        '
        Me.Tobservacion.Location = New System.Drawing.Point(122, 201)
        Me.Tobservacion.Name = "Tobservacion"
        Me.Tobservacion.Size = New System.Drawing.Size(533, 20)
        Me.Tobservacion.TabIndex = 62
        '
        'Bexaminar
        '
        Me.Bexaminar.Location = New System.Drawing.Point(308, 166)
        Me.Bexaminar.Name = "Bexaminar"
        Me.Bexaminar.Size = New System.Drawing.Size(75, 23)
        Me.Bexaminar.TabIndex = 60
        Me.Bexaminar.Text = "Examinar"
        Me.Bexaminar.UseVisualStyleBackColor = True
        '
        'Tibam
        '
        Me.Tibam.Location = New System.Drawing.Point(122, 144)
        Me.Tibam.Name = "Tibam"
        Me.Tibam.Size = New System.Drawing.Size(152, 20)
        Me.Tibam.TabIndex = 57
        '
        'Tfoto
        '
        Me.Tfoto.Location = New System.Drawing.Point(122, 170)
        Me.Tfoto.Name = "Tfoto"
        Me.Tfoto.Size = New System.Drawing.Size(100, 20)
        Me.Tfoto.TabIndex = 59
        '
        'Temail
        '
        Me.Temail.Location = New System.Drawing.Point(122, 117)
        Me.Temail.Name = "Temail"
        Me.Temail.Size = New System.Drawing.Size(152, 20)
        Me.Temail.TabIndex = 55
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(122, 93)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(152, 20)
        Me.Tnombre.TabIndex = 53
        '
        'Tdni
        '
        Me.Tdni.Location = New System.Drawing.Point(122, 66)
        Me.Tdni.Name = "Tdni"
        Me.Tdni.Size = New System.Drawing.Size(66, 20)
        Me.Tdni.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Iban"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Foto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Observacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Dni"
        '
        'Beliminar
        '
        Me.Beliminar.Location = New System.Drawing.Point(442, 237)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(75, 23)
        Me.Beliminar.TabIndex = 66
        Me.Beliminar.Text = "Eliminar"
        Me.Beliminar.UseVisualStyleBackColor = True
        '
        'Beditar
        '
        Me.Beditar.Location = New System.Drawing.Point(361, 237)
        Me.Beditar.Name = "Beditar"
        Me.Beditar.Size = New System.Drawing.Size(75, 23)
        Me.Beditar.TabIndex = 65
        Me.Beditar.Text = "Modificar"
        Me.Beditar.UseVisualStyleBackColor = True
        '
        'Bagregar
        '
        Me.Bagregar.Location = New System.Drawing.Point(280, 237)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(75, 23)
        Me.Bagregar.TabIndex = 64
        Me.Bagregar.Text = "Insertar"
        Me.Bagregar.UseVisualStyleBackColor = True
        '
        'Bnuevo
        '
        Me.Bnuevo.Location = New System.Drawing.Point(199, 237)
        Me.Bnuevo.Name = "Bnuevo"
        Me.Bnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Bnuevo.TabIndex = 63
        Me.Bnuevo.Text = "Nuevo"
        Me.Bnuevo.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.Grilla.Location = New System.Drawing.Point(28, 290)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(744, 317)
        Me.Grilla.TabIndex = 68
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo_Dni"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Email"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Iban"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Foto"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Observaciones"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'Acciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 662)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mostrarfoto)
        Me.Controls.Add(Me.Tobservacion)
        Me.Controls.Add(Me.Bexaminar)
        Me.Controls.Add(Me.Tibam)
        Me.Controls.Add(Me.Tfoto)
        Me.Controls.Add(Me.Temail)
        Me.Controls.Add(Me.Tnombre)
        Me.Controls.Add(Me.Tdni)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Beliminar)
        Me.Controls.Add(Me.Beditar)
        Me.Controls.Add(Me.Bagregar)
        Me.Controls.Add(Me.Bnuevo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Acciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acciones"
        CType(Me.mostrarfoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mostrarfoto As System.Windows.Forms.PictureBox
    Friend WithEvents Tobservacion As System.Windows.Forms.TextBox
    Friend WithEvents Bexaminar As System.Windows.Forms.Button
    Friend WithEvents Tibam As System.Windows.Forms.TextBox
    Friend WithEvents Tfoto As System.Windows.Forms.TextBox
    Friend WithEvents Temail As System.Windows.Forms.TextBox
    Friend WithEvents Tnombre As System.Windows.Forms.TextBox
    Friend WithEvents Tdni As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Beliminar As System.Windows.Forms.Button
    Friend WithEvents Beditar As System.Windows.Forms.Button
    Friend WithEvents Bagregar As System.Windows.Forms.Button
    Friend WithEvents Bnuevo As System.Windows.Forms.Button
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
