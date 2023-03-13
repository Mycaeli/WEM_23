using UnityEngine;
using UnityEngine.UI;
using Uduino;

public class BtnEvent : MonoBehaviour
{
    public Text textzone1, textzone2, textzone3, textzone4;
    public AudioSource[] sources = new AudioSource[4];
    public float[] crono = new[] {0.5f,0.5f,0.5f,0.5f };
    
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
        
        ButtonEvnt(bt1,textzone1,1);
        ButtonEvnt(bt2,textzone2,2);
        ButtonEvnt(bt3,textzone3,3);
        ButtonEvnt(bt4,textzone4,4);
    }

    void ButtonEvnt(int btn, Text text, int i)
    {
        if (btn == 0 && crono[i-1] > 0){
            text.text = "Down";
            AudioTrigger(sources[i-1]);
            crono[i-1] -= Time.deltaTime;
        }
        else{
            text.text = "Up";
            if (btn == 1){
                crono[i-1] = 0.5f;
            }
        }
    }
    void AudioTrigger(AudioSource aud){
        while (aud.isPlaying == false){
            aud.Play();
        }
    }
}
