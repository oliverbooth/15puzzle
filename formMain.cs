using _15puzzle.Properties;
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
  public partial class formMain : Form {

    // f0a26fa8-d56d-49bd-ba26-01bbaeaf682d
    Puzzle Puzzle = null;

    public formMain() {
      Puzzle = new Puzzle(tableGrid, labelMoves, labelSolvable, labelEmptycell, button1);
      InitializeComponent();
      string vers = Resources.appVersion.Trim();
      if(vers != string.Empty)
        vers = " " + vers;
      Text = "15.NET (v " + Application.ProductVersion + "" + vers + ")";

      if(!File.Exists(Environment.CurrentDirectory + "\\settings.ini")) {
        INI.WriteVal(Environment.CurrentDirectory + "\\settings.ini", "size", "width", this.Width.ToString());
        INI.WriteVal(Environment.CurrentDirectory + "\\settings.ini", "size", "height", this.Height.ToString());
      }

      this.Width = Convert.ToInt32(INI.ReadVal(Environment.CurrentDirectory + "\\settings.ini", "size", "width"));
      this.Height = Convert.ToInt32(INI.ReadVal(Environment.CurrentDirectory + "\\settings.ini", "size", "height"));
    }

    private void bruteSolveToolStripMenuItem_Click(object sender, EventArgs e) {
      // Brute solve the puzzle
      Puzzle.BruteSolve();
    }

    #region Clicks
    // Cell at 0, 0
    private void b0x0y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 0, 0 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 0, 0 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 0, 0 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 0, 0 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 0, 0 }); // Move the cell right
      }
    }
    // Cell at 1, 0
    private void b1x0y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 1, 0 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 1, 0 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 1, 0 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 1, 0 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 1, 0 }); // Move the cell right
      }
    }
    // Cell at 2, 0
    private void b2x0y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 2, 0 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 2, 0 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 2, 0 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 2, 0 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 2, 0 }); // Move the cell right
      }
    }
    // Cell at 3, 0
    private void b3x0y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 3, 0 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 3, 0 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 3, 0 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 3, 0 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 3, 0 }); // Move the cell right
      }
    }
    // Cell at 0, 1
    private void b0x1y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 0, 1 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 0, 1 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 0, 1 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 0, 1 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 0, 1 }); // Move the cell right
      }
    }
    // Cell at 1, 1
    private void b1x1y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 1, 1 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 1, 1 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 1, 1 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 1, 1 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 1, 1 }); // Move the cell right
      }
    }
    // Cell at 2, 1
    private void b2x1y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 2, 1 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 2, 1 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 2, 1 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 2, 1 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 2, 1 }); // Move the cell right
      }
    }
    // Cell at 3, 1
    private void b3x1y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 3, 1 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 3, 1 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 3, 1 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 3, 1 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 3, 1 }); // Move the cell right
      }
    }
    // Cell at 0, 2
    private void b0x2y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 0, 2 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 0, 2 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 0, 2 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 0, 2 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 0, 2 }); // Move the cell right
      }
    }
    // Cell at 1, 2
    private void b1x2y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 1, 2 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 1, 2 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 1, 2 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 1, 2 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 1, 2 }); // Move the cell right
      }
    }
    // Cell at 2, 2
    private void b2x2y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 2, 2 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 2, 2 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 2, 2 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 2, 2 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 2, 2 }); // Move the cell right
      }
    }
    // Cell at 3, 2
    private void b3x2y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 3, 2 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 3, 2 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 3, 2 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 3, 2 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 3, 2 }); // Move the cell right
      }
    }
    // Cell at 0, 3
    private void b0x3y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 0, 3 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 0, 3 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 0, 3 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 0, 3 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 0, 3 }); // Move the cell right
      }
    }
    // Cell at 1, 3
    private void b1x3y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 1, 3 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 1, 3 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 1, 3 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 1, 3 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 1, 3 }); // Move the cell right
      }
    }
    // Cell at 2, 3
    private void b2x3y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 2, 3 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 2, 3 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 2, 3 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 2, 3 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 2, 3 }); // Move the cell right
      }
    }
    // Cell at 3, 3
    private void b3x3y_Click(object sender, EventArgs e) {
      Puzzle.UpdateGUI();
      if(Puzzle.ScanEmptyCell(Puzzle.Direction.Up, new int[] { 3, 3 })) { // Is the cell above empty?
        Puzzle.MoveCell(Puzzle.Direction.Up, new int[] { 3, 3 }); // Move the cell upwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Down, new int[] { 0, 3 })) { // Is the cell below empty?
        Puzzle.MoveCell(Puzzle.Direction.Down, new int[] { 3, 3 }); // Move the cell downwards
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Left, new int[] { 0, 3 })) {  // Is the cell leftwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Left, new int[] { 3, 3 }); // Move the cell left
      } else if(Puzzle.ScanEmptyCell(Puzzle.Direction.Right, new int[] { 0, 3 })) { // Is the cell rightwards empty?
        Puzzle.MoveCell(Puzzle.Direction.Right, new int[] { 3, 3 }); // Move the cell right
      }
    }
    #endregion

    private void formMain_Load(object sender, EventArgs e) {
      Puzzle = new Puzzle(tableGrid, labelMoves, labelSolvable, labelEmptycell, button1);
      Puzzle.UpdateGUI();
      Puzzle.BruteSolve();
    }

    private void shuffleToolStripMenuItem_Click(object sender, EventArgs e) {
      Puzzle.ShuffleGrid(pbarShuffle);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
      Environment.Exit(0);
    }

    private void formMain_KeyPress(object sender, KeyPressEventArgs e) {
      if(e.KeyChar == 'w') {
        if(Puzzle.MoveEmptyTile(Puzzle.Direction.Down)) Puzzle.Moves++;
        Puzzle.CheckWin(true);
        Puzzle.UpdateGUI();
      }
      if(e.KeyChar == 's') {
        if(Puzzle.MoveEmptyTile(Puzzle.Direction.Up)) Puzzle.Moves++;
        Puzzle.CheckWin(true);
        Puzzle.UpdateGUI();
      }
      if(e.KeyChar == 'a') {
        if(Puzzle.MoveEmptyTile(Puzzle.Direction.Right)) Puzzle.Moves++;
        Puzzle.CheckWin(true);
        Puzzle.UpdateGUI();
      }
      if(e.KeyChar == 'd') {
        if(Puzzle.MoveEmptyTile(Puzzle.Direction.Left)) Puzzle.Moves++;
        Puzzle.CheckWin(true);
        Puzzle.UpdateGUI();
      }
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
      new formAbout().ShowDialog(this);
    }

    private void logicallySolveToolStripMenuItem_Click(object sender, EventArgs e) {
      Puzzle.SolveFromHere();
    }

    private void specificToolStripMenuItem_Click(object sender, EventArgs e) {
      formSpecificgame fsg = new formSpecificgame();
      fsg.ShowDialog();
      for(int i = 0; i < fsg.Grid.Length; i++){
        Puzzle.SetTileValue(Puzzle.GridPositionInt(i + 1), fsg.Grid[i]);
        Application.DoEvents();
      }
      if(Puzzle.MoveEmptyTile(Puzzle.Direction.Up)) {
        Puzzle.MoveEmptyTile(Puzzle.Direction.Down);
      } else if(Puzzle.MoveEmptyTile(Puzzle.Direction.Down)) {
        Puzzle.MoveEmptyTile(Puzzle.Direction.Up);
      }
      Application.DoEvents();
      Puzzle.GameStarted = true;
      Puzzle.UpdateGUI();
    }
  }
}