using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect04 : MonoBehaviour {
 
    public GameObject cube;
    public GameObject cube04;
    public Vector3 oriPos;

    void Start() {
        cube = GameObject.Find("Cube");
        cube04 = GameObject.Find("Cube04");
    }
    void OnMouseUp(){
        print(cube04);
        oriPos = new Vector3(cube.transform.position.x-0.05f, cube.transform.position.y-0.05f, cube.transform.position.z-0.05f);
        bool flag = false;
        if (Math.Abs(cube04.transform.rotation.x - 0) < 15) {
            if (Math.Abs(cube04.transform.rotation.y - 0) < 15){
                if (Math.Abs(cube04.transform.rotation.z - 90) < 15){
                    flag = true;
                }
            }
        }
        flag = true;
        if(flag && (Vector3.Distance(cube04.transform.position, oriPos) <= 0.02f)){
            cube04.transform.position = oriPos;
            cube04.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }
}