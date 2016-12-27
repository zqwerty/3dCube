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
        int flag = 0;
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube06.transform.localEulerAngles.x - i) < 15){
                oriRota.x = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube06.transform.localEulerAngles.y - i) < 15){
                oriRota.y = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube06.transform.localEulerAngles.z - i) < 15){
                oriRota.z = i;
                flag ++;
                break;
            }
        }
        oriPos = Cube06.transform.localPosition;
        if (Math.Abs(oriPos.x - 0.25f) < 0.12){
            oriPos.x = 0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.x + 0.25f) < 0.12){
            oriPos.x = -0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.y - 0.25f) < 0.12){
            oriPos.y = 0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.y + 0.25f) < 0.12){
            oriPos.y = -0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.z - 0.25f) < 0.12){
            oriPos.z = 0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.z + 0.25f) < 0.12){
            oriPos.z = -0.25f;
            flag ++;
        }
        if (flag == 6){
            Cube06.transform.localEulerAngles = oriRota;
            Cube06.transform.localPosition = oriPos;
        }
    }
}