/*Source File Name:BackgroundController.cs
 * Author: Sukhpreet Sekhon
 * Last Modified By: Sukhpreet Sekhon
 * Date Of Modification:05-10-2015
 * Program Description: Script to move background in one direction
*/

using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {
    //public instance variable
    public float speed;

    // Use this for initialization
    void Start()
    {
        this._Reset();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = new Vector2(0.0f, 0.0f);
        currentPosition = gameObject.GetComponent<Transform>().position;
        currentPosition.y -= speed;
        //movve the gameobject to th ecurrent position
        gameObject.GetComponent<Transform>().position = currentPosition;

        //bottom boundray check oceans meets camra view point
        if (currentPosition.y <= -480)
        {
            this._Reset();
        }

    }
    //resets our game object
    private void _Reset()
    {
        Vector2 resetPosition = new Vector2(0.0f, 480f);
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}
