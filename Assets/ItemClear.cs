using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClear : MonoBehaviour
{
    //�J�����̃I�u�W�F�N�g
    private GameObject maincamera;

    // Start is called before the first frame update
    void Start()
    {
        //�J�����̃I�u�W�F�N�g���擾
        maincamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //�J�����̈ʒu���I�u�W�F�N�g�̈ʒu
        if (maincamera.transform.position.z > this.transform.position.z)
        {
            //�I�u�W�F�N�g���폜
            Destroy(this.gameObject);
        }
    }
}
