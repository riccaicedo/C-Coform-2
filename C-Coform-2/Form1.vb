Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports Microsoft.Office.Interop
Imports System.Data

Public Class Form1

    'Variable para abrir Libro excel
    'Dim libroPrincipal = ExcelApp.Workbooks.Open(Filename:="C:\Centerlining-Sellado-PFM's\EJEMPLO.xlsx, ReadOnly:=True")
    'Dim libroPrincipal = ExcelApp.Workbooks.Open(Application.StartupPath & "\ExcelBD\CENTERLINING.xlsx", Notify:=False)
    Dim libroPrincipal = ExcelApp.Workbooks.Open(Application.StartupPath & "\ExcelBD\CENTERLINING.xlsx")

    'Variable para Bara de Progreso
    Dim contador As Integer

#Region "Funcionalidades del Form"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(64, 64, 64))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click


        If libroPrincipal.Saved() = False Then
            Dim Respuesta As MsgBoxResult = MsgBox("Desea Guardar los Cambios " & libroPrincipal.name &
                                                   "?", vbExclamation + vbYesNo, "Microsoft Excel")
            Select Case Respuesta
                Case MsgBoxResult.Yes
                    ProgressBar1.Value = 0.0
                    ProgressBar1.Maximum = 120
                    tmBarraProgreso.Interval = 40
                    tmBarraProgreso.Enabled = True
                    libroPrincipal.Save()
                    MsgBox("Los Cambios han sido guardados en el libro: " & libroPrincipal.Name)
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()
                Case MsgBoxResult.No
                    libroPrincipal.Saved() = True
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()
            End Select
        Else
            ExcelApp.Quit()
            libroPrincipal = Nothing
            ExcelApp = Nothing
            Application.Exit()

        End If

    End Sub

    'Variables para CAPTURAR VALORES DE LA PANTALLA
    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click

        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnRestaurar.Visible = False
        btnMaximizar.Visible = True

    End Sub
#End Region

#Region "Timer del Form Principal"
    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenuCenterlining.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenuCenterlining.Width = 60
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If PanelMenuCenterlining.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.PanelMenuCenterlining.Width = 220
        End If
    End Sub

    Private Sub tmBarraProgreso_Tick(sender As Object, e As EventArgs) Handles tmBarraProgreso.Tick
        If contador <= 120 Then
            ProgressBar1.Value = contador
            contador = contador + 10
        Else
            tmBarraProgreso.Enabled = False
        End If
    End Sub

#End Region

