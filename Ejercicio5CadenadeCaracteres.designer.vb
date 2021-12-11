<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcadenadecaracteres
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCadena = New System.Windows.Forms.TextBox()
        Me.txtLongitud = New System.Windows.Forms.TextBox()
        Me.txtUltimo = New System.Windows.Forms.TextBox()
        Me.txtPrimer = New System.Windows.Forms.TextBox()
        Me.txt26 = New System.Windows.Forms.TextBox()
        Me.txtprimeraA = New System.Windows.Forms.TextBox()
        Me.txtMayusculas = New System.Windows.Forms.TextBox()
        Me.txtMinusculas = New System.Windows.Forms.TextBox()
        Me.txtBorrarEspacios = New System.Windows.Forms.TextBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadena:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Longitud:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Último Carácter:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Primer Carácter:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "2do al 6to Carácter:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Posicion de la 1era letra A:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mayúsculas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Minúsculas:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Borrar Espacios:"
        '
        'txtCadena
        '
        Me.txtCadena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCadena.Location = New System.Drawing.Point(166, 20)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Size = New System.Drawing.Size(178, 20)
        Me.txtCadena.TabIndex = 9
        '
        'txtLongitud
        '
        Me.txtLongitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLongitud.Location = New System.Drawing.Point(166, 56)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(145, 20)
        Me.txtLongitud.TabIndex = 10
        '
        'txtUltimo
        '
        Me.txtUltimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUltimo.Location = New System.Drawing.Point(166, 91)
        Me.txtUltimo.Name = "txtUltimo"
        Me.txtUltimo.Size = New System.Drawing.Size(145, 20)
        Me.txtUltimo.TabIndex = 11
        '
        'txtPrimer
        '
        Me.txtPrimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrimer.Location = New System.Drawing.Point(166, 131)
        Me.txtPrimer.Name = "txtPrimer"
        Me.txtPrimer.Size = New System.Drawing.Size(145, 20)
        Me.txtPrimer.TabIndex = 12
        '
        'txt26
        '
        Me.txt26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt26.Location = New System.Drawing.Point(166, 172)
        Me.txt26.Name = "txt26"
        Me.txt26.Size = New System.Drawing.Size(145, 20)
        Me.txt26.TabIndex = 13
        '
        'txtprimeraA
        '
        Me.txtprimeraA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprimeraA.Location = New System.Drawing.Point(166, 213)
        Me.txtprimeraA.Name = "txtprimeraA"
        Me.txtprimeraA.Size = New System.Drawing.Size(145, 20)
        Me.txtprimeraA.TabIndex = 14
        '
        'txtMayusculas
        '
        Me.txtMayusculas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMayusculas.Location = New System.Drawing.Point(166, 252)
        Me.txtMayusculas.Name = "txtMayusculas"
        Me.txtMayusculas.Size = New System.Drawing.Size(145, 20)
        Me.txtMayusculas.TabIndex = 15
        '
        'txtMinusculas
        '
        Me.txtMinusculas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMinusculas.Location = New System.Drawing.Point(166, 292)
        Me.txtMinusculas.Name = "txtMinusculas"
        Me.txtMinusculas.Size = New System.Drawing.Size(145, 20)
        Me.txtMinusculas.TabIndex = 16
        '
        'txtBorrarEspacios
        '
        Me.txtBorrarEspacios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBorrarEspacios.Location = New System.Drawing.Point(166, 327)
        Me.txtBorrarEspacios.Name = "txtBorrarEspacios"
        Me.txtBorrarEspacios.Size = New System.Drawing.Size(145, 20)
        Me.txtBorrarEspacios.TabIndex = 17
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Location = New System.Drawing.Point(359, 20)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(93, 20)
        Me.btnProcesar.TabIndex = 18
        Me.btnProcesar.Text = "PROCESAR"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(359, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 20)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmcadenadecaracteres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MenuPrincipal.My.Resources.Resources.pngtree_academic_conference_background_image_2647331
        Me.ClientSize = New System.Drawing.Size(464, 376)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.txtBorrarEspacios)
        Me.Controls.Add(Me.txtMinusculas)
        Me.Controls.Add(Me.txtMayusculas)
        Me.Controls.Add(Me.txtprimeraA)
        Me.Controls.Add(Me.txt26)
        Me.Controls.Add(Me.txtPrimer)
        Me.Controls.Add(Me.txtUltimo)
        Me.Controls.Add(Me.txtLongitud)
        Me.Controls.Add(Me.txtCadena)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmcadenadecaracteres"
        Me.ShowIcon = False
        Me.Text = "Funciones con Cadenas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCadena As System.Windows.Forms.TextBox
    Friend WithEvents txtLongitud As System.Windows.Forms.TextBox
    Friend WithEvents txtUltimo As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimer As System.Windows.Forms.TextBox
    Friend WithEvents txt26 As System.Windows.Forms.TextBox
    Friend WithEvents txtprimeraA As System.Windows.Forms.TextBox
    Friend WithEvents txtMayusculas As System.Windows.Forms.TextBox
    Friend WithEvents txtMinusculas As System.Windows.Forms.TextBox
    Friend WithEvents txtBorrarEspacios As System.Windows.Forms.TextBox
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
