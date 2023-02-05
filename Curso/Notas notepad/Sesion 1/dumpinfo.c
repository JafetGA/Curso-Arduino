/*Primer programa de arduino 
Para ususar de forma correcta el RFID tenemos que incluir una libreria 
RUTA Programa/Incluir libreria/Gstionar librerias  Escribir en el campo de busqueda RC522 (MFRC522) by githubcommunity
Usaremos un ejemplo que ya viene por defecto en la libreria */

#include <SPI.h>
#include <MFRC522.h>

#define RST_PIN         9           
#define SS_PIN          10         

MFRC522 mfrc522(SS_PIN, RST_PIN);  // Creamos el objeto en base a los pines que definimos con anterioridad MFRC522 

void setup() {
	Serial.begin(9600);		// Inicializamos la comunicacion serial con nuestra PC
	while (!Serial);		// NO hacemos nada si ningun puerto serial se abre
	SPI.begin();			// Init SPI bus
	mfrc522.PCD_Init();		// Esta funcion inicializa el modulo lector 
	delay(4);				// despues del llamado a la función tenemos un pequeño delay
	mfrc522.PCD_DumpVersionToSerial();	// Show details of PCD - MFRC522 Card Reader details
	Serial.println(F("Scan PICC to see UID, SAK, type, and data blocks..."));
}

void loop() {
	// Reset the loop if no new card present on the sensor/reader. This saves the entire process when idle.
	if ( ! mfrc522.PICC_IsNewCardPresent()) {
		return;
	}

	// Select one of the cards
	if ( ! mfrc522.PICC_ReadCardSerial()) {
		return;
	}

	// Dump debug info about the card; PICC_HaltA() is automatically called
	mfrc522.PICC_DumpToSerial(&(mfrc522.uid));
}
