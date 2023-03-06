using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class MapBoard : MonoBehaviour
{
    private const string TERRAIN_MAP_OBJ_NAME = "TerrainMap";

    public Vector2Int MapCellSize { get; private set; } = default;
    public Vector2 MapCellGap { get; private set; } = default;

    private TerrainMap terrainMap = default;

    private void Awake()
    {
        // { ���� �Ŵ����� ��� �ʱ�ȭ�Ѵ�.
        ResManager.Instance.Create();
        // } ���� �Ŵ����� ��� �ʱ�ȭ�Ѵ�.

        // �ʿ� ������ �ʱ�ȭ�Ͽ� ��ġ�Ѵ�.
        terrainMap = gameObject.FindChildComponent<TerrainMap>(TERRAIN_MAP_OBJ_NAME);
        terrainMap.InitAwake(this);
        MapCellSize = terrainMap.GetCellSize();
        MapCellGap = terrainMap.GetCellGap();
    }
}
