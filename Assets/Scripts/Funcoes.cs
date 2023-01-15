using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Funcoes
{
    public static bool pcVersion 
    { 
        get 
        {
            if (Application.platform == RuntimePlatform.WebGLPlayer || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
                return true;
            else
                return false;
        } 
    }
}
