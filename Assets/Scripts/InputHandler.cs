using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{
    public UnityEvent onInputZ;
    public UnityEvent onInputX;

    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            SendKeyEvent(KeyCode.Z);
        }
        if (Input.GetKey(KeyCode.X))
        {
            SendKeyEvent(KeyCode.X);
        }
    }

    private void SendKeyEvent(KeyCode keycode)
    {
        switch (keycode)
        {
            case KeyCode.Z:
                onInputZ.Invoke();
                break;
            case KeyCode.X:
                onInputX.Invoke();
                break;
        }
    }

}
