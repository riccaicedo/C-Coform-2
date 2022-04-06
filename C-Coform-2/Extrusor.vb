Public Class Extrusor

    'Variables Del libro Excel
    Public HDatos = libro.Worksheets("DATOS")
    Public HCenterlining = libro.Worksheets("BD EXTRUSION")

    'Variables Globales
    Dim turno As String
    Dim supervisor As String
    Dim operario As String
    Dim referencia As String
    Dim LabelFormacion As String
    Dim contadorVariablesFuera As Integer
    Dim SaludMaquina As Decimal

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

#Region "Envio de Datos"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or
            TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or
            TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "" Or TextBox14.Text = "" Or TextBox15.Text = "" Or
            TextBox16.Text = "" Or TextBox17.Text = "" Or CBTurno.Text = "" Or CBSupervisor.Text = "" Or
            CBOperario.Text = "" Or CBReferencia.Text = "") Or
            (TextBox1.Text = "-" Or TextBox2.Text = "-" Or TextBox3.Text = "-" Or TextBox4.Text = "-" Or TextBox5.Text = "-" Or
            TextBox6.Text = "-" Or TextBox7.Text = "-" Or TextBox8.Text = "-" Or TextBox9.Text = "-" Or TextBox10.Text = "-" Or
            TextBox11.Text = "-" Or TextBox12.Text = "-" Or TextBox13.Text = "-" Or TextBox14.Text = "-" Or TextBox15.Text = "-" Or
            TextBox16.Text = "-" Or TextBox17.Text = "-" Or CBTurno.Text = "-" Or CBSupervisor.Text = "-" Or
            CBOperario.Text = "-" Or CBReferencia.Text = "-") Then
            MsgBox("Se encuentran casillas con en blanco o con datos invalidos")
        Else

            'Variables 
            Dim fecha As Date = Today
            Dim hora As String = TimeOfDay.TimeOfDay.ToString
            Dim Ucolumna

            'Variables para guardar limites
            Dim LSC As Decimal
            Dim OBJ As Decimal
            Dim LIC As Decimal


            'Variables de Proceso
            Dim textb As Integer
            textb = 0
            Dim VariablesFormacion As String

            'Dim TemperaturaSpinPumpB As String = TextBox2.Text

            'Format(Now, "dddd, d MMM yyyy")
            'MsgBox(fecha)
            'MsgBox("fecha personalizada: " & Format(Now, "d/MM/yyyy"))

            'Funcion para Mostar la Fila vacia seleccionas la Hoja - Inicio FILA- Inicio COLUMNA
            Final = nReg(HCenterlining, 7, 1)

            'Funcion para Mostar la ultima Columna seleccionas la Hoja - Inicio FILA- Inicio COLUMNA
            Ucolumna = nRegC(HCenterlining, 6, 1)

            ' Pegar variables Staticas
            HCenterlining.cells(Final, 1) = fecha
            HCenterlining.cells(Final, 2) = hora
            HCenterlining.cells(Final, 5) = referencia
            HCenterlining.Cells(Final, 6) = supervisor
            HCenterlining.Cells(Final, 7) = operario
            HCenterlining.Cells(Final, 8) = turno

            'Instalar Referencia

            If referencia = "43024961-B.COFORM BL 35G 163.1 X228.6CM 6,7'' LOC" Then
                HCenterlining.Cells(5, 6) = "35"
            End If
            If referencia = "43024962-B.COFORM BL 50G 163.1 X228.6CM 6.7'' LOC" Then
                HCenterlining.Cells(5, 6) = "50"
            End If
            If referencia = "43025329-B.COFORM BL 63G 163.1 X228.6CM 6,7'' LOC" Then
                HCenterlining.Cells(5, 6) = "63"
            End If

            'prueba recorrer todos los texbox y Pegarlos--
            For Each oControl As Control In Me.PanelVariables.Controls


                If TypeOf oControl Is TextBox Then

                    textb = textb + 1
                    VariablesFormacion = CType(oControl, TextBox).Text

#Region "label formacion"
                    If textb = 1 Then
                        LabelFormacion = Label20.Text
                    End If
                    If textb = 2 Then
                        LabelFormacion = Label19.Text
                    End If
                    If textb = 3 Then
                        LabelFormacion = Label18.Text
                    End If
                    If textb = 4 Then
                        LabelFormacion = Label17.Text
                    End If
                    If textb = 5 Then
                        LabelFormacion = Label16.Text
                    End If
                    If textb = 6 Then
                        LabelFormacion = Label15.Text
                    End If
                    If textb = 7 Then
                        LabelFormacion = Label14.Text
                    End If
                    If textb = 8 Then
                        LabelFormacion = Label13.Text
                    End If
                    If textb = 9 Then
                        LabelFormacion = Label12.Text
                    End If
                    If textb = 10 Then
                        LabelFormacion = Label11.Text
                    End If
                    If textb = 11 Then
                        LabelFormacion = Label10.Text
                    End If
                    If textb = 12 Then
                        LabelFormacion = Label9.Text
                    End If
                    If textb = 13 Then
                        LabelFormacion = Label8.Text
                    End If
                    If textb = 14 Then
                        LabelFormacion = Label7.Text
                    End If
                    If textb = 15 Then
                        LabelFormacion = Label6.Text
                    End If
                    If textb = 16 Then
                        LabelFormacion = Label5.Text
                    End If
                    If textb = 17 Then
                        LabelFormacion = Label4.Text
                    End If
