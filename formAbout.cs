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
  public partial class formAbout : Form {
    public formAbout() {
      InitializeComponent();
      string vers = Resources.appVersion.Trim();
      if(vers != string.Empty)
        vers = " " + vers;
      Text = "15.NET (v " + Application.ProductVersion + "" + vers + ")";
      labelAbout.Text = "15.NET" +
        "\nv " + Application.ProductVersion + vers +
        "\n\nCopyright © 2010 Oliver Davenport" +
        "\nMarshmallowZombies.co.uk" +
        "\nAll rights reserved"+
        "\n\nThis application is subject to update, and"+
        "\nlater versions may require a more recent"+
        "\n.NET redistributible framework.";
    }
  }
}