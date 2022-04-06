<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Extrusor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelTituloFormacion = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelOperario = New System.Windows.Forms.Label()
        Me.LabelSupervisor = New System.Windows.Forms.Label()
        Me.LabelTurno = New System.Windows.Forms.Label()
        Me.CBReferencia = New System.Windows.Forms.ComboBox()
        Me.CBOperario = New System.Windows.Forms.ComboBox()
        Me.CBSupervisor = New System.Windows.Forms.ComboBox()
        Me.CBTurno = New System.Windows.Forms.ComboBox()
        Me.PanelVariables = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PanelTituloFormacion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelVariables.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTituloFormacion
        '
        Me.PanelTituloFormacion.BackColor = System.Drawing.SystemColors.GrayText
        Me.PanelTituloFormacion.Controls.Add(Me.Label1)
        Me.PanelTituloFormacion.Controls.Add(Me.Label2)
        Me.PanelTituloFormacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTituloFormacion.Location = New System.Drawing.Point(0, 0)
        Me.PanelTituloFormacion.Name = "PanelTituloFormacion"
        Me.PanelTituloFormacion.Size = New System.Drawing.Size(940, 37)
        Me.PanelTituloFormacion.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Centerlining Extrusor"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(912, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LabelOperario)
        Me.Panel1.Controls.Add(Me.LabelSupervisor)
        Me.Panel1.Controls.Add(Me.LabelTurno)
        Me.Panel1.Controls.Add(Me.CBReferencia)
        Me.Panel1.Controls.Add(Me.CBOperario)
        Me.Panel1.Controls.Add(Me.CBSupervisor)
        Me.Panel1.Controls.Add(Me.CBTurno)
        Me.Panel1.Location = New System.Drawing.Point(4, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 92)
        Me.Panel1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Referencia"
        '
        'LabelOperario
        '
        Me.LabelOperario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelOperario.AutoSize = True
        Me.LabelOperario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOperario.ForeColor = System.Drawing.Color.Black
        Me.LabelOperario.Location = New System.Drawing.Point(548, 18)
        Me.LabelOperario.Name = "LabelOperario"
        Me.LabelOperario.Size = New System.Drawing.Size(78, 20)
        Me.LabelOperario.TabIndex = 7
        Me.LabelOperario.Text = "Operario"
        '
        'LabelSupervisor
        '
        Me.LabelSupervisor.AutoSize = True
        Me.LabelSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSupervisor.ForeColor = System.Drawing.Color.Black
        Me.LabelSupervisor.Location = New System.Drawing.Point(152, 18)
        Me.LabelSupervisor.Name = "LabelSupervisor"
        Me.LabelSupervisor.Size = New System.Drawing.Size(94, 20)
        Me.LabelSupervisor.TabIndex = 6
        Me.LabelSupervisor.Text = "Supervisor"
        '
        'LabelTurno
        '
        Me.LabelTurno.AutoSize = True
        Me.LabelTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTurno.ForeColor = System.Drawing.Color.Black
        Me.LabelTurno.Location = New System.Drawing.Point(5, 18)
        Me.LabelTurno.Name = "LabelTurno"
        Me.LabelTurno.Size = New System.Drawing.Size(55, 20)
        Me.LabelTurno.TabIndex = 5
        Me.LabelTurno.Text = "Turno"
        '
        'CBReferencia
        '
        Me.CBReferencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBReferencia.FormattingEnabled = True
        Me.CBReferencia.Location = New System.Drawing.Point(108, 56)
        Me.CBReferencia.Name = "CBReferencia"
        Me.CBReferencia.Size = New System.Drawing.Size(810, 21)
        Me.CBReferencia.TabIndex = 3
        '
        'CBOperario
        '
        Me.CBOperario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBOperario.FormattingEnabled = True
        Me.CBOperario.Location = New System.Drawing.Point(634, 16)
        Me.CBOperario.Name = "CBOperario"
        Me.CBOperario.Size = New System.Drawing.Size(283, 21)
        Me.CBOperario.TabIndex = 2
        '
        'CBSupervisor
        '
        Me.CBSupervisor.FormattingEnabled = True
        Me.CBSupervisor.Location = New System.Drawing.Point(252, 17)
        Me.CBSupervisor.Name = "CBSupervisor"
        Me.CBSupervisor.Size = New System.Drawing.Size(283, 21)
        Me.CBSupervisor.TabIndex = 1
        '
        'CBTurno
        '
        Me.CBTurno.FormattingEnabled = True
        Me.CBTurno.Location = New System.Drawing.Point(66, 16)
        Me.CBTurno.Name = "CBTurno"
        Me.CBTurno.Size = New System.Drawing.Size(71, 21)
        Me.CBTurno.TabIndex = 0
        '
        'PanelVariables
        '
        Me.PanelVariables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVariables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelVariables.Controls.Add(Me.Button1)
        Me.PanelVariables.Controls.Add(Me.Label20)
        Me.PanelVariables.Controls.Add(Me.TextBox17)
        Me.PanelVariables.Controls.Add(Me.Label19)
        Me.PanelVariables.Controls.Add(Me.Label18)
        Me.PanelVariables.Controls.Add(Me.Label17)
        Me.PanelVariables.Controls.Add(Me.Label16)
        Me.PanelVariables.Controls.Add(Me.Label15)
        Me.PanelVariables.Controls.Add(Me.Label14)
        Me.PanelVariables.Controls.Add(Me.Label13)
        Me.PanelVariables.Controls.Add(Me.Label12)
        Me.PanelVariables.Controls.Add(Me.Label11)
        Me.PanelVariables.Controls.Add(Me.Label10)
        Me.PanelVariables.Controls.Add(Me.Label9)
        Me.PanelVariables.Controls.Add(Me.Label8)
        Me.PanelVariables.Controls.Add(Me.Label7)
        Me.PanelVariables.Controls.Add(Me.Label6)
        Me.PanelVariables.Controls.Add(Me.TextBox16)
        Me.PanelVariables.Controls.Add(Me.TextBox15)
        Me.PanelVariables.Controls.Add(Me.TextBox14)
        Me.PanelVariables.Controls.Add(Me.TextBox13)
        Me.PanelVariables.Controls.Add(Me.TextBox12)
        Me.PanelVariables.Controls.Add(Me.TextBox11)
        Me.PanelVariables.Controls.Add(Me.TextBox10)
        Me.PanelVariables.Controls.Add(Me.TextBox9)
        Me.PanelVariables.Controls.Add(Me.TextBox8)
        Me.PanelVariables.Controls.Add(Me.TextBox7)
        Me.PanelVariables.Controls.Add(Me.TextBox6)
        Me.PanelVariables.Controls.Add(Me.TextBox5)
        Me.PanelVariables.Controls.Add(Me.TextBox4)
        Me.PanelVariables.Controls.Add(Me.TextBox3)
        Me.PanelVariables.Controls.Add(Me.TextBox2)
        Me.PanelVariables.Controls.Add(Me.TextBox1)
        Me.PanelVariables.Controls.Add(Me.Label5)
        Me.PanelVariables.Controls.Add(Me.Label4)
        Me.PanelVariables.Location = New System.Drawing.Point(5, 140)
        Me.PanelVariables.Name = "PanelVariables"
        Me.PanelVariables.Size = New System.Drawing.Size(932, 525)
        Me.PanelVariables.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.C_Coform_2.My.Resources.Resources.RDatos
        Me.Button1.Location = New System.Drawing.Point(867, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 58)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "Registrar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 407)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(257, 15)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Presión de Salida Compresor Aire de Proceso"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(18, 381)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(164, 15)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Temperatura Tuberia Zona 2"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 355)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(164, 15)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Temperatura Tuberia Zona 1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 329)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 15)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Diferencia de Presion Filtro"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 303)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(220, 15)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Presion  Filtro de Polimero en la Salida"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 277)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(228, 15)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Presion  Filtro de Polimero en la Entrada"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 15)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Temperatura  Filtro Inferior"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 15)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Temperatura  Filtro Superior"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "RPM del Extrusor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Temperatura  Brida"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Temperatura  Extrusor  Zona 6"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Temperatura  Extrusor  Zona 5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Temperatura  Extrusor  Zona 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Temperatura  Extrusor  Zona 3"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(279, 404)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(80, 20)
        Me.TextBox16.TabIndex = 17
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(279, 378)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(80, 20)
        Me.TextBox15.TabIndex = 16
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(279, 352)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(80, 20)
        Me.TextBox14.TabIndex = 15
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(279, 326)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(80, 20)
        Me.TextBox13.TabIndex = 14
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(279, 300)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(80, 20)
        Me.TextBox12.TabIndex = 13
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(279, 274)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(80, 20)
        Me.TextBox11.TabIndex = 12
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(279, 248)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(80, 20)
        Me.TextBox10.TabIndex = 11
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(279, 222)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(80, 20)
        Me.TextBox9.TabIndex = 10
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(279, 196)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(80, 20)
        Me.TextBox8.TabIndex = 9
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(279, 170)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(80, 20)
        Me.TextBox7.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(279, 144)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(80, 20)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(279, 118)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(80, 20)
        Me.TextBox5.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(279, 92)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(80, 20)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(279, 66)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(80, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(279, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(80, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(279, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Temperatura  Extrusor  Zona 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Temperatura  Extrusor  Zona 1"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(279, 430)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(80, 20)
        Me.TextBox17.TabIndex = 32
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(18, 433)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 15)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Temperatura Enclouser"
        '
        'Extrusor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 721)
        Me.Controls.Add(Me.PanelVariables)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTituloFormacion)
        Me.Name = "Extrusor"
        Me.Text = "Extrusor"
        Me.PanelTituloFormacion.ResumeLayout(False)
        Me.PanelTituloFormacion.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelVariables.ResumeLayout(False)
        Me.PanelVariables.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTituloFormacion As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelOperario As Label
    Friend WithEvents LabelSupervisor As Label
    Friend WithEvents LabelTurno As Label
    Friend WithEvents CBReferencia As ComboBox
    Friend WithEvents CBOperario As ComboBox
    Friend WithEvents CBSupervisor As ComboBox
    Friend WithEvents CBTurno As ComboBox
    Friend WithEvents PanelVariables As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox17 As TextBox
End Class
