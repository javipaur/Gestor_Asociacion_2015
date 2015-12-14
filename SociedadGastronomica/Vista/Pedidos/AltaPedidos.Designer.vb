<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaPedidos))
        Me.Añadir = New System.Windows.Forms.Button()
        Me.Tcantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cproductos = New System.Windows.Forms.ComboBox()
        Me.Cdni = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TnumeroPedido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Confirmar = New System.Windows.Forms.Button()
        Me.Timporte = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Añadir
        '
        Me.Añadir.Location = New System.Drawing.Point(579, 276)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(75, 23)
        Me.Añadir.TabIndex = 15
        Me.Añadir.Text = "Añadir"
        Me.Añadir.UseVisualStyleBackColor = True
        '
        'Tcantidad
        '
        Me.Tcantidad.Location = New System.Drawing.Point(497, 276)
        Me.Tcantidad.Name = "Tcantidad"
        Me.Tcantidad.Size = New System.Drawing.Size(64, 20)
        Me.Tcantidad.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(442, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Productos"
        '
        'Cproductos
        '
        Me.Cproductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cproductos.FormattingEnabled = True
        Me.Cproductos.Location = New System.Drawing.Point(197, 276)
        Me.Cproductos.Name = "Cproductos"
        Me.Cproductos.Size = New System.Drawing.Size(222, 21)
        Me.Cproductos.TabIndex = 12
        '
        'Cdni
        '
        Me.Cdni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cdni.FormattingEnabled = True
        Me.Cdni.Location = New System.Drawing.Point(376, 105)
        Me.Cdni.Name = "Cdni"
        Me.Cdni.Size = New System.Drawing.Size(269, 21)
        Me.Cdni.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha"
        '
        'Tfecha
        '
        Me.Tfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Tfecha.Location = New System.Drawing.Point(206, 140)
        Me.Tfecha.Name = "Tfecha"
        Me.Tfecha.Size = New System.Drawing.Size(100, 20)
        Me.Tfecha.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Socio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(333, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 33)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Alta Pedido"
        '
        'TnumeroPedido
        '
        Me.TnumeroPedido.Location = New System.Drawing.Point(240, 105)
        Me.TnumeroPedido.Name = "TnumeroPedido"
        Me.TnumeroPedido.Size = New System.Drawing.Size(66, 20)
        Me.TnumeroPedido.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(151, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Numero_Pedido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(319, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 33)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lineas Pedido"
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column1})
        Me.Grilla.Location = New System.Drawing.Point(137, 316)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(544, 317)
        Me.Grilla.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Column1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "Importe"
        Me.Column1.Name = "Column1"
        '
        'Confirmar
        '
        Me.Confirmar.Location = New System.Drawing.Point(511, 142)
        Me.Confirmar.Name = "Confirmar"
        Me.Confirmar.Size = New System.Drawing.Size(112, 23)
        Me.Confirmar.TabIndex = 9
        Me.Confirmar.Text = "Confirmar Pedido"
        Me.Confirmar.UseVisualStyleBackColor = True
        '
        'Timporte
        '
        Me.Timporte.Location = New System.Drawing.Point(391, 142)
        Me.Timporte.Name = "Timporte"
        Me.Timporte.Size = New System.Drawing.Size(64, 20)
        Me.Timporte.TabIndex = 8
        Me.Timporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(336, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Importe"
        '
        'AltaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 662)
        Me.Controls.Add(Me.Timporte)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Confirmar)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TnumeroPedido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Añadir)
        Me.Controls.Add(Me.Tcantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cproductos)
        Me.Controls.Add(Me.Cdni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tfecha)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccionesProductos_Pedidos"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Añadir As System.Windows.Forms.Button
    Friend WithEvents Tcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cproductos As System.Windows.Forms.ComboBox
    Friend WithEvents Cdni As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TnumeroPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Confirmar As System.Windows.Forms.Button
    Friend WithEvents Timporte As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
