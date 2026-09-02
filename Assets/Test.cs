using ENet;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.PackageManager;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool ok = ENet.Library.Initialize();
        Debug.Log(ok);

        using (Host client = new Host())
        {
            Address address = new Address();


            address.SetHost("127.0.0.1");
            address.Port = 6666;
            client.Create();

            Peer peer = client.Connect(address);

            ENet.Event netwEvent;

            client.Flush();
        }
    }

    // Update is called once per frame
    void Update()
    {

        //while (!Console.KeyAvailable)
        //{
        //    bool polled = false;

        //    while (!polled)
        //    {
        //        if (client.CheckEvents(out netEvent) <= 0)
        //        {
        //            if (client.Service(15, out netEvent) <= 0)
        //                break;

        //            polled = true;
        //        }

        //        switch (netEvent.Type)
        //        {
        //            case EventType.None:
        //                break;

        //            case EventType.Connect:
        //                Console.WriteLine("Client connected to server");
        //                break;

        //            case EventType.Disconnect:
        //                Console.WriteLine("Client disconnected from server");
        //                break;

        //            case EventType.Timeout:
        //                Console.WriteLine("Client connection timeout");
        //                break;

        //            case EventType.Receive:
        //                Console.WriteLine("Packet received from server - Channel ID: " + netEvent.ChannelID + ", Data length: " + netEvent.Packet.Length);
        //                netEvent.Packet.Dispose();
        //                break;
        //        }
        //    }
        //}

    }
}
