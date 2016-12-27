using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect06 : MonoBehaviour {
 
    public GameObject Cube;
    public GameObject Cube06;
    public Vector3 oriPos;
    public Vector3 oriRota;

    void Start() {
        Cube = GameObject.Find("Cube");
        Cube06 = GameObject.Find("Cube06");
    }
    void OnMouseUp(){
        print(Cube06);
        print("x " + Cube06.transform.eulerAngles.x);
        print("y " + Cube06.transform.eulerAngles.y);
        print("z " + Cube06.transform.eulerAngles.z);
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube06.transform.eulerAngles.x - i) < 15){
                oriRota.x = i;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube06.transform.eulerAngles.y - i) < 15){
                oriRota.y = i;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube06.transform.eulerAngles.z - i) < 15){
                oriRota.z = i;
                break;
            }
        }
        Cube06.transform.eulerAngles = oriRota;
        oriPos = Cube06.transform.position;
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
        Cube06.transform.position = oriPos;
    }
}