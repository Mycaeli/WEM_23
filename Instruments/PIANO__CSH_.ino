  int PIEZO = 11;
  int LED = 13;
  
  int BUTTON_C = 2;
  int BUTTON_D = 3;
  int BUTTON_E = 4;
  int BUTTON_F = 5;
  int BUTTON_G = 6;
  int BUTTON_A = 7;
  int BUTTON_B = 8;
  int BUTTON_C2 = 9;
  
  int MUSICAL = 10;
  
  void setup()
  {
    for(int i = 2; i<=10;i++)
    {
      pinMode(i, INPUT_PULLUP);
    }
    
    pinMode(LED, OUTPUT);      
  }
  
  
  
  
  
  void loop()
  {
     while(digitalRead(BUTTON_C) == LOW)
    {
      tone(PIEZO, 262, 100);
      digitalWrite(LED,HIGH);
    }
    while(digitalRead(BUTTON_D) == LOW)
    {
      tone(PIEZO, 294, 100);
      digitalWrite(LED,HIGH);
    }
  
    while(digitalRead(BUTTON_E) == LOW)
    {
      tone(PIEZO, 330, 100);
      digitalWrite(LED,HIGH);
    }
    
    while(digitalRead(BUTTON_F) == LOW)
    {
      tone(PIEZO, 349, 100);
      digitalWrite(LED,HIGH);
    }
  
    while(digitalRead(BUTTON_G) == LOW)
    {
      tone(PIEZO, 392, 100);
      digitalWrite(LED,HIGH);
    }
  
    while(digitalRead(BUTTON_A) == LOW)
    {
      tone(PIEZO, 440, 100);
      digitalWrite(LED,HIGH);
    }
  
    while(digitalRead(BUTTON_B) == LOW)
    {
      tone(PIEZO, 494, 100);
      digitalWrite(LED,HIGH);
    }      
  
    while(digitalRead(BUTTON_C2) == LOW)
    {
      tone(PIEZO, 523, 100);
      digitalWrite(LED,HIGH);
    }  
  
    if(digitalRead(MUSICAL) == LOW)
    {
      midi();
    }
  
    noTone(PIEZO);
    digitalWrite(LED,LOW);
  
  }

void midi() {

    tone(PIEZO, 493, 99.0);
    delay(110.0);
    delay(300.0);
    tone(PIEZO, 493, 108.0);
    delay(120.0);
    delay(280.0);
    tone(PIEZO, 493, 103.5);
    delay(115.0);
    delay(300.0);
    tone(PIEZO, 493, 103.5);
    delay(115.0);
    delay(300.0);
    tone(PIEZO, 493, 108.0);
    delay(120.0);
    delay(285.0);
    tone(PIEZO, 493, 103.5);
    delay(115.0);
    delay(300.0);
    tone(PIEZO, 493, 103.5);
    delay(115.0);
    delay(350.0);
    tone(PIEZO, 349, 351.0);
    delay(390.0);
    delay(5.0);
    tone(PIEZO, 293, 364.5);
    delay(405.0);
    delay(10.0);
    tone(PIEZO, 293, 333.0);
    delay(370.0);
    delay(50.0);
    tone(PIEZO, 293, 351.0);
    delay(390.0);
    delay(10.0);
    tone(PIEZO, 349, 355.5);
    delay(395.0);
    delay(25.0);
    tone(PIEZO, 293, 342.0);
    delay(380.0);
    delay(30.0);
    tone(PIEZO, 293, 378.0);
    delay(420.0);
    tone(PIEZO, 587, 351.0);
    delay(390.0);
    delay(10.0);
    tone(PIEZO, 523, 193.5);
    delay(215.0);
    delay(5.0);
    tone(PIEZO, 466, 175.5);
    delay(195.0);
    tone(PIEZO, 440, 189.0);
    delay(210.0);
    delay(5.0);
    tone(PIEZO, 391, 175.5);
    delay(195.0);
    tone(PIEZO, 349, 355.5);
    delay(395.0);
    delay(15.0);
    tone(PIEZO, 311, 355.5);
    delay(395.0);
    delay(15.0);
    tone(PIEZO, 293, 360.0);
    delay(400.0);
    delay(15.0);
    tone(PIEZO, 311, 364.5);
    delay(405.0);
    delay(10.0);
    tone(PIEZO, 349, 720.0);
    delay(800.0);
    delay(20.0);
    tone(PIEZO, 349, 364.5);
    delay(405.0);
    delay(15.0);
    tone(PIEZO, 293, 283.5);
    delay(315.0);
    delay(85.0);
    tone(PIEZO, 293, 360.0);
    delay(400.0);
    delay(10.0);
    tone(PIEZO, 293, 369.0);
    delay(410.0);
    delay(5.0);
    tone(PIEZO, 349, 360.0);
    delay(400.0);
    delay(20.0);
    tone(PIEZO, 293, 342.0);
    delay(380.0);
    delay(20.0);
    tone(PIEZO, 293, 373.5);
    delay(415.0);
    tone(PIEZO, 587, 373.5);
    delay(415.0);
    delay(10.0);
    delay(195.0);
    tone(PIEZO, 466, 171.0);
    delay(190.0);
    delay(5.0);
    tone(PIEZO, 440, 189.0);
    delay(210.0);
    delay(10.0);
    tone(PIEZO, 391, 171.0);
    delay(190.0);
    delay(5.0);
    tone(PIEZO, 349, 364.5);
    delay(405.0);
    delay(15.0);
    tone(PIEZO, 369, 360.0);
    delay(400.0);
    delay(10.0);
    tone(PIEZO, 391, 846.0);
    delay(940.0);




  }
