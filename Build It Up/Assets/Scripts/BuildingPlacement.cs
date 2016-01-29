using UnityEngine;
using System.Collections;

public class BuildingPlacement : MonoBehaviour {

    private Transform currentBuilding;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (currentBuilding != null)
        {
            Vector3 m = Input.mousePosition;
            m = new Vector3(m.x, m.y, transform.position.y);
            Vector3 p = GetComponent<Camera>().ScreenToWorldPoint(m);
            currentBuilding.position = new Vector3(p.x, 0, p.z);
        }
	}

    public void SetItem(GameObject b)
    {
        currentBuilding = ((GameObject)Instantiate(b)).transform;
    }
}
