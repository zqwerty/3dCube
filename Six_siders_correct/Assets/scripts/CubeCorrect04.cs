using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect04 : MonoBehaviour {
 
    public GameObject Cube;
    public GameObject Cube04;
    public Vector3 oriPos;
    public Vector3 oriRota;

    void Start() {
        Cube = GameObject.Find("Cube");
        Cube04 = GameObject.Find("Cube04");
    }
    void OnMouseUp(){
        print(Cube04);
        print("x " + Cube04.transform.eulerAngles.x);
        print("y " + Cube04.transform.eulerAngles.y);
        print("z " + Cube04.transform.eulerAngles.z);
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube04.transform.eulerAngles.x - i) < 15){
                oriRota.x = i;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube04.transform.eulerAngles.y - i) < 15){
                oriRota.y = i;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube04.transform.eulerAngles.z - i) < 15){
                oriRota.z = i;
                break;
            }
        }
        Cube04.transform.eulerAngles = oriRota;
        oriPos = Cube04.transform.position;
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
        Cube04.transform.position = oriPos;
    }
}