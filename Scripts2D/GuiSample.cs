// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class GuiSample : MonoBehaviour {

    // Text style.
    public GUIStyle textStyle = new GUIStyle();

    // getCenterRect(x, y, w, h):
    private Rect getCenterRect(float x, float y, float w, float h)
    {
        return new Rect(Screen.width*(x-w/2), Screen.height*(y-h/2), 
                        Screen.width*w, Screen.height*h);
    }

    void OnGUI() {
        Rect r = getCenterRect(0.5, 0.5, 0.3, 0.1);
        GUI.Label(r, "Text.", textStyle);
    }

}
