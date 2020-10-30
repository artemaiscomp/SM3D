using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class Movement_personagem : MonoBehaviour
{
    public FixedJoystick MoveJoystick;
    public FixedTouchField TouchField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<FirstPersonController>();
        
        fps.RunAxis = MoveJoystick.Direction;
        fps.m_MouseLook.LookAxis = TouchField.TouchDist;
    }
}
