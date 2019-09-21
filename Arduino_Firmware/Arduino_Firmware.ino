#include <OneWire.h>
#include <Wire.h>
#include <Servo.h>  //Incluimos a livraria servo.h

//pinos das saidas
#define SM1 11
#define SM2 10
#define SM3 9
#define VS1 8
#define VS2 7
#define VS3 6
#define Brec 5
#define Bref 4
#define Buzzer 3

//pinos das entradas
#define SensorTemp1 2
#define SensorTemp2 12
#define SensorTemp3 13
#define SensorChama1 A0
#define SensorChama2 A1
#define SensorChama3 A2
#define SensorNivel1 A3
#define SensorNivel2 A4
#define SensorNivel3 A5


OneWire ds1(SensorTemp1);  // on digital pin 8
OneWire ds2(SensorTemp2);  // on digital pin 9
OneWire ds3(SensorTemp3);  // on digital pin 9

Servo servo1;  // Cria um Objeto servo chamado Servo1
Servo servo2;  // Cria um Objeto servo chamado Servo1
Servo servo3;  // Cria um Objeto servo chamado Servo1


int i = 0, j = 0, k = 0;
int semcomunicacao = 0;
float tempo_anterior1 = 0;
float tempo_anterior2 = 0;
int flagSM1 = 0, flagSM2 = 0, flagSM3 = 0;
float Temperatura_atual = 50;
float referencia = 0;
float sinal_graus = 92;
float sinal_controle_pres1 = 0, sinal_controle_pas1 = 0, sinal_erro_pres1 = 0, sinal_erro_pas1 = 0;
float sinal_graus1;
float sinal_graus2;
float sinal_controle_pres2 = 0, sinal_controle_pas2 = 0, sinal_erro_pres2 = 0, sinal_erro_pas2 = 0;


float controle2(int flagSM2, int temperatura2) {
  if ((millis() - tempo_anterior2) > 5000 && flagSM2) {
    tempo_anterior2 = millis();

    referencia = temperatura2;

    sinal_erro_pres2 = referencia - getTemp2();

    sinal_controle_pres2 = sinal_controle_pas2 + 5.25 * sinal_erro_pres2 - 5.248 * sinal_erro_pas2;

    sinal_graus2 = 90 - sinal_controle_pres2;

    sinal_erro_pas2 = sinal_erro_pres2;

    sinal_controle_pas2 = sinal_controle_pres2;

    if (sinal_graus2 > 92 || sinal_controle_pres2 < 5) {
      sinal_graus2 = 92;
    }

    if (sinal_graus2 < 55) {
      sinal_graus2 = 55;
    }
  }
}

float controle1(int flagSM1, int temperatura1) {
  if ((millis() - tempo_anterior1) > 5000 && flagSM1) {
    tempo_anterior1 = millis();

    referencia = temperatura1;

    sinal_erro_pres1 = referencia - getTemp1();

    sinal_controle_pres1 = sinal_controle_pas1 + 5.25 * sinal_erro_pres1 - 5.248 * sinal_erro_pas1;

    sinal_erro_pas1 = sinal_erro_pres1;

    sinal_controle_pas1 = sinal_controle_pres1;

    sinal_graus1 = 90 - sinal_controle_pres1;

    if (sinal_graus1 > 92 || sinal_controle_pres1 < 5) {
      sinal_graus1 = 92;
    }

    if (sinal_graus1 < 55) {
      sinal_graus1 = 55;
    }
  }
}


