# WEM_23

### Members 

* William Alejandro Pabon Guerrero/ID: 225366
* Miguel Calad Posada/ID: 350013               
* Emmanuel Echeverri Sepulveda/ID: 448007 


### Project Idea




### Vision

We are looking forward to do an interactive system that provide to our posible users an space where they can play with their sorrunding to experience rhytms and music.


### Interest




### Proto 1.0: 
We made an arduino system with a buzzer to use it like a piano, the mini piano works but the idea changed to use a Leap Motion, the code still works.

![Diagrama-Piano-Electrico-1024x463](https://user-images.githubusercontent.com/84156615/217916693-bf6f049f-c5fc-4a95-85df-6d70629816f7.png)
>Code.INO in the archives of the Git

-https://www.youtube.com/watch?v=hgfqUaslW6o-

### Avance 2.2:
We implement de Leap motion as a sensor to use in the experience of the music creation, the Leap Motion have some problems maping the hands in some position that we need but in general, its the perfect tool for the job, the next step its to build the interface in Unity to make it workfit at all, in this case to make a functional digital piano midi and the compass.

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Leap%20Motion_test.png)

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Piano_test1.png)

### Proto 2.0:
The integration of the piano and the Leap motion was a hard step in the progress, the piano system have some errors because the leap motion have some trobbles trancking the hands and the piano just can play a Note one by one, if two notes are pushed at the same time the piano doesnt play anything, one solutions its to put a multi audio device in the unity, in theory all the piano sounds are in the same audio line so if we devide it, the sounds will play individualy, if that doesnt work, a code especifing the audio system outputs will be need it.

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Leap%20Motion_test%20on%20piano.png)

### Avance 3.1:
The drums are in process of modeling, the base model its working with the sound effects, the ESP its in the final stages to be funtional and the Leap motion has some troubles with the fingers control and how the keys are pressed, the only way that the user can make 2 sounds at the same time its playing the piano upside ways because the hitbox of the hands are confusing the piano keys. The songs we´ll use are: Harry Potter Theme, Can U feel my heart, Lacrimosa, Rush E and Tetris Theme.

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Drums_test1.png)

This is the reference for the piano system:

![image](https://user-images.githubusercontent.com/84156615/222506743-f4e86872-7ddd-40b1-96f2-1bb83fa07c9c.png)

### Avance 3.2:
Description.

Conga model Blender preview:

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Conga%20Model.png)

Conga model UV:

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Conga%20UV.png)

Conga texture example:

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Conga_Texture_Image.png)

Congas Unity integration:

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Congas_Unity.png)

The making the system for the rhythm game its hard, for the interaction of the buttons of the leap its needed to edit the code of the package of Ultra Leap but that codes cannot be edited so one alternative its to create a new code with the same value that detects when the button its pressed or not. However, it didnt mean that we didnt do anything, the musical peaces now can fall and mark each piano key to play

![image](https://user-images.githubusercontent.com/84156615/223938806-c05a507d-ecd4-4321-9cd8-52779d1dc9e4.png)

So we made a new code for apart of the Leap to detect when de button its press and when its pressed destroy the coming note, every element with the tag Note will destroy when the key get pressed:


    void Start()
    {
        isPressed = false;
    }


    private void OnTriggerStay(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
            if (other.gameObject.tag == "Note")
            {
                note = other.gameObject;
            }
            Destroy(note);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = Vector3.zero;
            onRelease.Invoke();
            isPressed = false;
        }
    }
### Avance 3.3:
Description.

Integration of the Uduino plugin and it's Wifi extension to manage the communicatios of the Esp32 that would be the interface to play the kongas.

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Integration.png)

The Uduino plugin had to been set Up adding the Arduino Library reference and setting up the specs of the micro controller in this case ESP32 Generic

