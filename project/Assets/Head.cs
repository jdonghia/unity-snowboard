using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Head : MonoBehaviour
{
    Player player;
    [SerializeField] ParticleSystem m_particle2;
    [SerializeField] ParticleSystem m_particle;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider is CircleCollider2D && other.gameObject.tag == "Player")
        {
            player = other.gameObject.GetComponent<Player>();
            player.hasBumped = true;
            m_particle.Play();
            Invoke("RestartLevel", 2f);
        }

        if (other.collider is CapsuleCollider2D && other.gameObject.tag == "Player")
        {
            m_particle2.Play();
        }

    }

    void RestartLevel()
    {


        SceneManager.LoadScene(0);

    }
}
