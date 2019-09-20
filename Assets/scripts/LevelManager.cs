using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{
    [SerializeField]
    List<GameObject> grounds;

    [SerializeField]
    private CameraMovement cameraMovement;

    private Dictionary<Point, int> stage;
    public Dictionary<Point, GameObject> Grid { get; set; }


    private int mapX = 15;
    private int mapY = 10;

    public float TileSize
    {
        get { return grounds[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x; }
    }

    void Start()
    {
        CreateStage();
    }


    private void CreateStage()
    {

        stage = new Dictionary<Point, int>();
        Grid = new Dictionary<Point, GameObject>();

        int[,] map = { {02,04,04,04,04,04,04,04,04,04,04,03},
                       {06,17,05,05,05,05,05,19,17,05,05,01},
                       {06,09,08,08,08,08,08,06,09,08,08,15},
                       {06,09,08,02,04,03,08,06,09,08,02,03},
                       {06,09,08,06,07,09,08,06,09,08,06,09},
                       {06,09,08,06,07,09,08,06,09,08,06,09},
                       {00,01,08,06,07,09,08,00,01,08,06,09},
                       {14,08,08,06,07,09,08,08,08,08,06,09},
                       {02,04,04,18,07,16,04,04,04,04,18,09},
                       {00,05,05,05,05,05,05,05,05,05,05,01} };

        showStage(map);

    }

    private void SetSpawnPointsAndDefense(int nSpawns, int nDefense)
    {

        List<Point> spawnPoints = new List<Point>();

        Point spawnPoint = setPoint();
        Point defensePoint = setPoint();

    }

    private Point setPoint()
    {

        int side = Random.Range(0, 3);

        Point point = new Point();

        switch (side)
        {
            case 0:
                point = new Point(1, Random.Range(1, mapY - 1));
                break;
            case 1:
                point = new Point(mapX - 1, Random.Range(1, mapY - 1));
                break;
            case 2:
                point = new Point(Random.Range(1, mapX - 1), 1);
                break;
            case 3:
                point = new Point(Random.Range(1, mapX - 1), mapY - 1);
                break;
        }

        return point;

    }


    private void showStage(int[,] map)
    {

        Vector3 initialPoint = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height));


        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {

                Vector3 position = new Vector3(initialPoint.x + (TileSize * x), initialPoint.y - (TileSize * y), 0);
                Grid.Add(new Point(x, y), Instantiate(grounds[map[y, x]], position, rotation: Quaternion.identity));

            }
        }

        GameObject maxTile = Grid[new Point(map.GetLength(1) - 1, map.GetLength(0) - 1)];

        cameraMovement.setLimits(new Vector3((maxTile.transform.position.x +TileSize),(maxTile.transform.position.y - TileSize), 0));

    }


}

