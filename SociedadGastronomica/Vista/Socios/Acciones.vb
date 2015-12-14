Public Class Acciones
    Dim directorio As String = My.Application.Info.DirectoryPath
    Private Sub Acciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ObjSocios As New Socio
        ObjSocios.Mostrar_socios(Grilla)
        Beliminar.Enabled = False
        Beditar.Enabled = False
    End Sub

    Private Sub Limpiar()
        Tdni.Text = ""
        Tdni.ReadOnly = False
        Tdni.Select() 'Posiciona el cursor
        Tnombre.Text = ""
        Temail.Text = ""
        Tibam.Text = ""
        Tfoto.Text = ""
        Tobservacion.Text = ""
        Me.mostrarfoto.Image = Image.FromFile(directorio & "/fotos/" & "SinImagen.jpg")
    End Sub

    Private Sub Bnuevo_Click_1(sender As System.Object, e As System.EventArgs) Handles Bnuevo.Click
        Limpiar()
        'Deshabilita el boton Beditar y Beliminar
        Bagregar.Enabled = True
        Beditar.Enabled = False
        Beliminar.Enabled = False
    End Sub
  
    Private Sub Bagregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bagregar.Click
        If Tdni.Text <> "" And Tnombre.Text <> "" And Temail.Text <> "" And Tibam.Text <> "" And Tfoto.Text <> "" And Tobservacion.Text <> "" Then
            Dim dni As String = Tdni.Text
            Dim nombre As String = Tnombre.Text
            Dim email As String = Temail.Text
            Dim ibam As String = Tibam.Text
            Dim foto As String = Tfoto.Text
            Dim observacion As String = Tobservacion.Text

            Dim ObjSocio As New Socio

            If CBool(ObjSocio.Agregar_socio(dni, nombre, email, ibam, foto, observacion)) Then
                MessageBox.Show("Socio agregado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                ObjSocio.Mostrar_socios(Grilla)
            Else
                MessageBox.Show("Error al guardar, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Complete los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Beditar_Click(sender As System.Object, e As System.EventArgs) Handles Beditar.Click
        If Tdni.Text <> "" And Tnombre.Text <> "" And Temail.Text <> "" And Tibam.Text <> "" And Tfoto.Text <> "" And Tobservacion.Text <> "" Then
            Dim dni As String = Tdni.Text
            Dim nombre As String = Tnombre.Text
            Dim email As String = Temail.Text
            Dim ibam As String = Tibam.Text
            Dim foto As String = Tfoto.Text
            Me.mostrarfoto.Image = Image.FromFile(directorio & "/fotos/" & "SinImagen.jpg")
            If My.Computer.FileSystem.FileExists(directorio & "/fotos/" & Tfoto.Text) Then
                Me.mostrarfoto.Image = Image.FromFile(directorio & "/fotos/" & Tfoto.Text)
            End If
            Dim observacion As String = Tobservacion.Text
            Dim ObjSocio As New Socio
            If ObjSocio.Editar_socio(dni, nombre, email, ibam, foto, observacion) Then
                MessageBox.Show("Socio Modificado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                ObjSocio.Mostrar_socios(Grilla)
            Else
                MessageBox.Show("Error al editar, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Complete los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Beliminar_Click_1(sender As System.Object, e As System.EventArgs) Handles Beliminar.Click
        If Tdni.Text <> "" And Tnombre.Text <> "" And Temail.Text <> "" And Tibam.Text <> "" And Tfoto.Text <> "" And Tobservacion.Text <> "" Then
            Dim dni As String = Tdni.Text
            Dim nombre As String = Tnombre.Text
            Dim email As String = Temail.Text
            Dim ibam As String = Tibam.Text
            Dim foto As String = Tfoto.Text
            Dim observacion As String = Tobservacion.Text
            Dim ObjSocio As New Socio
            If ObjSocio.Eliminar_socio(dni, nombre, email, ibam, foto, observacion) Then
                MessageBox.Show("Socio Eliminado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()

                ObjSocio.Mostrar_socios(Grilla)
            Else
                MessageBox.Show("Error al editar, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Complete los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Bexaminar_Click(sender As System.Object, e As System.EventArgs) Handles Bexaminar.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = directorio & "\fotos"
        openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim ultimaBarra As Integer = openFileDialog1.FileName.LastIndexOf("\")
            Tfoto.Text = openFileDialog1.FileName().Substring(ultimaBarra + 1)
            Me.mostrarfoto.Image = Image.FromFile(directorio & "/fotos/" & "SinImagen.jpg")
            If My.Computer.FileSystem.FileExists(directorio & "/fotos/" & Tfoto.Text) Then
                Me.mostrarfoto.Image = Image.FromFile(directorio & "/fotos/" & Tfoto.Text)
            End If
        End If
    End Sub

    Private Sub usuarioGrilla(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellClick
        'Completa las cajas de texto para su consulta 
        Tdni.Text = CStr(Grilla.SelectedCells.Item(0).Value)
        Tdni.ReadOnly = True
        Tnombre.Select()
        Tnombre.Text = CStr(Grilla.SelectedCells.Item(1).Value)
        Temail.Text = CStr(Grilla.SelectedCells.Item(2).Value)
        Tibam.Text = CStr(Grilla.SelectedCells.Item(3).Value)
        Tfoto.Text = CStr(Grilla.SelectedCells.Item(4).Value)
        Tobservacion.Text = CStr(Grilla.SelectedCells.Item(5).Value)
        Me.mostrarfoto.Image = Image.FromFile(directorio & "/fotos/" & "SinImagen.jpg")
        If My.Computer.FileSystem.FileExists(directorio & "/fotos/" & Tfoto.Text) Then
            Me.mostrarfoto.Image = Image.FromFile(directorio & "/fotos/" & Tfoto.Text)
        End If

        'Deshabilita el boton Agregar
        Bagregar.Enabled = False
        Beditar.Enabled = True
        Beliminar.Enabled = True
    End Sub

End Class