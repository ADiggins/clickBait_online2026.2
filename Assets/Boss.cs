using UnityEngine;


//Inheritance -- Boss is an Enemy now!
public class Boss : Enemy
{
   public string message = "Hello World!";

   //Polymorphism -- Boss 'overrides' current default behaviour of 'Move()'
   public override void Move()
   {
      direction = transform.position - Vector3.zero;
      Vector3 rotatedDirection = Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.forward) * direction;
      transform.position = rotatedDirection;
   }
}
