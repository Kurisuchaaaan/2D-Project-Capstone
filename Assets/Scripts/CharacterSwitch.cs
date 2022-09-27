using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CharacterSwitch : MonoBehaviour
{

    public Transform avatar1, avatar2;
    public CinemachineVirtualCamera cam;


    int whichAvatarIsOn = 1;
    void Start()
    {
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(false);
    }

    public void SwitchAvatar()
    {
        switch (whichAvatarIsOn)
        {
            case 1:

                whichAvatarIsOn = 2;

                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(true);

                cam.Follow = avatar2;



                break;

            case 2:

                whichAvatarIsOn = 1;

                avatar1.gameObject.SetActive(true);
                avatar2.gameObject.SetActive(false);

                cam.Follow = avatar1;
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {

    }


}
