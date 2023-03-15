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