float getTemp1() {
  //returns the temperature from one DS18S20 in DEG Celsius

  byte data[12];
  byte addr[8];

  if ( !ds1.search(addr)) {
    //no more sensors on chain, reset search
    ds1.reset_search();
    return -1;
  }

  if ( OneWire::crc8( addr, 7) != addr[7]) {
    Serial.println("CRC is not valid!");
    return -1;
  }

  if ( addr[0] != 0x10 && addr[0] != 0x28) {
    Serial.print("Device is not recognized");
    return -1;
  }

  ds1.reset();
  ds1.select(addr);
  ds1.write(0x44, 1); // start conversion, with parasite power on at the end

  byte present = ds1.reset();
  ds1.select(addr);
  ds1.write(0xBE); // Read Scratchpad


  for (int i = 0; i < 9; i++) { // we need 9 bytes
    data[i] = ds1.read();
  }

  ds1.reset_search();

  byte MSB = data[1];
  byte LSB = data[0];

  float tempRead = ((MSB << 8) | LSB); //using two's compliment
  float TemperatureSum = tempRead / 16;

  return TemperatureSum;

}


float getTemp2() {
  //returns the temperature from one DS18S20 in DEG Celsius

  byte data[12];
  byte addr[8];

  if ( !ds2.search(addr)) {
    //no more sensors on chain, reset search
    ds2.reset_search();
    return -1;
  }

  if ( OneWire::crc8( addr, 7) != addr[7]) {
    Serial.println("CRC is not valid!");
    return -1;
  }

  if ( addr[0] != 0x10 && addr[0] != 0x28) {
    Serial.print("Device is not recognized");
    return -1;
  }

  ds2.reset();
  ds2.select(addr);
  ds2.write(0x44, 1); // start conversion, with parasite power on at the end

  byte present = ds2.reset();
  ds2.select(addr);
  ds2.write(0xBE); // Read Scratchpad


  for (int i = 0; i < 9; i++) { // we need 9 bytes
    data[i] = ds2.read();
  }

  ds2.reset_search();

  byte MSB = data[1];
  byte LSB = data[0];

  float tempRead = ((MSB << 8) | LSB); //using two's compliment
  float TemperatureSum = tempRead / 16;

  return TemperatureSum;

}

float getTemp3() {
  //returns the temperature from one DS18S20 in DEG Celsius
  byte data[12];
  byte addr[8];
  if ( !ds3.search(addr)) {
    //no more sensors on chain, reset search
    ds3.reset_search();
    return -1;
  }
  if ( OneWire::crc8( addr, 7) != addr[7]) {
    Serial.println("CRC is not valid!");
    return -1;
  }
  if ( addr[0] != 0x10 && addr[0] != 0x28) {
    Serial.print("Device is not recognized");
    return -1;
  }
  ds3.reset();
  ds3.select(addr);
  ds3.write(0x44, 1); // start conversion, with parasite power on at the end

  byte present = ds3.reset();
  ds3.select(addr);
  ds3.write(0xBE); // Read Scratchpad
  for (int i = 0; i < 9; i++) { // we need 9 bytes
    data[i] = ds3.read();
  }
  ds3.reset_search();
  byte MSB = data[1];
  byte LSB = data[0];
  float tempRead = ((MSB << 8) | LSB); //using two's compliment
  float TemperatureSum = tempRead / 16;
  return TemperatureSum;
}

