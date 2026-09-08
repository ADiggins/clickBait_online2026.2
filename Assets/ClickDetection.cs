using UnityEngine;
using UnityEngine.InputSystem;

public class ClickDetection : MonoBehaviour
{
   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {

   }

   // Update is called once per frame
   void Update()
   {
      if (Mouse.current.leftButton.wasPressedThisFrame)
      {         
         Vector3 mousePosition = Camera.main.ScreenToWorldPoint( Mouse.current.position.ReadValue() );
         //print("Mouse has just been clicked!: " + mousePosition );
         RaycastHit2D hit = Physics2D.Raycast( mousePosition, Vector3.forward );
         if (hit.collider != null)
         {
            //print(hit.transform.gameObject.name);
            //Associative -- ClickDetection 'uses a' Enemy component
            if ( hit.collider.TryGetComponent<Enemy>(out Enemy enemyComponent) )
            {
               enemyComponent.ChangeHealth(-1);
            }
         }
      }
   }
}
