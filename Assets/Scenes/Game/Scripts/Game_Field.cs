using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// 盤面の制御クラス
/// </summary>

public class Game_Field : UIBehaviour
{
    /// <summary>
    /// 石の色定義
    /// </summary>
    public enum StoneColor
    {
        None,
        Black,
        White
    }

    [SerializeField]
    Game_Cell cellPrefab;

    List<Game_Cell> cells = new List<Game_Cell>();
    int possibleCoroutineCount;

    protected override void Awake()
    {
        base.Awake();
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                Game_Cell cell = Instantiate(cellPrefab, transform);
                cell.transform.SetParent(transform);
                cell.transform.localScale = Vector3.one;
                cell.Initialize(x, y);
                cells.Add(cell);
            }
        }
    }

    /// <summary>
    /// フィールド初期化処理
    /// </summary>
    public void Initialize()
    {
        foreach (Game_Cell cell in cells)
        {
            cell.SetStoneColor(StoneColor.None);
            if (cell.X == 3)
            {
                if (cell.Y == 3)
                {
                    cell.SetStoneColor(StoneColor.White);
                }
                if (cell.Y == 4)
                {
                    cell.SetStoneColor(StoneColor.Black);
                }
            }
            else if (cell.X == 4)
            {
                if (cell.Y == 3)
                {
                    cell.SetStoneColor(StoneColor.Black);
                }
                if (cell.Y == 4)
                {
                    cell.SetStoneColor(StoneColor.White);
                }
            }
        }

    }

    /// <summary>
    /// 全てのマスをクリック不可にします
    /// </summary>
    public void Lock()
    {

    }

    /// <summary>
    /// 指定したマスを起点に、可能であれば石をひっくり返します
    /// </summary>

    public void TurnOverStoneIfPossible(Game_Cell cell)
    {

    }

    /// <summary>
    /// 指定色の石の数を数えます
    /// </summary>

    public int CountStone(StoneColor stoneColor)
    {
        return 0;
    }

    /// <summary>
    /// クリック可能なマスの数を数えます
    /// </summary>
    public int CountClickableCells()
    {
        return 0;
    }

    /// <summary>
    /// 各マスのクリック可否状態を更新します
    /// </summary>
    public void UpdateCellsClickable(StoneColor stoneColor)
    {

    }

    /// <summary>
    /// 石が配置可能なマスかどうか確認します
    /// </summary>

    bool IsStonePuttableCell(Game_Cell cell, StoneColor stoneColor)
    {
        if (true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// 任意のマスから指定された方向に対し、相手の石を挟める場所に自分の石が配置されているかチェックします
    /// </summary>

    bool Turncheck(Game_Cell cell, StoneColor stoneColor, int xDirection, int yDirection)
    {
        return true;
    }

    /// <summary>
    /// 石をひっくり返すコルーチンを呼ぶためのコルーチンです。
    /// </summary>

    IEnumerator CallTurnStoneCoroutine(Game_Cell cell)
    {
        yield break;
    }

    /// <summary>
    /// 石をひっくり返すコルーチンです。（指定した1方向に対して処理をかける実働メソッド）
    /// </summary>

    IEnumerator TurnStoneCoroutine(Game_Cell cell, int xDirection, int yDirection)
    {
        yield break;
    }

    /// <summary>
    /// 指定場所のマスを取得します
    /// </summary>

    Game_Cell GetCell(int x, int y)
    {
        Game_Cell target_Cell = new Game_Cell();
        foreach (Game_Cell cell in cells)
        {
            if (cell.X == x && cell.Y == y)
            {
                target_Cell = cell;
            }
        }
        return target_Cell;
    }
}
