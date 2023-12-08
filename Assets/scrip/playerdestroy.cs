using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour
{
    public float kecepatanMaju = 5f; // Kecepatan maju objek

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Muncul sesuai arah mouse
        GerakSesuaiArahMouse();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected");
        if (collision.gameObject.CompareTag("enemy1") || collision.gameObject.CompareTag("item1"))
        {
            // Panggil fungsi HancurkanObjek pada objek yang bersentuhan
            HancurkanObjek(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("envirotment"))
        {
            // Panggil fungsi HancurkanObjek pada objek ini (jika bersentuhan dengan objek ber tag "environment")
            HancurkanObjek(gameObject);
        }
    }

    void HancurkanObjek(GameObject objek)
    {
        // Hancurkan objek yang bersentuhan
        Destroy(objek);

        // Hancurkan objek ini
        Destroy(gameObject);
    }

    void GerakSesuaiArahMouse()
    {
        // Mendapatkan posisi mouse dalam koordinat dunia
        Vector3 posisiMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posisiMouse.z = 0; // Pastikan objek berada pada z-posisi yang sama dengan pemain

        // Mendapatkan vektor dari posisi pemain ke posisi mouse
        Vector2 arah = (posisiMouse - transform.position).normalized;

        // Berikan kecepatan maju sesuai arah mouse
        rb.velocity = arah * kecepatanMaju;

        // Menghitung sudut rotasi
        float sudutRotasi = Mathf.Atan2(arah.y, arah.x) * Mathf.Rad2Deg;

        // Mengatur rotasi objek sesuai dengan sudut rotasi
        transform.rotation = Quaternion.Euler(0, 0, sudutRotasi);
    }
}







