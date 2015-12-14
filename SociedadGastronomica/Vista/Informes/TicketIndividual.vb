Public Class TicketIndividual
    Dim ObjPedido As New Pedido
    Dim ObjLineasPedido As New Productos_Pedidos
    Private Sub TicketIndividual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObjPedido.MostrarUsuarios(Cdni)
    End Sub
    Private Sub Cdni_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cdni.SelectedIndexChanged
        Dim posicionGuion As Integer = Cdni.Text.IndexOf("-")
        Dim dni As String = Cdni.Text.Substring(0, posicionGuion)
        ObjPedido.MostrarPedidosSocio(dni, Grilla)
    End Sub
    Private Sub usuarioGrilla(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellClick
        'Completa las cajas de texto para su consulta 
        Tpedido.Text = CStr(Grilla.SelectedCells.Item(0).Value)
        Dim dtFecha As DateTime = CDate(Grilla.SelectedCells.Item(1).Value)
        Dim fecha2 As String = dtFecha.ToString("dddd, d 'de' MMMMMMMMMMMM 'de' yyyy")
        Tfecha.Text = fecha2
        Dim posicionGuion As Integer = Cdni.Text.IndexOf("-")
        Dim nombre As String = Cdni.Text.Substring(posicionGuion + 1)
        Tnombre.Text = nombre
        Ttotal.Text = CStr(Grilla.SelectedCells.Item(2).Value) & "€"
        ObjLineasPedido.MostrarLineasPedido(CInt(Tpedido.Text), Grilla2)
    End Sub
End Class