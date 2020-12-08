using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids.Managers;

namespace Asteroids.Gameplay
{
    [System.Serializable]
    public class Enemy : MonoBehaviour
    {
        public NextEnemySpawnClass currEnemySpawnClass;
        public List<NextEnemySpawnClass> spawnNewEnemyOnDestroyList = new List<NextEnemySpawnClass>();
        public bool toDestroy = false;
        public virtual void StartAnimation() 
        {
            throw new System.NotImplementedException();
        }

        public virtual void SetNewEnemyClassList(NextEnemySpawnClass currentEnemyClass, List<NextEnemySpawnClass> enemySpawnClasses)
        {
            spawnNewEnemyOnDestroyList = enemySpawnClasses;
            currEnemySpawnClass = currentEnemyClass;
        }

        public virtual void OnGotHitByBullet(Bullets bullet)
        {
            if (toDestroy) return;

            Debug.LogError("HERE");
            currEnemySpawnClass.enemyHealth -= bullet.bulletDamage;
            if (currEnemySpawnClass.enemyHealth <= 0)
            {
                toDestroy = true; 
                OnGotDestroyed();
            }
        }

        public virtual void SpawNextEnemy(NextEnemySpawnClass newEnemyData , List<NextEnemySpawnClass> newEnemySpawnClasses)
        {
            Debug.LogError("Spawn next Enemy");

            var count = Random.Range((int)newEnemyData.enemySpawnCountRange.x, (int)newEnemyData.enemySpawnCountRange.y);

            for (int i = 0; i < count; i++)
            {
                var enemyPrefab = ContentMaanger.GetEnemy(newEnemyData.enemyType);
                var newRotation = this.transform.eulerAngles + (Vector3.forward * Random.Range(0 , 360));
                var e = Instantiate(enemyPrefab, this.transform.position, Quaternion.Euler(newRotation));
                e.StartAnimation();
                e.SetNewEnemyClassList(newEnemyData ,newEnemySpawnClasses);
            }
        }

        public virtual void OnGotDestroyed()
        {
            Debug.LogError("On Destroyed");

            if (spawnNewEnemyOnDestroyList.Count > 0)
            {
                var curr = spawnNewEnemyOnDestroyList[0];

                spawnNewEnemyOnDestroyList.RemoveAt(0);

                SpawNextEnemy(curr, spawnNewEnemyOnDestroyList);

            }
              
            Destroy(gameObject );
        }
    }
}