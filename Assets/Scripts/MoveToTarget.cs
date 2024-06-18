using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{
    public GameObject targetObject;  

    public NavMeshAgent agent;

    public void IniciaLacarreragaaaa()
    {
        agent.destination = targetObject.transform.position;
    }

    
}