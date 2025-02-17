using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private float damage = 1f;
    [SerializeField] private float range = 30f;
    [SerializeField] private Camera cam;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }
    private void Fire()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            
            EnemySceleton target =  hit.transform.GetComponent<EnemySceleton>();
            if (target != null)
            {
                target.Hurt(damage);
            }
        }
    }
}
