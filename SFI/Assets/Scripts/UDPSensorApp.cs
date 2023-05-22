using System;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using UnityEngine;
using System.Text;
using Unity.VisualScripting;

public class UDPSensorApp : MonoBehaviour
{
    public GameObject Piano_01;
    public GameObject Piano_02;
    public GameObject Signal_01;
    public GameObject Signal_02;
    private static UDPSensorApp instance;

    private Thread receiveThread;
    private bool isInitialized;
    private Queue receiveQueue;


    private UdpClient receiveClient;
    public int receivePort = 6665;

    private IPEndPoint receiveEndPoint;
    public string ip = "192.168.141.154";

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        instance = this;
        receiveEndPoint = new IPEndPoint(IPAddress.Parse(ip), receivePort);
        receiveClient = new UdpClient(receivePort);
        receiveQueue = Queue.Synchronized(new Queue());
        receiveThread = new Thread(new ThreadStart(ReceiveDataListener));
        receiveThread.IsBackground = true;
        receiveThread.Start();
        isInitialized = true;
    }

    void Start()
    {
        Piano_01.SetActive(true);
        Signal_01.SetActive(true);
        
        Piano_02.SetActive(false);
        Signal_02.SetActive(false);
    }

    private void ReceiveDataListener()
    {
        while (true)
        {
            try
            {
                byte[] data = receiveClient.Receive(ref receiveEndPoint);
                string text = Encoding.UTF8.GetString(data);
                
                Debug.Log("Data received from " + receiveEndPoint + ": " + text);
                SerializeMessage(text);
            }
            catch (System.Exception ex)
            {
                Debug.Log(ex.ToString());
            }
        }
    }

    private void SerializeMessage(string message)
    {
        try
        {
            receiveQueue.Enqueue(message);
        }
        catch (System.Exception e)
        {
            Debug.Log(e.ToString());
        }
    }

    private void OnDestroy()
    {
        TryKillThread();
    }

    private void OnApplicationQuit()
    {
        TryKillThread();
    }

    private void TryKillThread()
    {
        if (isInitialized)
        {
            receiveThread.Abort();
            receiveThread = null;
            receiveClient.Close();
            receiveClient = null;
            Debug.Log("Thread killed");
            isInitialized = false;
        }
    }


    void Update()
    {
        if (receiveQueue.Count != 0)
        {
            string message = (string)receiveQueue.Dequeue();
            if (message == "1")
            {
                Debug.Log("1");
                Piano_01.SetActive(true);
                Signal_01.SetActive(true);
        
                Piano_02.SetActive(false);
                Signal_02.SetActive(false);
            }
            else if (message == "0")
            {
                Debug.Log("0");
                Piano_01.SetActive(false);
                Signal_01.SetActive(false);
        
                Piano_02.SetActive(true);
                Signal_02.SetActive(true);
            }
        }
    }
}
