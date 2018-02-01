using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public GameObject monCube;
	// Use this for initialization
	void Start () {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Instantiate(monCube, Vector3.zero, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
