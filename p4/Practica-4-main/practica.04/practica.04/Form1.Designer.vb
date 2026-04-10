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
        Me.components = New System.ComponentModel.Container()
        Me.horas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.minutos = New System.Windows.Forms.Label()
        Me.dias = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.config = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.restart = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.tiempo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.segundos = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FOTO = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.config.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'horas
        '
        Me.horas.AutoSize = True
        Me.horas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.horas.Location = New System.Drawing.Point(84, 114)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(127, 91)
        Me.horas.TabIndex = 0
        Me.horas.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(199, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 91)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":"
        '
        'minutos
        '
        Me.minutos.AutoSize = True
        Me.minutos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.minutos.Location = New System.Drawing.Point(247, 114)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(127, 91)
        Me.minutos.TabIndex = 2
        Me.minutos.Text = "00"
        '
        'dias
        '
        Me.dias.AutoSize = True
        Me.dias.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dias.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dias.Location = New System.Drawing.Point(207, 196)
        Me.dias.Name = "dias"
        Me.dias.Size = New System.Drawing.Size(128, 46)
        Me.dias.TabIndex = 3
        Me.dias.Text = "Lunes"
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.fecha.Location = New System.Drawing.Point(82, 251)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(404, 46)
        Me.fecha.TabIndex = 4
        Me.fecha.Text = "09 de marzo del 2026"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'config
        '
        Me.config.Controls.Add(Me.ComboBox1)
        Me.config.Controls.Add(Me.Button1)
        Me.config.Controls.Add(Me.Label1)
        Me.config.Location = New System.Drawing.Point(81, 93)
        Me.config.Name = "config"
        Me.config.Size = New System.Drawing.Size(479, 248)
        Me.config.TabIndex = 7
        Me.config.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Blanco", "Rojo", "Azul", "Amarillo", "Verde"})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 103)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "12h/24h"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Configuraciones"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.restart)
        Me.Panel1.Controls.Add(Me.Start)
        Me.Panel1.Controls.Add(Me.tiempo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(81, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 248)
        Me.Panel1.TabIndex = 10
        Me.Panel1.Visible = False
        '
        'restart
        '
        Me.restart.Location = New System.Drawing.Point(285, 179)
        Me.restart.Name = "restart"
        Me.restart.Size = New System.Drawing.Size(75, 23)
        Me.restart.TabIndex = 3
        Me.restart.Text = "Restart"
        Me.restart.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(94, 179)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 2
        Me.Start.Text = "Start/Stop"
        Me.Start.UseVisualStyleBackColor = True
        '
        'tiempo
        '
        Me.tiempo.AutoSize = True
        Me.tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiempo.Location = New System.Drawing.Point(169, 117)
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Size = New System.Drawing.Size(120, 31)
        Me.tiempo.TabIndex = 1
        Me.tiempo.Text = "00:00:00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 63)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cronometro"
        '
        'segundos
        '
        Me.segundos.AutoSize = True
        Me.segundos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.segundos.Location = New System.Drawing.Point(433, 114)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(127, 91)
        Me.segundos.TabIndex = 8
        Me.segundos.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(380, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 91)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = ":"
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(82, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 249)
        Me.Panel2.TabIndex = 12
        Me.Panel2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.practica._04.My.Resources.Resources.reloj_de_arena
        Me.PictureBox3.Location = New System.Drawing.Point(291, 347)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(73, 76)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.practica._04.My.Resources.Resources.images__1_
        Me.PictureBox2.Location = New System.Drawing.Point(370, 348)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'FOTO
        '
        Me.FOTO.Image = Global.practica._04.My.Resources.Resources.congif
        Me.FOTO.Location = New System.Drawing.Point(449, 347)
        Me.FOTO.Name = "FOTO"
        Me.FOTO.Size = New System.Drawing.Size(83, 77)
        Me.FOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FOTO.TabIndex = 6
        Me.FOTO.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.practica._04.My.Resources.Resources.reloj_bien
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(622, 586)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(312, 63)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cronometro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(203, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 31)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "00:00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 564)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.config)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.segundos)
        Me.Controls.Add(Me.FOTO)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.dias)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Reloj digital"
        Me.config.ResumeLayout(False)
        Me.config.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents horas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents minutos As Label
    Friend WithEvents dias As Label
    Friend WithEvents fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents FOTO As PictureBox
    Friend WithEvents config As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents segundos As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tiempo As Label
    Friend WithEvents restart As Button
    Friend WithEvents Start As Button
    Friend WithEvents Timer4 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
