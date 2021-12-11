<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcedulaverificador
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
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.txtconfirmacion = New System.Windows.Forms.TextBox()
        Me.txtaccion = New System.Windows.Forms.TextBox()
        Me.btnverificar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(202, 21)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(59, 20)
        Me.txtcedula.TabIndex = 0
        '
        'txtconfirmacion
        '
        Me.txtconfirmacion.Location = New System.Drawing.Point(202, 72)
        Me.txtconfirmacion.Name = "txtconfirmacion"
        Me.txtconfirmacion.Size = New System.Drawing.Size(59, 20)
        Me.txtconfirmacion.TabIndex = 1
        '
        'txtaccion
        '
        Me.txtaccion.Location = New System.Drawing.Point(202, 124)
        Me.txtaccion.Name = "txtaccion"
        Me.txtaccion.Size = New System.Drawing.Size(59, 20)
        Me.txtaccion.TabIndex = 2
        '
        'btnverificar
        '
        Me.btnverificar.BackColor = System.Drawing.Color.LightGray
        Me.btnverificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnverificar.Location = New System.Drawing.Point(116, 124)
        Me.btnverificar.Name = "btnverificar"
        Me.btnverificar.Size = New System.Drawing.Size(68, 20)
        Me.btnverificar.TabIndex = 3
        Me.btnverificar.Text = "Verificar"
        Me.btnverificar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Salmon
        Me.Button2.Location = New System.Drawing.Point(19, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 20)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ingrese su cedula de identidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Confirma tu cedula de identidad:"
        '
        'frmcedulaverificador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MenuPrincipal.My.Resources.Resources.jovenes_cedula_3131
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(296, 156)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnverificar)
        Me.Controls.Add(Me.txtaccion)
        Me.Controls.Add(Me.txtconfirmacion)
        Me.Controls.Add(Me.txtcedula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmcedulaverificador"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.Text = "Verificador de Cedula"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents txtconfirmacion As System.Windows.Forms.TextBox
    Friend WithEvents txtaccion As System.Windows.Forms.TextBox
    Friend WithEvents btnverificar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
