using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DrawLine))]
public class DrawLineEditor : Editor {

    void OnEnable()
    {
        //SceneView.onSceneGUIDelegate -= this.MyGUI;

        SceneView.onSceneGUIDelegate += this.MyGUI;
    }

    void OnDestroy()
    {
        //SceneView.onSceneGUIDelegate -= this.MyGUI;
    }

    void MyGUI(SceneView SV)
    {
        /*DrawLine dl = target as DrawLine;

        if(dl == null || dl.gameObjects == null)        
            return;

        Vector3 center = dl.transform.position;

        for(int i = 0; i < dl.gameObjects.Length; i++)
        {
            if(dl.gameObjects[i] != null)
            {
                Handles.DrawLine(center, dl.gameObjects[i].transform.position);
            }
        }*/

        Handles.BeginGUI();
        GUILayout.BeginArea(new Rect(10, 10, 100, 100));
        if (GUILayout.Button("Reset"))
        {
            Selection.activeGameObject.transform.position = Vector3.up;
        }
        GUILayout.EndArea();
        Handles.EndGUI();

        /*Handles.color = Color.red;
        Handles.DrawWireArc(dl.transform.position, dl.transform.up, -dl.transform.right, dl.shieldArc, dl.shieldArea);
        dl.shieldArea = Handles.ScaleValueHandle(dl.shieldArea, dl.transform.position + dl.transform.forward * dl.shieldArea,
                                                dl.transform.rotation, 2, Handles.ConeCap, 1);*/
    }
}
