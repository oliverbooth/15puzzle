using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _15puzzle {
  class Puzzle {
    private TableLayoutPanel PuzzleGrid = null;
    private ToolStripStatusLabel lMoves = null, lSolvable = null, lEmptyCell = null;
    private Button OutFocus = null;

    public Puzzle(TableLayoutPanel TableGrid, ToolStripStatusLabel llMoves, ToolStripStatusLabel llSolvable, ToolStripStatusLabel llEmptyCell, Button bFocus) {
      PuzzleGrid = TableGrid;
      lMoves = llMoves;
      lSolvable = llSolvable;
      lEmptyCell = llEmptyCell;
      OutFocus = bFocus;
    }

    public enum Direction {
      Up, Down,
      Left, Right
    }

    public int Moves        = 0;
    public bool GameStarted = false;

    /// <summary>
    /// Gets the X / Y coordinate relative to a cell
    /// </summary>
    /// <param name="tile">The cell number to convert</param>
    public Point GridPosition(int tile) {
      int x = ((tile % 4) - 1 < 0 ? 3 : (tile % 4) - 1), // Calcuate the column the TILEth cell is in
          y = (x == 3 ? ((int)Math.Floor(tile / 4d) - 1) : (int)Math.Floor(tile / 4d)); // Calcuate the row the TILEth cell is in

      // Return X and Y as a Point
      return new Point(x == -1 ? 3 : x, y == -1 ? 3 : y);
    }
    /// <summary>
    /// Gets the X / Y coordinate relative to a cell
    /// </summary>
    /// <param name="tile">The cell number to convert</param>
    public int[] GridPositionInt(int tile) {
      return new int[] { GridPosition(tile).X, GridPosition(tile).Y };
    }
    public int FindTileValue(int value) {
      for(int i = 1 ; i<=16 ; i++) {
        if(GetTileValue(i) == value) return i;
      }
      return 0;
    }
    public void UpdateGUI() {
      try {
        lMoves.Text = Moves + " moves";
        lSolvable.Text = IsSolvable() ? "Solvable" : "Not solvable";
        lEmptyCell.Text = "EC @ " + TileAtEmptyCell();
        foreach(Control c in PuzzleGrid.Controls) {
          c.Visible = true;
        }
        PuzzleGrid.GetControlFromPosition(GridPositionInt(TileAtEmptyCell())[0], GridPositionInt(TileAtEmptyCell())[1]).Visible = false;
        OutFocus.Focus();
      } catch { }
      Application.DoEvents();
    }

    public bool MoveEmptyTile(Direction direction) {
      int e = TileAtEmptyCell();

      if(direction == Direction.Up) {
        if(GridPosition(e).Y > 0) {
          SetTileValue(new int[] { GridPosition(e).X, GridPosition(e).Y },
            GetTileValue(new int[] { GridPosition(e).X, GridPosition(e).Y - 1 }));

          SetTileValue(new int[] { GridPosition(e).X, GridPosition(e).Y - 1 }, "");
          return true;
        }
      } else if(direction == Direction.Down) {
        if(GridPosition(e).Y <= 2) {
          SetTileValue(new int[] { GridPosition(e).X, GridPosition(e).Y },
            GetTileValue(new int[] { GridPosition(e).X, GridPosition(e).Y + 1 }));

          SetTileValue(new int[] { GridPosition(e).X, GridPosition(e).Y + 1 }, "");
          return true;
        }
      } else if(direction == Direction.Left) {
        if(GridPosition(e).X > 0) {
          SetTileValue(new int[] { GridPosition(e).X, GridPosition(e).Y },
            GetTileValue(new int[] { GridPosition(e).X - 1, GridPosition(e).Y }));

          SetTileValue(new int[] { GridPosition(e).X - 1, GridPosition(e).Y }, "");
          return true;
        }
      } else if(direction == Direction.Right) {
        if(GridPosition(e).X <= 2) {
          SetTileValue(new int[] { GridPosition(e).X, GridPosition(e).Y },
            GetTileValue(new int[] { GridPosition(e).X + 1, GridPosition(e).Y }));

          SetTileValue(new int[] { GridPosition(e).X + 1, GridPosition(e).Y }, "");
          return true;
        }
      }
      return false;
    }

    public int TileAtEmptyCell() {
      for(int i = 1 ; i <= 16 ; i++) {
        if(GetTileValue(i) == 0) return i;
      }
      return 0;
    }

    public bool SolveOne() {
      // ************************
      // Move the 1 into place **
      // ************************

      // Check whether or not the 1 is in the 2nd, 3rd or 4th columnn
      if(GridPosition(FindTileValue(1)).X > 0) {
        // If the empty cell is to the left of 1
        while(GridPosition(TileAtEmptyCell()).X < GridPosition(FindTileValue(1)).X - 1) {
          // Move it right
          MoveEmptyTile(Direction.Right);
          Thread.Sleep(200);
        }
        // Otherwise
        while(GridPosition(TileAtEmptyCell()).X > GridPosition(FindTileValue(1)).X - 1) {
          // Move it left
          MoveEmptyTile(Direction.Left);
          Thread.Sleep(200);
        }

        while(GridPosition(TileAtEmptyCell()).Y > GridPosition(FindTileValue(1)).Y) {
          MoveEmptyTile(Direction.Up);
          Thread.Sleep(200);
        }
        while(GridPosition(TileAtEmptyCell()).Y < GridPosition(FindTileValue(1)).Y) {
          MoveEmptyTile(Direction.Down);
          Thread.Sleep(200);
        }

        if(GridPosition(FindTileValue(1)).Y == 3) {
          while(GridPosition(FindTileValue(1)).X > 0) {
            MoveEmptyTile(Direction.Right);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Up);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Left);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Left);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Down);
            Thread.Sleep(200);
          }
        } else {
          while(GridPosition(FindTileValue(1)).X > 0) {
            MoveEmptyTile(Direction.Right);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Down);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Left);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Left);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Up);
            Thread.Sleep(200);
          }
        }
        MoveEmptyTile(Direction.Right);
        Thread.Sleep(200);

        if(GridPosition(FindTileValue(1)).Y == 0) return true;
      }
      // Check whether or not the 1 is in the 1st column
      else if(GridPosition(FindTileValue(1)).X == 0) {
        while(GridPosition(TileAtEmptyCell()).X > GridPosition(FindTileValue(1)).X + 1) {
          // Move the empty cell left until we reach the right of 1
          MoveEmptyTile(Direction.Left);
          Thread.Sleep(200);
        }
        while(GridPosition(FindTileValue(1)).Y > 0) {
          MoveEmptyTile(Direction.Up);
          Thread.Sleep(200);
          MoveEmptyTile(Direction.Left);
          Thread.Sleep(200);
          MoveEmptyTile(Direction.Down);
          Thread.Sleep(200);
          MoveEmptyTile(Direction.Right);
          Thread.Sleep(200);
          MoveEmptyTile(Direction.Up);
          Thread.Sleep(200);
        }
        if(GridPosition(FindTileValue(1)).Y == 0) return true;
      }

      // Check whether or not the 1 is in the 2nd, 3rd or 4th row
      if(GridPosition(FindTileValue(1)).Y > 0) {
        while(GridPosition(TileAtEmptyCell()).X > GridPosition(FindTileValue(1)).X + 1) {
          // Move the empty cell left until we reach the right of 1
          MoveEmptyTile(Direction.Left);
          Thread.Sleep(200);
        }
        if(GridPosition(FindTileValue(1)).X == 0) {
          while(GridPosition(FindTileValue(1)).Y > 0) {
            MoveEmptyTile(Direction.Left);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Down);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Right);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Up);
            Thread.Sleep(200);
            MoveEmptyTile(Direction.Up);
            Thread.Sleep(200);
          }
        }
      }

      return GridPosition(FindTileValue(1)).X == 0 && GridPosition(FindTileValue(1)).Y == 0;
    }
    public bool SolveFromHere() {
      // ************************
      // Move the 1 into place **
      // ************************
      SolveOne();

      // Successfully solved
      return true;
    }

    public bool IsSolvable() {
      int parity = 0;
      for(int tile = 1 ; tile < 15 ; tile++) {
        for(int tileBefore = 1 ; tileBefore < tile ; tileBefore++) {
          if(GetTileValue(tileBefore) != 0 && GetTileValue(tile) != 0) {
            if(GetTileValue(tileBefore) > GetTileValue(tile)) {
              parity++;
            }
          }
        }
      }
      // Add 1 to pairty if empty tile is in row 0 or 2 (and not in 1 or 3)
      if((GetTileValue(TileAtEmptyCell()) % 2) == 0)
        parity++;
      // If pairty is even -> puzzle solvable
      return ((parity % 2) == 0);
    }
    public void ShuffleGrid(ToolStripProgressBar pbarShuffle) {
      Moves = 0;
      int NUM_OF_STEPS = new Random().Next(150, 250);
      pbarShuffle.Maximum = NUM_OF_STEPS;
      //BruteSolve();
      int steps = 0;
      while(steps < NUM_OF_STEPS) {
        int rnd = new Random().Next(1, 16);
        switch(rnd) {
          case 1: if(MoveEmptyTile(Direction.Left)) break; else continue;
          case 2: if(MoveEmptyTile(Direction.Down)) break; else continue;
          case 3: if(MoveEmptyTile(Direction.Right)) break; else continue;
          case 4: if(MoveEmptyTile(Direction.Up)) break; else continue;
          case 5: if(MoveEmptyTile(Direction.Left)) break; else continue;
          case 6: if(MoveEmptyTile(Direction.Down)) break; else continue;
          case 7: if(MoveEmptyTile(Direction.Right)) break; else continue;
          case 8: if(MoveEmptyTile(Direction.Up)) break; else continue;
          case 9: if(MoveEmptyTile(Direction.Left)) break; else continue;
          case 10: if(MoveEmptyTile(Direction.Down)) break; else continue;
          case 11: if(MoveEmptyTile(Direction.Right)) break; else continue;
          case 12: if(MoveEmptyTile(Direction.Up)) break; else continue;
          case 13: if(MoveEmptyTile(Direction.Left)) break; else continue;
          case 14: if(MoveEmptyTile(Direction.Down)) break; else continue;
          case 15: if(MoveEmptyTile(Direction.Right)) break; else continue;
          case 16: if(MoveEmptyTile(Direction.Up)) break; else continue;
          default: break; // Should not happen          
        }
        //Thread.Sleep(1);
        steps++;
        pbarShuffle.Value = steps;
      }
      GameStarted = true;
      UpdateGUI();
    }

    public int GetTileValue(int tile) {
      return GetTileValue(new int[] { GridPosition(tile).X, GridPosition(tile).Y });
    }
    public int GetTileValue(int[] point) {
      // If the cell at the given point is empty, return 0
      if(PuzzleGrid.GetControlFromPosition(point[0], point[1]).Text == "") return 0;
      // Otherwise, return its value
      else return Convert.ToInt32(PuzzleGrid.GetControlFromPosition(point[0], point[1]).Text);
    }
    public void SetTileValue(int[] point, object val) {
      // Assign the cell at the given point the given value unconditionally
      try {
        PuzzleGrid.GetControlFromPosition(point[0], point[1]).Text = val.ToString();
      } catch { }
      UpdateGUI();
    }
    public bool IsEmptyCell(int[] point) {
      // Check whether the cell at the given point is the empty one
      return PuzzleGrid.GetControlFromPosition(point[0], point[1]).Text == "";
    }
    public bool CheckWin(bool dispalyMessage) {
      if(GameStarted) {
        for(int i = 1 ; i < 16 ; i++) {
          if(GetTileValue(i) != i)
            return false;
        }
        if(GetTileValue(16) == 0) {
          if(dispalyMessage) {

            foreach(Control c in PuzzleGrid.Controls) {
              c.BackColor = Color.ForestGreen;
            }

            MessageBox.Show("Solved!\nIn " + Moves + " moves.", "15", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach(Control c in PuzzleGrid.Controls) {
              c.BackColor = SystemColors.Control;
            }
          }
          GameStarted = false;
          return true;
        }
      }
      return false;
    }
    public bool MoveCell(Direction direction, int[] point) {
      // Get the value of the cell at the given point, and store it in variable N
      int n = GetTileValue(point);

      // Clear the current cell
      SetTileValue(point, "");
      if(direction == Direction.Up) { // Move up?
        SetTileValue(new int[] { point[0], point[1] - 1 }, n); // Place the value of N in the cell
        if(GameStarted) Moves++;
      } else if(direction == Direction.Down) { // Move down?
        SetTileValue(new int[] { point[0], point[1] + 1 }, n); // Place the value of N in the cell
        if(GameStarted) Moves++;
      } else if(direction == Direction.Left) { // Move left?
        SetTileValue(new int[] { point[0] - 1, point[1] }, n); // Place the value of N in the cell
        if(GameStarted) Moves++;
      } else if(direction == Direction.Right) { // Move right?
        SetTileValue(new int[] { point[0] + 1, point[1] }, n); // Place the value of N in the cell
        if(GameStarted) Moves++;
      }
      UpdateGUI();
      CheckWin(true);
      return true;
    }

    /// <summary>
    /// Scans the cell in the direction given, relative to the coordinates given,
    /// </summary>
    /// <param name="movement">Which direction to scan</param>
    /// <param name="point">The position of the cell</param>
    public bool ScanEmptyCell(Direction direction, int[] point) {
      if(direction == Direction.Up) { // Check up?
        if(point[1] == 0) return false; // If the cell is topmost, there's no possible way an empty cell is above it
        if(IsEmptyCell(new int[] { point[0], point[1] - 1 })) return true; // The cell above is empty
      } else if(direction == Direction.Down) { // Check down?
        if(point[1] == 3) return false; // If the cell is bottommost, there's no possible way an empty cell is below it
        if(IsEmptyCell(new int[] { point[0], point[1] + 1 })) return true; // The cell below is empty
      } else if(direction == Direction.Left) { // Check left?
        if(point[0] == 0) return false; // If the cell is lefmost, there's no possible way an empty cell is to the left
        if(IsEmptyCell(new int[] { point[0] - 1, point[1] })) return true;  // The cell to the left is empty
      } else if(direction == Direction.Right) { // Check right?
        if(point[0] == 3) return false; // If the cell is rightmost, there's no possible way an empty cell is to the right
        if(IsEmptyCell(new int[] { point[0] + 1, point[1] })) return true; // The cell to the right is empty
      }

      return false;
    }

    public void BruteSolve() {
      for(int i = 1 ; i < 16 ; i++) { // Iterate through the 15 cells
        // Place their respective values
        PuzzleGrid.GetControlFromPosition(GridPosition(i).X, GridPosition(i).Y).Text = i.ToString();
      }
      // Clear the value of the final cell, just in case
      PuzzleGrid.GetControlFromPosition(3, 3).Text = "";
      Moves = 0;
      UpdateGUI();
    }
  }
}
