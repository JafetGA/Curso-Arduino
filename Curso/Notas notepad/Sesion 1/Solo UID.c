/* SEGUNDO PROGRAMA */

#include <SPI.h>
#include <MFRC522.h>

#define RST_PIN         9           
#define SS_PIN          10         

MFRC522 mfrc522(SS_PIN, RST_PIN);  // Creamos el objeto en base a los pines que definimos con anterioridad MFRC522 

void setup() {
	Serial.begin(9600);		// Inicializamos la comunicacion serial con nuestra PC
	SPI.begin();			// Init SPI bus
	mfrc522.PCD_Init();		// Esta funcion inicializa el modulo lector 
}

void loop(){
	if ( ! mfrc522.PICC_IsNewCardPresent()) { //Condicional para determinar si esta presente una tarjeta|
		return;
	}
	if ( ! mfrc522.PICC_ReadCardSerial()) {  //Condicional que nos dira si podemos obtener informacion de nuestra tarjeta
		return;
	
	
	Serial.print("UID:");//obtendremos el identificador unico con el siguinete bucle
	for(byte i = 0; i < mfrc522.uid.size;i++) { //declaramos una variable de iteracion del tipo byte i debe ser menor al tamaño que tenga el uid de la tarjeta o llavero (son de 4 bytes) 
		if(mfrc522.uid.uidByte[i] < 0x10){//Este if nos dara formato para mostrarlo en el monitor serie. Consultamos si el valor del uid leido es menor al 10 hexadecimal 
			Serial.print(" 0");//Es verdadero entonces si esta entre 0 y 9 agregamos un 0 y un espacio en blanco
		}
		else{
			Serial.print(" "); //SI es mayor o igual al 10 en hexadecimal solo deberemos separar los valores con un espacio [A - F]
		}
		Serial.print(mfrc522.uid.uidByte[i], HEX); // Variable i de 0 a 3 obteniendo los 4 byetes de la memoria, en formato Hexadecimal	
	}
	Serial.println();
	mfrc522.PICC_HaltA();//indicamos a la tarjeta o llavero que no necesitamos tener más informacion de esta 
}