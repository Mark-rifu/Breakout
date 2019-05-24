using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    float speed = 30.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump") && GetComponent<Rigidbody>().velocity == new Vector3(0, 0, 0))
        {
            //オブジェクトの位置や速度を表すために、Vector3。
            GetComponent<Rigidbody>().AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
            //X軸方向とZ軸方向に15の力を加えています。
        }
    }


        void OnCollisionEnter()
        {
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = rigidbody.velocity.normalized * 15;
        }
}
