using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;

    public GameObject ImpactEfect;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceFrame, Space.World);
    }

    void HitTarget()
    {
        GameObject effectInst = Instantiate(ImpactEfect, transform.position, transform.rotation);
        Destroy(effectInst, 2f);
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
