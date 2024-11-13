using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/glue")]
public class GluePowerUp : Powerup
{
    public override void UsePowerup(Rigidbody rb)
    {
        Rigidbody[] otherRbs = FindObjectsOfType<Rigidbody>();

        Debug.Log("test");
        HighscoreSystem.instance.StartCoroutine(StickyTime(rb, otherRbs));

        /*foreach (var otherRb in otherRbs)
        {

        }*/
    }

    IEnumerator StickyTime(Rigidbody rb, Rigidbody[] otherRbs)
    {
        float startTime = Time.time;

        while (startTime + duration > Time.time)
        {
            for (int i = 0; i < otherRbs.Length; i++)
            {
                Rigidbody otherRb = otherRbs[i];

                if (otherRb == rb) continue;
                if (otherRb.gameObject.layer != LayerMask.NameToLayer("Marble"))
                {
                    continue;
                }
                float reduction = Mathf.Clamp01( Mathf.InverseLerp(100,0,power));
                otherRb.velocity *=  reduction;
            }

            yield return new WaitForFixedUpdate();
        }
    }
}
