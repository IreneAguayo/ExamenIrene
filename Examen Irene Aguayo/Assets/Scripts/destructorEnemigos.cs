using UnityEngine;
using System.Collections;

public class destructorEnemigos : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){ //elimina naves enemigo cuando salen de pantalla
		if (col.gameObject.tag == "Enemigo"){ //si enemigo enemigo choca con destructor
			Destroy (col.gameObject); //destruye nave enemiga
		}
	}
}