int Confereestado(char info[15]) {
  int flag = 0;
  // Se saidas do estado 0 um forem a entrada, então flag é 1
  if (info[2] == 0 && info[3] == 0 && info[4] == 1 && info[5] == 0 && info[6] == 0 && info[7] == 0 && info[8] == 0 && info[9] == 0) {
    flag = 1;
  }
  // Se saidas do estado 1 um forem a entrada, então flag é 1
  if (info[2] == 0 && info[3] == 0 && info[4] == 0 && info[5] == 0 && info[6] == 0 && info[7] == 0 && info[8] == 0 && info[9] == 0) {
    flag = 1;
  }
  // Se saidas do estado 2 um forem a entrada, então flag é 1
  if (info[3] == 0 && info[4] == 0 && info[5] == 1 && info[6] == 0 && info[7] == 0 && info[8] == 0 && info[9] == 0) {
    flag = 1;
  }
  // Se saidas do estado 3 um forem a entrada, então flag é 1
  if (info[3] == 0 && info[4] == 1 && info[5] == 0 && info[6] == 0 && info[7] == 1 && info[8] == 0 && info[9] == 0) {
    flag = 1;
  }
  // Se saidas do estado 4 um forem a entrada, então flag é 1
  if (info[3] == 0 && info[4] == 0 && info[5] == 0 && info[6] == 0 && info[7] == 1 && info[8] == 0 && info[9] == 0) {
    flag = 1;
  }
  // Se saidas do estado 5 um forem a entrada, então flag é 1
  if (info[2] == 0 && info[3] == 1 && info[4] == 0 && info[5] == 0 && info[6] == 1 && info[7] == 0 && info[8] == 0 && info[9] == 0) {
    flag = 1;
  }
  if (info[2] == 0 && info[3] == 0 && info[4] == 0 && info[5] == 0 && info[6] == 1 && info[7] == 0 && info[8] == 0 && info[9] == 0) {
    flag = 1;
  }
  // Se saidas do estado 6 um forem a entrada, então flag é 1
  if (info[1] == 0 && info[2] == 0 && info[3] == 1 && info[4] == 0 && info[5] == 1 && info[6] == 1 && info[7] == 0 && info[8] == 0 && info[9] == 0) {
    flag = 1;
  }
  // Se saidas do estado 7 um forem a entrada, então flag é 1
  if (info[1] == 0 && info[2] == 0 && info[3] == 1 && info[4] == 0 && info[5] == 0 && info[6] == 0 && info[7] == 0 && info[8] == 0) {
    flag = 1;
  }
  // Se saidas do estado 8 um forem a entrada, então flag é 1
  if (info[1] == 0 && info[2] == 0 && info[3] == 0 && info[4] == 0 && info[5] == 0 && info[6] == 0 && info[7] == 0 && info[8] == 1 ) {
    flag = 1;
  }
  if (info[1] == 0 && info[2] == 0 && info[3] == 0 && info[4] == 0 && info[5] == 0 && info[6] == 0 && info[7] == 0 && info[8] == 0 && info[9] == 1) {
    flag = 1;
  }
  return flag;
}



void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  // Declara os servo motores nos seus devidos pinos
  servo1.attach(SM1);
  servo2.attach(SM2);
  servo3.attach(SM3);
  servo1.write(90);  // Garante que todas as válvulas estão fechadas
  servo2.write(90);
  servo3.write(90);


  //entradas
  pinMode(SensorChama1, INPUT);
  pinMode(SensorChama2, INPUT);
  pinMode(SensorChama3, INPUT);
  pinMode(SensorNivel1, INPUT);
  pinMode(SensorNivel2, INPUT);
  pinMode(SensorNivel3, INPUT);

  //saidas
  pinMode(Buzzer, OUTPUT);
  pinMode(Bref, OUTPUT);
  pinMode(Brec, OUTPUT);
  pinMode(VS3, OUTPUT);
  pinMode(VS2, OUTPUT);
  pinMode(VS1, OUTPUT);
  pinMode(SM3, OUTPUT);
  pinMode(SM2, OUTPUT);
  //pinMode(SM1, OUTPUT);
  digitalWrite(Buzzer, LOW);
  digitalWrite(Bref, LOW);
  digitalWrite(Brec, LOW);
  digitalWrite(VS3, LOW);
  digitalWrite(VS2, LOW);
  digitalWrite(VS1, LOW);

}


