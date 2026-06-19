using UnityEngine;

public class MazeCell : MonoBehaviour
{
  [SerializeField]
  private GameObject leftWall;
  [SerializeField]
  private GameObject rightWall;
  [SerializeField]
  private GameObject frontWall;
  [SerializeField]
  private GameObject backWall;
  [SerializeField]
  private GameObject unvisitedBlock;
  public bool isVisited { get; private set; }
  public int gridX;
  public int gridZ;
  public void Visit()
  {
    this.isVisited = true;
    this.unvisitedBlock.SetActive(false);
  }

  public void RemoveWall(Direction direction)
  {
    switch (direction)
    {
      case Direction.Left:
        this.leftWall.SetActive(false);
        break;
      case Direction.Right:
        this.rightWall.SetActive(false);
        break;
      case Direction.Front:
        this.frontWall.SetActive(false);
        break;
      case Direction.Back:
        this.backWall.SetActive(false);
        break;
    }
  }
}