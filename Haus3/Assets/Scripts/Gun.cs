
using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    public ParticleSystem muzzleFlash;
    public float damage = 10f;
    public float range = 100f;
    public float head = 0f;
    public Camera fpsCam;

    public int maxAmmo = 24;
    public int currentAmmo;
    public float reloadTime = 1f;
    private bool isReloading = false;
    public AudioSource someSound;
    public AudioSource reloadSound;

    public Animator animator;
    public bool nachladen = false;

    private void Start()
    {
        currentAmmo = maxAmmo;
    }

    void Update()
    {
        if (isReloading)
            return;

        if ( Input.GetButtonDown("Reload"))
        {
            nachladen = false;
            StartCoroutine(Reload());
            return;
        }
        if (currentAmmo <= 0)
        {
            //Debug.Log("BItte Nachladen");
            nachladen = true;
            return;
        }


        if (Input.GetButtonDown("Fire1")&& Time.timeScale >0)
        {
            Shoot();
        }
    }

    IEnumerator Reload()
    {
        reloadSound.Play();
        isReloading = true;
        Debug.Log("Reload...");

        animator.SetBool("Realoading", true);

        yield return new WaitForSeconds(reloadTime);

        animator.SetBool("Realoading", false);

        currentAmmo = maxAmmo;
        isReloading = false;
    }

    void Shoot()
    {
        currentAmmo--;
        someSound.Play();

        muzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            Debug.Log(hit.transform.name);
            if(hit.transform.name == "head")
            {
                target.Head();
            }
            else
            {
                
                if (target != null)
                {
                    target.TakeDamage(damage);
                }
            }
        }
    }
}
