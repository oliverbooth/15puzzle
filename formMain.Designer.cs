namespace _15puzzle {
  partial class formMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.stripMenu = new System.Windows.Forms.MenuStrip();
      this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.specificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.solveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bruteSolveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.logicallySolveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.stripStatus = new System.Windows.Forms.StatusStrip();
      this.pbarShuffle = new System.Windows.Forms.ToolStripProgressBar();
      this.labelMoves = new System.Windows.Forms.ToolStripStatusLabel();
      this.labelSolvable = new System.Windows.Forms.ToolStripStatusLabel();
      this.labelEmptycell = new System.Windows.Forms.ToolStripStatusLabel();
      this.tableGrid = new System.Windows.Forms.TableLayoutPanel();
      this.b3x3y = new System.Windows.Forms.Button();
      this.b2x3y = new System.Windows.Forms.Button();
      this.b1x3y = new System.Windows.Forms.Button();
      this.b0x3y = new System.Windows.Forms.Button();
      this.b3x2y = new System.Windows.Forms.Button();
      this.b2x2y = new System.Windows.Forms.Button();
      this.b1x2y = new System.Windows.Forms.Button();
      this.b0x2y = new System.Windows.Forms.Button();
      this.b3x1y = new System.Windows.Forms.Button();
      this.b2x1y = new System.Windows.Forms.Button();
      this.b1x1y = new System.Windows.Forms.Button();
      this.b0x1y = new System.Windows.Forms.Button();
      this.b3x0y = new System.Windows.Forms.Button();
      this.b2x0y = new System.Windows.Forms.Button();
      this.b1x0y = new System.Windows.Forms.Button();
      this.b0x0y = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.stripMenu.SuspendLayout();
      this.stripStatus.SuspendLayout();
      this.tableGrid.SuspendLayout();
      this.SuspendLayout();
      // 
      // stripMenu
      // 
      this.stripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.stripMenu.Location = new System.Drawing.Point(0, 0);
      this.stripMenu.Name = "stripMenu";
      this.stripMenu.Size = new System.Drawing.Size(322, 24);
      this.stripMenu.TabIndex = 0;
      this.stripMenu.Text = "Menu";
      // 
      // gameToolStripMenuItem
      // 
      this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.solveToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
      this.gameToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
      this.gameToolStripMenuItem.Text = "&Game";
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shuffleToolStripMenuItem,
            this.specificToolStripMenuItem});
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
      this.toolStripMenuItem2.Text = "&New";
      // 
      // shuffleToolStripMenuItem
      // 
      this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
      this.shuffleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.shuffleToolStripMenuItem.Text = "Sh&uffle";
      this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.shuffleToolStripMenuItem_Click);
      // 
      // specificToolStripMenuItem
      // 
      this.specificToolStripMenuItem.Name = "specificToolStripMenuItem";
      this.specificToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
      this.specificToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.specificToolStripMenuItem.Text = "&Specific";
      this.specificToolStripMenuItem.Click += new System.EventHandler(this.specificToolStripMenuItem_Click);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Enabled = false;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.openToolStripMenuItem.Text = "&Open";
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Enabled = false;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.saveToolStripMenuItem.Text = "&Save";
      // 
      // solveToolStripMenuItem
      // 
      this.solveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bruteSolveToolStripMenuItem,
            this.logicallySolveToolStripMenuItem});
      this.solveToolStripMenuItem.Name = "solveToolStripMenuItem";
      this.solveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.solveToolStripMenuItem.Text = "Sol&ve";
      // 
      // bruteSolveToolStripMenuItem
      // 
      this.bruteSolveToolStripMenuItem.Name = "bruteSolveToolStripMenuItem";
      this.bruteSolveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
      this.bruteSolveToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.bruteSolveToolStripMenuItem.Text = "Brute solve";
      this.bruteSolveToolStripMenuItem.Click += new System.EventHandler(this.bruteSolveToolStripMenuItem_Click);
      // 
      // logicallySolveToolStripMenuItem
      // 
      this.logicallySolveToolStripMenuItem.Name = "logicallySolveToolStripMenuItem";
      this.logicallySolveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
      this.logicallySolveToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.logicallySolveToolStripMenuItem.Text = "Logically solve";
      this.logicallySolveToolStripMenuItem.Click += new System.EventHandler(this.logicallySolveToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.aboutToolStripMenuItem.Text = "&About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // checkForUpdatesToolStripMenuItem
      // 
      this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
      this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.checkForUpdatesToolStripMenuItem.Text = "&Check for updates";
      // 
      // stripStatus
      // 
      this.stripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbarShuffle,
            this.labelMoves,
            this.labelSolvable,
            this.labelEmptycell});
      this.stripStatus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
      this.stripStatus.Location = new System.Drawing.Point(0, 321);
      this.stripStatus.Name = "stripStatus";
      this.stripStatus.Size = new System.Drawing.Size(322, 22);
      this.stripStatus.TabIndex = 1;
      this.stripStatus.Text = "Status";
      // 
      // pbarShuffle
      // 
      this.pbarShuffle.Name = "pbarShuffle";
      this.pbarShuffle.Size = new System.Drawing.Size(100, 16);
      this.pbarShuffle.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      // 
      // labelMoves
      // 
      this.labelMoves.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
      this.labelMoves.Name = "labelMoves";
      this.labelMoves.Size = new System.Drawing.Size(27, 17);
      this.labelMoves.Text = "n/a";
      // 
      // labelSolvable
      // 
      this.labelSolvable.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
      this.labelSolvable.Name = "labelSolvable";
      this.labelSolvable.Size = new System.Drawing.Size(27, 17);
      this.labelSolvable.Text = "n/a";
      // 
      // labelEmptycell
      // 
      this.labelEmptycell.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
      this.labelEmptycell.Name = "labelEmptycell";
      this.labelEmptycell.Size = new System.Drawing.Size(27, 17);
      this.labelEmptycell.Text = "n/a";
      // 
      // tableGrid
      // 
      this.tableGrid.BackColor = System.Drawing.SystemColors.ControlDark;
      this.tableGrid.ColumnCount = 4;
      this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableGrid.Controls.Add(this.b3x3y, 3, 3);
      this.tableGrid.Controls.Add(this.b2x3y, 2, 3);
      this.tableGrid.Controls.Add(this.b1x3y, 1, 3);
      this.tableGrid.Controls.Add(this.b0x3y, 0, 3);
      this.tableGrid.Controls.Add(this.b3x2y, 3, 2);
      this.tableGrid.Controls.Add(this.b2x2y, 2, 2);
      this.tableGrid.Controls.Add(this.b1x2y, 1, 2);
      this.tableGrid.Controls.Add(this.b0x2y, 0, 2);
      this.tableGrid.Controls.Add(this.b3x1y, 3, 1);
      this.tableGrid.Controls.Add(this.b2x1y, 2, 1);
      this.tableGrid.Controls.Add(this.b1x1y, 1, 1);
      this.tableGrid.Controls.Add(this.b0x1y, 0, 1);
      this.tableGrid.Controls.Add(this.b3x0y, 3, 0);
      this.tableGrid.Controls.Add(this.b2x0y, 2, 0);
      this.tableGrid.Controls.Add(this.b1x0y, 1, 0);
      this.tableGrid.Controls.Add(this.b0x0y, 0, 0);
      this.tableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableGrid.Location = new System.Drawing.Point(0, 24);
      this.tableGrid.Name = "tableGrid";
      this.tableGrid.RowCount = 4;
      this.tableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableGrid.Size = new System.Drawing.Size(322, 297);
      this.tableGrid.TabIndex = 2;
      // 
      // b3x3y
      // 
      this.b3x3y.BackColor = System.Drawing.SystemColors.Control;
      this.b3x3y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b3x3y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b3x3y.Location = new System.Drawing.Point(243, 225);
      this.b3x3y.Name = "b3x3y";
      this.b3x3y.Size = new System.Drawing.Size(76, 69);
      this.b3x3y.TabIndex = 15;
      this.b3x3y.Tag = "3,3";
      this.b3x3y.UseVisualStyleBackColor = false;
      this.b3x3y.Click += new System.EventHandler(this.b3x3y_Click);
      // 
      // b2x3y
      // 
      this.b2x3y.BackColor = System.Drawing.SystemColors.Control;
      this.b2x3y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b2x3y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b2x3y.Location = new System.Drawing.Point(163, 225);
      this.b2x3y.Name = "b2x3y";
      this.b2x3y.Size = new System.Drawing.Size(74, 69);
      this.b2x3y.TabIndex = 14;
      this.b2x3y.Tag = "2,3";
      this.b2x3y.UseVisualStyleBackColor = false;
      this.b2x3y.Click += new System.EventHandler(this.b2x3y_Click);
      // 
      // b1x3y
      // 
      this.b1x3y.BackColor = System.Drawing.SystemColors.Control;
      this.b1x3y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b1x3y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b1x3y.Location = new System.Drawing.Point(83, 225);
      this.b1x3y.Name = "b1x3y";
      this.b1x3y.Size = new System.Drawing.Size(74, 69);
      this.b1x3y.TabIndex = 13;
      this.b1x3y.Tag = "1,3";
      this.b1x3y.UseVisualStyleBackColor = false;
      this.b1x3y.Click += new System.EventHandler(this.b1x3y_Click);
      // 
      // b0x3y
      // 
      this.b0x3y.BackColor = System.Drawing.SystemColors.Control;
      this.b0x3y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b0x3y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b0x3y.Location = new System.Drawing.Point(3, 225);
      this.b0x3y.Name = "b0x3y";
      this.b0x3y.Size = new System.Drawing.Size(74, 69);
      this.b0x3y.TabIndex = 12;
      this.b0x3y.Tag = "0,3";
      this.b0x3y.UseVisualStyleBackColor = false;
      this.b0x3y.Click += new System.EventHandler(this.b0x3y_Click);
      // 
      // b3x2y
      // 
      this.b3x2y.BackColor = System.Drawing.SystemColors.Control;
      this.b3x2y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b3x2y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b3x2y.Location = new System.Drawing.Point(243, 151);
      this.b3x2y.Name = "b3x2y";
      this.b3x2y.Size = new System.Drawing.Size(76, 68);
      this.b3x2y.TabIndex = 11;
      this.b3x2y.Tag = "3,2";
      this.b3x2y.UseVisualStyleBackColor = false;
      this.b3x2y.Click += new System.EventHandler(this.b3x2y_Click);
      // 
      // b2x2y
      // 
      this.b2x2y.BackColor = System.Drawing.SystemColors.Control;
      this.b2x2y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b2x2y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b2x2y.Location = new System.Drawing.Point(163, 151);
      this.b2x2y.Name = "b2x2y";
      this.b2x2y.Size = new System.Drawing.Size(74, 68);
      this.b2x2y.TabIndex = 10;
      this.b2x2y.Tag = "2,2";
      this.b2x2y.UseVisualStyleBackColor = false;
      this.b2x2y.Click += new System.EventHandler(this.b2x2y_Click);
      // 
      // b1x2y
      // 
      this.b1x2y.BackColor = System.Drawing.SystemColors.Control;
      this.b1x2y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b1x2y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b1x2y.Location = new System.Drawing.Point(83, 151);
      this.b1x2y.Name = "b1x2y";
      this.b1x2y.Size = new System.Drawing.Size(74, 68);
      this.b1x2y.TabIndex = 9;
      this.b1x2y.Tag = "1,2";
      this.b1x2y.UseVisualStyleBackColor = false;
      this.b1x2y.Click += new System.EventHandler(this.b1x2y_Click);
      // 
      // b0x2y
      // 
      this.b0x2y.BackColor = System.Drawing.SystemColors.Control;
      this.b0x2y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b0x2y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b0x2y.Location = new System.Drawing.Point(3, 151);
      this.b0x2y.Name = "b0x2y";
      this.b0x2y.Size = new System.Drawing.Size(74, 68);
      this.b0x2y.TabIndex = 8;
      this.b0x2y.Tag = "0,2";
      this.b0x2y.UseVisualStyleBackColor = false;
      this.b0x2y.Click += new System.EventHandler(this.b0x2y_Click);
      // 
      // b3x1y
      // 
      this.b3x1y.BackColor = System.Drawing.SystemColors.Control;
      this.b3x1y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b3x1y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b3x1y.Location = new System.Drawing.Point(243, 77);
      this.b3x1y.Name = "b3x1y";
      this.b3x1y.Size = new System.Drawing.Size(76, 68);
      this.b3x1y.TabIndex = 7;
      this.b3x1y.Tag = "3,1";
      this.b3x1y.UseVisualStyleBackColor = false;
      this.b3x1y.Click += new System.EventHandler(this.b3x1y_Click);
      // 
      // b2x1y
      // 
      this.b2x1y.BackColor = System.Drawing.SystemColors.Control;
      this.b2x1y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b2x1y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b2x1y.Location = new System.Drawing.Point(163, 77);
      this.b2x1y.Name = "b2x1y";
      this.b2x1y.Size = new System.Drawing.Size(74, 68);
      this.b2x1y.TabIndex = 6;
      this.b2x1y.Tag = "2,1";
      this.b2x1y.UseVisualStyleBackColor = false;
      this.b2x1y.Click += new System.EventHandler(this.b2x1y_Click);
      // 
      // b1x1y
      // 
      this.b1x1y.BackColor = System.Drawing.SystemColors.Control;
      this.b1x1y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b1x1y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b1x1y.Location = new System.Drawing.Point(83, 77);
      this.b1x1y.Name = "b1x1y";
      this.b1x1y.Size = new System.Drawing.Size(74, 68);
      this.b1x1y.TabIndex = 5;
      this.b1x1y.Tag = "1,1";
      this.b1x1y.UseVisualStyleBackColor = false;
      this.b1x1y.Click += new System.EventHandler(this.b1x1y_Click);
      // 
      // b0x1y
      // 
      this.b0x1y.BackColor = System.Drawing.SystemColors.Control;
      this.b0x1y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b0x1y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b0x1y.Location = new System.Drawing.Point(3, 77);
      this.b0x1y.Name = "b0x1y";
      this.b0x1y.Size = new System.Drawing.Size(74, 68);
      this.b0x1y.TabIndex = 4;
      this.b0x1y.Tag = "0,1";
      this.b0x1y.UseVisualStyleBackColor = false;
      this.b0x1y.Click += new System.EventHandler(this.b0x1y_Click);
      // 
      // b3x0y
      // 
      this.b3x0y.BackColor = System.Drawing.SystemColors.Control;
      this.b3x0y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b3x0y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b3x0y.Location = new System.Drawing.Point(243, 3);
      this.b3x0y.Name = "b3x0y";
      this.b3x0y.Size = new System.Drawing.Size(76, 68);
      this.b3x0y.TabIndex = 3;
      this.b3x0y.Tag = "3,0";
      this.b3x0y.UseVisualStyleBackColor = false;
      this.b3x0y.Click += new System.EventHandler(this.b3x0y_Click);
      // 
      // b2x0y
      // 
      this.b2x0y.BackColor = System.Drawing.SystemColors.Control;
      this.b2x0y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b2x0y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b2x0y.Location = new System.Drawing.Point(163, 3);
      this.b2x0y.Name = "b2x0y";
      this.b2x0y.Size = new System.Drawing.Size(74, 68);
      this.b2x0y.TabIndex = 2;
      this.b2x0y.Tag = "2,0";
      this.b2x0y.UseVisualStyleBackColor = false;
      this.b2x0y.Click += new System.EventHandler(this.b2x0y_Click);
      // 
      // b1x0y
      // 
      this.b1x0y.BackColor = System.Drawing.SystemColors.Control;
      this.b1x0y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b1x0y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b1x0y.Location = new System.Drawing.Point(83, 3);
      this.b1x0y.Name = "b1x0y";
      this.b1x0y.Size = new System.Drawing.Size(74, 68);
      this.b1x0y.TabIndex = 1;
      this.b1x0y.Tag = "1,0";
      this.b1x0y.UseVisualStyleBackColor = false;
      this.b1x0y.Click += new System.EventHandler(this.b1x0y_Click);
      // 
      // b0x0y
      // 
      this.b0x0y.BackColor = System.Drawing.SystemColors.Control;
      this.b0x0y.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b0x0y.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.b0x0y.Location = new System.Drawing.Point(3, 3);
      this.b0x0y.Name = "b0x0y";
      this.b0x0y.Size = new System.Drawing.Size(74, 68);
      this.b0x0y.TabIndex = 0;
      this.b0x0y.Tag = "0,0";
      this.b0x0y.UseVisualStyleBackColor = false;
      this.b0x0y.Click += new System.EventHandler(this.b0x0y_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(-5, -5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(1, 1);
      this.button1.TabIndex = 3;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // formMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(322, 343);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.tableGrid);
      this.Controls.Add(this.stripStatus);
      this.Controls.Add(this.stripMenu);
      this.KeyPreview = true;
      this.MainMenuStrip = this.stripMenu;
      this.Name = "formMain";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "15.NET";
      this.Load += new System.EventHandler(this.formMain_Load);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formMain_KeyPress);
      this.stripMenu.ResumeLayout(false);
      this.stripMenu.PerformLayout();
      this.stripStatus.ResumeLayout(false);
      this.stripStatus.PerformLayout();
      this.tableGrid.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip stripMenu;
    private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem specificToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem solveToolStripMenuItem;
    private System.Windows.Forms.StatusStrip stripStatus;
    private System.Windows.Forms.TableLayoutPanel tableGrid;
    private System.Windows.Forms.Button b0x0y;
    private System.Windows.Forms.Button b2x3y;
    private System.Windows.Forms.Button b1x3y;
    private System.Windows.Forms.Button b0x3y;
    private System.Windows.Forms.Button b3x2y;
    private System.Windows.Forms.Button b2x2y;
    private System.Windows.Forms.Button b1x2y;
    private System.Windows.Forms.Button b0x2y;
    private System.Windows.Forms.Button b3x1y;
    private System.Windows.Forms.Button b2x1y;
    private System.Windows.Forms.Button b1x1y;
    private System.Windows.Forms.Button b0x1y;
    private System.Windows.Forms.Button b3x0y;
    private System.Windows.Forms.Button b2x0y;
    private System.Windows.Forms.Button b1x0y;
    private System.Windows.Forms.ToolStripStatusLabel labelMoves;
    private System.Windows.Forms.ToolStripStatusLabel labelSolvable;
    private System.Windows.Forms.Button b3x3y;
    private System.Windows.Forms.ToolStripMenuItem bruteSolveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem logicallySolveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel labelEmptycell;
    private System.Windows.Forms.ToolStripProgressBar pbarShuffle;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
  }
}

