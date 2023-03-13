using UnityEngine;
using UnityEngine.UI;
using Uduino;

public class BtnEvent : MonoBehaviour
{
    public Text textzone1, textzone2, textzone3, textzone4;
    public AudioSource source1, source2, source3, source4;
    public float wait = 0.5f;
    
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

        if (bt1 == 0 && wait > 0){
            textzone1.text = "Down";
            AudioTrigger(source1);
            wait -= Time.deltaTime;
        }
        else{
            textzone1.text = "Up";
            if (bt1 == 1)
            {
                wait = 0.5f;
            }
        }

        
        if (bt2 == 0){
            textzone2.text = "Down";
            AudioTrigger(source2);
        }else
            textzone2.text = "Up";
        
        if (bt3 == 0){
            textzone3.text = "Down";
            AudioTrigger(source3);
        }else
            textzone3.text = "Up";
        
        if (bt4 == 0){
            textzone4.text = "Down";
            AudioTrigger(source4);
        }else
            textzone4.text = "Up";
    }
    void AudioTrigger(AudioSource aud)
    {
        while (aud.isPlaying == false){
            aud.Play();
        }
    }

    void ButtonTimer(float t)
    {
        if (t > 0)
        {
            t -= Time.deltaTime;
        }
    }
}
