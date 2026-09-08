using UnityEngine;

public class Spawner : MonoBehaviour
{
   public float spawnDistance = 5;
   public float spawnInitialDelay = 2;
   public float spawnDelay = 0.75f;
   public GameObject[] spawnedObjs;
   public GameObject spawnedObj; //Aggregate Relationship -- 'Spawner has a spawnedObj'

   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {
      //SpawnObject(); //Run function normally
      //Invoke( "SpawnObject", 1 ); //Run function after 1s delay
      InvokeRepeating( "SpawnObject", spawnInitialDelay, spawnDelay); //Run function 'again and again' every 1s
   }

   public void SpawnObject()
   {
      Vector3 newPos = Random.insideUnitCircle.normalized * spawnDistance;
      spawnedObj = spawnedObjs[ Random.Range( 0,spawnedObjs.Length ) ];
      Instantiate( spawnedObj, transform.position + newPos, transform.rotation );
   }

   
}
