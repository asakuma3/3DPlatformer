using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreBox;
    public static int currentScore;     //! static��inspector�ɕ\�������Ȃ��悤�ɂ���
    public int internalScore;

    void Update()
    {
        internalScore = currentScore;
        scoreBox.GetComponent<Text>().text = "" + internalScore;  //  Text�R���|�[�l���g��text�{�b�N�X��

    }
}
