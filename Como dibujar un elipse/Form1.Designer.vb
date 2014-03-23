<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button_Graficar = New System.Windows.Forms.Button()
        Me.TextBox_Diametro = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox_Figuras = New System.Windows.Forms.ComboBox()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Graficar
        '
        Me.Button_Graficar.Location = New System.Drawing.Point(147, 351)
        Me.Button_Graficar.Name = "Button_Graficar"
        Me.Button_Graficar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Graficar.TabIndex = 1
        Me.Button_Graficar.Text = "Graficar"
        Me.Button_Graficar.UseVisualStyleBackColor = True
        '
        'TextBox_Diametro
        '
        Me.TextBox_Diametro.Location = New System.Drawing.Point(14, 353)
        Me.TextBox_Diametro.Name = "TextBox_Diametro"
        Me.TextBox_Diametro.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Diametro.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(14, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 316)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ComboBox_Figuras
        '
        Me.ComboBox_Figuras.FormattingEnabled = True
        Me.ComboBox_Figuras.Items.AddRange(New Object() {"Circulo", "Cuadrado", "Triangulo"})
        Me.ComboBox_Figuras.Location = New System.Drawing.Point(22, 20)
        Me.ComboBox_Figuras.Name = "ComboBox_Figuras"
        Me.ComboBox_Figuras.Size = New System.Drawing.Size(87, 21)
        Me.ComboBox_Figuras.TabIndex = 4
        Me.ComboBox_Figuras.Text = "Figuras"
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Location = New System.Drawing.Point(244, 351)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Limpiar.TabIndex = 5
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(90, 386)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(154, 15)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Para mas videos tutoriales."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(102, 408)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "©Programadores HN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(342, 432)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button_Limpiar)
        Me.Controls.Add(Me.ComboBox_Figuras)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox_Diametro)
        Me.Controls.Add(Me.Button_Graficar)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Graficar As System.Windows.Forms.Button
    Friend WithEvents TextBox_Diametro As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox_Figuras As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Limpiar As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
