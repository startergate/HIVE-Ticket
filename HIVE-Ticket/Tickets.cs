using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HIVE_Ticket
{
  public partial class Tickets : Form
  {
    public Tickets()
    {
      InitializeComponent();
    }

    private MySqlConnection conn;
    private MySqlDataAdapter adapter;
    private DataSet dataSet;

    private void Tickets_Load(object sender, EventArgs e)
    {
      string connStr = "server=db.donote.co;port=3306;database=hive_ticket;uid=hive;pwd=1111";
      conn = new MySqlConnection(connStr);
      adapter = new MySqlDataAdapter();
      dataSet = new DataSet(); 

      try
      {
        conn.Open();
        if (conn.State == ConnectionState.Open)
        {
          var sql = "SELECT * FROM ticket_with_user";

          adapter.SelectCommand = new MySqlCommand(sql, conn);
          if (adapter.Fill(dataSet) > 0)
          {
            dataGridView1.DataSource = dataSet.Tables["Table"];
          }
          else
          {
            MessageBox.Show("검색된 데이터가 없습니다.");
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var sql = "SELECT * FROM ticket_with_user";

      List<string> conditions = new List<string>();
      if (!String.IsNullOrWhiteSpace(customer_name.Text))
      {
        conditions.Add("name=\"" + customer_name.Text + "\"");
      }

      if (!String.IsNullOrWhiteSpace(movie_name.Text))
      {
        conditions.Add("title=\"" + movie_name.Text + "\"");
      }

      if (!String.IsNullOrWhiteSpace(movie_time.Text))
      {
        conditions.Add("available_at=\"" + movie_time.Text + "\"");
      }

      var condition = (conditions.ToArray().Length > 0 ? " WHERE " : "") + String.Join(" AND ", conditions.ToArray());

      adapter.SelectCommand = new MySqlCommand(sql + condition, conn);
      if (adapter.Fill(dataSet) > 0)
      {
        dataGridView1.DataSource = dataSet.Tables["Table"].DefaultView.ToTable(true);
      }
      else
      {
        MessageBox.Show("검색된 데이터가 없습니다.");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      NewTicketDialog newTicketDialog = new NewTicketDialog();
      newTicketDialog.ShowDialog();
    }
  }
}