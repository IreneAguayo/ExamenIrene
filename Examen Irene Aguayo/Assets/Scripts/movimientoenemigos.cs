using UnityEngine;
using System.Collections;

public class movimientoenemigos : MonoBehaviour {
	
	
	public float speed = -8f;//velocidad de enemigos
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, 1, 0) * speed * Time.deltaTime);//movimiento en eje y de enemigos
	}
}
