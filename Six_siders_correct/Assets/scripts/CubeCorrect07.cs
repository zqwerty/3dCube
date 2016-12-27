using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect07 : MonoBehaviour {
 
    public GameObject cube;
    public GameObject cube07;
    public Vector3 oriPos;

    void Start() {
        cube = GameObject.Find("Cube");
        cube07 = GameObject.Find("Cube07");
    }
    void OnMouseUp(){
        print(cube07);
        oriPos = new Vector3(cube.transform.position.x+0.05f, cube.transform.position.y-0.05f, cube.transform.position.z+0.05f);
        bool flag = false;
        if (Math.Abs(cube07.transform.rotation.x - 0.5) < 0.1305262) {
            if (Math.Abs(cube07.transform.rotation.y + 0.5) < 0.1305262){
                if (Math.Abs(cube07.transform.rotation.z + 0.5) < 0.1305262){
                    flag = true;
                }
            }
        }
        if(flag && (Vector3.Distance(cube07.transform.position, oriPos) <= 0.02f)){
            cube07.transform.position = oriPos;
            cube07.transform.rotation = Quaternion.Euler(180, 90, 90);
        }
    }
}