using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect01 : MonoBehaviour {
 
    public GameObject Cube;
    public GameObject Cube01;
    public Vector3 oriPos;
    public Vector3 oriRota;

    void Start() {
        Cube = GameObject.Find("Cube");
        Cube01 = GameObject.Find("Cube01");
    }
    void OnMouseUp(){
        print(Cube01);
        print("x " + Cube01.transform.eulerAngles.x);
        print("y " + Cube01.transform.eulerAngles.y);
        print("z " + Cube01.transform.eulerAngles.z);
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube01.transform.eulerAngles.x - i) < 15){
                oriRota.x = i;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube01.transform.eulerAngles.y - i) < 15){
                oriRota.y = i;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube01.transform.eulerAngles.z - i) < 15){
                oriRota.z = i;
                break;
            }
        }
        Cube01.transform.eulerAngles = oriRota;
        oriPos = Cube01.transform.position;
        if (Math.Abs(oriPos.x - Cube.transform.position.x - 0.05f) < 0.02)
            oriPos.x = Cube.transform.position.x + 0.05f;
        if (Math.Abs(oriPos.x - Cube.transform.position.x + 0.05f) < 0.02)
            oriPos.x = Cube.transform.position.x - 0.05f;
        if (Math.Abs(oriPos.y - Cube.transform.position.y - 0.05f) < 0.02)
            oriPos.y = Cube.transform.position.y + 0.05f;
        if (Math.Abs(oriPos.y - Cube.transform.position.y + 0.05f) < 0.02)
            oriPos.y = Cube.transform.position.y - 0.05f;
        if (Math.Abs(oriPos.z - Cube.transform.position.z - 0.05f) < 0.02)
            oriPos.z = Cube.transform.position.z + 0.05f;
        if (Math.Abs(oriPos.z - Cube.transform.position.z + 0.05f) < 0.02)
            oriPos.z = Cube.transform.position.z - 0.05f;
        Cube01.transform.position = oriPos;
    }
}