using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect05 : MonoBehaviour {
 
    public GameObject Cube;
    public GameObject Cube05;
    public Vector3 oriPos;
    public Vector3 oriRota;

    void Start() {
        Cube = GameObject.Find("Cube");
        Cube05 = GameObject.Find("Cube05");
    }
    void OnMouseUp(){
        print(Cube05);
        print("x " + Cube05.transform.eulerAngles.x);
        print("y " + Cube05.transform.eulerAngles.y);
        print("z " + Cube05.transform.eulerAngles.z);
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube05.transform.eulerAngles.x - i) < 15){
                oriRota.x = i;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube05.transform.eulerAngles.y - i) < 15){
                oriRota.y = i;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube05.transform.eulerAngles.z - i) < 15){
                oriRota.z = i;
                break;
            }
        }
        Cube05.transform.eulerAngles = oriRota;
        oriPos = Cube05.transform.position;
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
        Cube05.transform.position = oriPos;
    }
}