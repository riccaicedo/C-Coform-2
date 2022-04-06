Public Class Mallas

    'Variables Del libro Excel
    Public HDatos = libro.Worksheets("DATOS")
    Public HMallas = libro.Worksheets("BD MALLAS")

    'Cerrar Formulario Secundario
    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    'Variables Globales
    Dim Ref As String
    Dim turno As String
    Dim supervisor As String
    Dim operario As String
    Dim actividad As String
    Dim maximo As Integer

    'Carga el form de Mallas con CheckBox en False
    Private Sub Mallas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        CheckBox3.Visible = False
        CheckBox4.Visible = False
        CheckBox5.Visible = False
        CheckBox6.Visible = False
        CheckBox7.Visible = False
        TextBox1.Visible = False
        Label10.Visible = False
        Dim lavado As String
        Dim Desmontaje As String
        lavado = "Lavado\n"
        Desmontaje = "Desmonataje\n"

        'Ejemplo de grafica

        'Creacion de Series
        Me.ChartMallas1.Series.Clear()
        Me.ChartMallas1.Series.Add("Mallas Lavadas")
        Me.ChartMallas1.Series.Add("Mallas Desmonatadas")
        Me.ChartMallas1.Series.Add("POBJ")

        'Limpiar Grafico Serie
        Me.ChartMallas1.Series("Mallas Lavadas").Points.Clear()
        Me.ChartMallas1.Series("Mallas Desmonatadas").Points.Clear()
        Me.ChartMallas1.Series("POBJ").Points.Clear()

        'Inhablitar leyenda de serie de puntos 
        Me.ChartMallas1.Series("POBJ").IsVisibleInLegend = False

        'Creacion del estilo de la Serie
        Me.ChartMallas1.Series("Mallas Lavadas").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        Me.ChartMallas1.Series("Mallas Desmonatadas").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        Me.ChartMallas1.Series("POBJ").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line

        'Titulo del area de Grafico 
        Me.ChartMallas1.ChartAreas("ChartArea1").AxisX.Title = "Codigo de Mallas"
        Me.ChartMallas1.ChartAreas("ChartArea1").AxisY.Title = "Numero de Actividad"
        'Me.ChartMallas1.ChartAreas("ChartArea1").AxisY2.Enabled = DataVisualization.Charting.AxisType.Secondary
        'Me.ChartMallas1.ChartAreas("ChartArea1").AxisX2.Enabled = DataVisualization.Charting.AxisType.Secondary

        'Color y Estilo de Series
        Me.ChartMallas1.Series("Mallas Lavadas").BorderWidth = 2
        Me.ChartMallas1.Series("Mallas Lavadas").Color = Color.SteelBlue
        Me.ChartMallas1.Series("Mallas Lavadas").MarkerColor = Color.Blue
        Me.ChartMallas1.Series("Mallas Lavadas").MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
        Me.ChartMallas1.Series("Mallas Lavadas").MarkerSize = 7

        Me.ChartMallas1.Series("Mallas Desmonatadas").BorderWidth = 2
        Me.ChartMallas1.Series("Mallas Desmonatadas").Color = Color.LightCoral
        Me.ChartMallas1.Series("Mallas Desmonatadas").MarkerColor = Color.Red
        Me.ChartMallas1.Series("Mallas Desmonatadas").MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
        Me.ChartMallas1.Series("Mallas Desmonatadas").MarkerSize = 7

        Me.ChartMallas1.Series("POBJ").BorderWidth = 2
        Me.ChartMallas1.Series("POBJ").Color = Color.Green

        'Agregar ToolTip
        Me.ChartMallas1.Series("Mallas Lavadas").ToolTip = "#VALY"
        Me.ChartMallas1.Series("Mallas Desmonatadas").ToolTip = "#VALY"
        'PUNTOS DE LAS SERIES

        ' Se configura un eje secundario en Y para la serie Mallas Desmonatadas
        Me.ChartMallas1.Series("Mallas Desmonatadas").XAxisType = DataVisualization.Charting.AxisType.Secondary

        Me.ChartMallas1.Series("POBJ").Points.AddXY(lavado & 50001, 10)
        Me.ChartMallas1.Series("Mallas Lavadas").Points.AddXY(lavado & 50001, 2)
        Me.ChartMallas1.Series("Mallas Desmonatadas").Points.AddXY(Desmontaje & 50001, 4)
        Me.ChartMallas1.Series("POBJ").Points.AddXY(lavado & 50002, 10)
        Me.ChartMallas1.Series("Mallas Lavadas").Points.AddXY(lavado & 50002, 2)
        Me.ChartMallas1.Series("Mallas Desmonatadas").Points.AddXY(Desmontaje & 50002, 6)
        Me.ChartMallas1.Series("POBJ").Points.AddXY(lavado & 50003, 10)
        Me.ChartMallas1.Series("Mallas Lavadas").Points.AddXY(lavado & 50003, 7)
        Me.ChartMallas1.Series("Mallas Desmonatadas").Points.AddXY(Desmontaje & 50003, 7)
        Me.ChartMallas1.Series("POBJ").Points.AddXY(lavado & 50004, 10)
        Me.ChartMallas1.Series("Mallas Lavadas").Points.AddXY(lavado & 50004, 7)
        Me.ChartMallas1.Series("Mallas Desmonatadas").Points.AddXY(Desmontaje & 50004, 7)
        Me.ChartMallas1.Series("POBJ").Points.AddXY(lavado & 50005, 10)
        Me.ChartMallas1.Series("Mallas Lavadas").Points.AddXY(lavado & 50005, 7)
        Me.ChartMallas1.Series("Mallas Desmonatadas").Points.AddXY(Desmontaje & 50005, 7)

        '------------------DTAGRID----------------------------

        'DataGridView1.Rows.Add(New String() {"50", "50001", "Lavada"})
        'DataGridView1.Rows.Add(New String() {"50", "50002", "Sucia"})
        'DataGridView1.Rows.Add(New String() {"63", "63001", "Lavada"})
        'DataGridView1.Rows.Add(New String() {"63", "63002", "Sucia"})


    End Sub

