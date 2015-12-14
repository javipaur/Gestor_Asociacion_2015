Public Class AccionesProductos

    Private Sub AccionesProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ObjProducto As New Producto
        ObjProducto.Mostrar_Producto(Grilla)
        Beliminar.Enabled = False
        Bmodificar.Enabled = False
    End Sub

    Private Sub Bnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnuevo.Click
        Limpiar()
        'Deshabilita el boton Beditar y Beliminar
        Tcodigo.ReadOnly = False
        Tcodigo.Select() 'Posiciona el cursor
        Bnuevo.Enabled = True
        Binsertar.Enabled = True
        Bmodificar.Enabled = False
        Beliminar.Enabled = False
    End Sub

    Private Sub Limpiar()
        Tcodigo.Text = ""
        Tnombre.Text = ""
        Tdescripcion.Text = ""
        Tprecio.Text = ""
        Tstock.Text = ""
        TstockMinimo.Text = ""
    End Sub

    Private Sub Binsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Binsertar.Click
        If Tcodigo.Text <> "" And Tnombre.Text <> "" And Tdescripcion.Text <> "" And Tprecio.Text <> "" And Tstock.Text <> "" And TstockMinimo.Text <> "" Then
            Dim codigo As String = Tcodigo.Text
            Dim nombre As String = Tnombre.Text
            Dim descripcion As String = Tdescripcion.Text
            Dim precio As String = Tprecio.Text
            Dim stock As String = Tstock.Text
            Dim stock_Minimo As String = TstockMinimo.Text


            Dim ObjProducto As New Producto

            If CBool(ObjProducto.Agregar_Producto(codigo, nombre, descripcion, precio, stock, stock_Minimo)) Then
                MessageBox.Show("Producto agregado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                ObjProducto.Mostrar_Producto(Grilla)
            Else
                MessageBox.Show("Error al guardar, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Complete los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Bmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bmodificar.Click
        If Tcodigo.Text <> "" And Tnombre.Text <> "" And Tdescripcion.Text <> "" And Tprecio.Text <> "" And Tstock.Text <> "" And TstockMinimo.Text <> "" Then
            Dim codigo As String = Tcodigo.Text
            Dim nombre As String = Tnombre.Text
            Dim descripcion As String = Tdescripcion.Text
            Dim precio As String = Tprecio.Text
            Dim stock As String = Tstock.Text
            Dim stock_Minimo As String = TstockMinimo.Text
            Dim ObjProducto As New Producto

            If ObjProducto.Editar_producto(codigo, nombre, descripcion, precio, stock, stock_Minimo) Then
                MessageBox.Show("Producto Modificado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                ObjProducto.Mostrar_Producto(Grilla)
            Else
                MessageBox.Show("Error al editar, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Complete los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub celdapulsada(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellClick
        'Completa las cajas de texto para su consulta 
        Tcodigo.ReadOnly = True
        Tnombre.Select()
        Tcodigo.Text = CStr(Grilla.SelectedCells.Item(0).Value)
        Tnombre.Text = CStr(Grilla.SelectedCells.Item(1).Value)
        Tdescripcion.Text = CStr(Grilla.SelectedCells.Item(2).Value)
        Tprecio.Text = CStr(Grilla.SelectedCells.Item(3).Value)
        Tstock.Text = CStr(Grilla.SelectedCells.Item(4).Value)
        TstockMinimo.Text = CStr(Grilla.SelectedCells.Item(5).Value)
        'Deshabilita el boton Agregar
        Binsertar.Enabled = False
        Bmodificar.Enabled = True
        Beliminar.Enabled = True
    End Sub

    Private Sub Beliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Beliminar.Click
        If Tcodigo.Text <> "" And Tnombre.Text <> "" And Tdescripcion.Text <> "" And Tprecio.Text <> "" And Tstock.Text <> "" And TstockMinimo.Text <> "" Then
            Dim codigo As String = Tcodigo.Text
            Dim nombre As String = Tnombre.Text
            Dim descripcion As String = Tdescripcion.Text
            Dim precio As String = Tprecio.Text
            Dim stock As String = Tstock.Text
            Dim stock_Minimo As String = TstockMinimo.Text
            Dim ObjProducto As New Producto

            If ObjProducto.Eliminar_producto(codigo, nombre, descripcion, precio, stock, stock_Minimo) Then
                MessageBox.Show("Producto Eliminado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                ObjProducto.Mostrar_Producto(Grilla)
            Else
                MessageBox.Show("Error al editar, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Complete los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class