using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.SceneManagement;

public class EnemyPatrol : MonoBehaviour
{

    public Transform[] points;
    int current;
    public float Speed;
    public HealthController HealthPoints;
    private AudioSource GhostDamage;

    private void Awake()
    {
        current = 0;

        InvokeRepeating("UpdateTarget", 1f, 1.5f);

        GhostDamage = GetComponent<AudioSource>();
    }

    private void Update()
    {

        if (transform.position != points[current].transform.position)
        {

            transform.position = Vector2.MoveTowards(transform.position, points[current].position, Speed * Time.deltaTime);

        } 

    }

    private void UpdateTarget()
    {

        current = (current + 1) % points.Length;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GhostDamage.Play();
        HealthPoints.takeDamage(1);

        if (HealthPoints.currentHealth == 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }


}