#End Region

                    ' llenado de limites 
                    LSC = HCenterlining.Cells(3, Ucolumna - textb).Value
                    OBJ = HCenterlining.Cells(4, Ucolumna - textb).Value
                    LIC = HCenterlining.Cells(5, Ucolumna - textb).Value

                    ' Inserta las variables
                    HCenterlining.Cells(Final, Ucolumna - textb) = Convert.ToDecimal(VariablesFormacion)

                    ' Examina las variables si se encuentran dentro de los limites 
                    If Convert.ToDecimal(VariablesFormacion) < LIC Or Convert.ToDecimal(VariablesFormacion) > LSC Then

                        contadorVariablesFuera = contadorVariablesFuera + 1

                        'Envio de Comentarios
                        Dim descripcion As String
                        descripcion = InputBox("Descripcion de Evento " & LabelFormacion & ": " & VariablesFormacion, "Variables Fuera de Rango : # " & contadorVariablesFuera)

                        If String.IsNullOrEmpty(descripcion) Then

                            HCenterlining.cells(Final, Ucolumna - textb).AddComment
                            HCenterlining.cells(Final, Ucolumna - textb).Comment.Text("Actualizacion de Limites de Control")
                            HCenterlining.cells(Final, Ucolumna - textb).Interior.Color = RGB(150, 152, 154)
                        Else

                            HCenterlining.cells(Final, Ucolumna - textb).AddComment
                            HCenterlining.cells(Final, Ucolumna - textb).Comment.Text(descripcion)
                            HCenterlining.cells(Final, Ucolumna - textb).Interior.Color = RGB(255, 128, 0)
                        End If

                    End If

                End If

            Next

            SaludMaquina = 100 - ((contadorVariablesFuera / textb) * 100)
            SaludMaquina = Format(SaludMaquina, "0.00")
            MsgBox("Las variables fuera de rango fueron: " & contadorVariablesFuera & vbCrLf & "El estado de salud de su máquina es: " & SaludMaquina & " %.")

            ' Borrar Datos despues de Registralos en el Libro
#Region "Limpieza de TextBox"

            contadorVariablesFuera = 0
            CBTurno.Text = vbNullChar
            CBSupervisor.Text = vbNullChar
            CBOperario.Text = vbNullChar
            CBReferencia.Text = vbNullChar
            TextBox1.Text = vbNullChar
            TextBox2.Text = vbNullChar
            TextBox3.Text = vbNullChar
            TextBox4.Text = vbNullChar
            TextBox5.Text = vbNullChar
            TextBox6.Text = vbNullChar
            TextBox7.Text = vbNullChar
            TextBox8.Text = vbNullChar
            TextBox9.Text = vbNullChar
            TextBox10.Text = vbNullChar
            TextBox11.Text = vbNullChar
            TextBox12.Text = vbNullChar
            TextBox13.Text = vbNullChar
            TextBox14.Text = vbNullChar
            TextBox15.Text = vbNullChar
            TextBox16.Text = vbNullChar
            TextBox17.Text = vbNullChar
#End Region

        End If

    End Sub
#End Region

#Region "Funciones ComboBox"
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

    Private Sub CBReferencia_Enter(sender As Object, e As EventArgs) Handles CBReferencia.Enter
        Dim fila As Integer
        Dim final As Integer
        Dim lista As String

        Me.CBReferencia.Items.Clear()
        'Funcion para Mostar la ultima Columna vacia Hoja-FILA-COLUMNA
        final = nReg(HDatos, 2, 2) - 1

        For fila = 2 To final
            lista = HDatos.Cells(fila, 2).Text
            Me.CBReferencia.Items.Add(lista)
        Next
    End Sub

    Private Sub CBReferencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBReferencia.SelectedIndexChanged
        Dim fila As Integer
        Dim final As Integer
        'Funcion para Mostar la ultima Fila vacia Hoja-FILA-COLUMNA
        final = nReg(HDatos, 2, 2) - 1

        For fila = 2 To final
            If HDatos.Cells(fila, 2).Text = Me.CBReferencia.Text Then
                referencia = HDatos.Cells(fila, 2).Text
                'MsgBox(referencia)
                Exit For
            End If
        Next
    End Sub

    Private Sub CBReferencia_TextChanged(sender As Object, e As EventArgs) Handles CBReferencia.TextChanged
        If Me.CBReferencia.Text = "" Then
            referencia = ""

        End If
    End Sub
#End Region

