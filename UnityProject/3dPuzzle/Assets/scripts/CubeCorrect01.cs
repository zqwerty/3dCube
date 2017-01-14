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
        //print(Cube01);
        int flag = 0;
        Transform _anchor = Cube01.transform.parent;
        Cube01.transform.parent = _anchor.parent;
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube01.transform.localEulerAngles.x - i) < 25){
                oriRota.x = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube01.transform.localEulerAngles.y - i) < 25){
                oriRota.y = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube01.transform.localEulerAngles.z - i) < 25){
                oriRota.z = i;
                flag ++;
                break;
            }
        }
        oriPos = Cube01.transform.localPosition;
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
            Cube01.transform.localEulerAngles = oriRota;
            Cube01.transform.localPosition = oriPos;
        }
        Cube01.transform.parent = _anchor;
        //print("flag" + flag);
        //print("x" + Cube01.transform.localPosition.x);
        //print("y" + Cube01.transform.localPosition.y);
        //print("z" + Cube01.transform.localPosition.z);
    }
}