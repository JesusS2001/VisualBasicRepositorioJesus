Public Class frmcadenadecaracteres

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        'Declarar variables
        Dim cadena As String = txtCadena.Text
        'Aplicar las funciones
        'Calculamos la longitud de la cadena
        txtLongitud.Text = cadena.Length
        'Mostrar el primer carácter
        txtPrimer.Text = cadena.Substring(0, 1)
        'Mostrar el último caracter
        txtUltimo.Text = cadena.Substring(cadena.Length - 1, 1)
        'Mostrar del segundo al sexto carácter
        txt26.Text = cadena.Substring(1, 5)
        'Mostrar la ubicación de la primera letra A
        txtprimeraA.Text = cadena.IndexOf("A", 0) + 1
        'Convertimos el texto a mayúsculas
        txtMayusculas.Text = cadena.ToUpper()
        'Convertimos el texto a minúsculas
        txtMinusculas.Text = cadena.ToLower()
        'Borrar espacios en blancos
        txtBorrarEspacios.Text = cadena.Replace(" ", "")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtCadena.Text = String.Empty
        txtLongitud.Text = String.Empty
        txtUltimo.Text = String.Empty
        txtPrimer.Text = String.Empty
        txt26.Text = String.Empty
        txtprimeraA.Text = String.Empty
        txtMayusculas.Text = String.Empty
        txtMinusculas.Text = String.Empty
        txtBorrarEspacios.Text = String.Empty

    End Sub
End Class