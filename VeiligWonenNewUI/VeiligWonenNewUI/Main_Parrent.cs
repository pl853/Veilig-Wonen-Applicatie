using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace VeiligWonenNewUI
{
    public partial class Main_Ui : Form
    {
        MySqlConnection con = new MySqlConnection("server = sql11.freemysqlhosting.net; database=sql11169883; user=sql11169883; password=sbCqYkpscM");

        MySqlDataAdapter sda;

        DataTable dt;

        GMarkerGoogle marker;

        GMapOverlay markerOverlay;

        List<string> huizen = new List<string>();

        Addhuis_UI Addhuis = new Addhuis_UI();

        addData AddData = new addData();


        public Main_Ui(string Role, string UserName)
        {
            InitializeComponent();

            //filling labels

            Name_Label.Text = UserName;
            Role_label.Text = Role;
        }

        private void VeiligWonen_Load(object sender, EventArgs e)
        {
            OnAppLoad();

        }

        void OnAppLoad()
        {
            // fill chart

            Inbraak_Chart.Series["Perc"].Points.AddXY("2013", 12);
            Inbraak_Chart.Series["Perc"].Points.AddXY("2014", 12.1);
            Inbraak_Chart.Series["Perc"].Points.AddXY("2015", 11.1);
            Inbraak_Chart.Series["Perc"].Points.AddXY("2016", 13.5);

            gewelds_chart.Series["Perc"].Points.AddXY("2013", 4);
            gewelds_chart.Series["Perc"].Points.AddXY("2014", 3.5);
            gewelds_chart.Series["Perc"].Points.AddXY("2015", 4.6);
            gewelds_chart.Series["Perc"].Points.AddXY("2016", 5.5);

            vandilsme_chart.Series["Perc"].Points.AddXY("2013", 14.9);
            vandilsme_chart.Series["Perc"].Points.AddXY("2014", 18.7);
            vandilsme_chart.Series["Perc"].Points.AddXY("2015", 17);
            vandilsme_chart.Series["Perc"].Points.AddXY("2016", 13.9);

            //fill Circles

            Woning_circle.Value = 14;
            Auto_circle.Value = 4;
            Gewelds_circle.Value = 6;
            Bedreiging_circle.Value = 6;
            Vernieling_circle.Value = 7;
            Bekladding_circle.Value = 14;
            

            // what check who logged and what to display
            if (Role_label.Text != "Admin")
            {
                ManageData_MenuItem.Visible = false;
                Managehuizen_MenuItem.Visible = false;
            }
            // load google maps att
            ShowMarkers("select * from huis ", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` ");
            GoogleMapsControl.DragButton = MouseButtons.Left;
            GoogleMapsControl.CanDragMap = true;
            GoogleMapsControl.MapProvider = GMapProviders.GoogleMap;
            GoogleMapsControl.Position = new PointLatLng(51.906582, 4.492979);
            GoogleMapsControl.MinZoom = 11;
            GoogleMapsControl.MaxZoom = 24;
            GoogleMapsControl.Zoom = 12;
        }

        void CreateMarker(string name, double Latitude, double Longditute, string Huisnummer, string Prijs, string KoopHuur)
        {
            markerOverlay = new GMapOverlay("marker");
            marker = new GMarkerGoogle(new PointLatLng(Latitude, Longditute), GMarkerGoogleType.blue_pushpin);
            markerOverlay.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("\n" + name + " {0}\n{1} \nPrijs: €{2},-", Huisnummer, KoopHuur, Prijs);
            GoogleMapsControl.Overlays.Add(markerOverlay);
        }

        void ShowMarkers(string queryFill, string queryShow)
        {
            DataTable tap = new DataTable();
            new MySqlDataAdapter(queryFill, con).Fill(tap);
            huizen = tap.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Wijk")).ToList();

            foreach (var huis in huizen)
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(queryShow, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow i in dt.Rows)
                {
                    string MyDoubleLong = i[1].ToString();
                    double Long = double.Parse(MyDoubleLong);
                    string MyDoubleLat = i[2].ToString();
                    double Lat = double.Parse(MyDoubleLat);
                    CreateMarker(i[0].ToString(), Long, Lat, i[3].ToString(), i[4].ToString(), i[5].ToString());
                }
            }
        }

        public void fillcombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            sda.Fill(dt);
            combo.DataSource = dt;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;

        }

        private void StadsGebied_Dropdown_MouseDown(object sender, MouseEventArgs e)
        {
            string query = "SELECT stadsgebied.GID , stadsgebied.Naam from stadsgebied";
            fillcombo(StadsGebied_Dropdown, query, "Naam", "GID");
            StadsGebied_Dropdown_SelectedIndexChanged(null, null);
        }

        private void StadsGebied_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(StadsGebied_Dropdown.SelectedValue.ToString(), out val);
            string query = "SELECT WID , Naam,GID from wijk WHERE GID = " + val;
            fillcombo(Wijk_dropdown, query, "Naam", "WID");
        }

        private void Managehuizen_MenuItem_Click(object sender, EventArgs e)
        {
            Addhuis.Show();
            Addhuis.MdiParent = this;
            Addhuis.Dock = DockStyle.Fill;
            panel2.Hide();
            AddData.Hide();
        }

        private void ZoekHuis_MenuItem_Click(object sender, EventArgs e)
        {
            Addhuis.Hide();
            panel2.Show();
            AddData.Hide();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void setMapPosition(string query)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string MyDoubleLong = dt.Rows[0][1].ToString();
            double Long = double.Parse(MyDoubleLong);
            string MyDoubleLat = dt.Rows[0][0].ToString();
            double Lat = double.Parse(MyDoubleLat);
            GoogleMapsControl.Position = new PointLatLng(Lat, Long);
            GoogleMapsControl.Zoom = 14.85;

        }

        public void FillPercentages()
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(@"select subcategoriecriminaliteit.Per2016 from subcategoriecriminaliteit join wijk on  subcategoriecriminaliteit.WID = wijk.WID where wijk.Naam = '" + Wijk_dropdown.Text + "'and subcategoriecriminaliteit.Naam = 'Woninginbraak' ", con);
            MySqlDataAdapter sda1 = new MySqlDataAdapter(@"select subcategoriecriminaliteit.Per2016 from subcategoriecriminaliteit join wijk on  subcategoriecriminaliteit.WID = wijk.WID where wijk.Naam = '" + Wijk_dropdown.Text + "'and subcategoriecriminaliteit.Naam = 'Auto-inbraak' ", con);
            MySqlDataAdapter sda2 = new MySqlDataAdapter(@"select subcategoriecriminaliteit.Per2016 from subcategoriecriminaliteit join wijk on  subcategoriecriminaliteit.WID = wijk.WID where wijk.Naam = '" + Wijk_dropdown.Text + "'and subcategoriecriminaliteit.Naam = 'Geweldsdelicten' ", con);
            MySqlDataAdapter sda3 = new MySqlDataAdapter(@"select subcategoriecriminaliteit.Per2016 from subcategoriecriminaliteit join wijk on  subcategoriecriminaliteit.WID = wijk.WID where wijk.Naam = '" + Wijk_dropdown.Text + "'and subcategoriecriminaliteit.Naam = 'Bedreiging' ", con);
            MySqlDataAdapter sda4 = new MySqlDataAdapter(@"select subcategoriecriminaliteit.Per2016 from subcategoriecriminaliteit join wijk on  subcategoriecriminaliteit.WID = wijk.WID where wijk.Naam = '" + Wijk_dropdown.Text + "'and subcategoriecriminaliteit.Naam = 'Vernieling' ", con);
            MySqlDataAdapter sda5 = new MySqlDataAdapter(@"select subcategoriecriminaliteit.Per2016 from subcategoriecriminaliteit join wijk on  subcategoriecriminaliteit.WID = wijk.WID where wijk.Naam = '" + Wijk_dropdown.Text + "'and subcategoriecriminaliteit.Naam = 'Bekladding' ", con);
            DataTable dt = new DataTable(); DataTable dt1 = new DataTable(); DataTable dt2 = new DataTable(); DataTable dt3 = new DataTable(); DataTable dt4 = new DataTable();DataTable dt5 = new DataTable();
            sda.Fill(dt); sda1.Fill(dt1); sda2.Fill(dt2); sda3.Fill(dt3); sda4.Fill(dt4); sda5.Fill(dt5);

            if (dt.Rows.Count >= 1)
            {
                string woninginbraak_percstr = dt.Rows[0][0].ToString();
                float woninginbraak_percfloat = float.Parse(woninginbraak_percstr);
                int woninginbraak_percint = Convert.ToInt32(woninginbraak_percfloat);
                string Autoinbraak_percstr = dt1.Rows[0][0].ToString();
                float Autoinbraak_percfloat = float.Parse(Autoinbraak_percstr);
                int Autoinbraak_percint = Convert.ToInt32(Autoinbraak_percfloat);
                string Geweldsdel_percstr = dt2.Rows[0][0].ToString();
                float Geweldsdel_perfloat = float.Parse(Geweldsdel_percstr);
                int Geweldsdel_perint = Convert.ToInt32(Geweldsdel_perfloat);
                string Bedreiging_perstr = dt3.Rows[0][0].ToString();
                float Bedreiging_perfloat = float.Parse(Bedreiging_perstr);
                int Bedreiging_perint = Convert.ToInt32(Bedreiging_perfloat);
                string Vernieling_perstr = dt4.Rows[0][0].ToString();
               float Vernieling_perfloat = float.Parse(Vernieling_perstr);
                int Vernieling_perint = Convert.ToInt32(Vernieling_perfloat);
                string Bekladding_perstr = dt5.Rows[0][0].ToString();
                float Bekladding_perfloat = float.Parse(Bekladding_perstr);
                int Bekladding_perint = Convert.ToInt32(Bekladding_perfloat);

                Woning_circle.Value = woninginbraak_percint;
                Auto_circle.Value = Autoinbraak_percint;
                Gewelds_circle.Value = Geweldsdel_perint;
                Bedreiging_circle.Value = Bedreiging_perint;
                Vernieling_circle.Value = Vernieling_perint;
                Bekladding_circle.Value = Bekladding_perint;
            }
        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {

            RemoveGraphData();
            FillPercentages(); 
            FillChart();

            if (StadsGebied_Dropdown.Text == "")
            {
                MessageBox.Show("Selecteer een Stadsgebied");
            }
            else
            {
                if (Straat_TextBox.Text != "")
                {

                    if (KoopHuur_DropDown.Text != "")
                    {
                        ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "' and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'");
                        
                        if (PrijsTot_Textbox.Text != "")
                        {
                            GoogleMapsControl.Overlays.Clear();
                            ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'and Prijs < '" + PrijsTot_Textbox.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "' and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'");
                        }

                        else
                        {
                            GoogleMapsControl.Overlays.Clear();
                            ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "' and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'");
                        }
                    }
                    else
                    {
                        GoogleMapsControl.Overlays.Clear();
                        ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'and Straat = '" + Straat_TextBox.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "' and Straat = '" + Straat_TextBox.Text + "'");
                    }
                }
                else if (KoopHuur_DropDown.Text != "")
                {
                    GoogleMapsControl.Overlays.Clear();
                    ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "' and KoopHuur = '" + KoopHuur_DropDown.Text + "'");

                }
                else
                {
                    GoogleMapsControl.Overlays.Clear();
                    ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'");

                }
                setMapPosition("SELECT wijk.Lat,wijk.Long From sql11169883.wijk where wijk.Naam = '" + Wijk_dropdown.Text + "'");
                KoopHuur_DropDown.SelectedIndex = -1;
            }
        }



        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_UI LoginUI = new Login_UI();
            LoginUI.Show();
        }

        private void ManageData_MenuItem_Click(object sender, EventArgs e)
        {
            AddData.Show();
            AddData.MdiParent = this;
            AddData.Dock = DockStyle.Fill;
            panel2.Hide();
        }

        void FillChart()
        {
            sda = new MySqlDataAdapter("select per2013,per2014,per2015,per2016 from subcategoriecriminaliteit join wijk on  subcategoriecriminaliteit.WID = wijk.WID where wijk.Naam = '" + Wijk_dropdown.Text + "'and subcategoriecriminaliteit.Naam = 'Woninginbraak'",con);
            dt = new DataTable();
            sda.Fill(dt);
            MySqlDataAdapter sda1 = new MySqlDataAdapter("select per2013,per2014,per2015,per2016 from subcategoriecriminaliteit join wijk on  subcategoriecriminaliteit.WID = wijk.WID where wijk.Naam = '" + Wijk_dropdown.Text + "'and subcategoriecriminaliteit.Naam = 'Vandalisme'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            MySqlDataAdapter sda2 = new MySqlDataAdapter("select per2013,per2014,per2015,per2016 from subcategoriecriminaliteit join wijk on  subcategoriecriminaliteit.WID = wijk.WID where wijk.Naam = '" + Wijk_dropdown.Text + "'and subcategoriecriminaliteit.Naam = 'Geweld'", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            if (dt.Rows.Count >= 1)
            {
                Inbraak_Chart.Series["Perc"].Points.AddXY("2013", dt.Rows[0][0].ToString());
                Inbraak_Chart.Series["Perc"].Points.AddXY("2014", dt.Rows[0][1].ToString());
                Inbraak_Chart.Series["Perc"].Points.AddXY("2015", dt.Rows[0][2].ToString());
                Inbraak_Chart.Series["Perc"].Points.AddXY("2016", dt.Rows[0][3].ToString());

                gewelds_chart.Series["Perc"].Points.AddXY("2013", dt.Rows[0][0].ToString());
                gewelds_chart.Series["Perc"].Points.AddXY("2014", dt.Rows[0][1].ToString());
                gewelds_chart.Series["Perc"].Points.AddXY("2015", dt.Rows[0][2].ToString());
                gewelds_chart.Series["Perc"].Points.AddXY("2016", dt.Rows[0][3].ToString());

                vandilsme_chart.Series["Perc"].Points.AddXY("2013", dt.Rows[0][0].ToString());
                vandilsme_chart.Series["Perc"].Points.AddXY("2014", dt.Rows[0][1].ToString());
                vandilsme_chart.Series["Perc"].Points.AddXY("2015", dt.Rows[0][2].ToString());
                vandilsme_chart.Series["Perc"].Points.AddXY("2016", dt.Rows[0][3].ToString());
            }
            else
            {
                MessageBox.Show("Sorry er is momenteel geen data beschikbaar");
            }

        }

        private void Show_allbutton_Click(object sender, EventArgs e)
        {

            ShowMarkers("select * from huis ", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` ");
            RemoveGraphData();

            Inbraak_Chart.Series["Perc"].Points.AddXY("2013", 12);
            Inbraak_Chart.Series["Perc"].Points.AddXY("2014", 12.1);
            Inbraak_Chart.Series["Perc"].Points.AddXY("2015", 11.1);
            Inbraak_Chart.Series["Perc"].Points.AddXY("2016", 13.5);

            gewelds_chart.Series["Perc"].Points.AddXY("2013", 4);
            gewelds_chart.Series["Perc"].Points.AddXY("2014", 3.5);
            gewelds_chart.Series["Perc"].Points.AddXY("2015", 4.6);
            gewelds_chart.Series["Perc"].Points.AddXY("2016", 5.5);

            vandilsme_chart.Series["Perc"].Points.AddXY("2013", 14.9);
            vandilsme_chart.Series["Perc"].Points.AddXY("2014", 18.7);
            vandilsme_chart.Series["Perc"].Points.AddXY("2015", 17);
            vandilsme_chart.Series["Perc"].Points.AddXY("2016", 13.9);



            //fill Circles

            Woning_circle.Value = 14;
            Auto_circle.Value = 4;
            Gewelds_circle.Value = 6;
            Bedreiging_circle.Value = 6;
            Vernieling_circle.Value = 7;
            Bekladding_circle.Value = 14;

            GoogleMapsControl.Position = new PointLatLng(51.906582, 4.492979);
            GoogleMapsControl.Zoom = 12;

        }

        void RemoveGraphData()
        {
            Inbraak_Chart.Series["Perc"].Points.Clear();
            gewelds_chart.Series["Perc"].Points.Clear();
            vandilsme_chart.Series["Perc"].Points.Clear();

        }
    }
}
