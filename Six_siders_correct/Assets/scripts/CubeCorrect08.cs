using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect08 : MonoBehaviour {
 
    public GameObject Cube;
    public GameObject Cube08;
    public Vector3 oriPos;
    public Vector3 oriRota;

    void Start() {
        Cube = GameObject.Find("Cube");
        Cube08 = GameObject.Find("Cube08");
    }
    void OnMouseUp(){
        print(Cube08);
        int flag = 0;
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube08.transform.localEulerAngles.x - i) < 15){
                oriRota.x = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube08.transform.localEulerAngles.y - i) < 15){
                oriRota.y = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube08.transform.localEulerAngles.z - i) < 15){
                oriRota.z = i;
                flag ++;
                break;
            }
        }
        oriPos = Cube08.transform.localPosition;
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
            Cube08.transform.localEulerAngles = oriRota;
            Cube08.transform.localPosition = oriPos;
        }
    }
}