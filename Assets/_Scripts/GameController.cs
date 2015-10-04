using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    //public instance variable
    public int enemyNumber;
    public GameObject enemy;

    // Use this for initialization
    void Start()
    {
        this._GenerateEnemy();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //generate cloud
    private void _GenerateEnemy()
    {
        for (int count = 0; count < this.enemyNumber; count++)
        {
            Instantiate(enemy);
        }
    }
}
