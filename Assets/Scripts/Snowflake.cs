using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowflake : Projectile
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Transformable"))
        {
            collision.gameObject.SetActive(false);

            TemporaryPlatform tp = Instantiate(GameManager.Instance.Platform, collision.transform).GetComponent<TemporaryPlatform>();
            tp.SetTimer(collision.gameObject);
        }
    }
}
