using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
