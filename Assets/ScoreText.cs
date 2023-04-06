using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    public float speed; // ��������
    public Text scoreText; // �X�R�A�� UI

    private Rigidbody rb; // Rididbody
    private int score; // �X�R�A


    // Start is called before the first frame update
    void Start()
    {



        // Rigidbody ���擾
        rb = GetComponent<Rigidbody>();







        // UI ��������
        score = 0;
        SetCountText();

    }



    // �ʂ����̃I�u�W�F�N�g�ɂԂ��������ɌĂяo�����
    void OnCollisionEnter(Collision other)
    {
        // �Ԃ������I�u�W�F�N�g�����W�A�C�e���������ꍇ
        if (other.gameObject.CompareTag("LargeSterTag")) 
        {

            // �X�R�A�����Z���܂�
            score = score + 10;

            // UI �̕\�����X�V���܂�
            SetCountText();
        }
        if (other.gameObject.CompareTag("SmallSterTag")) 
        {
            // �X�R�A�����Z���܂�
            score = score + 1;

            // UI �̕\�����X�V���܂�
            SetCountText();


        }
        if (other.gameObject.CompareTag("SmallCloud")) 
        {
            // �X�R�A�����Z���܂�
            score = score + 3;

            // UI �̕\�����X�V���܂�
            SetCountText();


        }
        if(other.gameObject.CompareTag("LargeCloud"))

        {
            // �X�R�A�����Z���܂�
            score = score + 20;

            // UI �̕\�����X�V���܂�
            SetCountText();
        }







    }
    // UI �̕\�����X�V����
    void SetCountText()
    {
        // �X�R�A�̕\�����X�V
        scoreText.text = "Count: " + score.ToString();

    }



}