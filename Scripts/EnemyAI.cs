using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//추가

public class EnemyAI : MonoBehaviour
{
    GameObject player;
    NavMeshAgent enemy;

    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Player");//플레이어 태그 찾음
        //플레이어가 없으면
        if(player==null)
        {
          Debug.Log("플레이어가 없음");
        }
        enemy= GetComponent<NavMeshAgent>();//좀비
    }

    // Update is called once per frame
    void Update()
    {
        enemy.destination=player.transform.position;//좀비가 플레이어를 따라감.
    }
}
