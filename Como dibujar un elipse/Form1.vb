
Public Class Form1
    Dim a, b, diametro As Integer
    Dim figuras As String
    Dim dibujo As Graphics
    Dim lapiz1 As New Pen(Color.Red)
    Dim lapiz2 As New Pen(Color.Black)
    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        'trasladamos coordenadas 
        e.Graphics.TranslateTransform(100, 80)
        'Dibujamos los ejes X-Y
        e.Graphics.DrawLine(lapiz2, 100 * -1, 0, 300 * 2, 0)
        e.Graphics.DrawLine(lapiz2, 0, 300, 0, 80 * -1)
    End Sub
    'Metodo para graficar
    Private Sub Graficar()
        dibujo = PictureBox1.CreateGraphics 'declaramos área de dibujo
        'Trasladamos las figuras a las siguientes coordenadas 
        dibujo.TranslateTransform(100, 80)
        'Condicion que evalua el TexBox
        If TextBox_Diametro.Text = "" Then
            MessageBox.Show("Ingrese un diametro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox_Diametro.Focus()
        Else
            'Obtenemos el datos ingresado
            diametro = Convert.ToInt16(TextBox_Diametro.Text)
            'Ciclo for que dibuja los puntos +x
            For a = 0 To 200 Step 8
                dibujo.DrawLine(lapiz2, 5, a, -5, a)
            Next
            'Ciclo for que dibuja los puntos -Y
            For b = 0 To 200 Step 8
                dibujo.DrawLine(lapiz2, b, 5, b, -5)
            Next
            'Capturamos el items seleccionado en el comboBox
            figuras = ComboBox_Figuras.Text
            'Select Case que evaluá la variable figura
            Select Case figuras
                Case "Figuras"
                    MessageBox.Show("Seleccione una figura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case "Circulo"
                    dibujo.DrawEllipse(lapiz1, 0, 0, diametro, diametro)
                Case "Cuadrado"
                    dibujo.DrawRectangle(lapiz1, 0, 0, diametro, diametro)
                Case "Triangulo"
                    dibujo.DrawLine(lapiz1, 2, diametro, diametro, 2)
            End Select
        End If

    End Sub

    Private Sub Button_Graficar_Click(sender As Object, e As EventArgs) Handles Button_Graficar.Click
        Graficar()
    End Sub

    Private Sub Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        PictureBox1.Image = Nothing
        TextBox_Diametro.Text = ""
        ComboBox_Figuras.Text = "Figuras"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("www.youtube.com/alexjpz17")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Links.Add(9, 8, "")
    End Sub
End Class
