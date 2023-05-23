using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManagers : MonoBehaviour
{
    [SerializeField] private GameObject pantallaMenu;
    [SerializeField] private GameObject pantallaDerrota;
    [SerializeField] private GameObject pantallaCreditos;
    [SerializeField] private GameObject pantallaVictoria;

    [SerializeField] private Text derrotaCountText;
    [SerializeField] private Text victoriaCountText;
    [SerializeField] private Text creditosCountText;
    [SerializeField] private Text integrantesText;

    private int derrotaCount;
    private int victoriaCount;
    private int creditosCount;
    private string[] grupoIntegrantes;

    private int currentIntegranteIndex;
    private float creditosDisplayTimer;

    private void Start()
    {
        derrotaCount = PlayerPrefs.GetInt("DerrotaCount", 0);
        victoriaCount = PlayerPrefs.GetInt("VictoriaCount", 0);
        creditosCount = PlayerPrefs.GetInt("CreditosCount", 0);
        currentIntegranteIndex = 0;

        derrotaCountText.text = "Derrota Count: " + derrotaCount;
        victoriaCountText.text = "Victoria Count: " + victoriaCount;
        creditosCountText.text = "Creditos Count: " + creditosCount;

        grupoIntegrantes = new string[]
        {
            "David Piccone",
            "Diego Valderrama",
            "Luis Zapata",
            "Said Albujar",
            "Paolo Pajares"
        };
    }

    public void IncrementDerrotaCount()
    {
        derrotaCount++;
        PlayerPrefs.SetInt("DerrotaCount", derrotaCount);
        derrotaCountText.text = "Derrota Count: " + derrotaCount;
    }

    public void IncrementVictoriaCount()
    {
        victoriaCount++;
        PlayerPrefs.SetInt("VictoriaCount", victoriaCount);
        victoriaCountText.text = "Victoria Count: " + victoriaCount;
    }

    public void IncrementCreditosCount()
    {
        creditosCount++;
        PlayerPrefs.SetInt("CreditosCount", creditosCount);
        creditosCountText.text = "Creditos Count: " + creditosCount;
    }

    public void ShowPantallaMenu()
    {
        pantallaMenu.SetActive(true);
        pantallaDerrota.SetActive(false);
        pantallaCreditos.SetActive(false);
        pantallaVictoria.SetActive(false);
    }

    public void ShowPantallaDerrota()
    {
        pantallaMenu.SetActive(false);
        pantallaDerrota.SetActive(true);
        pantallaCreditos.SetActive(false);
        pantallaVictoria.SetActive(false);
    }

    public void ShowPantallaCreditos()
    {
        pantallaMenu.SetActive(false);
        pantallaDerrota.SetActive(false);
        pantallaCreditos.SetActive(true);
        pantallaVictoria.SetActive(false);

        StartCoroutine(DisplayIntegrantes());
    }

    public void ShowPantallaVictoria()
    {
        pantallaMenu.SetActive(false);
        pantallaDerrota.SetActive(false);
        pantallaCreditos.SetActive(false);
        pantallaVictoria.SetActive(true);
    }

    private System.Collections.IEnumerator DisplayIntegrantes()
    {
        while (true)
        {
            integrantesText.text = grupoIntegrantes[currentIntegranteIndex];

            yield return new WaitForSeconds(2f);

            currentIntegranteIndex++;
            if (currentIntegranteIndex >= grupoIntegrantes.Length)
                currentIntegranteIndex = 0;
        }
    }
}