#Region "Funciones ComboBox"

    Private Sub CBTipoMalla_Enter(sender As Object, e As EventArgs) Handles CBTipoMalla.Enter

        'Limpiamos la lita del combobox
        Me.CBTipoMalla.Items.Clear()
        Me.CBTipoMalla.Items.Add("50")
        Me.CBTipoMalla.Items.Add("63")

    End Sub

    Private Sub CBTipoMalla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoMalla.SelectedIndexChanged

        If Me.CBTipoMalla.Text = "" Then
            Ref = " "
        Else
            Ref = Me.CBTipoMalla.Text
        End If

    End Sub

    Private Sub CBTipoMalla_TextChanged(sender As Object, e As EventArgs) Handles CBTipoMalla.TextChanged
        If Me.CBTipoMalla.Text = "" Then
            Ref = ""

        End If
    End Sub

    Private Sub CBSupervisor_Enter(sender As Object, e As EventArgs) Handles CBSupervisor.Enter
        Dim fila As Integer
        Dim final As Integer
        Dim lista As String

        Me.CBSupervisor.Items.Clear()
        'Funcion para Mostar la ultima Columna vacia Hoja-FILA-COLUMNA
        final = nReg(HDatos, 2, 3) - 1

        For fila = 2 To final
            lista = HDatos.Cells(fila, 3).Text
            Me.CBSupervisor.Items.Add(lista)
        Next
    End Sub

    Private Sub CBSupervisor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSupervisor.SelectedIndexChanged
        Dim fila As Integer
        Dim final As Integer
        'Funcion para Mostar la ultima Fila vacia Hoja-FILA-COLUMNA
        final = nReg(HDatos, 2, 3) - 1

        For fila = 2 To final
            If HDatos.Cells(fila, 3).Text = Me.CBSupervisor.Text Then
                supervisor = HDatos.Cells(fila, 3).Text
                'MsgBox(supervisor)
                Exit For
            End If
        Next
    End Sub

    Private Sub CBSupervisor_TextChanged(sender As Object, e As EventArgs) Handles CBSupervisor.TextChanged
        If Me.CBSupervisor.Text = "" Then
            supervisor = ""

        End If
    End Sub

    Private Sub CBOperario_Enter(sender As Object, e As EventArgs) Handles CBOperario.Enter
        Dim fila As Integer
        Dim final As Integer
        Dim lista As String

        Me.CBOperario.Items.Clear()
        'Funcion para Mostar la ultima Columna vacia Hoja-FILA-COLUMNA
        final = nReg(HDatos, 2, 4) - 1

        For fila = 2 To final
            lista = HDatos.Cells(fila, 4).Text
            Me.CBOperario.Items.Add(lista)
        Next
    End Sub

    Private Sub CBOperario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOperario.SelectedIndexChanged
        Dim fila As Integer
        Dim final As Integer
        'Funcion para Mostar la ultima Fila vacia Hoja-FILA-COLUMNA
        final = nReg(HDatos, 2, 4) - 1

        For fila = 2 To final
            If HDatos.Cells(fila, 4).Text = Me.CBOperario.Text Then
                operario = HDatos.Cells(fila, 4).Text
                'MsgBox(operario)
                Exit For
            End If
        Next
    End Sub

    Private Sub CBOperario_TextChanged(sender As Object, e As EventArgs) Handles CBOperario.TextChanged
        If Me.CBOperario.Text = "" Then
            operario = ""

        End If
    End Sub

    Private Sub CBTurno_Enter(sender As Object, e As EventArgs) Handles CBTurno.Enter

        Dim fila As Integer
        Dim final As Integer
        Dim lista As String

        Me.CBTurno.Items.Clear()
        'Funcion para Mostar la ultima Columna vacia Hoja-FILA-COLUMNA
        final = nReg(HDatos, 2, 1) - 1

        For fila = 2 To final
            lista = HDatos.Cells(fila, 1).Text
            Me.CBTurno.Items.Add(lista)
        Next

    End Sub

    Private Sub CBTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTurno.SelectedIndexChanged

        Dim fila As Integer
        Dim final As Integer
        'Funcion para Mostar la ultima Fila vacia Hoja-FILA-COLUMNA
        final = nReg(HDatos, 2, 1) - 1
        For fila = 2 To final
            If HDatos.Cells(fila, 1).Text = Me.CBTurno.Text Then
                turno = HDatos.Cells(fila, 1).Text
                'MsgBox(turno)
                Exit For
            End If
        Next

    End Sub

    Private Sub CBTurno_TextChanged(sender As Object, e As EventArgs) Handles CBTurno.TextChanged
        If Me.CBTurno.Text = "" Then
            turno = ""

        End If
    End Sub

    Private Sub CBActividad_Enter(sender As Object, e As EventArgs) Handles CBActividad.Enter

        'Limpiamos la lita del combobox
        Me.CBActividad.Items.Clear()
        Me.CBActividad.Items.Add("REGISTRO")
        Me.CBActividad.Items.Add("LAVADO")
        Me.CBActividad.Items.Add("DESMONTAJE")

    End Sub

    Private Sub CBActividad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBActividad.SelectedIndexChanged

        If Me.CBActividad.Text = "" Then
            actividad = " "
        Else
            actividad = Me.CBActividad.Text

            'Validar estados de la malla segun Actvidad

            If actividad = "REGISTRO" Then

                CheckBox1.Visible = True
                CheckBox2.Visible = False
                CheckBox3.Visible = False
                CheckBox4.Visible = False
                CheckBox5.Visible = False
                CheckBox6.Visible = False
                CheckBox7.Visible = False
                TextBox1.Visible = False
                Label10.Visible = False

            End If

            If actividad = "LAVADO" Then

                CheckBox1.Visible = True
                CheckBox2.Visible = True
                CheckBox3.Visible = True
                CheckBox4.Visible = True
                CheckBox5.Visible = True
                CheckBox6.Visible = True
                CheckBox7.Visible = False
                TextBox1.Visible = True
                Label10.Visible = True
                'Borra el label de codigo generado en la actividad registro
                Me.Label3.Text = "..."

            End If

            If actividad = "DESMONTAJE" Then

                CheckBox1.Visible = False
                CheckBox2.Visible = False
                CheckBox3.Visible = False
                CheckBox4.Visible = False
                CheckBox5.Visible = False
                CheckBox6.Visible = False
                CheckBox7.Visible = True
                TextBox1.Visible = True
                Label10.Visible = True
                'Borra el label de codigo generado en la actividad registro
                Me.Label3.Text = "..."
            End If

        End If

    End Sub

    Private Sub CBActividad_TextChanged(sender As Object, e As EventArgs) Handles CBActividad.TextChanged
        If Me.CBActividad.Text = "" Then
            actividad = ""
            CheckBox1.Visible = False
            CheckBox2.Visible = False
            CheckBox3.Visible = False
            CheckBox4.Visible = False
            CheckBox5.Visible = False
            CheckBox6.Visible = False
            CheckBox7.Visible = False
            TextBox1.Visible = False
            Label10.Visible = False
        End If
    End Sub

