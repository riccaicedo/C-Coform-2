<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelBarraProgreso = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PanelMenuCenterlining = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnMallas = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.Separador2 = New System.Windows.Forms.Panel()
        Me.Separador1 = New System.Windows.Forms.Panel()
        Me.LetraCoform = New System.Windows.Forms.PictureBox()
        Me.LogoCoform = New System.Windows.Forms.PictureBox()
        Me.subMenu = New System.Windows.Forms.Panel()
        Me.LabelPulpa = New System.Windows.Forms.Label()
        Me.LabelWinder = New System.Windows.Forms.Label()
        Me.LabelExtrusor = New System.Windows.Forms.Label()
        Me.LabelFormacion = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnPulpa = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnWinder = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnExtrusor = New System.Windows.Forms.Button()
        Me.btnFormacion = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btnCenterlining = New System.Windows.Forms.Button()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.LogoKCC = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmBarraProgreso = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedor.SuspendLayout()
        Me.PanelBarraProgreso.SuspendLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenuCenterlining.SuspendLayout()
        CType(Me.LetraCoform, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoCoform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.subMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.LogoKCC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.PanelBarraProgreso)
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenuCenterlining)
        Me.PanelContenedor.Controls.Add(Me.PanelCabecera)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1165, 726)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelBarraProgreso
        '
        Me.PanelBarraProgreso.Controls.Add(Me.btnGuardar)
        Me.PanelBarraProgreso.Controls.Add(Me.ProgressBar1)
        Me.PanelBarraProgreso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBarraProgreso.Location = New System.Drawing.Point(220, 676)
        Me.PanelBarraProgreso.Name = "PanelBarraProgreso"
        Me.PanelBarraProgreso.Size = New System.Drawing.Size(945, 50)
        Me.PanelBarraProgreso.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Image = Global.C_Coform_2.My.Resources.Resources.Guardar3
        Me.btnGuardar.Location = New System.Drawing.Point(896, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(44, 43)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(885, 40)
        Me.ProgressBar1.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.Gray
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(220, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(945, 686)
        Me.PanelFormularios.TabIndex = 2
        '
        'PanelMenuCenterlining
        '
        Me.PanelMenuCenterlining.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelMenuCenterlining.Controls.Add(Me.Panel8)
        Me.PanelMenuCenterlining.Controls.Add(Me.btnMallas)
        Me.PanelMenuCenterlining.Controls.Add(Me.Panel7)
        Me.PanelMenuCenterlining.Controls.Add(Me.btnVer)
        Me.PanelMenuCenterlining.Controls.Add(Me.Separador2)
        Me.PanelMenuCenterlining.Controls.Add(Me.Separador1)
        Me.PanelMenuCenterlining.Controls.Add(Me.LetraCoform)
        Me.PanelMenuCenterlining.Controls.Add(Me.LogoCoform)
        Me.PanelMenuCenterlining.Controls.Add(Me.subMenu)
        Me.PanelMenuCenterlining.Controls.Add(Me.Panel2)
        Me.PanelMenuCenterlining.Controls.Add(Me.Panel1)
        Me.PanelMenuCenterlining.Controls.Add(Me.btnMenu)
        Me.PanelMenuCenterlining.Controls.Add(Me.btnCenterlining)
        Me.PanelMenuCenterlining.Controls.Add(Me.btnGraficar)
        Me.PanelMenuCenterlining.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuCenterlining.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenuCenterlining.Name = "PanelMenuCenterlining"
        Me.PanelMenuCenterlining.Size = New System.Drawing.Size(220, 686)
        Me.PanelMenuCenterlining.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel8.Location = New System.Drawing.Point(3, 238)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 50)
        Me.Panel8.TabIndex = 6
        '
        'btnMallas
        '
        Me.btnMallas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMallas.FlatAppearance.BorderSize = 0
        Me.btnMallas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnMallas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMallas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMallas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMallas.ForeColor = System.Drawing.Color.White
        Me.btnMallas.Image = Global.C_Coform_2.My.Resources.Resources.Malla
        Me.btnMallas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMallas.Location = New System.Drawing.Point(0, 238)
        Me.btnMallas.Name = "btnMallas"
        Me.btnMallas.Size = New System.Drawing.Size(220, 50)
        Me.btnMallas.TabIndex = 9
        Me.btnMallas.Text = "   Mallas"
        Me.btnMallas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMallas.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel7.Location = New System.Drawing.Point(3, 183)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 50)
        Me.Panel7.TabIndex = 5
        '
        'btnVer
        '
        Me.btnVer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVer.FlatAppearance.BorderSize = 0
        Me.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVer.ForeColor = System.Drawing.Color.White
        Me.btnVer.Image = Global.C_Coform_2.My.Resources.Resources.Lupa
        Me.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVer.Location = New System.Drawing.Point(0, 183)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(220, 50)
        Me.btnVer.TabIndex = 8
        Me.btnVer.Text = "   Data View"
        Me.btnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'Separador2
        '
        Me.Separador2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Separador2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Separador2.Location = New System.Drawing.Point(3, 117)
        Me.Separador2.Name = "Separador2"
        Me.Separador2.Size = New System.Drawing.Size(214, 2)
        Me.Separador2.TabIndex = 5
        '
        'Separador1
        '
        Me.Separador1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Separador1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Separador1.Location = New System.Drawing.Point(3, 45)
        Me.Separador1.Name = "Separador1"
        Me.Separador1.Size = New System.Drawing.Size(214, 2)
        Me.Separador1.TabIndex = 4
        '
        'LetraCoform
        '
        Me.LetraCoform.Image = Global.C_Coform_2.My.Resources.Resources.Coform
        Me.LetraCoform.Location = New System.Drawing.Point(78, 61)
        Me.LetraCoform.Name = "LetraCoform"
        Me.LetraCoform.Size = New System.Drawing.Size(121, 40)
        Me.LetraCoform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LetraCoform.TabIndex = 7
        Me.LetraCoform.TabStop = False
        '
        'LogoCoform
        '
        Me.LogoCoform.Image = Global.C_Coform_2.My.Resources.Resources.LCoform
        Me.LogoCoform.Location = New System.Drawing.Point(1, 56)
        Me.LogoCoform.Name = "LogoCoform"
        Me.LogoCoform.Size = New System.Drawing.Size(58, 50)
        Me.LogoCoform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoCoform.TabIndex = 6
        Me.LogoCoform.TabStop = False
        '
        'subMenu
        '
        Me.subMenu.Controls.Add(Me.LabelPulpa)
        Me.subMenu.Controls.Add(Me.LabelWinder)
        Me.subMenu.Controls.Add(Me.LabelExtrusor)
        Me.subMenu.Controls.Add(Me.LabelFormacion)
        Me.subMenu.Controls.Add(Me.Panel6)
        Me.subMenu.Controls.Add(Me.btnPulpa)
        Me.subMenu.Controls.Add(Me.Panel5)
        Me.subMenu.Controls.Add(Me.btnWinder)
        Me.subMenu.Controls.Add(Me.Panel4)
        Me.subMenu.Controls.Add(Me.Panel3)
        Me.subMenu.Controls.Add(Me.btnExtrusor)
        Me.subMenu.Controls.Add(Me.btnFormacion)
        Me.subMenu.Location = New System.Drawing.Point(17, 348)
        Me.subMenu.Name = "subMenu"
        Me.subMenu.Size = New System.Drawing.Size(200, 224)
        Me.subMenu.TabIndex = 5
        Me.subMenu.Visible = False
        '
        'LabelPulpa
        '
        Me.LabelPulpa.AutoSize = True
        Me.LabelPulpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPulpa.ForeColor = System.Drawing.Color.White
        Me.LabelPulpa.Location = New System.Drawing.Point(13, 182)
        Me.LabelPulpa.Name = "LabelPulpa"
        Me.LabelPulpa.Size = New System.Drawing.Size(27, 25)
        Me.LabelPulpa.TabIndex = 15
        Me.LabelPulpa.Text = "P"
        Me.LabelPulpa.Visible = False
        '
        'LabelWinder
        '
        Me.LabelWinder.AutoSize = True
        Me.LabelWinder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWinder.ForeColor = System.Drawing.Color.White
        Me.LabelWinder.Location = New System.Drawing.Point(8, 126)
        Me.LabelWinder.Name = "LabelWinder"
        Me.LabelWinder.Size = New System.Drawing.Size(33, 25)
        Me.LabelWinder.TabIndex = 14
        Me.LabelWinder.Text = "W"
        Me.LabelWinder.Visible = False
        '
        'LabelExtrusor
        '
        Me.LabelExtrusor.AutoSize = True
        Me.LabelExtrusor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExtrusor.ForeColor = System.Drawing.Color.White
        Me.LabelExtrusor.Location = New System.Drawing.Point(11, 70)
        Me.LabelExtrusor.Name = "LabelExtrusor"
        Me.LabelExtrusor.Size = New System.Drawing.Size(27, 25)
        Me.LabelExtrusor.TabIndex = 13
        Me.LabelExtrusor.Text = "E"
        Me.LabelExtrusor.Visible = False
        '
        'LabelFormacion
        '
        Me.LabelFormacion.AutoSize = True
        Me.LabelFormacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFormacion.ForeColor = System.Drawing.Color.White
        Me.LabelFormacion.Location = New System.Drawing.Point(13, 14)
        Me.LabelFormacion.Name = "LabelFormacion"
        Me.LabelFormacion.Size = New System.Drawing.Size(26, 25)
        Me.LabelFormacion.TabIndex = 0
        Me.LabelFormacion.Text = "F"
        Me.LabelFormacion.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel6.Location = New System.Drawing.Point(3, 171)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 11
        '
        'btnPulpa
        '
        Me.btnPulpa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPulpa.FlatAppearance.BorderSize = 0
        Me.btnPulpa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnPulpa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPulpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPulpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulpa.ForeColor = System.Drawing.Color.White
        Me.btnPulpa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPulpa.Location = New System.Drawing.Point(2, 171)
        Me.btnPulpa.Name = "btnPulpa"
        Me.btnPulpa.Size = New System.Drawing.Size(197, 50)
        Me.btnPulpa.TabIndex = 12
        Me.btnPulpa.Text = "Pulpa"
        Me.btnPulpa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPulpa.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Location = New System.Drawing.Point(3, 115)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 9
        '
        'btnWinder
        '
        Me.btnWinder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWinder.FlatAppearance.BorderSize = 0
        Me.btnWinder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnWinder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnWinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWinder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWinder.ForeColor = System.Drawing.Color.White
        Me.btnWinder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWinder.Location = New System.Drawing.Point(2, 115)
        Me.btnWinder.Name = "btnWinder"
        Me.btnWinder.Size = New System.Drawing.Size(197, 50)
        Me.btnWinder.TabIndex = 10
        Me.btnWinder.Text = "Winder"
        Me.btnWinder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWinder.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.Location = New System.Drawing.Point(3, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 5
        '
        'btnExtrusor
        '
        Me.btnExtrusor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExtrusor.FlatAppearance.BorderSize = 0
        Me.btnExtrusor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnExtrusor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnExtrusor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtrusor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtrusor.ForeColor = System.Drawing.Color.White
        Me.btnExtrusor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExtrusor.Location = New System.Drawing.Point(2, 59)
        Me.btnExtrusor.Name = "btnExtrusor"
        Me.btnExtrusor.Size = New System.Drawing.Size(197, 50)
        Me.btnExtrusor.TabIndex = 8
        Me.btnExtrusor.Text = "Extrusor"
        Me.btnExtrusor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExtrusor.UseVisualStyleBackColor = True
        '
        'btnFormacion
        '
        Me.btnFormacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormacion.FlatAppearance.BorderSize = 0
        Me.btnFormacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnFormacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnFormacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormacion.ForeColor = System.Drawing.Color.White
        Me.btnFormacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormacion.Location = New System.Drawing.Point(2, 3)
        Me.btnFormacion.Name = "btnFormacion"
        Me.btnFormacion.Size = New System.Drawing.Size(197, 50)
        Me.btnFormacion.TabIndex = 7
        Me.btnFormacion.Text = "Formacion"
        Me.btnFormacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFormacion.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Location = New System.Drawing.Point(3, 293)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Location = New System.Drawing.Point(3, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 3
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Image = Global.C_Coform_2.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(168, 6)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(45, 33)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.TabStop = False
        '
        'btnCenterlining
        '
        Me.btnCenterlining.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCenterlining.FlatAppearance.BorderSize = 0
        Me.btnCenterlining.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnCenterlining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCenterlining.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCenterlining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCenterlining.ForeColor = System.Drawing.Color.White
        Me.btnCenterlining.Image = Global.C_Coform_2.My.Resources.Resources.producto
        Me.btnCenterlining.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCenterlining.Location = New System.Drawing.Point(0, 293)
        Me.btnCenterlining.Name = "btnCenterlining"
        Me.btnCenterlining.Size = New System.Drawing.Size(220, 50)
        Me.btnCenterlining.TabIndex = 1
        Me.btnCenterlining.Text = " Centerlining"
        Me.btnCenterlining.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCenterlining.UseVisualStyleBackColor = True
        '
        'btnGraficar
        '
        Me.btnGraficar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGraficar.FlatAppearance.BorderSize = 0
        Me.btnGraficar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnGraficar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficar.ForeColor = System.Drawing.Color.White
        Me.btnGraficar.Image = Global.C_Coform_2.My.Resources.Resources.reportes
        Me.btnGraficar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGraficar.Location = New System.Drawing.Point(0, 128)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGraficar.Size = New System.Drawing.Size(220, 50)
        Me.btnGraficar.TabIndex = 0
        Me.btnGraficar.Text = " Graficar"
        Me.btnGraficar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGraficar.UseVisualStyleBackColor = True
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelCabecera.Controls.Add(Me.LogoKCC)
        Me.PanelCabecera.Controls.Add(Me.btnRestaurar)
        Me.PanelCabecera.Controls.Add(Me.btnMinimizar)
        Me.PanelCabecera.Controls.Add(Me.btnMaximizar)
        Me.PanelCabecera.Controls.Add(Me.btnCerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(1165, 40)
        Me.PanelCabecera.TabIndex = 0
        '
        'LogoKCC
        '
        Me.LogoKCC.Image = Global.C_Coform_2.My.Resources.Resources.LogoKCC
        Me.LogoKCC.Location = New System.Drawing.Point(3, 3)
        Me.LogoKCC.Name = "LogoKCC"
        Me.LogoKCC.Size = New System.Drawing.Size(136, 35)
        Me.LogoKCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoKCC.TabIndex = 8
        Me.LogoKCC.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.C_Coform_2.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1079, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.Text = " "
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.C_Coform_2.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1033, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.Text = " "
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.C_Coform_2.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1079, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.Text = " "
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.C_Coform_2.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.Location = New System.Drawing.Point(1125, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = " "
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'tmBarraProgreso
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 726)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(980, 726)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelBarraProgreso.ResumeLayout(False)
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenuCenterlining.ResumeLayout(False)
        CType(Me.LetraCoform, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoCoform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.subMenu.ResumeLayout(False)
        Me.subMenu.PerformLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCabecera.ResumeLayout(False)
        CType(Me.LogoKCC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PanelMenuCenterlining As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnCenterlining As Button
    Friend WithEvents btnGraficar As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents subMenu As Panel
    Friend WithEvents btnExtrusor As Button
    Friend WithEvents btnFormacion As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelBarraProgreso As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnGuardar As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnPulpa As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnWinder As Button
    Friend WithEvents tmBarraProgreso As Timer
    Friend WithEvents LogoCoform As PictureBox
    Friend WithEvents LetraCoform As PictureBox
    Friend WithEvents Separador2 As Panel
    Friend WithEvents Separador1 As Panel
    Friend WithEvents LogoKCC As PictureBox
    Friend WithEvents LabelFormacion As Label
    Friend WithEvents LabelPulpa As Label
    Friend WithEvents LabelWinder As Label
    Friend WithEvents LabelExtrusor As Label
    Friend WithEvents btnVer As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnMallas As Button
End Class
