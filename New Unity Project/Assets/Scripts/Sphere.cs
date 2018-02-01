using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {
    // Use this for initialization
    void Start () {
    }
	
    public void generate_sphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(0, 1.5F, 0);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
