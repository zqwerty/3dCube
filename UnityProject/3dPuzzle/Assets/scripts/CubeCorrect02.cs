using UnityEngine;
using System.Collections;
using System;
public class CubeCorrect02 : MonoBehaviour {
 
    public GameObject Cube;
    public GameObject Cube02;
    public Vector3 oriPos;
    public Vector3 oriRota;

    void Start() {
        Cube = GameObject.Find("Cube");
        Cube02 = GameObject.Find("Cube02");
    }
    void OnMouseUp(){
        print(Cube02);
        int flag = 0;
        Transform _anchor = Cube02.transform.parent;
        Cube02.transform.parent = _anchor.parent;
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube02.transform.localEulerAngles.x - i) < 25){
                oriRota.x = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube02.transform.localEulerAngles.y - i) < 25){
                oriRota.y = i;
                flag ++;
                break;
            }
        }
        for (int i = 0; i < 361; i += 90){
            if (Math.Abs(Cube02.transform.localEulerAngles.z - i) < 25){
                oriRota.z = i;
                flag ++;
                break;
            }
        }
        oriPos = Cube02.transform.localPosition;
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
            Cube02.transform.localEulerAngles = oriRota;
            Cube02.transform.localPosition = oriPos;
        }
        Cube02.transform.parent = _anchor;
        print("flag" + flag);
        print("x" + Cube02.transform.localPosition.x);
        print("y" + Cube02.transform.localPosition.y);
        print("z" + Cube02.transform.localPosition.z);
    }
}