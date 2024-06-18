using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class MoveOnClick : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public GameObject targetObject;
    public UnityEvent pescao;

    public void MovimientoOnClick(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                navMeshAgent.destination = hit.point;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pescado"))
        {
            pescao.Invoke();
        }
    }
}
