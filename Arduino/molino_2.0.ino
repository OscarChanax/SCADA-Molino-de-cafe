#include "max6675.h"
#include <Servo.h>

// Definición de pines para los sensores y pulsadores
#define SENSOR_CORRIENTE A2
#define PWM 3
#define thermoDO 4
#define thermoCS 5
#define thermoCLK 6
#define PULSADOR_MARCHA 9
#define PULSADOR_PARO 8


Servo servo_entrada, servo_salida;
MAX6675 thermocouple(thermoCLK, thermoCS, thermoDO);

float Sensibilidad = 0.100;
int marcha = 0;
int paro = 0;
int trigPin = 11;    // Disparador (Trigger)
int echoPin = 12;    // Eco (Echo)
long duration, cm;
float rpm = 0, corriente = 0;
bool detener = false;

void setup() {
  Serial.begin(9600);
  pinMode(PULSADOR_MARCHA, 0);
  pinMode(PULSADOR_PARO, 0);
  //pines para ultrasonico
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
  servo_entrada.attach(7);
  servo_salida.attach(10);
  pinMode(PWM, 1);
  pinMode(2, 1);//señal sig etapa
  pinMode(15, 1);//led rojo
  pinMode(14, 1);//led verde
  analogWrite(PWM, 0);
  digitalWrite(14, 0);
  digitalWrite(15, 0);
  digitalWrite(2, 0);
  servo_entrada.write(180); //90 abierto cerrado 180
  servo_salida.write(23);   //33 cerrado 100 abierto
  delay(500);
}
void loop() {
  if (Serial.available() >= 0) {
    String condicion = Serial.readStringUntil('\n');
    condicion.trim();
    if (digitalRead(PULSADOR_MARCHA) == 1 or condicion == "MARCHA")marcha = 1; else marcha = 0;
    if (digitalRead(PULSADOR_PARO) == 1 or condicion == "PARO")paro = 1; else paro = 0;

    while (marcha == 1) {
      Serial.println("sistema Iniciado");
      digitalWrite(14, 1);
      digitalWrite(15, 0);
      digitalWrite(2, 0);
      detener = false;
      sensores();
      // Recepción de comandos desde el SCADA
      String comando = Serial.readStringUntil('\n');
      procesarComando(comando);
      if (digitalRead(PULSADOR_PARO) == 1 or comando == "PARO") {
        paro = 1; marcha = 0; break; detener = true;
      }
    }
    while (paro == 1) {
      Serial.println("sistema detenido");
      digitalWrite(14, 0);
      digitalWrite(15, 1);
      digitalWrite(2, 0);
      analogWrite(PWM, 0);
      servo_entrada.write(180); //90 abierto cerrado 180
      servo_salida.write(23);   //33 cerrado 100 abierto
      enviarDatos(0, 0, 0, 0, marcha, paro);
      condicion = Serial.readStringUntil('\n');
      condicion.trim();
      if (digitalRead(PULSADOR_MARCHA) == 1 or condicion == "MARCHA") {
        marcha = 1; paro = 0; break;
      }
    }
  }
}
void sensores() {
  // Lectura de sensores
  int temperatura = thermocouple.readCelsius();
  // El sensor se activa con un pulso ALTO de 10 microsegundos o más
  // Emite un breve pulso BAJO antes para asegurar un pulso ALTO limpio:
  digitalWrite(trigPin, LOW);
  delayMicroseconds(5);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  // ping hasta la recepción de su eco de un objeto.
  pinMode(echoPin, INPUT);
  duration = pulseIn(echoPin, HIGH);
  // Convierte el tiempo en distancia
  int nivel = (duration / 2) / 29.1;   // Divide entre 29.1 o multiplica por 0.0343

  enviarDatos(corriente, rpm, temperatura, nivel, marcha, paro);
}

void enviarDatos(float corriente, float rpm, int temperatura, int nivel, bool marcha, bool paro) {
  Serial.print("C:");
  Serial.print(corriente, 3);
  Serial.print(",R:");
  Serial.print(rpm);
  Serial.print(",T:");
  Serial.print(temperatura);
  Serial.print(",N:");
  Serial.print(nivel);
  Serial.print(",M:");
  Serial.print(marcha);
  Serial.print(",P:");
  Serial.println(paro);
}

