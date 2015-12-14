Imports System.Data.OleDb
Public Class AltaPedidos
    Private Sub AccionesProductos_Pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BorrarPantalla()
    End Sub
    Private Sub Añadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Añadir.Click
        Dim ObjProductosPedidos As New Productos_Pedidos
        If Tcantidad.Text <> "" And Cproductos.Text <> "" Then
            Dim pedido As Integer = CInt(TnumeroPedido.Text)
            'MsgBox(Cproductos.Text.Substring(0, 4))
            Dim producto As String = Cproductos.Text.Substring(0, 4)
            Dim cantidad As Integer = CInt(Tcantidad.Text)
            If CBool(ObjProductosPedidos.Agregar_Productos_Pedidos(pedido, producto, cantidad)) Then
                'MessageBox.Show("Linea Pedido agregada con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarLinea()
                ObjProductosPedidos.Mostrar_Productos_Pedidos(Grilla, pedido, Timporte)
            Else
                MessageBox.Show("Error al guardar Linea Pedido, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Selecciona producto y mete la cantidad , intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub LimpiarLinea()
        TnumeroPedido.ReadOnly = True
        Tcantidad.Text = "0"
        Cproductos.ResetText()
    End Sub
    Private Sub Confirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confirmar.Click
        If Cdni.Text <> "" And Timporte.Text > "0" Then
            Dim ObjPedido As New Pedido
            Dim posicionGuion As Integer = Cdni.Text.IndexOf("-")
            Dim dni As String = Cdni.Text.Substring(0, posicionGuion)
            'MsgBox(dni)

            If CBool(ObjPedido.Agregar_Pedido(CInt(TnumeroPedido.Text), dni, Tfecha.Text, CDbl(Timporte.Text))) Then
                ActualizarStockProductos(Grilla)
                MessageBox.Show("Pedido agregado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarLinea()
                BorrarPantalla()
            Else
                MessageBox.Show("Error al guardar Pedido, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Selecciona un dni y mete Lineas de Pedido , intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub BorrarPantalla()
        Dim ObjPedido As New Pedido
        ObjPedido.MostrarUsuarios(Cdni)
        ObjPedido.MostrarProductos(Cproductos)
        ObjPedido.MostrarNumeroPedido(TnumeroPedido)
        TnumeroPedido.ReadOnly = True
        Cdni.Select() 'Posiciona el cursor
        Timporte.ReadOnly = True
        Timporte.Text = "0"
        Grilla.Rows.Clear()
    End Sub
    Private Sub ActualizarStockProductos(ByVal Grilla As DataGridView)
        'Recorrer la Grilla para sacar la Descripcion del Producto y la Cantidad vendida
        Dim Descripcion As String
        Dim Cantidad As Integer
        For x As Integer = 0 To Grilla.Rows.Count - 2
            'MsgBox(Grilla.Item(0, x).Value & "-" & Grilla.Item(2, x).Value)
            Descripcion = CStr((Grilla.Item(0, x).Value))
            Cantidad = CInt(Grilla.Item(2, x).Value)
            'Modificar el Stock de Productos
            Dim ObjProductos As New Producto
            If CBool(ObjProductos.Modificar_Productos_Stock(Descripcion, Cantidad)) Then
                'MessageBox.Show("Stock Producto modificado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar Stock Producto, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next
    End Sub
End Class
