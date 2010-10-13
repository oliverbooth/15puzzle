using _15puzzle.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _15puzzle {
  public partial class formSpecificgame : Form {
    public formSpecificgame() {
      InitializeComponent();
      Randomize();
    }

    public int[] Grid {
      get {
        return new int[]{
          Convert.ToInt32(c1.Text  == string.Empty ? (0).ToString() : c1.Text ),
          Convert.ToInt32(c2.Text  == string.Empty ? (0).ToString() : c2.Text ),
          Convert.ToInt32(c3.Text  == string.Empty ? (0).ToString() : c3.Text ),
          Convert.ToInt32(c4.Text  == string.Empty ? (0).ToString() : c4.Text ),
          Convert.ToInt32(c5.Text  == string.Empty ? (0).ToString() : c5.Text ),
          Convert.ToInt32(c6.Text  == string.Empty ? (0).ToString() : c6.Text ),
          Convert.ToInt32(c7.Text  == string.Empty ? (0).ToString() : c7.Text ),
          Convert.ToInt32(c8.Text  == string.Empty ? (0).ToString() : c8.Text ),
          Convert.ToInt32(c9.Text  == string.Empty ? (0).ToString() : c9.Text ),
          Convert.ToInt32(c10.Text == string.Empty ? (0).ToString() : c10.Text),
          Convert.ToInt32(c11.Text == string.Empty ? (0).ToString() : c11.Text),
          Convert.ToInt32(c12.Text == string.Empty ? (0).ToString() : c12.Text),
          Convert.ToInt32(c13.Text == string.Empty ? (0).ToString() : c13.Text),
          Convert.ToInt32(c14.Text == string.Empty ? (0).ToString() : c14.Text),
          Convert.ToInt32(c15.Text == string.Empty ? (0).ToString() : c15.Text),
          Convert.ToInt32(c16.Text == string.Empty ? (0).ToString() : c16.Text),
        };
      }
      set {
        c1.Text  = (value[1]  == 0 ? "" : value[1].ToString() );
        c2.Text  = (value[2]  == 0 ? "" : value[2].ToString() );
        c3.Text  = (value[3]  == 0 ? "" : value[3].ToString() );
        c4.Text  = (value[4]  == 0 ? "" : value[4].ToString() );
        c5.Text  = (value[5]  == 0 ? "" : value[5].ToString() );
        c6.Text  = (value[6]  == 0 ? "" : value[6].ToString() );
        c7.Text  = (value[7]  == 0 ? "" : value[7].ToString() );
        c8.Text  = (value[8]  == 0 ? "" : value[8].ToString() );
        c9.Text  = (value[9]  == 0 ? "" : value[9].ToString() );
        c10.Text = (value[10] == 0 ? "" : value[10].ToString());
        c11.Text = (value[11] == 0 ? "" : value[11].ToString());
        c12.Text = (value[12] == 0 ? "" : value[12].ToString());
        c13.Text = (value[13] == 0 ? "" : value[13].ToString());
        c14.Text = (value[14] == 0 ? "" : value[14].ToString());
        c15.Text = (value[15] == 0 ? "" : value[15].ToString());
        c16.Text = (value[16] == 0 ? "" : value[16].ToString());
      }
    }

    private void buttonRandomize_Click(object sender, EventArgs e) {
      Randomize();
    }

    private void Randomize() {
      List<int> nums = new List<int>();
      for(int i = 0 ; i < 16 ; i++) {
        nums.Add(i);
      }

      Random rnd = new Random();
      foreach(Control ctl in this.Controls) {
        if(ctl is TextBox) {
          int x = rnd.Next(0, nums.Count);
          ctl.Text = (nums[x] == 0 ? "" : nums[x].ToString());
          nums.Remove(nums[x]);
          Application.DoEvents();
        }
      }
    }

    private string listItems(List<int> val) {
      string s = "";

      foreach(int v in val) {
        s += v + ", ";
      }

      s = s.Substring(0, s.Length - 2);
      return s;
    }
  }
}