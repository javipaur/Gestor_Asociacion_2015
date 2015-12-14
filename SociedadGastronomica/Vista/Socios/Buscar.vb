Public Class Buscar


   
    Private Sub Bbuscar_Click(sender As System.Object, e As System.EventArgs) Handles Bbuscar.Click
        Dim ObjSocios As New Socio
        Dim consulta As String = "select * from socios"
        Dim primero As Integer = 0
        If Tdni.Text <> "" Then
            primero = 1
            consulta = consulta + " Where codigo_dni LIKE '%" + Tdni.Text + "%'"
        End If
        If Tnombre.Text <> "" Then
            If primero = 0 Then
                primero = 1
                consulta = consulta + " Where nombre LIKE '%" + Tnombre.Text + "%'"
            Else
                consulta = consulta + " and nombre LIKE '%" + Tnombre.Text + "%'"
            End If

        End If
        If Temail.Text <> "" Then
            If primero = 0 Then
                primero = 1
                consulta = consulta + " Where email LIKE '%" + Temail.Text + "%'"
            Else
                consulta = consulta + " and email LIKE '%" + Temail.Text + "%'"
            End If

        End If
        If Tibam.Text <> "" Then
            If primero = 0 Then
                primero = 1
                consulta = consulta + " Where iban LIKE '%" + Tibam.Text + "%'"
            Else
                consulta = consulta + " and iban LIKE '%" + Tibam.Text + "%'"
            End If

        End If
        If Tfoto.Text <> "" Then
            If primero = 0 Then
                primero = 1
                consulta = consulta + " Where foto LIKE '%" + Tfoto.Text + "%'"
            Else
                consulta = consulta + " and foto LIKE '%" + Tfoto.Text + "%'"
            End If

        End If
        If Tobservacion.Text <> "" Then
            If primero = 0 Then
                primero = 1
                consulta = consulta + " Where observaciones LIKE '%" + Tobservacion.Text + "%'"
            Else
                consulta = consulta + " and observaciones LIKE '%" + Tobservacion.Text + "%'"
            End If

        End If
        consulta = consulta + " order by 1"
        ObjSocios.Buscar_socios(Grilla, consulta)
    End Sub

    Private Sub Buscar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class