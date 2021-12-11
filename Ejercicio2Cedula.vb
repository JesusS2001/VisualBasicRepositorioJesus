Public Class frmcedulaverificador

    Private Sub btnverificar_Click(sender As Object, e As EventArgs) Handles btnverificar.Click

        Dim cedula, confirmacion, accion As Long

        cedula = Val(txtcedula.Text)

        confirmacion = Val(txtconfirmacion.Text)

        accion = Val(txtaccion.Text)

        If (confirmacion = cedula) Then

            txtaccion.Text = "Aprobada"

        ElseIf (confirmacion <> cedula) Then
            txtaccion.Text = "Incorrecta"

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtcedula.Text = String.Empty
        txtconfirmacion.Text = String.Empty
        txtaccion.Text = String.Empty

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class