void procesarComando(String comando) {
  comando.trim();
  if (comando == "FINO") {

    evaluacion();
    if (detener == true)return;
    servo_entrada.write(90); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    servo_salida.write(26);   //33 cerrado 100 abierto
    evaluacion();
    if (detener == true)return;
    delay(7000);
    evaluacion();
    if (detener == true)return;
    servo_entrada.write(180); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    delay(1500);
    evaluacion();
    if (detener == true)return;

    for (int i = 0; i < 12; i++) {
      if (i == 0) {
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 70);
        evaluacion();
        if (detener == true)return;
        rpm = 300 + ((random(-20, 20) / 100.0) * 0.1);
        corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(5000);
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 0);
        evaluacion();
        if (detener == true)return;
        rpm = 0;
        corriente = 0;
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(1000);
      }
      else {
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 160);
        evaluacion();
        if (detener == true)return;
        rpm = 1200 + ((random(-20, 20) / 100.0) * 0.1);
        corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(5000);
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 0);
        evaluacion();
        if (detener == true)return;
        rpm = 0;
        corriente = 0;
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(1000);
      }
      evaluacion();
      if (detener == true)return;
    }
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 0);
    evaluacion();
    if (detener == true)return;
    delay(2000);
    servo_entrada.write(180); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    servo_salida.write(100);   //33 cerrado 100 abierto
    evaluacion();
    if (detener == true)return;
    delay(5000);
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 70);
    rpm = 300 + ((random(-20, 20) / 100.0) * 0.1);
    corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
    sensores();
    evaluacion();
    if (detener == true)return;
    delay(1000);
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 0);
    evaluacion();
    if (detener == true)return;
    rpm = 0;
    evaluacion();
    if (detener == true)return;
    corriente = 0;
    evaluacion();
    if (detener == true)return;
    sensores();
    evaluacion();
    if (detener == true)return;
    delay(1000);
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 70);
    evaluacion();
    if (detener == true)return;
    rpm = 300 + ((random(-20, 20) / 100.0) * 0.1);
    corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
    sensores();
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 0);
    evaluacion();
    if (detener == true)return;
    rpm = 0;
    corriente = 0;
    sensores();
    evaluacion();
    if (detener == true)return;
    delay(2000);
    evaluacion();
    if (detener == true)return;
    servo_entrada.write(180); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    servo_salida.write(23);   //33 cerrado 100 abierto
    evaluacion();
    if (detener == true)return;
    digitalWrite(2, 1);
    evaluacion();
    if (detener == true)return;

  } else if (comando == "MEDIO") {

    evaluacion();
    if (detener == true)return;
    servo_entrada.write(90); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    servo_salida.write(26);   //33 cerrado 100 abierto
    evaluacion();
    if (detener == true)return;
    delay(7000);
    evaluacion();
    if (detener == true)return;
    servo_entrada.write(180); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    delay(1500);
    evaluacion();
    if (detener == true)return;

    for (int i = 0; i < 7; i++) {
      if (i == 0) {
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 70);
        evaluacion();
        if (detener == true)return;
        rpm = 300 + ((random(-20, 20) / 100.0) * 0.1);
        corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(5000);
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 0);
        evaluacion();
        if (detener == true)return;
        rpm = 0;
        corriente = 0;
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(1000);
      }
      else {
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 110);
        evaluacion();
        if (detener == true)return;
        rpm = 600 + ((random(-20, 20) / 100.0) * 0.1);
        corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(5000);
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 0);
        evaluacion();
        if (detener == true)return;
        rpm = 0;
        corriente = 0;
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(1000);
      }
      evaluacion();
      if (detener == true)return;
    }
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 0);
    evaluacion();
    if (detener == true)return;
    delay(2000);
    servo_entrada.write(180); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    servo_salida.write(100);   //33 cerrado 100 abierto
    evaluacion();
    if (detener == true)return;
    delay(5000);
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 70);
    rpm = 300 + ((random(-20, 20) / 100.0) * 0.1);
    corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
    sensores();
    evaluacion();
    if (detener == true)return;
    delay(1000);
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 0);
    evaluacion();
    if (detener == true)return;
    rpm = 0;
    evaluacion();
    if (detener == true)return;
    corriente = 0;
    evaluacion();
    if (detener == true)return;
    sensores();
    evaluacion();
    if (detener == true)return;
    delay(1000);
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 70);
    evaluacion();
    if (detener == true)return;
    rpm = 300 + ((random(-20, 20) / 100.0) * 0.1);
    corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
    sensores();
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 0);
    evaluacion();
    if (detener == true)return;
    rpm = 0;
    corriente = 0;
    sensores();
    evaluacion();
    if (detener == true)return;
    delay(2000);
    evaluacion();
    if (detener == true)return;
    servo_entrada.write(180); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    servo_salida.write(26);   //33 cerrado 100 abierto
    evaluacion();
    if (detener == true)return;
    digitalWrite(2, 1);
    evaluacion();
    if (detener == true)return;

  } else if (comando == "GRUESO") {

    evaluacion();
    if (detener == true)return;
    servo_entrada.write(90); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    servo_salida.write(26);   //33 cerrado 100 abierto
    evaluacion();
    if (detener == true)return;
    delay(7000);
    evaluacion();
    if (detener == true)return;
    servo_entrada.write(180); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    delay(1500);
    evaluacion();
    if (detener == true)return;

    for (int i = 0; i < 3; i++) {
      if (i == 0) {
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 70);
        evaluacion();
        if (detener == true)return;
        rpm = 300 + ((random(-20, 20) / 100.0) * 0.1);
        corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(5000);
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 0);
        evaluacion();
        if (detener == true)return;
        rpm = 0;
        corriente = 0;
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(1000);
      }
      else {
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 80);
        evaluacion();
        if (detener == true)return;
        rpm = 450 + ((random(-20, 20) / 100.0) * 0.1);
        corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(5000);
        evaluacion();
        if (detener == true)return;
        analogWrite(PWM, 0);
        evaluacion();
        if (detener == true)return;
        rpm = 0;
        corriente = 0;
        sensores();
        evaluacion();
        if (detener == true)return;
        delay(1000);
      }
      evaluacion();
      if (detener == true)return;
    }
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 0);
    evaluacion();
    if (detener == true)return;
    delay(2000);
    servo_entrada.write(180); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    servo_salida.write(100);   //33 cerrado 100 abierto
    evaluacion();
    if (detener == true)return;
    delay(5000);
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 70);
    rpm = 300 + ((random(-20, 20) / 100.0) * 0.1);
    corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
    sensores();
    evaluacion();
    if (detener == true)return;
    delay(1000);
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 0);
    evaluacion();
    if (detener == true)return;
    rpm = 0;
    evaluacion();
    if (detener == true)return;
    corriente = 0;
    evaluacion();
    if (detener == true)return;
    sensores();
    evaluacion();
    if (detener == true)return;
    delay(1000);
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 70);
    evaluacion();
    if (detener == true)return;
    rpm = 300 + ((random(-20, 20) / 100.0) * 0.1);
    corriente = 2.0 + ((random(-20, 20) / 100.0) * 0.1);
    sensores();
    evaluacion();
    if (detener == true)return;
    analogWrite(PWM, 0);
    evaluacion();
    if (detener == true)return;
    rpm = 0;
    corriente = 0;
    sensores();
    evaluacion();
    if (detener == true)return;
    delay(2000);
    evaluacion();
    if (detener == true)return;
    servo_entrada.write(180); //90 abierto cerrado 180
    evaluacion();
    if (detener == true)return;
    servo_salida.write(26);   //33 cerrado 100 abierto
    evaluacion();
    if (detener == true)return;
    digitalWrite(2, 1);
    evaluacion();
    if (detener == true)return;
  }
}

void evaluacion() {
  String comando = Serial.readStringUntil('\n');
  if (comando == "PARO" or digitalRead(PULSADOR_PARO) == 1) {
    detener = true; paro = 1; marcha = 0;
  }
}
