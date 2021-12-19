using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterManager
{
    public GameObject Player;
    private NavMeshAgent _agent;

    public void Init()
    {
        var tag = "Player";
        Player = GameObject.FindGameObjectWithTag(tag);
        _agent = Player.GetComponent<NavMeshAgent>();
    }

    public void StopAgent()
    {
        _agent.isStopped = true;
        _agent.enabled = false;
    }

    public void OpenAgent()
    {
        _agent.enabled = true;
    }


}
