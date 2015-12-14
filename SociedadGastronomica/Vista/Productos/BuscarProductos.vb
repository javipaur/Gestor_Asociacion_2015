Public Class BuscarProductos

   
    Private Sub Bbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bbuscar.Click
        Dim ObjProducto As New Producto
        ObjProducto.Mostrar_Producto(Grilla)

        Dim consulta As String = "select * from Productos"
        Dim primero As Integer = 0
        If Tcodigo.Text <> "" Then
            primero = 1
            consulta = consulta + " Where codigo_producto LIKE '%" + Tcodigo.Text + "%'"
        End If
        If Tnombre.Text <> "" Then
            If primero = 0 Then
                primero = 1
                consulta = consulta + " Where nombre LIKE '%" + Tnombre.Text + "%'"
            Else
                consulta = consulta + " and nombre LIKE '%" + Tnombre.Text + "%'"
            End If

        End If
        If Tdescripcion.Text <> "" Then
            If primero = 0 Then
                primero = 1
                consulta = consulta + " Where descripcion LIKE '%" + Tdescripcion.Text + "%'"
            Else
                consulta = consulta + " and descripcion LIKE '%" + Tdescripcion.Text + "%'"
            End If

        End If
        If Tprecio.Text <> "" Then
            If primero = 0 Then
                primero = 1
                consulta = consulta + " Where (InStr(Str(precio),'" + Tprecio.Text + "') > 0)"
            Else
                consulta = consulta + " and (InStr(Str(precio),'" + Tprecio.Text + "') > 0)"
            End If
        End If
        If Tstock.Text <> "" Then
            If primero = 0 Then
                primero = 1
                consulta = consulta + " Where stock LIKE '%" + Tstock.Text + "%'"
            Else
                consulta = consulta + " and stock LIKE '%" + Tstock.Text + "%'"
            End If

        End If
        If Tstock_minimo.Text <> "" Then
            If primero = 0 Then
                primero = 1
                consulta = consulta + " Where  stock_minimo LIKE '%" + Tstock_minimo.Text + "%'"
            Else
                consulta = consulta + " and stock_minimo LIKE '%" + Tstock_minimo.Text + "%'"
            End If

        End If
        consulta = consulta + " order by 1"
        ObjProducto.BuscarProductos(grilla, consulta)
    End Sub

   
End Class