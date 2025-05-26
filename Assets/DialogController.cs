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
    public static bool jaMostrouDialogo = false;

    private void Start()
    {
        dialogPanel.SetActive(false);
        IsDialogActive = false;

        closeButton.onClick.AddListener(() =>
        {
            dialogPanel.SetActive(false);
            IsDialogActive = false;
        });
    }

    public void MostrarDialogo(int morangosColetados, float vidaPerdida)
    {
        string mensagem = $"Parab�ns! Voc� resgatou {morangosColetados} morangos!" +
                          $"O inimigo perdeu {vidaPerdida} pontos de vida! Para derrot�-lo, pule em cima dele e fuja de seus ataques";
        dialogText.text = mensagem;
        dialogPanel.SetActive(true);
        IsDialogActive = true;
        jaMostrouDialogo = true;
    }

    public void MostrarDialogoFinal()
    {
        string mensagem = $"Parab�ns! voc� venceu a corrida para resgatar seus morangos!";
        dialogText.text = mensagem;
        dialogPanel.SetActive(true);
        IsDialogActive = true;
    }
}
