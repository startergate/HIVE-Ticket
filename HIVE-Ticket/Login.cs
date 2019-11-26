using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIVE_Ticket
{
  public partial class Login : Form
  {
    public Login()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      
      var tickets = new Tickets {Location = this.Location, StartPosition = this.StartPosition};
      
      tickets.Show();
      this.Hide();
    }
  }
}