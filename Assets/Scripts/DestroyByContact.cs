using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundry")
        {
            return;
        }
        //GameObject clone =
        Instantiate(explosion, transform.position, transform.rotation); //as GameObject;

        if (other.tag == "Player")
        {
            //GameObject clone =
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation); //as GameObject;
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
