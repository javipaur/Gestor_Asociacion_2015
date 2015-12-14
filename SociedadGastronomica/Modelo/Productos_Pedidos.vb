Option Strict Off
Imports System.Data.OleDb
Public Class Productos_Pedidos
    Inherits ConexionBD 'Hereda la clase conexion
    Dim Comando As New OleDbCommand
    Dim Adaptador As New OleDbDataAdapter(Comando)
    Dim Transact As OleDbTransaction

    Function Eliminar_productos_pedidos(ByVal pedido As Integer, ByVal producto As String) As Boolean
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Delete from Productos_Pedidos Where numero_pedido=" & pedido & " "
        Consulta &= " AND  codigo_producto='" & producto & "'"
        Try
            Conectar()

            Transaccion = Conector.BeginTransaction(IsolationLevel.ReadCommitted)

            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            Comando.Transaction = Transaccion

            If Comando.ExecuteNonQuery Then
                Transaccion.Commit()
                Return True
            Else
                Transaccion.Rollback()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Function Agregar_Productos_Pedidos(ByVal pedido As Integer, ByVal producto As String, ByVal cantidad As Integer) As Object
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Insert Into Productos_Pedidos(numero_pedido, codigo_producto, cantidad) values('" & pedido & "','" & producto & "','" & cantidad & "')"
        Try
            Conectar()

            Transaccion = Conector.BeginTransaction(IsolationLevel.ReadCommitted) 'Establecemos la clausula  "Begin" de SQL

            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector 'Establecemos conexion
            Comando.Transaction = Transaccion 'Establecemos transaccion

            If Comando.ExecuteNonQuery Then
                Transaccion.Commit()
                Return True
            Else
                Transaccion.Rollback() 'Si falla hacemos Rollback
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()

        End Try
    End Function

    Sub Mostrar_Productos_Pedidos(ByVal Grilla As DataGridView, ByVal numeroPedido As Integer, ByVal Timporte As TextBox)
        Grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Dim Importe As Decimal = 0
        Dim Consulta As String = "SELECT descripcion,precio,cantidad,precio*cantidad as importe "
        Consulta &= "FROM Productos_Pedidos x, Productos y "
        Consulta &= "WHERE   y.codigo_producto = x.codigo_producto "
        Consulta &= "AND   x.numero_pedido=" & numeroPedido & " order by 1, 2"
        'MsgBox(Consulta)
        Try
            Conectar()
            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    Grilla.Rows.Add(DR("Descripcion"), DR("Precio"), DR("Cantidad"), DR("Importe"))
                    Importe = Importe + DR("Importe")
                Loop
            End If
            Timporte.Text = Importe & "€"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Sub

    Function Modificar_productos_pedidos(ByVal pedido As Integer, ByVal producto As String, ByVal cantidad As Integer) As Boolean

        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Update Productos_Pedidos set codigo_producto='" & producto & "', cantidad='" & cantidad & "' Where numero_pedido=" & pedido & ""
        Consulta &= " AND  codigo_producto='" & producto & "'"
        Try
            Conectar()

            Transaccion = Conector.BeginTransaction(IsolationLevel.ReadCommitted)

            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            Comando.Transaction = Transaccion

            If Comando.ExecuteNonQuery Then
                Transaccion.Commit()
                Return True
            Else
                Transaccion.Rollback()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Function Eliminar_productos_pedidos(ByVal pedido As String) As Boolean
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Delete from Productos_Pedidos Where numero_pedido=" & pedido & " "
        Try
            Conectar()

            Transaccion = Conector.BeginTransaction(IsolationLevel.ReadCommitted)

            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            Comando.Transaction = Transaccion

            If Comando.ExecuteNonQuery Then
                Transaccion.Commit()
                Return True
            Else
                Transaccion.Rollback()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Sub MostrarLineasPedido(ByVal numeroPedido As Integer, ByVal Grilla As DataGridView)
        Grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Dim Importe As Decimal = 0
        Dim Consulta As String = "SELECT cantidad,descripcion,precio,precio*cantidad as importe "
        Consulta &= "FROM Productos_Pedidos x, Productos y "
        Consulta &= "WHERE   y.codigo_producto = x.codigo_producto "
        Consulta &= "AND   x.numero_pedido=" & numeroPedido & ""
        Consulta &= " order by 1, 2"
        'MsgBox(Consulta)
        Try
            Conectar()
            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    Grilla.Rows.Add(DR("Cantidad"), DR("Descripcion"), DR("Precio"), DR("Importe"))
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Sub

    Sub MostrarLineasPedidoAcumulado(ByVal dni As String, ByVal FechaInicial As String, ByVal FechaFinal As String, ByVal Grilla As DataGridView)
        Grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Dim Importe As Decimal = 0

        Dim fechaI As Date
        fechaI = FechaInicial
        fechaI = Format(fechaI, "dd/MM/yyyy")

        Dim fechaF As Date
        fechaF = FechaFinal
        fechaF = Format(fechaF, "dd/MM/yyyy")

        Dim Consulta As String = "SELECT  distinct sum(cantidad) as cantidad,descripcion,precio,sum(precio*cantidad) as importe "
        Consulta &= "FROM Productos_Pedidos x, Productos y, Pedidos z "
        Consulta &= "WHERE y.codigo_producto = x.codigo_producto "
        Consulta &= "AND   x.numero_pedido= z.numero_pedido "
        Consulta &= "AND   z.fecha_pedido BETWEEN #" & CDate(fechaI) & "# and #" & CDate(fechaF) & "# "
        Consulta &= "AND   z.codigo_dni='" & dni & "' "
        Consulta &= "group by descripcion, precio"
        'MsgBox(Consulta)
        Try
            Conectar()
            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    Grilla.Rows.Add(DR("Cantidad"), DR("Descripcion"), DR("Precio"), DR("Importe"))
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Sub


End Class
