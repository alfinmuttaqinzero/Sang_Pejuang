using System.Collections;
using UnityEngine;

public class titikTembak : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    public float reloadTime = 2f;
    public int maxAmmo = 7;

    private int currentAmmo;
    private bool isReloading = false;
    private float nextFireTime = 0f;

    private Camera mainCam;
    private Vector3 mousePos;

    private Animator animShoot;
    [SerializeField] private AudioSource shoothandgun;
    private string shootTrigger = "shoot";

    void Start()
    {
        mainCam = Camera.main;
        currentAmmo = maxAmmo;
        animShoot = GetComponent<Animator>();
    }

    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float angle = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        if (isReloading)
        {
            return;
        }

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }

        if (Input.GetMouseButtonDown(0) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
            shoothandgun.Play();
            animShoot.SetTrigger(shootTrigger);
        }
    }

    public void Shoot()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            currentAmmo--;
        }
    }

    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;
    }
}
