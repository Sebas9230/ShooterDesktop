using TMPro; // Para TextMeshPro
using UnityEngine;

public class TimerCountdown : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Asigna el texto del Timer desde el inspector.
    private float timeRemaining = 30f; // Tiempo inicial en segundos.
    private bool isRunning = true; // Controla si el timer est� activo.

    void Update()
    {
        if (isRunning)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                isRunning = false;
                // Aqu� puedes agregar l�gica de fin de partida.
            }

            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        int seconds = Mathf.CeilToInt(timeRemaining); // Redondea hacia arriba.
        timerText.text = seconds.ToString();

        // Cambiar estilo cuando est� en 5 segundos o menos.
        if (seconds <= 5)
        {
            timerText.color = Color.red; // Cambia el color a rojo.
            timerText.fontSize = 40; // Incrementa el tama�o de la fuente.
        }
        else
        {
            timerText.color = Color.black; // Restaura el color original.
            timerText.fontSize = 25; // Tama�o normal.
        }
    }
}
