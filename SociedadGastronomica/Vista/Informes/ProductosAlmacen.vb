Public Class ProductosAlmacen

    Private Sub ProductosAlmacen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ObjProducto As New Producto
        ObjProducto.Mostrar_Producto_Almacen(Grilla)
    End Sub

    
End Class