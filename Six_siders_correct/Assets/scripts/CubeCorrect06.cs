using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect06 : MonoBehaviour {
 
    public GameObject cube;
    public GameObject cube06;
    public Vector3 oriPos;

    void Start() {
        cube = GameObject.Find("Cube");
        cube06 = GameObject.Find("Cube06");
    }
    void OnMouseUp(){
        print(cube06);
        oriPos = new Vector3(cube.transform.position.x+0.05f, cube.transform.position.y-0.05f, cube.transform.position.z-0.05f);
        bool flag = false;
        if (Math.Abs(cube06.transform.rotation.x + 0.5) < 0.1305262) {
            if (Math.Abs(cube06.transform.rotation.y + 0.5) < 0.1305262){
                if (Math.Abs(cube06.transform.rotation.z - 0) < 0.1305262){
                    flag = true;
                }
            }
        }
        if(flag && (Vector3.Distance(cube06.transform.position, oriPos) <= 0.02f)){
            cube06.transform.position = oriPos;
            cube06.transform.rotation = Quaternion.Euler(-90, -90, 0);
        }
    }
}