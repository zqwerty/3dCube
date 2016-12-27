using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect08 : MonoBehaviour {
 
    public GameObject cube;
    public GameObject cube08;
    public Vector3 oriPos;

    void Start() {
        cube = GameObject.Find("Cube");
        cube08 = GameObject.Find("Cube08");
    }
    void OnMouseUp(){
        print(cube08);
        oriPos = new Vector3(cube.transform.position.x+0.05f, cube.transform.position.y+0.05f, cube.transform.position.z-0.05f);
        bool flag = false;
        if (Math.Abs(cube08.transform.rotation.x - 0) < 0.1305262) {
            if (Math.Abs(cube08.transform.rotation.y - 0) < 0.1305262){
                if (Math.Abs(cube08.transform.rotation.z + 0.7071068) < 0.1305262){
                    flag = true;
                }
            }
        }
        if(flag && (Vector3.Distance(cube08.transform.position, oriPos) <= 0.02f)){
            cube08.transform.position = oriPos;
            cube08.transform.rotation = Quaternion.Euler(0, 0, -90);
        }
    }
    
}