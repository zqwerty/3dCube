using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect05 : MonoBehaviour {
 
    public GameObject cube;
    public GameObject cube05;
    public Vector3 oriPos;

    void Start() {
        cube = GameObject.Find("Cube");
        cube05 = GameObject.Find("Cube05");
    }
    void OnMouseUp(){
        print(cube05);
        oriPos = new Vector3(cube.transform.position.x+0.05f, cube.transform.position.y+0.05f, cube.transform.position.z+0.05f);
        bool flag = false;
        if (Math.Abs(cube05.transform.rotation.x + 0.5) < 0.1305262) {
            if (Math.Abs(cube05.transform.rotation.y - 0.5) < 0.1305262){
                if (Math.Abs(cube05.transform.rotation.z - 0.5) < 0.1305262){
                    flag = true;
                }
            }
        }
        if(flag && (Vector3.Distance(cube05.transform.position, oriPos) <= 0.02f)){
            cube05.transform.position = oriPos;
            cube05.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}