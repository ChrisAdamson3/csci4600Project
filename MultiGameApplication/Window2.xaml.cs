using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MultiGameApplication
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            
        }

        private void Openwindow(object sender, RoutedEventArgs e)
        {
            MainWindow window2 = new MainWindow();
            this.Visibility= Visibility.Hidden;
            window2.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To win in this get four of your peices in a row");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow window2 = new MainWindow();
            this.Visibility= Visibility.Hidden;
            window2.Show();
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String value = "RED";


            if (Player.Content.Equals("Player One Turn"))
            {
                Player.Content="Player Two Turn";
                value="RED";
            }
            else { 
                Player.Content="Player One Turn";
                value="Yellow";
            }

            if (Label61.Content!="")
            {
                Player.Content="Invalid MOVE";
            }
            
            if (Label51.Content!=""&Label61.Content=="")
            {
                Label61.Content=value;
            }
            if (Label41.Content!=""&Label51.Content=="")
            {
                Label51.Content=value;
            }
            if (Label31.Content!=""&Label41.Content=="")
            {
                Label41.Content=value;
            }
            if (Label21.Content!=""&Label31.Content=="")
            {
                Label31.Content=value;
            }
            if (Label11.Content!=""&Label21.Content=="")
            {
                Label21.Content=value;
            }
            
            
            if (Label11.Content=="")
            {
                Label11.Content=value;
                
            }
            if (Winner()==true & Player.Content.Equals("Player One Turn"))
            {
                Winners.Content="Player Two Wins";
                Clear();

            }
            else if (Winner()==true & Player.Content.Equals("Player Two Turn"))
            {
                Winners.Content="Player One Wins";
               
                Clear();

            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           
                String value = "RED";


                if (Player.Content.Equals("Player One Turn"))
                {
                    Player.Content="Player Two Turn";
                    value="RED";
                
                }
                else
                {
                    Player.Content="Player One Turn";
                    value="Yellow";
                }

                if (Label62.Content!="")
                {
                    Player.Content="Invalid MOVE";
                }

                if (Label52.Content!=""&Label62.Content=="")
                {
                    Label62.Content=value;
                }
                if (Label42.Content!=""&Label52.Content=="")
                {
                    Label52.Content=value;
                }
                if (Label32.Content!=""&Label42.Content=="")
                {
                    Label42.Content=value;
                }
                if (Label22.Content!=""&Label32.Content=="")
                {
                    Label32.Content=value;
                }
                if (Label12.Content!=""&Label22.Content=="")
                {
                    Label22.Content=value;
                }


                if (Label12.Content=="")
                {
                    Label12.Content=value;
                }
            if (Winner()==true & Player.Content.Equals("Player One Turn"))
            {
                Winners.Content="Player Two Wins";
                Clear();

            }
            else if (Winner()==true & Player.Content.Equals("Player Two Turn"))
            {
                Winners.Content="Player One Wins";
                Clear();

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
          
                String value = "RED";


                if (Player.Content.Equals("Player One Turn"))
                {
                    Player.Content="Player Two Turn";
                    value="RED";
                }
                else
                {
                    Player.Content="Player One Turn";
                    value="Yellow";
                }

                if (Label63.Content!="")
                {
                    Player.Content="Invalid MOVE";
                }

                if (Label53.Content!=""&Label63.Content=="")
                {
                    Label63.Content=value;
                }
                if (Label43.Content!=""&Label53.Content=="")
                {
                    Label53.Content=value;
                }
                if (Label33.Content!=""&Label43.Content=="")
                {
                    Label43.Content=value;
                }
                if (Label23.Content!=""&Label33.Content=="")
                {
                    Label33.Content=value;
                }
                if (Label13.Content!=""&Label23.Content=="")
                {
                    Label23.Content=value;
                }


                if (Label13.Content=="")
                {
                    Label13.Content=value;
                }
            if (Winner()==true & Player.Content.Equals("Player One Turn"))
            {
                Winners.Content="Player Two Wins";
                Clear();

            }
            else if (Winner()==true & Player.Content.Equals("Player Two Turn"))
            {
                Winners.Content="Player One Wins";
                Clear();

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            String value = "RED";
            

                if (Player.Content.Equals("Player One Turn"))
                {
                    Player.Content="Player Two Turn";
                    value="RED";
                }
                else
                {
                    Player.Content="Player One Turn";
                    value="Yellow";
                }

                if (Label64.Content!="")
                {
                    Player.Content="Invalid MOVE";
                }

                if (Label54.Content!=""&Label64.Content=="")
                {
                    Label64.Content=value;
                }
                if (Label44.Content!=""&Label54.Content=="")
                {
                    Label54.Content=value;
                }
                if (Label34.Content!=""&Label44.Content=="")
                {
                    Label44.Content=value;
                }
                if (Label24.Content!=""&Label34.Content=="")
                {
                    Label34.Content=value;
                }
                if (Label14.Content!=""&Label24.Content=="")
                {
                    Label24.Content=value;
                }


                if (Label14.Content=="")
                {
                    Label14.Content=value;
                }
            if (Winner()==true & Player.Content.Equals("Player One Turn"))
            {
                Winners.Content="Player Two Wins";
                Clear();

            }
            else if(Winner()==true & Player.Content.Equals("Player Two Turn"))
            {
                Winners.Content="Player One Wins";
                Clear();

            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            String value = "RED";


                if (Player.Content.Equals("Player One Turn"))
                {
                    Player.Content="Player Two Turn";
                    value="RED";
                }
                else
                {
                    Player.Content="Player One Turn";
                    value="Yellow";
                }

                if (Label65.Content!="")
                {
                    Player.Content="Invalid MOVE";
                }

                if (Label55.Content!=""&Label65.Content=="")
                {
                    Label65.Content=value;
                }
                if (Label45.Content!=""&Label55.Content=="")
                {
                    Label55.Content=value;
                }
                if (Label35.Content!=""&Label45.Content=="")
                {
                    Label45.Content=value;
                }
                if (Label25.Content!=""&Label35.Content=="")
                {
                    Label35.Content=value;
                }
                if (Label15.Content!=""&Label25.Content=="")
                {
                    Label25.Content=value;
                }


                if (Label15.Content=="")
                {
                    Label15.Content=value;
                }
            if (Winner()==true & Player.Content.Equals("Player One Turn"))
            {
                Winners.Content="Player Two Wins";
                Clear();

            }
            else if (Winner()==true & Player.Content.Equals("Player Two Turn"))
            {
                Winners.Content="Player One Wins";
                Clear();

            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
           
                String value = "RED";


                if (Player.Content.Equals("Player One Turn"))
                {
                    Player.Content="Player Two Turn";
                    value="RED";
                }
                else
                {
                    Player.Content="Player One Turn";
                    value="Yellow";
                }

                if (Label66.Content!="")
                {
                    Player.Content="Invalid MOVE";
                }

                if (Label56.Content!=""&Label66.Content=="")
                {
                    Label66.Content=value;
                }
                if (Label46.Content!=""&Label56.Content=="")
                {
                    Label56.Content=value;
                }
                if (Label36.Content!=""&Label46.Content=="")
                {
                    Label46.Content=value;
                }
                if (Label26.Content!=""&Label36.Content=="")
                {
                    Label36.Content=value;
                }
                if (Label16.Content!=""&Label26.Content=="")
                {
                    Label26.Content=value;
                }


                if (Label16.Content=="")
                {
                    Label16.Content=value;
                }
            if (Winner()==true & Player.Content.Equals("Player One Turn"))
            {
                Winners.Content="Player Two Wins";
                Clear();

            }
            else if (Winner()==true & Player.Content.Equals("Player Two Turn"))
            {
                Winners.Content="Player One Wins";
                Clear();

            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
             String value = "RED";


                if (Player.Content.Equals("Player One Turn"))
                {
                    Player.Content="Player Two Turn";
                    value="RED";
                }
                else
                {
                    Player.Content="Player One Turn";
                    value="Yellow";
                }

                if (Label67.Content!="")
                {
                    Player.Content="Invalid MOVE";
                }

                if (Label57.Content!=""&Label67.Content=="")
                {
                    Label67.Content=value;
                }
                if (Label47.Content!=""&Label57.Content=="")
                {
                    Label57.Content=value;
                }
                if (Label37.Content!=""&Label47.Content=="")
                {
                    Label47.Content=value;
                }
                if (Label27.Content!=""&Label37.Content=="")
                {
                    Label37.Content=value;
                }
                if (Label17.Content!=""&Label27.Content=="")
                {
                    Label27.Content=value;
                }


                if (Label17.Content=="")
                {
                    Label17.Content=value;
                    
                }
            if (Winner()==true & Player.Content.Equals("Player One Turn"))
            {
                Winners.Content="Player Two Wins";
                Clear();
            }
            else if (Winner()==true & Player.Content.Equals("Player Two Turn"))
            {
                Winners.Content="Player One Wins";
                Clear();

            }
        }

        
        public bool Winner()
        {
            if (Label11.Content!="" & Label11.Content==Label12.Content & Label11.Content==Label13.Content & Label11.Content==Label14.Content)
            {
                return true;
            }else if (Label12.Content!="" & Label12.Content==Label13.Content & Label12.Content==Label14.Content & Label12.Content==Label15.Content)
            {
                return true;
            }else if (Label13.Content!="" & Label13.Content==Label14.Content & Label13.Content==Label15.Content & Label13.Content==Label16.Content)
            {
                return true;
            }else if (Label14.Content!="" & Label14.Content==Label15.Content & Label14.Content==Label16.Content & Label14.Content==Label17.Content)
            {
                return true;
            }
            else if (Label21.Content!="" & Label21.Content==Label22.Content & Label21.Content==Label23.Content & Label21.Content==Label24.Content)
            {
                return true;
            }
            else if (Label22.Content!="" & Label22.Content==Label23.Content & Label22.Content==Label24.Content & Label22.Content==Label25.Content)
            {
                return true;
            }
            else if (Label23.Content!="" & Label23.Content==Label24.Content & Label23.Content==Label25.Content & Label23.Content==Label26.Content)
            {
                return true;
            }
            else if (Label24.Content!="" & Label24.Content==Label25.Content & Label24.Content==Label26.Content & Label24.Content==Label27.Content)
            {
                return true;
            }
            else if (Label31.Content!="" & Label31.Content==Label32.Content & Label31.Content==Label33.Content & Label31.Content==Label34.Content)
            {
                return true;
            }
            else if (Label32.Content!="" & Label32.Content==Label33.Content & Label32.Content==Label34.Content & Label32.Content==Label35.Content)
            {
                return true;
            }
            else if (Label33.Content!="" & Label33.Content==Label15.Content & Label14.Content==Label16.Content & Label14.Content==Label17.Content)
            {
                return true;
            }
            else if (Label34.Content!="" & Label34.Content==Label35.Content & Label34.Content==Label36.Content & Label14.Content==Label37.Content)
            {
                return true;
            }
            else if (Label41.Content!="" & Label41.Content==Label42.Content & Label41.Content==Label43.Content & Label41.Content==Label44.Content)
            {
                return true;
            }
            else if (Label42.Content!="" & Label42.Content==Label43.Content & Label42.Content==Label44.Content & Label42.Content==Label45.Content)
            {
                return true;
            }
            else if (Label43.Content!="" & Label43.Content==Label44.Content & Label43.Content==Label45.Content & Label43.Content==Label46.Content)
            {
                return true;
            }
            else if (Label44.Content!="" & Label44.Content==Label45.Content & Label44.Content==Label46.Content & Label44.Content==Label47.Content)
            {
                return true;
            }
            else if (Label51.Content!="" & Label51.Content==Label52.Content & Label51.Content==Label53.Content & Label51.Content==Label54.Content)
            {
                return true;
            }
            else if (Label52.Content!="" & Label52.Content==Label53.Content & Label52.Content==Label55.Content & Label52.Content==Label55.Content)
            {
                return true;
            }
            else if (Label53.Content!="" & Label53.Content==Label54.Content & Label53.Content==Label55.Content & Label53.Content==Label56.Content)
            {
                return true;
            }
            else if (Label54.Content!="" & Label54.Content==Label55.Content & Label54.Content==Label56.Content & Label54.Content==Label57.Content)
            {
                return true;
            }
            else if (Label61.Content!="" & Label61.Content==Label62.Content & Label61.Content==Label63.Content & Label61.Content==Label64.Content)
            {
                return true;
            }
            else if (Label62.Content!="" & Label62.Content==Label63.Content & Label62.Content==Label64.Content & Label62.Content==Label65.Content)
            {
                return true;
            }
            else if (Label63.Content!="" & Label63.Content==Label64.Content & Label63.Content==Label65.Content & Label63.Content==Label66.Content)
            {
                return true;
            }
            else if (Label64.Content!="" & Label64.Content==Label65.Content & Label64.Content==Label66.Content & Label64.Content==Label67.Content)
            {
                return true;
            }
            else if (Label11.Content!="" & Label11.Content==Label21.Content & Label11.Content==Label31.Content & Label11.Content==Label41.Content)
            {
                return true;
            }
            else if (Label21.Content!="" & Label21.Content==Label31.Content & Label21.Content==Label41.Content & Label21.Content==Label51.Content)
            {
                return true;
            }
            else if (Label31.Content!="" & Label31.Content==Label41.Content & Label31.Content==Label51.Content & Label51.Content==Label61.Content)
            {
                return true;
            }
            else if (Label12.Content!="" & Label12.Content==Label22.Content & Label12.Content==Label32.Content & Label12.Content==Label42.Content)
            {
                return true;
            }
            else if (Label22.Content!="" & Label22.Content==Label32.Content & Label22.Content==Label42.Content & Label22.Content==Label52.Content)
            {
                return true;
            }
            else if (Label32.Content!="" & Label32.Content==Label42.Content & Label32.Content==Label52.Content & Label32.Content==Label62.Content)
            {
                return true;
            }
            else if (Label13.Content!="" & Label13.Content==Label23.Content & Label13.Content==Label33.Content & Label13.Content==Label43.Content)
            {
                return true;
            }
            else if (Label23.Content!="" & Label23.Content==Label33.Content & Label23.Content==Label43.Content & Label23.Content==Label53.Content)
            {
                return true;
            }
            else if (Label33.Content!="" & Label33.Content==Label43.Content & Label33.Content==Label53.Content & Label33.Content==Label63.Content)
            {
                return true;
            }
            else if (Label14.Content!="" & Label14.Content==Label24.Content & Label14.Content==Label34.Content & Label14.Content==Label44.Content)
            {
                return true;
            }
            else if (Label24.Content!="" & Label24.Content==Label34.Content & Label24.Content==Label44.Content & Label24.Content==Label54.Content)
            {
                return true;
            }
            else if (Label34.Content!="" & Label34.Content==Label44.Content & Label34.Content==Label54.Content & Label34.Content==Label64.Content)
            {
                return true;
            }
            else if (Label15.Content!="" & Label15.Content==Label25.Content & Label15.Content==Label35.Content & Label15.Content==Label45.Content)
            {
                return true;
            }
            else if (Label25.Content!="" & Label25.Content==Label35.Content & Label25.Content==Label45.Content & Label25.Content==Label55.Content)
            {
                return true;
            }
            else if (Label35.Content!="" & Label35.Content==Label45.Content & Label35.Content==Label45.Content & Label35.Content==Label55.Content)
            {
                return true;
            }
            else if (Label16.Content!="" & Label16.Content==Label26.Content & Label16.Content==Label36.Content & Label16.Content==Label46.Content)
            {
                return true;
            }
            else if (Label26.Content!="" & Label26.Content==Label36.Content & Label26.Content==Label46.Content & Label26.Content==Label56.Content)
            {
                return true;
            }
            else if (Label36.Content!="" & Label36.Content==Label46.Content & Label36.Content==Label56.Content & Label36.Content==Label66.Content)
            {
                return true;
            }
            else if (Label17.Content!="" & Label17.Content==Label27.Content & Label17.Content==Label37.Content & Label17.Content==Label47.Content)
            {
                return true;
            }
            else if (Label27.Content!="" & Label27.Content==Label37.Content & Label27.Content==Label47.Content & Label27.Content==Label57.Content)
            {
                return true;
            }
            else if (Label37.Content!="" & Label37.Content==Label47.Content & Label37.Content==Label57.Content & Label37.Content==Label67.Content)
            {
                return true;
            }
            else if (Label51.Content!="" & Label51.Content==Label52.Content & Label51.Content==Label53.Content & Label51.Content==Label54.Content)
            {
                return true;
            }
            else if (Label11.Content!="" & Label11.Content==Label22.Content & Label11.Content==Label33.Content & Label11.Content==Label44.Content)
            {
                return true;
            }
            else if (Label22.Content!="" & Label22.Content==Label33.Content & Label22.Content==Label44.Content & Label22.Content==Label55.Content)
            {
                return true;
            }
            else if (Label33.Content!="" & Label33.Content==Label44.Content & Label33.Content==Label55.Content & Label33.Content==Label66.Content)
            {
                return true;
            }
            else if (Label21.Content!="" & Label21.Content==Label32.Content & Label21.Content==Label43.Content & Label21.Content==Label54.Content)
            {
                return true;
            }
            else if (Label32.Content!="" & Label32.Content==Label43.Content & Label32.Content==Label54.Content & Label32.Content==Label65.Content)
            {
                return true;
            }
            else if (Label31.Content!="" & Label31.Content==Label42.Content & Label31.Content==Label53.Content & Label31.Content==Label64.Content)
            {
                return true;
            }
            else if (Label12.Content!="" & Label12.Content==Label23.Content & Label12.Content==Label34.Content & Label12.Content==Label45.Content)
            {
                return true;
            }
            else if (Label23.Content!="" & Label23.Content==Label34.Content & Label23.Content==Label45.Content & Label23.Content==Label56.Content)
            {
                return true;
            }
            else if (Label34.Content!="" & Label34.Content==Label45.Content & Label34.Content==Label56.Content & Label34.Content==Label67.Content)
            {
                return true;
            }
            else if (Label13.Content!="" & Label13.Content==Label24.Content & Label13.Content==Label35.Content & Label13.Content==Label46.Content)
            {
                return true;
            }
            else if (Label24.Content!="" & Label24.Content==Label35.Content & Label24.Content==Label46.Content & Label24.Content==Label57.Content)
            {
                return true;
            }
            else if (Label14.Content!="" & Label14.Content==Label25.Content & Label14.Content==Label36.Content & Label14.Content==Label47.Content)
            {
                return true;
            }
            else if (Label14.Content!="" & Label14.Content==Label23.Content & Label14.Content==Label32.Content & Label14.Content==Label41.Content)
            {
                return true;
            }
            else if (Label15.Content!="" & Label15.Content==Label24.Content & Label15.Content==Label33.Content & Label15.Content==Label42.Content)
            {
                return true;
            }
            else if (Label24.Content!="" & Label24.Content==Label33.Content & Label24.Content==Label42.Content & Label24.Content==Label51.Content)
            {
                return true;
            }
            else if (Label16.Content!="" & Label16.Content==Label25.Content & Label16.Content==Label34.Content & Label16.Content==Label43.Content)
            {
                return true;
            }
            else if (Label25.Content!="" & Label25.Content==Label34.Content & Label25.Content==Label43.Content & Label25.Content==Label52.Content)
            {
                return true;
            }
            else if (Label34.Content!="" & Label34.Content==Label43.Content & Label34.Content==Label52.Content & Label34.Content==Label61.Content)
            {
                return true;
            }
            else if (Label17.Content!="" & Label17.Content==Label26.Content & Label17.Content==Label35.Content & Label17.Content==Label44.Content)
            {
                return true;
            }
            else if (Label26.Content!="" & Label26.Content==Label35.Content & Label26.Content==Label44.Content & Label26.Content==Label53.Content)
            {
                return true;
            }
            else if (Label35.Content!="" & Label35.Content==Label44.Content & Label35.Content==Label53.Content & Label35.Content==Label62.Content)
            {
                return true;
            }
            else if (Label27.Content!="" & Label27.Content==Label36.Content & Label27.Content==Label45.Content & Label27.Content==Label54.Content)
            {
                return true;
            }
            else if (Label36.Content!="" & Label36.Content==Label45.Content & Label36.Content==Label54.Content & Label36.Content==Label63.Content)
            {
                return true;
            }
            else if (Label51.Content!="" & Label51.Content==Label52.Content & Label51.Content==Label53.Content & Label51.Content==Label54.Content)
            {
                return true;
            }
            else if (Label37.Content!="" & Label37.Content==Label46.Content & Label51.Content==Label53.Content & Label51.Content==Label54.Content)
            {
                return true;
            }

            return false;
        }

        public void Clear()
        {
            
            Label11.Content="";
            Label12.Content="";
            Label13.Content="";
            Label14.Content="";
            Label15.Content="";
            Label16.Content="";
            Label17.Content="";
            Label21.Content="";
            Label22.Content="";
            Label23.Content="";
            Label24.Content="";
            Label25.Content="";
            Label26.Content="";
            Label27.Content="";
            Label31.Content="";
            Label32.Content="";
            Label33.Content="";
            Label34.Content="";
            Label35.Content="";
            Label36.Content="";
            Label37.Content="";
            Label41.Content="";
            Label42.Content="";
            Label43.Content="";
            Label44.Content="";
            Label45.Content="";
            Label46.Content="";
            Label47.Content="";
            Label51.Content="";
            Label52.Content="";
            Label53.Content="";
            Label54.Content="";
            Label55.Content="";
            Label56.Content="";
            Label57.Content="";
            Label61.Content="";
            Label62.Content="";
            Label63.Content="";
            Label64.Content="";
            Label65.Content="";
            Label66.Content="";
            Label67.Content="";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Clear();
        }
    }
}
