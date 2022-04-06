<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mallas
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
        Dim LineAnnotation1 As System.Windows.Forms.DataVisualization.Charting.LineAnnotation = New System.Windows.Forms.DataVisualization.Charting.LineAnnotation()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(120520.0R, 8.0R)
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(130520.0R, 10.0R)
        Me.PanelTituloFormacion = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelContenedorControlGrafico = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBTurno = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBOperario = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBActividad = New System.Windows.Forms.ComboBox()
        Me.CBSupervisor = New System.Windows.Forms.ComboBox()
        Me.CBTipoMalla = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TipoMalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChartMallas1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelTituloFormacion.SuspendLayout()
        Me.PanelContenedorControlGrafico.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartMallas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.PanelTituloFormacion.Size = New System.Drawing.Size(964, 37)
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
        Me.Label1.Size = New System.Drawing.Size(234, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Registro y Lavado de Mallas"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(936, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "X"
        '
        'PanelContenedorControlGrafico
        '
        Me.PanelContenedorControlGrafico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContenedorControlGrafico.BackColor = System.Drawing.Color.DarkGray
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Panel2)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Label9)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.CBTurno)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Label6)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Label8)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Label5)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.CBOperario)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.Label4)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.CBActividad)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.CBSupervisor)
        Me.PanelContenedorControlGrafico.Controls.Add(Me.CBTipoMalla)
        Me.PanelContenedorControlGrafico.Location = New System.Drawing.Point(12, 43)
        Me.PanelContenedorControlGrafico.Name = "PanelContenedorControlGrafico"
        Me.PanelContenedorControlGrafico.Size = New System.Drawing.Size(940, 311)
        Me.PanelContenedorControlGrafico.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.CheckBox7)
        Me.Panel2.Controls.Add(Me.CheckBox6)
        Me.Panel2.Controls.Add(Me.CheckBox5)
        Me.Panel2.Controls.Add(Me.CheckBox4)
        Me.Panel2.Controls.Add(Me.CheckBox3)
        Me.Panel2.Controls.Add(Me.CheckBox2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Location = New System.Drawing.Point(21, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(903, 226)
        Me.Panel2.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightBlue
        Me.Label10.Location = New System.Drawing.Point(269, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 20)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Codigo de Malla"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(412, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(584, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 24)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "..."
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.C_Coform_2.My.Resources.Resources.RDatos
        Me.Button1.Location = New System.Drawing.Point(833, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 58)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Registrar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox7.Location = New System.Drawing.Point(8, 43)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(108, 20)
        Me.CheckBox7.TabIndex = 29
        Me.CheckBox7.Text = "Malla Sucia"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox6.Location = New System.Drawing.Point(9, 196)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(257, 20)
        Me.CheckBox6.TabIndex = 28
        Me.CheckBox6.Text = "Malla Contaminada Con Polimero"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox5.Location = New System.Drawing.Point(9, 170)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(242, 20)
        Me.CheckBox5.TabIndex = 27
        Me.CheckBox5.Text = "Malla Con Border Deteriorados"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox4.Location = New System.Drawing.Point(8, 144)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(251, 20)
        Me.CheckBox4.TabIndex = 26
        Me.CheckBox4.Text = "Malla Con Agujero Considerable"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox3.Location = New System.Drawing.Point(8, 118)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(192, 20)
        Me.CheckBox3.TabIndex = 25
        Me.CheckBox3.Text = "Malla Con Agujero Leve"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox2.Location = New System.Drawing.Point(8, 92)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(171, 20)
        Me.CheckBox2.TabIndex = 24
        Me.CheckBox2.Text = "Malla Con Desgaste "
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Estados Malla"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox1.Location = New System.Drawing.Point(8, 66)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(89, 20)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "Malla OK"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(797, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Turno"
        '
        'CBTurno
        '
        Me.CBTurno.FormattingEnabled = True
        Me.CBTurno.Location = New System.Drawing.Point(800, 34)
        Me.CBTurno.Name = "CBTurno"
        Me.CBTurno.Size = New System.Drawing.Size(100, 21)
        Me.CBTurno.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(152, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Actividad"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(546, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Operario"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(291, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Supervisor"
        '
        'CBOperario
        '
        Me.CBOperario.FormattingEnabled = True
        Me.CBOperario.Location = New System.Drawing.Point(549, 34)
        Me.CBOperario.Name = "CBOperario"
        Me.CBOperario.Size = New System.Drawing.Size(215, 21)
        Me.CBOperario.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo de Malla"
        '
        'CBActividad
        '
        Me.CBActividad.FormattingEnabled = True
        Me.CBActividad.Location = New System.Drawing.Point(155, 34)
        Me.CBActividad.Name = "CBActividad"
        Me.CBActividad.Size = New System.Drawing.Size(100, 21)
        Me.CBActividad.TabIndex = 11
        '
        'CBSupervisor
        '
        Me.CBSupervisor.FormattingEnabled = True
        Me.CBSupervisor.Location = New System.Drawing.Point(294, 34)
        Me.CBSupervisor.Name = "CBSupervisor"
        Me.CBSupervisor.Size = New System.Drawing.Size(215, 21)
        Me.CBSupervisor.TabIndex = 16
        '
        'CBTipoMalla
        '
        Me.CBTipoMalla.FormattingEnabled = True
        Me.CBTipoMalla.Location = New System.Drawing.Point(21, 34)
        Me.CBTipoMalla.Name = "CBTipoMalla"
        Me.CBTipoMalla.Size = New System.Drawing.Size(100, 21)
        Me.CBTipoMalla.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoMalla, Me.codigo, Me.estado})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(385, 217)
        Me.DataGridView1.TabIndex = 19
        '
        'TipoMalla
        '
        Me.TipoMalla.HeaderText = "Tipo de Malla "
        Me.TipoMalla.Name = "TipoMalla"
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo Malla"
        Me.codigo.Name = "codigo"
        '
        'estado
        '
        Me.estado.HeaderText = "Estado de Malla"
        Me.estado.Name = "estado"
        '
        'ChartMallas1
        '
        Me.ChartMallas1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        LineAnnotation1.Name = "LineAnnotation1"
        LineAnnotation1.ToolTip = "hhhhh"
        Me.ChartMallas1.Annotations.Add(LineAnnotation1)
        Me.ChartMallas1.BorderlineColor = System.Drawing.SystemColors.InfoText
        ChartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ChartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Silver
        ChartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea1.Name = "ChartArea1"
        Me.ChartMallas1.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Gray
        Legend1.Name = "Legend1"
        Me.ChartMallas1.Legends.Add(Legend1)
        Me.ChartMallas1.Location = New System.Drawing.Point(454, 360)
        Me.ChartMallas1.Name = "ChartMallas1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.LegendToolTip = "Hola soy Leyenda"
        Series1.Name = "Series1"
        DataPoint1.IsValueShownAsLabel = False
        DataPoint1.IsVisibleInLegend = False
        DataPoint1.Label = "#VALX"
        DataPoint1.LabelBackColor = System.Drawing.Color.Lime
        DataPoint1.LabelBorderColor = System.Drawing.Color.PaleTurquoise
        DataPoint1.LabelToolTip = ""
        DataPoint1.LegendText = ""
        DataPoint1.LegendToolTip = ""
        DataPoint2.IsValueShownAsLabel = False
        DataPoint2.IsVisibleInLegend = False
        DataPoint2.Label = "#VALX"
        DataPoint2.LabelToolTip = "#VALX"
        DataPoint2.LegendToolTip = ""
        Series1.Points.Add(DataPoint1)
        Series1.Points.Add(DataPoint2)
        Series1.ToolTip = "Area Mapa:#LABEL"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Me.ChartMallas1.Series.Add(Series1)
        Me.ChartMallas1.Size = New System.Drawing.Size(498, 270)
        Me.ChartMallas1.TabIndex = 20
        Me.ChartMallas1.Text = "Chart1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 360)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(427, 270)
        Me.Panel1.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(21, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(385, 25)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Validar Estado de Mallas"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Mallas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(964, 721)
        Me.Controls.Add(Me.ChartMallas1)
        Me.Controls.Add(Me.PanelContenedorControlGrafico)
        Me.Controls.Add(Me.PanelTituloFormacion)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Mallas"
        Me.Text = "Mallas"
        Me.PanelTituloFormacion.ResumeLayout(False)
        Me.PanelTituloFormacion.PerformLayout()
        Me.PanelContenedorControlGrafico.ResumeLayout(False)
        Me.PanelContenedorControlGrafico.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartMallas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTituloFormacion As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelContenedorControlGrafico As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBTurno As ComboBox
    Friend WithEvents CBOperario As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CBActividad As ComboBox
    Friend WithEvents CBSupervisor As ComboBox
    Friend WithEvents CBTipoMalla As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents ChartMallas1 As DataVisualization.Charting.Chart
    Friend WithEvents TipoMalla As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
End Class