#End Region

#Region "Envio de Datos"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CBTipoMalla.Text = "" Or CBActividad.Text = "" Or CBSupervisor.Text = "" Or CBOperario.Text = "" Or CBTurno.Text = "" Then

            MsgBox("Se encuentran casillas en blanco o con datos invalidos")

        Else

            'Variables 
            'Asignacion de Fecha
            Dim fecha As Date = Today
            'Asignacion de Hora
            Dim hora As String = TimeOfDay.TimeOfDay.ToString
            Dim i As Integer
            Dim contador As Integer
            Dim valorMayor As Integer
            valorMayor = 0
            Dim numeroLavadas As Integer
            Dim codigoMalla As Integer
            Dim condicionCodigo As Boolean
            Dim subCodigo As String

            'Funcion para Mostar la Fila vacia seleccionas la Hoja - Inicio FILA- Inicio COLUMNA
            Final = nReg(HMallas, 7, 1)

            If CBActividad.Text = "REGISTRO" Then

                If CheckBox1.Checked = False Then

                    MsgBox("Olvido dar Check a la actividad REGISTRO")
                    Exit Sub
                End If

                For i = 7 To Final

                    'Compara Tipo de Malla para analizar el registro y asignar codigo
                    If HMallas.Cells(i, 3).Text = Me.CBTipoMalla.Text Then

                        'se compara en el arreglo cual es la malla con valor maximo para generar codigo nuevo
                        If HMallas.Cells(i, 4).value > valorMayor Then
                            valorMayor = HMallas.Cells(i, 4).value
                        End If

                    End If

                Next

                If valorMayor = 0 And CBTipoMalla.Text = "50" Then
                    'se Asigna codigo predeterminado 50
                    valorMayor = HMallas.Cells(5, 7).value + 1
                    MsgBox("Debe Asignar a la malla el siguiente Codigo: " & valorMayor)
                    Me.Label3.Text = "Asignar Codigo: " & valorMayor
                ElseIf valorMayor = 0 And CBTipoMalla.Text = "63" Then
                    'se Asigna codigo predeterminado 63
                    valorMayor = HMallas.Cells(5, 8).value + 1
                    MsgBox("Debe Asignar a la malla el siguiente Codigo: " & valorMayor)
                    Me.Label3.Text = "Asignar Codigo: " & valorMayor
                Else
                    'se Asigna codigo con valor mayor a los que se encuentran en la base de Datos
                    valorMayor = valorMayor + 1
                    MsgBox("Debe Asignar a la malla el siguiente Codigo: " & valorMayor)
                    Me.Label3.Text = "Asignar Codigo: " & valorMayor
                End If

                numeroLavadas = 0

                If Me.CBActividad.Text = "" Then
                        i = 0
                        valorMayor = 0
                    End If

                End If

            If CBActividad.Text = "LAVADO" Then

                If CheckBox1.Checked = True And (CheckBox2.Checked = True Or CheckBox3.Checked = True Or CheckBox4.Checked = True Or CheckBox5.Checked = True Or CheckBox6.Checked = True) Then

                    MsgBox("la Malla no se puede encontrar OK si tiene algun Deterioro")
                    CheckBox1.Checked = False
                    CheckBox2.Checked = False
                    CheckBox3.Checked = False
                    CheckBox4.Checked = False
                    CheckBox5.Checked = False
                    CheckBox6.Checked = False
                    CheckBox7.Checked = False
                    Exit Sub
                End If

                If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And CheckBox4.Checked = False And CheckBox5.Checked = False And CheckBox6.Checked = False Then

                    MsgBox("Olvido dar Check a la actividad LAVADO")
                    Exit Sub
                End If

                'Examina si el codigo digitado se encuentra en base de datos
                For i = 7 To Final

                    If Me.TextBox1.Text = HMallas.Cells(i, 4).text Then
                        condicionCodigo = True
                        Exit For
                    End If

                Next

                If condicionCodigo = True Then

                    codigoMalla = CInt(Me.TextBox1.Text)

                    For i = 7 To Final

                        'Compara El codigo y actividad de la malla con el ingresado en el TextBox 
                        If HMallas.Cells(i, 4).value = codigoMalla And HMallas.Cells(i, 5).text = Me.CBActividad.Text Then
                            'Almacena numero de lavadas del codigo de malla digitado
                            contador = contador + 1
                            numeroLavadas = contador + 1
                        End If

                    Next

                    If numeroLavadas = 0 Then
                        'Esta condicion se de cuando es la primera vez que se Desmonta la malla
                        numeroLavadas = 1
                    End If

                Else
                    MsgBox("Verifique: El codigo de malla digitado no se encuentra en la base de datos")
                    Exit Sub
                End If

                If Me.TextBox1.Text = "" Then
                    MsgBox("Digite el codigo de Malla")
                    Exit Sub
                Else
                    subCodigo = TextBox1.Text.Substring(0, 2)

                    If subCodigo <> CBTipoMalla.Text Then
                        MsgBox("El codigo digitado no corresponde al tipo de malla ")
                        Exit Sub
                    End If

                End If

                valorMayor = Me.TextBox1.Text

            End If

            If CBActividad.Text = "DESMONTAJE" Then

                If CheckBox7.Checked = False Then

                    MsgBox("Olvido dar Check a la actividad DESMONTAJE")
                    Exit Sub
                End If

                'Examina si el codigo digitado se encuentra en base de datos
                For i = 7 To Final

                    If Me.TextBox1.Text = HMallas.Cells(i, 4).text Then
                        condicionCodigo = True
                        Exit For
                    End If

                Next

                If condicionCodigo = True Then

                    codigoMalla = CInt(Me.TextBox1.Text)

                    For i = 7 To Final

                        'Compara El codigo y actividad de la malla con el ingresado en el TextBox 
                        If HMallas.Cells(i, 4).value = codigoMalla And HMallas.Cells(i, 5).text = Me.CBActividad.Text Then
                            'Almacena numero de desmontadas del codigo de malla digitado
                            contador = contador + 1
                            numeroLavadas = contador + 1
                        End If

                    Next

                    If numeroLavadas = 0 Then
                        'Esta condicion se de cuando es la primera vez que se Desmonta la malla
                        numeroLavadas = 1
                    End If

                Else
                    MsgBox("Verifique: El codigo de malla digitado no se encuentra en la base de datos")
                    Exit Sub
                End If

                If Me.TextBox1.Text = "" Then
                    MsgBox("Digite el codigo de Malla")
                    Exit Sub
                Else
                    subCodigo = TextBox1.Text.Substring(0, 2)

                    If subCodigo <> CBTipoMalla.Text Then
                        MsgBox("El codigo digitado no corresponde al tipo de malla ")
                        Exit Sub
                    End If

                End If

                valorMayor = Me.TextBox1.Text

            End If

            ' Pegar variables Staticas
            HMallas.cells(Final, 1) = fecha
            HMallas.cells(Final, 2) = hora
            HMallas.cells(Final, 3) = Ref
            HMallas.Cells(Final, 4) = valorMayor
            HMallas.Cells(Final, 5) = actividad
            HMallas.Cells(Final, 6) = supervisor
            HMallas.Cells(Final, 7) = operario
            HMallas.Cells(Final, 8) = turno
            HMallas.Cells(Final, 10) = numeroLavadas
            If CheckBox1.Checked = True Then
                HMallas.Cells(Final, 11) = 1
            Else HMallas.Cells(Final, 11) = 0
            End If
            If CheckBox2.Checked = True Then
                HMallas.Cells(Final, 12) = 1
            Else HMallas.Cells(Final, 12) = 0
            End If
            If CheckBox3.Checked = True Then
                HMallas.Cells(Final, 13) = 1
            Else HMallas.Cells(Final, 13) = 0
            End If
            If CheckBox4.Checked = True Then
                HMallas.Cells(Final, 14) = 1
            Else HMallas.Cells(Final, 14) = 0
            End If
            If CheckBox5.Checked = True Then
                HMallas.Cells(Final, 15) = 1
            Else HMallas.Cells(Final, 15) = 0
            End If
            If CheckBox6.Checked = True Then
                HMallas.Cells(Final, 16) = 1
            Else HMallas.Cells(Final, 16) = 0
            End If
            If CheckBox7.Checked = True Then
                HMallas.Cells(Final, 17) = 1
            Else HMallas.Cells(Final, 17) = 0
            End If

            MsgBox("Registro Satisfactorio")

