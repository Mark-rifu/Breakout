using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{


    void OnGUI()
    {

        GUIStyle guiStyle = new GUIStyle();
        //フォント
        GUIStyleState styleState = new GUIStyleState();
        //テキストカラー

        styleState.textColor = Color.black;

        guiStyle.normal = styleState;
        guiStyle.fontSize = 100;

        GUI.Label(new Rect(10, 10, 300, 100), "Game Over !!", guiStyle);
    }
}