#Region "Condicion para insertar solo Numeros"
    Public Sub condicion(sender As TextBox, e As KeyPressEventArgs)
        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) = 0 Then
            filtro += "-"
        End If

        If Len(cadena) > 0 Then
            filtro += ","
        End If

        ' Agregar Punto (.) y convertirlo en Coma(;)
        If e.KeyChar = "." Then
            SendKeys.Send(",")
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True

            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""

            ' ingresar coma o punto solo despues de un numero
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "," And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then

            If Asc(e.KeyChar) = 13 Then
            Else sender.Text = ""
            End If

        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{Tab}")
        End If

        ' digitar , una sola vez
        If e.KeyChar = "," And Not cadena.IndexOf(",") Or e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Call condicion(TextBox1, e)
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Call condicion(TextBox2, e)
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Call condicion(TextBox3, e)
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Call condicion(TextBox4, e)
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        Call condicion(TextBox5, e)
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        Call condicion(TextBox6, e)
    End Sub
    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        Call condicion(TextBox7, e)
    End Sub
    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        Call condicion(TextBox8, e)
    End Sub
    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        Call condicion(TextBox9, e)
    End Sub
    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        Call condicion(TextBox10, e)
    End Sub
    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        Call condicion(TextBox11, e)
    End Sub
    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        Call condicion(TextBox12, e)
    End Sub
    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        Call condicion(TextBox13, e)
    End Sub
    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        Call condicion(TextBox14, e)
    End Sub
    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        Call condicion(TextBox15, e)
    End Sub
    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox16.KeyPress
        Call condicion(TextBox16, e)
    End Sub
    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        Call condicion(TextBox17, e)
    End Sub

    'Resaltar Textbox al presionar Enter
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = TextBox1.Text.Length
    End Sub
    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        TextBox2.SelectionStart = 0
        TextBox2.SelectionLength = TextBox2.Text.Length
    End Sub
    Private Sub TextBox3_Enter(sender As Object, e As EventArgs) Handles TextBox3.Enter
        TextBox3.SelectionStart = 0
        TextBox3.SelectionLength = TextBox3.Text.Length
    End Sub
    Private Sub TextBox4_Enter(sender As Object, e As EventArgs) Handles TextBox4.Enter
        TextBox4.SelectionStart = 0
        TextBox4.SelectionLength = TextBox4.Text.Length
    End Sub
    Private Sub TextBox5_Enter(sender As Object, e As EventArgs) Handles TextBox5.Enter
        TextBox5.SelectionStart = 0
        TextBox5.SelectionLength = TextBox5.Text.Length
    End Sub
    Private Sub TextBox6_Enter(sender As Object, e As EventArgs) Handles TextBox6.Enter
        TextBox6.SelectionStart = 0
        TextBox6.SelectionLength = TextBox6.Text.Length
    End Sub
    Private Sub TextBox7_Enter(sender As Object, e As EventArgs) Handles TextBox7.Enter
        TextBox7.SelectionStart = 0
        TextBox7.SelectionLength = TextBox7.Text.Length
    End Sub
    Private Sub TextBox8_Enter(sender As Object, e As EventArgs) Handles TextBox8.Enter
        TextBox8.SelectionStart = 0
        TextBox8.SelectionLength = TextBox8.Text.Length
    End Sub
    Private Sub TextBox9_Enter(sender As Object, e As EventArgs) Handles TextBox9.Enter
        TextBox9.SelectionStart = 0
        TextBox9.SelectionLength = TextBox9.Text.Length
    End Sub
    Private Sub TextBox10_Enter(sender As Object, e As EventArgs) Handles TextBox10.Enter
        TextBox10.SelectionStart = 0
        TextBox10.SelectionLength = TextBox10.Text.Length
    End Sub
    Private Sub TextBox11_Enter(sender As Object, e As EventArgs) Handles TextBox11.Enter
        TextBox11.SelectionStart = 0
        TextBox11.SelectionLength = TextBox11.Text.Length
    End Sub
    Private Sub TextBox12_Enter(sender As Object, e As EventArgs) Handles TextBox12.Enter
        TextBox12.SelectionStart = 0
        TextBox12.SelectionLength = TextBox12.Text.Length
    End Sub
    Private Sub TextBox13_Enter(sender As Object, e As EventArgs) Handles TextBox13.Enter
        TextBox13.SelectionStart = 0
        TextBox13.SelectionLength = TextBox13.Text.Length
    End Sub
    Private Sub TextBox14_Enter(sender As Object, e As EventArgs) Handles TextBox14.Enter
        TextBox14.SelectionStart = 0
        TextBox14.SelectionLength = TextBox14.Text.Length
    End Sub
    Private Sub TextBox15_Enter(sender As Object, e As EventArgs) Handles TextBox15.Enter
        TextBox15.SelectionStart = 0
        TextBox15.SelectionLength = TextBox15.Text.Length
    End Sub
    Private Sub TextBox16_Enter(sender As Object, e As EventArgs) Handles TextBox16.Enter
        TextBox16.SelectionStart = 0
        TextBox16.SelectionLength = TextBox16.Text.Length
    End Sub
    Private Sub TextBox17_Enter(sender As Object, e As EventArgs) Handles TextBox17.Enter
        TextBox17.SelectionStart = 0
        TextBox17.SelectionLength = TextBox17.Text.Length
    End Sub
#End Region

End Class