using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect02 : MonoBehaviour {
 
    public GameObject cube;
    public GameObject cube02;
    public Vector3 oriPos;

    void Start() {
        cube = GameObject.Find("Cube");
        cube02 = GameObject.Find("Cube02");  
        
    }
    void OnMouseUp(){
        print(cube02);
        oriPos = new Vector3(cube.transform.position.x-0.05f, cube.transform.position.y+0.05f, cube.transform.position.z+0.05f);
        bool flag = false;
        print("x" + cube02.transform.rotation.x);
        print("y" + cube02.transform.rotation.y);
        print("z" + cube02.transform.rotation.z);
        //print(cube02.transform.eulerAngles);
        if (Math.Abs(cube02.transform.rotation.x - 0.7071068) < 0.1) {
            if (Math.Abs(cube02.transform.rotation.y - 0) <= 0.1305262){
                if (Math.Abs(cube02.transform.rotation.z - 0) <= 0.1305262){
                    flag = true;
                }
            }
        }
        //flag = true;
        if(flag && (Vector3.Distance(cube02.transform.position, oriPos) <= 0.02f)){
            cube02.transform.position = oriPos;
            cube02.transform.rotation = Quaternion.Euler(90, 0, 0);
        }
    }
}