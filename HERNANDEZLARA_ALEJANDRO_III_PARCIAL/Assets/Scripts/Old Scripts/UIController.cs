using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    int monedas = 0;

    [SerializeField]
    string estado = "En progreso";

    [SerializeField]
    float tiempo = 0F;

    [SerializeField]
    Text textEstado;

    [SerializeField]
    Text textTiempo;

    [SerializeField]
    Text textMonedas;

    [SerializeField]
    Text textLlave;

    [SerializeField]
    bool llave;

    int minutos = 0, segundos = 0; bool ganar = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Coin")) { Destroy(collision.gameObject); monedas++; DisplayMonedas(); }
        if (collision.gameObject.tag.Equals("Key")) { Destroy(collision.gameObject); llave = true; DisplayLlave(); }
        if (collision.gameObject.tag.Equals("Door") && llave) { estado = "Ganaste :)"; ganar = true; }
    }

    //GameObject.Find("A").GetComponent<MeshRenderer>().material.color = color;

    void Start() { DisplayTiempo(); DisplayEstado(); DisplayMonedas(); llave = false; DisplayLlave(); }

    void DisplayTiempo() {
        tiempo = tiempo + 1 * Time.deltaTime;
        minutos = (int) tiempo / 60; 
        segundos = (int) tiempo % 60;
        if (tiempo % 60 < 10) { textTiempo.text = "Tiempo: " + minutos.ToString() + ":0" + segundos.ToString(); }
        else { textTiempo.text = "Tiempo: " + minutos.ToString() + ":" + segundos.ToString(); }
    }

    void DisplayEstado() { 
        if (minutos == 2 && ganar == false) { estado = "Perdiste :("; } 
        textEstado.text = "Estado: " + estado; 
    }

    //void DisplayEstado() { textEstado.text = estado; }

    void DisplayMonedas() { textMonedas.text = "Monedas: " + monedas.ToString(); }

    void DisplayLlave() { textLlave.text = "Llave: " + llave.ToString(); }

    void Update() { DisplayTiempo(); DisplayEstado(); }
}
//Aceites de Argan y Almendra, calcetas fantasmitas que no cubren empeine 37/36.5, medias para hacer bici, biosalud, colas, mascarillas, impresión de un perrito