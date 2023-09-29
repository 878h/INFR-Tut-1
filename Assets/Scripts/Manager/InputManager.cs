using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class static class InputManager

{

    private static Control _gamecontrol;


    public static void Init()
    {
        _gamecontrol = new Control();

        _gamecontrol.Permanent.Enable();

        _gamecontrol.Ingame.Movement.performed += Ok =>
         {

         };    
 
    public static void SetGameControl()
    {
        _gamecontrol.Ingame.Enable();

        _gamecontrol.UI.Disable();
    }


    public static void SetUIControl()
    {

        _gamecontrol.Ingame.Disable();

        _gamecontrol.UI.Enable();

    }
}
