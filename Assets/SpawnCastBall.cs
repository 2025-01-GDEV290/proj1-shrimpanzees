using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCastBall : MonoBehaviour
{

    public GameObject castBall;
    public GameObject spawnPoint;
    public float speed = 30f;

    public void CastSpell()
    {
        GameObject go = Instantiate(
            castBall,
            spawnPoint.transform.position,
            Quaternion.identity);
        go.GetComponent<Rigidbody>().velocity = new Vector3(speed,0,0);
    }

}
