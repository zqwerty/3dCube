using UnityEngine;
using System.Collections;
public class CubeBack : MonoBehaviour {
 
    public GameObject cube;
    public GameObject cube01, cube02, cube03, cube04, cube05, cube06, cube07, cube08;
    public Vector3 oriPos;

    void Start() {
        cube = GameObject.Find("Cube");
        cube01 = GameObject.Find("Cube01");
        cube02 = GameObject.Find("Cube02");
        cube03 = GameObject.Find("Cube03");
        cube04 = GameObject.Find("Cube04");
        cube05 = GameObject.Find("Cube05");
        cube06 = GameObject.Find("Cube06");
        cube07 = GameObject.Find("Cube07");
        cube08 = GameObject.Find("Cube08");
    }
     
    void Update() {
        if(Input.GetKey(KeyCode.Space))
        {
            oriPos = new Vector3(0, 0, 0.2);
            cube.transform.position = oriPos;
            cube.transform.rotation = Quaternion.Euler(0, 0, 0);
            oriPos = new Vector3(cube.transform.position.x-0.05f, cube.transform.position.y+0.05f, cube.transform.position.z-0.05f);
            cube01.transform.rotation = Quaternion.Euler(0, 0, 0);
            cube01.transform.position = oriPos;
            oriPos = new Vector3(cube.transform.position.x-0.05f, cube.transform.position.y+0.05f, cube.transform.position.z+0.05f);
            cube02.transform.rotation = Quaternion.Euler(90, 0, 0);
            cube02.transform.position = oriPos;
            oriPos = new Vector3(cube.transform.position.x-0.05f, cube.transform.position.y-0.05f, cube.transform.position.z+0.05f);
            cube03.transform.rotation = Quaternion.Euler(-90, 90, 0);
            cube03.transform.position = oriPos;
            oriPos = new Vector3(cube.transform.position.x-0.05f, cube.transform.position.y-0.05f, cube.transform.position.z-0.05f);
            cube04.transform.rotation = Quaternion.Euler(0, 0, 90);
            cube04.transform.position = oriPos;
            oriPos = new Vector3(cube.transform.position.x+0.05f, cube.transform.position.y+0.05f, cube.transform.position.z+0.05f);
            cube05.transform.rotation = Quaternion.Euler(0, 90, 0);
            cube05.transform.position = oriPos;
            oriPos = new Vector3(cube.transform.position.x+0.05f, cube.transform.position.y-0.05f, cube.transform.position.z-0.05f);
            cube06.transform.rotation = Quaternion.Euler(-90, -90, 0);
            cube06.transform.position = oriPos;
            oriPos = new Vector3(cube.transform.position.x+0.05f, cube.transform.position.y-0.05f, cube.transform.position.z+0.05f);
            cube07.transform.rotation = Quaternion.Euler(180, 90, 90);
            cube07.transform.position = oriPos;
            oriPos = new Vector3(cube.transform.position.x+0.05f, cube.transform.position.y+0.05f, cube.transform.position.z-0.05f);
            cube08.transform.rotation = Quaternion.Euler(0, 0, -90);                     
            cube08.transform.position = oriPos;
        }
    }
}