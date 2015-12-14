<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccionesProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaPedidosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionBajaPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPedidosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReciboToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReciboAcumuladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReposicionDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosEnAlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccionesToolStripMenuItem, Me.AccionesProductosToolStripMenuItem, Me.ProductosPedidosToolStripMenuItem, Me.InformesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccionesToolStripMenuItem
        '
        Me.AccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMSociosToolStripMenuItem, Me.BuscarSociosToolStripMenuItem})
        Me.AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        Me.AccionesToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AccionesToolStripMenuItem.Text = "Socios"
        '
        'ABMSociosToolStripMenuItem
        '
        Me.ABMSociosToolStripMenuItem.Name = "ABMSociosToolStripMenuItem"
        Me.ABMSociosToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ABMSociosToolStripMenuItem.Text = "Alta/Baja/Modificacion "
        '
        'BuscarSociosToolStripMenuItem
        '
        Me.BuscarSociosToolStripMenuItem.Name = "BuscarSociosToolStripMenuItem"
        Me.BuscarSociosToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.BuscarSociosToolStripMenuItem.Text = "Buscar "
        '
        'AccionesProductosToolStripMenuItem
        '
        Me.AccionesProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMProductosToolStripMenuItem, Me.BuscarProductosToolStripMenuItem1})
        Me.AccionesProductosToolStripMenuItem.Name = "AccionesProductosToolStripMenuItem"
        Me.AccionesProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.AccionesProductosToolStripMenuItem.Text = "Productos"
        '
        'ABMProductosToolStripMenuItem
        '
        Me.ABMProductosToolStripMenuItem.Name = "ABMProductosToolStripMenuItem"
        Me.ABMProductosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ABMProductosToolStripMenuItem.Text = "Alta/Baja/Modificación"
        '
        'BuscarProductosToolStripMenuItem1
        '
        Me.BuscarProductosToolStripMenuItem1.Name = "BuscarProductosToolStripMenuItem1"
        Me.BuscarProductosToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.BuscarProductosToolStripMenuItem1.Text = "Buscar "
        '
        'ProductosPedidosToolStripMenuItem
        '
        Me.ProductosPedidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaPedidosToolStripMenuItem1, Me.ModificacionBajaPedidosToolStripMenuItem, Me.BuscarPedidosToolStripMenuItem2})
        Me.ProductosPedidosToolStripMenuItem.Name = "ProductosPedidosToolStripMenuItem"
        Me.ProductosPedidosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ProductosPedidosToolStripMenuItem.Text = "Pedidos"
        '
        'AltaPedidosToolStripMenuItem1
        '
        Me.AltaPedidosToolStripMenuItem1.Name = "AltaPedidosToolStripMenuItem1"
        Me.AltaPedidosToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.AltaPedidosToolStripMenuItem1.Text = "Alta"
        '
        'ModificacionBajaPedidosToolStripMenuItem
        '
        Me.ModificacionBajaPedidosToolStripMenuItem.Name = "ModificacionBajaPedidosToolStripMenuItem"
        Me.ModificacionBajaPedidosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ModificacionBajaPedidosToolStripMenuItem.Text = "Modificacion/Baja"
        '
        'BuscarPedidosToolStripMenuItem2
        '
        Me.BuscarPedidosToolStripMenuItem2.Name = "BuscarPedidosToolStripMenuItem2"
        Me.BuscarPedidosToolStripMenuItem2.Size = New System.Drawing.Size(171, 22)
        Me.BuscarPedidosToolStripMenuItem2.Text = "Buscar"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReciboToolStripMenuItem, Me.ReciboAcumuladoToolStripMenuItem, Me.ReposicionDeProductosToolStripMenuItem, Me.ProductosEnAlmacenToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'ReciboToolStripMenuItem
        '
        Me.ReciboToolStripMenuItem.Name = "ReciboToolStripMenuItem"
        Me.ReciboToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ReciboToolStripMenuItem.Text = "Ticket Indivudual"
        '
        'ReciboAcumuladoToolStripMenuItem
        '
        Me.ReciboAcumuladoToolStripMenuItem.Name = "ReciboAcumuladoToolStripMenuItem"
        Me.ReciboAcumuladoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ReciboAcumuladoToolStripMenuItem.Text = "Ticket Acumulado"
        '
        'ReposicionDeProductosToolStripMenuItem
        '
        Me.ReposicionDeProductosToolStripMenuItem.Name = "ReposicionDeProductosToolStripMenuItem"
        Me.ReposicionDeProductosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ReposicionDeProductosToolStripMenuItem.Text = "Ticket de Cobros a Socios"
        '
        'ProductosEnAlmacenToolStripMenuItem
        '
        Me.ProductosEnAlmacenToolStripMenuItem.Name = "ProductosEnAlmacenToolStripMenuItem"
        Me.ProductosEnAlmacenToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ProductosEnAlmacenToolStripMenuItem.Text = "Productos en Almacen"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 271)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gasteizko Margolariak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(366, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 33)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sociedad Gastronomica"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 359)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sociedad Gastronomica"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMSociosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarSociosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AccionesProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarProductosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaPedidosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPedidosToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionBajaPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReciboToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReciboAcumuladoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReposicionDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosEnAlmacenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
