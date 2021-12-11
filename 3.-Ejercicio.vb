Public Class frmEjercicio3


    Private Sub frmEjercicio3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtTiempo.Enabled = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles txtTiempo.Tick




    End Sub

    Private Sub btnBucarHora_Click(sender As Object, e As EventArgs) Handles btnBucarHora.Click

        Dim hora, accion, desayuno, almuerzo, postre, cena, bebidas As String

        hora = Val(txtHora.Text)
        Format(Now, "HH:mm:ss")

        accion = Val(txtAccion.Text)

        desayuno = Val(txtDesayuno.Text)

        almuerzo = Val(txtAlmuerzo.Text)

        postre = Val(txtMerienda.Text)

        cena = Val(txtCena.Text)

        bebidas = Val(txtBebidas.Text)

        If (hora <= 6 And hora <= 24) Then

            MsgBox("estamos cerrados, nuestros Horarios de atencion son de 7AM a 10PM", MsgBoxStyle.Critical)
            MsgBox(accion)

        ElseIf (hora >= 7 And hora <= 10) Then

            txtDesayuno.Text = "Cachapa" + vbCrLf + "Empanadas" + vbCrLf + "Cereal"
            txtBebidas.Text = "Coca-Cola" + vbCrLf + "Panela con Limon" + vbCrLf + "Jugos naturales" + vbCrLf + "Cafe"
            txtDesayuno.BackColor = Color.AliceBlue

        ElseIf (hora >= 10 And hora <= 15) Then

            txtAlmuerzo.Text = "Pasta con carne " + vbCrLf + "Pabellon" + vbCrLf + "Macarrones"
            txtBebidas.Text = "Coca-Cola" + vbCrLf + "Panela con Limon" + vbCrLf + "Jugos naturales"
            txtAlmuerzo.BackColor = Color.AliceBlue

        ElseIf (hora >= 15 And hora <= 18) Then

            txtMerienda.Text = "Tortas" + vbCrLf + "Galletas" + vbCrLf + "Arroz con leche"
            txtBebidas.Text = "Cafe"
            txtMerienda.BackColor = Color.AliceBlue

        ElseIf (hora >= 17 And hora <= 22) Then

            txtCena.Text = "Pizza" + vbCrLf + "Hamburguesa" + vbCrLf + "Hallaca"
            txtBebidas.Text = "Coca-Cola" + vbCrLf + "Pepsi-Cola"
            txtCena.BackColor = Color.AliceBlue

        End If



    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        txtHora.Text = String.Empty
        txtDesayuno.Text = String.Empty
        txtBebidas.Text = String.Empty
        txtAlmuerzo.Text = String.Empty
        txtMerienda.Text = String.Empty
        txtCena.Text = String.Empty


    End Sub
End Class