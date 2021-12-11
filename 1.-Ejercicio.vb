Public Class frmEjercicio1

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        labResultado.Text = "El area es: " & (Val(txtBase.Text) * Val(txtAltura.Text) / 2)

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        txtBase.Text = String.Empty
        txtAltura.Text = String.Empty
        labResultado.Text = ""

    End Sub

    Private Sub txtBase_TextChanged(sender As Object, e As EventArgs) Handles txtBase.TextChanged

    End Sub

    Private Sub frmEjercicio1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class