using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect03 : MonoBehaviour {
 
    public GameObject cube;
    public GameObject cube03;
    public Vector3 oriPos;

    void Start() {
        cube = GameObject.Find("Cube");
        cube03 = GameObject.Find("Cube03");
    }
    void OnMouseUp(){
        print(cube03);
        oriPos = new Vector3(cube.transform.position.x-0.05f, cube.transform.position.y-0.05f, cube.transform.position.z+0.05f);
        bool flag = false;
        if (Math.Abs(cube03.transform.rotation.x + 0.5) < 0.1305262) {
            if (Math.Abs(cube03.transform.rotation.y - 0.5) < 0.1305262){
                if (Math.Abs(cube03.transform.rotation.z - 0.5) < 0.1305262){
                    flag = true;
                }
            }
        }
        if(flag && (Vector3.Distance(cube03.transform.position, oriPos) <= 0.02f)){
            cube03.transform.position = oriPos;
            cube03.transform.rotation = Quaternion.Euler(-90, 90, 0);
        }
    }
}