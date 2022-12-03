using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public int health;
    public int cost;

    protected virtual void Start()
    {

    }

    public virtual bool LoseHealth(int amount)
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);
            return true;
        }
        return false;
    }
}
