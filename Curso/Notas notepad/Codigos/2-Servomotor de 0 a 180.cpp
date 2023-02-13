// Incluímos la librería para poder controlar el servo
#include <Servo.h>
// Declaramos la variable para controlar el servo
Servo TestServo

void setup() {
   // Iniciamos el servo para que empiece a trabajar con el pin 3
  TestServo.attach(3);
}

void loop() {
  for(int i = 0; i <= 180; i++)
  {  
	TestServo.write(i);
		delay (50);
  }
	
  for (int i = 179;i > 0; i--)
  {
	  TestServo.write(i);
		delay (50);
  }
}
