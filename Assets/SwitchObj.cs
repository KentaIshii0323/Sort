using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class SwitchObj : MonoBehaviour
{

    //クリック数をカウントする
    int clickcnt;
    //オブジェクトの位置を管理する配列
    [SerializeField] Transform[] trans;
    //他から呼び出せるようにするためのインスタンス
    static public SwitchObj instance;
    //ゲーム中の四角の位置を保存する配列
    public Square.COLOR[] input;
    //四角の並びの正解
    public Square.COLOR[] correct;
    //配列の添字
    int index1, index2;
    //正解時に発生するイベント
    public UnityEvent someEvent;

    public void OnClickSquare(Square.COLOR color, Transform transform)
    {

        //クリックされたらオブジェクトの位置を保存
        //2回目のクリックでスワップする
        if (clickcnt == 0)
        {
            trans[0] = transform;
            index1 = Array.IndexOf(input, color);
            clickcnt++;
        }
        else if (clickcnt == 1)
        {
            trans[1] = transform;
            index2 = Array.IndexOf(input, color);
            // オブジェクトの位置を交換する
            SwapObj();
            // 配列の位置を交換する
            SwapArray();
            //正解かチェックする
            if (input.SequenceEqual(correct))
            {
                //正解だったら何かしらのイベントを発生させる
                someEvent.Invoke();
            }
            clickcnt = 0;
        }
    }

    void SwapObj()
    {
        // オブジェクトの位置関係をスワップする
        Vector3 tmp = new Vector3(trans[0].position.x, trans[0].position.y, trans[0].position.z);
        trans[0].position = trans[1].position;
        trans[1].position = tmp;
    }

    public void SwapArray()
    {
        // 色をスワップする
        var tmp = input[index1];
        input[index1] = input[index2];
        input[index2] = tmp;
    }
}