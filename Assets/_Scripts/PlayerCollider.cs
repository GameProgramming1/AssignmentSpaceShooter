﻿/*Source File Name:PlayerCollider.cs
 * Author: Sukhpreet Sekhon
 * Last Modified By: Sukhpreet Sekhon
 * Date Of Modification:05-10-2015
 * Program Description: Script to display scoreboard and control player collider with enemies and power sources
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {

    //public instance variables
    public Text scorelabel;
    public Text livesLabel;
    public Text gameOverLabel;
    public Text finalScoreLabel;
    public Text congratulations;
    public int _scoreValue = 0;
    public int _liveValue = 5;

    //private instance variable
    private AudioSource[] _audioSources; //array of audio sources
    private AudioSource _EnemyAudioSource;
    private AudioSource _PowerpointAudioSource;
    private AudioSource _EndingSound;



    // Use this for initialization
    void Start()
    {
        this._audioSources = this.GetComponents<AudioSource>();
        this._EnemyAudioSource = this._audioSources[1];//reference cloud sound
        this._PowerpointAudioSource = this._audioSources[2];
        this._EndingSound = this._audioSources[3];
        this.gameOverLabel.enabled = false;
        this.finalScoreLabel.enabled = false;
        this.congratulations.enabled = false;


        this._setScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    void OnTriggerEnter2D(Collider2D otherGameObject)
    {
        if (otherGameObject.tag == "Powerpill")
        {
            this._PowerpointAudioSource.Play(); //play zap sound
            this._scoreValue += 100; //add 100 points
        }

        else
        {
            this._EnemyAudioSource.Play();
            this._liveValue--; //remove 1 life
            if (this._liveValue <= 0)
            {
                this._EndingSound.Play();

                //yield return new WaitForSeconds(300);
                this._EndGame();
            }

        }
        this._setScore();
    }

    private void _setScore()
    {
        this.scorelabel.text = "Score : " + this._scoreValue;
        this.livesLabel.text = "Lives : " + this._liveValue;

    }

    private void _EndGame()
    {
        Destroy(gameObject);
        this.scorelabel.enabled = false;
        this.livesLabel.enabled = false;
        this.gameOverLabel.enabled = true;
        this.finalScoreLabel.enabled = true;
        this.finalScoreLabel.text = "Score :" + this._scoreValue;

    }
}
