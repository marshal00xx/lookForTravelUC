﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lookForTravelUC
{
    public partial class mainUC: UserControl
    {
        public mainUC()
        {
            InitializeComponent();
        }
        private void mainUC_Load(object sender, EventArgs e) {
            String[] listOfCities = new string[] {
                "city", "Casablanca", "El Kelaa des Srarhna", "Fès", "Tangier", "Marrakech", "Sale",
                "Rabat", "Meknès", "Kenitra", "Agadir", "Oujda-Angad", "Tétouan", "Taourirt", "Temara",
                "Safi", "Laâyoune", "Mohammedia", "Kouribga", "Béni Mellal", "El Jadid", "Ait Melloul",
                "Nador", "Taza", "Settat", "Barrechid", "Al Khmissat", "Inezgane", "Ksar El Kebir", "Larache",
                "Guelmim", "Khénifra", "Berkane", "Bouskoura", "Al Fqih Ben Çalah", "Oued Zem", "Sidi Slimane",
                "Errachidia", "Guercif", "Oulad Teïma", "Ad Dakhla", "Ben Guerir", "Wislane", "Tiflet", "Lqoliaa",
                "Taroudannt", "Sefrou", "Essaouira", "Fnidq", "Ait Ali", "Sidi Qacem", "Tiznit", "Moulay Abdallah",
                "Tan-Tan", "Warzat", "Youssoufia", "Sa’ada", "Martil", "Aïn Harrouda", "Skhirate", "Ouezzane",
                "Sidi Yahya Zaer", "Benslimane", "Al Hoceïma", "Beni Enzar", "M’diq", "Sidi Bennour", "Midalt",
                "Azrou", "Ain El Aouda", "Beni Yakhlef", "Semara", "Ad Darwa", "Al Aaroui", "Qasbat Tadla", "Boujad",
                "Jerada", "Chefchaouene", "Mrirt", "Sidi Mohamed Lahmar", "Tineghir", "El Aïoun", "Azemmour", "Temsia",
                "Zoumi", "Laouamra", "Zagora", "Ait Ourir", "Sidi Bibi", "Aziylal", "Sidi Yahia El Gharb", "Biougra",
                "Taounate", "Bouznika", "Aourir", "Zaïo", "Aguelmous", "El Hajeb", "Mnasra", "Mediouna", "Zeghanghane",
                "Imzouren", "Loudaya", "Oulad Zemam", "Bou Ahmed", "Tit Mellil", "Arbaoua", "Douar Oulad Hssine",
                "Bahharet Oulad Ayyad", "Mechraa Bel Ksiri", "Mograne", "Dar Ould Zidouh", "Asilah", "Demnat",
                "Lalla Mimouna", "Fritissa", "Arfoud", "Tameslouht", "Bou Arfa", "Sidi Smai’il", "Taza",
                "Souk et Tnine Jorf el Mellah", "Mehdya", "Oulad Hammou", "Douar Oulad Aj-jabri", "Aïn Taoujdat",
                "Dar Bel Hamri", "Chichaoua", "Tahla", "Bellaa", "Oulad Yaïch", "Ksebia", "Tamorot", "Moulay Bousselham",
                "Sabaa Aiyoun", "Bourdoud", "Aït Faska", "Boureït", "Lamzoudia", "Oulad Said", "Missour", "Ain Aicha",
                "Zawyat ech Cheïkh", "Bouknadel", "El Ghiate", "Safsaf", "Ouaoula", "Douar Olad. Salem", "Oulad Tayeb",
                "Echemmaia Est", "Oulad Barhil", "Douar ’Ayn Dfali", "Setti Fatma", "Skoura", "Douar Ouled Ayad",
                "Zawyat an Nwaçer", "Khenichet-sur Ouerrha","Ayt Mohamed", "Gueznaia", "Oulad Hassoune", "Bni Frassen",
                "Tifariti", "Zawit Al Bour",
            };
            destCityCB.Items.AddRange(listOfCities);
            origineCityCB.Items.AddRange(listOfCities);
        }
        private void seachBtn_Click(object sender, EventArgs e) {

        }

        
    }
}