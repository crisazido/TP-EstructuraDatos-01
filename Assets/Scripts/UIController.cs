using UnityEngine;
using TMPro; 

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI textoConjunto;
    private ConjuntoDinamico<int> conjunto;

    void Start()
    {
        conjunto = new ConjuntoDinamico<int>();
        ActualizarTextoConjunto();
    }

    public void AgregarElemento()
    {
        // Agrega un elemento de ejemplo, como el número 5.
        conjunto.Add(5);
        ActualizarTextoConjunto();
    }

    public void EliminarElemento()
    {
        // Elimina un elemento de ejemplo, como el número 5.
        conjunto.Remove(5);
        ActualizarTextoConjunto();
    }

    public void MostrarConjunto()
    {
        textoConjunto.text = "Conjunto: [" + conjunto.Show() + "]";
    }

    private void ActualizarTextoConjunto()
    {
        textoConjunto.text = "Conjunto: [" + conjunto.Show() + "]";
    }
}

