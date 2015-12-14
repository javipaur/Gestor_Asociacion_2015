<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificacionBajaPedidos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BeliminarLP = New System.Windows.Forms.Button()
        Me.BmodificarLP = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tpedido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timporte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Bmodificar = New System.Windows.Forms.Button()
        Me.Tcantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Codigo_Producto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Cdni = New System.Windows.Forms.ComboBox()
        Me.GrillaLP = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cproductos = New System.Windows.Forms.ComboBox()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaLP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BeliminarLP
        '
        Me.BeliminarLP.Location = New System.Drawing.Point(382, 400)
        Me.BeliminarLP.Name = "BeliminarLP"
        Me.BeliminarLP.Size = New System.Drawing.Size(75, 28)
        Me.BeliminarLP.TabIndex = 87
        Me.BeliminarLP.Text = "Eliminar"
        Me.BeliminarLP.UseVisualStyleBackColor = True
        '
        'BmodificarLP
        '
        Me.BmodificarLP.Location = New System.Drawing.Point(215, 400)
        Me.BmodificarLP.Name = "BmodificarLP"
        Me.BmodificarLP.Size = New System.Drawing.Size(75, 28)
        Me.BmodificarLP.TabIndex = 86
        Me.BmodificarLP.Text = "Modificar"
        Me.BmodificarLP.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(347, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Dni"
        '
        'Tpedido
        '
        Me.Tpedido.Location = New System.Drawing.Point(237, 50)
        Me.Tpedido.Name = "Tpedido"
        Me.Tpedido.ReadOnly = True
        Me.Tpedido.Size = New System.Drawing.Size(66, 20)
        Me.Tpedido.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(136, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Numero_Pedido"
        '
        'Timporte
        '
        Me.Timporte.Location = New System.Drawing.Point(409, 82)
        Me.Timporte.Name = "Timporte"
        Me.Timporte.ReadOnly = True
        Me.Timporte.Size = New System.Drawing.Size(66, 20)
        Me.Timporte.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(347, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Importe"
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column3})
        Me.Grilla.Location = New System.Drawing.Point(161, 159)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(458, 176)
        Me.Grilla.TabIndex = 76
        '
        'Column6
        '
        Me.Column6.HeaderText = "numero_Pedido"
        Me.Column6.Name = "Column6"
        '
        'Column1
        '
        Me.Column1.HeaderText = "codigo_Dni"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "fecha_Pedido"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Importe"
        Me.Column3.Name = "Column3"
        '
        'Beliminar
        '
        Me.Beliminar.Location = New System.Drawing.Point(395, 115)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(75, 23)
        Me.Beliminar.TabIndex = 75
        Me.Beliminar.Text = "Eliminar"
        Me.Beliminar.UseVisualStyleBackColor = True
        '
        'Bmodificar
        '
        Me.Bmodificar.Location = New System.Drawing.Point(228, 115)
        Me.Bmodificar.Name = "Bmodificar"
        Me.Bmodificar.Size = New System.Drawing.Size(75, 23)
        Me.Bmodificar.TabIndex = 74
        Me.Bmodificar.Text = "Modificar"
        Me.Bmodificar.UseVisualStyleBackColor = True
        '
        'Tcantidad
        '
        Me.Tcantidad.Location = New System.Drawing.Point(555, 364)
        Me.Tcantidad.Name = "Tcantidad"
        Me.Tcantidad.Size = New System.Drawing.Size(64, 20)
        Me.Tcantidad.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(500, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Cantidad"
        '
        'Codigo_Producto
        '
        Me.Codigo_Producto.AutoSize = True
        Me.Codigo_Producto.Location = New System.Drawing.Point(145, 364)
        Me.Codigo_Producto.Name = "Codigo_Producto"
        Me.Codigo_Producto.Size = New System.Drawing.Size(89, 13)
        Me.Codigo_Producto.TabIndex = 69
        Me.Codigo_Producto.Text = "Codigo_Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Fecha"
        '
        'Tfecha
        '
        Me.Tfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Tfecha.Location = New System.Drawing.Point(203, 79)
        Me.Tfecha.Name = "Tfecha"
        Me.Tfecha.Size = New System.Drawing.Size(100, 20)
        Me.Tfecha.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(199, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 29)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Modificación y Baja de Pedidos"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(215, 395)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 86
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Cdni
        '
        Me.Cdni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cdni.FormattingEnabled = True
        Me.Cdni.Location = New System.Drawing.Point(409, 47)
        Me.Cdni.Name = "Cdni"
        Me.Cdni.Size = New System.Drawing.Size(269, 21)
        Me.Cdni.TabIndex = 92
        '
        'GrillaLP
        '
        Me.GrillaLP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaLP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.GrillaLP.Location = New System.Drawing.Point(116, 454)
        Me.GrillaLP.Name = "GrillaLP"
        Me.GrillaLP.ReadOnly = True
        Me.GrillaLP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaLP.Size = New System.Drawing.Size(540, 196)
        Me.GrillaLP.TabIndex = 93
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Cproductos
        '
        Me.Cproductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cproductos.Enabled = False
        Me.Cproductos.FormattingEnabled = True
        Me.Cproductos.Location = New System.Drawing.Point(240, 362)
        Me.Cproductos.Name = "Cproductos"
        Me.Cproductos.Size = New System.Drawing.Size(222, 21)
        Me.Cproductos.TabIndex = 94
        '
        'ModificacionBajaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 662)
        Me.Controls.Add(Me.Cproductos)
        Me.Controls.Add(Me.GrillaLP)
        Me.Controls.Add(Me.Cdni)
        Me.Controls.Add(Me.BeliminarLP)
        Me.Controls.Add(Me.BmodificarLP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Tpedido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Timporte)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.Beliminar)
        Me.Controls.Add(Me.Bmodificar)
        Me.Controls.Add(Me.Tcantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Codigo_Producto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tfecha)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModificacionBajaPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificacionBajaPedidos"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaLP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BeliminarLP As System.Windows.Forms.Button
    Friend WithEvents BmodificarLP As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Tpedido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timporte As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Beliminar As System.Windows.Forms.Button
    Friend WithEvents Bmodificar As System.Windows.Forms.Button
    Friend WithEvents Tcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Codigo_Producto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Cdni As System.Windows.Forms.ComboBox
    Friend WithEvents GrillaLP As System.Windows.Forms.DataGridView
    Friend WithEvents Cproductos As System.Windows.Forms.ComboBox
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
