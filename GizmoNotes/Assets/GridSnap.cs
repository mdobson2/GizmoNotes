using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GridSnap : MonoBehaviour {

    public LevelGrid lg;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(lg != null)
        {
            Vector3 gridCords = lg.WorldToGrid(transform.position);
            transform.position = lg.GridToWorld((int)gridCords.x, (int)gridCords.y);
        }
	}

    void OnDrawGizmosSelected()
    {
        if(lg != null)
        {
            Gizmos.color = (lg.IsInsideGridBounds(transform.position)) ? CustomColors.greenTransparent : CustomColors.puce;
            Gizmos.DrawCube(transform.position, Vector3.one * lg.gridSize);
        }
    }
}
