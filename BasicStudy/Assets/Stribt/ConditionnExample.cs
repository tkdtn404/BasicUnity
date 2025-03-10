using UnityEngine;

public class ConditionnExample : MonoBehaviour
{
    //연산자와 조건문
    public int health = 100;


    void Start()
    {
        
    }

    
    void Update()
    {
        health -= 1;//체력감소
        Debug.Log("Health " + health);

        //조건문
        if(health <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
