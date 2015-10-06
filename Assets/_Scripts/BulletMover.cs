/*Source File Name:BulletMover.cs
 * Author: Sukhpreet Sekhon
 * Last Modified By: Sukhpreet Sekhon
 * Date Of Modification:05-10-2015
 * Program Description: Script to move bullet
*/

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
