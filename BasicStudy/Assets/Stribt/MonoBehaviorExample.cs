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
        Debug.Log("Update: �÷��Ӹ��� ȣ��˴ϴ�.");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate: ���� ���꿡 ���˴ϴ�.");
    }

    //��Ʈ�� ����Ʈ m
}
