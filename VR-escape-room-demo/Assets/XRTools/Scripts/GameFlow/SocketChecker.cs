// Author: Peter Dickx https://github.com/dickxpe
// MIT License - Copyright (c) 2024 Peter Dickx

using UnityEngine;
using UltEvents;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketChecker : MonoBehaviour
{
    [SerializeField]
    string connectionName;

    [SerializeField]
    UltEvent WrongConnection;
    [SerializeField]
    UltEvent CorrectConnection;
    public void CheckSocket(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.gameObject.name == connectionName)
        {
            CorrectConnection.Invoke();
        }
        else
        {
            WrongConnection.Invoke();
        }
    }
}
