Option Strict Off
Imports System.Data.OleDb
Public Class Pedido
    Inherits ConexionBD 'Hereda la clase conexion

    Dim Comando As New OleDbCommand
    Dim Adaptador As New OleDbDataAdapter(Comando)
    Dim Transact As OleDbTransaction
    Public Function MostrarPedidos(ByVal Grilla As DataGridView)
        Grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Dim Consulta As String = "Select numero_pedido, codigo_dni,LEFT(CSTR(fecha_pedido),10) as fecha_pedido, importe  from Pedidos order by 1"
        Try
            Conectar()
            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    Grilla.Rows.Add(DR("numero_pedido"), DR("codigo_dni"), DR("fecha_pedido"), DR("importe"))
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

    Function BuscarPedido(ByVal grilla As DataGridView, ByVal consulta As String)
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
                    grilla.Rows.Add(DR("numero_pedido"), DR("codigo_dni"), DR("fecha_pedido"), DR("importe"))
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
    Public Sub MostrarUsuarios(ByVal Cdni As ComboBox)
        Dim DR As OleDbDataReader
        Dim Consulta As String = "Select codigo_dni & '- ' & nombre as nombre from Socios order by 1"
        Conectar()
        Comando = New OleDbCommand(Consulta)
        Comando.CommandType = CommandType.Text
        Comando.Connection = Conector
        DR = Comando.ExecuteReader
        While DR.Read()
            Cdni.Items.Add(DR("nombre"))
        End While
        'Cdni.SelectedIndex = 0
    End Sub

    Sub MostrarFecha(ByVal Tfecha As DateTimePicker)
        Dim DR As OleDbDataReader
        Dim Consulta As String = "Select *from Pedidos"
        Conectar()
        Comando = New OleDbCommand(Consulta)
        Comando.CommandType = CommandType.Text
        Comando.Connection = Conector
        DR = Comando.ExecuteReader
        While DR.Read()
            Tfecha.Value = DR("fecha pedido")
        End While
    End Sub

    Sub MostrarProductos(ByVal Cproductos As ComboBox)
        Dim DR As OleDbDataReader
        Dim Consulta As String = "Select codigo_producto & '- ' &descripcion as descripcion from Productos order by 1"
        Conectar()
        Comando = New OleDbCommand(Consulta)
        Comando.CommandType = CommandType.Text
        Comando.Connection = Conector
        DR = Comando.ExecuteReader
        While DR.Read()
            Cproductos.Items.Add(DR("descripcion"))
        End While
        'Cproductos.SelectedIndex = 0
    End Sub
    Sub MostrarNumeroPedido(ByVal TnumeroPedido As TextBox)
        Dim DR As OleDbDataReader
        Dim Consulta As String = "Select max (numero_pedido) as numero_pedido from Pedidos"
        Conectar()
        Comando = New OleDbCommand(Consulta)
        Comando.CommandType = CommandType.Text
        Comando.Connection = Conector
        DR = Comando.ExecuteReader
        While DR.Read()
            'MsgBox((DR("numero_pedido") + 1))
            TnumeroPedido.Text = (DR("numero_pedido") + 1)
        End While

        ' Borrar Productos_Pedidos si no se ha confirmado Pedido
        Consulta = "Delete from Productos_Pedidos where numero_pedido=" & CInt(TnumeroPedido.Text) & " "
        Try
            Conectar()
            Dim Transaccion = Conector.BeginTransaction(IsolationLevel.ReadCommitted)
            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            Comando.Transaction = Transaccion

            If Comando.ExecuteNonQuery Then
                Transaccion.Commit()
            Else
                Transaccion.Rollback()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Desconectar()
        End Try
    End Sub

    Function Agregar_Pedido(ByVal pedido As Integer, ByVal dni As String, ByVal fecha As String, ByVal importe As Double) As Object
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Insert Into Pedidos(numero_pedido,codigo_dni,fecha_pedido, importe) values('" & pedido & "','" & dni & "','" & fecha & "','" & importe & "')"
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
   

    Function Eliminar_pedido(ByVal pedido As Integer) As Boolean
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Delete from Pedidos Where numero_pedido=" & pedido & ""
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

    Function Modificar_Pedido(ByVal pedido As Integer, ByVal dni As String, ByVal fecha As String, ByVal importe As String) As Boolean
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Update Pedidos set codigo_dni='" & dni & "', fecha_pedido ='" & fecha & "', importe='" & importe & "'  Where numero_pedido=" & pedido & ""
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

    Function Modificar_Pedidos_Importe(pedido As Integer, CambioImporte As Decimal) As Boolean
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Update Pedidos set  importe=importe +'" & CambioImporte & "'  Where numero_pedido=" & pedido & ""
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
    Public Function MostrarPedidosSocio(ByVal dni As String, ByVal Grilla As DataGridView) As Boolean
        Grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Dim Consulta As String = "Select numero_pedido, LEFT(CSTR(fecha_pedido),10) as fecha_pedido, importe  from Pedidos "
        Consulta = Consulta + " WHERE codigo_dni = '" + dni + "'"
        Consulta = Consulta + " ORDER by 1"
        Try
            Conectar()
            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    Grilla.Rows.Add(DR("numero_pedido"), DR("fecha_pedido"), DR("importe"))
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

    Sub MostrarPedidosFechas(ByVal FechaInicial As String, ByVal FechaFinal As String, ByVal Grilla As DataGridView)
        Grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Dim Importe As Decimal = 0

        Dim fechaI As Date
        fechaI = FechaInicial
        fechaI = Format(fechaI, "dd/MM/yyyy")

        Dim fechaF As Date
        fechaF = FechaFinal
        fechaF = Format(fechaF, "dd/MM/yyyy")

        Dim Consulta As String = "SELECT  x.codigo_dni,nombre,iban,sum(importe) as importe "
        Consulta &= "FROM Socios x, Pedidos y "
        Consulta &= "WHERE x.codigo_dni= y.codigo_dni "
        Consulta &= "AND   y.fecha_pedido BETWEEN #" & CDate(fechaI) & "# and #" & CDate(fechaF) & "# "
        Consulta &= "group by  x.codigo_dni,nombre,iban"
        'MsgBox(Consulta)
        Try
            Conectar()
            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    Grilla.Rows.Add(DR("codigo_dni"), DR("nombre"), DR("iban"), DR("Importe"))
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Sub



End Class
