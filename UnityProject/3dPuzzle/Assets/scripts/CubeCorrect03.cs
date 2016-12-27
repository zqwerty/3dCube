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
        int flag = 0;
        Transform _anchor = Cube03.transform.parent;
        Cube03.transform.parent = _anchor.parent;
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube03.transform.localEulerAngles.x - i) < 25){
                oriRota.x = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube03.transform.localEulerAngles.y - i) < 25){
                oriRota.y = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube03.transform.localEulerAngles.z - i) < 25){
                oriRota.z = i;
                flag ++;
                break;
            }
        }
        oriPos = Cube03.transform.localPosition;
        if (Math.Abs(oriPos.x - 0.25f) < 0.2){
            oriPos.x = 0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.x + 0.25f) < 0.2){
            oriPos.x = -0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.y - 0.25f) < 0.2){
            oriPos.y = 0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.y + 0.25f) < 0.2){
            oriPos.y = -0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.z - 0.25f) < 0.2){
            oriPos.z = 0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.z + 0.25f) < 0.2){
            oriPos.z = -0.25f;
            flag ++;
        }
        if (flag == 6){
            Cube03.transform.localEulerAngles = oriRota;
            Cube03.transform.localPosition = oriPos;
        }
        Cube03.transform.parent = _anchor;
    }
}