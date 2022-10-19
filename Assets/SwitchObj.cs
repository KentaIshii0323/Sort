using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class SwitchObj : MonoBehaviour
{

    //�N���b�N�����J�E���g����
    int clickcnt;
    //�I�u�W�F�N�g�̈ʒu���Ǘ�����z��
    [SerializeField] Transform[] trans;
    //������Ăяo����悤�ɂ��邽�߂̃C���X�^���X
    static public SwitchObj instance;
    //�Q�[�����̎l�p�̈ʒu��ۑ�����z��
    public Square.COLOR[] input;
    //�l�p�̕��т̐���
    public Square.COLOR[] correct;
    //�z��̓Y��
    int index1, index2;
    //�������ɔ�������C�x���g
    public UnityEvent someEvent;

    public void OnClickSquare(Square.COLOR color, Transform transform)
    {

        //�N���b�N���ꂽ��I�u�W�F�N�g�̈ʒu��ۑ�
        //2��ڂ̃N���b�N�ŃX���b�v����
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
            // �I�u�W�F�N�g�̈ʒu����������
            SwapObj();
            // �z��̈ʒu����������
            SwapArray();
            //�������`�F�b�N����
            if (input.SequenceEqual(correct))
            {
                //�����������牽������̃C�x���g�𔭐�������
                someEvent.Invoke();
            }
            clickcnt = 0;
        }
    }

    void SwapObj()
    {
        // �I�u�W�F�N�g�̈ʒu�֌W���X���b�v����
        Vector3 tmp = new Vector3(trans[0].position.x, trans[0].position.y, trans[0].position.z);
        trans[0].position = trans[1].position;
        trans[1].position = tmp;
    }

    public void SwapArray()
    {
        // �F���X���b�v����
        var tmp = input[index1];
        input[index1] = input[index2];
        input[index2] = tmp;
    }
}