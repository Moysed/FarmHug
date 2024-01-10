using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualController : MonoBehaviour
{
    public HeroKnight _player;

    /*private bool m_Jump;
    public VirtualButtonState _JumpButton;
    private bool m_Block;
    public VirtualButtonState _BlockButton;*/
    //Key Virtual JoyStick

    public VirtualJoyStick _VirtualJoy;

    public VirtualButtonState _CollectButton;
    public bool m_Collect;

    public void Start()
    {
        _player = GetComponent<HeroKnight>();
    }

    private void FixedUpdate()
    {
        
        //Collect State
        if (_CollectButton._currentState == VirtualButtonState.State.Down
                                   && m_Collect== false)
        {
            m_Collect = true;
            Debug.Log(m_Collect);
        }
        else if (_CollectButton._currentState == VirtualButtonState.State.Up
                                    && m_Collect == true)
        {
            m_Collect = false;
            Debug.Log(m_Collect);
        }

        _player.ActionSwapDirection(_VirtualJoy.InputVector.x);
        _player.ActionBodyMove(_VirtualJoy.InputVector.x);
        _player.ActionRun(_VirtualJoy.InputVector.x);
    }

}
