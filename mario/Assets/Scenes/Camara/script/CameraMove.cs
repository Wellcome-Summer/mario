using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//사용자가 마우스를 드래그 하면 카메라를 회전하고싶다.


public class CameraMove : MonoBehaviour
{
    public float gravity = -9.81f;//중력, 플레이를 달, 화성에서 할 수도 있으니까 조절가능하게
    float yVelocity;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    float rx;
    float ry;
    public float speed = 200f;
    public GameObject aa;

    // Update is called once per frame
    void Update()
    {
        //1)사용자가 마우스를 드래그하면 "움직인다"
        transform.LookAt(aa.transform.position);
        if(Input.GetButton("Fire1")) //드래그
        {
            //태어날때 고정된 위치를 가진다.
            transform.position = (new Vector3(-63, 96, -45));
            //고정된 각도를 가진다.
            transform.eulerAngles = (new Vector3(36, 25, 0));

            //카메라 움직임
            float mx = Input.GetAxis("Mouse X");
            float my = Input.GetAxis("Mouse Y");

            //x축 기준으로 움직임 -> 위,아래(y방향)
            //y축 기준으로 움직임 -> 좌,우 (x방향)
            //편의성을 위해 방향 기준으로 x, y 변경 -> 필드변수 생성 후 내용 완성rx(my), ry(mx)
            rx += my * speed * Time.deltaTime;
            ry += mx * speed * Time.deltaTime;

            //스피드라는 이름의 변수 없음 -> 퍼블릭으로 생성(유니티상에서도 속도 변경 가능하게)

            rx = Mathf.Clamp(rx, -70, 70); //카메라 각도 제한


            //2) 카메라 회전
            transform.eulerAngles = (new Vector3(-rx, ry, 0));
        }

    }



}

