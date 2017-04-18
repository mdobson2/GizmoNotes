using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoExample : MonoBehaviour {

	void OnDrawGizmos()
    {
        //Gizmos.color = Color.white;
        //Gizmos.DrawCube(transform.position, Vector3.one);
        Gizmos.DrawIcon(transform.position, "icon.png");
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, Vector3.one);
    }
}
