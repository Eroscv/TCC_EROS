using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       
using TMPro;

public class DialogController : MonoBehaviour
{
    [Header("Refer�ncias UI")]
    public GameObject dialogPanel;        
    public TextMeshProUGUI dialogText;
    public Button closeButton;
    public static bool IsDialogActive;

    private void Start()
    {
        closeButton.onClick.AddListener(() =>
        {
            dialogPanel.SetActive(false);
            IsDialogActive = false;
        });
    }

    public void MostrarDialogo(int morangosColetados, float vidaPerdida)
    {
        string mensagem = $"Parab�ns! Voc� resgatou {morangosColetados} morangos!" +
                          $"O inimigo perdeu {vidaPerdida} pontos de vida!";
        dialogText.text = mensagem;
        dialogPanel.SetActive(true);
        IsDialogActive = true;
    }
}
