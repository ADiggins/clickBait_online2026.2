using UnityEngine;

public class Enemy : MonoBehaviour
{
   //Attributes -- things that are unique about me!
   public float speed;
   public int health;
   protected Vector3 direction;

   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {
      direction = Vector3.zero - transform.position; // B - A
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
      if (health <= 0)
      {
         Destroy(this.gameObject);
      }
   }
}
