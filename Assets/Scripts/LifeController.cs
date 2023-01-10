using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeController : MonoBehaviour
{
    public int lifes_current;
    public int lifes_max;
    public float invencible_time;
    bool invencible;
    public Image barravida;


    public enum DeathMode { Teleport, ReloadScene, Destroy }
    public DeathMode death_mode;
    public Transform respawn;

    Rigidbody2D rb;

    // Start is called before the first frame update
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lifes_current = lifes_max;
    }

    void Update()
    {
        barravida.fillAmount = lifes_current / lifes_max;
    }

    public void Damage(int damage, bool ignoreInvencible = false)
    {
        if (!invencible || ignoreInvencible)
        {
            lifes_current -= damage;
          //  StartCoroutine(Invencible_Coroutine());
      //     if (lifes_current <= 0)
      //     {
       //         SceneManager.LoadScene("perder");
          //      Death();
         //   }
        }

   }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //diferentes tag
        if (collision.gameObject.tag == "muerte")
        {
            lifes_current = 0;
        }
        if (collision.gameObject.tag == "quitavidas")
        {
            lifes_current = lifes_current - 1;
        }
        if (collision.gameObject.tag == "Botiquin")
        {
            lifes_current = 3;
            Destroy(collision.gameObject);
        }
        if (lifes_current <= 0)
          {
              SceneManager.LoadScene("perder");
        }
    }

}
