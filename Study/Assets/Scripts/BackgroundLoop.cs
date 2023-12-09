using UnityEngine;

// ���� ������ �̵��� ����� ������ ������ ���ġ�ϴ� ��ũ��Ʈ
public class BackgroundLoop : MonoBehaviour
{
    private float width; // ����� ���� ����

    private void Awake()
    {
        // BoxCollider2D ������Ʈ�� Size �ʵ��� X ���� ���� ���̷� ���
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }

    private void Update()
    {
        // ���� ��ġ�� �������� �������� width �̻� �̵������� ��ġ�� ����
        if (transform.position.x <= -width)
        {
            Reposition();
        }
    }

    // ��ġ�� �����ϴ� �޼���
    private void Reposition()
    {
        // ���� ��ġ���� ���������� ���α��� * 2 ��ŭ �̵�
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + offset;
    }
}
