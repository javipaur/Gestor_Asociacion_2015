<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarProductos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tcodigo = New System.Windows.Forms.TextBox()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Tdescripcion = New System.Windows.Forms.TextBox()
        Me.Tprecio = New System.Windows.Forms.TextBox()
        Me.Tstock = New System.Windows.Forms.TextBox()
        Me.Tstock_minimo = New System.Windows.Forms.TextBox()
        Me.Bbuscar = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(285, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(285, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Stock_Minimo"
        '
        'Tcodigo
        '
        Me.Tcodigo.Location = New System.Drawing.Point(362, 51)
        Me.Tcodigo.Name = "Tcodigo"
        Me.Tcodigo.Size = New System.Drawing.Size(100, 20)
        Me.Tcodigo.TabIndex = 6
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(362, 77)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(100, 20)
        Me.Tnombre.TabIndex = 7
        '
        'Tdescripcion
        '
        Me.Tdescripcion.Location = New System.Drawing.Point(362, 107)
        Me.Tdescripcion.Name = "Tdescripcion"
        Me.Tdescripcion.Size = New System.Drawing.Size(100, 20)
        Me.Tdescripcion.TabIndex = 8
        '
        'Tprecio
        '
        Me.Tprecio.Location = New System.Drawing.Point(362, 133)
        Me.Tprecio.Name = "Tprecio"
        Me.Tprecio.Size = New System.Drawing.Size(100, 20)
        Me.Tprecio.TabIndex = 9
        '
        'Tstock
        '
        Me.Tstock.Location = New System.Drawing.Point(362, 160)
        Me.Tstock.Name = "Tstock"
        Me.Tstock.Size = New System.Drawing.Size(100, 20)
        Me.Tstock.TabIndex = 10
        '
        'Tstock_minimo
        '
        Me.Tstock_minimo.Location = New System.Drawing.Point(362, 187)
        Me.Tstock_minimo.Name = "Tstock_minimo"
        Me.Tstock_minimo.Size = New System.Drawing.Size(100, 20)
        Me.Tstock_minimo.TabIndex = 11
        '
        'Bbuscar
        '
        Me.Bbuscar.Location = New System.Drawing.Point(288, 224)
        Me.Bbuscar.Name = "Bbuscar"
        Me.Bbuscar.Size = New System.Drawing.Size(178, 23)
        Me.Bbuscar.TabIndex = 12
        Me.Bbuscar.Text = "Buscar"
        Me.Bbuscar.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.grilla.Location = New System.Drawing.Point(61, 262)
        Me.grilla.Name = "grilla"
        Me.grilla.Size = New System.Drawing.Size(687, 388)
        Me.grilla.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(260, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 33)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Buscar Productos"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo Producto"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descripcion"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 180
        '
        'Column4
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column4.HeaderText = "Precio"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column5
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column5.HeaderText = "Stock"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 80
        '
        'Column6
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column6.HeaderText = "Stock Minimo"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 80
        '
        'BuscarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 662)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.Bbuscar)
        Me.Controls.Add(Me.Tstock_minimo)
        Me.Controls.Add(Me.Tstock)
        Me.Controls.Add(Me.Tprecio)
        Me.Controls.Add(Me.Tdescripcion)
        Me.Controls.Add(Me.Tnombre)
        Me.Controls.Add(Me.Tcodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BuscarProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarProductos"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Tnombre As System.Windows.Forms.TextBox
    Friend WithEvents Tdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Tprecio As System.Windows.Forms.TextBox
    Friend WithEvents Tstock As System.Windows.Forms.TextBox
    Friend WithEvents Tstock_minimo As System.Windows.Forms.TextBox
    Friend WithEvents Bbuscar As System.Windows.Forms.Button
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
