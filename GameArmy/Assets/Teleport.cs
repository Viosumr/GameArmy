using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject FinishRezult;
    public Text textPolosascore, textStrelba, Summ;
    float sum;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FinishRezult.SetActive(true);
            GameObject man;
            man = GameObject.FindGameObjectWithTag("Player");
            man.GetComponent<FirstPersonController>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            textPolosascore.text ="������ ����������� - " + Polosa_start.score.ToString();
            textStrelba.text = "�������� - " + GreenTarget.scores.ToString();
            sum = Polosa_start.score + GreenTarget.scores;
            Summ.text ="����� �����" +  sum.ToString();
        }
   
    }

    public void Continious()
    {
        SceneManager.LoadScene("��������");
    }
}
