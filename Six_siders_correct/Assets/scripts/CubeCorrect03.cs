using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect03 : MonoBehaviour {
 
    public GameObject Cube;
    public GameObject Cube03;
    public Vector3 oriPos;
    public Vector3 oriRota;

    void Start() {
        Cube = GameObject.Find("Cube");
        Cube03 = GameObject.Find("Cube03");
    }
    void OnMouseUp(){
        print(Cube03);
        print("x " + Cube03.transform.eulerAngles.x);
        print("y " + Cube03.transform.eulerAngles.y);
        print("z " + Cube03.transform.eulerAngles.z);
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube03.transform.eulerAngles.x - i) < 15){
                oriRota.x = i;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube03.transform.eulerAngles.y - i) < 15){
                oriRota.y = i;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube03.transform.eulerAngles.z - i) < 15){
                oriRota.z = i;
                break;
            }
        }
        Cube03.transform.eulerAngles = oriRota;
        oriPos = Cube03.transform.position;
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
        Cube03.transform.position = oriPos;
    }
}