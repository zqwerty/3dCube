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
        int flag = 0;
        Transform _anchor = Cube05.transform.parent;
        Cube05.transform.parent = _anchor.parent;
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube05.transform.localEulerAngles.x - i) < 25){
                oriRota.x = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube05.transform.localEulerAngles.y - i) < 25){
                oriRota.y = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube05.transform.localEulerAngles.z - i) < 25){
                oriRota.z = i;
                flag ++;
                break;
            }
        }
        oriPos = Cube05.transform.localPosition;
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
            Cube05.transform.localEulerAngles = oriRota;
            Cube05.transform.localPosition = oriPos;
        }
        Cube05.transform.parent = _anchor;
    }
}