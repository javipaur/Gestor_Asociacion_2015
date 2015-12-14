Option Strict Off
Imports System.Data.OleDb
Public Class Producto
    Inherits ConexionBD 'Hereda la clase conexion

    Dim Comando As New OleDbCommand
    Dim Adaptador As New OleDbDataAdapter(Comando)
    Dim Transact As OleDbTransaction

    Public Function Mostrar_Producto(ByVal Grilla As DataGridView)
        Grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Dim Consulta As String = "Select *from Productos order by 1"
        Try
            Conectar()
            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    Grilla.Rows.Add(DR("codigo_producto"), DR("nombre"), DR("descripcion"), DR("precio"), DR("stock"), DR("stock_minimo"))
                Loop
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Function Agregar_Producto(ByVal codigo As String, ByVal nombre As String, ByVal descripcion As String, ByVal precio As String, ByVal stock As String, ByVal stock_Minimo As String) As Object
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Insert Into Productos(codigo_producto, nombre, descripcion, precio, stock, stock_minimo) values('" & codigo & "','" & nombre & "','" & descripcion & "','" & precio & "','" & stock & "','" & stock_Minimo & "')"
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

    Function Editar_producto(ByVal codigo As String, ByVal nombre As String, ByVal descripcion As String, ByVal precio As String, ByVal stock As String, ByVal stock_Minimo As String) As Boolean
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Update Productos set codigo_producto='" & codigo & "', nombre='" & nombre & "', descripcion='" & descripcion & "', precio='" & precio & "', stock='" & stock & "', stock_minimo='" & stock_Minimo & "' Where codigo_producto='" & codigo & "'"
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

    Function Eliminar_producto(ByVal codigo As String, ByVal nombre As String, ByVal descripcion As String, ByVal precio As String, ByVal stock As String, ByVal stock_Minimo As String) As Boolean
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Delete from Productos Where codigo_producto='" & codigo & "'"
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

    Function BuscarProductos(ByVal grilla As DataGridView, ByVal consulta As String)
        grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Try
            Conectar()
            Comando = New OleDbCommand(consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    grilla.Rows.Add(DR("codigo_producto"), DR("nombre"), DR("descripcion"), DR("precio"), DR("stock"), DR("stock_minimo"))
                Loop
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Function Modificar_Productos_Stock(Descripcion As String, Cantidad As Integer) As Object
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Update Productos SET  stock=stock - " & Cantidad & "  Where descripcion ='" & Descripcion & "'"
        'MsgBox(Consulta)
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

    Function Mostrar_Producto_Almacen(ByVal grilla As DataGridView)
        grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Dim Consulta As String = "Select * from Productos order by 1"
        Try
            Conectar()
            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    'MsgBox(DR("stock") & "-" & DR("stock_minimo"))
                    If DR("stock") < DR("stock_minimo") Then
                        grilla.Rows.Add(DR("codigo_producto"), DR("nombre"), DR("descripcion"), DR("precio"), DR("stock"), DR("stock_minimo"), "     *")
                    Else
                        grilla.Rows.Add(DR("codigo_producto"), DR("nombre"), DR("descripcion"), DR("precio"), DR("stock"), DR("stock_minimo"), " ")
                    End If
                Loop
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

End Class
