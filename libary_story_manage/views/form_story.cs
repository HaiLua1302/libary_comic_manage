using libary_story_manage.controller;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace libary_story_manage
{
    public partial class form_story_manage : Form
    {
        private DBConnect dBConnect;
        public form_story_manage()
        {
            InitializeComponent();
            try
            {
                dBConnect = new DBConnect();
                MessageBox.Show("0k");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
