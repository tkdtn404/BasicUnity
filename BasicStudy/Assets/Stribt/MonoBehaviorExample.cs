using UnityEngine;

public class MonoBehaviorExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update: 플레임마다 호출됩니다.");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate: 물리 연산에 사용됩니다.");
    }

    //컨트롤 쉬프트 m
}
