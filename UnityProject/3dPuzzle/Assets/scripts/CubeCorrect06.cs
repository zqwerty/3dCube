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
        //print(Cube06);
        int flag = 0;
        Transform _anchor = Cube06.transform.parent;
        Cube06.transform.parent = _anchor.parent;
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube06.transform.localEulerAngles.x - i) < 25){
                oriRota.x = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube06.transform.localEulerAngles.y - i) < 25){
                oriRota.y = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube06.transform.localEulerAngles.z - i) < 25){
                oriRota.z = i;
                flag ++;
                break;
            }
        }
        oriPos = Cube06.transform.localPosition;
        if (Math.Abs(oriPos.x - 0.25f) < 0.22){
            oriPos.x = 0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.x + 0.25f) < 0.22){
            oriPos.x = -0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.y - 0.25f) < 0.22){
            oriPos.y = 0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.y + 0.25f) < 0.22){
            oriPos.y = -0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.z - 0.25f) < 0.22){
            oriPos.z = 0.25f;
            flag ++;
        }
        if (Math.Abs(oriPos.z + 0.25f) < 0.22){
            oriPos.z = -0.25f;
            flag ++;
        }
        if (flag == 6){
            Cube06.transform.localEulerAngles = oriRota;
            Cube06.transform.localPosition = oriPos;
        }
        Cube06.transform.parent = _anchor;
        //print("flag" + flag);
        //print("x" + Cube06.transform.localPosition.x);
        //print("y" + Cube06.transform.localPosition.y);
        //print("z" + Cube06.transform.localPosition.z);
    }
}