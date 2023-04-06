using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    public float speed; // 動く速さ
    public Text scoreText; // スコアの UI

    private Rigidbody rb; // Rididbody
    private int score; // スコア


    // Start is called before the first frame update
    void Start()
    {



        // Rigidbody を取得
        rb = GetComponent<Rigidbody>();







        // UI を初期化
        score = 0;
        SetCountText();

    }



    // 玉が他のオブジェクトにぶつかった時に呼び出される
    void OnCollisionEnter(Collision other)
    {
        // ぶつかったオブジェクトが収集アイテムだった場合
        if (other.gameObject.CompareTag("LargeSterTag")) 
        {

            // スコアを加算します
            score = score + 10;

            // UI の表示を更新します
            SetCountText();
        }
        if (other.gameObject.CompareTag("SmallSterTag")) 
        {
            // スコアを加算します
            score = score + 1;

            // UI の表示を更新します
            SetCountText();


        }
        if (other.gameObject.CompareTag("SmallCloud")) 
        {
            // スコアを加算します
            score = score + 3;

            // UI の表示を更新します
            SetCountText();


        }
        if(other.gameObject.CompareTag("LargeCloud"))

        {
            // スコアを加算します
            score = score + 20;

            // UI の表示を更新します
            SetCountText();
        }







    }
    // UI の表示を更新する
    void SetCountText()
    {
        // スコアの表示を更新
        scoreText.text = "Count: " + score.ToString();

    }



}