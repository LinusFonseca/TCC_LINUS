Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports


Public Class Supervisorio
    Dim estado As Double
    Dim contadoratual As Integer = 0
    Dim contadorinicio As Integer
    Dim TempRampa1 As String
    Dim TempRampa2 As String
    Dim TempRampa3 As String
    Dim TimeRampa1 As String
    Dim TimeRampa2 As String
    Dim TimeRampa3 As String
    Dim Lupulo1 As String
    Dim Lupulo2 As String
    Dim Lupulo3 As String
    Dim TempResf As String
    Dim Fervura As String

    Dim TempPanela1 As String
    Dim TempPanela2 As String
  
    Dim Chama1 As String
    Dim Chama2 As String
    Dim Chama3 As String

    Dim Nivel1 As String
    Dim Nivel2 As String
    Dim Nivel3 As String

    Dim LeituraPanela1 As String
    Dim LeituraPanela2 As String
    Dim LeituraPanela3 As String

    Dim Iniciarflag As Boolean = False

    Dim ServoMotor1 As Integer = 0
    Dim ServoMotor2 As Integer = 0
    Dim ServoMotor3 As Integer = 0
    Dim solenoide1 As Integer = 0
    Dim solenoide2 As Integer = 0
    Dim solenoide3 As Integer = 0
    Dim BombaRecirculacao As Integer = 0
    Dim BombaResfriamento As Integer = 0
    Public Buzzer As Integer = 0
    Dim flagfim As Boolean = False

    Dim EscreverUmaVez As Boolean = True

    Dim path As String = "d:\TxtdosTCC\teste.txt"

    Delegate Sub SetTextCallback(ByVal [text] As String)

    
    Private Sub Supervisorio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        estado = 10
        Estados()
        Timer2.Enabled = True
        ComboBox_AvailableSerialPorts.Items.Add("Default")
        TempPanela2 = "00"
        For Each AvailableSerialPorts As String In IO.Ports.SerialPort.GetPortNames()

            ComboBox_AvailableSerialPorts.Items.Add(AvailableSerialPorts)

            ComboBox_AvailableSerialPorts.Text = AvailableSerialPorts

            SerialPort1.ReadTimeout = 2000

            Button_Connect.Visible = True
            Button_Disconnect.Visible = False

        Next

    End Sub


    Private Sub EnviarButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarButton.Click
        Timer3.Start()
        Dim file As New System.IO.StreamWriter(path, True)
        file.Close()
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        file.WriteLine(DateTime.Now.ToLongDateString())
        file.WriteLine(DateTime.Now.ToLongTimeString() + "Inicio")
        file.Close()

        Iniciarflag = True
        Dim alerta As Integer
        alerta = 1

        If SerialPort1.IsOpen Then
            alerta = 0
        Else
            MessageBox.Show("Nada conectado: verifique conexão")
        End If

        If Rampa1TextBox.Text.Length = 0 Then
            alerta = 1
            MessageBox.Show("Colocar a temperatura da Rampa 1")
        ElseIf Rampa1TextBox.Text.Length = 1 Then
            TempRampa1 = "0" + Rampa1TextBox.Text
        ElseIf Rampa1TextBox.Text.Length = 2 Then
            TempRampa1 = Rampa1TextBox.Text
        ElseIf Rampa1TextBox.Text.Length > 2 Then
            alerta = 1
            MessageBox.Show("A temperatura deve ter apenas 2 digitos")
        End If

        If Rampa2TextBox.Text.Length = 0 Then
            TempRampa2 = "00"
        ElseIf Rampa2TextBox.Text.Length = 1 Then
            TempRampa2 = "0" + Rampa2TextBox.Text
        ElseIf Rampa2TextBox.Text.Length = 2 Then
            TempRampa2 = Rampa2TextBox.Text
        ElseIf Rampa2TextBox.Text.Length > 2 Then
            alerta = 1
            MessageBox.Show("A temperatura deve ter apenas 2 digitos")
        End If

        If Rampa3TextBox.Text.Length = 0 Then
            TempRampa3 = "00"
        ElseIf Rampa3TextBox.Text.Length = 1 Then
            TempRampa3 = "0" + Rampa3TextBox.Text
        ElseIf Rampa3TextBox.Text.Length = 2 Then
            TempRampa3 = Rampa3TextBox.Text
        ElseIf Rampa3TextBox.Text.Length > 2 Then
            alerta = 1
            MessageBox.Show("A temperatura deve ter apenas 2 digitos")
        End If

        If MinRampa1TextBox.Text.Length = 0 Then
            alerta = 1
            MessageBox.Show("Colocar o tempo da Rampa 1")
        ElseIf MinRampa1TextBox.Text.Length = 1 Then
            TimeRampa1 = "0" + MinRampa1TextBox.Text
        ElseIf MinRampa1TextBox.Text.Length = 2 Then
            TimeRampa1 = MinRampa1TextBox.Text
        ElseIf MinRampa1TextBox.Text.Length > 2 Then
            alerta = 1
            MessageBox.Show("O tempo deve ter apenas 2 digitos")
        End If

        If MinRampa2TextBox.Text.Length = 0 Then
            TimeRampa2 = "00"
        ElseIf MinRampa2TextBox.Text.Length = 1 Then
            TimeRampa2 = "0" + MinRampa2TextBox.Text
        ElseIf MinRampa2TextBox.Text.Length = 2 Then
            TimeRampa2 = MinRampa2TextBox.Text
        ElseIf MinRampa2TextBox.Text.Length > 2 Then
            alerta = 1
            MessageBox.Show("O tempo deve ter apenas 2 digitos")
        End If

        If MinRampa3TextBox.Text.Length = 0 Then
            TimeRampa3 = "00"
        ElseIf MinRampa3TextBox.Text.Length = 1 Then
            TimeRampa3 = "0" + MinRampa3TextBox.Text
        ElseIf MinRampa3TextBox.Text.Length = 2 Then
            TimeRampa3 = MinRampa3TextBox.Text
        ElseIf MinRampa3TextBox.Text.Length > 2 Then
            alerta = 1
            MessageBox.Show("O tempo deve ter apenas 2 digitos")
        End If

        If Lupulo1TextBox.Text.Length = 0 Then
            alerta = 1
            MessageBox.Show("Não vai adicionar nenhum lúpulo?")
        ElseIf Lupulo1TextBox.Text.Length = 1 Then
            Lupulo1 = "0" + Lupulo1TextBox.Text
        ElseIf Lupulo1TextBox.Text.Length = 2 Then
            Lupulo1 = Lupulo1TextBox.Text
        ElseIf Lupulo1TextBox.Text.Length > 2 Then
            alerta = 1
            MessageBox.Show("O tempo deve ter apenas 2 digitos")
        End If

        If Lupulo2TextBox.Text.Length = 0 Then
            Lupulo2 = "00"
        ElseIf Lupulo2TextBox.Text.Length = 1 Then
            Lupulo2 = "0" + Lupulo2TextBox.Text
        ElseIf Lupulo2TextBox.Text.Length = 2 Then
            Lupulo2 = Lupulo2TextBox.Text
        ElseIf Lupulo2TextBox.Text.Length > 2 Then
            alerta = 1
            MessageBox.Show("O tempo deve ter apenas 2 digitos")
        End If

        If Lupulo3TextBox.Text.Length = 0 Then
            Lupulo3 = "00"
        ElseIf Lupulo3TextBox.Text.Length = 1 Then
            Lupulo3 = "0" + Lupulo3TextBox.Text
        ElseIf Lupulo3TextBox.Text.Length = 2 Then
            Lupulo3 = Lupulo3TextBox.Text
        ElseIf Lupulo3TextBox.Text.Length > 2 Then
            alerta = 1
            MessageBox.Show("O tempo deve ter apenas 2 digitos")
        End If

        If FervuraTextBox.Text.Length = 0 Then
            Fervura = "060"
        ElseIf FervuraTextBox.Text.Length = 1 Then
            Fervura = "00" + FervuraTextBox.Text
        ElseIf FervuraTextBox.Text.Length = 2 Then
            Fervura = "0" + FervuraTextBox.Text
        ElseIf FervuraTextBox.Text.Length = 3 Then
            Fervura = FervuraTextBox.Text
        ElseIf FervuraTextBox.Text.Length > 3 Then
            alerta = 1
            MessageBox.Show("O tempo deve ter apenas 3 digitos")
        End If

        If ResfriamentoTextBox.Text.Length = 0 Then
            TempResf = "20"
        ElseIf ResfriamentoTextBox.Text.Length = 1 Then
            TempResf = "0" + ResfriamentoTextBox.Text
        ElseIf ResfriamentoTextBox.Text.Length = 2 Then
            TempResf = ResfriamentoTextBox.Text
        ElseIf ResfriamentoTextBox.Text.Length > 2 Then
            alerta = 1
            MessageBox.Show("A temperatura deve ter apenas 2 digitos")
        End If

        If alerta = 1 Then
            TempRampa1 = "00"
            TempRampa2 = "00"
            TempRampa3 = "00"
            TimeRampa1 = "00"
            TimeRampa2 = "00"
            TimeRampa3 = "00"
            Lupulo1 = "00"
            Lupulo2 = "00"
            Lupulo3 = "00"
            Fervura = "000"
            TempResf = "00"
        Else
            MessageBox.Show("Enviado com sucesso")
            estado = 0
            Rampa1TextBox.Clear()
            Rampa2TextBox.Clear()
            Rampa3TextBox.Clear()
            MinRampa1TextBox.Clear()
            MinRampa2TextBox.Clear()
            MinRampa3TextBox.Clear()
            Lupulo1TextBox.Clear()
            Lupulo2TextBox.Clear()
            Lupulo3TextBox.Clear()
            FervuraTextBox.Clear()
            ResfriamentoTextBox.Clear()

        End If

    End Sub


    Private Sub Button_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Connect.Click
        SerialPort1.BaudRate = "9600"
        If ComboBox_AvailableSerialPorts.Text.Contains("COM") Then
            SerialPort1.PortName = ComboBox_AvailableSerialPorts.Text
            Button_Connect.Visible = False
            Button_Disconnect.Visible = True

            If SerialPort1.IsOpen = False Then
                SerialPort1.Open()
            End If
            Timer1.Enabled = True
        Else
            MessageBox.Show("nenhuma porta")
        End If

    End Sub

    Private Sub Button_Disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Disconnect.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
        End If

        Button_Connect.Visible = True
        Button_Disconnect.Visible = False

        Timer1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        contadoratual = contadoratual + 1

        ConfereNiveis()
        Estados()
        estadoTextBox.Text = CStr(estado)
        Dim Palavra As String
        TempPanela1 = CStr(CInt(TempPanela1))
        TempPanela1 = doiscaracteres(TempPanela1)
        If TempPanela2.Length > 2 Then
            TempPanela2 = Mid(TempPanela2, 1, 2)
        End If

        Palavra = "a" + CStr(ServoMotor1) + CStr(ServoMotor2) + CStr(ServoMotor3) + CStr(solenoide1) + CStr(solenoide2) + CStr(solenoide3) + CStr(BombaRecirculacao) + CStr(BombaResfriamento) + CStr(Buzzer) + TempPanela1 + TempPanela2 + "b"

        If SerialPort1.IsOpen = True Then

            Try
                SerialPort1.Write(Palavra)
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try

            Dim ReceivedMessage As String

            If SerialPort1.BytesToRead <> 0 Then
                ReceivedMessage = SerialPort1.ReadExisting
                SplitText(ReceivedMessage)
            Else

            End If

        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If Iniciarflag = True Then
            PassaEstado()
        End If

        Estados()
        atualizaimagens()
        ControleTemperatura()


        For Each AvailableSerialPorts As String In IO.Ports.SerialPort.GetPortNames()
            If ComboBox_AvailableSerialPorts.Items.Contains(AvailableSerialPorts) Then

            Else
                ComboBox_AvailableSerialPorts.Items.Add(AvailableSerialPorts)
                ComboBox_AvailableSerialPorts.Text = AvailableSerialPorts
            End If
        Next
    End Sub

    Private Sub ComboBox_AvailableSerialPorts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_AvailableSerialPorts.SelectedIndexChanged
        ComboBox_AvailableSerialPorts.Items.Clear()
        ComboBox_AvailableSerialPorts.Items.Add("Default")
        For Each AvailableSerialPorts As String In IO.Ports.SerialPort.GetPortNames()
            If ComboBox_AvailableSerialPorts.Items.Contains(AvailableSerialPorts) Then

            Else
                ComboBox_AvailableSerialPorts.Items.Add(AvailableSerialPorts)
            End If
        Next
    End Sub


    'Serial Port Receiving Code(Invoke) Starts Here ....
    Private Sub SplitText(ByVal [text] As String)
        LeituraPanela1 = Mid([text], 1, 5)
        LeituraPanela2 = Mid([text], 6, 5)
        LeituraPanela3 = Mid([text], 11, 5)
        Chama1 = Mid([text], 16, 1)
        Chama2 = Mid([text], 17, 1)
        Chama3 = Mid([text], 18, 1)
        Nivel1 = Mid([text], 19, 1)
        Nivel2 = Mid([text], 20, 1)
        Nivel3 = Mid([text], 21, 1)
        temp1.Text = LeituraPanela1
        temp2.Text = LeituraPanela2
        temp3.Text = LeituraPanela3
        'TextBox1.Text = contadoratual
        estadoTextBox.Text = CStr(estado)

        If Nivel1 = "1" Then
            TextBox6.Text = "ON"
        Else
            TextBox6.Text = "OFF"
        End If

        If Nivel2 = "1" Then
            TextBox7.Text = "ON"
        Else
            TextBox7.Text = "OFF"
        End If

        If Nivel3 = "1" Then
            TextBox8.Text = "ON"
        Else
            TextBox8.Text = "OFF"
        End If

        If Chama1 = "1" Then
            TextBox3.Text = "ON"
        Else
            TextBox3.Text = "OFF"
        End If

        If Chama2 = "1" Then
            TextBox4.Text = "ON"
        Else
            TextBox4.Text = "OFF"
        End If

        If Chama3 = "1" Then
            TextBox5.Text = "ON"
        Else
            TextBox5.Text = "OFF"
        End If

    End Sub

    Private Sub ControleTemperatura()
        If (estado = 5 Or estado = 4 Or estado = 4.2 Or estado = 4.4 Or estado = 3 Or estado = 2 Or estado = 1 Or estado = 0) And (CInt(LeituraPanela1) + 1) <= CInt(TempPanela1) Then
            ServoMotor1 = 1
        Else
            ServoMotor1 = 0
        End If

        If (estado = 4 Or estado = 4.2 Or estado = 4.4 Or estado = 3 Or estado = 2) And (CInt(LeituraPanela2) + 1) <= CInt(TempPanela2) Then
            ServoMotor2 = 1
        Else
            ServoMotor2 = 0
        End If

    End Sub


    Private Sub ConfereNiveis()
        If Nivel1 = "1" Then
            solenoide1 = "0"
        End If
        If Nivel2 = "1" Then
            solenoide2 = "0"
        End If
        If Nivel3 = "1" Then
            solenoide3 = "0"
        End If

    End Sub

    Public Sub Estados()
        If estado = 0 And Nivel1 = "0" Then
            ServoMotor1 = 1
            ServoMotor2 = 0
            ServoMotor3 = 0
            solenoide1 = 1
            solenoide2 = 0
            solenoide3 = 0
            BombaRecirculacao = 0
            BombaResfriamento = 0
            Buzzer = 0

            TempPanela1 = TempRampa1
            TempPanela2 = "00"
            Etapabox.Text = "Pré-Mostura 0"
        ElseIf estado = 1 And Nivel1 = "0" Then
            solenoide1 = 0
            solenoide2 = 0
            solenoide3 = 0
        ElseIf estado = 2 And Nivel2 = "0" Then
            solenoide1 = 0
            solenoide2 = 1
            solenoide3 = 0
        ElseIf estado = 3 And Nivel1 = "0" Then
            solenoide1 = 1
            solenoide2 = 0
            solenoide3 = 0
        ElseIf estado = 4 Then
            solenoide1 = 0
            solenoide2 = 0
            solenoide3 = 0
        ElseIf estado = 5 And Nivel3 = "0" Then
            solenoide1 = 0
            solenoide2 = 0
            solenoide3 = 1
        ElseIf estado = 6 And Nivel2 = "0" Then
            solenoide1 = 0
            solenoide2 = 1
        ElseIf estado = 6 And Nivel3 = "0" Then
            solenoide1 = 0
            solenoide2 = 0
            solenoide3 = 1
        ElseIf estado = 10 Then
            ServoMotor1 = 0
            ServoMotor2 = 0
            ServoMotor3 = 0
            solenoide1 = 0
            solenoide2 = 0
            solenoide3 = 0
            BombaRecirculacao = 0
            BombaResfriamento = 0
            Buzzer = 0

            Valv1g.Visible = False
            Valv1r.Visible = True
            Valv2g.Visible = False
            Valv2r.Visible = True
            Valv3g.Visible = False
            Valv3r.Visible = True
            Panela1vazia.Visible = True
            Panela1meia.Visible = False
            Panela1cheia.Visible = False
            Panela2Malte.Visible = True
            Panela2cheia.Visible = False
            Panela3vazia.Visible = True
            Panela3cheia.Visible = False
            Fogo1.Visible = False
            Fogo2.Visible = False
            Fogo3.Visible = False
            bomba1M.Visible = False
            bomba1P.Visible = True
            bomba2M.Visible = False
            bomba2P.Visible = True

        End If
    End Sub

    Private Sub RegistrarFim()
        Dim file As New System.IO.StreamWriter(path, True)
        file.Close()
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)

        file.WriteLine(DateTime.Now.ToLongDateString())
        file.WriteLine(DateTime.Now.ToLongTimeString() + "Fim")
        file.Close()
        Dim ask As MsgBoxResult
        If flagfim = True Then
            flagfim = False
            ask = MsgBox("Bora fermentar?", MsgBoxStyle.YesNo, "Fim da Brassagem")
        End If

        If ask = MsgBoxResult.Yes Then
            estado = 10
        End If
    End Sub

    Private Sub PassaEstado()
        If LeituraPanela1 = "-1.00" Then
            LeituraPanela1 = "1"
        End If
        If LeituraPanela2 = "-1.00" Then
            LeituraPanela2 = "1"
        End If
        If LeituraPanela2 = "-1.00" Then
            LeituraPanela2 = "1"
        End If

        If estado = 0 And Nivel1 = "1" Then  'Pré Mostura 0
            estado = 1
            If CInt(TempRampa1) < 10 Then
                TempPanela1 = "0" + CStr(CInt(TempRampa1))
            ElseIf CInt(TempRampa1) > 9 Then
                TempPanela1 = CStr(CInt(TempRampa1))
            End If
            TempPanela2 = "00"
            Referencia2TextBox.Text = "Sem Controle"
            Referencia1Textbox.Text = TempPanela1

            ServoMotor1 = 1
            ServoMotor2 = 0
            ServoMotor3 = 0
            solenoide1 = 0
            solenoide2 = 0
            solenoide3 = 0
            BombaRecirculacao = 0
            BombaResfriamento = 0
            Etapabox.Text = "Pré-Mostura 1"
            EscreveAoLadoDaHora("Aquecendo água para Mostura")

        ElseIf estado = 1 And CInt(LeituraPanela1 + 2) > (CInt(TempRampa1)) Then 'Pré- Mostura
            estado = 2
            If CInt(TempRampa1) < 10 Then
                TempPanela1 = "0" + CStr(CInt(TempRampa1))
            ElseIf CInt(TempRampa1) > 9 Then
                TempPanela1 = CStr(CInt(TempRampa1))
            End If
            TempPanela2 = "00"
            Referencia2TextBox.Text = "Sem Controle"
            Referencia1Textbox.Text = TempPanela1

            ServoMotor1 = 1
            ServoMotor2 = 0
            ServoMotor3 = 0
            solenoide1 = 0
            solenoide2 = 1
            solenoide3 = 0
            BombaRecirculacao = 0
            BombaResfriamento = 0
            EscreveAoLadoDaHora("Passando a água para caldeira 2")

            Etapabox.Text = "Mostura 0"

        ElseIf estado = 2 And Nivel2 = "1" Then 'Mostura 0
            estado = 3

            TempPanela1 = "78"
            TempPanela2 = "00"
            Referencia2TextBox.Text = "Sem Controle"
            Referencia1Textbox.Text = TempPanela1

            ServoMotor1 = 1
            ServoMotor2 = 1
            ServoMotor3 = 0
            solenoide1 = 1
            solenoide2 = 0
            solenoide3 = 0
            BombaRecirculacao = 1
            BombaResfriamento = 0

            EscreveAoLadoDaHora("Enchendo a caldeira 1")

            Etapabox.Text = "Mostura 1"

        ElseIf estado = 3 And Nivel1 = "1" Then 'Mostura 1

            TempPanela1 = "78"
            TempPanela2 = doiscaracteres(TempRampa1)
            Referencia2TextBox.Text = TempRampa1
            Referencia1Textbox.Text = TempPanela1

            ServoMotor1 = 1
            ServoMotor2 = 1
            ServoMotor3 = 0
            solenoide1 = 0
            solenoide2 = 0
            solenoide3 = 0
            BombaRecirculacao = 1
            BombaResfriamento = 0


            Etapabox.Text = "Aqc. Rampa 1"

            If (LeituraPanela2 + 2) >= TempRampa1 Then
                estado = 4
                contadorinicio = contadoratual

                ServoMotor1 = 1
                ServoMotor2 = 1
                ServoMotor3 = 0
                solenoide1 = 0
                solenoide2 = 0
                solenoide3 = 0
                BombaRecirculacao = 1
                BombaResfriamento = 0

                EscreveAoLadoDaHora("Começo Rampa 1")

                Etapabox.Text = "Rampa 1"
            End If

        ElseIf estado = 4 And (contadoratual - contadorinicio) > (CInt(TimeRampa1) * 60) Then 'Mostura 2

            TempPanela1 = "78"
            TempPanela2 = doiscaracteres(TempRampa2)
            Referencia2TextBox.Text = TempRampa2
            Referencia1Textbox.Text = TempPanela1

            Etapabox.Text = "Aqc. Rampa 2"

            If (LeituraPanela2 + 2) >= TempRampa2 Then
                estado = 4.2
                contadorinicio = contadoratual

                EscreveAoLadoDaHora("Começo Rampa 2")

                Etapabox.Text = "Rampa 2"
            End If

        ElseIf estado = 4.2 And (contadoratual - contadorinicio) > (CInt(TimeRampa2) * 60) Then
            TempPanela1 = "78"
            TempPanela2 = doiscaracteres(TempRampa3)
            Referencia2TextBox.Text = TempRampa3
            Referencia1Textbox.Text = TempPanela1

            Etapabox.Text = "Aqc. Rampa 3"

            If (LeituraPanela2 + 2) >= TempRampa3 Then
                estado = 4.4
                contadorinicio = contadoratual

                EscreveAoLadoDaHora("Começo Rampa 3")

                Etapabox.Text = "Rampa 3"
            End If


        ElseIf estado = 4.4 And (contadoratual - contadorinicio) > (CInt(TimeRampa3) * 60) Then
            estado = 5
            contadorinicio = contadoratual
            TempPanela1 = "78"
            TempPanela2 = doiscaracteres(TempRampa3)
            Referencia2TextBox.Text = TempRampa3
            Referencia1Textbox.Text = TempPanela1

            ServoMotor1 = 1
            ServoMotor2 = 0
            ServoMotor3 = 0
            solenoide1 = 0
            solenoide2 = 0
            solenoide3 = 1
            BombaRecirculacao = 0
            BombaResfriamento = 0
            EscreveAoLadoDaHora("Esperando Aquecer Água para Lavagem")

        ElseIf estado = 5 And (contadoratual - contadorinicio) > 240 Then 'Pré-Lavagem

            TempPanela1 = "78"
            TempPanela2 = "00"
            Referencia2TextBox.Text = "Sem Controle"

            ServoMotor1 = 1
            ServoMotor2 = 0
            ServoMotor3 = 0
            solenoide1 = 0
            solenoide2 = 0
            solenoide3 = 0
            BombaRecirculacao = 0
            BombaResfriamento = 0



            If (LeituraPanela1 + 2) >= 78 Then
                estado = 6
                ServoMotor1 = 0
                ServoMotor2 = 0
                ServoMotor3 = 1
                solenoide1 = 0
                solenoide2 = 1
                solenoide3 = 1
                BombaRecirculacao = 0
                BombaResfriamento = 0
                contadorinicio = contadoratual

                EscreveAoLadoDaHora("Começou a Lavagem")

                Etapabox.Text = "Lavagem"
            End If
            

        ElseIf estado = 6 And ((contadoratual - contadorinicio) > 300 Or Nivel3 = "1") Then 'Lavagem


            TempPanela1 = "00"
            TempPanela2 = "00"
            Referencia2TextBox.Text = "Sem Controle"
            Referencia1Textbox.Text = TempPanela1

            ServoMotor1 = 0
            ServoMotor2 = 0
            ServoMotor3 = 1
            solenoide1 = 0
            solenoide2 = 0
            solenoide3 = 0
            BombaRecirculacao = 0
            BombaResfriamento = 0

            Etapabox.Text = "Fervura"

            If EscreverUmaVez = True Then
                EscreverUmaVez = False
                EscreveAoLadoDaHora("Esperando aquecer pra fervura")
            End If

            If LeituraPanela3 > 98 Then
                estado = 7
                contadorinicio = contadoratual
                TempPanela1 = "00"
                TempPanela2 = "00"
                Referencia2TextBox.Text = "Sem Controle"

                EscreveAoLadoDaHora("Começou a fervura")
            End If

            ElseIf estado = 7 And (contadoratual - contadorinicio) > (CInt(Fervura) - CInt(Lupulo1)) * 60 Then 'Fervura
                estado = 7.2
                Buzzer = 1
                contadorinicio = contadoratual
                TempPanela1 = "00"
                TempPanela2 = "00"
                Referencia2TextBox.Text = "Sem Controle"
                Referencia1Textbox.Text = TempPanela1
                AddLupulo.Show()



            ElseIf estado = 7.2 And (contadoratual - contadorinicio) > (CInt(Fervura) - CInt(Lupulo2)) * 60 Then
                estado = 7.4
                TempPanela1 = "00"
                TempPanela2 = "00"
                Referencia2TextBox.Text = "Sem Controle"
                If AddLupulo.Visible Then

                Else
                    Buzzer = 1
                    AddLupulo.Show()
                End If

            ElseIf estado = 7.4 And (contadoratual - contadorinicio) > (CInt(Fervura) - CInt(Lupulo3)) * 60 Then
                estado = 7.6
                TempPanela1 = "00"
                TempPanela2 = "00"
                Referencia2TextBox.Text = "Sem Controle"
                If AddLupulo.Visible Then

                Else
                    Buzzer = 1
                    AddLupulo.Show()
                End If

            ElseIf estado = 7.6 And (contadoratual - contadorinicio) > CInt(Fervura) * 60 Then
                estado = 8
                Buzzer = 1
                contadorinicio = contadoratual
                TempPanela1 = "00"
                TempPanela2 = "00"
                Referencia2TextBox.Text = "Sem Controle"
                AddLupulo.Show()

                ServoMotor1 = 0
                ServoMotor2 = 0
                ServoMotor3 = 0
                solenoide1 = 0
                solenoide2 = 0
                solenoide3 = 0
                BombaRecirculacao = 0
                BombaResfriamento = 1

                EscreveAoLadoDaHora("Começo do Resfriamento")

                Etapabox.Text = "Resfriamento"
                flagfim = True

            ElseIf estado = 8 And (LeituraPanela3) < TempResf Then 'Resfriamento
                estado = 9
                TempPanela1 = "00"
                TempPanela2 = "00"
                Referencia2TextBox.Text = "Sem Controle"

                ServoMotor1 = 0
                ServoMotor2 = 0
                ServoMotor3 = 0
                solenoide1 = 0
                solenoide2 = 0
                solenoide3 = 0
                BombaRecirculacao = 0
                BombaResfriamento = 0
                Buzzer = 1

                RegistrarFim()
                Etapabox.Text = "FIM"


            ElseIf estado = 9 Then 'Fim
                'estado = 10
                TempPanela1 = "00"
                TempPanela2 = "00"
                Referencia2TextBox.Text = "Sem Controle"

                ServoMotor1 = 0
                ServoMotor2 = 0
                ServoMotor3 = 0
                solenoide1 = 0
                solenoide2 = 0
                solenoide3 = 0
                BombaRecirculacao = 0
                BombaResfriamento = 0
                Buzzer = 0

                Valv1g.Visible = False
                Valv1r.Visible = True
                Valv2g.Visible = False
                Valv2r.Visible = True
                Valv3g.Visible = False
                Valv3r.Visible = True
                Panela1vazia.Visible = True
                Panela1meia.Visible = False
                Panela1cheia.Visible = False
                Panela2Malte.Visible = True
                Panela2cheia.Visible = False
                Panela3vazia.Visible = True
                Panela3cheia.Visible = False
                Fogo1.Visible = False
                Fogo2.Visible = False
                Fogo3.Visible = False
                bomba1M.Visible = False
                bomba1P.Visible = True
                bomba2M.Visible = False
                bomba2P.Visible = True
            ElseIf estado > 9 Then
                estado = 10

            End If



    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddLupulo.Show()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim file As New System.IO.StreamWriter(path, True)
        file.Close()
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        file.WriteLine(LeituraPanela1 + ";" + LeituraPanela2 + ";" + LeituraPanela3)
        file.Close()
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        estado = 10
    End Sub

    Private Sub atualizaimagens()
        If ServoMotor1 = 1 Then
            Fogo1.Visible = True
        End If
        If ServoMotor2 = 1 Then
            Fogo2.Visible = True
        End If
        If ServoMotor3 = 1 Then
            Fogo3.Visible = True
        End If

        If ServoMotor1 = 0 Then
            Fogo1.Visible = False
        End If
        If ServoMotor2 = 0 Then
            Fogo2.Visible = False
        End If
        If ServoMotor3 = 0 Then
            Fogo3.Visible = False
        End If

        If solenoide1 = 1 Then
            Valv1g.Visible = True
            Valv1r.Visible = False
        ElseIf solenoide1 = 0 Then
            Valv1r.Visible = True
            Valv1g.Visible = False
        End If

        If solenoide2 = 1 Then
            Valv2g.Visible = True
            Valv2r.Visible = False
        ElseIf solenoide2 = 0 Then
            Valv2r.Visible = True
            Valv2g.Visible = False
        End If
        If solenoide3 = 1 Then
            Valv3g.Visible = True
            Valv3r.Visible = False
        ElseIf solenoide3 = 0 Then
            Valv3r.Visible = True
            Valv3g.Visible = False
        End If

        If Nivel1 = 1 Then
            Panela1vazia.Visible = False
            Panela1meia.Visible = True
        ElseIf Nivel1 = 0 Then
            Panela1vazia.Visible = True
            Panela1meia.Visible = False
        End If

        If Nivel2 = 1 Then
            Panela2cheia.Visible = True
            Panela2Malte.Visible = False
        ElseIf Nivel2 = 0 Then
            Panela2cheia.Visible = False
            Panela2Malte.Visible = True
        End If

        If Nivel3 = 1 Then
            Panela3vazia.Visible = False
            Panela3cheia.Visible = True
        ElseIf Nivel1 = 0 Then
            Panela3vazia.Visible = True
            Panela3cheia.Visible = False
        End If

        If BombaRecirculacao = 1 Then
            bomba1M.Visible = True
            bomba1P.Visible = False
        ElseIf BombaRecirculacao = 0 Then
            bomba1M.Visible = False
            bomba1P.Visible = True
        End If

        If BombaResfriamento = 1 Then
            bomba2M.Visible = True
            bomba2P.Visible = False
        ElseIf BombaResfriamento = 0 Then
            bomba2M.Visible = False
            bomba2P.Visible = True
        End If
    End Sub

    Function doiscaracteres(ByVal [text] As String)
        If CInt([text]) < 10 Then
            [text] = "0" + [text]
        ElseIf CInt([text]) > 9 Then
            [text] = [text]
        ElseIf CInt([text]) > 99 Then
            [text] = "99"
        End If

        Return [text]
    End Function

    Private Sub ResetButton_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        estado = 10
    End Sub


    Public Sub EscreveAoLadoDaHora(ByVal [text] As String)
        Dim file As New System.IO.StreamWriter(path, True)
        file.Close()
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        file.WriteLine(DateTime.Now.ToLongTimeString() + " " + [text])
        file.Close()
    End Sub


End Class
