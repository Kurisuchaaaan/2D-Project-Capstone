using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchKeys : MonoBehaviour
{
    public KeyCode Key;

    private Button button;

    void Awake()
    {
        button = GetComponent<Button>();
    }

    void Update()
    {
        if(Input.GetKeyDown(Key))
        {
            button.onClick.Invoke();
        }
    }
}
