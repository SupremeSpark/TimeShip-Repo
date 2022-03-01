using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletPooler : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int poolSize;
    [SerializeField] private bool expandable;
    private List<GameObject> freeList;
    private List<GameObject> usedList;
    void Awake()
    {
        freeList = new List<GameObject>();
        usedList = new List<GameObject>();  

        for (int i = 0; i < poolSize; ++i) {

        } 
    }

    public GameObject GetObject(){
        int totalFree = freeList.Count;
        if (totalFree == 0 && !expandable) return null;
        else if (totalFree == 0) GenerateNewObject();

        GameObject g = freeList[totalFree - 1];
        freeList.RemoveAt(totalFree - 1);
        usedList.Add(g);
    }

    public void ReturnObject(GameObject obj){
        Debug.Assert(usedList.Contains(obj));
        obj.SetActive(false);
        usedList.Remove(obj);
        freeList.Add(obj);
    }
    private void GenerateNewObject(){
        GameObject g = Instantiate(prefab);
        g.transform.parent = transform;
        g.SetActive(false);
        freeList.Add(g);
    }
}
