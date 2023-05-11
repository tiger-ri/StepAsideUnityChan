using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClear : MonoBehaviour
{
    //カメラのオブジェクト
    private GameObject maincamera;

    // Start is called before the first frame update
    void Start()
    {
        //カメラのオブジェクトを取得
        maincamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //カメラの位置＞オブジェクトの位置
        if (maincamera.transform.position.z > this.transform.position.z)
        {
            //オブジェクトを削除
            Destroy(this.gameObject);
        }
    }
}
