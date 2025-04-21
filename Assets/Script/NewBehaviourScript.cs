using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI txtSaludo;
    public TMP_InputField inputNombre;
    string nombreIngresado;
    string saludo;

    // Start is called before the first frame update
    void Start()
    {
        txtSaludo.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saludar()
    {
        //Obtener el nombre del inputfield

        nombreIngresado = inputNombre.text;

        //Concatenar el nombre con el saludo

        txtSaludo.text = "Hola " + nombreIngresado + "!";

        //Mostrar el saludo en txtSaludo

        txtSaludo.text = saludo;

    }
}
