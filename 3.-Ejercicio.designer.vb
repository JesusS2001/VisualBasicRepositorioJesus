<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio3
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBucarHora = New System.Windows.Forms.Button()
        Me.labHora = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.Timer(Me.components)
        Me.txtAlmuerzo = New System.Windows.Forms.TextBox()
        Me.txtMerienda = New System.Windows.Forms.TextBox()
        Me.txtCena = New System.Windows.Forms.TextBox()
        Me.txtDesayuno = New System.Windows.Forms.TextBox()
        Me.txtBebidas = New System.Windows.Forms.TextBox()
        Me.txtAccion = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBucarHora
        '
        Me.btnBucarHora.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBucarHora.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBucarHora.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBucarHora.Location = New System.Drawing.Point(608, 73)
        Me.btnBucarHora.Name = "btnBucarHora"
        Me.btnBucarHora.Size = New System.Drawing.Size(83, 36)
        Me.btnBucarHora.TabIndex = 7
        Me.btnBucarHora.Text = "Buscar"
        Me.btnBucarHora.UseVisualStyleBackColor = False
        '
        'labHora
        '
        Me.labHora.BackColor = System.Drawing.Color.LightSkyBlue
        Me.labHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labHora.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labHora.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labHora.Location = New System.Drawing.Point(12, 77)
        Me.labHora.Name = "labHora"
        Me.labHora.Size = New System.Drawing.Size(326, 29)
        Me.labHora.TabIndex = 6
        Me.labHora.Text = "Introduce la Hora "
        Me.labHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Tomato
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(408, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bienvenido "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(357, 83)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(222, 20)
        Me.txtHora.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(12, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Menu"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTiempo
        '
        '
        'txtAlmuerzo
        '
        Me.txtAlmuerzo.AutoCompleteCustomSource.AddRange(New String() {"Pabellon ", "Hallaca", "Pollo asado"})
        Me.txtAlmuerzo.Location = New System.Drawing.Point(322, 195)
        Me.txtAlmuerzo.Multiline = True
        Me.txtAlmuerzo.Name = "txtAlmuerzo"
        Me.txtAlmuerzo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlmuerzo.Size = New System.Drawing.Size(132, 79)
        Me.txtAlmuerzo.TabIndex = 12
        '
        'txtMerienda
        '
        Me.txtMerienda.AutoCompleteCustomSource.AddRange(New String() {"Torta", "Arroz con leche", "Dulce de guayaba"})
        Me.txtMerienda.Location = New System.Drawing.Point(473, 195)
        Me.txtMerienda.Multiline = True
        Me.txtMerienda.Name = "txtMerienda"
        Me.txtMerienda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMerienda.Size = New System.Drawing.Size(129, 79)
        Me.txtMerienda.TabIndex = 13
        '
        'txtCena
        '
        Me.txtCena.AutoCompleteCustomSource.AddRange(New String() {"Pizza", "Hamburgesa", "Ramen"})
        Me.txtCena.Location = New System.Drawing.Point(617, 195)
        Me.txtCena.Multiline = True
        Me.txtCena.Name = "txtCena"
        Me.txtCena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCena.Size = New System.Drawing.Size(138, 79)
        Me.txtCena.TabIndex = 14
        '
        'txtDesayuno
        '
        Me.txtDesayuno.AutoCompleteCustomSource.AddRange(New String() {"Pabellon ", "Hallaca", "Pollo asado"})
        Me.txtDesayuno.Location = New System.Drawing.Point(154, 195)
        Me.txtDesayuno.Multiline = True
        Me.txtDesayuno.Name = "txtDesayuno"
        Me.txtDesayuno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDesayuno.Size = New System.Drawing.Size(149, 79)
        Me.txtDesayuno.TabIndex = 15
        '
        'txtBebidas
        '
        Me.txtBebidas.AutoCompleteCustomSource.AddRange(New String() {"Pizza", "Hamburgesa", "Ramen"})
        Me.txtBebidas.Location = New System.Drawing.Point(773, 195)
        Me.txtBebidas.Multiline = True
        Me.txtBebidas.Name = "txtBebidas"
        Me.txtBebidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBebidas.Size = New System.Drawing.Size(138, 79)
        Me.txtBebidas.TabIndex = 16
        '
        'txtAccion
        '
        Me.txtAccion.Location = New System.Drawing.Point(585, 83)
        Me.txtAccion.Name = "txtAccion"
        Me.txtAccion.Size = New System.Drawing.Size(10, 20)
        Me.txtAccion.TabIndex = 10
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBorrar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBorrar.Location = New System.Drawing.Point(697, 73)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(83, 36)
        Me.btnBorrar.TabIndex = 17
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'frmEjercicio3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MenuPrincipal.My.Resources.Resources._290719_525624_PIYDKD_830
        Me.ClientSize = New System.Drawing.Size(962, 391)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.txtBebidas)
        Me.Controls.Add(Me.txtDesayuno)
        Me.Controls.Add(Me.txtCena)
        Me.Controls.Add(Me.txtMerienda)
        Me.Controls.Add(Me.txtAlmuerzo)
        Me.Controls.Add(Me.txtAccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.btnBucarHora)
        Me.Controls.Add(Me.labHora)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEjercicio3"
        Me.Text = "3.-Ejercicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBucarHora As System.Windows.Forms.Button
    Friend WithEvents labHora As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtTiempo As System.Windows.Forms.Timer
    Friend WithEvents txtAlmuerzo As System.Windows.Forms.TextBox
    Friend WithEvents txtMerienda As System.Windows.Forms.TextBox
    Friend WithEvents txtCena As System.Windows.Forms.TextBox
    Friend WithEvents txtDesayuno As System.Windows.Forms.TextBox
    Friend WithEvents txtBebidas As System.Windows.Forms.TextBox
    Friend WithEvents txtAccion As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
End Class
