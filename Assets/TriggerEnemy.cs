using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemy : MonoBehaviour
{
    [SerializeField] GameObject m_Enemy;
    // Start is called before the first frame update
    void Start()
    {
        m_Enemy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_Enemy.SetActive(true);
        }
    }
}
