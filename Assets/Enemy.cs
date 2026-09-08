using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
   //Attributes -- things that are unique about me!
   public float speed;
   public int health;
   protected Vector3 direction;
   protected TMP_Text healthLabel;

   // Start is called once before the first execution of Update after the MonoBehaviour is created
   protected virtual void Start()
   {
      direction = Vector3.zero - transform.position; // B - A
      healthLabel = GetComponentInChildren<TMP_Text>();
      healthLabel.text = "" + health ;
   }

   // Update is called once per frame
   void Update()
   {
      Move();
   }

   //'virtual' gives permission to inherited objects to override this function
   public virtual void Move()
   {
      transform.position += direction.normalized * speed * Time.deltaTime;
   }

   public void ChangeHealth( int amount )
   {
      health += amount;
      healthLabel.text = "" + health;
      if (health <= 0)
      {
         Destroy(this.gameObject);
      }
   }
}
