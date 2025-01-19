using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider; // Refer�ncia ao Slider que controla o volume
    private AudioSource audioSource; // Refer�ncia ao componente de �udio

    void Start()
    {
        // Obt�m a refer�ncia do componente de �udio associado ao GameObject atual
        audioSource = GetComponent<AudioSource>();

        // Define o valor inicial do slider com base no volume atual
        volumeSlider.value = audioSource.volume;

        // Adiciona um listener ao slider para chamar a fun��o OnVolumeChanged quando o valor do slider � alterado
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    void OnVolumeChanged(float volume)
    {
        // Atualiza o volume do �udio com base no valor do slider
        audioSource.volume = volume;
    }
}
