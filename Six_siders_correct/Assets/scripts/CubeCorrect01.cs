using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect01 : MonoBehaviour {
 
    public GameObject cube;
    public GameObject cube01;
    public Vector3 oriPos;

    void Start() {
        cube = GameObject.Find("Cube");
        cube01 = GameObject.Find("Cube01");
    }
    void OnMouseUp(){
        print(cube01);
        oriPos = new Vector3(cube.transform.position.x-0.05f, cube.transform.position.y+0.05f, cube.transform.position.z-0.05f);
        bool flag = false;

        print("x" + cube01.transform.rotation.x);
        print("y" + cube01.transform.rotation.y);
        print("z" + cube01.transform.rotation.z);
        //print(cube01.transform.eulerAngles);
        if (Math.Abs(cube01.transform.rotation.x - 0) < 0.131) {
            if (Math.Abs(cube01.transform.rotation.y - 0) < 0.131){
                if (Math.Abs(cube01.transform.rotation.z - 0) < 0.131){
                    flag = true;
                }
            }
        }
        if(flag && (Vector3.Distance(cube01.transform.position, oriPos) <= 0.02f)){
            cube01.transform.position = oriPos;     
            cube01.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}