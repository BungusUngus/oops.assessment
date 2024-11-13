using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/hammer")]
public class HammerPowerup : Powerup
{
    public LayerMask mask;
    public float radius = 8f;

    public override void UsePowerup(Rigidbody rb)
    {
        //int mask = 1 << LayerMask.NameToLayer("Marble");
        Collider[] neighbours = Physics.OverlapSphere(rb.position, radius, mask);

        foreach (Collider col in neighbours)
        {
            if (col.transform == rb.transform) continue;

            col.attachedRigidbody.AddExplosionForce(power, rb.position, radius);
        }
    }

    /*
    void OnDrawGizmos()
    {
        if (rbtest != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(rbtest.position, 8f);
        }
    }*/
}