void loop() {
  // put your main code here, to run repeatedly:

  char info[15];
  for (i = 0; i > 15; i++) {
    info[i] = '0';
  }

  int temperatura1, temperatura2, temperatura1_ant, temperatura2_ant;

  float panela1 = 100, panela2 = 100, panela3 = 100;

  float temp1 = getTemp1();
  float temp2 = getTemp2();
  float temp3 = getTemp3();

  int flagdado = 0;

  int Chama1 = digitalRead(SensorChama1);
  int Chama2 = digitalRead(SensorChama2);
  int Chama3 = digitalRead(SensorChama3);
  int Nivel1 = digitalRead(SensorNivel1);
  int Nivel2 = digitalRead(SensorNivel2);
  int Nivel3 = digitalRead(SensorNivel3);

  semcomunicacao = semcomunicacao + 1;
  // reply only when you receive data:
  if (Serial.available() > 0) {
    semcomunicacao  = 0;
    while (Serial.available() > 0) {
      // read the incoming byte:
      info[j] = Serial.read();
      j++;
    }
    j = 0;

    //Enviando os dados para o pc
    Serial.print(temp1);
    Serial.print(temp2);
    Serial.print(temp3);
    Serial.print(Chama1);
    Serial.print(Chama2);
    Serial.print(Chama3);
    Serial.print(Nivel1);
    Serial.print(Nivel2);
    Serial.print(Nivel3);
    //*/
    k = 0;

    for (i = 1; i < 13; i++) {
      if (info[i] != 0) {
        info[i] = info[i] - 48;
      }
    }

    flagdado = Confereestado(info);


    if (info[0] == 'a' && info[14] == 'b' && flagdado == 1) {
      temperatura1 = info[10] * 10 + info[11];
      temperatura2 = info[12] * 10 + info[13];

      digitalWrite(Buzzer, info[9]);
      digitalWrite(Bref, info[8]);
      digitalWrite(Brec, info[7]);
      digitalWrite(VS3, info[6]);
      digitalWrite(VS2, info[5]);
      digitalWrite(VS1, info[4]);
      //digitalWrite(SM3, info[3]);
      if (info[3] == 1) {
        servo3.write(65);
        flagSM3 = 1;
      }
      else if (info[3] == 0) {
        servo3.write(90);
      }
      //digitalWrite(SM2, info[2]);
      if (info[2] == 1) {
        servo2.write(sinal_graus2);
        if (flagSM2 == 0) {
          flagSM2 = 1;
          sinal_controle_pres2 = 0;
          sinal_controle_pas2 = 0;
        }
      }
      else if (info[2] == 0) {
        servo2.write(90);
        flagSM2 = 0;
      }
      if (info[1] == 1) {
        servo1.write(sinal_graus1);

        /*  Serial.print("sinal_graus:");
          Serial.print(sinal_graus1);

          Serial.print("Temperatura1:");
          Serial.print(temperatura1);

           Serial.print("FlagSM1:");
          Serial.print(flagSM1);


           Serial.print("sinal de Controle Pres:");
          Serial.print(sinal_controle_pres1);

          Serial.print("sinal de Erro Pres:");
          Serial.print(sinal_erro_pres1);

           Serial.print("sinal de erro Pas:");
          Serial.print(sinal_erro_pas1);

           Serial.print("Tempos:");
           Serial.print(tempo_anterior1);
          Serial.println(millis());

          //*/

        if (flagSM1 == 0) {
          flagSM1 = 1;
          sinal_controle_pres1 = 0;
          sinal_controle_pas1 = 0;
        }
      }
      else if (info[1] == 0) {
        servo1.write(90);
        flagSM1 = 0;
      }
    }
  }//finaliza if (Serial.available)

  delay(600);
  if (temperatura1 > 0 && temperatura1 < 100) {
    temperatura1_ant = temperatura1;
  }
  if (temperatura1 > 0 && temperatura1 < 100) {
    temperatura2_ant = temperatura2;
  }
  if (abs(temperatura1 - temperatura1_ant) < 5) {
    controle1(flagSM1, temperatura1);
  }
  if (abs(temperatura2 - temperatura2_ant) < 5) {
    controle2(flagSM2, temperatura2);
  }

  if (semcomunicacao > 10) {
    digitalWrite(Buzzer, LOW);
    digitalWrite(Bref, LOW);
    digitalWrite(Brec, LOW);
    digitalWrite(VS3, LOW);
    digitalWrite(VS2, LOW);
    digitalWrite(VS1, LOW);
    servo1.write(90);  // Garante que todas as válvulas estão fechadas
    servo2.write(90);
    servo3.write(90);
    flagSM1 = 0;
    flagSM2 = 0;
    flagSM3 = 0;
  }
}
