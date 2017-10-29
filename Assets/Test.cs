using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//発展
public class Boss
{
    int mp = 53;

    public void magic()
    {
        //mpが5以上の場合
        if (mp > 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else //mpが足りない場合
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }


}
public class Test : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {
        Boss boss = new Boss();
        //配列初期化
        int[] array = { 1, 2, 3, 4, 5 };


        //配列の要素を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //for文を使って配列の要素を逆に表示
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //発展
        //magic関数を計11回呼び出す
        for(int i = 0;i < 11; i++)
        {
            boss.magic();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