#Region "Limpieza de TextBox"
            CBTipoMalla.Text = vbNullChar
            CBActividad.Text = vbNullChar
            CBSupervisor.Text = vbNullChar
            CBOperario.Text = vbNullChar
            CBTurno.Text = vbNullChar
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            TextBox1.Text = vbNullChar

#End Region

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Funcion para Mostar la Fila vacia seleccionas la Hoja - Inicio FILA- Inicio COLUMNA
        Final = nReg(HMallas, 7, 1)
        Dim valorMayor As Integer
        Dim limiteConteo As Integer
        Dim nlavadas As Integer
        Dim ndesmontadas As Integer
        Dim codigoM As Integer
        valorMayor = 0
        nlavadas = 0
        ndesmontadas = 0

        For i = 7 To Final

            'Compara Tipo de Malla para analizar el registro y asignar codigo
            If HMallas.Cells(i, 3).Text = "63" And HMallas.Cells(i, 5).Text = "DESMONTAJE" Then

                'se compara en el arreglo cual es la malla con valor maximo para generar codigo nuevo
                If HMallas.Cells(i, 4).value > valorMayor Then
                    valorMayor = HMallas.Cells(i, 4).value
                End If

            End If

        Next

        limiteConteo = valorMayor - 3

        If limiteConteo < 63000 Then

            If limiteConteo = 62999 Then
                limiteConteo = 2
            Else
                limiteConteo = 1
            End If

        Else
            limiteConteo = 3
        End If

        For j = 0 To limiteConteo - 1 Step 1

            codigoM = valorMayor - j
            'MsgBox(codigoM)

            ' Ciclo que arroja el ultimo numero de lavadas segun el codigo de la malla 
            For i = 7 To Final

                'Se condiciona y compara Tipo de Malla, Numero de malla 
                If HMallas.Cells(i, 3).Text = "63" And HMallas.Cells(i, 4).Text = CStr(codigoM) And HMallas.Cells(i, 5).Text = "LAVADO" Then

                    'Se busca el numero mayor de lavadas 
                    If HMallas.Cells(i, 10).value > nlavadas Then
                        nlavadas = HMallas.Cells(i, 10).value
                    End If
                End If

            Next
            'MsgBox("Lavada #: " & nlavadas)

            ' Ciclo que arroja el ultimo numero de Desmontajes segun el codigo de la malla 
            For i = 7 To Final

                'Se condiciona y compara Tipo de Malla, Numero de malla 
                If HMallas.Cells(i, 3).Text = "63" And HMallas.Cells(i, 4).Text = CStr(codigoM) And HMallas.Cells(i, 5).Text = "DESMONTAJE" Then

                    'Se busca el numero mayor de lavadas 
                    If HMallas.Cells(i, 10).value > ndesmontadas Then
                        ndesmontadas = HMallas.Cells(i, 10).value
                    End If

                End If

            Next
            'MsgBox("desmontada #: " & ndesmontadas)

            If nlavadas = ndesmontadas Then
                DataGridView1.Rows.Add(New String() {"63", codigoM, "Limpia"})
            Else
                DataGridView1.Rows.Add(New String() {"63", codigoM, "sucia"})
            End If

        Next

        valorMayor = 0
        nlavadas = 0
        ndesmontadas = 0
        '-----------------------------------------

        For i = 7 To Final

            'Compara Tipo de Malla para analizar el registro y asignar codigo
            If HMallas.Cells(i, 3).Text = "50" And HMallas.Cells(i, 5).Text = "DESMONTAJE" Then

                'se compara en el arreglo cual es la malla con valor maximo para generar codigo nuevo
                If HMallas.Cells(i, 4).value > valorMayor Then
                    valorMayor = HMallas.Cells(i, 4).value
                End If

            End If

        Next

        limiteConteo = valorMayor - 3

        If limiteConteo < 50000 Then

            If limiteConteo = 49999 Then
                limiteConteo = 2
            Else
                limiteConteo = 1
            End If

        Else
            limiteConteo = 3
        End If

        For j = 0 To limiteConteo - 1 Step 1

            codigoM = valorMayor - j
            'MsgBox(codigoM)

            ' Ciclo que arroja el ultimo numero de lavadas segun el codigo de la malla 
            For i = 7 To Final

                'Se condiciona y compara Tipo de Malla, Numero de malla 
                If HMallas.Cells(i, 3).Text = "50" And HMallas.Cells(i, 4).Text = CStr(codigoM) And HMallas.Cells(i, 5).Text = "LAVADO" Then

                    'Se busca el numero mayor de lavadas 
                    If HMallas.Cells(i, 10).value > nlavadas Then
                        nlavadas = HMallas.Cells(i, 10).value
                    End If
                End If

            Next
            'MsgBox("Lavada #: " & nlavadas)

            ' Ciclo que arroja el ultimo numero de Desmontajes segun el codigo de la malla 
            For i = 7 To Final

                'Se condiciona y compara Tipo de Malla, Numero de malla 
                If HMallas.Cells(i, 3).Text = "50" And HMallas.Cells(i, 4).Text = CStr(codigoM) And HMallas.Cells(i, 5).Text = "DESMONTAJE" Then

                    'Se busca el numero mayor de lavadas 
                    If HMallas.Cells(i, 10).value > ndesmontadas Then
                        ndesmontadas = HMallas.Cells(i, 10).value
                    End If

                End If

            Next
            'MsgBox("desmontada #: " & ndesmontadas)

            If nlavadas = ndesmontadas Then
                DataGridView1.Rows.Add(New String() {"50", codigoM, "Limpia"})
            Else
                DataGridView1.Rows.Add(New String() {"50", codigoM, "sucia"})
            End If

        Next


    End Sub



#End Region

End Class