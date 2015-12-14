Public Class BuscarPedidos

    Private Sub BuscarProductosPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ObjPedido As New Pedido
        ObjPedido.MostrarPedidos(Grilla)
    End Sub

    Private Sub Bbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bbuscar.Click
        Dim ObjPedido As New Pedido
        ObjPedido.MostrarPedidos(Grilla)

        Dim consulta As String = "select numero_pedido,codigo_dni,LEFT(CSTR(fecha_pedido),10) as fecha_pedido,importe from Pedidos "
        If Tbuscar.Text <> "" Then
            consulta = consulta + " WHERE numero_pedido LIKE '%" + Tbuscar.Text + "%'"
            consulta = consulta + " OR codigo_dni LIKE '%" + Tbuscar.Text + "%'"
            consulta = consulta + " OR LEFT(CSTR(fecha_pedido),10)  LIKE '%" + Tbuscar.Text + "%'"
            consulta = consulta + " OR (InStr(Str(importe),'" + Tbuscar.Text + "') > 0) "
            consulta = consulta + " ORDER by 1"
        End If
        'MsgBox(consulta)
        ObjPedido.BuscarPedido(Grilla, consulta)
    End Sub

End Class