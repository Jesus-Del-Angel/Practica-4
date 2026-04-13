Public Class Form1
    Dim Formato As Boolean = True
    Dim boton_start As Boolean = False
    Dim tiempo_crono As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()


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
    '=====================
    'Codigo del Cronometro
    '=====================

    Private startTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If boton_start = False Then
            Timer4.Enabled = True
            boton_start = True
            Start.Text = "Stop"
            startTime = DateTime.Now
        ElseIf boton_start = True Then
            Timer4.Enabled = False
            boton_start = False
            Start.Text = "Start"
            elapsed += DateTime.Now - startTime
        End If
    End Sub

    Private Sub restart_Click(sender As Object, e As EventArgs) Handles restart.Click
        elapsed = TimeSpan.Zero
        Timer4.Enabled = False
        tiempo.Text = "00:00:00.00"
        boton_start = False
        Start.Text = "Start"

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim current = elapsed + (DateTime.Now - startTime)
        tiempo.Text = current.ToString("hh\:mm\:ss\.ff")

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    '=======================
    'Codigo del Temporizador
    '=======================

    Private tiempoRestante As TimeSpan = TimeSpan.Zero
    Private temporizadorActivo As Boolean = False

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Panel2.Visible = True Then
            Panel2.Visible = False
        ElseIf Panel2.Visible = False Then
            Panel2.Visible = True
        End If
    End Sub

    Private Sub Min1_Click(sender As Object, e As EventArgs) Handles Min1.Click
        tiempoRestante = tiempoRestante.Add(TimeSpan.FromMinutes(1))
        Label6.Text = tiempoRestante.ToString("mm\:ss")
    End Sub

    Private Sub Min5_Click(sender As Object, e As EventArgs) Handles Min5.Click
        tiempoRestante = tiempoRestante.Add(TimeSpan.FromMinutes(5))
        Label6.Text = tiempoRestante.ToString("mm\:ss")
    End Sub

    Private Sub empezar_Click(sender As Object, e As EventArgs) Handles empezar.Click
        If tiempoRestante = TimeSpan.Zero Then
            MessageBox.Show("Agrega tiempo primero.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If temporizadorActivo = False Then
            Timer5.Enabled = True
            temporizadorActivo = False
            empezar.Text = "Stop"
        Else
            Timer5.Enabled = False
            temporizadorActivo = False
            empezar.Text = "Start"
        End If
    End Sub

    Private Sub Reiniciar_Click(sender As Object, e As EventArgs) Handles Reiniciar.Click
        Timer5.Enabled = False
        tiempoRestante = TimeSpan.Zero
        temporizadorActivo = False
        Label6.Text = "00:00"
        empezar.Text = "Start"
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If tiempoRestante = tiempoRestante.Subtract(TimeSpan.FromMilliseconds(Timer5.Interval)) Then
            Label6.Text = tiempoRestante.ToString("mm\:ss")
        Else
            'Tiempo TERMINADO
            Timer5.Enabled = False
            temporizadorActivo = False
            tiempoRestante = TimeSpan.Zero
            Label6.Text = "00:00"
            empezar.Text = "Start"

            MessageBox.Show("⌛ ¡Tiempo TERMINADO!", "Temporizador",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class
