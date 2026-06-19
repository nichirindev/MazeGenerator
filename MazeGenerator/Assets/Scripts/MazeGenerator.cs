using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class MazeGenerator : MonoBehaviour
{
  [SerializeField]
  private MazeCell cellPrefab;
  [SerializeField]
  private GameObject structurePrefab;
  [SerializeField]
  private int width = 10;
  [SerializeField]
  private int height = 10;
  private MazeCell[,] mazeGrid;
  [SerializeField]
  private int randomVariations = 10;

void Start()
{
    this.mazeGrid = new MazeCell[this.width, this.height];
    for (int x = 0; x < this.width; ++x)
    {
      for (int z = 0; z < this.height; ++z)
      {
        MazeCell cell = Instantiate(cellPrefab, new Vector3(x, 0, z), Quaternion.identity, transform);
        cell.gridX = x;
        cell.gridZ = z;
        mazeGrid[x, z] = cell;
      }
    }
    this.GenerateMaze((MazeCell) null, this.mazeGrid[0, 0]);
    for (int index = 0; index < this.randomVariations; ++index)
      this.RandomVariation();
    this.transform.localScale = new Vector3(15f, 80f, 15f);
    for (int index = 0; index < 3; ++index)
    {
      RaycastHit hitInfo;
      if (Physics.Raycast(new Vector3((float) (UnityEngine.Random.Range(1, this.width - 1) * 15), 50f, (float) (UnityEngine.Random.Range(1, this.height - 1) * 15)), Vector3.down, out hitInfo, 100f))
        Instantiate(this.structurePrefab, hitInfo.point, Quaternion.identity);
    }
  }

  private void GenerateMaze(MazeCell prevCell, MazeCell curCell)
  {
    curCell.Visit();
    this.ClearWalls(prevCell, curCell);
    MazeCell nextUnvisitedCell;
    do
    {
      nextUnvisitedCell = this.GetNextUnvisitedCell(curCell);
      if (nextUnvisitedCell != null)
        this.GenerateMaze(curCell, nextUnvisitedCell);
    }
    while (nextUnvisitedCell != null);
  }

  private MazeCell GetNextUnvisitedCell(MazeCell curCell)
  {
    return this.GetUnivistedNeighbours(curCell).OrderBy<MazeCell, int>((Func<MazeCell, int>) (_ => UnityEngine.Random.Range(1, 10))).FirstOrDefault<MazeCell>();
  }

  private List<MazeCell> GetUnivistedNeighbours(MazeCell currentCell)
  {
    List<MazeCell> univistedNeighbours = new List<MazeCell>();
    int x = currentCell.gridX;
    int z = currentCell.gridZ;
    if (x + 1 < this.width)
    {
      MazeCell mazeCell = this.mazeGrid[x + 1, z];
      if (!mazeCell.isVisited)
        univistedNeighbours.Add(mazeCell);
    }
    if (x - 1 >= 0)
    {
      MazeCell mazeCell = this.mazeGrid[x - 1, z];
      if (!mazeCell.isVisited)
        univistedNeighbours.Add(mazeCell);
    }
    if (z + 1 < this.height)
    {
      MazeCell mazeCell = this.mazeGrid[x, z + 1];
      if (!mazeCell.isVisited)
        univistedNeighbours.Add(mazeCell);
    }
    if (z - 1 >= 0)
    {
      MazeCell mazeCell = this.mazeGrid[x, z - 1];
      if (!mazeCell.isVisited)
        univistedNeighbours.Add(mazeCell);
    }
    return univistedNeighbours;
  }

  private void ClearWalls(MazeCell prevCell, MazeCell curCell)
  {
    if (!(prevCell != null))
      return;
    int num1 = (int) ((double) curCell.transform.position.x - (double) prevCell.transform.position.x);
    int num2 = (int) ((double) curCell.transform.position.z - (double) prevCell.transform.position.z);
    if (num1 == 1)
    {
      prevCell.RemoveWall(Direction.Right);
      curCell.RemoveWall(Direction.Left);
    }
    else if (num1 == -1)
    {
      prevCell.RemoveWall(Direction.Left);
      curCell.RemoveWall(Direction.Right);
    }
    else if (num2 == 1)
    {
      prevCell.RemoveWall(Direction.Front);
      curCell.RemoveWall(Direction.Back);
    }
    else
    {
      if (num2 != -1)
        return;
      prevCell.RemoveWall(Direction.Back);
      curCell.RemoveWall(Direction.Front);
    }
  }

  private void RandomVariation()
  {
    int index1 = UnityEngine.Random.Range(1, this.width - 1);
    int index2 = UnityEngine.Random.Range(1, this.height - 1);
    MazeCell mazeCell = this.mazeGrid[index1, index2];
    switch (UnityEngine.Random.Range(0, 4))
    {
      case 0:
        mazeCell.RemoveWall(Direction.Left);
        this.mazeGrid[index1 - 1, index2].RemoveWall(Direction.Right);
        break;
      case 1:
        mazeCell.RemoveWall(Direction.Right);
        this.mazeGrid[index1 + 1, index2].RemoveWall(Direction.Left);
        break;
      case 2:
        mazeCell.RemoveWall(Direction.Front);
        this.mazeGrid[index1, index2 + 1].RemoveWall(Direction.Back);
        break;
      case 3:
        mazeCell.RemoveWall(Direction.Back);
        this.mazeGrid[index1, index2 - 1].RemoveWall(Direction.Front);
        break;
    }
  }
}