using UnityEngine;

public class FuncExample : MonoBehaviour
{
    //�Լ� ����
    void SayHello()
    {
        Debug.Log("Hello , Unity");
    }

    int AdDNumbers(int a, int b)
    {
        return a + b;
    }

    void Start()
    {
        SayHello();//�Լ� ȣ��
        int total = AdDNumbers(3, 5);
        Debug.Log($"Total : {total}");

    }

    
    void Update()
    {
        
    }
}
