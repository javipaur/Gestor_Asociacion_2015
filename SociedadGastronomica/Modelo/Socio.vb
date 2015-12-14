Option Strict Off
Imports System.Data.OleDb
Public Class Socio
    Inherits ConexionBD 'Hereda la clase conexion

    Dim Comando As New OleDbCommand
    Dim Adaptador As New OleDbDataAdapter(Comando)
    Dim Transact As OleDbTransaction

    Public Function Mostrar_socios(ByVal Grilla As DataGridView)
        Grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Dim Consulta As String = "Select *from Socios order by 1"

        Try
            Conectar()
            Comando = New OleDbCommand(Consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    Grilla.Rows.Add(DR("CODIGO_DNI"), DR("NOMBRE"), DR("EMAIL"), DR("IBAN"), DR("FOTO"), DR("OBSERVACIONES"))
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

    Function Agregar_socio(ByVal dni As String, ByVal nombre As String, ByVal email As String, ByVal ibam As String, ByVal foto As String, ByVal observacion As String) As Object

        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Insert Into Socios(codigo_dni, nombre, email, iban, foto, observaciones) values('" & dni & "','" & nombre & "','" & email & "','" & ibam & "','" & foto & "','" & observacion & "')"
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

    Function Editar_socio(ByVal dni As String, ByVal nombre As String, ByVal email As String, ByVal ibam As String, ByVal foto As String, ByVal observacion As String) As Boolean
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Update Socios set codigo_dni='" & dni & "', nombre='" & nombre & "', email='" & email & "', iban='" & ibam & "', foto='" & foto & "', observaciones='" & observacion & "' Where codigo_dni='" & dni & "'"
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

    Function Eliminar_socio(ByVal dni As String, ByVal nombre As String, ByVal email As String, ByVal ibam As String, ByVal foto As String, ByVal observacion As String) As Boolean
        Dim Transaccion As OleDbTransaction
        Dim Consulta As String = "Delete from Socios Where codigo_dni='" & dni & "'"
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

    Function Buscar_socios(Grilla As DataGridView, consulta As String)
        Grilla.Rows.Clear()
        Dim DR As OleDbDataReader
        Try
            Conectar()
            Comando = New OleDbCommand(consulta)
            Comando.CommandType = CommandType.Text
            Comando.Connection = Conector
            DR = Comando.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    Grilla.Rows.Add(DR("CODIGO_DNI"), DR("NOMBRE"), DR("EMAIL"), DR("IBAN"), DR("FOTO"), DR("OBSERVACIONES"))
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
