Public Class TicketAcumulado
    Dim ObjPedido As New Pedido
    Dim ObjLineasPedido As New Productos_Pedidos
    Private Sub TicketAcumulado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObjPedido.MostrarUsuarios(Cdni)
    End Sub
    Private Sub Cdni_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cdni.SelectedIndexChanged
        VisualizarTiCketAcumulado()
    End Sub
    Private Sub FechaInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaInicial.ValueChanged
        VisualizarTiCketAcumulado()
    End Sub

    Private Sub FechaFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaFinal.ValueChanged
        VisualizarTiCketAcumulado()
    End Sub
    Private Sub VisualizarTiCketAcumulado()
        Dim posicionGuion As Integer = Cdni.Text.IndexOf("-")
        Dim dni As String = Cdni.Text.Substring(0, posicionGuion)
        Dim dtFecha As DateTime = CDate(FechaInicial.Text)
        Dim fecha2 As String = dtFecha.ToString("dddd, d 'de' MMMMMMMMMMMM 'de' yyyy")
        TfechaI.Text = fecha2
        dtFecha = CDate(FechaFinal.Text)
        fecha2 = dtFecha.ToString("dddd, d 'de' MMMMMMMMMMMM 'de' yyyy")
        TFechaF.Text = fecha2
        Dim nombre As String = Cdni.Text.Substring(posicionGuion + 1)
        Tnombre.Text = nombre
        ObjLineasPedido.MostrarLineasPedidoAcumulado(dni, FechaInicial.Text, FechaFinal.Text, Grilla)

        'Recorrer la Grilla para sacar la importe Total
        Dim Importe As Double = 0
        For x As Integer = 0 To Grilla.Rows.Count - 2
            'MsgBox(Grilla.Item(0, x).Value & "-" & Grilla.Item(2, x).Value)
            Importe = Importe + CDbl(Grilla.Item(3, x).Value)
        Next
        Ttotal.Text = Importe.ToString & "€"
    End Sub

  
End Class