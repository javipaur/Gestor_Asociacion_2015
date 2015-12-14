Option Strict Off
Public Class ModificacionBajaPedidos
    Dim directorio As String = My.Application.Info.DirectoryPath
    Private Sub ModificacionBajaPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ObjPedidos As New Pedido
        ObjPedidos.MostrarPedidos(Grilla)
        Limpiar()
    End Sub
    Private Sub Limpiar()
        Beliminar.Enabled = False
        Bmodificar.Enabled = False
        BeliminarLP.Enabled = False
        BmodificarLP.Enabled = False
        Cdni.Text = ""
        Tpedido.Text = ""
        Timporte.Text = ""
        Tfecha.Text = ""
        Cproductos.Text = ""
        Tcantidad.Text = 0
        Dim ObjPedidos As New Pedido
        ObjPedidos.MostrarPedidos(Grilla)
        GrillaLP.Rows.Clear()
    End Sub
    Private Sub Bmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bmodificar.Click
        If Tpedido.Text <> "" And Cdni.Text <> "" Then
            Dim pedido As Integer = CInt(Tpedido.Text)
            Dim posicionGuion As Integer = Cdni.Text.IndexOf("-")
            Dim dni As String = Cdni.Text.Substring(0, posicionGuion)
            Dim fecha As String = Tfecha.Text
            Dim importe As String = Timporte.Text
            Dim ObjPedidos As New Pedido
            If ObjPedidos.Modificar_Pedido(pedido, dni, fecha, importe) Then
                MessageBox.Show("Pedido Modificado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                ObjPedidos.MostrarPedidos(Grilla)
            Else
                MessageBox.Show("Error al modificar Pedido, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Selecciona el pedido y un Dni ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub Beliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Beliminar.Click
        If Tpedido.Text <> "" And Cdni.Text <> "" Then
            Dim pedido As String = CInt(Tpedido.Text)
            Dim ObjPedido As New Pedido
            If ObjPedido.Eliminar_pedido(pedido) Then
                MessageBox.Show("Pedido Eliminado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ActualizarStockLineasPedido()
                EliminarTodasLineasPedido(pedido)
                Limpiar()
                ObjPedido.MostrarPedidos(Grilla)
            Else
                MessageBox.Show("Error al eliminar Pedido, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Selecciona el pedido y un dni ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub pedidosGrilla(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellClick
        'Completa las cajas de texto para su MOdificacion o borrado 
        Dim ObjPedidos As New Pedido
        ObjPedidos.MostrarUsuarios(Cdni)
        Tpedido.Text = CStr(Grilla.SelectedCells.Item(0).Value)
        Tpedido.ReadOnly = True
        'Posicionar el DNI en el combo
        For i As Integer = 0 To Cdni.Items.Count - 1
            If Cdni.Items.Item(i).IndexOF(CStr(Grilla.SelectedCells.Item(1).Value)) <> -1 Then
                Cdni.SelectedIndex = i
            End If
        Next
        Tfecha.Text = CStr(Grilla.SelectedCells.Item(2).Value)
        Timporte.Text = CStr(Grilla.SelectedCells.Item(3).Value)

        Bmodificar.Enabled = True
        Beliminar.Enabled = True
        Dim ObjProductosPedidos As New Productos_Pedidos
        ObjProductosPedidos.Mostrar_Productos_Pedidos(GrillaLP, CInt(Tpedido.Text), Timporte)
    End Sub
    Private Sub pedidosGrillaLP(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaLP.CellClick
        'Completa las cajas de texto para su Modificacion o borrado 
        Dim ObjPedidos As New Pedido
        ObjPedidos.MostrarProductos(Cproductos)
        'Posicionar el Producto en el combo
        For i As Integer = 0 To Cproductos.Items.Count - 1
            If Cproductos.Items.Item(i).IndexOF(CStr(GrillaLP.SelectedCells.Item(0).Value)) <> -1 Then
                Cproductos.SelectedIndex = i
            End If
        Next
        Tcantidad.Text = CStr(GrillaLP.SelectedCells.Item(2).Value)
        
        BmodificarLP.Enabled = True
        BeliminarLP.Enabled = True
    End Sub
    Private Sub BmodificarLP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BmodificarLP.Click
        If Tpedido.Text <> "" And Cproductos.Text <> "" Then
            Dim pedido As Integer = CInt(Tpedido.Text)
            Dim producto As String = Cproductos.Text.Substring(0, 4)
            Dim descripcion As String = Cproductos.Text.Substring(6)
            Dim cantidad As Integer = CInt(Tcantidad.Text)

            Dim ObjProductosPedidos As New Productos_Pedidos
            If ObjProductosPedidos.Modificar_productos_pedidos(pedido, producto, cantidad) Then
                MessageBox.Show("Linea Pedido Modificada con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RecalcularImportePedido(pedido)
                RecalcularStockProductoM(descripcion)
                Limpiar()
            Else
                MessageBox.Show("Error al modificar Linea Pedido, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Selecciona el pedido y un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub BeliminarLP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeliminarLP.Click
        If Tpedido.Text <> "" And Cproductos.Text <> "" Then
            Dim pedido As String = CInt(Tpedido.Text)
            Dim producto As String = Cproductos.Text.Substring(0, 4)
            Dim ObjProductosPedidos As New Productos_Pedidos
            If ObjProductosPedidos.Eliminar_productos_pedidos(pedido, producto) Then
                RecalcularStockProductoE()
                MessageBox.Show("Linea Pedido Eliminada con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            Else
                MessageBox.Show("Error al eliminar Linea Pedido, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Selecciona el pedido y un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub ActualizarStockLineasPedido()
        For Filas As Integer = 0 To GrillaLP.RowCount - 2
            'For Columnas As Integer = 0 To GrillaLP.ColumnCount - 1
            'MsgBox(GrillaLP.Item(Columnas, Filas).Value)
            'Recalcular Stock  
            Dim descripcion As String = GrillaLP.Item(0, Filas).Value
            Dim CantidadSumar As Integer = 0
            CantidadSumar = CDbl(GrillaLP.Item(2, Filas).Value)
            CantidadSumar = CantidadSumar * -1
            Dim ObjProductos As New Producto
            If ObjProductos.Modificar_Productos_Stock(descripcion, CantidadSumar) Then
                'MessageBox.Show("Stock Producto Modificado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar Stock Producto, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'Next
        Next
    End Sub
    Private Sub EliminarTodasLineasPedido(ByVal pedido As String)
        'Eliminar todas las lineas de pedido
        If (GrillaLP.RowCount > 1) Then
            Dim ObjProductosPedidos As New Productos_Pedidos
            If ObjProductosPedidos.Eliminar_productos_pedidos(pedido) Then
                'MessageBox.Show("Linea Pedido Eliminada con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al eliminar Lineas Pedido, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub RecalcularImportePedido(ByVal pedido As Integer)
        'Recalcular Importe  
        Dim CambioImporte As Decimal = 0
        Dim ImporteAnterior As Decimal = 0
        Dim ImporteNuevo As Decimal = 0
        ImporteNuevo = CInt(Tcantidad.Text) * CDbl(GrillaLP.SelectedCells.Item(1).Value)
        ImporteAnterior = CDbl(GrillaLP.SelectedCells.Item(3).Value)
        CambioImporte = ImporteNuevo - ImporteAnterior
        Dim ObjPedidos As New Pedido
        If ObjPedidos.Modificar_Pedidos_Importe(pedido, CambioImporte) Then
            'MessageBox.Show("Importe Pedido Modificado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al Modificar Importe Pedido, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RecalcularStockProductoM(ByVal descripcion As String)
        'Recalcular Stock  
        Dim CambioCantidad As Integer = 0
        Dim CantidadAnterior As Integer = 0
        Dim CantidadNueva As Integer = 0
        CantidadNueva = CInt(Tcantidad.Text)
        CantidadAnterior = CDbl(GrillaLP.SelectedCells.Item(2).Value)
        CambioCantidad = CantidadNueva - CantidadAnterior
        Dim ObjProductos As New Producto
        If ObjProductos.Modificar_Productos_Stock(descripcion, CambioCantidad) Then
            'MessageBox.Show("Stock Producto Modificado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al modificar Stock Producto, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub RecalcularStockProductoE()
        Dim descripcion As String = Cproductos.Text.Substring(6)
        'Recalcular Stock  
        Dim CantidadSumar As Integer = 0
        CantidadSumar = CDbl(GrillaLP.SelectedCells.Item(2).Value)
        CantidadSumar = CantidadSumar * -1
        Dim ObjProductos As New Producto
        If ObjProductos.Modificar_Productos_Stock(descripcion, CantidadSumar) Then
            'MessageBox.Show("Stock Producto Modificado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al modificar Stock Producto, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class