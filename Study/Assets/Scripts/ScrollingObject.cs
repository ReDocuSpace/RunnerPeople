using UnityEngine;

// ���� ������Ʈ�� ��� �������� �����̴� ��ũ��Ʈ
public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; // �̵� �ӵ�

    private void Update()
    {
        // ���� ������ �ƴ϶��
        if (!GameManager.instance.isGameover)
        {
            // �ʴ� speed�� �ӵ��� �������� ���� �̵�
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}

