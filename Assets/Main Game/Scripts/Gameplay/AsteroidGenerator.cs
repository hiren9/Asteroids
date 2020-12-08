using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids.Managers;

namespace Asteroids.Gameplay
{
    public class AsteroidGenerator : MonoBehaviour
    {
        public float AsteroidDeathTime;
        public List<AsteroidGenerationData> asteroidGenerationDataList;

        public AsteroidGenerationData currentGenerationData;
        private Coroutine continuousAsteroidGeneration;
        
        public void StartGenrating()
        {
            ChangeWave();
        }

        private void Start()
        {
            StartGenrating();
        }

        private void OnDisable()
        {
            StopAllCoroutines();
        }

        private void GenerateAsteroid()
        {
            var enemyType = currentGenerationData.typesOfAsteroidGeneration[Random.Range(0, currentGenerationData.typesOfAsteroidGeneration.Count)];
            var enemy = ContentMaanger.GetEnemy(enemyType);
            var randomTargetx = Random.Range(-ObjectReference.AsteroidTargetRange.x, ObjectReference.AsteroidTargetRange.x);
            var randomTargety = Random.Range(-ObjectReference.AsteroidTargetRange.y, ObjectReference.AsteroidTargetRange.y);
            var newTargetPosition = new Vector2(randomTargetx, randomTargety);
            var newposition = GetRandomPointOnCircle(ObjectReference.spawnRadius);
            var newRotation = GetRotationFromPosition(newTargetPosition, newposition);
            var e = Instantiate(enemy, newposition,  newRotation , ObjectReference.EnemeyParent.transform);
            e.StartAnimation();
            Destroy(e.gameObject, AsteroidDeathTime);
        }

        private void GenerateWave()
        {
            for (int i = 0; i < currentGenerationData.waveAsteroidCount; i++)
            {
                GenerateAsteroid();
            }
        }

        private Quaternion GetRotationFromPosition(Vector3 target , Vector3 fromPosition)
        {
            var dir = target - fromPosition;
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            angle -= 90;
            return Quaternion.AngleAxis(angle, Vector3.forward);
        }

        private Vector2 GetRandomPointOnCircle(float radius)
        {
            return Random.insideUnitCircle.normalized * radius;
        }

        private void ChangeWave()
        {
            SetCurrentGenerationData();
            StartCoroutine(StartWaveCounter(currentGenerationData.waveTime));
            if(continuousAsteroidGeneration != null) StopCoroutine(continuousAsteroidGeneration);                            
            continuousAsteroidGeneration = StartCoroutine(ContinuousAsteroidGenerator(currentGenerationData.AsteroidsPer5Sec));
            GenerateWave();
        }

        private void SetCurrentGenerationData()
        {
            if (!(asteroidGenerationDataList.Count > 0)) return;            

            currentGenerationData = asteroidGenerationDataList[0];
            asteroidGenerationDataList.RemoveAt(0);

        }

        IEnumerator StartWaveCounter(float time)
        {
            yield return new WaitForSeconds(time);

            ChangeWave();
        }


        IEnumerator ContinuousAsteroidGenerator(float rate )
        {
            WaitForSeconds wait = new WaitForSeconds(5 / rate);
            while (true)
            {
                yield return wait;
                GenerateAsteroid();
            }
        }
    }

    [System.Serializable]
    public class AsteroidGenerationData
    {
        public int waveNumber;
        public float AsteroidsPer5Sec;
        public int waveAsteroidCount;
        public float waveTime;
        public List<EnemyTypes> typesOfAsteroidGeneration = new List<EnemyTypes>();        
    }
}