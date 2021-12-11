<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio15
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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.txtNumero1 = New System.Windows.Forms.Label()
        Me.labResultado = New System.Windows.Forms.Label()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(39, 86)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 0
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(183, 82)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 1
        Me.btncalcular.Text = "calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'txtNumero1
        '
        Me.txtNumero1.AutoSize = True
        Me.txtNumero1.Location = New System.Drawing.Point(27, 52)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(101, 13)
        Me.txtNumero1.TabIndex = 2
        Me.txtNumero1.Text = "Introduce el numero"
        '
        'labResultado
        '
        Me.labResultado.AutoSize = True
        Me.labResultado.Location = New System.Drawing.Point(27, 129)
        Me.labResultado.Name = "labResultado"
        Me.labResultado.Size = New System.Drawing.Size(105, 13)
        Me.labResultado.TabIndex = 3
        Me.labResultado.Text = "Cuantos digitos son: "
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Location = New System.Drawing.Point(183, 119)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnReiniciar.TabIndex = 4
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'frmEjercicio15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MenuPrincipal.My.Resources.Resources.numero
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.labResultado)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtNumero)
        Me.Name = "frmEjercicio15"
        Me.Text = "15.-Ejercicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents btncalcular As System.Windows.Forms.Button
    Friend WithEvents txtNumero1 As System.Windows.Forms.Label
    Friend WithEvents labResultado As System.Windows.Forms.Label
    Friend WithEvents btnReiniciar As System.Windows.Forms.Button
End Class