![image](https://user-images.githubusercontent.com/83185513/225727866-31819525-9ff5-4ce7-8944-1bf1dcce12f4.png)

The Control of the Micro Controller it's the Uduino default, with the exception of the addition of the Hot Spot ssdi and password, and the direct declaration of the pins

```
 Serial.print("Init controller\n");

  pinMode(14, INPUT_PULLUP);
  pinMode(25, INPUT_PULLUP);
  pinMode(26, INPUT_PULLUP);
  pinMode(27, INPUT_PULLUP);


  // Optional functions,  to add BEFORE connectWifi(...)
  uduino.setPort(4222);   // default 4222
  //uduino.connectWifi("SSID", "Password");
  uduino.connectWifi("FAMILIA_PG", "NicolasAlejandro0715");
```
The function of the Konga it's made by Advanced Event of the plugin with a personal script

```
using UnityEngine;
using UnityEngine.UI;
using Uduino;

public class BtnEvent : MonoBehaviour
{
    public GameObject[] kongs = new GameObject[4];
    public Text[] txtZone = new Text[4];
    public AudioSource[] sources = new AudioSource[4];
    public float[] crono = new[] {0.5f,0.5f,0.5f,0.5f };
    public float[] adjust = new[] {0.2f,0.3f,0.3f,0.2f };
    
    void Start(){
        UduinoManager.Instance.pinMode(14, PinMode.Input_pullup);
        UduinoManager.Instance.pinMode(27, PinMode.Input_pullup);
        UduinoManager.Instance.pinMode(26, PinMode.Input_pullup);
        UduinoManager.Instance.pinMode(25, PinMode.Input_pullup);
    }
    
    void Update(){
        
        int bt1 = UduinoManager.Instance.digitalRead(14);
        int bt2 = UduinoManager.Instance.digitalRead(27);
        int bt3 = UduinoManager.Instance.digitalRead(26);
        int bt4 = UduinoManager.Instance.digitalRead(25);
        
        ButtonEvnt(bt1,1, kongs[0]);
        ButtonEvnt(bt2,2, kongs[1]);
        ButtonEvnt(bt3,3, kongs[2]);
        ButtonEvnt(bt4,4, kongs[3]);
    }

    void ButtonEvnt(int btn, int i, GameObject obj)
    {
        var spaceholder = obj;
        if (btn == 0 && crono[i-1] > 0){
            txtZone[i-1].text = "Down";
            AudioTrigger(sources[i-1]);
            Konga_A(obj);
            crono[i-1] -= Time.deltaTime;
        }
        else{
            txtZone[i-1].text = "Up";
            Konga_B(obj,spaceholder);
            if (btn == 1){
                crono[i-1] = adjust[i-1];
            }
        }
    }
    void AudioTrigger(AudioSource aud){
        while (aud.isPlaying == false){
            aud.Play();
        }
    }

    void Konga_A(GameObject obj){ 
        //obj.GetComponent<Renderer>().material.color = Color.white;
        obj.GetComponent<Renderer>().material.SetFloat("_Metallic",1f);
    }
    
    void Konga_B(GameObject obj, GameObject objSwap)
    {
        //obj.GetComponent<Renderer>().material.color.Equals(objSwap);
        obj.GetComponent<Renderer>().material.SetFloat("_Metallic",0f);
    }
}
```

### Proto 3.0

The kongos and the piano had been implemented on the same unity project, both of them work and can sound at the same time, for the moment the kongos, had a visual feedback of color change, and the piano notes had a animation of moving when active.

To solve the problem of the piano keys, the solution was to separate the piano black key from the white keys, sometimes the sensor had some troubles tranking so the hands shake a little in the corners of the leap

![image](https://user-images.githubusercontent.com/84156615/227058649-a52bd5fb-8e66-4374-93cb-3ec3d861fe11.png)

The scenary will be basic, a dark room where the object stand out. The complex part will be the lighting where grid lights and laser beams will appear in the game scene as they´ll be animated.
![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Scenary_test.png)

This is an example of a laser beam:
![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Laser_test.png)




