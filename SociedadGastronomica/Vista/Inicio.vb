Public Class Inicio

    Private Sub ABMSociosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMSociosToolStripMenuItem.Click
        Acciones.Show()
    End Sub

    Private Sub BuscarSociosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarSociosToolStripMenuItem.Click
        Buscar.Show()
    End Sub

    Private Sub ABMProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMProductosToolStripMenuItem.Click
        AccionesProductos.Show()
    End Sub

    Private Sub BuscarProductosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProductosToolStripMenuItem1.Click
        BuscarProductos.Show()
    End Sub

    Private Sub AltaPedidosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaPedidosToolStripMenuItem1.Click
        AltaPedidos.Show()
    End Sub

    Private Sub ModificacionBajaPedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionBajaPedidosToolStripMenuItem.Click
        ModificacionBajaPedidos.Show()
    End Sub
    Private Sub BuscarPedidosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarPedidosToolStripMenuItem2.Click
        BuscarPedidos.Show()
    End Sub
    Private Sub ProductosEnAlmacenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosEnAlmacenToolStripMenuItem.Click
        ProductosAlmacen.Show()
    End Sub
    Private Sub ReciboToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReciboToolStripMenuItem.Click
        TicketIndividual.Show()
    End Sub

    Private Sub ReciboAcumuladoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReciboAcumuladoToolStripMenuItem.Click
        TicketAcumulado.Show()
    End Sub
    Private Sub ReposicionDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReposicionDeProductosToolStripMenuItem.Click
        TicketCobroSocios.Show()
    End Sub
End Class
