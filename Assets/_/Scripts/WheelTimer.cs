using ColliderEventSystem;
using System.Collections;
using UnityEngine;

public class WheelTimer : MonoBehaviour
{
    [SerializeField, Min(0f)] private float delay = 1f;

    public void Reactivate(BoolVariable variable)
    {
        if (variable != null)
        {
            StartCoroutine(ReactivateRoutine(variable));
        }
    }

    private IEnumerator ReactivateRoutine(BoolVariable variable)
    {
        yield return new WaitForSeconds(delay);
        variable.RuntimeValue = true;
    }
}