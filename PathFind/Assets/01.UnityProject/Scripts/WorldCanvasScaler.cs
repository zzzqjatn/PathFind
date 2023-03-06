using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCanvasScaler : MonoBehaviour
{
    private Canvas worldCanvas = default;
    private Vector2 cameraSize = default;

    [SerializeField]    //private �� editor���� ���� �ְ� ���ִ� �ڵ�
    private Vector2 canvasAspect = default;

    void Start()
    {
        worldCanvas = gameObject.GetComponentMust<Canvas>();
        cameraSize = GFunc.GetCameraSize();
        Vector2 CanvasSize = worldCanvas.gameObject.GetRectSizeDelta();

        // ī�޶� ������� ĵ���� ������ ������ ũ�� �� ���Ѵ�.
        // width �� height �� �߿� �ϳ��� ������ ������ �����Ѵ�.
        canvasAspect.x = cameraSize.x / CanvasSize.x;
        canvasAspect.y = canvasAspect.x;

        // ���� ĵ������ ���� �������� ������ ������ ������ �����Ѵ�.
        worldCanvas.transform.localScale = canvasAspect;
    }   //Start()

    void Update()
    {
        
    }
}
