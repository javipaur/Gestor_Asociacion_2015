<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccionesProductos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Tdescripcion = New System.Windows.Forms.TextBox()
        Me.Tprecio = New System.Windows.Forms.TextBox()
        Me.Tstock = New System.Windows.Forms.TextBox()
        Me.TstockMinimo = New System.Windows.Forms.TextBox()
        Me.Bnuevo = New System.Windows.Forms.Button()
        Me.Binsertar = New System.Windows.Forms.Button()
        Me.Bmodificar = New System.Windows.Forms.Button()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tcodigo = New System.Windows.Forms.TextBox()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Alta, Baja y Modificicacion de Productos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(103, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(103, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Stock_Minimo"
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(218, 84)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(278, 20)
        Me.Tnombre.TabIndex = 4
        '
        'Tdescripcion
        '
        Me.Tdescripcion.Location = New System.Drawing.Point(218, 110)
        Me.Tdescripcion.Name = "Tdescripcion"
        Me.Tdescripcion.Size = New System.Drawing.Size(278, 20)
        Me.Tdescripcion.TabIndex = 6
        '
        'Tprecio
        '
        Me.Tprecio.Location = New System.Drawing.Point(218, 136)
        Me.Tprecio.Name = "Tprecio"
        Me.Tprecio.Size = New System.Drawing.Size(100, 20)
        Me.Tprecio.TabIndex = 8
        '
        'Tstock
        '
        Me.Tstock.Location = New System.Drawing.Point(218, 162)
        Me.Tstock.Name = "Tstock"
        Me.Tstock.Size = New System.Drawing.Size(100, 20)
        Me.Tstock.TabIndex = 10
        '
        'TstockMinimo
        '
        Me.TstockMinimo.Location = New System.Drawing.Point(218, 188)
        Me.TstockMinimo.Name = "TstockMinimo"
        Me.TstockMinimo.Size = New System.Drawing.Size(100, 20)
        Me.TstockMinimo.TabIndex = 12
        '
        'Bnuevo
        '
        Me.Bnuevo.Location = New System.Drawing.Point(340, 227)
        Me.Bnuevo.Name = "Bnuevo"
        Me.Bnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Bnuevo.TabIndex = 13
        Me.Bnuevo.Text = "Nuevo"
        Me.Bnuevo.UseVisualStyleBackColor = True
        '
        'Binsertar
        '
        Me.Binsertar.Location = New System.Drawing.Point(421, 227)
        Me.Binsertar.Name = "Binsertar"
        Me.Binsertar.Size = New System.Drawing.Size(75, 23)
        Me.Binsertar.TabIndex = 14
        Me.Binsertar.Text = "Insertar"
        Me.Binsertar.UseVisualStyleBackColor = True
        '
        'Bmodificar
        '
        Me.Bmodificar.Location = New System.Drawing.Point(502, 227)
        Me.Bmodificar.Name = "Bmodificar"
        Me.Bmodificar.Size = New System.Drawing.Size(75, 23)
        Me.Bmodificar.TabIndex = 15
        Me.Bmodificar.Text = "Modificar"
        Me.Bmodificar.UseVisualStyleBackColor = True
        '
        'Beliminar
        '
        Me.Beliminar.Location = New System.Drawing.Point(583, 227)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(75, 23)
        Me.Beliminar.TabIndex = 16
        Me.Beliminar.Text = "Eliminar"
        Me.Beliminar.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.Grilla.Location = New System.Drawing.Point(61, 269)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(681, 344)
        Me.Grilla.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Codigo"
        '
        'Tcodigo
        '
        Me.Tcodigo.Location = New System.Drawing.Point(218, 58)
        Me.Tcodigo.Name = "Tcodigo"
        Me.Tcodigo.Size = New System.Drawing.Size(100, 20)
        Me.Tcodigo.TabIndex = 2
        '
        'Column6
        '
        Me.Column6.HeaderText = "Codigo Producto"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripcion"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 180
        '
        'Column3
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column4
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Stock"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column5
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Stock Minimo"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 90
        '
        'AccionesProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 662)
        Me.Controls.Add(Me.Tcodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.Beliminar)
        Me.Controls.Add(Me.Bmodificar)
        Me.Controls.Add(Me.Binsertar)
        Me.Controls.Add(Me.Bnuevo)
        Me.Controls.Add(Me.TstockMinimo)
        Me.Controls.Add(Me.Tstock)
        Me.Controls.Add(Me.Tprecio)
        Me.Controls.Add(Me.Tdescripcion)
        Me.Controls.Add(Me.Tnombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AccionesProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccionesProductos"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Tnombre As System.Windows.Forms.TextBox
    Friend WithEvents Tdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Tprecio As System.Windows.Forms.TextBox
    Friend WithEvents Tstock As System.Windows.Forms.TextBox
    Friend WithEvents TstockMinimo As System.Windows.Forms.TextBox
    Friend WithEvents Bnuevo As System.Windows.Forms.Button
    Friend WithEvents Binsertar As System.Windows.Forms.Button
    Friend WithEvents Bmodificar As System.Windows.Forms.Button
    Friend WithEvents Beliminar As System.Windows.Forms.Button
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