#Region "Funcion de los Botones del Form"
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenuCenterlining.Width = 220 Then
            tmOcultarMenu.Enabled = True
            LabelFormacion.Visible = True
            LabelExtrusor.Visible = True
            LabelWinder.Visible = True
            LabelPulpa.Visible = True
        ElseIf PanelMenuCenterlining.Width = 60 Then
            tmMostrarMenu.Enabled = True
            LabelFormacion.Visible = False
            LabelExtrusor.Visible = False
            LabelWinder.Visible = False
            LabelPulpa.Visible = False
        End If
    End Sub

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click

        If libroPrincipal.ReadOnly Then

            Dim Respuesta As MsgBoxResult = MsgBox("La Base de datos: " & libroPrincipal.name & " se encuentra ocupada por otro Usuario intente mas tarde!", vbExclamation + vbNo)

            Select Case Respuesta

                Case MsgBoxResult.Ok
                    libroPrincipal.Saved() = True
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()

            End Select

        End If

        AbrirFormEnPanel(Of Graficas)()
        btnGraficar.BackColor = Color.SteelBlue

    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click

        If libroPrincipal.ReadOnly Then

            Dim Respuesta As MsgBoxResult = MsgBox("La Base de datos: " & libroPrincipal.name & " se encuentra ocupada por otro Usuario intente mas tarde!", vbExclamation + vbNo)

            Select Case Respuesta

                Case MsgBoxResult.Ok
                    libroPrincipal.Saved() = True
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()

            End Select

        End If

        'AbrirFormEnPanel(Of VerDatos)()
        'btnVer.BackColor = Color.SteelBlue
    End Sub

    Private Sub btnMallas_Click(sender As Object, e As EventArgs) Handles btnMallas.Click

        If libroPrincipal.ReadOnly Then

            Dim Respuesta As MsgBoxResult = MsgBox("La Base de datos: " & libroPrincipal.name & " se encuentra ocupada por otro Usuario intente mas tarde!", vbExclamation + vbNo)

            Select Case Respuesta

                Case MsgBoxResult.Ok
                    libroPrincipal.Saved() = True
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()

            End Select

        End If

        AbrirFormEnPanel(Of Mallas)()
        btnMallas.BackColor = Color.SteelBlue

    End Sub

    Private Sub Centerlining_Click(sender As Object, e As EventArgs) Handles btnCenterlining.Click

        If libroPrincipal.ReadOnly Then

            Dim Respuesta As MsgBoxResult = MsgBox("La Base de datos: " & libroPrincipal.name & " se encuentra ocupada por otro Usuario intente mas tarde!", vbExclamation + vbNo)

            Select Case Respuesta

                Case MsgBoxResult.Ok
                    libroPrincipal.Saved() = True
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()

            End Select

        End If

        If subMenu.Visible = True Then
            subMenu.Visible = False
            btnCenterlining.BackColor = Color.FromArgb(37, 46, 59)
        Else
            subMenu.Visible = True
            btnCenterlining.BackColor = Color.SteelBlue
        End If

    End Sub

    Private Sub btnFormacion_Click(sender As Object, e As EventArgs) Handles btnFormacion.Click
        btnFormacion.BackColor = Color.SteelBlue
        LabelFormacion.BackColor = Color.SteelBlue
        AbrirFormEnPanel(Of Formacion)()
    End Sub

    Private Sub btnExtrusor_Click(sender As Object, e As EventArgs) Handles btnExtrusor.Click
        btnExtrusor.BackColor = Color.SteelBlue
        LabelExtrusor.BackColor = Color.SteelBlue
        AbrirFormEnPanel(Of Extrusor)()
    End Sub

    Private Sub btnWinder_Click(sender As Object, e As EventArgs) Handles btnWinder.Click
        btnWinder.BackColor = Color.SteelBlue
        LabelWinder.BackColor = Color.SteelBlue
        AbrirFormEnPanel(Of Winder)()
    End Sub

    Private Sub btnPulpa_Click(sender As Object, e As EventArgs) Handles btnPulpa.Click
        btnPulpa.BackColor = Color.SteelBlue
        LabelPulpa.BackColor = Color.SteelBlue
        AbrirFormEnPanel(Of Pulpa)()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If libroPrincipal.ReadOnly Then

            Dim Respuesta As MsgBoxResult = MsgBox("La Base de datos: " & libroPrincipal.name & " se encuentra ocupada por otro Usuario intente mas tarde!", vbExclamation + vbNo)

            Select Case Respuesta

                Case MsgBoxResult.Ok
                    libroPrincipal.Saved() = True
                    ExcelApp.Quit()
                    libroPrincipal = Nothing
                    ExcelApp = Nothing
                    Application.Exit()

            End Select
        Else
            ProgressBar1.Value = 0.0
            ProgressBar1.Maximum = 120
            tmBarraProgreso.Interval = 40
            tmBarraProgreso.Enabled = True
            libroPrincipal.Save()
            MsgBox("Los Cambios han sido guardados en el libro: " & libroPrincipal.Name)
            ExcelApp.Quit()
            libroPrincipal = Nothing
            ExcelApp = Nothing
            Application.Exit()

        End If

    End Sub


#End Region

    'METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL
    Private Sub AbrirFormEnPanel(Of Forms As {Form, New})()
        Dim formulario As Form
        formulario = PanelFormularios.Controls.OfType(Of Forms)().FirstOrDefault() 'Busca Formulario en coleccion

        If formulario Is Nothing Then
            formulario = New Forms()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(formulario)
            PanelFormularios.Tag = formulario
            AddHandler formulario.FormClosed, AddressOf Me.CerrarFormulario
            formulario.Show()
            formulario.BringToFront()
        Else

            'If formulario.WindowState = FormWindowState.Minimized Then
            'formulario.WindowState = FormWindowState.Normal
            'End If

            formulario.BringToFront()
        End If
    End Sub

    'METDO PARA CERRAR FORM SECURDARIOS
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'Codicion para examinar un from abierto
        If (Application.OpenForms("Graficas") Is Nothing) Then
            btnGraficar.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Mallas") Is Nothing) Then
            btnMallas.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Formacion") Is Nothing) Then
            btnFormacion.BackColor = Color.FromArgb(37, 46, 59)
            LabelFormacion.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Extrusor") Is Nothing) Then
            btnExtrusor.BackColor = Color.FromArgb(37, 46, 59)
            LabelExtrusor.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Winder") Is Nothing) Then
            btnWinder.BackColor = Color.FromArgb(37, 46, 59)
            LabelWinder.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Pulpa") Is Nothing) Then
            btnPulpa.BackColor = Color.FromArgb(37, 46, 59)
            LabelPulpa.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Formacion") Is Nothing) And (Application.OpenForms("Extrusor") Is Nothing) And
            (Application.OpenForms("Winder") Is Nothing) And (Application.OpenForms("Pulpa") Is Nothing) And
            subMenu.Visible = False Then
            btnCenterlining.BackColor = Color.FromArgb(37, 46, 59)
        End If
    End Sub

End Class
