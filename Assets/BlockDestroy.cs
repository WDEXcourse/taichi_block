using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//消えるブロック
public class BlockDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 7, 0);
    }


    //何かに当たったら
    private void OnCollisionEnter(Collision collision)
    {
        //このゲームオブジェクト（を削除する
        Destroy(this.gameObject);
    }

}
