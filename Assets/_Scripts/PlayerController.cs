using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // PUBLIC INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++
    public float speed;
    public Boundary boundary;

    //player bullet prefab
    public GameObject bullet;
    public Transform bulletSpawn;
    public float fireRate;






    // PRIVATE INSTANCE VARIABLES
    private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
    private float newFire;

     //Use this for initialization
    void Start()
    {
    
      }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1") && Time.time > newFire)
        {
            newFire = Time.time + fireRate;
            Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
        }
        this._CheckInput();
    }

    private void _CheckInput()
    {
        this._newPosition = gameObject.GetComponent<Transform>().position; // current position

        if (Input.GetAxis("Horizontal") > 0)
        {
            this._newPosition.x += this.speed; // add move value to current position
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            this._newPosition.x -= this.speed; // subtract move value to current position
        }

        this._BoundaryCheck();

        gameObject.GetComponent<Transform>().position = this._newPosition;
    }

    private void _BoundaryCheck()
    {
        if (this._newPosition.x < this.boundary.minX)
        {
            this._newPosition.x = this.boundary.minX;
        }

        if (this._newPosition.x > this.boundary.maxX)
        {
            this._newPosition.x = this.boundary.maxX;
        }
    }
}
