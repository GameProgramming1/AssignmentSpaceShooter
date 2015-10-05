using UnityEngine;
using System.Collections;

public class BulletMover : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
	}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
