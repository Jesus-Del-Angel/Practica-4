Public Class Form1
    Dim Formato As Boolean = True
    Dim boton_start As Boolean = False
    Dim tiempo_crono As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o As String = ""


        ' Este es el formato de 24h
        If Formato = True Then
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf Formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_mod = Time_o.Split(":")
        horas.Text = Time_mod(0)
        minutos.Text = Time_mod(1)
        segundos.Text = Time_mod(2)
        dias.Text = Day_o
        fecha.Text = Date_o

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label2.Text = ":" Then
            Label2.Text = ""
        ElseIf Label2.Text = "" Then
            Label2.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles FOTO.Click
        If config.Visible = False Then
            config.Visible = True
        ElseIf config.Visible = True Then
            config.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString()
        If color_texto = "Blanco" Then
            horas.ForeColor = Color.White
            minutos.ForeColor = Color.White
            dias.ForeColor = Color.White
            fecha.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label4.ForeColor = Color.White
            segundos.ForeColor = Color.White
        ElseIf color_texto = "Rojo" Then
            horas.ForeColor = Color.Red
            minutos.ForeColor = Color.Red
            dias.ForeColor = Color.Red
            fecha.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
            Label4.ForeColor = Color.Red
            segundos.ForeColor = Color.Red
        ElseIf color_texto = "Azul" Then
            horas.ForeColor = Color.Blue
            minutos.ForeColor = Color.Blue
            dias.ForeColor = Color.Blue
            fecha.ForeColor = Color.Blue
            Label2.ForeColor = Color.Blue
            Label4.ForeColor = Color.Blue
            segundos.ForeColor = Color.Blue
        ElseIf color_texto = "Amarillo" Then
            horas.ForeColor = Color.Yellow
            minutos.ForeColor = Color.Yellow
            dias.ForeColor = Color.Yellow
            fecha.ForeColor = Color.Yellow
            Label2.ForeColor = Color.Yellow
            Label4.ForeColor = Color.Yellow
            segundos.ForeColor = Color.Yellow
        ElseIf color_texto = "Verde" Then
            horas.ForeColor = Color.Green
            minutos.ForeColor = Color.Green
            dias.ForeColor = Color.Green
            fecha.ForeColor = Color.Green
            Label2.ForeColor = Color.Green
            Label4.ForeColor = Color.Green
            segundos.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Formato = True Then
            Button1.Text = "12h"
            Formato = False
        ElseIf Formato = False Then
            Button1.Text = "24h"
            Formato = True
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Label4.Text = ":" Then
            Label4.Text = ""
        ElseIf Label4.Text = "" Then
            Label4.Text = ":"
        End If
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If boton_start = False Then
            Timer4.Enabled = True
            boton_start = True
            Start.Text = "Stop"
        ElseIf boton_start = True Then
            Timer4.Enabled = False
            boton_start = False
            Start.Text = "Start"
        End If
    End Sub

    Private Sub restart_Click(sender As Object, e As EventArgs) Handles restart.Click
        tiempo_crono = 0
        Timer4.Enabled = False
        tiempo.Text = "0"
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        tiempo_crono = tiempo_crono + 1
        tiempo.Text = tiempo_crono.ToString()
    End Sub
End Class
