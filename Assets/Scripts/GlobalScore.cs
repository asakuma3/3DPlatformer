using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreBox;
    public static int currentScore;     //! staticはinspectorに表示させないようにする
    public int internalScore;

    void Update()
    {
        internalScore = currentScore;
        scoreBox.GetComponent<Text>().text = "" + internalScore;  //  Textコンポーネントのtextボックス内

    }
}
