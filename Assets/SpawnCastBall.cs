using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCastBall : MonoBehaviour
{

    public GameObject castBall;
    public GameObject spawnPoint;
    public float speed = 30f;

    private Animator animator;

    private void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator not set!!!");
        }
    }

    public void CastSpell()
    {
        GameObject go = Instantiate(
            castBall,
            spawnPoint.transform.position,
            Quaternion.identity);
        go.GetComponent<Rigidbody>().velocity = new Vector3(speed,0,0);
    }


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("castTrigger");
        }
    }
}
