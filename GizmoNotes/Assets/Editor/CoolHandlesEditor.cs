using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CoolHandles))]
public class CoolHandlesEditor : Editor {

    CoolHandles cH;
    void OnEnable()
    {
        cH = (CoolHandles)target;
    }

    void OnSceneGUI()
    {
        Handles.Label(cH.transform.position + Vector3.up * 2, "tFloat: " + cH.tFloat.ToString()); //this makes a label on scene

        float size = HandleUtility.GetHandleSize(cH.transform.position) * .2f; //this is how you change your handle size

        cH.tFloat = Handles.Slider(new Vector3(cH.tFloat, cH.transform.position.y, cH.transform.position.z), Vector3.right, size, Handles.ConeHandleCap, .1f).x; //this will give a handle that will alter a value

        //if (Handles.Button(cH.transform.position - Vector3.up * 2, Quaternion.identity, size, size, Handles.DotHandleCap))
        //{
        //    cH.tFloat = 1;
        //}

        //Handles.Label(cH.transform.position - Vector3.up * 2, "Reset");

        //this draws a button on the scene, so does the thing above but it sucks
        Vector2 worldPoint = HandleUtility.WorldToGUIPoint(cH.transform.position - Vector3.up);

        Handles.BeginGUI();

        GUILayout.BeginArea(new Rect(worldPoint.x, worldPoint.y, 50, 50));
        if(GUILayout.Button("Reset"))
        {
            cH.tFloat = 1;
        }

        GUILayout.EndArea();
        Handles.EndGUI();
    }
}
