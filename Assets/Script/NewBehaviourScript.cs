using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{ 
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;
    public TMP_InputField inputUsuario;

    string clave = "a";
    string usuario = "a";

    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = "";
    }

    public void ComprobarClaveIngresada()
    {
        string claveIngresada = inputClave.text;
        string usuarioIngresado = inputUsuario.text;
        if (claveIngresada != clave || usuarioIngresado != usuario)
        {

            txtMensaje.text = "Acceso denegado";
            inputClave.text = "";
            inputUsuario.text = "";
        }
        else
        {
            txtMensaje.text = "Bienvenido";
        }
    }
}