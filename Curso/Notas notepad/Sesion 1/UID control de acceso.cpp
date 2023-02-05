#include <SPI.h>
#include <MFRC522.h>

#define RST_PIN         9           
#define SS_PIN          10         

MFRC522 mfrc522(SS_PIN, RST_PIN);  // Creamos el objeto en base a los pines que definimos con anterioridad MFRC522 

byte LecturaUID[4];//Almacenamos el valor de nuestro uid para poder compararlo
char str[12] = "";//Delclaramos un array de tipo char para guaradar nuestro UID
int Success;//declaramos una variable de tipo entero para indicar que tuvumos exito al leer nuestro UDI
String StrUID;//Un String para almacenar nuestro UID en forma de cadena

void setup() {
	Serial.begin(9600);		// Inicializamos la comunicacion serial con nuestra PC
	SPI.begin();			// Init SPI bus
	mfrc522.PCD_Init();		// Esta funcion inicializa el modulo lector 
}

void loop(){
	Success = getID();
	if(Success){
		Serial.print(StrUID);
    Serial.println();
		delay (1000);
	}
}

int getID(){ // Leeremos y obtendermos nuestro UID
	
if ( ! mfrc522.PICC_IsNewCardPresent()) { //Condicional para determinar si esta presente una tarjeta|
		return 0;
	}
	if ( ! mfrc522.PICC_ReadCardSerial()) {  //Condicional que nos dira si podemos obtener informacion de nuestra tarjeta
		return 0;
}
	
	//obtendremos el identificador unico con el siguinete bucle
	for(byte i = 0; i < mfrc522.uid.size;i++) { //declaramos una variable de iteracion del tipo byte i debe ser menor al tamaño que tenga el uid de la tarjeta o llavero (son de 4 bytes) 
		if(mfrc522.uid.uidByte[i] < 0x10){//Este if nos dara formato para mostrarlo en el monitor serie. Consultamos si el valor del uid leido es menor al 10 hexadecimal 
			Serial.print(" 0");//Es verdadero entonces si esta entre 0 y 9 agregamos un 0 y un espacio en blanco
		}
		else{
			Serial.print(" "); //SI es mayor o igual al 10 en hexadecimal solo deberemos separar los valores con un espacio [A - F]
		}
		Serial.print(mfrc522.uid.uidByte[i], HEX); // Variable i de 0 a 3 obteniendo los 4 byetes de la memoria, en formato Hexadecimal	
		LecturaUID[i] = mfrc522.uid.uidByte[i];
		array_to_string(LecturaUID,4,str);
		StrUID = str;
	}
	
	mfrc522.PICC_HaltA();//indicamos a la tarjeta o llavero que no necesitamos tener más informacion de esta 
	return 1;
}

void array_to_string(byte array[],unsigned int size, char buffer[]){
  //Convertiremos nuestro UID a candena
		for (unsigned int i = 0; i < size; i++){
			byte nib1 = (array[i] >> 4) & 0x0F;  //Hacemos un bit shifting (movemos el digito a la derecha) en este caso son 4 bytes borrando los 4 bits mas a la izquierda conbirtiendolos en 0 &0f ignoramos los 4 bits mas a la izquierda       

			byte nib2 = (array[i] >> 0) & 0x0F;

			buffer[i*2+0] = nib1  < 0xA ? '0' + nib1  : 'A' + nib1  - 0xA;
			//Si nuestro valor del byte es menor que el hexadecimal de A, agregamos el codigo ASCII de caracter 0
      
			buffer[i*2+1] = nib2  < 0xA ? '0' + nib2  : 'A' + nib2  - 0xA;
			
		}
		 buffer[size-4] = '\0';
}
