using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostradorDeVidas : MonoBehaviour {

    private Text campoTexto;
    public Jogador jogador;

	// Use this for initialization
	void Start () {

        campoTexto = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {

        campoTexto.text = "Vidas: " + jogador.GetVida();

	}
}
